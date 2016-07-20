namespace SIM
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Data;
    using HM.MMS.AR.Server.BusinessEntity.Ordenes;
    using HM.MMS.AR.Server.BusinessEntity.Ordenes.Prensa;
    using HM.Contratos.Entidad.Ordenes;
    using HM.Contratos.Entidad.Campanas;
    using HM.Contratos.Entidad.Maestros;
    using HM.Contratos.Entidad.Soportes;
    using HM.MMS.Core.Server.BusinessEntity.Ordenes.PR;
    using HM.Comun.Utilidades;
    using HM.Contratos.Entidad.Configuracion;
    using HM.MMS.Cliente.Comun.Compra.Winforms.Ordenes;
    using HM.Contratos.Entidad.Seguridad;
    using HM.Comun.Persistencia.Entidad.CriterioFiltro;
    using HM.MMS.Agentes.Compra;
    using HM.MMS.Agentes.Comun;
    using HM.Comun.Varios;

    /// <summary>
    /// Clase encargada de mapear los datos correspondientes a el Medio Prensa.
    /// </summary>
    public class OrdenPrensaDataMapper : IDisposable
    {
        #region Propiedades

        private bool _disposed = false;

        public DataTable _dtDatosPrensa;
        private OrdenPrensa _ordenPrensa;
        private List<OrdenPrensa> listOrdenPrensa = new List<OrdenPrensa>();
        public DataTable dtAvisosInsertados;

        public ColeccionNegocioBase<PresupuestoEntidad> lstPresupuestos;
        public static ColeccionNegocioBase<TipoDescuentoRecargoEntidad> coleccionTipoDescuento;
        public int idCampaniaMMS;
        public int idSubCampanaMms;
        public int mmsCodPais;
        public int mmsCodUsuario;
        public int mmsCodCompania;
        public int codMedio;

        #endregion

        #region Constructor

        public OrdenPrensaDataMapper(DataTable _value, int idCampaniaMMS, int idSubCampanaMms, int mmsCodPais, int mmsCodUsuario, int mmsCodCompania)
        {
            //Incializa los valores necesarios para realizar la inserccione de ordenes.
            this._dtDatosPrensa = _value;
            this.idCampaniaMMS = idCampaniaMMS;
            this.idSubCampanaMms = idSubCampanaMms;
            this.mmsCodPais = mmsCodPais;
            this.mmsCodUsuario = mmsCodUsuario;
            this.mmsCodCompania = mmsCodCompania;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Establece una nueva orden prensa con los valores recuperados.
        /// </summary>
        public void SetNewOrdenPrensaObject()
        {
            try
            {
                var results = new Dictionary<OrdenEverest, int?>();

                for (int i = 0; i < this._dtDatosPrensa.Rows.Count; i++)
                {
                    long? _idSpot = (long?)this._dtDatosPrensa.Rows[i]["CODIGOSPOT"]; ;
                    long? _idSpotDetalle = (long?)this._dtDatosPrensa.Rows[i]["CODIGOSPOTDETALLE"]; ;

                    OrdenPrensa newOrder = new OrdenPrensa();

                    newOrder.EsOrdenEverest = true;
                    newOrder.Material = this._dtDatosPrensa.Rows[i]["MATERIAL"].ToString();
                    newOrder.CodigoCompania = int.Parse(this._dtDatosPrensa.Rows[i]["CODIGOCOMPANIA"].ToString());
                    newOrder.CodigoConvenio = (this._dtDatosPrensa.Rows[i]["CODIGOCONVENIO"].ToString()) == "" ? 0 : int.Parse(this._dtDatosPrensa.Rows[i]["CODIGOCONVENIO"].ToString());
                    newOrder.CodigoOrden = 0;
                    newOrder.Monitoreada = false;
                    //arreglar este hardcode dcaime 17/06/2010
                    //newOrder.TituloAnuncio = "Envio Compra Presna";
                    newOrder.TituloAnuncio = this._dtDatosPrensa.Rows[i]["CONCEPTO"].ToString();
                    //Seteo los valores de OrdenEverest.
                    newOrder.OrdenEverest = new OrdenEverest(null, null);
                    newOrder.OrdenEverest.CodigoSpot = (long?)this._dtDatosPrensa.Rows[i]["CODIGOSPOT"];
                    newOrder.OrdenEverest.CodigoSpotDetalle = (long?)this._dtDatosPrensa.Rows[i]["CODIGOSPOTDETALLE"];
                    newOrder.OrdenEverest.CodigoCampania = int.Parse(this._dtDatosPrensa.Rows[i]["CODIGOCAMPANIA"].ToString());
                    newOrder.OrdenEverest.CodigoEjercicio = int.Parse(this._dtDatosPrensa.Rows[i]["CODIGOEJERCICIO"].ToString());
                    newOrder.OrdenEverest.CodigoSistema = int.Parse(this._dtDatosPrensa.Rows[i]["CODIGOSISTEMA"].ToString());

                    OrdenPrensa ordenTemp = new OrdenPrensa();

                    //ordenTemp = this.SetOrderInterna(newOrder, i);
                    ordenTemp = this.SetOrderInterna(newOrder, i);
                    this.listOrdenPrensa.Add(ordenTemp);    
                }

                results = OrdenPrensaManager.insertar_spotPrensa(this.listOrdenPrensa, this.idCampaniaMMS, this.idSubCampanaMms, this.mmsCodPais, this.mmsCodUsuario, this.mmsCodCompania);
                
                vueltaAvisosInsertados(results);

                this.Dispose(true);
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
                newDescuento.Porcentaje = decimal.Parse(this._dtDatosPrensa.Rows[i][colName].ToString());
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
            //return listDesc = GestorOrdenes.RecogerDescuentos(dtDesc, TiposOperacion.Insertar, this.mmsCodPais.ToString());
        }

        /// <summary>
        /// RECORREMOS EL DICCIONARIO Y LLENAMOS UN DATATABLE QUE DEVOLVEMOS A EVEREST
        /// SE AGREGA SOLO LOS SPOTS_DETALLE QUE TENGAN ASOCIADOS UNA ORDEN DE MMS
        /// </summary>
        /// <param name="lstOrdenesInsertadas"></param>
        /// <returns>DT</returns>
        public void vueltaAvisosInsertados(Dictionary<OrdenEverest, int?> lstOrdenesInsertadas)
        {
            dtAvisosInsertados = new DataTable();
            formatearTabla(dtAvisosInsertados);
            DataRow drAviso = null;

            foreach (KeyValuePair<OrdenEverest, int?> var in lstOrdenesInsertadas)
            {
                if (var.Value != null && var.Value != -1)
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
        private void formatearTabla(DataTable dt)
        {
            //agregar el nombre
            dtAvisosInsertados.Columns.Add("id_spot", typeof(long));
            dtAvisosInsertados.Columns.Add("id_spot_detalle", typeof(long));
            dtAvisosInsertados.Columns.Add("id_orden_mms", typeof(long));
        }

        #endregion

        #region Temp

        private OrdenPrensa SetOrderInterna(OrdenPrensa order, int i)
        {
            int codigoCampana = this.idCampaniaMMS;
            int codigoSubcampana = this.idSubCampanaMms;
            int codigoMedio = 4;
            int codPais = this.mmsCodPais;
            int codCompania = this.mmsCodCompania;
            int codigoSoporte = int.Parse(this._dtDatosPrensa.Rows[i]["ID_SOPORTE"].ToString());// Convert.ToInt32(txtSoporte.Text);
            int codigoPresupuesto = int.Parse(this._dtDatosPrensa.Rows[i]["CODIGOPRESUPUESTO"].ToString());

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

            //GDG 20100125
            var nuevaOrden = new GestorOrdenes().InicializaOrden_Prensa(presupuesto, true, "1", "5");

            //JJP 17012011 - Vuelvo a poner el intercambio en el presupuesto.
            nuevaOrden.Presupuesto.Intercambio = intecambio;

            nuevaOrden.Compania = new CompaniaEntidad() { Codigo = codCompania };

            order.OrdenInterna = nuevaOrden;

            order.OrdenInterna.CodigoOrden = -1;
            order.OrdenInterna.Estado = 1;
            order.OrdenInterna.CambioOficial = order.OrdenInterna.CambioOficial ?? 0;
            order.OrdenInterna.CambioAplicado = order.OrdenInterna.CambioOficial;
            //arreglar este hardcode dcaime 17/06/2010 CONCEPTO
            //order.OrdenInterna.TituloAnuncio = "Prensa " + DateTime.Today.ToShortDateString();
            order.OrdenInterna.TituloAnuncio = this._dtDatosPrensa.Rows[i]["CONCEPTO"].ToString();
            order.OrdenInterna.FechaEjecucion = DateTime.Parse(this._dtDatosPrensa.Rows[i]["F_SPOT"].ToString());//dcaime 24062010
            order.OrdenInterna.Rappel = false;
            order.OrdenInterna.Formato = new TipoAnuncioEntidad() { CodigoPais = 32, Codigo = int.Parse(this._dtDatosPrensa.Rows[i]["FORMATO"].ToString()) };

   
            order.OrdenInterna.Duracion = new TipoAnuncioDetalleEntidad();
            order.OrdenInterna.Duracion.ValorAnuncio = int.Parse(this._dtDatosPrensa.Rows[i]["COLOR"].ToString());

            order.OrdenInterna.Material = new MaterialEntidad() { Codigo = int.Parse(this._dtDatosPrensa.Rows[i]["MATERIAL"].ToString())};
            
            //AGuzzardi 11/06/2010 ------------------------------------------------------
            if (order.OrdenInterna.Material.Codigo == 0)
            {order.OrdenInterna.Material = null;}
            //-----------------------------------------------------------------------------------

            // revisar dcaime
            order.OrdenInterna.TituloAnuncio = this._dtDatosPrensa.Rows[i]["PROGRAMADESCRIPCION"].ToString();
            
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

            //dcaime arreglo 30/06/2010
            int? _codSeccion = int.Parse(_dtDatosPrensa.Rows[i]["id_seccion"].ToString());
            order.OrdenInterna.Seccion = new SeccionEntidad() { Codigo = _codSeccion };//((int?)this._dtDatosPrensa.Rows[i]["id_seccion"]) };
            // { Codigo = 1 };

            order.OrdenInterna.Delegacion = new DelegacionEntidad() { CodDelegacion = 1 };

            //Importes
            decimal? importeCompra = decimal.Parse(this._dtDatosPrensa.Rows[i]["IMPORTECOMPRA"].ToString());
            decimal? importeVenta = decimal.Parse(this._dtDatosPrensa.Rows[i]["IMPORTEVENTA"].ToString());
            decimal? importeCompraNeto = decimal.Parse(this._dtDatosPrensa.Rows[i]["IMPORTECOMPRANETO"].ToString());
            decimal? importeVentaNeto = decimal.Parse(this._dtDatosPrensa.Rows[i]["IMPORTEVENTANETO"].ToString());

            //

            order.OrdenInterna.CodigoPaseTipo = order.OrdenInterna.CodigoPaseTipo ?? "0";
            order.OrdenInterna.CambioAplicado = 1;
            order.OrdenInterna.CambioOficial = 1;
            order.OrdenInterna.DeCierre = false;
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
            
            order.OrdenInterna.Rappel = true;
            order.OrdenInterna.ReferenciaFactura = "";
            order.OrdenInterna.ImporteUnitario = importeCompra;
            order.OrdenInterna.ImporteUnitario_Divisa = 0;
            order.OrdenInterna.DescuentoAgenciaCompra = decimal.Parse(this._dtDatosPrensa.Rows[i]["DESCUENTOCASCADA"].ToString());
            order.OrdenInterna.DescuentoAgenciaVenta = decimal.Parse(this._dtDatosPrensa.Rows[i]["DESCUENTOCASCADA"].ToString());
            order.OrdenInterna.Ancho = decimal.Parse(this._dtDatosPrensa.Rows[i]["ANCHO"].ToString());
            order.OrdenInterna.Alto = decimal.Parse(this._dtDatosPrensa.Rows[i]["ALTO"].ToString());
            order.OrdenInterna.NoInserciones = 1;

            if (order.OrdenInterna.Formato.Codigo == 2)
            {
                order.OrdenInterna.ImporteUnitario = importeCompra / order.OrdenInterna.Ancho / order.OrdenInterna.Alto;
                order.OrdenInterna.ImporteUnitario_Divisa = importeCompra / order.OrdenInterna.Ancho / order.OrdenInterna.Alto;
            }

            order.OrdenInterna.Descuentos = this.setDescuentos(i);

            return order;
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
                    this._dtDatosPrensa = null;
                    this._ordenPrensa = null;
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
        OrdenPrensaDataMapper()
        {
            // Llamo al método que contiene la lógica
            // para liberar los recursos de esta clase.
            Dispose(true);
        }

        #endregion
    }
}
