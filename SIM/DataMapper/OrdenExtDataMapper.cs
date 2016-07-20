namespace SIM
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using HM.MMS.AR.Server.BusinessEntity.Ordenes;
    using HM.MMS.AR.Server.BusinessEntity.Ordenes.ViaPublica;
    using System.Data;
    using HM.Contratos.Entidad.Ordenes;
    using SIM.Manager;
    using HM.Comun.Utilidades;
    using HM.Contratos.Entidad.Soportes;
    using HM.Contratos.Entidad.Maestros;
    using HM.Contratos.Entidad.Parrillas;
    using HM.Contratos.Entidad.Campanas;
    using HM.Comun.Persistencia.Entidad.CriterioFiltro;
    using HM.MMS.Agentes.Compra;
    using HM.MMS.Cliente.Comun.Compra.Winforms.Ordenes;
    using HM.Contratos.Entidad.Ordenes.GestorPrecios;

    /// <summary>
    /// Clase encargada de mapear los datos correspondientes a el Medio Exterior.
    /// </summary>
    public class OrdenExtDataMapper : IDisposable
    {
        #region Propiedades

        private bool _disposed = false;
        public DataTable _dtDatosExt;
        private OrdenViaPublica _ordenExt;
        private List<OrdenViaPublica> listOrdenExterior = new List<OrdenViaPublica>();
        static DataTable dtReturn;
        public DataTable dtAvisosInsertados;

        public int idCampaniaMMS;
        public int idSubCampanaMms;
        public int mmsCodPais;
        public int mmsCodUsuario;
        public int mmsCodCompania;

        #endregion
        
        #region Constructor

        public OrdenExtDataMapper()
        {

        }


        public OrdenExtDataMapper(DataTable _value, int idCampaniaMMS, int idSubCampanaMms, int mmsCodPais, int mmsCodUsuario, int mmsCodCompania)
        {
            _dtDatosExt = _value;
            this.idCampaniaMMS = idCampaniaMMS;
            this.idSubCampanaMms = idSubCampanaMms;
            this.mmsCodPais = mmsCodPais;
            this.mmsCodUsuario = mmsCodUsuario;
            this.mmsCodCompania = mmsCodCompania;
        }        
        
        #endregion        

        #region Metodos

        /// <summary>
        /// Setea los valores en el objeto para enviarlos a Compra.
        /// </summary>
        public DataTable SetNewOrdenExtObject()
        {
            try
            {
                var results = new Dictionary<OrdenEverest, int?>();

                for (int i = 0; i < this._dtDatosExt.Rows.Count; i++)
                {
                    OrdenViaPublica temp = new OrdenViaPublica();

                    temp = new OrdenViaPublica();
                    temp.EsOrdenEverest = true;
                    temp.Material = this._dtDatosExt.Rows[i]["PROGRAMADESCRIPCION"].ToString();
                    temp.CodigoCompania = int.Parse(this._dtDatosExt.Rows[i]["CODIGOCOMPANIA"].ToString());
                    temp.CodigoConvenio = (this._dtDatosExt.Rows[i]["CODIGOCONVENIO"].ToString()) == "" ? 0 : int.Parse(this._dtDatosExt.Rows[i]["CODIGOCONVENIO"].ToString());
                    temp.CodigoOrden = 0;
                    temp.Monitoreada = false;
                    temp.TituloAnuncio = this._dtDatosExt.Rows[i]["PROGRAMADESCRIPCION"].ToString();

                    //Seteo los valores de OrdenEverest.
                    temp.OrdenEverest = new OrdenEverest(null, null);
                    temp.OrdenEverest.CodigoSpot = (long?)this._dtDatosExt.Rows[i]["CODIGOSPOT"];
                    temp.OrdenEverest.CodigoSpotDetalle = (long?)this._dtDatosExt.Rows[i]["CODIGOSPOTDETALLE"];
                    temp.OrdenEverest.CodigoCampania = int.Parse(this._dtDatosExt.Rows[i]["CODIGOCAMPANIA"].ToString());
                    temp.OrdenEverest.CodigoEjercicio = int.Parse(this._dtDatosExt.Rows[i]["CODIGOEJERCICIO"].ToString());
                    temp.OrdenEverest.CodigoSistema = int.Parse(this._dtDatosExt.Rows[i]["CODIGOSISTEMA"].ToString());

                    this.listOrdenExterior.Add(this.SetOrdenInterna(temp, i));
                }
                results = OrdenExtManager.insertar_spotExt(this.listOrdenExterior, this.idCampaniaMMS, this.idSubCampanaMms, this.mmsCodPais, this.mmsCodUsuario, this.mmsCodCompania);
                
                this.SetOrderReturn(results);
                
                this.Dispose(true);

                dtReturn = this.dtAvisosInsertados;
                return dtReturn;
            }
            catch (Exception ex)
            {
                this.Dispose(true);
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Setea los descuentos de Orden Prensa.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        private ColeccionNegocioBase<OrdenDescuentoRecargoEntidad> setDescuentos(int i)
        {
            //AG ID 16480 27/08/2010 Modificacion Descuentos Venta y Compras ------------------------------------------------------------------------------------------------------------------------------------------
            ColeccionNegocioBase<OrdenDescuentoRecargoEntidad> listDesc = new ColeccionNegocioBase<OrdenDescuentoRecargoEntidad>();
            int f = 1;
            for (int j = 1; j < 11; j++)
            {
                OrdenDescuentoRecargoEntidad newDescuento = new OrdenDescuentoRecargoEntidad();
                TipoDescuentoRecargoEntidad tipo = new TipoDescuentoRecargoEntidad();
                TipoBasicoEntidad tipoBasico = new TipoBasicoEntidad("");

                string colName = "DCTOC" + f;
                if (j >= 6)
                {
                    colName = "DCTO" + f;
                    tipoBasico.Codigo = 2; // DESCUENTOS DE VENTA
                    tipoBasico.Descripcion = "Precio Venta";
                    tipo.DescripcionTipo = "Generico Venta";
                    tipoBasico.Pais = new PaisEntidad() { CodPais = 32 };
                    tipo.TipoUso = tipoBasico;
                    tipo.CodigoTipo = 2; // DESCUENTOS DE VENTA
                }
                else
                {
                    tipoBasico.Codigo = 1; // DESCUENTOS DE COMPRA
                    tipoBasico.Descripcion = "Precio Compra";
                    tipo.DescripcionTipo = "Generico Compra";
                    tipoBasico.Pais = new PaisEntidad() { CodPais = 32 };
                    tipo.TipoUso = tipoBasico;
                    tipo.CodigoTipo = 1; // DESCUENTOS DE COMPRA
                }

                newDescuento.Codigo = 0;
                newDescuento.TipoDescuento = tipo;
                newDescuento.Porcentaje = decimal.Parse(this._dtDatosExt.Rows[i][colName].ToString());
                newDescuento.Descripcion = "Dt/Rec";

                if (newDescuento.Porcentaje * -1 < 0)
                    newDescuento.EsRecargo = false; //Verificar valores.
                else
                    newDescuento.EsRecargo = true; //Verificar valores.

                newDescuento.Operacion = TiposOperacion.Insertar;
                newDescuento.TipoUso = newDescuento.TipoDescuento.TipoUso;

                listDesc.Add(newDescuento);
                if (f == 5)
                    f = 0;

                f = f + 1;
            }
            return listDesc;
            //------------------------------------------------------------------------------------------------------------------------------------------------------------------
        }

        private ColeccionNegocioBase<SubOrdenExteriorEntidad> setSubOrden(int i, int CodMedio)
        {
            ColeccionNegocioBase<SubOrdenExteriorEntidad> SubOrden = new ColeccionNegocioBase<SubOrdenExteriorEntidad>();
            SubOrdenExteriorEntidad entidadSubOrden = new SubOrdenExteriorEntidad();
            PoblacionEntidad provincia = null;
            PoblacionEntidad comunidad = null;
            ////Cargo la entidad de Provincia ( Cod_Pobl1) y (Cod_Pobl2) +++++++++++++++++++++++++++++++++++++++++++++++
            int codigoProvincia = Convert.ToInt32(this._dtDatosExt.Rows[i]["COD_POBL1"].ToString());
            comunidad = new PoblacionEntidad();
            comunidad.Codigo = 0; // Generico
            comunidad.Operacion = TiposOperacion.Insertar;
            PaisEntidad paisProvincia = new PaisEntidad();
            paisProvincia.CodPais = 32;
            comunidad.Pais = paisProvincia;
            comunidad.PoblacionesHijas = new ColeccionNegocioBase<PoblacionEntidad>();
            provincia = new PoblacionEntidad();
            provincia.Codigo = codigoProvincia;
            provincia.Pais = paisProvincia;
            provincia.Operacion = TiposOperacion.Insertar;
            comunidad.PoblacionesHijas.Add(provincia);
            ////Cargo la entidad de Localidad ( Cod_Pobl3) +++++++++++++++++++++++++++++++++++++++++++++++
            if (provincia != null)
            {
                PoblacionEntidad localidad = new PoblacionEntidad();
                int? codigoLocalidad = Convert.ToInt32(this._dtDatosExt.Rows[i]["COD_POBL2"].ToString());
                if (codigoLocalidad > -1)
                {localidad.Codigo = codigoLocalidad.Value;
                  localidad.Operacion = TiposOperacion.Insertar;
                  provincia.PoblacionesHijas = new ColeccionNegocioBase<PoblacionEntidad>();
                  provincia.PoblacionesHijas.Add(localidad);
                }
            }
            if (comunidad != null && provincia != null)
            {entidadSubOrden.Poblacion = comunidad;}
            entidadSubOrden.Caras = int.Parse(this._dtDatosExt.Rows[i]["NUM_CARAS"].ToString());
            entidadSubOrden.Formato = new TipoAnuncioEntidad();
            entidadSubOrden.Formato.Codigo = 1;
            entidadSubOrden.Formato.Medio = new MedioEntidad();
            entidadSubOrden.Formato.Medio.CodMedio = CodMedio;
            if (DBNull.Value == this._dtDatosExt.Rows[i]["DIRECCION1"])
            { entidadSubOrden.Direccion = null; }
            else
            { entidadSubOrden.Direccion = this._dtDatosExt.Rows[i]["DIRECCION1"].ToString(); }
            entidadSubOrden.Observaciones = null;
            entidadSubOrden.DetalleCircuito = null;
            entidadSubOrden.Operacion = TiposOperacion.Insertar;
            entidadSubOrden.Importe = null;
            SubOrden.Add(entidadSubOrden);
            return SubOrden;
        }

        /// <summary>
        /// Setea los valores del Diccionario en un datatable para retornarlos
        /// </summary>
        /// <param name="lstOrdenesInsertadas">Diccionario con las ordenes insertadas.</param>
        /// <returns>DataTable</returns>
        public void SetOrderReturn(Dictionary<OrdenEverest, int?> lstOrdenesInsertadas)
        {
            dtAvisosInsertados = new DataTable();
            FormatDataTable(dtAvisosInsertados);
            DataRow drAviso = null;

            foreach (KeyValuePair<OrdenEverest, int?> var in lstOrdenesInsertadas)
            {
                if (var.Value != null)
                {
                    drAviso = dtAvisosInsertados.NewRow();
                    drAviso["id_spot"] = var.Key.CodigoSpot;
                    drAviso["id_spot_detalle"] = var.Key.CodigoSpotDetalle;
                    drAviso["id_orden_mms"] = var.Value;
                    dtAvisosInsertados.Rows.Add(drAviso);
                }
            } // foreach
            //return dtAvisosInsertados;
        }

        /// <summary>
        /// Formateamos la tabla para que tenga los campos necesarios
        /// </summary>
        /// <param name="dt">DataTable a formatear</param>
        private void FormatDataTable(DataTable dt)
        {
            //agregar el nombre
            dtAvisosInsertados.Columns.Add("id_spot", typeof(long));
            dtAvisosInsertados.Columns.Add("id_spot_detalle", typeof(long));
            dtAvisosInsertados.Columns.Add("id_orden_mms", typeof(long));
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

        private void ClearResources(bool disposing)
        {
            if (!this._disposed)
            {
                //En caso de que hagamos el dispose nosotros y no el GC limpiamos los datos.
                if (disposing)
                {
                    this._dtDatosExt = null;
                }
            }
            _disposed = true;
        }

        #endregion

        #region Temp

        protected OrdenViaPublica SetOrdenInterna(OrdenViaPublica order, int i)
        {
            int codigoCampana = this.idCampaniaMMS;
            int codigoSubcampana = this.idSubCampanaMms;
            int codigoMedio = 3;
            int codPais = this.mmsCodPais;
            int codCompania = this.mmsCodCompania;
            int codigoSoporte = int.Parse(this._dtDatosExt.Rows[i]["ID_SOPORTE"].ToString());
            int codigoPresupuesto = int.Parse(this._dtDatosExt.Rows[i]["CODIGOPRESUPUESTO"].ToString());

            CampanaFiltro filtroCampana = new CampanaFiltro();
            filtroCampana.Criterio = Expresion.Eq(CampanaFiltro.COD_PAIS, codPais);
            filtroCampana.Criterio = Expresion.And(filtroCampana.Criterio, Expresion.Eq(CampanaFiltro.COD_CAMPANA, codigoCampana));
            filtroCampana.Criterio = Expresion.And(filtroCampana.Criterio, Expresion.Eq(CampanaFiltro.COD_COMPANIA, codCompania));

            SubcampanaFiltro filtroSubcampana = new SubcampanaFiltro();
            filtroSubcampana.Criterio = Expresion.Eq(SubcampanaFiltro.COD_PAIS, codPais);
            filtroSubcampana.Criterio = Expresion.And(filtroSubcampana.Criterio, Expresion.Eq(SubcampanaFiltro.COD_CAMPANA, codigoCampana));
            filtroSubcampana.Criterio = Expresion.And(filtroSubcampana.Criterio, Expresion.Eq(SubcampanaFiltro.COD_COMPANIA, codCompania));
            filtroSubcampana.Criterio = Expresion.And(filtroSubcampana.Criterio, Expresion.Eq(SubcampanaFiltro.COD_MEDIO, codigoMedio));
            filtroSubcampana.Criterio = Expresion.And(filtroSubcampana.Criterio, Expresion.Eq(SubcampanaFiltro.COD_SUBCAMPANA, codigoSubcampana));

            PresupuestoFiltro filtroPresupuesto = new PresupuestoFiltro();
            filtroPresupuesto.Criterio = Expresion.Eq(PresupuestoFiltro.COD_PAIS, codPais);
            filtroPresupuesto.Criterio = Expresion.And(filtroPresupuesto.Criterio, Expresion.Eq(PresupuestoFiltro.COD_COMPANIA, codCompania));
            filtroPresupuesto.Criterio = Expresion.And(filtroPresupuesto.Criterio, Expresion.Eq(PresupuestoFiltro.COD_CAMPANA, codigoCampana));
            filtroPresupuesto.Criterio = Expresion.And(filtroPresupuesto.Criterio, Expresion.Eq(PresupuestoFiltro.COD_SUBCAMPANA, codigoSubcampana));

            ColeccionNegocioBase<PresupuestoEntidad> listPresupuesto = new PresupuestoAgente().obtenerPresupuestos(filtroPresupuesto, filtroSubcampana, filtroCampana);
            
            PresupuestoEntidad presupuesto = new PresupuestoEntidad();

            foreach (PresupuestoEntidad item in listPresupuesto)
            {
                if (item.Codigo == codigoPresupuesto)
                { presupuesto = item; break; }
            }

            //JJP 17012011 - Elimino el intercambio del ppto para que al inicializar la orden no use el GestorEstado
            //              que no se puede utilizar desde Everest.
            IntercambioEntidad intecambio = presupuesto.Intercambio;
            presupuesto.Intercambio = null;

            OrdenExteriorEntidad nuevaOrden = new GestorOrdenes().InicializaOrden_Exterior(presupuesto, true, "1", "5");

            //JJP 17012011 - Vuelvo a poner el intercambio en el presupuesto.
            nuevaOrden.Presupuesto.Intercambio = intecambio;
            nuevaOrden.Compania = new CompaniaEntidad() { Codigo = this.mmsCodCompania };
            order.OrdenInterna = nuevaOrden;

            //revisar esto dcaime
            order.OrdenInterna.CodigoOrden = -1;
            order.OrdenInterna.Estado = 1;
            order.OrdenInterna.CambioOficial = order.OrdenInterna.CambioOficial ?? 0;
            order.OrdenInterna.CambioAplicado = order.OrdenInterna.CambioOficial;

            order.OrdenInterna.TituloAnuncio = "";// this._dtDatosExt.Rows[i]["PROGRAMADESCRIPCION"].ToString();
            order.OrdenInterna.FechaEjecucion = DateTime.Parse(this._dtDatosExt.Rows[i]["F_SPOT"].ToString());
            order.OrdenInterna.FechaEjecucionFin = Convert.ToDateTime("01/01/0001"); //revisar esto dcaime
            order.OrdenInterna.Rappel = false;
            order.OrdenInterna.EsPorTarifa = true; 
            order.OrdenInterna.NumeroCaras = int.Parse(this._dtDatosExt.Rows[i]["NUM_CARAS"].ToString())    ; //revisar esto dcaime
            decimal? importeCompra = decimal.Parse(this._dtDatosExt.Rows[i]["IMPORTECOMPRA"].ToString());
            decimal? importeVenta = decimal.Parse(this._dtDatosExt.Rows[i]["IMPORTEVENTA"].ToString());
            decimal? importeCompraNeto = decimal.Parse(this._dtDatosExt.Rows[i]["IMPORTECOMPRANETO"].ToString());
            decimal? importeVentaNeto = decimal.Parse(this._dtDatosExt.Rows[i]["IMPORTEVENTANETO"].ToString());

            order.OrdenInterna.ImporteCompra = importeCompra;
            order.OrdenInterna.ImporteCompra_Divisa = importeCompra;
            order.OrdenInterna.ImporteCompraNeto = importeCompraNeto;
            order.OrdenInterna.ImporteCompraNeto_Divisa = importeCompraNeto;
            order.OrdenInterna.ImporteTarifaCompra = importeCompra;
            order.OrdenInterna.ImporteTarifaCompra_Divisa = importeCompra;
            order.OrdenInterna.ImporteTarifaOficial = importeCompra;
            order.OrdenInterna.ImporteTarifaOficial_Divisa = importeCompra;
            order.OrdenInterna.ImporteTarifaVenta = importeVenta;
            order.OrdenInterna.ImporteTarifaVenta_Divisa = importeVenta;
            order.OrdenInterna.ImporteVenta = importeVenta;
            order.OrdenInterna.ImporteVenta_Divisa = importeVenta;
            order.OrdenInterna.ImporteVentaDesglose = importeVenta;
            order.OrdenInterna.ImporteVentaDesglose_Divisa = importeVenta;
            order.OrdenInterna.ImporteVentaNeto = importeVentaNeto;
            order.OrdenInterna.ImporteVentaNeto_Divisa = importeVentaNeto;

            //Warning Verificar Importes si se utiliza la lista de objetos de la orden Interior
            order.OrdenInterna.ImporteCompra_Divisa = decimal.Parse(this._dtDatosExt.Rows[i]["IMPORTECOMPRA"].ToString());
            order.OrdenInterna.ImporteCompraNeto = decimal.Parse(this._dtDatosExt.Rows[i]["IMPORTECOMPRANETO"].ToString());
            order.OrdenInterna.ImporteVentaNeto = decimal.Parse(this._dtDatosExt.Rows[i]["IMPORTEVENTANETO"].ToString());
            order.OrdenInterna.ImporteCompra = decimal.Parse(this._dtDatosExt.Rows[i]["IMPORTECOMPRA"].ToString());
            order.OrdenInterna.ImporteTarifaCompra = decimal.Parse(this._dtDatosExt.Rows[i]["IMPORTECOMPRA"].ToString());
            order.OrdenInterna.ImporteTarifaCompra_Divisa = decimal.Parse(this._dtDatosExt.Rows[i]["IMPORTECOMPRA"].ToString());
            order.OrdenInterna.ImporteTarifaVenta = decimal.Parse(this._dtDatosExt.Rows[i]["IMPORTEVENTA"].ToString());
            order.OrdenInterna.ImporteVenta = decimal.Parse(this._dtDatosExt.Rows[i]["IMPORTEVENTA"].ToString());
            order.OrdenInterna.ImporteVenta_Divisa = decimal.Parse(this._dtDatosExt.Rows[i]["IMPORTEVENTA"].ToString());
            order.OrdenInterna.ImporteVentaNeto_Divisa = decimal.Parse(this._dtDatosExt.Rows[i]["IMPORTEVENTANETO"].ToString());
            //
            order.OrdenInterna.ImporteCara = 0;
            order.OrdenInterna.ImporteCara_Divisa = 0;
            order.OrdenInterna.DiaSemanaInicio = 1; //revisar esto dcaime
            order.OrdenInterna.Circuito = order.OrdenInterna.Circuito ?? new CircuitoEntidad() { Codigo = 0 };
            order.OrdenInterna.CodigoUsuario = this.mmsCodUsuario;
            order.OrdenInterna.NoInserciones = 1; //revisar esto dcaime
            order.OrdenInterna.Soporte = new SoporteEntidad()
            {Codigo = codigoSoporte,
               Medio = new MedioEntidad()
                {CodMedio = 3,
                   Pais = new PaisEntidad() { CodPais = this.mmsCodPais }
                },
                Moneda = new MonedaEntidad() { Codigo = 5 },
                Idioma = new IdiomaEntidad() { Codigo = 1 }
            };
            order.OrdenInterna.Proveedor = new ProveedorEntidad() { Codigo = 0 };
            order.OrdenInterna.Descuentos = this.setDescuentos(i);
            order.OrdenInterna.SubOrdenes = setSubOrden(i, codigoMedio);
            order.OrdenInterna.NumeroProvincias = order.OrdenInterna.SubOrdenes.Count;

            //LC 21/04/2014 Inserta el codigo AGIP en MMS
            order.CodigoAGIP = this._dtDatosExt.Rows[i]["COD_AGIP"].ToString();

            //GG 15/05/2015 Inserta Tipo_Elemento, Ancho, Alto y CISOP
            order.IdTipoElemento = Convert.ToInt32(this._dtDatosExt.Rows[i]["ID_TIPO_ELEMENTO"]);
            order.Ancho = this._dtDatosExt.Rows[i]["AnchoVP"] != DBNull.Value ? Convert.ToSingle(this._dtDatosExt.Rows[i]["AnchoVP"]) : new Nullable<float>();
            order.Alto = this._dtDatosExt.Rows[i]["AltoVP"] != DBNull.Value ? Convert.ToSingle(this._dtDatosExt.Rows[i]["AltoVP"].ToString()) : new Nullable<float>();
            order.Cisop = this._dtDatosExt.Rows[i]["Cisop"] != DBNull.Value ? Convert.ToInt64(this._dtDatosExt.Rows[i]["Cisop"].ToString()) : new Nullable<long>();

            return order;
        }

        #endregion
    }
}
