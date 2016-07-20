namespace SIM.DataMapper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Data;
    using HM.MMS.AR.Server.BusinessEntity.Ordenes.Revista;
    using HM.Contratos.Entidad.Campanas;
    using HM.Comun.Persistencia.Entidad.CriterioFiltro;
    using HM.MMS.Agentes.Compra;
    using HM.Contratos.Entidad.Maestros;
    using HM.MMS.Cliente.Comun.Compra.Winforms.Ordenes;
    using HM.Contratos.Entidad.Soportes;
    using HM.Comun.Utilidades;
    using HM.MMS.AR.Server.BusinessEntity.Ordenes;
    using SIM.Manager;
    using HM.Contratos.Entidad.Ordenes;
    using HM.MMS.Agentes.Comun;
    using HM.Comun.Varios;

    /// <summary>
    /// Clase encargada de mapear lo datos al objeto OrdenRevista.
    /// </summary>
    public class OrdenRevistaDataMapper : IDisposable
    {
        #region Propiedades

        private bool _disposed = false;
        public DataTable _dtDatosRevista;
        private OrdenRevista _ordenRevista;
        private List<OrdenRevista> listOrdenRevista = new List<OrdenRevista>();
        public static ColeccionNegocioBase<TipoDescuentoRecargoEntidad> coleccionTipoDescuento;
        static DataTable dtReturn;
        public DataTable dtAvisosInsertados;

        public int idCampaniaMMS;
        public int idSubCampanaMms;
        public int mmsCodPais;
        public int mmsCodUsuario;
        public int mmsCodCompania;

        #endregion

        #region Constructor

        public OrdenRevistaDataMapper(DataTable _value, int idCampaniaMMS, int idSubCampanaMms, int mmsCodPais, int mmsCodUsuario, int mmsCodCompania)
        {
            _dtDatosRevista = _value;
            this.idCampaniaMMS = idCampaniaMMS;
            this.idSubCampanaMms = idSubCampanaMms;
            this.mmsCodPais = mmsCodPais;
            this.mmsCodUsuario = mmsCodUsuario;
            this.mmsCodCompania = mmsCodCompania;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Setea los valores en la entidad OrdenRevista.
        /// </summary>
        /// <returns>DataTable con los codigos de ordenes insertados</returns>
        public void SetNewOrdenObject()
        {
            try
            {
                var results = new Dictionary<OrdenEverest, int?>();

                for (int i = 0; i < this._dtDatosRevista.Rows.Count; i++)
                {
                    OrdenRevista newOrder = new OrdenRevista();

                    newOrder.EsOrdenEverest = true;
                    newOrder.Material = this._dtDatosRevista.Rows[i]["MATERIAL"].ToString();
                    newOrder.CodigoCompania = int.Parse(this._dtDatosRevista.Rows[i]["CODIGOCOMPANIA"].ToString());
                    newOrder.CodigoConvenio = (this._dtDatosRevista.Rows[i]["CODIGOCONVENIO"].ToString()) == "" ? 0 : int.Parse(this._dtDatosRevista.Rows[i]["CODIGOCONVENIO"].ToString());
                    newOrder.CodigoOrden = 0;
                    newOrder.Monitoreada = false;

                    //modificar para que ponga el titulo dcaime 17/06/2010
                    //newOrder.TituloAnuncio = "Envio a compras RV";
                    newOrder.TituloAnuncio = this._dtDatosRevista.Rows[i]["CONCEPTO"].ToString();
                    //Seteo los valores de OrdenEverest.
                    newOrder.OrdenEverest = new OrdenEverest(null, null);
                    newOrder.OrdenEverest.CodigoSpot = (long?)this._dtDatosRevista.Rows[i]["CODIGOSPOT"];
                    newOrder.OrdenEverest.CodigoSpotDetalle = (long?)this._dtDatosRevista.Rows[i]["CODIGOSPOTDETALLE"];
                    newOrder.OrdenEverest.CodigoCampania = int.Parse(this._dtDatosRevista.Rows[i]["CODIGOCAMPANIA"].ToString());
                    newOrder.OrdenEverest.CodigoEjercicio = int.Parse(this._dtDatosRevista.Rows[i]["CODIGOEJERCICIO"].ToString());
                    newOrder.OrdenEverest.CodigoSistema = int.Parse(this._dtDatosRevista.Rows[i]["CODIGOSISTEMA"].ToString());

                    this.SetOrdenInterna(newOrder, i);

                    this.listOrdenRevista.Add(newOrder);
                }

                results = OrdenRevistaManager.insertar_spotRevista(this.listOrdenRevista, this.idCampaniaMMS, this.idSubCampanaMms, this.mmsCodPais, this.mmsCodUsuario, this.mmsCodCompania);
                vueltaAvisosInsertados(results);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Setea los valores en la orden Interna.
        /// </summary>
        /// <param name="newOrder">Objeto OrdenRevista</param>
        /// <param name="i">Index del datatable</param>
        private void SetOrdenInterna(OrdenRevista order, int i)
        {
            int codigoCampana = this.idCampaniaMMS;
            int codigoSubcampana = this.idSubCampanaMms;
            int codigoMedio = 5;
            int codPais = this.mmsCodPais;
            int codCompania = this.mmsCodCompania;
            int codigoSoporte = int.Parse(this._dtDatosRevista.Rows[i]["ID_SOPORTE"].ToString());
            int codigoPresupuesto = int.Parse(this._dtDatosRevista.Rows[i]["CODIGOPRESUPUESTO"].ToString());

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

            var nuevaOrden = new GestorOrdenes().InicializaOrden_Prensa(presupuesto, true, "1", "5");

            //JJP 17012011 - Vuelvo a poner el intercambio en el presupuesto.
            nuevaOrden.Presupuesto.Intercambio = intecambio;
            
            nuevaOrden.Compania = new CompaniaEntidad() { Codigo = this.mmsCodCompania };

            order.OrdenInterna = nuevaOrden;

            order.OrdenInterna.CodigoOrden = -1;
            order.OrdenInterna.Estado = 1;
            order.OrdenInterna.CambioOficial = order.OrdenInterna.CambioOficial ?? 0;
            order.OrdenInterna.CambioAplicado = order.OrdenInterna.CambioOficial;

            //arreglar este hardcode dcaime 17/06/2010
            //order.OrdenInterna.TituloAnuncio = "Prensa " + DateTime.Today.ToShortDateString();
            order.OrdenInterna.TituloAnuncio = this._dtDatosRevista.Rows[i]["CONCEPTO"].ToString();
            order.OrdenInterna.FechaEjecucion = DateTime.Parse(this._dtDatosRevista.Rows[i]["F_SPOT"].ToString());
            order.OrdenInterna.Rappel = false;

            order.OrdenInterna.Soporte = new SoporteEntidad()
            {
                Codigo = codigoSoporte,
                Medio = new MedioEntidad()
                {
                    CodMedio = codigoMedio,
                    Pais = new PaisEntidad() { CodPais = codPais }
                },
                Moneda = new MonedaEntidad() { Codigo = 5 },
                Idioma = new IdiomaEntidad() { Codigo = 1 }
            };

            order.OrdenInterna.Proveedor = new ProveedorEntidad() { Codigo = 0 };

            order.OrdenInterna.EsOrden = true;

            //arreglar esto dcaime
            int? _codSeccion = int.Parse(_dtDatosRevista.Rows[i]["id_seccion"].ToString());
            order.OrdenInterna.Seccion = new SeccionEntidad() { Codigo = _codSeccion };//((int?)this._dtDatosPrensa.Rows[i]["id_seccion"]) };
            //order.OrdenInterna.Seccion = new SeccionEntidad() { Codigo = 1 };
            order.OrdenInterna.Delegacion = new DelegacionEntidad() { CodDelegacion = 1 };

            //Importes
            decimal? importeCompra = decimal.Parse(this._dtDatosRevista.Rows[i]["IMPORTECOMPRA"].ToString());
            decimal? importeVenta = decimal.Parse(this._dtDatosRevista.Rows[i]["IMPORTEVENTA"].ToString());
            decimal? importeCompraNeto = decimal.Parse(this._dtDatosRevista.Rows[i]["IMPORTECOMPRANETO"].ToString());
            decimal? importeVentaNeto = decimal.Parse(this._dtDatosRevista.Rows[i]["IMPORTEVENTANETO"].ToString());
            //

            order.OrdenInterna.CodigoPaseTipo = order.OrdenInterna.CodigoPaseTipo ?? "0";
            order.OrdenInterna.CambioAplicado = 1;
            order.OrdenInterna.CambioOficial = 1;
            order.OrdenInterna.DeCierre = false;
            order.OrdenInterna.DescuentoAgenciaCompra = 0;
            order.OrdenInterna.DescuentoAgenciaVenta = 0;
            order.OrdenInterna.DescuentoNegociacionCompra = 0;
            order.OrdenInterna.DescuentoNegociacionVenta = 0;
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
            order.OrdenInterna.ImporteVentaNeto = importeVentaNeto;
            order.OrdenInterna.ImporteVentaNeto_Divisa = importeVentaNeto;
            order.OrdenInterna.Rappel = true;
            order.OrdenInterna.ReferenciaFactura = "";
            order.OrdenInterna.ImporteUnitario = 0;
            order.OrdenInterna.ImporteUnitario_Divisa = 0;
            order.OrdenInterna.CodigoUsuario = this.mmsCodUsuario;
            order.OrdenInterna.NoInserciones = 1;

            //Nuevos campos JJP
            order.OrdenInterna.DescuentoAgenciaCompra = decimal.Parse(this._dtDatosRevista.Rows[i]["DESCUENTOCASCADA"].ToString());
            order.OrdenInterna.DescuentoAgenciaVenta = decimal.Parse(this._dtDatosRevista.Rows[i]["DESCUENTOCASCADA"].ToString());

            order.OrdenInterna.Formato = new TipoAnuncioEntidad() { CodigoPais = 32, Codigo = int.Parse(this._dtDatosRevista.Rows[i]["FORMATO"].ToString()) };

            order.OrdenInterna.Duracion = new TipoAnuncioDetalleEntidad();
            order.OrdenInterna.Duracion.ValorAnuncio = int.Parse(this._dtDatosRevista.Rows[i]["COLOR"].ToString());

            order.OrdenInterna.Material = new MaterialEntidad() { Codigo = int.Parse(this._dtDatosRevista.Rows[i]["MATERIAL"].ToString()) };

            //AGuzzardi 11/06/2010 ------------------------------------------------------
            if (order.OrdenInterna.Material.Codigo == 0)
            { order.OrdenInterna.Material = null; }
            

            //-----------------------------------------------------------------------------------

            if (order.OrdenInterna.Formato.Codigo == 2)
            {
                order.OrdenInterna.Ancho = decimal.Parse(this._dtDatosRevista.Rows[i]["ANCHO"].ToString());
                order.OrdenInterna.Alto = decimal.Parse(this._dtDatosRevista.Rows[i]["ALTO"].ToString());

                order.OrdenInterna.ImporteUnitario = importeCompra / order.OrdenInterna.Ancho / order.OrdenInterna.Alto;
                order.OrdenInterna.ImporteUnitario_Divisa = importeCompra / order.OrdenInterna.Ancho / order.OrdenInterna.Alto;
            }
            ///////////////////

            order.OrdenInterna.Descuentos = this.RecogerDescuentos(i);
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

        private ColeccionNegocioBase<OrdenDescuentoRecargoEntidad> setDescuentos(int i)
        {
            OrdenDescuentoRecargoEntidad descuento = new OrdenDescuentoRecargoEntidad();
            ColeccionNegocioBase<OrdenDescuentoRecargoEntidad> listDescuentos = new ColeccionNegocioBase<OrdenDescuentoRecargoEntidad>();

            for (int p = 1; p < 11; p++)
            {

                descuento = new OrdenDescuentoRecargoEntidad();
                if (p >= 6)
                {
                    descuento.EsRecargo = false;
                }
                else
                {
                    descuento.EsRecargo = true;
                }
                descuento.EsRecargo = true;
                string desCol = "DCTO" + p;
                descuento.Porcentaje = decimal.Parse(this._dtDatosRevista.Rows[i][desCol].ToString());
                descuento.Descripcion = "Dt/Rec";
                descuento.Aplicacion = true;
                listDescuentos.Add(descuento);
                p = p + 1;
            }
            return listDescuentos;
        }

        public ColeccionNegocioBase<OrdenDescuentoRecargoEntidad> RecogerDescuentos(int i)
        {
         
            
            
            /* ColeccionNegocioBase<OrdenDescuentoRecargoEntidad> resulta = new ColeccionNegocioBase<OrdenDescuentoRecargoEntidad>();
            AgenteGenerico Agente = new AgenteGenerico();
            TipoDescuentoRecargoFiltro filtro = new TipoDescuentoRecargoFiltro();
            filtro.Criterio = Expresion.And(filtro.Criterio, Expresion.Eq(TipoDescuentoRecargoFiltro.COD_PAIS, 32));
            filtro.Criterio = Expresion.And(filtro.Criterio, Expresion.Eq(TipoDescuentoRecargoFiltro.COD_ENTIDAD, TipoDescuentoRecargoEntidad.CODIGO_ENTIDAD_ORDEN));
            //coleccionTipoDescuento = Agente.ObtenerElementos<TipoDescuentoRecargoEntidad>(new TipoDescuentoRecargoEntidad(), filtro);
            coleccionTipoDescuento = new AgenteMaestro().obtenerElementosTipoDescuentoRecargoEntidad(filtro);
            int f = 1;
            try
            {
                for (int j = 1; j < 11; j++)
                {
                    string colName = "DCTO" + f;
                    decimal? _porcentaje = int.Parse(this._dtDatosRevista.Rows[i][colName].ToString());

                    OrdenDescuentoRecargoEntidad entidad = new OrdenDescuentoRecargoEntidad();
                    entidad.Codigo = null;

                    if (entidad.Porcentaje * -1 < 0)
                        entidad.EsRecargo = false;
                    else
                        entidad.EsRecargo = true;

                    entidad.TipoDescuento = new TipoDescuentoRecargoEntidad();

                    entidad.TipoDescuento = coleccionTipoDescuento.Buscar(new ColeccionFiltro(TipoDescuentoRecargoEntidad.CODIGO_TIPO_DTOREC, 1));
                    if (entidad.TipoDescuento == null)
                        continue;
                    entidad.TipoUso = entidad.TipoDescuento.TipoUso;
                    entidad.Descripcion = "Dt/Rec";
                    entidad.Porcentaje = _porcentaje;
                    entidad.Operacion = TiposOperacion.Insertar;//ObtenerTipoOperacion(dtRow.ItemArray[5], operacion);

                    resulta.Add(entidad);

                    if (f == 5)
                        f = 0;

                    f = f + 1;
                }
            }
            catch (Exception ex)
            {
                ex = new Exception(ex.Message, ex);
            }
            return resulta;*/

            // AG ID 16480 27/08/2010 ------------------------------------------------------------------------------------------------------------------------------------------
            DataTable dtDesc = new DataTable();
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
                    tipoBasico.Pais = new PaisEntidad() { CodPais = 32 };
                    tipo.TipoUso = tipoBasico;
                    tipo.DescripcionTipo = "Generico Compra";
                    tipo.CodigoTipo = 1; // DESCUENTOS DE COMPRA
                }

                newDescuento.Codigo = null;
                newDescuento.TipoDescuento = tipo;
                newDescuento.Porcentaje = decimal.Parse(this._dtDatosRevista.Rows[i][colName].ToString());
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
            //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
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
                    this._dtDatosRevista = null;
                }
            }
            _disposed = true;
        }

        #endregion
    }
}
