namespace SIM.DataMapper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using SIM.Manager;
    using System.Data;
    using HM.MMS.AR.Server.BusinessEntity.Ordenes.Radio;
    using HM.MMS.AR.Server.BusinessEntity.Ordenes;
    using HM.MMS.Core.Server.BusinessEntity.Ordenes.RD;
    using HM.MMS.Core.Server.BusinessEntity.Seguridad;
    using HM.Comun.SolutionEntityFramework;

    /// <summary>
    /// Mapea los valores al objeto Radio.
    /// </summary>
    public class OrdenRadioDataMapper : IDisposable
    {
        #region Propiedades

        private bool _disposed = false;
        public DataTable _dtDatos;
        private OrdenRadio _ordenRadio;
        private List<OrdenRadio> _listOrdenRadio = new List<OrdenRadio>();
        public DataTable dtAvisosInsertados;
        static DataTable dtReturn;

        private SolutionEntityList<Cuna> lstCunas = new SolutionEntityList<Cuna>();

        public int idCampaniaMMS;
        public int idSubCampanaMms;
        public int mmsCodPais;
        public int mmsCodUsuario;
        public int mmsCodCompania;
        private int lastCodSpot;

        #endregion

        #region Constructor

        public OrdenRadioDataMapper(DataTable _value, int idCampaniaMMS, int idSubCampanaMms, int mmsCodPais, int mmsCodUsuario, int mmsCodCompania)
        {
            //Incializa los valores necesarios para realizar la inserccione de ordenes.
            this._dtDatos = _value;
            this.idCampaniaMMS = idCampaniaMMS;
            this.idSubCampanaMms = idSubCampanaMms;
            this.mmsCodPais = mmsCodPais;
            this.mmsCodUsuario = mmsCodUsuario;
            this.mmsCodCompania = mmsCodCompania;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Setea los valores de la Orden Radio para luego ser insertados.
        /// </summary>
        public DataTable SetNewOrdenRadioObject()
        {
            try
            {
                var results = new Dictionary<OrdenEverest, int?>();

                for (int i = 0; i < this._dtDatos.Rows.Count; i++)
                {
                    this._ordenRadio = new OrdenRadio();
                    long? _codSpot = (long?)this._dtDatos.Rows[i]["CODIGOSPOT"];
                    long? _codSpotDetalle = (long?)this._dtDatos.Rows[i]["CODIGOSPOTDETALLE"];
                    string _idTema = this._dtDatos.Rows[i]["ID_TEMA"].ToString();
                    int _codPrograma = int.Parse(this._dtDatos.Rows[i]["CODIGOPROGRAMA"].ToString());
                    int _soporte = int.Parse(this._dtDatos.Rows[i]["CODIGOSOPORTE"].ToString());
                    DateTime _fechaSpot = (DateTime)this._dtDatos.Rows[i]["F_SPOT"];
                    int _duracion = int.Parse(this._dtDatos.Rows[i]["DURACION"].ToString());
                    if (!ValidateOrden(_codSpot, _fechaSpot, _duracion))
                    {
                        this._ordenRadio = new OrdenRadio();

                        this._ordenRadio.EsOrdenEverest = true;
                        this._ordenRadio.Material = this._dtDatos.Rows[i]["MATERIAL"].ToString();
                        this._ordenRadio.CodigoCompania = int.Parse(this._dtDatos.Rows[i]["CODIGOCOMPANIA"].ToString());
                        this._ordenRadio.CodigoConvenio = (this._dtDatos.Rows[i]["CODIGOCONVENIO"].ToString()) == "" ? 0 : int.Parse(this._dtDatos.Rows[i]["CODIGOCONVENIO"].ToString());
                        this._ordenRadio.CodigoOrden = 0;
                        this._ordenRadio.Monitoreada = false;
                        this._ordenRadio.TituloAnuncio = "Test";

                        //Seteo los valores de OrdenEverest.
                        this._ordenRadio.OrdenEverest = new OrdenEverest(null, null);
                        this._ordenRadio.OrdenEverest.CodigoSpot = (long?)this._dtDatos.Rows[i]["CODIGOSPOT"];
                        this._ordenRadio.OrdenEverest.CodigoSpotDetalle = (long?)this._dtDatos.Rows[i]["CODIGOSPOTDETALLE"];
                        this._ordenRadio.OrdenEverest.CodigoCampania = int.Parse(this._dtDatos.Rows[i]["CODIGOCAMPANIA"].ToString());
                        this._ordenRadio.OrdenEverest.CodigoEjercicio = (int)this._dtDatos.Rows[i]["CODIGOEJERCICIO"];
                        this._ordenRadio.OrdenEverest.CodigoSistema = (int)this._dtDatos.Rows[i]["CODIGOSISTEMA"];

                        //seteo una nueva orden interna.
                        this.SetValuesOrdenRadio(this._ordenRadio, i);

                        this._ordenRadio.CodigoCompania = int.Parse(this._dtDatos.Rows[i]["CODIGOCOMPANIA"].ToString());

                        this.lastCodSpot = i;
                        //agrego el nuevo item a la lista.
                        this._listOrdenRadio.Add(this._ordenRadio);
                    }
                    
                }
                    
                results = OrdenRadioManager.insertar_spotRadio(this._listOrdenRadio, this.idCampaniaMMS, this.idSubCampanaMms, this.mmsCodPais, this.mmsCodUsuario, this.mmsCodCompania);
                dtReturn = vueltaAvisosInsertados(results);
                this.Dispose(true);
                return dtReturn;

            }
            catch (ArgumentNullException e)
            {
                this.Dispose(true);
                throw new ArgumentNullException(e.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //LC 24/06/2014 Se agrego el spot detalle a la validacion
        private bool ValidateOrden(long? codSpot, DateTime fSpot, int duracion)
        {
            bool _return = false;
            long? idSpot = long.Parse(this._dtDatos.Rows[this.lastCodSpot]["CODIGOSPOT"].ToString());

            if (this._listOrdenRadio.Count >= 1)
            {
                //JJP 15062010
                //Busco que en la lista de órdenes ya existentes no esté dada de alta una orden
                //con el mismo código de spot, el mismo mes en la fecha y la misma duración
                //LC 24/06/2014 Se agrego el spot detalle a la validacion
                IEnumerable<OrdenRadio> lOrden = _listOrdenRadio.Where(x => x.OrdenInterna.FechaEjecucion.Month == fSpot.Month 
                    && x.OrdenEverest.CodigoSpot == codSpot && x.OrdenInterna.ValorAnuncio == duracion);

                if (lOrden.Count() > 0)
                {
                    _return = true;
                }
                else
                {
                    _return = false;
                }
                
                //Código anterior 15062010
                //if (codSpot == idSpot && fSpot.Month == fechaSpot.Month)
                //{
                //    _return = true;
                //}
                //else 
                //{
                //    _return = false;
                //}
                 
            }
            return _return;
        }

        /// <summary>
        /// Setea los valores de la orden Interna de Radio.
        /// </summary>
        /// <param name="order">Objecto OrdenRadio</param>
        /// <param name="i">index del DataTable</param>
        /// <returns>Objecto OrdenRadio con los valores seteados.</returns>
        private OrdenRadio SetValuesOrdenRadio(OrdenRadio order, int i)
        {
            try
            {
                order.OrdenInterna = new OrdenRD();
                order.OrdenInterna.Cunas = new SolutionEntityList<Cuna>();
                order.OrdenInterna.CodigoUsuario = int.Parse(this._dtDatos.Rows[i]["CODIGOUSUARIO"].ToString());
                order.OrdenInterna.CodigoCampana = this.idCampaniaMMS;//int.Parse(this._dtDatos.Rows[i]["CODIGOCAMPANA"].ToString());
                //LC 20/08/2014 set codigo sub campania
                order.OrdenInterna.CodigoSubcampana = this.idSubCampanaMms;// int.Parse(this._dtDatos.Rows[i]["CODIGOSUBCAMPANA"].ToString());
                order.OrdenInterna.CodigoPresupuesto = int.Parse(this._dtDatos.Rows[i]["CODIGOPRESUPUESTO"].ToString());
                order.OrdenInterna.CodigoCliente = int.Parse(this._dtDatos.Rows[i]["CODIGOCLIENTE"].ToString());
                order.OrdenInterna.CodigoCompania = int.Parse(this._dtDatos.Rows[i]["CODIGOCOMPANIA"].ToString());
                order.OrdenInterna.CodigoDelegacion = int.Parse(this._dtDatos.Rows[i]["CODIGODELEGACION"].ToString());
                order.OrdenInterna.CodigoMaterial = int.Parse(this._dtDatos.Rows[i]["CODIGOMATERIAL"].ToString());
                order.OrdenInterna.CodigoMedio = int.Parse(this._dtDatos.Rows[i]["CODIGOMEDIO"].ToString());
                order.OrdenInterna.CodigoOrigenOrden = int.Parse(this._dtDatos.Rows[i]["CODIGOORIGEN"].ToString()); //3 es Everest.
                order.OrdenInterna.CodigoProducto = int.Parse(this._dtDatos.Rows[i]["CODIGOPRODUCTO"].ToString());
                order.OrdenInterna.CodigoSoporte = int.Parse(this._dtDatos.Rows[i]["CODIGOSOPORTE"].ToString());
                order.OrdenInterna.FechaCreacion = (DateTime)this._dtDatos.Rows[i]["FECHACREACION"];
                order.OrdenInterna.FechaEjecucion = (DateTime)this._dtDatos.Rows[i]["FECHACREACION"];
                //Warning: Jsperk - Verificar el valor GRP, porque retorna dos valores GRP y en el objeto hay solo uno.
                order.OrdenInterna.GRP = (decimal)this._dtDatos.Rows[i]["GRP_PREVISTO"];
                order.OrdenInterna.ImporteCompraDivisa = decimal.Parse(this._dtDatos.Rows[i]["IMPORTECOMPRA"].ToString());
                order.OrdenInterna.ImporteNetoCompraOrden = decimal.Parse(this._dtDatos.Rows[i]["IMPORTECOMPRANETO"].ToString());
                order.OrdenInterna.ImporteVentaDivisa = decimal.Parse(this._dtDatos.Rows[i]["IMPORTEVENTA"].ToString());
                order.OrdenInterna.ImporteNetoVentaOrden = decimal.Parse(this._dtDatos.Rows[i]["IMPORTEVENTANETO"].ToString());
                order.OrdenInterna.ImporteCompraBruto = decimal.Parse(this._dtDatos.Rows[i]["IMPORTECOMPRA"].ToString());
                order.OrdenInterna.ImporteVentaBruto = decimal.Parse(this._dtDatos.Rows[i]["IMPORTEVENTA"].ToString());
                order.OrdenInterna.ImporteCompraOrden = decimal.Parse(this._dtDatos.Rows[i]["IMPORTECOMPRA"].ToString());
                order.OrdenInterna.ImporteVentaOrden = decimal.Parse(this._dtDatos.Rows[i]["IMPORTEVENTA"].ToString());
                order.OrdenInterna.ImporteCompraBruto = decimal.Parse(this._dtDatos.Rows[i]["IMPORTECOMPRA"].ToString());
                order.OrdenInterna.ImporteVentaBruto = decimal.Parse(this._dtDatos.Rows[i]["IMPORTEVENTA"].ToString());

                //Setea la lista de importes.
                var o = order.OrdenInterna;

                SolutionEntityList<Importe> sImportes = new SolutionEntityList<Importe>();
                sImportes.Add(new Importe(o.CodigoOrden, o.CodigoCompania, o.ImporteCompraBruto.Value, o.ImporteCompraBruto.Value * o.CambioAplicado.Value, Importe.CODIGO_IMPORTE_COMPRA_BRUTO), this.mmsCodUsuario.ToString());
                sImportes.Add(new Importe(o.CodigoOrden, o.CodigoCompania, o.ImporteNetoCompraOrden.Value, o.ImporteNetoCompraOrden.Value * o.CambioAplicado.Value, Importe.CODIGO_IMPORTE_COMPRA_NETO), this.mmsCodUsuario.ToString());
                sImportes.Add(new Importe(o.CodigoOrden, o.CodigoCompania, o.ImporteVentaBruto.Value, o.ImporteVentaBruto.Value * o.CambioAplicado.Value, Importe.CODIGO_IMPORTE_VENTA_BRUTO), this.mmsCodUsuario.ToString());
                sImportes.Add(new Importe(o.CodigoOrden, o.CodigoCompania, o.ImporteNetoVentaOrden.Value, o.ImporteNetoVentaOrden.Value * o.CambioAplicado.Value, Importe.CODIGO_IMPORTE_VENTA_NETO), this.mmsCodUsuario.ToString());
                sImportes.Add(new Importe(o.CodigoOrden, o.CodigoCompania, o.ImporteCompraOrden.Value, o.ImporteCompraDivisa.HasValue ? o.ImporteCompraDivisa.Value : 0, Importe.CODIGO_TARIFA_BASE_COMPRA), this.mmsCodUsuario.ToString());
                sImportes.Add(new Importe(o.CodigoOrden, o.CodigoCompania, o.ImporteVentaOrden.Value, o.ImporteVentaDivisa.HasValue ? o.ImporteVentaDivisa.Value : 0, Importe.CODIGO_TARIFA_BASE_VENTA), this.mmsCodUsuario.ToString());
                sImportes.Add(new Importe(o.CodigoOrden, o.CodigoCompania, o.ImporteTranscripcion.HasValue ? o.ImporteTranscripcion.Value : 0, o.ImporteTranscripcionDivisa.HasValue ? o.ImporteTranscripcionDivisa.Value : 0, Importe.CODIGO_TRANSCRIPCION), this.mmsCodUsuario.ToString());
                order.OrdenInterna.Importes = sImportes;
                
                //Setea los valores a Programa Radio.
                order.OrdenInterna.ProgramaRadio = this.SetPrograma(i);

                //Warning Jsperk JPerazzo : Verifical el valor de cambio real.
                order.OrdenInterna.CambioReal = 1;

                //Valor de duracion.
                order.OrdenInterna.ValorAnuncio = int.Parse(this._dtDatos.Rows[i]["DURACION"].ToString());
                
                order.OrdenInterna.CodigoTipoOrden = 1;
                order.OrdenInterna.IndicadorEstado = 1;

                string horaInicio = this._dtDatos.Rows[i]["HORAINICIO"].ToString().Replace(":","");
                string horaFin = this._dtDatos.Rows[i]["HORAFIN"].ToString().Replace(":", "");

                //valores de testeo.
                order.OrdenInterna.DescripcionPrograma = this._dtDatos.Rows[i]["PROGRAMADESCRIPCION"].ToString();
                order.OrdenInterna.IndicadorPlanificacion = 1;
                order.OrdenInterna.HoraDesde = int.Parse(horaInicio);
                order.OrdenInterna.HoraHasta = int.Parse(horaFin);
                order.OrdenInterna.HoraDesdeFranja = 0;
                order.OrdenInterna.HoraHastaFranja = 260000;

                string tempTema = this._dtDatos.Rows[i]["ID_TEMA"].ToString();
                this.SetCunas(order.OrdenInterna.FechaCreacion.Month, (long)this._dtDatos.Rows[i]["CODIGOSPOT"], order.OrdenInterna.ValorAnuncio);
                order.OrdenInterna.Cunas = this.lstCunas;
                
                //dcaime jperazzo 30/0/2010
                int cantidad = 0;
                foreach (var cuna in lstCunas)
                {                    
                    cantidad += Convert.ToInt32(((Cuna)cuna.BusinessEntity).NumInsercionesCuna);
                } // foreach

                order.OrdenInterna.NoInserciones = cantidad;
                order.OrdenInterna.CodigoMoneda = 5; //"Peso Argentino"
                order.OrdenInterna.CodigoMonedaDivisa = 5;
                order.OrdenInterna.CambioOficial = 1;
                order.OrdenInterna.CambioAplicado = 1;
                order.OrdenInterna.CodigoPais = this.mmsCodPais; //Argentina.
                order.OrdenInterna.CodigoAnuncio = 1;
                order.OrdenInterna.NumeroInsercionOrden = 0;
                order.OrdenInterna.ImporteTarifaDivisa = decimal.Parse(this._dtDatos.Rows[i]["IMPORTEVENTA"].ToString());
                order.OrdenInterna.ImporteTarifaCompraDivisa = decimal.Parse(this._dtDatos.Rows[i]["IMPORTECOMPRA"].ToString());
                order.OrdenInterna.ImporteTarifaVentaDivisa = decimal.Parse(this._dtDatos.Rows[i]["IMPORTEVENTA"].ToString());
                order.OrdenInterna.ImporteTarifaVentaOrden = decimal.Parse(this._dtDatos.Rows[i]["IMPORTEVENTA"].ToString());
                order.OrdenInterna.ImporteTarifaCompraOrden = decimal.Parse(this._dtDatos.Rows[i]["IMPORTECOMPRA"].ToString());
                order.OrdenInterna.ImporteTarifaOrden = decimal.Parse(this._dtDatos.Rows[i]["IMPORTEVENTA"].ToString());

                //Setea los descuentos correspondientes a la orden.
                this._ordenRadio.OrdenInterna.Descuentos = this.SetDescuentos(i);
               
                //Tabla Planificación
                //WARNING : Jsperk - Consultar con GW si este valor hace referencia a "GRP_Planificacion" que devuelve el SP.
                order.OrdenInterna.CodigoPlanificacion = 0; //Mucho muy importante.

                return order;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Retorna una instancion de Usuario, verificar de que manera se debe implementar.
        /// </summary>
        /// <returns></returns>
        protected Usuario GetLoggedUser(int codUsuario)
        {
            return new Usuario() { CodCompaniaActual = 35, CodPaisActual = 32, CodUsuario = codUsuario };
        }

        /// <summary>
        /// Setea el objeto descuentos con los valores correspondientes.
        /// </summary>
        /// <param name="i">Indice del DataTable</param>
        /// <returns>Lista de descuentoRecargo</returns>
        private SolutionEntityList<DescuentoRecargo> SetDescuentos(int i)
        {
            
            //AG ID 16480 27/08/2010 Modificacion Descuentos Venta y Compras ------------------------------------------------------------------------------------------------------------------------------------------
            SolutionEntityList<DescuentoRecargo> listDesc = new SolutionEntityList<DescuentoRecargo>();
            int f = 1;
            int g = 0;

            for (int j = 1; j < 6; j++)
            {
                string colName = "DCTO" + f;  // Descuento de Venta
                 DescuentoRecargo newDescuento = new DescuentoRecargo();
                newDescuento.CodigoTipoUso = 2;
                newDescuento.CodigoTipoDescuento = 2; // TIPO_GENERICO_VENTA = 2;
                newDescuento.Porcentaje = decimal.Parse(this._dtDatos.Rows[i][colName].ToString());
                newDescuento.Descripcion = "Dt/Rec";
                newDescuento.Indicador = -1;
                newDescuento.Aplicacion = 0;
                newDescuento.CodDtoRec = j - 1;
                listDesc.Add(newDescuento, this.mmsCodUsuario.ToString());
                f = f + 1;
                g = j;
            }
            f = 0;
            for (int j = 1; j < 6; j++)
            {
                g = g + 1;
                f = f + 1;
                string colName = "DCTOC" + f;  //Descuento de Compras
                 DescuentoRecargo newDescuento = new DescuentoRecargo();
                newDescuento.CodigoTipoUso = 1;
                newDescuento.CodigoTipoDescuento = 1; // TIPO_GENERICO_COMPRA  = 1;
                newDescuento.Porcentaje = decimal.Parse(this._dtDatos.Rows[i][colName].ToString());
                newDescuento.Descripcion = "Dt/Rec";
                newDescuento.Indicador = -1;
                newDescuento.Aplicacion = 0;
                newDescuento.CodDtoRec = g - 1;
                listDesc.Add(newDescuento, this.mmsCodUsuario.ToString());
            }
            f = 0;
            g = 0;

            // AG 27/08/2010 Codigo anterior -------------------------------------------------------------------------------------------------------------------------
            ////SolutionEntityList<DescuentoRecargo> listDesc = new SolutionEntityList<DescuentoRecargo>();
            ////int f = 1;
            ////for (int j = 1; j < 11; j++)
            ////{
            ////    DescuentoRecargo newDescuento = new DescuentoRecargo();
            ////    string colName = "DCTO" + f;
            ////    if (j >= 6)
            ////    {
            ////        colName = "DCTO" + f;
            ////        newDescuento.CodigoTipoUso = 1;
            ////        newDescuento.CodigoTipoDescuento = 1; // HACK - Jsperk - TIPO_GENERICO_COMPRA = 1; TIPO_GENERICO_COMPRAVENTA = 3; TIPO_GENERICO_VENTA = 2;
            ////    }
            ////    else
            ////    {
            ////        newDescuento.CodigoTipoUso = 2;
            ////        newDescuento.CodigoTipoDescuento = 2; // HACK - Jsperk - TIPO_GENERICO_COMPRA = 1; TIPO_GENERICO_COMPRAVENTA = 3; TIPO_GENERICO_VENTA = 2;
            ////    }

            ////    newDescuento.Porcentaje = decimal.Parse(this._dtDatos.Rows[i][colName].ToString());
            ////    newDescuento.Descripcion = "Dt/Rec";
            ////    newDescuento.Indicador = -1;
            ////    newDescuento.Aplicacion = 0;
            ////    newDescuento.CodDtoRec = j - 1;
            ////    listDesc.Add(newDescuento, this.mmsCodUsuario.ToString());
            ////    if (f == 5)
            ////        f = 0;
            ////    f = f + 1;
            //}

            return listDesc;
        }

        /// <summary>
        /// Set de los valores en el objeto ProgramaRd.
        /// </summary>
        /// <param name="i">Index.</param>
        /// <returns>ProgramaRD con los valores seteados.</returns>
        private ProgramaRD SetPrograma(int i)
        {
            try
            {
                //Warning: Jsperk - Verificar si faltan valores a setear.
                ProgramaRD _programa = new ProgramaRD();

                _programa.CodigoMedio = int.Parse(this._dtDatos.Rows[i]["CODIGOMEDIO"].ToString()); ;
                _programa.CodigoPrograma = int.Parse(this._dtDatos.Rows[i]["CODIGOPROGRAMA"].ToString());
                _programa.CodSoporte = int.Parse(this._dtDatos.Rows[i]["CODIGOSOPORTE"].ToString());
                _programa.Duracion = int.Parse(this._dtDatos.Rows[i]["DURACION"].ToString());
                _programa.DescPrograma = this._dtDatos.Rows[i]["PROGRAMADESCRIPCION"].ToString();
                _programa.DescripcionAbreviadaPrograma = this._dtDatos.Rows[i]["PROGRAMADESCRIPCION"].ToString();

                return _programa;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// RECORREMOS EL DICCIONARIO Y LLENAMOS UN DATATABLE QUE DEVOLVEMOS A EVEREST
        /// SE AGREGA SOLO LOS SPOTS_DETALLE QUE TENGAN ASOCIADOS UNA ORDEN DE MMS
        /// </summary>
        /// <param name="lstOrdenesInsertadas"></param>
        /// <returns>DT</returns>
        public DataTable vueltaAvisosInsertados(Dictionary<OrdenEverest, int?> lstOrdenesInsertadas)
        {
            dtAvisosInsertados = new DataTable();
            formatearTabla(dtAvisosInsertados);
            DataRow drAviso = null;

            //JJP 20/09/2010
            var avisoAux = new KeyValuePair<OrdenEverest, int?>();
            for (int i = 0; i < this._dtDatos.Rows.Count; i++)
            {
                long? codSpot = (long?)this._dtDatos.Rows[i]["CODIGOSPOT"];
                //LC 23/06/2014 se agrega el codigo spopt detalle para buscar el codigo de orden de MMS
                long? codSpotDetalle = (long?)this._dtDatos.Rows[i]["CODIGOSPOTDETALLE"];

                var aviso = lstOrdenesInsertadas.FirstOrDefault(x => x.Key.CodigoSpot == codSpot && x.Key.CodigoSpotDetalle == codSpotDetalle);
                if (aviso.Key != null)
                {
                    drAviso = dtAvisosInsertados.NewRow();
                    drAviso["id_spot"] = (long?)this._dtDatos.Rows[i]["CODIGOSPOT"];
                    drAviso["id_spot_detalle"] = (long?)this._dtDatos.Rows[i]["CODIGOSPOTDETALLE"];
                    drAviso["id_orden_mms"] = aviso.Value;
                    dtAvisosInsertados.Rows.Add(drAviso);
                    avisoAux = aviso;
                }
                else if (avisoAux.Key != null)
                {
                    drAviso = dtAvisosInsertados.NewRow();
                    drAviso["id_spot"] = (long?)this._dtDatos.Rows[i]["CODIGOSPOT"];
                    drAviso["id_spot_detalle"] = (long?)this._dtDatos.Rows[i]["CODIGOSPOTDETALLE"];
                    drAviso["id_orden_mms"] = avisoAux.Value;
                    dtAvisosInsertados.Rows.Add(drAviso);
                }
            }

            
            //OLD CODE
            //foreach (KeyValuePair<OrdenEverest, int?> var in lstOrdenesInsertadas)
            //{
            //    for (int i = 0; i < this._dtDatos.Rows.Count; i++)
            //    {
            //        if (var.Value != null)
            //        {
            //            long? codSpot = (long?)this._dtDatos.Rows[i]["CODIGOSPOT"];
            //            if (var.Key.CodigoSpot == codSpot)
            //            {
            //                drAviso = dtAvisosInsertados.NewRow();
            //                drAviso["id_spot"] = (long?)this._dtDatos.Rows[i]["CODIGOSPOT"];
            //                drAviso["id_spot_detalle"] = (long?)this._dtDatos.Rows[i]["CODIGOSPOTDETALLE"];
            //                drAviso["id_orden_mms"] = var.Value;
            //                dtAvisosInsertados.Rows.Add(drAviso);
            //            }
            //        }
            //    }
            //} // foreach

            return dtAvisosInsertados;
        }

        /// <summary>
        /// Formateamos la tabla para que tenga los campos necesarios
        /// </summary>
        /// <param name="dt">DataTable a formatear</param>
        private void formatearTabla(DataTable dt)
        {
            //agregar el nombre
            dtAvisosInsertados.Columns.Add("id_spot", typeof(long));
            dtAvisosInsertados.Columns.Add("id_spot_detalle", typeof(long));
            dtAvisosInsertados.Columns.Add("id_orden_mms", typeof(long));
        }

        /// <summary>
        /// Setea la lista de Cuñas sumando la cantidad por fecha.
        /// </summary>
        /// <param name="i"></param>
        private void SetCunas(int month,long codSpot, int? duracion)
        {
            this.lstCunas = new SolutionEntityList<Cuna>();

            //JJP 15062010 
            int codCuna = 0;
            int tempCodMaterial = -1;
            ///

            for (int i = 0; i < this._dtDatos.Rows.Count; i++)
            {
                DateTime _fSpot = DateTime.Parse(this._dtDatos.Rows[i]["F_SPOT"].ToString());
                int _idSpot = int.Parse(this._dtDatos.Rows[i]["CODIGOSPOT"].ToString());
                int tempDuracion = int.Parse(this._dtDatos.Rows[i]["DURACION"].ToString());
                                

                if (month == _fSpot.Month && _idSpot == codSpot && duracion == tempDuracion)
                {
                    int _idSpotDetalle = int.Parse(this._dtDatos.Rows[i]["CODIGOSPOTDETALLE"].ToString());
                    int _codMaterial = int.Parse(this._dtDatos.Rows[i]["CODIGOMATERIAL"].ToString());
                    string _Tema = this._dtDatos.Rows[i]["ID_TEMA"].ToString();

                    //Variable para el control de insercciones en la lista de Objetos.
                    int _verifyCun = 0;

                    //JJP 15062010 - Evaluo el material para saber si lo tengo que insertar
                    //con otro código de cuña, ya que así es el funcionamiento en MMS
                    if (tempCodMaterial != _codMaterial)
                    {
                        codCuna++;
                        tempCodMaterial = _codMaterial;
                    }
                    ///

                    //Seteo los valores al nuevo objeto Cuña.
                    Cuna _cuna = new Cuna();
                    _cuna.CodCuna = codCuna;
                    //_cuna.CodCuna = 1;
                    _cuna.CodCompania = this.mmsCodCompania;
                    _cuna.FechaCuna = _fSpot;
                    _cuna.CodOrden = 1;
                    _cuna.CodMaterial = _codMaterial;

                    //Recorro la lista de Cuñas existentes.
                    if (this.lstCunas.Count != 0)
                    {
                        //
                        for (int j = 0; j < this.lstCunas.Count; j++)
                        {
                            if (this.lstCunas[j].FechaCuna == _cuna.FechaCuna)
                            {
                                if (this.lstCunas[j].CodMaterial == _codMaterial)
                                {
                                    if (this.ValidateCunas(lstCunas, _cuna, _idSpot, _idSpotDetalle))
                                    {
                                        this.lstCunas[j].NumInsercionesCuna = this.lstCunas[j].NumInsercionesCuna + 1;
                                        _verifyCun = 1;
                                        break;
                                    }
                                }
                            }
                        }
                    }

                    //En caso de no haber coincidencia agrego la Cuña a la lista.
                    if (_verifyCun == 0)
                    {
                        _cuna.NumInsercionesCuna = 1;
                        this.lstCunas.Add(_cuna, this.mmsCodUsuario.ToString());
                    }
                }
            }
        }

        /// <summary>
        /// Valida las cunnas
        /// </summary>
        /// <param name="lstCunas">Lista de cunas</param>
        /// <param name="_cuna">Objeto Cunas</param>
        /// <param name="_idSpot">Id Spot</param>
        /// <param name="_idSpotDetalle">Id Spot Detalle</param>
        /// <returns>True False</returns>
        private bool ValidateCunas(SolutionEntityList<Cuna> lstCunas, Cuna _cuna, int _idSpot, int _idSpotDetalle)
        {
            bool validate = false;
            for (int i = 0; i < lstCunas.Count; i++)
            {
                if (_cuna.CodMaterial == lstCunas[i].CodMaterial)
                {
                    validate =  true;
                    break;
                }
            }
            return validate;
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            Dispose(true);
        }

        /// <summary>
        /// Metodo con sobrecarga para realizar el dispose.
        /// </summary>
        /// <param name="disposing">V/F</param>
        private void Dispose(bool disposing)
	    {
	        this.ClearResources(true);
	        GC.SuppressFinalize(this);
	    }

        /// <summary>
        /// Limpia las propiedades que establecemos.
        /// </summary>
        /// <param name="disposing"></param>
        private void ClearResources(bool disposing)
	    {
	        if (!this._disposed)
	        {
                //En caso de que hagamos el dispose nosotros y no el GC limpiamos los datos.
	            if (disposing)
	            {
                    _ordenRadio = null;
                    dtAvisosInsertados = null;
	            }
	        }
	        _disposed = true;
        }

        /// <summary>
        /// Destructor de clase.
        /// En caso de que se nos olvide “desechar” la clase,
        /// el GC llamará al destructor, que tambén ejecuta la lógica
        /// anterior para liberar los recursos.
        /// </summary>
        OrdenRadioDataMapper()
        {
            // Llamo al método que contiene la lógica
            // para liberar los recursos de esta clase.
            Dispose(true);
        }

        #endregion
    }
}
