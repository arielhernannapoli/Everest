namespace SIM
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Data;
    using HM.MMS.AR.Server.BusinessEntity.Ordenes.Television;
    using HM.MMS.Core.Server.BusinessEntity.Ordenes.TV;
    using HM.MMS.AR.Server.BusinessEntity.Ordenes;
    using HM.Comun.SolutionEntityFramework;

    /// <summary>
    /// Representa el seteo de valores en el objeto para ser insertados.
    /// </summary>
    public class OrdenTvDataMapper : IDisposable
    {
        #region Propiedades

        private bool _disposed = false;
        public DataTable _dtDatos;
        private OrdenTelevision _ordenTelevision;
        private List<OrdenTelevision> listOrdenTelevision = new List<OrdenTelevision>();
        public DataTable dtAvisosInsertados;
        static DataTable dtReturn;

        public int idCampaniaMMS;
        public int idSubCampanaMms;
        public int mmsCodPais;
        public int mmsCodUsuario;
        public int mmsCodCompania;
        public int mmsCodCliente;
        #endregion

        #region Constructor

        public OrdenTvDataMapper()
        {

        }

        #endregion

        #region Metodos

        /// <summary>
        /// Setea los valores del datatable en los diferentes objetos..
        /// </summary>
        public DataTable SetNewOrdenObject()
        {
            //var results = new Dictionary<OrdenEverest, int?>();

            // NUEVO DESARROLLO DE ENVIO A COMPRAS LIGERO (AN 27-08-2015)
            if (_dtDatos.Rows.Count > 0)
            {
                var oEnvioLigeroMMS = new SIM.DataMapper.Envio_Ligero_MMS(_dtDatos, mmsCodCompania, mmsCodCliente, mmsCodUsuario, idCampaniaMMS, idSubCampanaMms, string.Empty, string.Empty, string.Empty);
                var cantidadOrdenes = oEnvioLigeroMMS.Envio_Cabecera_MMS_TV();

                // Creo el DataTable de retorno con un campo con la cantidad de ordenes insertadas en MMS.
                dtReturn = new DataTable();
                dtReturn.Columns.Add("TOTAL_ORDENES", typeof(int));
                dtReturn.Rows.Add(cantidadOrdenes);
            }

            //_dtDatos --> aca llegan los filtros.

            // SE COMENTA POR EL NUEVO DESARROLLO DE ENVIO A COMPRAS LIGERO (AN 27-08-2015)
            //for (int i = 0; i < this._dtDatos.Rows.Count; i++)
            //{
            //    this._ordenTelevision = new OrdenTelevision();
            //    this._ordenTelevision.EsOrdenEverest = true;
            //    this._ordenTelevision.Material = this._dtDatos.Rows[i]["CODIGOPROGRAMA"].ToString();
            //    this._ordenTelevision.CodigoCompania = int.Parse(this._dtDatos.Rows[i]["CODIGOCOMPANIA"].ToString());
            //    this._ordenTelevision.CodigoConvenio = (this._dtDatos.Rows[i]["CODIGOCONVENIO"].ToString()) == "" ? 0 : int.Parse(this._dtDatos.Rows[i]["CODIGOCONVENIO"].ToString());

            //    this._ordenTelevision.Descuentos = this.SetDescuentos(i);

            //    //Seteo los valores de OrdenEverest.
            //    this._ordenTelevision.OrdenEverest = new OrdenEverest(null, null);
            //    this._ordenTelevision.OrdenEverest.CodigoCampania = int.Parse(this._dtDatos.Rows[i]["CODIGOCAMPANIA"].ToString());
            //    this._ordenTelevision.OrdenEverest.CodigoEjercicio = (int)this._dtDatos.Rows[i]["CODIGOEJERCICIO"];
            //    this._ordenTelevision.OrdenEverest.CodigoSistema = (int)this._dtDatos.Rows[i]["CODIGOSISTEMA"];
            //    this._ordenTelevision.OrdenEverest.CodigoSpot = (long?)this._dtDatos.Rows[i]["CODIGOSPOT"];
            //    this._ordenTelevision.OrdenEverest.CodigoSpotDetalle = (long?)this._dtDatos.Rows[i]["CODIGOSPOTDETALLE"];

            //    //seteo una nueva orden interna.
            //    OrdenTV _ordenTVs = new OrdenTV();
            //    _ordenTVs = this.SetValuesOrdenTV(i);
            //    this._ordenTelevision.OrdenInterna = _ordenTVs;

            //    //agrego el nuevo item a la lista.
            //    this.listOrdenTelevision.Add(this._ordenTelevision);
            //}

            //results = OrdenTvManager.insertar_spotTV(this.listOrdenTelevision, this.idCampaniaMMS, this.idSubCampanaMms, this.mmsCodPais, this.mmsCodUsuario, this.mmsCodCompania);
            //dtReturn = vueltaAvisosInsertados(results);

            this.Dispose(true);
            return dtReturn;
        }

        /// <summary>
        /// Setea lo valores correspondientes a OrdenTV
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        private OrdenTV SetValuesOrdenTV(int i)
        {
            return null;
            // SE COMENTA TODO EL METODO POR EL NUEVO DESARROLLO DE ENVIO A COMPRAS LIGERO (AN 01-09-2015)
            //try
            //{
            //    //WARNING: Jsperk - Revisar los valores corerspondientes a ESTADO debido a que si el presupuesto es de de intercambio el valor varia.
            //    OrdenTV _ordenTVs = new OrdenTV();

            //    _ordenTVs.CodigoCampana = this.idCampaniaMMS;
            //    _ordenTVs.CodigoDelegacion = int.Parse(this._dtDatos.Rows[i]["CODIGODELEGACION"].ToString());
            //    _ordenTVs.CodigoMedio = int.Parse(this._dtDatos.Rows[i]["CODIGOMEDIO"].ToString());
            //    _ordenTVs.CodigoOrigen = int.Parse(this._dtDatos.Rows[i]["CODIGOORIGEN"].ToString());
            //    _ordenTVs.CodigoPais = int.Parse(this._dtDatos.Rows[i]["CODIGOPAIS"].ToString());
            //    _ordenTVs.CodigoPresupuesto = int.Parse(this._dtDatos.Rows[i]["CODIGOPRESUPUESTO"].ToString());
            //    _ordenTVs.CodigoProducto = int.Parse(this._dtDatos.Rows[i]["CODIGOPRODUCTO"].ToString());
            //    _ordenTVs.CodigoPrograma = 1;//int.Parse(this._dtDatos.Rows[i]["CODIGOPROGRAMA"].ToString());
            //    _ordenTVs.CodigoSoporte = int.Parse(this._dtDatos.Rows[i]["CODIGOSOPORTE"].ToString());
            //    //CF 27/08/2014 set codigo sub campania
            //    _ordenTVs.CodigoSubcampana = this.idSubCampanaMms;// int.Parse(this._dtDatos.Rows[i]["CODIGOSUBCAMPANA"].ToString());
            //    _ordenTVs.CodigoUsuario = int.Parse(this._dtDatos.Rows[i]["CODIGOUSUARIO"].ToString());
            //    _ordenTVs.Duracion = int.Parse(this._dtDatos.Rows[i]["DURACION"].ToString());
            //    _ordenTVs.Estado = int.Parse(this._dtDatos.Rows[i]["ESTADO"].ToString());
            //    _ordenTVs.FechaCreacion = (DateTime)this._dtDatos.Rows[i]["FECHACREACION"];
            //    _ordenTVs.FechaEjecucion = (DateTime)this._dtDatos.Rows[i]["F_SPOT"];
            //    _ordenTVs.GRP_Previsto = (decimal)this._dtDatos.Rows[i]["GRP_PREVISTO"];
            //    _ordenTVs.GRPPlanificacion = (decimal)this._dtDatos.Rows[i]["GRP_PLANIFICACION"];
            //    _ordenTVs.Hora = this.setHora(this._dtDatos.Rows[i]["HORA"].ToString());
            //    _ordenTVs.HoraPublicidad.Hora = int.Parse(this._dtDatos.Rows[i]["HORA"].ToString().Substring(0, 2));
            //    _ordenTVs.HoraPublicidad.Minuto = int.Parse(this._dtDatos.Rows[i]["HORA"].ToString().Substring(3, 2));
            //    _ordenTVs.HoraPublicidad.Segundo = int.Parse(this._dtDatos.Rows[i]["HORA"].ToString().Substring(6, 2));
            //    _ordenTVs.ImporteCompra_Divisa = decimal.Parse(this._dtDatos.Rows[i]["IMPORTECOMPRA"].ToString());
            //    _ordenTVs.ImporteCompraNeto = decimal.Parse(this._dtDatos.Rows[i]["IMPORTECOMPRANETO"].ToString());
            //    _ordenTVs.ImporteVenta_Divisa = decimal.Parse(this._dtDatos.Rows[i]["IMPORTEVENTA"].ToString());
            //    _ordenTVs.ImporteVentaNeto = decimal.Parse(this._dtDatos.Rows[i]["IMPORTEVENTANETO"].ToString());
            //    _ordenTVs.IntercambioEstado = null;
            //    _ordenTVs.ProgramaDescripcion = (string)this._dtDatos.Rows[i]["PROGRAMADESCRIPCION"];
            //    _ordenTVs.Bloque = (string)this._dtDatos.Rows[i]["PROGRAMADESCRIPCION"];
            //    _ordenTVs.CodigoCliente = int.Parse(this._dtDatos.Rows[i]["CODIGOCLIENTE"].ToString());
                
                
            //    //AG
            //    //AGuzzardi 19/08/2010 ------------------------------------------------------
            //    // codigo Anterior -----------------
            //    //_ordenTVs.CodigoMaterial = int.Parse(this._dtDatos.Rows[i]["MATERIAL"].ToString());
            //    //-------------------------------------
            //    if (int.Parse(this._dtDatos.Rows[i]["MATERIAL"].ToString()) == -1)
            //    { _ordenTVs.CodigoMaterial = null; }
            //    else
            //        _ordenTVs.CodigoMaterial = int.Parse(this._dtDatos.Rows[i]["MATERIAL"].ToString());
            //    //-----------------------------------------------------------------------------------

            //    //
            //    _ordenTVs.CodigoCompania = int.Parse(this._dtDatos.Rows[i]["CODIGOCOMPANIA"].ToString());

            //    decimal? importeCompra = decimal.Parse(this._dtDatos.Rows[i]["IMPORTECOMPRA"].ToString());
            //    decimal? importeVenta = decimal.Parse(this._dtDatos.Rows[i]["IMPORTEVENTA"].ToString());
                
            //    //AG 30/02/2014 =================================================
            //    decimal? tarifa = importeVenta / _ordenTVs.Duracion;
                
            //    //decimal? tarifa = importeCompra / _ordenTVs.Duracion;
            //    //===============================================================
                

            //    // valor del segundo bruto
            //    _ordenTVs.ImporteTarifaOficial = tarifa;
            //    _ordenTVs.ImporteTarifaOficial_Divisa = tarifa;
            //    // valor de compra y venta igual al valor del segundo
                
            //    _ordenTVs.DescuentoAgenciaCompra = decimal.Parse(this._dtDatos.Rows[i]["DESCUENTOCASCADACOMPRA"].ToString());
            //    _ordenTVs.DescuentoAgenciaVenta = decimal.Parse(this._dtDatos.Rows[i]["DESCUENTOCASCADA"].ToString());

            //    //SuperHack
            //    _ordenTVs.CodigoMoneda = 5; 
            //    _ordenTVs.CodigoMoneda_Divisa = 5;
            //    _ordenTVs.CodigoInsercion = 0;
            //    _ordenTVs.CodigoProveedor = 0;

            //    _ordenTVs.ImporteTarifaVenta = tarifa;
            //    _ordenTVs.ImporteVenta = _ordenTVs.ImporteTarifaOficial * _ordenTVs.Duracion;
            //    _ordenTVs.ImporteTarifaVenta_Divisa = tarifa;

            //    //AG 30/01/2014 ==============================================================
            //    _ordenTVs.ImporteTarifaCompra = importeCompra /_ordenTVs.Duracion; //tarifa;
            //    _ordenTVs.ImporteCompra = importeCompra; //_ordenTVs.ImporteTarifaOficial * _ordenTVs.Duracion;
            //    _ordenTVs.ImporteTarifaCompra_Divisa = importeCompra / _ordenTVs.Duracion;  //tarifa;
            //    // ===========================================================================


            //    _ordenTVs.CambioAplicado = 1;
            //    _ordenTVs.CambioOficial = 1;

            //    _ordenTVs.CodigoTargetVenta = "0";
            //    _ordenTVs.CodigoTargetCompra = "0";
            //    _ordenTVs.CodigoPosicionVenta = _ordenTVs.CodigoPosicionVenta ?? 0;
            //    _ordenTVs.CodigoBloquePosCompra = 1;
            //    _ordenTVs.CodigoBloquePosVenta = 1;
            //    _ordenTVs.CodigoFuenteCompra = _ordenTVs.CodigoFuenteCompra ?? 0;
            //    _ordenTVs.CodigoFuenteVenta = _ordenTVs.CodigoFuenteVenta ?? 0;
            //    _ordenTVs.CoeficienteCompra = _ordenTVs.CoeficienteCompra ?? 0;
            //    _ordenTVs.CoeficienteVenta = _ordenTVs.CoeficienteVenta ?? 0;
            //    _ordenTVs.CodigoTipoEquivalencia = _ordenTVs.CodigoTipoEquivalencia ?? 0;

            //    _ordenTVs.CodigoPlanificacion = _ordenTVs.CodigoPlanificacion ?? 0;
            //    _ordenTVs.CodigoPlan = _ordenTVs.CodigoPlan ?? 0;
            //    _ordenTVs.CodigoPaseTipo = _ordenTVs.CodigoPaseTipo ?? "0";

            //    _ordenTVs.Rappel = true;
            //    _ordenTVs.NumOrdenInsercion = "1";
            //    _ordenTVs.NoInserciones = 1;
            //    _ordenTVs.CodigoTipoOrden = 1;
            //    _ordenTVs.PosicionVentaCodigo = 1;
            //    _ordenTVs.PosicionCompraCodigo = 1;
            //    _ordenTVs.DescuentoSAGVenta = 0;
            //    _ordenTVs.DescuentoSAGCompra = 0;
            //    _ordenTVs.IndicadorEstado = 1;
            //    _ordenTVs.CodigoBloquePosCompra = 1;
            //    _ordenTVs.CodigoBloquePosVenta = 1;
            //    _ordenTVs.FechaRealEjecucion = (DateTime)this._dtDatos.Rows[i]["F_SPOT"];

            //    //Warning: Jsperk - Se comenta la ejecucion de este metodo porque falla al llamar el servicio de inserccion. Prob
            //    //this.SetGrpTV(_ordenTVs, i);

            //    return _ordenTVs;
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception(ex.Message);
            //}
        }

        /// <summary>
        /// Setea loa valores correspondientes a GRPS
        /// </summary>
        /// <param name="_ordenTVs"></param>
        /// <param name="index"></param>
        private OrdenTV SetGrpTV(OrdenTV _ordenTVs, int index)
        {
            SolutionEntityList<OrdenGRPTV> _ordenGrpList = new SolutionEntityList<OrdenGRPTV>();
            OrdenGRPTV item = new OrdenGRPTV();
            item.GRPPrevisto = (decimal)this._dtDatos.Rows[index]["GRP_PREVISTO"];

            _ordenGrpList.Add(item, this.mmsCodUsuario.ToString());
            _ordenTVs.OrdenGRPS = _ordenGrpList;

            return _ordenTVs;
       }

        /// <summary>
        /// Setea la hora de la forma en al que la espera el objeto OrdenTV
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private int? setHora(string value)
        {
            string horafinal = value.ToString().Replace(":", "").Substring(0, 2);
            return Convert.ToInt32(horafinal);
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
        /// Setea el objeto descuentos con los valores correspondientes.
        /// </summary>
        /// <param name="i">Indice del DataTable</param>
        /// <returns>Lista de descuentoRecargo</returns>
        private List<DescuentoRecargoTvAR> SetDescuentos(int i)
        {
            ////AG ID 16480 -- 25/08/2010 Nuevo Codigo --------------------------------------------------------------------------------
            List<DescuentoRecargoTvAR> listDesc = new List<DescuentoRecargoTvAR>();
            int f = 1;
            int g = 0;

            for (int j = 1; j < 6; j++)
            {
                string colName = "DCTO" + f;  // Descuento de Venta
                DescuentoRecargoTvAR newDescuento = new DescuentoRecargoTvAR();
                newDescuento.CodigoTipoUso = 2;
                newDescuento.CodigoTipoDescuento = 2; // TIPO_GENERICO_VENTA = 2;
                newDescuento.PorcentajeAR = decimal.Parse(this._dtDatos.Rows[i][colName].ToString());
                newDescuento.Descripcion = "Dt/Rec";
                newDescuento.Indicador = -1;
                newDescuento.Aplicacion = 0;
                newDescuento.CodDtoRec = j - 1;
                listDesc.Add(newDescuento);
                f = f + 1;
                g = j;
            }
            f = 0;
            for (int j = 1; j < 6; j++)
            {
                g = g + 1;
                f = f + 1;
                string colName = "DCTOC" + f;  //Descuento de Compras
                DescuentoRecargoTvAR newDescuento = new DescuentoRecargoTvAR();
                newDescuento.CodigoTipoUso = 1;
                newDescuento.CodigoTipoDescuento = 1; // TIPO_GENERICO_COMPRA  = 1;
                newDescuento.PorcentajeAR = decimal.Parse(this._dtDatos.Rows[i][colName].ToString());
                newDescuento.Descripcion = "Dt/Rec";
                newDescuento.Indicador = -1;
                newDescuento.Aplicacion = 0;
                newDescuento.CodDtoRec = g - 1;
                listDesc.Add(newDescuento);
            }
            f = 0;
            g = 0;

            //AG -- 25/08/2010 Codigo Anterior -------------------------------------------------------------------------------------------------------
            //List<DescuentoRecargoTvAR> listDesc = new List<DescuentoRecargoTvAR>();
            //int f = 1;
            //for (int j = 1; j < 11; j++)
            //{
            //    DescuentoRecargoTvAR newDescuento = new DescuentoRecargoTvAR();
            //    string colName = "DCTO" + f;
            //    if (j >= 6)
            //    {
            //        colName = "DCTO" + f;
            //        newDescuento.CodigoTipoUso = 1;
            //        newDescuento.CodigoTipoDescuento = 1; // HACK - Jsperk - TIPO_GENERICO_COMPRA = 1; TIPO_GENERICO_COMPRAVENTA = 3; TIPO_GENERICO_VENTA = 2;
            //    }
            //    else
            //    {
            //        newDescuento.CodigoTipoUso = 2;
            //        newDescuento.CodigoTipoDescuento = 2; // HACK - Jsperk - TIPO_GENERICO_COMPRA = 1; TIPO_GENERICO_COMPRAVENTA = 3; TIPO_GENERICO_VENTA = 2;
            //    }

            //    newDescuento.PorcentajeAR = decimal.Parse(this._dtDatos.Rows[i][colName].ToString());
            //    newDescuento.Descripcion = "Dt/Rec";
            //    newDescuento.Indicador = -1;
            //    newDescuento.Aplicacion = 0;
            //    newDescuento.CodDtoRec = j - 1;
            //    listDesc.Add(newDescuento);
            //    if (f == 5)
            //        f = 0;

            //    f = f + 1;
                
            //} 
            return listDesc;
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
                   this._ordenTelevision= null;
                   this.dtAvisosInsertados = null;
                    this._dtDatos = null;
	            }
	        }
	        _disposed = true;
        }

        #endregion
    }
}
