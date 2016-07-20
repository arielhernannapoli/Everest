
namespace SIM
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using HM.MMS.AR.Server.BusinessEntity.Ordenes;
    using HM.MMS.AR.Server.BusinessEntity.Ordenes.Internet;
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
    using HM.MMS.AR.Cliente.Informes.Winforms;
    using HM.Localizacion.Informes;
    using HM.Contratos.Entidad.Configuracion;
    using HM.MMS.Agentes.Informes;
    using HM.Contratos.Entidad.Informes;
    using System.Collections;
    using HM.MMS.Agentes.Proveedores;
    using System.Collections.ObjectModel;
    using System.Threading;
    using HM.Forms.Controles;
    using HM.Forms.Pantallas;
    using HM.Localizacion;
    using HM.Localizacion.Estados;
    using HM.Localizacion.Operaciones;
    using HM.MMS.Agentes;
    using HM.MMS.AR.Client.Reportes; 
    using HM.MMS.AR.Client.Reportes.Reportes.Contratos;
    using HM.MMS.Cliente.Comun.Winforms;
    using HM.MMS.Cliente.OperacionesNegocio;
    using System.ComponentModel;
    using Framework.ExportacionUtil;
    using System.IO;

    public class OrdenIntDataMapper
    {

        #region Propiedades

        private bool _disposed = false;
        public DataTable _dtDatosInt;
        private List<OrdenInternet> listOrdenesInternet = new List<OrdenInternet>();
        static DataTable dtReturn;
        public DataTable dtAvisosInsertados;
        public int idCampaniaMMS;
        public int idSubCampanaMms;
        public int mmsCodPais;
        public int mmsCodUsuario;
        public int mmsCodCompania;
        public int mmsCodCliente;
        public string mesPresupuestos;
        public string anioPresupuestos;
        public string codigoPresupuestos;
        public bool esEnvioDoble;
        //LC 24/07/2014 Envio mail con los contratos
        private Hashtable HashContratos = new Hashtable();
        private Hashtable HashOrdenesContrato = new Hashtable();
        private Hashtable HashSoporteContratos = new Hashtable();
        private Dictionary<long, ColeccionNegocioBase<long>> HashFaxes = new Dictionary<long, ColeccionNegocioBase<long>>();
        private Dictionary<long, ColeccionNegocioBase<string>> HashMails = new Dictionary<long, ColeccionNegocioBase<string>>();
        private Collection<Preview> ColeccionVisores = new Collection<Preview>();
        private Collection<string> rutas = new Collection<string>();
        private int paginas = 0;

        //AS 2015/03 =======================================================================
        private BackgroundWorker bWorker;
        #endregion

        #region Metodos

        public OrdenIntDataMapper(DataTable _value, int idCampaniaMMS, int idSubCampanaMms, int mmsCodPais, int mmsCodUsuario, int mmsCodCompania, int mmsCodCliente, string mesPresupuestos, string anioPresupuestos, string codigoPresupuestos, bool esEnvioDoble)
        {
            _dtDatosInt = _value;
            this.idCampaniaMMS = idCampaniaMMS;
            this.idSubCampanaMms = idSubCampanaMms;
            this.mmsCodPais = mmsCodPais;
            this.mmsCodUsuario = mmsCodUsuario;
            this.mmsCodCompania = mmsCodCompania;
            this.mmsCodCliente = mmsCodCliente;
            this.mesPresupuestos = mesPresupuestos;
            this.anioPresupuestos = anioPresupuestos;
            this.codigoPresupuestos = codigoPresupuestos;
            this.esEnvioDoble = esEnvioDoble;

            //AS 2015/03 =======================================================================
            this.bWorker = new BackgroundWorker();
            this.bWorker.DoWork += new DoWorkEventHandler(ExportarOrdenDigitalBackground);
        }

        //AS 2014/12/29 =======================================================================
        private void ExportarOrdenDigitalBackground(object sender, DoWorkEventArgs e)
        {

            List<string> argumentList = e.Argument as List<string>;
            //String origen = (String)e.Argument+".pdf";
            String origen = argumentList.ElementAt(0)+ ".pdf";

            string destino = string.Format("{0}{1}", ParametrosExportacionLegajos.RutaExportacionOrdenInternet, argumentList.ElementAt(2) + "_" + argumentList.ElementAt(1) + ".pdf");
            
            try
            {
                File.Copy(origen, destino);
            }
            catch  (Exception ex)
            {

                //Reportes.Util.LogExportacionLegajo(param);
            }
            e.Result = 0;
        }

        public DataTable SetNewOrdenExtObject()
        {
            try
            {
                if (esEnvioDoble)
                {
                    // NUEVO DESARROLLO DE ENVIO A COMPRAS LIGERO DE INTERNET (AN 16-09-2015)
                    if (_dtDatosInt.Rows.Count > 0)
                    {
                        var oEnvioLigeroMMS = new SIM.DataMapper.Envio_Ligero_MMS(_dtDatosInt, mmsCodCompania, mmsCodCliente, mmsCodUsuario, idCampaniaMMS, idSubCampanaMms, mesPresupuestos, anioPresupuestos, codigoPresupuestos);
                        dtReturn = oEnvioLigeroMMS.Envio_Cabecera_MMS_Internet();
                    }

                    this.Dispose(true);
                    return dtReturn;
                }
                else
                {
                    var results = new Dictionary<OrdenEverest, int?>();

                    for (int i = 0; i < this._dtDatosInt.Rows.Count; i++)
                    {
                        OrdenWebEntidad OrdWebInternet = new OrdenWebEntidad();
                        OrdenEntidad OrdEntidadInt = new OrdenEntidad();
                        OrdenInternet OrdInternet = new OrdenInternet() { OrdenInterna = OrdWebInternet as OrdenWebEntidad };

                        OrdInternet.EsOrdenEverest = true;
                        OrdInternet.CodigoConvenio = (this._dtDatosInt.Rows[i]["CODIGOCONVENIO"].ToString()) == "" ? 0 : int.Parse(this._dtDatosInt.Rows[i]["CODIGOCONVENIO"].ToString());
                        OrdInternet.Material = null;// this._dtDatosInt.Rows[i]["PROGRAMADESCRIPCION"].ToString();
                        OrdInternet.CodigoCompania = int.Parse(this._dtDatosInt.Rows[i]["CODIGOCOMPANIA"].ToString());
                        OrdInternet.CodigoOrden = 0;
                        OrdInternet.Monitoreada = false;
                        OrdInternet.TituloAnuncio = this._dtDatosInt.Rows[i]["PROGRAMADESCRIPCION"].ToString();

                        //Seteo los valores de OrdenEverest.
                        OrdInternet.OrdenEverest = new OrdenEverest(null, null);
                        OrdInternet.OrdenEverest.CodigoSpot = (long?)this._dtDatosInt.Rows[i]["CODIGOSPOT"];
                        OrdInternet.OrdenEverest.CodigoSpotDetalle = 0;//(long?)this._dtDatosInt.Rows[i]["CODIGOSPOTDETALLE"];
                        OrdInternet.OrdenEverest.CodigoCampania = int.Parse(this._dtDatosInt.Rows[i]["CODIGOCAMPANIA"].ToString());
                        OrdInternet.OrdenEverest.CodigoEjercicio = int.Parse(this._dtDatosInt.Rows[i]["CODIGOEJERCICIO"].ToString());
                        OrdInternet.OrdenEverest.CodigoSistema = int.Parse(this._dtDatosInt.Rows[i]["CODIGOSISTEMA"].ToString());

                        //==== Datos propios de INTERNET SPOTS ==========
                        OrdInternet.CantidadDias = int.Parse(this._dtDatosInt.Rows[i]["CANTIDAD_DIAS"].ToString());
                        OrdInternet.CantidadHoras = int.Parse(this._dtDatosInt.Rows[i]["CANTIDAD_HORAS"].ToString());
                        OrdInternet.CodigoTipoCompra = int.Parse(this._dtDatosInt.Rows[i]["ID_TIPO_COMPRA"].ToString());
                        OrdInternet.Inversion = Math.Round(decimal.Parse(this._dtDatosInt.Rows[i]["IMPORTEVENTANETO"].ToString()), 2);

                        switch (int.Parse(this._dtDatosInt.Rows[i]["ID_TIPO_COMPRA"].ToString()))
                        {
                            case 2: //CPC
                                OrdInternet.CantidadComprada = int.Parse(this._dtDatosInt.Rows[i]["CLICKS"].ToString());
                                break;
                            case 3: //CPV
                                OrdInternet.CantidadComprada = int.Parse(this._dtDatosInt.Rows[i]["VIEWS"].ToString());
                                break;
                            case 9:
                                OrdInternet.CantidadComprada = int.Parse(this._dtDatosInt.Rows[i]["CA"].ToString()); //AG 07/01/2014
                                break;
                            case 1: //Todos lo demas Tipos
                            case 4:
                            case 5:
                            case 6:
                            case 8:
                            case 7:
                                OrdInternet.CantidadComprada = int.Parse(this._dtDatosInt.Rows[i]["IMPRESIONES"].ToString());
                                break;
                        }
                        listOrdenesInternet.Add(this.SetOrdenInterna(OrdInternet, i));
                    }
                    //LC 02/07/2014 Envio a compras avisos digital Emitidos y con contrato
                    List<OrdenWebEntidad> listaOrdenesWeb = new List<OrdenWebEntidad>();
                    ContratoAgente contratoAgente = new ContratoAgente();
                    foreach (var ordenWeb in listOrdenesInternet)
                    {
                        listaOrdenesWeb.Add(ordenWeb.OrdenInterna);
                    }
                    ColeccionNegocioBase<ContratoEntidad> contratos = contratoAgente.EmisionContratos(Convertidor.ToColeccionNegocioBaseGeneric<OrdenEntidad>(listaOrdenesWeb));
                    foreach (var contrato in contratos)
                    {
                        foreach (var orden in listOrdenesInternet)
                        {
                            if (orden.OrdenInterna.Soporte.Codigo == contrato.Soporte.Codigo && orden.OrdenInterna.Presupuesto.Codigo == contrato.CodigoPresupuesto)
                            {
                                if (orden.OrdenInterna.Contrato == null)
                                    orden.OrdenInterna.Contrato = new ContratoEntidad();
                                orden.OrdenInterna.Contrato.CodigoContrato = contrato.CodigoContrato;
                                orden.OrdenInterna.Soporte.Idioma.CodISO = Thread.CurrentThread.CurrentCulture.Name;
                                orden.OrdenInterna.Estado += 4;
                            }
                        }
                    }

                    results = OrdenIntManager.insertar_spotInt(this.listOrdenesInternet, this.idCampaniaMMS, this.idSubCampanaMms, this.mmsCodPais, this.mmsCodUsuario, this.mmsCodCompania);

                    this.SetOrderReturn(results, listOrdenesInternet);

                    this.Dispose(true);

                    dtReturn = this.dtAvisosInsertados;
                    //LC 24/07/2014 Envio mail con los contratos
                    this.CrearContratoPDF(dtReturn);

                    return dtReturn;
                }
            }
            catch (Exception ex)
            {
                this.Dispose(true);
                throw new Exception(ex.Message);
            }
        }

        //LC 24/07/2014 Envio mail con los contratos
        private void CrearContratoPDF(DataTable pContratos)
        {
            if (!pContratos.Columns.Contains("datos_mail"))
                pContratos.Columns.Add("datos_mail", typeof(String));

            foreach (DataRow row in pContratos.Rows)
            {
                var codigoContrato = Convert.ToInt32(row["ID_CONTRATO"]);
                var coidgoCompania = listOrdenesInternet.Find(x => x.OrdenInterna.CodigoContrato == codigoContrato).OrdenInterna.Presupuesto.Subcampana.Campana.Compania.Codigo;
                ColeccionNegocioBase<OrdenWebEntidad> ColeccionOrdenesTotal = new ColeccionNegocioBase<OrdenWebEntidad>();
                ColeccionOrdenesTotal = ObtenerOrdenesWeb(codigoContrato, coidgoCompania);
                var orden = ColeccionOrdenesTotal.Find(x => x.CodigoContrato == codigoContrato);

                if (orden == null)
                    return;

                if (!HashSoporteContratos.ContainsKey(orden.Soporte.Codigo))
                    HashSoporteContratos.Add(orden.Soporte.Codigo, orden.Soporte.Descripcion);
                Preview visorPre = null;         
                ReportContratoGenerico informe;
                informe = (ReportContratoGenerico)FactoriaReport.getInstancia(typeof(ReportContratos), HM.Localizacion.ConstantesLocalizacion.INFORMES_CONTRATOS);
                informe.Identificador = ObtenerIdentificador(codigoContrato, ContratoEntidad.TipoDocumentoContratoCN, orden.Presupuesto.Subcampana.Campana.Compania.Codigo, orden.Presupuesto.Subcampana.Campana.Compania.Pais.CodPais);
                informe.TipoDocumento = ContratoEntidad.TipoDocumentoContratoCN;
                informe.Medio = orden.Presupuesto.Subcampana.Medio.CodMedio.Value;
                informe.codigoConrato = codigoContrato;
                informe.Orientacion = OrientacionImpresion.Apaisado;
                informe.ColDatosFaxMail = new Dictionary<String, String>();
                informe.ColDatosFaxMail.Add(MailFax.TipoCamposExtra.DescripcionCliente.ToString(), orden.Presupuesto.Subcampana.Campana.Cliente.DescripcionCliente);
                informe.ColDatosFaxMail.Add(MailFax.TipoCamposExtra.NumeroContrato.ToString(), codigoContrato.ToString());
                informe.ColDatosFaxMail.Add(MailFax.TipoCamposExtra.NumeroSoporte.ToString(), orden.Soporte.Codigo.ToString());
                informe.emision = 0;
                informe.coleccionMov = null;
                informe.Agrupa = false;

                if (ColeccionOrdenesTotal.Count > 0)
                {
                    informe.coleccionOrdenesWeb = ColeccionOrdenesTotal;
                    VisualizacionInforme(ref visorPre, informe, orden.Presupuesto.Subcampana.Campana.Compania.Pais.CodPais, orden.Presupuesto.Subcampana.Medio.CodMedio.Value);
                }
                if (visorPre != null)
                {
                    var nombreArchivo = orden.Proveedor.Codigo.Value.ToString() + "_" + orden.Soporte.Codigo.ToString() + "_" + orden.Presupuesto.Subcampana.Campana.Cliente.DescripcionCliente + "_" + codigoContrato.ToString();
                    nombreArchivo = nombreArchivo.Replace(" ", "_");
                    ColeccionVisores.Add(visorPre);
                    visorPre.ColeccionVisores = ColeccionVisores;
                    
                    string tempFolder = @"C:\Temp\";
                    string tempName = string.Format("{0}{1}", tempFolder, nombreArchivo);

                    visorPre.GuardarPDF(tempFolder, nombreArchivo);
                    row["DATOS_MAIL"] = orden.Soporte.Descripcion + "|" + orden.Presupuesto.Subcampana.Campana.Cliente.DescripcionCliente + "|" + orden.Presupuesto.Subcampana.Campana.Descripcion + "|" + orden.FechaEjecucion + "|" + orden.FechaEjecucionFin + "|" + nombreArchivo;

                    //AS 2015/03======================
                    List<string > arguments = new List<string >();
                    arguments.Add(tempName);
                    arguments.Add(codigoContrato.ToString());
                    arguments.Add(orden.Compania.Codigo.ToString());
                    bWorker.RunWorkerAsync(arguments);
                }
            }    
        }

        


                   


        private void Visor_OperacionConfirmada(object sender, OperacionDetalleEventArgs<Hashtable> e)
        {
            try
            {
                Hashtable tabla = e.Entidad as Hashtable;

                string ruta = string.Empty;
                int pag = 0;

                foreach (DictionaryEntry elemento in tabla)
                {
                    ruta = elemento.Key.ToString();
                    pag = int.Parse(elemento.Value.ToString());
                    if (!rutas.Contains(ruta))
                    {
                        rutas.Add(ruta);
                        paginas = paginas + pag;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        //LC 16/07/2014 Exportacion masiva internet
        private ColeccionNegocioBase<OrdenWebEntidad> ObtenerOrdenesWeb(int pCodigoContrato, int pCodigoCompania)
        {
            ColeccionNegocioBase<OrdenWebEntidad> resulta = new ColeccionNegocioBase<OrdenWebEntidad>();
            ColeccionNegocioBase<OrdenWebEntidad> resultado = new ColeccionNegocioBase<OrdenWebEntidad>();
            ColeccionNegocioBase<OrdenWebEntidad> rParcial = new ColeccionNegocioBase<OrdenWebEntidad>();
            if (!HashOrdenesContrato.ContainsKey(pCodigoContrato))
            {
                OrdenAgente ordenAgente = new OrdenAgente();
                OrdenFiltro filtro = new OrdenFiltro();

                filtro.Criterio = Expresion.Eq(OrdenFiltro.COD_CONTRATO, pCodigoContrato);
                filtro.Criterio = Expresion.And(filtro.Criterio, Expresion.Eq(OrdenFiltro.COD_COMPANIA, pCodigoCompania));
                filtro.Criterio = Expresion.And(filtro.Criterio, Expresion.Bitand(OrdenFiltro.ESTADO, OrdenFiltro.ESTADO_BAJA, false));
                resulta = ordenAgente.obtenerOrdenesWeb(filtro, true);
                foreach (OrdenWebEntidad entidad in resulta)
                {
                    if (!HashOrdenesContrato.ContainsKey(entidad.Contrato.CodigoContrato))
                    {
                        rParcial = new ColeccionNegocioBase<OrdenWebEntidad>();
                        rParcial.Add(entidad);
                        HashOrdenesContrato.Add(entidad.Contrato.CodigoContrato, rParcial);
                    }
                    else
                    {
                        rParcial = HashOrdenesContrato[entidad.Contrato.CodigoContrato] as ColeccionNegocioBase<OrdenWebEntidad>;
                        rParcial.Add(entidad);
                        HashOrdenesContrato[entidad.Contrato.CodigoContrato] = rParcial;
                    }
                }
            }
            if (HashOrdenesContrato.ContainsKey(pCodigoContrato))
                resultado = HashOrdenesContrato[pCodigoContrato] as ColeccionNegocioBase<OrdenWebEntidad>;
            return resultado;
        }
        

        //LC 24/07/2014 Envio mail con los contratos
        private int ObtenerIdentificador(int pCodigoContrato, String TipoDocumento, int pCodigoCompana, int pCodigoPais)
        {
            ContratoEntidad mContrato = null;
            if (HashContratos.ContainsKey(pCodigoContrato))
                mContrato = HashContratos[pCodigoContrato] as ContratoEntidad;
            else
            {
                ContratoAgente agente = new ContratoAgente();
                ContratoFiltro filtro = new ContratoFiltro();
                filtro.Criterio = Expresion.Eq(ContratoFiltro.COD_CONTRATO, pCodigoContrato);
                ColeccionNegocioBase<ContratoEntidad> colContrato = agente.ObtenerContratos(filtro, null, true);
                if (colContrato != null && colContrato.Count > 0)
                    mContrato = colContrato[0];
            }
            if (mContrato == null) return -1;

            DocumentoAgente agenteDocumento = new DocumentoAgente();
            DocumentoFiltro filtroDocumento = new DocumentoFiltro();
            DocumentoCompaniaFiltro filtroDocumentoCompania = new DocumentoCompaniaFiltro();
            filtroDocumento.Criterio = Expresion.Eq(DocumentoFiltro.COD_TipoDocumento, TipoDocumento);
            filtroDocumentoCompania.Criterio = Expresion.Eq(DocumentoCompaniaFiltro.COD_COMPANIA, pCodigoCompana);
            filtroDocumentoCompania.Criterio = Expresion.And(filtroDocumentoCompania.Criterio, Expresion.Eq(DocumentoCompaniaFiltro.COD_PAIS, pCodigoPais));
            filtroDocumentoCompania.Criterio = Expresion.And(filtroDocumentoCompania.Criterio, Expresion.Eq(DocumentoCompaniaFiltro.COD_MEDIO, mContrato.Soporte.Medio.CodMedio.Value));
            filtroDocumentoCompania.Criterio = Expresion.And(filtroDocumentoCompania.Criterio, Expresion.Eq(DocumentoCompaniaFiltro.TIPO_DOC_COMPANIA, "C"));
            filtroDocumentoCompania.Criterio = Expresion.And(filtroDocumentoCompania.Criterio, Expresion.Ge(DocumentoCompaniaFiltro.F_FIN, DateTime.Parse(mContrato.FechaEmision.ToString())));
            filtroDocumentoCompania.Criterio = Expresion.And(filtroDocumentoCompania.Criterio, Expresion.Le(DocumentoCompaniaFiltro.F_INICIO, DateTime.Parse(mContrato.FechaEmision.ToString())));
            ColeccionNegocioBase<InformeEntidad> docInforme = agenteDocumento.obtenerDocumentos(filtroDocumento, filtroDocumentoCompania);
            if (docInforme != null && docInforme.Count > 0)
                return docInforme[0].Codigo;
            else return -1;
        }

        //LC 24/07/2014 Envio mail con los contratos
        private void VisualizacionInforme(ref Preview Visor, ReportContratoGenerico Informe, int pCodigoPais, int pCodigoMedio)
        {
            if (Visor == null)
            {
                Visor = new Preview(Informe, 1);

                
                DatosFaxmail(Informe, ref Visor, pCodigoPais, pCodigoMedio);
            }
        }

        //LC 24/07/2014 Envio mail con los contratos
        private void DatosFaxmail(ReportContratoGenerico Informe, ref Preview Visor, int pCodigoPais, int pCodigoMedio)
        {
            ObtenerContactos(pCodigoPais, pCodigoMedio);
            Visor.Faxes = HashFaxes;
            Visor.Correos = HashMails;
            Visor.FaxMail = true;
            Visor.AgruparEnvio = false;
            Visor.insertarInforme(Informe);
        }

        //LC 24/07/2014 Envio mail con los contratos
        private void ObtenerContactos(int pCodigoPais, int pCodigoMedio)
        {
            try
            {
                if (HashFaxes.Count > 0 || HashMails.Count > 0) return;

                SoporteFiltro filtro = new SoporteFiltro();

                foreach (DictionaryEntry item in HashSoporteContratos)
                {
                    filtro.Criterio = Expresion.Eq(SoporteFiltro.COD_SOPORTE, item.Key);
                    filtro.Criterio = Expresion.And(filtro.Criterio, Expresion.Eq(SoporteFiltro.COD_PAIS, pCodigoPais));
                    filtro.Criterio = Expresion.And(filtro.Criterio, Expresion.Eq(SoporteFiltro.COD_MEDIO, pCodigoMedio));
                }

                SoporteAgente agente = new SoporteAgente();

                ColeccionNegocioBase<SoporteEntidad> soportes = agente.obtenerSoportes(filtro, true);

                ColeccionNegocioBase<long> Faxes;
                ColeccionNegocioBase<string> Correos;

                foreach (SoporteEntidad soporte in soportes)
                {
                    Faxes = new ColeccionNegocioBase<long>();
                    Correos = new ColeccionNegocioBase<string>();

                    foreach (DomicilioEntidad domicilio in soporte.Domicilios)
                    {
                        long? mNumeroFax = ObtenerNumero(domicilio.Fax);
                        if (mNumeroFax.HasValue) Faxes.Add(mNumeroFax.Value);
                        if (!String.IsNullOrEmpty(domicilio.Mail)) Correos.Add(domicilio.Mail);

                        if (!HashFaxes.ContainsKey(soporte.Codigo))
                            HashFaxes.Add(soporte.Codigo, Faxes);
                        else
                            HashFaxes[soporte.Codigo] = Faxes;

                        if (!HashMails.ContainsKey(soporte.Codigo))
                            HashMails.Add(soporte.Codigo, Correos);
                        else
                            HashMails[soporte.Codigo] = Correos;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //LC 24/07/2014 Envio mail con los contratos
        private long? ObtenerNumero(string fax)
        {
            long? numero = 0;
            string cadena = string.Empty;

            try
            {
                if (fax == null) return 0;
                for (int i = 0; i <= fax.Length - 1; i++)
                    if (char.IsDigit(fax[i]))
                        cadena = cadena + fax[i];
                if (cadena == String.Empty)
                    numero = null;
                else
                    numero = long.Parse(cadena.ToString());
            }
            catch (Exception)
            {
                throw;
            }
            return numero;
        }

        protected OrdenInternet SetOrdenInterna(OrdenInternet order, int i)
        {
            int codigoCampana = this.idCampaniaMMS;
            int codigoSubcampana = this.idSubCampanaMms;
            int codigoMedio = 2;
            int codPais = this.mmsCodPais;
            int codCompania = this.mmsCodCompania;
            int codigoSoporte = int.Parse(this._dtDatosInt.Rows[i]["CODIGOSOPORTE"].ToString());
            int codigoPresupuesto = int.Parse(this._dtDatosInt.Rows[i]["CODIGOPRESUPUESTO"].ToString());

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
            
            IntercambioEntidad intecambio = presupuesto.Intercambio;
            presupuesto.Intercambio = null;

            OrdenWebEntidad nuevaOrden = new GestorOrdenes().InicializaOrden_Web(presupuesto, true, "1", "5");

            nuevaOrden.Presupuesto.Intercambio = intecambio;
            nuevaOrden.CodigoOrden = -1;
            nuevaOrden.Operacion = TiposOperacion.Insertar;
            
            nuevaOrden.Compania = new CompaniaEntidad(){ Codigo = this.mmsCodCompania };
            //nuevaOrden.Presupuesto.Subcampana.Campana.Cliente = new HM.Contratos.Entidad.Cliente.ClienteEntidad();
            //nuevaOrden.Presupuesto.Subcampana.Campana.Cliente.CodigoCliente = 10;

            order.OrdenInterna  = nuevaOrden;            
            order.OrdenInterna.Operacion = TiposOperacion.Insertar;

            order.CodigoOrden = -1;
            order.OrdenInterna.Estado = 1;
            order.OrdenInterna.CambioOficial = order.OrdenInterna.CambioOficial ?? 0;
            order.OrdenInterna.CambioAplicado = order.OrdenInterna.CambioOficial;

            order.TituloAnuncio = "";
            order.OrdenInterna.FechaCreacion = DateTime.Parse(this._dtDatosInt.Rows[i]["F_INICIO"].ToString());
            order.OrdenInterna.FechaEjecucion = DateTime.Parse(this._dtDatosInt.Rows[i]["F_INICIO"].ToString());
            order.OrdenInterna.FechaEjecucionFin = DateTime.Parse(this._dtDatosInt.Rows[i]["F_FIN"].ToString());
            order.OrdenInterna.Rappel = false;

            decimal? importeCompra = Math.Round(decimal.Parse(this._dtDatosInt.Rows[i]["INVERSION"].ToString()), 2);
            decimal? importeVenta = Math.Round(decimal.Parse(this._dtDatosInt.Rows[i]["INVERSION"].ToString()), 2);
            decimal? importeCompraNeto = Math.Round(decimal.Parse(this._dtDatosInt.Rows[i]["INVERSION"].ToString()), 2);
            decimal? importeVentaNeto = Math.Round(decimal.Parse(this._dtDatosInt.Rows[i]["INVERSION"].ToString()), 2);


            order.OrdenInterna.ImporteCPM = importeCompra;

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
            order.OrdenInterna.ImporteCompra_Divisa = Math.Round(decimal.Parse(this._dtDatosInt.Rows[i]["INVERSION"].ToString()), 2);
            order.OrdenInterna.ImporteCompraNeto = Math.Round(decimal.Parse(this._dtDatosInt.Rows[i]["INVERSION"].ToString()), 2);
            order.OrdenInterna.ImporteVentaNeto = Math.Round(decimal.Parse(this._dtDatosInt.Rows[i]["INVERSION"].ToString()), 2);
            order.OrdenInterna.ImporteCompra = Math.Round(decimal.Parse(this._dtDatosInt.Rows[i]["INVERSION"].ToString()), 2);
            order.OrdenInterna.ImporteTarifaCompra = Math.Round(decimal.Parse(this._dtDatosInt.Rows[i]["INVERSION"].ToString()), 2);
            order.OrdenInterna.ImporteTarifaCompra_Divisa = Math.Round(decimal.Parse(this._dtDatosInt.Rows[i]["INVERSION"].ToString()), 2);
            order.OrdenInterna.ImporteTarifaVenta = Math.Round(decimal.Parse(this._dtDatosInt.Rows[i]["INVERSION"].ToString()), 2);
            order.OrdenInterna.ImporteVenta = Math.Round(decimal.Parse(this._dtDatosInt.Rows[i]["INVERSION"].ToString()), 2);
            order.OrdenInterna.ImporteVenta_Divisa = Math.Round(decimal.Parse(this._dtDatosInt.Rows[i]["INVERSION"].ToString()), 2);
            order.OrdenInterna.ImporteVentaNeto_Divisa = Math.Round(decimal.Parse(this._dtDatosInt.Rows[i]["INVERSION"].ToString()), 2);
            //


            order.OrdenInterna.Colocacion = new ColocacionEntidad(); //TipoFormato
            order.OrdenInterna.Colocacion.Codigo = int.Parse(_dtDatosInt.Rows[i]["ID_TIPO_FORMATO"].ToString());

            order.OrdenInterna.Seccion = new SeccionEntidad(); //Ubicaciones
            order.OrdenInterna.Seccion.Codigo = int.Parse(_dtDatosInt.Rows[i]["ID_UBICACION"].ToString());

            order.OrdenInterna.Formato = new TipoAnuncioEntidad(); //TipoAnuncio
            order.OrdenInterna.Formato.Codigo = int.Parse(_dtDatosInt.Rows[i]["ID_FORMATO"].ToString()); ;

            order.OrdenInterna.Material = new MaterialEntidad();

            order.OrdenInterna.CodigoUsuario = this.mmsCodUsuario;
            order.OrdenInterna.NoInserciones = 0; 

            order.OrdenInterna.Soporte = new SoporteEntidad()
            {
                Codigo = codigoSoporte,
                Medio = new MedioEntidad()
                 {
                     CodMedio = 2,
                     Pais = new PaisEntidad() { CodPais = this.mmsCodPais }
                 },
                Moneda = new MonedaEntidad() { Codigo = 5 },
                Idioma = new IdiomaEntidad() { Codigo = 1 }
            };

            order.OrdenInterna.Proveedor = new ProveedorEntidad() { Codigo = int.Parse(_dtDatosInt.Rows[i]["ID_PROVEEDOR"].ToString()) };
            order.OrdenInterna.Proveedor.Pais = new PaisEntidad(){ CodPais = this.mmsCodPais };
 
            //order.OrdenInterna.Descuentos = this.setDescuentos(i); // No utiliza la coleccion de descuentos, pero si guarda el id_convenio
            
            return order;
        }

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
                newDescuento.Porcentaje = decimal.Parse(this._dtDatosInt.Rows[i][colName].ToString());
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

        #endregion

        #region Metodos_Extras

        public void SetOrderReturn(Dictionary<OrdenEverest, int?> lstOrdenesInsertadas, List<OrdenInternet> listOrdenesInternet)
        {
            dtAvisosInsertados = new DataTable();
            FormatDataTable(dtAvisosInsertados);
            DataRow drAviso = null;

            foreach (KeyValuePair<OrdenEverest, int?> var in lstOrdenesInsertadas)
            {
                if (var.Value != null)
                {
                    var orden = listOrdenesInternet.Find(delegate(OrdenInternet oi) { return oi.OrdenEverest.CodigoSpot == var.Key.CodigoSpot; });
                    drAviso = dtAvisosInsertados.NewRow();
                    drAviso["id_spot"] = var.Key.CodigoSpot;
                    drAviso["id_spot_detalle"] = var.Key.CodigoSpotDetalle;
                    drAviso["id_orden_mms"] = var.Value;
                    //LC 02/07/2014 Envio a compras avisos digital Emitidos y con contrato
                    drAviso["id_contrato"] = orden.OrdenInterna.Contrato.CodigoContrato.Value;
                    foreach (DataRow row in _dtDatosInt.Rows)
                    {
                        if (long.Parse(row["CODIGOSPOT"].ToString()) == var.Key.CodigoSpot)
                        {
                            drAviso["id_presupuesto"] = row["CODIGOPRESUPUESTO"];
                        }
                    }                    
                    dtAvisosInsertados.Rows.Add(drAviso);
                }
            } 
        }

        private void FormatDataTable(DataTable dt)
        {
            dtAvisosInsertados.Columns.Add("id_spot", typeof(long));
            dtAvisosInsertados.Columns.Add("id_spot_detalle", typeof(long));
            dtAvisosInsertados.Columns.Add("id_orden_mms", typeof(long));
            //LC 02/07/2014 Envio a compras avisos digital Emitidos y con contrato
            dtAvisosInsertados.Columns.Add("id_contrato", typeof(Int32));
            //ENVIO INTERNET SOCIALYSE (AN 24-09-2015)
            dtAvisosInsertados.Columns.Add("id_presupuesto", typeof(Int32));
        }

        public void Dispose()
        {
            Dispose(true);
        }

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
                    this._dtDatosInt = null;
                }
            }
            _disposed = true;
        }
        
        #endregion

    }
}
