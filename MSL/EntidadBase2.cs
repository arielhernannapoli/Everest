using System;
using System.Collections;//.Generic;

//using System.Text;
using System.Data;

//using HM.Contratos.Entidad.Seguridad;
//
using HM.Comun.Agentes;
using HM.Comun.DeclaracionesGlobales.Cliente;

//using HM.Comun.Persistencia;
using HM.Comun.Persistencia.Entidad;

//using HM.Contratos;
using HM.Comun.Persistencia.Entidad.CriterioFiltro;

//using System.ServiceModel;
//using Microsoft.Practices.EnterpriseLibrary.Data;
//using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using HM.Comun.Utilidades;
using HM.Comun.Varios;
using HM.Contratos.Entidad.Campanas;

//using HM.Comun.Compresion;
using HM.Contratos.Entidad.Cliente;
using HM.Contratos.Entidad.Grupos;
using HM.Contratos.Entidad.Maestros;
using HM.Contratos.Entidad.Soportes;
using HM.Contratos.Servicio;
using HM.MMS.Agentes;
using HM.MMS.Agentes.Compra;
using HM.MMS.Agentes.Comun;
using HM.MMS.Agentes.Maestros;
using HM.MMS.Agentes.Proveedores;
using HM.MMS.AR.Client.Agentes.Control;

namespace MSL
{
    public partial class DatosMms
    {
        //GLOBAL DECLARATION
        private const string CLAVE_CACHE_CLIENTES = "CLAVE_CACHE_CLIENTES";

        #region TEST

        public void traerAlgo()
        {
            //System.Data.DataTable dt;
            //Maestros osecciones = new Maestros();
            //dt = osecciones.seccionesObtener();
            //ColeccionNegocioBase<EntidadLectura> lista = null;
            //lista = ObtenerSecciones(32,1);
            //private Maestros _maestros;
            //public ColeccionNegocioBase<PresupuestoEntidad> lstPresupuestos2 = null;
        }

        #endregion TEST

        #region Editorial

        #endregion Editorial

        #region Clientes

        //Obtener clientes por usuario
        //public ColeccionNegocioBase<EntidadLectura> ObtenerClientesLectura(int idPais)
        /// <summary>
        /// Obtener Lista de clientes EntidadLectura por idPais
        /// </summary>
        /// <param name="idPais">int idPais</param>
        /// <returns></returns>
        public ColeccionNegocioBase<EntidadLectura> ObtenerClientesLectura(int idPais)
        {
            ClienteFiltro filtroCliente = new ClienteFiltro();

            filtroCliente.Criterio = Expresion.And(filtroCliente.Criterio, Expresion.Eq(ClienteCompaniaFiltro.COD_PAIS, idPais));
            ColeccionNegocioBase<EntidadLectura> lecturas = null;
            bool basico = false;//(filtroCliente == null);// REVISAR ESTE CODIGO //DANIEL CAIME!!

            using (GenericProxy<IClienteServicio> servicio = new GenericProxy<IClienteServicio>("WsHttpBinding_IClienteServicio"))
            {
                EntidadLectura elemento = new EntidadLectura(EntidadLectura.CLIENTE, CLAVE_CACHE_CLIENTES);

                if (basico && CacheCliente.existe(elemento))
                {
                    lecturas = (ColeccionNegocioBase<EntidadLectura>)CacheCliente.getAtributo(elemento);
                }
                else
                {
                    servicio.InvocarOperacion(delegate(IClienteServicio serv)
                    {
                        lecturas = serv.obtenerClientesLectura(filtroCliente);
                    });
                    if (basico)
                    {
                        CacheCliente.setAtributo(elemento, lecturas);
                    }
                }
            }
            return lecturas;
        }

        /// <summary>
        /// Obtener un Cliente por id_cliente
        /// </summary>
        /// <param name="IdPais">int idPais</param>
        /// <param name="IdCliente">int idCliente</param>
        /// <returns></returns>
        public ColeccionNegocioBase<EntidadLectura> ObtenerClientesLecturaporID(int idPais, int idCliente)
        {
            ClienteFiltro fCliente = new ClienteFiltro();
            fCliente.Criterio = Expresion.And(fCliente.Criterio, Expresion.Eq(ClienteFiltro.COD_PAIS, idPais));
            fCliente.Criterio = Expresion.And(fCliente.Criterio, Expresion.Eq(ClienteFiltro.COD_CLIENTE, idCliente));
            ClienteAgente aCliente = new ClienteAgente();
            //EntidadLectura elCliente = new EntidadLectura(aCliente.ToString());
            return aCliente.ObtenerClientesLectura(fCliente);
        }

        //--------------------------------------------------------------------------------------------------

        public ClienteEntidad ObtenerMedioPagosCliente(int id_pais, int id_compania, int id_cliente, int id_medio)
        {
            ClienteFiltro fCliente = new ClienteFiltro();
            ClienteCompaniaFiltro fClienteComp = new ClienteCompaniaFiltro();
            PagoMedioFiltro fPagoMedio = new PagoMedioFiltro();
            ClienteAgente aCliente = new ClienteAgente();

            //Filtro de Cliente -------------------------------------------------------------------------------------------------------------------------------------------------
            fCliente.Criterio = Expresion.And(fCliente.Criterio, Expresion.Eq(ClienteFiltro.COD_PAIS, id_pais));
            fCliente.Criterio = Expresion.And(fCliente.Criterio, Expresion.Eq(ClienteFiltro.COD_CLIENTE, id_cliente));
            //Filtro de Compania Cliente ----------------------------------------------------------------------------------------------------------------------------------------------
            fClienteComp.Criterio = Expresion.And(fClienteComp.Criterio, Expresion.Eq(ClienteCompaniaFiltro.COD_PAIS, id_pais));
            fClienteComp.Criterio = Expresion.And(fClienteComp.Criterio, Expresion.Eq(ClienteCompaniaFiltro.COD_COMPANIA, id_compania));
            fClienteComp.Criterio = Expresion.And(fClienteComp.Criterio, Expresion.Eq(ClienteCompaniaFiltro.COD_CLIENTE, id_cliente));
            //Filtro de PagoMedio -------------------------------------------------------------------------------------------------------------------------------------------------
            fPagoMedio.Criterio = Expresion.And(fPagoMedio.Criterio, Expresion.Eq(PagoMedioFiltro.COD_PAIS, id_pais));
            fPagoMedio.Criterio = Expresion.And(fPagoMedio.Criterio, Expresion.Eq(PagoMedioFiltro.COD_COMPANIA, id_compania));
            fPagoMedio.Criterio = Expresion.And(fPagoMedio.Criterio, Expresion.Eq(PagoMedioFiltro.COD_MEDIO, id_medio));
            fPagoMedio.Criterio = Expresion.And(fPagoMedio.Criterio, Expresion.Le(PagoMedioFiltro.FECHA_INICIO, DateTime.Now));
            fPagoMedio.Criterio = Expresion.And(fPagoMedio.Criterio, Expresion.Ge(PagoMedioFiltro.FECHA_FIN, DateTime.Now));

            return aCliente.ObtenerPagosMedioCliente(fCliente, fClienteComp, fPagoMedio);
        }

        //public ClienteEntidad ObtenerPagosMedioCliente1(ClienteFiltro filtroCliente, ClienteCompaniaFiltro filtroClienteCompania, PagoMedioFiltro filtroPagomedio)
        //{
        //    ClienteEntidad resulta = null;
        //    using (GenericProxy<IClienteServicio> servicio = new GenericProxy<IClienteServicio>("WsHttpBinding_IClienteServicio"))
        //    {
        //        servicio.InvocarOperacion(delegate(IClienteServicio serv)
        //        {
        //            resulta = serv.obtenerPagosMedioCliente(filtroCliente, filtroClienteCompania, filtroPagomedio);
        //        });
        //    }
        //    return resulta;
        //}

        #endregion Clientes

        #region Materiales

        public ColeccionNegocioBase<MaterialEntidad> ObtenerMaterialporMaterial(int id_pais, int id_cliente, int id_material)
        {
            AgenteGenerico agMaterial = new AgenteGenerico();
            MaterialFiltro filtroMaterial = new MaterialFiltro();
            ColeccionNegocioBase<MaterialEntidad> lstMateriales = new ColeccionNegocioBase<MaterialEntidad>();

            filtroMaterial.Criterio = Expresion.And(filtroMaterial.Criterio, Expresion.Eq(MaterialFiltro.COD_PAIS, id_pais));
            filtroMaterial.Criterio = Expresion.And(filtroMaterial.Criterio, Expresion.Eq(MaterialFiltro.COD_CLIENTE, id_cliente));
            filtroMaterial.Criterio = Expresion.And(filtroMaterial.Criterio, Expresion.Eq(MaterialFiltro.COD_MATERIAL, id_material));
            using (GenericProxy<IServicioMaestro> servicio = new GenericProxy<IServicioMaestro>("WSHttpBinding_IServicioMaestro"))
            {
                servicio.InvocarOperacion(delegate(IServicioMaestro serv)
                {
                    lstMateriales = serv.obtenerElementosMaterialEntidad(filtroMaterial);
                });
            }
            return lstMateriales;
        }

        /// <summary>
        /// obtiene materiales por cliente y producto
        /// </summary>
        /// <param name="IdPais"></param>
        /// <param name="IdCliente"></param>
        /// <returns></returns>
        public ColeccionNegocioBase<MaterialEntidad> ObtenerMaterialesLectura(int IdPais, int IdCliente, int id_producto)
        {
            AgenteGenerico agMaterial = new AgenteGenerico();
            MaterialFiltro filtroMaterial = new MaterialFiltro();
            ColeccionNegocioBase<MaterialEntidad> lstMateriales = new ColeccionNegocioBase<MaterialEntidad>();
            filtroMaterial.Criterio = Expresion.And(filtroMaterial.Criterio, Expresion.Eq(MaterialFiltro.COD_PAIS, IdPais));
            filtroMaterial.Criterio = Expresion.And(filtroMaterial.Criterio, Expresion.Eq(MaterialFiltro.COD_PRODUCTO, id_producto));
            filtroMaterial.Criterio = Expresion.And(filtroMaterial.Criterio, Expresion.Eq(MaterialFiltro.COD_CLIENTE, IdCliente));

            using (GenericProxy<IServicioMaestro> servicio = new GenericProxy<IServicioMaestro>("WSHttpBinding_IServicioMaestro"))
            {
                servicio.InvocarOperacion(delegate(IServicioMaestro serv)
                {
                    lstMateriales = serv.obtenerElementosMaterialEntidad(filtroMaterial);
                });
            }
            return lstMateriales;
        }

        public ColeccionNegocioBase<MaterialEntidad> ObtenerMaterialesLectura(int IdPais, int IdCliente, int id_producto, int id_medio)
        {
            AgenteGenerico agMaterial = new AgenteGenerico();
            MaterialFiltro filtroMaterial = new MaterialFiltro();
            ColeccionNegocioBase<MaterialEntidad> lstMateriales = new ColeccionNegocioBase<MaterialEntidad>();
            filtroMaterial.Criterio = Expresion.And(filtroMaterial.Criterio, Expresion.Eq(MaterialFiltro.COD_PAIS, IdPais));
            filtroMaterial.Criterio = Expresion.And(filtroMaterial.Criterio, Expresion.Eq(MaterialFiltro.COD_PRODUCTO, id_producto));
            filtroMaterial.Criterio = Expresion.And(filtroMaterial.Criterio, Expresion.Eq(MaterialFiltro.COD_CLIENTE, IdCliente));
            filtroMaterial.Criterio = Expresion.And(filtroMaterial.Criterio, Expresion.Eq(MaterialFiltro.COD_MEDIO, id_medio));
            using (GenericProxy<IServicioMaestro> servicio = new GenericProxy<IServicioMaestro>("WSHttpBinding_IServicioMaestro"))
            {
                servicio.InvocarOperacion(delegate(IServicioMaestro serv)
                {
                    lstMateriales = serv.obtenerElementosMaterialEntidad(filtroMaterial);
                });
            }
            return lstMateriales;
        }

        //20101001 Obtiene los materiales filtrando solo por cliente
        public ColeccionNegocioBase<MaterialEntidad> ObtenerMaterialporCliente(int id_pais, int id_cliente)
        {
            AgenteGenerico agMaterial = new AgenteGenerico();
            MaterialFiltro filtroMaterial = new MaterialFiltro();
            ColeccionNegocioBase<MaterialEntidad> lstMateriales = new ColeccionNegocioBase<MaterialEntidad>();

            filtroMaterial.Criterio = Expresion.And(filtroMaterial.Criterio, Expresion.Eq(MaterialFiltro.COD_PAIS, id_pais));
            filtroMaterial.Criterio = Expresion.And(filtroMaterial.Criterio, Expresion.Eq(MaterialFiltro.COD_CLIENTE, id_cliente));
            using (GenericProxy<IServicioMaestro> servicio = new GenericProxy<IServicioMaestro>("WSHttpBinding_IServicioMaestro"))
            {
                servicio.InvocarOperacion(delegate(IServicioMaestro serv)
                {
                    lstMateriales = serv.obtenerElementosMaterialEntidad(filtroMaterial);
                });
            }
            return lstMateriales;
        }

        public Boolean ExisteCodigoAfsca(int id_pais, string codigo_afsca, int codigo_material)
        {
            Boolean existe = false;
            HM.MMS.AR.Client.Agentes.AgenteGestionMaestros agenteGestionMaestros = new HM.MMS.AR.Client.Agentes.AgenteGestionMaestros();

            existe = agenteGestionMaestros.ExisteCodigoAfsca(id_pais, codigo_afsca, codigo_material);

            return existe;
        }

        public String AgregarCodigoAfsca(int id_pais, string codigo_afsca, int codigo_material)
        {
            String descripcion = String.Empty;

            HM.MMS.AR.Client.Agentes.AgenteGestionMaestros agenteGestionMaestros = new HM.MMS.AR.Client.Agentes.AgenteGestionMaestros();

            descripcion = agenteGestionMaestros.AgregarCodigoAfsca(id_pais, codigo_afsca, codigo_material);

            return descripcion;
        }

        public String SetNacionalExtranjeroFlag(Boolean esNacional, int codigo_material)
        {
            String descripcion = String.Empty;

            HM.MMS.AR.Client.Agentes.AgenteGestionMaestros agenteGestionMaestros = new HM.MMS.AR.Client.Agentes.AgenteGestionMaestros();

            descripcion = agenteGestionMaestros.SetNacionalExtranjeroFlag(esNacional, codigo_material);

            return descripcion;
        }

        public Boolean ExisteCodigoAfscaByMaterial(int id_pais, int codigo_material)
        {
            Boolean existe = false;

            HM.MMS.AR.Client.Agentes.AgenteGestionMaestros agenteGestionMaestros = new HM.MMS.AR.Client.Agentes.AgenteGestionMaestros();

            existe = agenteGestionMaestros.ExisteCodigoAfscaByMaterial(id_pais, codigo_material);
            return existe;
        }

        public String ActualizarCodigoAfsca(int id_pais, string codigo_afsca, int codigo_material)
        {
            String descripcion = String.Empty;

            HM.MMS.AR.Client.Agentes.AgenteGestionMaestros agenteGestionMaestros = new HM.MMS.AR.Client.Agentes.AgenteGestionMaestros();

            descripcion = agenteGestionMaestros.ActualizarCodigoAfsca(id_pais, codigo_afsca, codigo_material);

            return descripcion;
        }

        #endregion Materiales

        #region Impuestos

        #endregion Impuestos

        #region Poblaciones

        /// <summary>
        /// Obtener Localidades | Poblaciones_nivel3 en la BBDD de MMS
        /// </summary>
        /// <param name="id_pais"></param>
        /// <param name="id_provincia"></param>
        /// <returns></returns>
        public ColeccionNegocioBase<PoblacionEntidad> ObtenerLocalidades(int id_pais, int id_provincia)
        {
            PoblacionAgente agentePoblacion = new PoblacionAgente();
            LocalidadFiltro filtroLocalidad = new LocalidadFiltro();

            filtroLocalidad.Criterio = Expresion.Eq(LocalidadFiltro.COD_PAIS, id_pais);
            filtroLocalidad.Criterio = Expresion.And(filtroLocalidad.Criterio, Expresion.Eq(LocalidadFiltro.COD_PROVINCIA, id_provincia));

            ColeccionNegocioBase<PoblacionEntidad> lstLocalidades = agentePoblacion.ObtenerElementos<PoblacionEntidad>(HM.Comun.DeclaracionesGlobales.Cliente.Constantes.POBLACION_NIVEL3, filtroLocalidad);

            return lstLocalidades;
        }

        public ColeccionNegocioBase<PoblacionEntidad> ObtenerLocalidadesAlternativa(int id_pais, int id_provincia, int id_localidad)
        {
            PoblacionAgente agentePoblacion = new PoblacionAgente();
            //      LocalidadFiltro filtroLocalidad = new LocalidadFiltro();

            //    filtroLocalidad.Criterio = Expresion.Eq(LocalidadFiltro.COD_PAIS, id_pais);
            //  filtroLocalidad.Criterio = Expresion.And(filtroLocalidad.Criterio, Expresion.Eq(LocalidadFiltro.COD_PROVINCIA, id_provincia));

            // modificado GW por problema de alternativa VP en proximia
            FiltroGenerico poblacionFiltro = new FiltroGenerico();

            poblacionFiltro.Criterio = Expresion.Eq(HM.Comun.DeclaracionesGlobales.Cliente.Constantes.PAIS_CODIGO, id_pais);
            poblacionFiltro.Criterio = Expresion.And(poblacionFiltro.Criterio, Expresion.Eq(LocalidadFiltro.COD_PROVINCIA, id_provincia));
            poblacionFiltro.Criterio = Expresion.And(poblacionFiltro.Criterio, Expresion.Eq(HM.Comun.DeclaracionesGlobales.Cliente.Constantes.POBLACION_CODIGO3, id_localidad));

            ColeccionNegocioBase<PoblacionEntidad> lstLocalidades = agentePoblacion.ObtenerElementos<PoblacionEntidad>(HM.Comun.DeclaracionesGlobales.Cliente.Constantes.POBLACION_NIVEL3, poblacionFiltro);

            return lstLocalidades;
        }

        public ColeccionNegocioBase<PoblacionEntidad> ObtenerProvincias(int id_pais, int id_poblacion_padre)
        //public ColeccionNegocioBase<PoblacionEntidad> ObtenerPoblaciones(int id_pais,int id_poblacion_padre)
        {
            ColeccionNegocioBase<PoblacionEntidad> Provincias = null;
            Hashtable HashProvinciaComunidad = new Hashtable();
            PoblacionAgente agentePoblacion = new PoblacionAgente();
            FiltroGenerico filtro = new FiltroGenerico();
            filtro.Criterio = Expresion.Eq(HM.Comun.DeclaracionesGlobales.Cliente.Constantes.PAIS_CODIGO, id_pais);
            ColeccionNegocioBase<PoblacionEntidad> Comunidades = agentePoblacion.ObtenerComunidades(filtro);
            Provincias = new ColeccionNegocioBase<PoblacionEntidad>();
            foreach (PoblacionEntidad comunidad in Comunidades)
            {
                foreach (PoblacionEntidad provincia in comunidad.PoblacionesHijas)
                {
                    Provincias.Add(provincia);
                    HashProvinciaComunidad.Add(provincia.Codigo, comunidad.Codigo);
                }
            }
            Provincias.Ordenar("Nombre");
            return Provincias;

            //PoblacionEntidad EntidadPoblacion = new PoblacionEntidad();
            //FiltroGenerico poblacionFiltro = new FiltroGenerico();
            ////a ver a ver
            //ColeccionNegocioBase<PoblacionEntidad> comunidades = new ColeccionNegocioBase<PoblacionEntidad>();
            //PoblacionEntidad provincia = new PoblacionEntidad();
            //PaisEntidad pais = new PaisEntidad();
            //pais.CodPais = 32;
            //provincia.Codigo = 0;
            //provincia.Pais = pais;
            //provincia.PoblacionesHijas = new ColeccionNegocioBase<PoblacionEntidad>();
            //comunidades.Add(provincia);
            //HM.MMS.Agentes.PoblacionAgente agentePoblacion = new PoblacionAgente();

            ////ESTO ES PARA PASARLE EL COD_PAIS D_C
            //poblacionFiltro.Criterio = Expresion.Eq(HM.Comun.DeclaracionesGlobales.Cliente.Constantes.TIPO_PRESUPUESTO_COD_PAIS, id_pais);
            //ColeccionNegocioBase<PoblacionEntidad> lstPoblaciones = null;
            //lstPoblaciones = agentePoblacion.ObtenerComunidades(poblacionFiltro);
            //using (GenericProxy<IPoblacionServicio> servicio = new GenericProxy<IPoblacionServicio>("WSHttpBinding_IPoblacionServicio"))
            //{
            //    servicio.InvocarOperacion(delegate(IPoblacionServicio serv)
            //    {
            //        lstPoblaciones = serv.ObtenerComunidades(poblacionFiltro);
            //    });
            //}
            //return lstPoblaciones[0].PoblacionesHijas;
        }

        /// <summary>
        /// Obtenemos las poblaciones de NIVEL2 (Provincias)
        /// </summary>
        /// <param name="id_pais"></param>
        /// <returns></returns>
        public ColeccionNegocioBase<PoblacionEntidad> ObtenerPoblaciones(int id_pais)
        {
            PoblacionEntidad EntidadPoblacion = new PoblacionEntidad();
            FiltroGenerico poblacionFiltro = new FiltroGenerico();
            //ESTO ES PARA PASARLE EL COD_PAIS D_C
            poblacionFiltro.Criterio = Expresion.Eq(HM.Comun.DeclaracionesGlobales.Cliente.Constantes.POBLACION_NIVEL2, 0);
            poblacionFiltro.Criterio = Expresion.Eq(HM.Comun.DeclaracionesGlobales.Cliente.Constantes.TIPO_PRESUPUESTO_COD_PAIS, id_pais);
            ColeccionNegocioBase<PoblacionEntidad> lstPoblaciones = null;
            using (GenericProxy<IPoblacionServicio> servicio = new GenericProxy<IPoblacionServicio>("WSHttpBinding_IPoblacionServicio"))
            {
                servicio.InvocarOperacion(delegate(IPoblacionServicio serv)
                {
                    lstPoblaciones = serv.ObtenerComunidades(poblacionFiltro);
                });
            }
            return lstPoblaciones[0].PoblacionesHijas;
        }

        #endregion Poblaciones

        #region Secciones

        /// <summary>
        /// ObtenerSecciones
        /// </summary>
        /// <param name="id_pais">codigo de pais</param>
        /// <param name="id_medio">codigo de medio</param>
        /// D_C
        /// <returns>Coleccion de EntidadLectura objetos Secciones</returns>
        public ColeccionNegocioBase<EntidadLectura> ObtenerSecciones(int id_pais, int id_medio)
        {
            SeccionFiltro filtroSeccion = new SeccionFiltro();

            filtroSeccion.Criterio = Expresion.And(filtroSeccion.Criterio, Expresion.Eq(SeccionFiltro.COD_PAIS, id_pais));
            filtroSeccion.Criterio = Expresion.And(filtroSeccion.Criterio, Expresion.Eq(SeccionFiltro.COD_MEDIO, id_medio));
            filtroSeccion.Criterio = Expresion.And(filtroSeccion.Criterio, Expresion.IsNull(SeccionFiltro.FECHA_BAJA));

            ColeccionNegocioBase<EntidadLectura> lstSecciones = null;

            using (GenericProxy<IServicioGenerico> servicio = new GenericProxy<IServicioGenerico>("WSHttpBinding_IServicioGenerico"))
            {
                servicio.InvocarOperacion(delegate(IServicioGenerico serv)
                {
                    lstSecciones = serv.obtenerElementosLectura(new EntidadLectura(EntidadLectura.SECCION), filtroSeccion);
                });
            }
            return lstSecciones;
        }

        #endregion Secciones

        #region Colocaciones

        public ColeccionNegocioBase<EntidadLectura> ObtenerColocacion(int id_medio)
        {
            ColeccionNegocioBase<EntidadLectura> lstColocaciones = null;
            FiltroGenerico filtro = new FiltroGenerico();

            filtro.Criterio = Expresion.And(filtro.Criterio, Expresion.Eq("CodMedio", id_medio));

            using (GenericProxy<IServicioGenerico> servicio = new GenericProxy<IServicioGenerico>("WSHttpBinding_IServicioGenerico"))
            {
                servicio.InvocarOperacion(delegate(IServicioGenerico serv)
                {
                    lstColocaciones = serv.obtenerElementosLectura(new EntidadLectura(EntidadLectura.COLOCACION), filtro);
                });
            }
            return lstColocaciones;
        }

        #endregion Colocaciones

        #region Formatos

        public ColeccionNegocioBase<EntidadLectura> ObtenerFormatos(int IdMedio)
        {
            ColeccionNegocioBase<EntidadLectura> lstFormatos = null;

            FiltroGenerico filtro = new FiltroGenerico();
            filtro.Criterio = Expresion.And(filtro.Criterio, Expresion.Eq("CodMedio", IdMedio));

            using (GenericProxy<IServicioGenerico> servicio = new GenericProxy<IServicioGenerico>("WSHttpBinding_IServicioGenerico"))
            {
                servicio.InvocarOperacion(delegate(IServicioGenerico serv)
                {
                    lstFormatos = serv.obtenerElementosLectura(new EntidadLectura(EntidadLectura.FORMATO), filtro);
                });
            }
            return lstFormatos;
        }

        #endregion Formatos

        #region Plazas - Cobertura

        /// <summary>
        /// Devuelve plazas correspondientes a un pais
        /// Tipo de dato coleccion de coberturaEntidad
        /// </summary>
        /// <param name="IdPais"></param>
        /// <returns></returns>
        public ColeccionNegocioBase<CoberturaEntidad> ObtenerPlazas(int id_pais)
        {
            CoberturaFiltro filtroCobertura = new CoberturaFiltro();
            EntidadBase entBase = null;
            EntidadLectura elPlaza = new EntidadLectura();
            ColeccionNegocioBase<CoberturaEntidad> lstCobertura = new ColeccionNegocioBase<CoberturaEntidad>();
            ColeccionNegocioBase<EntidadLectura> lstPlazas = null;//new ColeccionNegocioBase<EntidadLectura>();
            filtroCobertura.Criterio = Expresion.And(filtroCobertura.Criterio, Expresion.Eq(CoberturaSoporteFiltro.COD_PAIS, id_pais));
            using (GenericProxy<ICoberturaServicio> servicio = new GenericProxy<ICoberturaServicio>("WSHttpBinding_ICoberturaServicio"))
            {
                servicio.InvocarOperacion(delegate(ICoberturaServicio serv)
                {
                    lstCobertura = serv.obtenerCoberturas(filtroCobertura, false);
                });
            }

            return lstCobertura;
        }

        ////--------------------------------------------------------------------------------------------------

        /// <summary>
        /// Obtener una plaza por id_plaza
        /// </summary>
        /// <param name="id_pais"></param>
        /// <param name="id_plaza"></param>
        /// <returns></returns>
        public ColeccionNegocioBase<CoberturaEntidad> PlazasObtenerByPlaza(int id_pais, int id_plaza)
        {
            CoberturaFiltro filtroCobertura = new CoberturaFiltro();
            ColeccionNegocioBase<CoberturaEntidad> lstCobertura = new ColeccionNegocioBase<CoberturaEntidad>();
            filtroCobertura.Criterio = Expresion.And(filtroCobertura.Criterio, Expresion.Eq(CoberturaSoporteFiltro.COD_PAIS, id_pais));
            filtroCobertura.Criterio = Expresion.And(filtroCobertura.Criterio, Expresion.Eq(CoberturaSoporteFiltro.COD_COBERTURA, id_plaza));

            using (GenericProxy<ICoberturaServicio> servicio = new GenericProxy<ICoberturaServicio>("WSHttpBinding_ICoberturaServicio"))
            {
                servicio.InvocarOperacion(delegate(ICoberturaServicio serv)
                {
                    lstCobertura = serv.obtenerCoberturas(filtroCobertura, false);
                });
            }
            return lstCobertura;
        }

        #endregion Plazas - Cobertura

        #region TipoSoporte

        /// <summary>
        /// Obtener tipo soportes
        /// </summary>
        /// <param name="id_pais"></param>
        /// <param name="id_medio">id_medio</param>
        /// <returns></returns>
        public ColeccionNegocioBase<EntidadBase> obtenerTipoSoporte(int id_pais, int id_medio)
        {
            ColeccionNegocioBase<EntidadBase> lstTipoSoporte = null;
            EntidadBase sopor = new TipoSoporteEntidad();
            TipoSoporteFiltro filtroSoporte = new TipoSoporteFiltro();
            TipoSoporteEntidad tipsop = new TipoSoporteEntidad();
            MedioFiltro filtMed = new MedioFiltro();
            filtMed.Criterio = Expresion.And(filtMed.Criterio, Expresion.Eq(MedioFiltro.COD_MEDIO, id_medio));
            FiltroBase basFiltro = filtroSoporte;
            using (GenericProxy<IServicioGenerico> servicio = new GenericProxy<IServicioGenerico>("WSHttpBinding_IServicioGenerico"))
            {
                servicio.InvocarOperacion(delegate(IServicioGenerico serv)
                {
                    lstTipoSoporte = serv.ObtenerElementos(sopor, filtMed);
                });
            }
            return lstTipoSoporte;
        }

        #endregion TipoSoporte

        #region Proveedores

        public ColeccionNegocioBase<ProveedorEntidad> ObtenerProveedor(int id_pais)
        {
            AgenteGenerico AgenteProveedor = new AgenteGenerico();
            ProveedorFiltro FiltroProveedor = new ProveedorFiltro();
            ColeccionNegocioBase<ProveedorEntidad> lstProveedor = new ColeccionNegocioBase<ProveedorEntidad>();
            FiltroProveedor.Criterio = Expresion.And(FiltroProveedor.Criterio, Expresion.Eq(ProveedorFiltro.COD_PAIS, id_pais));
            FiltroProveedor.addOrder(new CampoOrden(ProveedorFiltro.DES_PROVEEDOR, false));
            using (GenericProxy<IProveedorServicio> servicio = new GenericProxy<IProveedorServicio>("WSHttpBinding_IProveedorServicio"))
            {
                servicio.InvocarOperacion(delegate(IProveedorServicio serv)
                {
                    lstProveedor = serv.obtenerProveedores(FiltroProveedor, null);
                });
            }

            return lstProveedor;
        }

        public ColeccionNegocioBase<ProveedorEntidad> ObtenerProveedorCuit(int id_pais, int CodProveedor)
        {
            ProveedorAgente agente = new ProveedorAgente();
            ProveedorFiltro FiltroProveedor = new ProveedorFiltro();
            ProveedorEntidad Entidad;
            ColeccionNegocioBase<ProveedorEntidad> LstProveedorCuit = new ColeccionNegocioBase<ProveedorEntidad>();

            FiltroProveedor.Criterio = Expresion.Eq(ProveedorFiltro.COD_PAIS, id_pais);
            FiltroProveedor.Criterio = Expresion.And(FiltroProveedor.Criterio, Expresion.Eq(ProveedorFiltro.COD_PROVEEDOR, CodProveedor));

            Entidad = agente.obtenerProveedores(FiltroProveedor, null)[0];
            LstProveedorCuit.Add(Entidad);

            return LstProveedorCuit;
        }

        #endregion Proveedores

        #region Campanas

        public ColeccionNegocioBase<CampanaEntidad> obtenerCampanas(int id_pais, int id_compania, int id_cliente, int id_producto, string f_desde, string f_hasta)
        {
            ColeccionNegocioBase<CampanaEntidad> lstCampanas = null;
            CampanaFiltro filtroCampana = new CampanaFiltro();
            filtroCampana.Criterio = Expresion.Eq(CampanaFiltro.COD_PAIS, id_pais);
            filtroCampana.Criterio = Expresion.And(filtroCampana.Criterio, Expresion.Eq(CampanaFiltro.COD_COMPANIA, id_compania));
            filtroCampana.Criterio = Expresion.And(filtroCampana.Criterio, Expresion.Eq(CampanaFiltro.COD_CLIENTE, id_cliente));
            filtroCampana.Criterio = Expresion.And(filtroCampana.Criterio, Expresion.Eq(CampanaFiltro.COD_PRODUCTO, id_producto));
            //filtroCampana.Criterio = Expresion.And(filtroCampana.Criterio, Expresion.Between(CampanaFiltro.F_CREACION, DateTime.Parse(f_desde), DateTime.Parse(f_hasta)));
            using (GenericProxy<ICampanaServicio> servicio = new GenericProxy<ICampanaServicio>("WSHttpBinding_ICampanaServicio"))
            {
                servicio.InvocarOperacion(delegate(ICampanaServicio serv)
                {
                    lstCampanas = serv.obtenerCampanas(filtroCampana, null, null, null);
                });
            }
            return lstCampanas;
        }

        public int InsertarIntercambio(int codpais, int codcompania, int codcliente, string descripcion, decimal importe, DateTime Fdesde, DateTime FFin)
        {
            int CodIntercambio = 0;
            IntercambioEntidad entidad = new IntercambioEntidad();
            CompaniaEntidad comp = new CompaniaEntidad();
            comp.Codigo = codcompania;
            entidad.Compania = comp;
            ClienteEntidad cli = new ClienteEntidad();
            cli.CodigoCliente = codcliente;
            entidad.Cliente = cli;
            PaisEntidad p = new PaisEntidad();
            p.CodPais = codpais;
            entidad.Pais = p;
            MonedaEntidad moneda = new MonedaEntidad();
            moneda.Codigo = 5;
            entidad.Moneda = moneda;
            entidad.Codigo = null;
            entidad.Descripcion = descripcion;
            entidad.PorcentFactura = 100;
            entidad.Importe = importe;
            entidad.Estado = 1;
            IntercambioEntidad intercambio = new IntercambioEntidad();
            intercambio = (IntercambioEntidad)entidad;

            entidad.FechaInicio = Fdesde;
            entidad.FechaFin = FFin;

            AgenteGenerico agente = new AgenteGenerico();
            agente.Elemento_Alta(intercambio);

            return CodIntercambio;
        }

        public int InsertarCampania(int Id_Cliente, int Id_Producto, string DesCampania, int Id_Pais, int Id_Compania, DateTime F_Creacion, int Id_Usuario)
        {
            int Cod_Campania = 0;

            // ----- Obtengo Entiad Cliente ----------------------------------------------------------------------------------------------------------------------------------------
            ClienteFiltro filtroCliente = new ClienteFiltro();
            ClienteAgente OCliente = new ClienteAgente();
            ColeccionNegocioBase<ClienteEntidad> EntidadCliente = new ColeccionNegocioBase<ClienteEntidad>();
            //ClienteEntidad EntidadCliente = new ClienteEntidad();
            filtroCliente.Criterio = Expresion.Eq(ClienteFiltro.COD_PAIS, Id_Pais);
            filtroCliente.Criterio = Expresion.And(filtroCliente.Criterio, Expresion.Eq(ClienteFiltro.COD_CLIENTE, Id_Cliente));
            EntidadCliente = OCliente.ObtenerClientes(filtroCliente, null, null, null, null);

            // ----- Obtengo Entidad Producto --------------------------------------------------------------------------------------------------------------------------------------
            ProductoFiltro filtroProducto = new ProductoFiltro();
            AgenteMaestro OProducto = new AgenteMaestro();
            ColeccionNegocioBase<ProductoEntidad> EntidadProducto = new ColeccionNegocioBase<ProductoEntidad>();
            filtroProducto.Criterio = Expresion.Eq(ProductoFiltro.COD_PAIS, Id_Pais);
            filtroProducto.Criterio = Expresion.And(filtroProducto.Criterio, Expresion.Eq(ProductoFiltro.COD_CLIENTE, Id_Cliente));
            filtroProducto.Criterio = Expresion.And(filtroProducto.Criterio, Expresion.Eq(ProductoFiltro.COD_PRODUCTO, Id_Producto));
            EntidadProducto = OProducto.obtenerElementosProductoLigeroEntidad(filtroProducto);

            // ----- Obtengo Entidad Usuario ----------------------------------------------------------------------------------------------------------------------------------------

            UsuarioAgente OUsuario = new UsuarioAgente();
            HM.Contratos.Entidad.Seguridad.UsuarioEntidad EntidadUsuario = new HM.Contratos.Entidad.Seguridad.UsuarioEntidad();

            EntidadUsuario = OUsuario.ObtenerUsuarioActivo();
            EntidadUsuario.Companias.Buscar(new ColeccionFiltro(CompaniaFiltro.COD_COMPANIA, Id_Compania));

            //Cargo los Datos de la entidad Campania --------------------------------------------------------------------------------------------------------------------------
            CampanaEntidad EntidadCampania = new CampanaEntidad();
            EntidadCampania.Cliente = EntidadCliente[0];
            EntidadCampania.Producto = EntidadProducto[0];
            EntidadCampania.Compania = EntidadUsuario.Companias.Find(x => x.Codigo == Id_Compania);
            EntidadCampania.Descripcion = DesCampania;
            EntidadCampania.FechaCreacion = F_Creacion;
            EntidadCampania.Estado = CampanaFiltro.ESTADO_INSERTADA;
            EntidadCampania.Operacion = TiposOperacion.Insertar;
            EntidadCampania.OrigenObjeto = OrigenObjetoNegocio.ObjetoNuevo;

            //Realizo el insert de la Entidad Campania --------------------------------------------------------------------------------------------------------------------------
            CampanaAgente AgenteCampania = new CampanaAgente();
            CampanaEntidad Campania = new CampanaEntidad();

            if (EntidadCampania != null)
            {
                Campania = AgenteCampania.Insertar(EntidadCampania);
                Cod_Campania = Campania.Codigo;
            }

            // Si el Valor que retorna es alguno de estos 2 entonces, no se realizo ningun insert en la Tabla Campana del MMS - Captura error
            if (Campania.Codigo == 0 || Campania.Codigo == null)
            {
                Cod_Campania = 0;
            }
            return Cod_Campania;
        }

        #endregion Campanas

        #region SubCampanas

        public ColeccionNegocioBase<SubcampanaEntidad> obtenerSubCampanas(int id_pais, int id_compania, int id_campania, int id_medio)
        {
            ColeccionNegocioBase<SubcampanaEntidad> lstSubCampanas = null;
            SubcampanaFiltro filtroSubCampana = new SubcampanaFiltro();

            filtroSubCampana.Criterio = Expresion.Eq(CampanaFiltro.COD_PAIS, id_pais);
            filtroSubCampana.Criterio = Expresion.And(filtroSubCampana.Criterio, Expresion.Eq(SubcampanaFiltro.COD_COMPANIA, id_compania));
            filtroSubCampana.Criterio = Expresion.And(filtroSubCampana.Criterio, Expresion.Eq(SubcampanaFiltro.COD_CAMPANA, id_campania));
            filtroSubCampana.Criterio = Expresion.And(filtroSubCampana.Criterio, Expresion.Eq(SubcampanaFiltro.COD_MEDIO, id_medio));

            //Filtro para la coleccion de Campañas dentro de la subCampanas para obtener datos de la campania ---------------------
            CampanaFiltro filtroCampana = new CampanaFiltro();
            filtroCampana.Criterio = Expresion.Eq(CampanaFiltro.COD_PAIS, id_pais);
            filtroCampana.Criterio = Expresion.And(filtroCampana.Criterio, Expresion.Eq(CampanaFiltro.COD_CAMPANA, id_campania));
            //---------------------------------------------------------------------------------------------------------------------
            using (GenericProxy<ISubcampanaServicio> servicio = new GenericProxy<ISubcampanaServicio>("WSHttpBinding_ISubcampanaServicio"))
            {
                servicio.InvocarOperacion(delegate(ISubcampanaServicio serv)
                {
                    lstSubCampanas = serv.obtenerSubcampanas(filtroSubCampana, filtroCampana, null);
                });
            }
            return lstSubCampanas;
        }

        public int? InsertarSubCampania(int Id_Cliente, int Id_medio, int Id_Campania, string DesSubCampania, int Id_Pais, int Id_Compania, DateTime F_Inicio, DateTime F_Fin, DateTime F_Creacion)
        {
            int? Cod_SubCampania = 0;

            // ----- Obtengo Entiad Medio ----------------------------------------------------------------------------------------------------------------------------------------
            AgenteGenerico AgenteMedio = new AgenteGenerico();
            ColeccionNegocioBase<MedioEntidad> EntidadMedioTodos = new ColeccionNegocioBase<MedioEntidad>();
            MedioEntidad EntidadMedio = new MedioEntidad();
            EntidadMedioTodos = AgenteMedio.ObtenerElementos<MedioEntidad>(new MedioEntidad(), null);
            foreach (MedioEntidad Medio in EntidadMedioTodos)
            {
                if (Medio.CodMedio == Id_medio)
                {
                    EntidadMedio = Medio;
                    break;
                }
            }

            // ----- Obtengo Entiad Campania ----------------------------------------------------------------------------------------------------------------------------------------
            CampanaAgente AgenteCampania = new CampanaAgente();
            CampanaFiltro filtroCampania = new CampanaFiltro();
            filtroCampania.Criterio = Expresion.Eq(CampanaFiltro.COD_PAIS, Id_Pais);
            filtroCampania.Criterio = Expresion.And(filtroCampania.Criterio, Expresion.Eq(CampanaFiltro.COD_COMPANIA, Id_Compania));
            filtroCampania.Criterio = Expresion.And(filtroCampania.Criterio, Expresion.Eq(CampanaFiltro.COD_CLIENTE, Id_Cliente));
            filtroCampania.Criterio = Expresion.And(filtroCampania.Criterio, Expresion.Eq(CampanaFiltro.COD_CAMPANA, Id_Campania));
            ColeccionNegocioBase<CampanaEntidad> EntidadCampania = new ColeccionNegocioBase<CampanaEntidad>();
            EntidadCampania = AgenteCampania.ObtenerCampanas(filtroCampania, null, null, null);

            //Cargo los Datos de la entidad Campania --------------------------------------------------------------------------------------------------------------------------
            // Respetar el orden de en el cual se hacen las asignaciones de los objetos cargados
            SubcampanaEntidad EntidadSubCampania = new SubcampanaEntidad();
            EntidadSubCampania.Campana = EntidadCampania[0];
            EntidadSubCampania.Medio = EntidadMedio;
            EntidadSubCampania.Descripcion = DesSubCampania;
            EntidadSubCampania.FechaCreacion = F_Creacion;
            EntidadSubCampania.FechaInicio = F_Inicio;
            EntidadSubCampania.FechaFin = F_Fin;
            EntidadSubCampania.ImporteInversion = null;
            EntidadSubCampania.Estado = SubcampanaFiltro.ESTADO_INSERTADA;
            EntidadSubCampania.Operacion = TiposOperacion.Insertar;
            EntidadSubCampania.OrigenObjeto = OrigenObjetoNegocio.ObjetoNuevo;
            EntidadSubCampania.ColeccionPresupuestos = null;

            //Realizo el insert de la Entidad SubCampania --------------------------------------------------------------------------------------------------------------------------
            SubcampanaAgente AgenteSubCampania = new SubcampanaAgente();
            SubcampanaEntidad SubCampania = new SubcampanaEntidad();

            if (EntidadSubCampania != null)
            {
                SubCampania = AgenteSubCampania.crearSubcampana(EntidadSubCampania);
                Cod_SubCampania = SubCampania.Codigo;
            }

            // Si el Valor que retorna es alguno de estos 2 entonces, no se realizo ningun insert en la Tabla SubCampana del MMS - Captura error
            if (SubCampania.Codigo == 0 || SubCampania.Codigo == null)
            {
                Cod_SubCampania = 0;
            }
            return Cod_SubCampania;
        }

        #endregion SubCampanas

        #region Presupuestos

        public ColeccionNegocioBase<PresupuestoEntidad> obtenerPresupuestos(int id_pais, int id_compania, int id_campania, int id_subcampania, DateTime f_desde, DateTime f_hasta)
        {
            //filtro de Presupuestos ---------------------------------------------------------------------------------------------------
            ColeccionNegocioBase<PresupuestoEntidad> lstPresupuestos = null;
            PresupuestoFiltro filtroPresupuesto = new PresupuestoFiltro();
            filtroPresupuesto.Criterio = Expresion.Eq(PresupuestoFiltro.COD_PAIS, id_pais);
            filtroPresupuesto.Criterio = Expresion.And(filtroPresupuesto.Criterio, Expresion.Eq(PresupuestoFiltro.COD_COMPANIA, id_compania));
            filtroPresupuesto.Criterio = Expresion.And(filtroPresupuesto.Criterio, Expresion.Eq(PresupuestoFiltro.COD_CAMPANA, id_campania));
            filtroPresupuesto.Criterio = Expresion.And(filtroPresupuesto.Criterio, Expresion.Eq(PresupuestoFiltro.COD_SUBCAMPANA, id_subcampania));
            filtroPresupuesto.Criterio = Expresion.And(filtroPresupuesto.Criterio, Expresion.Between(PresupuestoFiltro.FECHA_EMISION, f_desde, f_hasta));
            //--------------------------------------------------------------------------------------------------------------------------

            //Filtro para la coleccion de Campañas asociadas a la subCampanas para obtener datos de la campania ---------------------
            CampanaFiltro filtroCampana = new CampanaFiltro();
            filtroCampana.Criterio = Expresion.Eq(CampanaFiltro.COD_PAIS, id_pais);
            filtroCampana.Criterio = Expresion.And(filtroCampana.Criterio, Expresion.Eq(CampanaFiltro.COD_COMPANIA, id_compania));
            filtroCampana.Criterio = Expresion.And(filtroCampana.Criterio, Expresion.Eq(CampanaFiltro.COD_CAMPANA, id_campania));
            //---------------------------------------------------------------------------------------------------------------------

            //Filtro para la coleccion de SubCampañas asociados al presupuesto para obtener datos de la Subcampania ---------------------
            SubcampanaFiltro filtroSubCampana = new SubcampanaFiltro();
            filtroSubCampana.Criterio = Expresion.Eq(CampanaFiltro.COD_PAIS, id_pais);
            filtroSubCampana.Criterio = Expresion.And(filtroSubCampana.Criterio, Expresion.Eq(SubcampanaFiltro.COD_COMPANIA, id_compania));
            filtroSubCampana.Criterio = Expresion.And(filtroSubCampana.Criterio, Expresion.Eq(SubcampanaFiltro.COD_CAMPANA, id_campania));
            filtroSubCampana.Criterio = Expresion.And(filtroSubCampana.Criterio, Expresion.Eq(SubcampanaFiltro.COD_SUBCAMPANA, id_subcampania));
            //---------------------------------------------------------------------------------------------------------------------

            using (GenericProxy<IPresupuestoServicio> servicio = new GenericProxy<IPresupuestoServicio>("WSHttpBinding_IPresupuestoServicio"))
            {
                servicio.InvocarOperacion(delegate(IPresupuestoServicio serv)
                {
                    lstPresupuestos = serv.obtenerPresupuestos(filtroPresupuesto, filtroSubCampana, filtroCampana);
                });
            }
            //Jsperk
            //_maestros = new Maestros();
            //_maestros.LstPresupuestos = lstPresupuestos;

            return lstPresupuestos;
        }

        public int? InsertarPresupuesto(int Id_Cliente, int Id_TPresupuesto, int Id_Campania, int Id_SubCampania, int Id_Pais, int Id_Compania, DateTime F_EmisionOrden, string CodIntercambio, String NumeroOC)
        {
            int? Cod_Presupuesto = 0;

            // ----- Obtengo Entiad Cliente ----------------------------------------------------------------------------------------------------------------------------------------
            ClienteFiltro filtroCliente = new ClienteFiltro();
            ClienteAgente OCliente = new ClienteAgente();
            ColeccionNegocioBase<ClienteEntidad> EntidadCliente = new ColeccionNegocioBase<ClienteEntidad>();
            ClienteEntidad EntidadMedio = new ClienteEntidad();
            filtroCliente.Criterio = Expresion.Eq(ClienteFiltro.COD_PAIS, Id_Pais);
            filtroCliente.Criterio = Expresion.And(filtroCliente.Criterio, Expresion.Eq(ClienteFiltro.COD_CLIENTE, Id_Cliente));
            EntidadCliente = OCliente.ObtenerClientes(filtroCliente, null, null, null, null);
            EntidadMedio = EntidadCliente[0];

            // ----- Obtengo Entiad Campania ----------------------------------------------------------------------------------------------------------------------------------------
            CampanaFiltro filtroCampania = new CampanaFiltro();
            CampanaAgente AgenteCampania = new CampanaAgente();
            ColeccionNegocioBase<CampanaEntidad> EntidadCampania = new ColeccionNegocioBase<CampanaEntidad>();
            filtroCampania.Criterio = Expresion.Eq(CampanaFiltro.COD_PAIS, Id_Pais);
            filtroCampania.Criterio = Expresion.And(filtroCampania.Criterio, Expresion.Eq(CampanaFiltro.COD_COMPANIA, Id_Compania));
            filtroCampania.Criterio = Expresion.And(filtroCampania.Criterio, Expresion.Eq(CampanaFiltro.COD_CLIENTE, Id_Cliente));
            filtroCampania.Criterio = Expresion.And(filtroCampania.Criterio, Expresion.Eq(CampanaFiltro.COD_CAMPANA, Id_Campania));
            EntidadCampania = AgenteCampania.ObtenerCampanas(filtroCampania, null, null, null);

            // ----- Obtengo Entiad SubCampania ----------------------------------------------------------------------------------------------------------------------------------------
            SubcampanaFiltro filtroSubCampania = new SubcampanaFiltro();
            SubcampanaAgente AgenteSubCampania = new SubcampanaAgente();
            ColeccionNegocioBase<SubcampanaEntidad> EntidadSubCampania = new ColeccionNegocioBase<SubcampanaEntidad>();
            filtroSubCampania.Criterio = Expresion.Eq(SubcampanaFiltro.COD_PAIS, Id_Pais);
            filtroSubCampania.Criterio = Expresion.And(filtroSubCampania.Criterio, Expresion.Eq(SubcampanaFiltro.COD_COMPANIA, Id_Compania));
            filtroSubCampania.Criterio = Expresion.And(filtroSubCampania.Criterio, Expresion.Eq(SubcampanaFiltro.COD_CAMPANA, Id_Campania));
            filtroSubCampania.Criterio = Expresion.And(filtroSubCampania.Criterio, Expresion.Eq(SubcampanaFiltro.COD_SUBCAMPANA, Id_SubCampania));
            EntidadSubCampania = AgenteSubCampania.obtenerSubcampanas(filtroSubCampania, null, null);

            // ----- Obtengo Entiad TipoPresupuestos ----------------------------------------------------------------------------------------------------------------------------------------
            TipoBasicoServicioAgente AgenteTipoBasico = new TipoBasicoServicioAgente();
            ColeccionNegocioBase<TipoBasicoEntidad> EntidadTipoBasico = new ColeccionNegocioBase<TipoBasicoEntidad>();
            FiltroGenerico filtro = new FiltroGenerico();
            filtro.Criterio = Expresion.Eq(HM.Comun.DeclaracionesGlobales.Cliente.Constantes.TIPO_PRESUPUESTO_COD_PAIS, Id_Pais);
            EntidadTipoBasico = AgenteTipoBasico.ObtenerElementos<TipoBasicoEntidad>(new TipoBasicoEntidad(NombresTiposBasicos.TIPO_PRESUPUESTO), filtro);
            PresupuestoEntidad TipoBasicoPresupuesto = new PresupuestoEntidad();

            foreach (TipoBasicoEntidad TBEntidad in EntidadTipoBasico)
            {
                if (TBEntidad.Codigo == Id_TPresupuesto)
                {
                    TipoBasicoPresupuesto.Tipo = TBEntidad;
                    break;
                }
            }

            //AG 19/09/2013 Obtengo Entiad Intercambio ----------------------------------------------------------------------------------------------------------------------------------------
            ColeccionNegocioBase<IntercambioEntidad> EntidadIntercambio = new ColeccionNegocioBase<IntercambioEntidad>();

            if (CodIntercambio != "")
            {
                FiltroGenerico IntercambioFiltro = new FiltroGenerico();
                IntercambioFiltro.Criterio = Expresion.Eq("CodIntercambio", CodIntercambio);
                IntercambioFiltro.Criterio = Expresion.And(filtro.Criterio, Expresion.Eq("CodCliente", Id_Cliente));
                EntidadIntercambio = new AgenteMaestro().obtenerElementosIntercambioEntidad(IntercambioFiltro);
            }
            else
            {
                EntidadIntercambio = null;
            }
            //================================================================================================

            //Cargo los Datos de la entidad Presupuesto --------------------------------------------------------------------------------------------------------------------------
            // Respetar el orden de en el cual se hacen las asignaciones de los objetos cargados
            PresupuestoEntidad EntidadPresupuesto = new PresupuestoEntidad();
            EntidadPresupuesto.Subcampana = new SubcampanaEntidad();
            EntidadPresupuesto.Subcampana.Campana = new CampanaEntidad();
            EntidadPresupuesto.Subcampana = EntidadSubCampania[0];
            EntidadPresupuesto.Subcampana.Campana = EntidadCampania[0];
            EntidadPresupuesto.Subcampana.Campana.Cliente = EntidadCliente[0];
            EntidadPresupuesto.Tipo = TipoBasicoPresupuesto.Tipo;
            EntidadPresupuesto.FechaEmisionOrdenes = F_EmisionOrden;
            EntidadPresupuesto.Estado = 1;
            EntidadPresupuesto.FechaEnvio = null;
            EntidadPresupuesto.FechaDevolucion = null;
            //AG 19/09/2013 =========================================================================================
            if (EntidadIntercambio == null)
            {
                EntidadPresupuesto.Intercambio = null;
            }
            else
            {
                EntidadPresupuesto.Intercambio = new IntercambioEntidad(); //AG 19/09/2013
                IntercambioEntidad EntidadIntercambioFinal = new IntercambioEntidad();
                foreach (IntercambioEntidad intercambio in EntidadIntercambio)
                {
                    if (Int32.Parse(intercambio.Codigo.ToString()) == Int32.Parse(CodIntercambio))
                    {
                        EntidadIntercambioFinal = intercambio;
                        break;
                    }
                }
                EntidadPresupuesto.Intercambio = EntidadIntercambioFinal;    //AG 19/09/2013
            }
            //======================================================================================================
            EntidadPresupuesto.NumeroDocumentoPresupuesto = NumeroOC;
            EntidadPresupuesto.Estado = 65;
            EntidadPresupuesto.FechaGrabacionOrdenes = DateTime.Now.Date;
            EntidadPresupuesto.OrigenObjeto = OrigenObjetoNegocio.ObjetoNuevo;

            //Realizo el insert de la Entidad Presupuesto --------------------------------------------------------------------------------------------------------------------------
            PresupuestoAgente AgentePresupuesto = new PresupuestoAgente();
            PresupuestoEntidad Presupuesto = new PresupuestoEntidad();

            if (EntidadPresupuesto != null)
            {
                Presupuesto = AgentePresupuesto.crearPresupuesto(EntidadPresupuesto);
                Cod_Presupuesto = Presupuesto.Codigo;
            }

            // Si el Valor que retorna es alguno de estos 2 entonces, no se realizo ningun insert en la Tabla Presupuesto del MMS - Captura error
            if (Presupuesto.Codigo == 0 || Presupuesto.Codigo == null)
            {
                Cod_Presupuesto = 0;
            }
            return Cod_Presupuesto;
        }

        public int? InsertarPresupuestoSinIntercambio(int Id_Cliente, int Id_TPresupuesto, int Id_Campania, int Id_SubCampania, int Id_Pais, int Id_Compania, DateTime F_EmisionOrden, String NumeroOC)
        {
            int? Cod_Presupuesto = 0;

            // ----- Obtengo Entiad Cliente ----------------------------------------------------------------------------------------------------------------------------------------
            ClienteFiltro filtroCliente = new ClienteFiltro();
            ClienteAgente OCliente = new ClienteAgente();
            ColeccionNegocioBase<ClienteEntidad> EntidadCliente = new ColeccionNegocioBase<ClienteEntidad>();
            ClienteEntidad EntidadMedio = new ClienteEntidad();
            filtroCliente.Criterio = Expresion.Eq(ClienteFiltro.COD_PAIS, Id_Pais);
            filtroCliente.Criterio = Expresion.And(filtroCliente.Criterio, Expresion.Eq(ClienteFiltro.COD_CLIENTE, Id_Cliente));
            EntidadCliente = OCliente.ObtenerClientes(filtroCliente, null, null, null, null);
            EntidadMedio = EntidadCliente[0];

            // ----- Obtengo Entiad Campania ----------------------------------------------------------------------------------------------------------------------------------------
            CampanaFiltro filtroCampania = new CampanaFiltro();
            CampanaAgente AgenteCampania = new CampanaAgente();
            ColeccionNegocioBase<CampanaEntidad> EntidadCampania = new ColeccionNegocioBase<CampanaEntidad>();
            filtroCampania.Criterio = Expresion.Eq(CampanaFiltro.COD_PAIS, Id_Pais);
            filtroCampania.Criterio = Expresion.And(filtroCampania.Criterio, Expresion.Eq(CampanaFiltro.COD_COMPANIA, Id_Compania));
            filtroCampania.Criterio = Expresion.And(filtroCampania.Criterio, Expresion.Eq(CampanaFiltro.COD_CLIENTE, Id_Cliente));
            filtroCampania.Criterio = Expresion.And(filtroCampania.Criterio, Expresion.Eq(CampanaFiltro.COD_CAMPANA, Id_Campania));
            EntidadCampania = AgenteCampania.ObtenerCampanas(filtroCampania, null, null, null);

            // ----- Obtengo Entiad SubCampania ----------------------------------------------------------------------------------------------------------------------------------------
            SubcampanaFiltro filtroSubCampania = new SubcampanaFiltro();
            SubcampanaAgente AgenteSubCampania = new SubcampanaAgente();
            ColeccionNegocioBase<SubcampanaEntidad> EntidadSubCampania = new ColeccionNegocioBase<SubcampanaEntidad>();
            filtroSubCampania.Criterio = Expresion.Eq(SubcampanaFiltro.COD_PAIS, Id_Pais);
            filtroSubCampania.Criterio = Expresion.And(filtroSubCampania.Criterio, Expresion.Eq(SubcampanaFiltro.COD_COMPANIA, Id_Compania));
            filtroSubCampania.Criterio = Expresion.And(filtroSubCampania.Criterio, Expresion.Eq(SubcampanaFiltro.COD_CAMPANA, Id_Campania));
            filtroSubCampania.Criterio = Expresion.And(filtroSubCampania.Criterio, Expresion.Eq(SubcampanaFiltro.COD_SUBCAMPANA, Id_SubCampania));
            EntidadSubCampania = AgenteSubCampania.obtenerSubcampanas(filtroSubCampania, null, null);

            // ----- Obtengo Entiad TipoPresupuestos ----------------------------------------------------------------------------------------------------------------------------------------
            TipoBasicoServicioAgente AgenteTipoBasico = new TipoBasicoServicioAgente();
            ColeccionNegocioBase<TipoBasicoEntidad> EntidadTipoBasico = new ColeccionNegocioBase<TipoBasicoEntidad>();
            FiltroGenerico filtro = new FiltroGenerico();
            filtro.Criterio = Expresion.Eq(HM.Comun.DeclaracionesGlobales.Cliente.Constantes.TIPO_PRESUPUESTO_COD_PAIS, Id_Pais);
            EntidadTipoBasico = AgenteTipoBasico.ObtenerElementos<TipoBasicoEntidad>(new TipoBasicoEntidad(NombresTiposBasicos.TIPO_PRESUPUESTO), filtro);
            PresupuestoEntidad TipoBasicoPresupuesto = new PresupuestoEntidad();

            foreach (TipoBasicoEntidad TBEntidad in EntidadTipoBasico)
            {
                if (TBEntidad.Codigo == Id_TPresupuesto)
                {
                    TipoBasicoPresupuesto.Tipo = TBEntidad;
                    break;
                }
            }

            //Cargo los Datos de la entidad Presupuesto --------------------------------------------------------------------------------------------------------------------------
            // Respetar el orden de en el cual se hacen las asignaciones de los objetos cargados
            PresupuestoEntidad EntidadPresupuesto = new PresupuestoEntidad();
            EntidadPresupuesto.Subcampana = new SubcampanaEntidad();
            EntidadPresupuesto.Subcampana.Campana = new CampanaEntidad();
            EntidadPresupuesto.Subcampana = EntidadSubCampania[0];
            EntidadPresupuesto.Subcampana.Campana = EntidadCampania[0];
            EntidadPresupuesto.Subcampana.Campana.Cliente = EntidadCliente[0];
            EntidadPresupuesto.Tipo = TipoBasicoPresupuesto.Tipo;
            EntidadPresupuesto.FechaEmisionOrdenes = F_EmisionOrden;
            EntidadPresupuesto.Estado = 1;
            EntidadPresupuesto.FechaEnvio = null;
            EntidadPresupuesto.FechaDevolucion = null;
            EntidadPresupuesto.Intercambio = null;
            EntidadPresupuesto.NumeroDocumentoPresupuesto = NumeroOC;
            EntidadPresupuesto.Estado = 65;
            EntidadPresupuesto.FechaGrabacionOrdenes = DateTime.Now.Date;
            EntidadPresupuesto.OrigenObjeto = OrigenObjetoNegocio.ObjetoNuevo;

            //Realizo el insert de la Entidad Presupuesto --------------------------------------------------------------------------------------------------------------------------
            PresupuestoAgente AgentePresupuesto = new PresupuestoAgente();
            PresupuestoEntidad Presupuesto = new PresupuestoEntidad();

            if (EntidadPresupuesto != null)
            {
                Presupuesto = AgentePresupuesto.crearPresupuesto(EntidadPresupuesto);
                Cod_Presupuesto = Presupuesto.Codigo;
            }

            // Si el Valor que retorna es alguno de estos 2 entonces, no se realizo ningun insert en la Tabla Presupuesto del MMS - Captura error
            if (Presupuesto.Codigo == 0 || Presupuesto.Codigo == null)
            {
                Cod_Presupuesto = 0;
            }
            return Cod_Presupuesto;
        }

        /// <summary>
        /// Obtiene un presupuesto. JJP 30052010
        /// </summary>
        /// <param name="id_pais"></param>
        /// <param name="id_compania"></param>
        /// <param name="id_presupuesto"></param>
        /// <returns>PresupuestoEntidad</returns>
        public PresupuestoEntidad obtenerPresupuesto(int id_pais, int id_compania, int id_presupuesto)
        {
            //filtro de Presupuestos ---------------------------------------------------------------------------------------------------
            ColeccionNegocioBase<PresupuestoEntidad> lstPresupuestos = null;
            PresupuestoFiltro filtroPresupuesto = new PresupuestoFiltro();
            filtroPresupuesto.Criterio = Expresion.Eq(PresupuestoFiltro.COD_PAIS, id_pais);
            filtroPresupuesto.Criterio = Expresion.And(filtroPresupuesto.Criterio, Expresion.Eq(PresupuestoFiltro.COD_COMPANIA, id_compania));
            filtroPresupuesto.Criterio = Expresion.And(filtroPresupuesto.Criterio, Expresion.Eq(PresupuestoFiltro.COD_PRESUPUESTO, id_presupuesto));
            //--------------------------------------------------------------------------------------------------------------------------

            //Filtro para la coleccion de Campañas asociadas a la subCampanas para obtener datos de la campania ---------------------
            CampanaFiltro filtroCampana = null;
            //---------------------------------------------------------------------------------------------------------------------

            //Filtro para la coleccion de SubCampañas asociados al presupuesto para obtener datos de la Subcampania ---------------------
            SubcampanaFiltro filtroSubCampana = null;
            //---------------------------------------------------------------------------------------------------------------------

            using (GenericProxy<IPresupuestoServicio> servicio = new GenericProxy<IPresupuestoServicio>("WSHttpBinding_IPresupuestoServicio"))
            {
                servicio.InvocarOperacion(delegate(IPresupuestoServicio serv)
                {
                    lstPresupuestos = serv.obtenerPresupuestos(filtroPresupuesto, filtroSubCampana, filtroCampana);
                });
            }

            if (lstPresupuestos.Count > 0)
                return lstPresupuestos[0];
            else
                return null;
        }

        public string InsertarMateriales(int IdPais, int IdCliente, int IdMedio, int IdProducto, string IdMaterial, int Duracion, string DescripcionMaterial)
        {
            Maestros oMaterial = new Maestros();
            DataTable Material;
            DataTable Medio = new DataTable();
            Maestros oMaestros = new Maestros();
            MaterialEntidad EntidadMaterial = new MaterialEntidad();
            ProductoAgente AgenteMaterial = new ProductoAgente();
            DataRow[] RowsMedio;
            DataRow[] RowsMaterial;
            string Cod_Material = null;

            // Busco Todos los materiales de ese producto y filtro por la Clave que ingreso el usuario
            string filter = "CLAVE_MATERIAL= '" + IdMaterial + "'";
            Material = oMaterial.MaterialesTraerTodos(IdPais, IdCliente, IdProducto);
            RowsMaterial = Material.Select(filter);

            if (RowsMaterial.Length == 0)
            {
                //Obtengo el Medio ----------------------------------------------------------------------
                string Filtro = "id_medio =" + IdMedio;
                Medio = oMaestros.MediosTraerTodos(IdPais);
                RowsMedio = Medio.Select(Filtro);
                EntidadMaterial.OrigenObjeto = OrigenObjetoNegocio.ObjetoNuevo;
                EntidadMaterial.Operacion = TiposOperacion.Insertar;
                //Cargo datos Pais ----------------------------------------------------------------------------------
                EntidadMaterial.Pais = new PaisEntidad();
                EntidadMaterial.Pais.CodPais = IdPais;
                EntidadMaterial.Descripcion = DescripcionMaterial;
                EntidadMaterial.Clave = IdMaterial.ToUpper();
                EntidadMaterial.FechaInicio = DateTime.Now.Date;
                EntidadMaterial.FechaFin = DateTime.Now.Date;
                //Cargo datos Medio --------------------------------------------------------------------------------
                EntidadMaterial.Medio = new MedioEntidad();
                EntidadMaterial.Medio.CodMedio = IdMedio;
                EntidadMaterial.Medio.DesMedio = RowsMedio[0]["DESCRIPCION"].ToString();
                //Cargo datos Procedencia --------------------------------------------------------------------------------
                EntidadMaterial.Procedencia = new ProcedenciaEntidad();
                EntidadMaterial.Procedencia.Codigo = 1;
                EntidadMaterial.Procedencia.Descripcion = "GENERICO";
                EntidadMaterial.Tamano = Duracion;
                //Cargo datos Producto --------------------------------------------------------------------------------
                EntidadMaterial.Producto = new ProductoEntidad();
                EntidadMaterial.Producto.CodigoProducto = IdProducto;
                //Cargo datos Cliente --------------------------------------------------------------------------------
                EntidadMaterial.Cliente = new ClienteEntidad();
                EntidadMaterial.Cliente.CodigoCliente = IdCliente;
                EntidadMaterial.Cliente.Pais = EntidadMaterial.Pais;

                if (EntidadMaterial != null)
                {
                    EntidadMaterial = AgenteMaterial.CrearMaterial(EntidadMaterial);
                    return Cod_Material = EntidadMaterial.Codigo.Value.ToString();
                }
            }
            return Cod_Material = "";
        }

        public string ActualizarMateriales(int IdPais, int IdCliente, int IdMedio, int IdProducto, string IdMaterial, int Duracion, string DescripcionMaterial)
        {
            Maestros oMaterial = new Maestros();
            DataTable Material;
            DataTable Medio = new DataTable();
            Maestros oMaestros = new Maestros();
            MaterialEntidad EntidadMaterial = new MaterialEntidad();
            AgenteGenerico AgenteMaterial = new AgenteGenerico();
            DataRow[] RowsMedio;
            DataRow[] RowsMaterial;
            string Cod_Material = null;

            // Busco Todos los materiales de ese producto y filtro por la Clave que ingreso el usuario
            string filter = "ID_MATERIAL= '" + IdMaterial + "'";
            Material = oMaterial.MaterialesTraerTodos(IdPais, IdCliente, IdProducto);
            RowsMaterial = Material.Select(filter);

            if (RowsMaterial.Length == 1)
            {
                //Obtengo el Medio ----------------------------------------------------------------------
                string Filtro = "id_medio =" + IdMedio;
                Medio = oMaestros.MediosTraerTodos(IdPais);
                RowsMedio = Medio.Select(Filtro);
                EntidadMaterial.OrigenObjeto = OrigenObjetoNegocio.ObjetoNuevo;
                EntidadMaterial.Operacion = TiposOperacion.Modificar;
                //Cargo datos Pais ----------------------------------------------------------------------------------
                EntidadMaterial.Pais = new PaisEntidad();
                EntidadMaterial.Pais.CodPais = IdPais;
                EntidadMaterial.Codigo = int.Parse(RowsMaterial[0]["ID_MATERIAL"].ToString());
                EntidadMaterial.Descripcion = DescripcionMaterial;
                EntidadMaterial.Clave = RowsMaterial[0]["CLAVE_MATERIAL"].ToString();
                EntidadMaterial.FechaInicio = DateTime.Now.Date;
                EntidadMaterial.FechaFin = DateTime.Now.Date;
                //Cargo datos Medio --------------------------------------------------------------------------------
                EntidadMaterial.Medio = new MedioEntidad();
                EntidadMaterial.Medio.CodMedio = IdMedio;
                EntidadMaterial.Medio.DesMedio = RowsMedio[0]["DESCRIPCION"].ToString();
                //Cargo datos Procedencia --------------------------------------------------------------------------------
                EntidadMaterial.Procedencia = new ProcedenciaEntidad();
                EntidadMaterial.Procedencia.Codigo = 1;
                EntidadMaterial.Procedencia.Descripcion = "GENERICO";
                EntidadMaterial.Tamano = Duracion;
                //Cargo datos Producto --------------------------------------------------------------------------------
                EntidadMaterial.Producto = new ProductoEntidad();
                EntidadMaterial.Producto.CodigoProducto = IdProducto;
                //Cargo datos Cliente --------------------------------------------------------------------------------
                EntidadMaterial.Cliente = new ClienteEntidad();
                EntidadMaterial.Cliente.CodigoCliente = IdCliente;
                EntidadMaterial.Cliente.Pais = EntidadMaterial.Pais;

                if (EntidadMaterial != null)
                {
                    EntidadMaterial = (MaterialEntidad)AgenteMaterial.Elemento_Modificar(EntidadMaterial);
                    return Cod_Material = EntidadMaterial.Clave;
                }
            }
            return Cod_Material = "";
        }

        public void ActualizarPresupuesto(int Id_Pais, int Id_Presupuesto, int Id_Intercambio)
        {
            PresupuestoEntidad EntidadPresupuesto = new PresupuestoEntidad();
            PresupuestoAgente AgentePresupuesto = new PresupuestoAgente();
            EntidadPresupuesto.Codigo = Id_Presupuesto;
            EntidadPresupuesto = AgentePresupuesto.modificarPresupuesto(EntidadPresupuesto);
        }

        public void ActualizarPresupuestoOC(int CodigoCompania, int Id_Presupuesto, String NumeroOC)
        {
            PresupuestoEntidad EntidadPresupuesto = new PresupuestoEntidad();
            PresupuestoAgente AgentePresupuesto = new PresupuestoAgente();

            UsuarioAgente OUsuario = new UsuarioAgente();
            HM.Contratos.Entidad.Seguridad.UsuarioEntidad EntidadUsuario = new HM.Contratos.Entidad.Seguridad.UsuarioEntidad();
            EntidadUsuario = OUsuario.ObtenerUsuarioActivo();
            EntidadUsuario.Companias.Buscar(new ColeccionFiltro(CompaniaFiltro.COD_COMPANIA, CodigoCompania));

            EntidadPresupuesto = obtenerPresupuesto(EntidadUsuario.CodPais.Value, CodigoCompania, Id_Presupuesto);
            EntidadPresupuesto.NumeroDocumentoPresupuesto = NumeroOC;
            EntidadPresupuesto.Compania = EntidadUsuario.Companias.Find(x => x.Codigo == CodigoCompania);

            EntidadPresupuesto = AgentePresupuesto.modificarPresupuesto(EntidadPresupuesto);
        }

        public ColeccionNegocioBase<IntercambioEntidad> obtenerIntercambios(int id_pais, int codcompania, int id_cliente, DateTime Fdesde, DateTime Fhasta, string codintercambio)
        {
            ColeccionNegocioBase<IntercambioEntidad> ColIntercambio = null;
            FiltroGenerico filtro = new FiltroGenerico();

            if (codintercambio != "")
            {
                filtro.Criterio = Expresion.Eq("CodIntercambio", codintercambio);
                filtro.Criterio = Expresion.And(filtro.Criterio, Expresion.Eq("CodCliente", id_cliente));
            }
            else
            {
                filtro.Criterio = Expresion.Eq("CodCliente", id_cliente);
                filtro.Criterio = Expresion.And(filtro.Criterio, Expresion.Le("FFinIntercambio", Fhasta));
                filtro.Criterio = Expresion.And(filtro.Criterio, Expresion.Ge("FInicioIntercambio", Fdesde));
                filtro.Criterio = Expresion.And(filtro.Criterio, Expresion.Eq("CodCompania", codcompania));
            }

            ColIntercambio = new AgenteMaestro().obtenerElementosIntercambioEntidad(filtro);

            if (ColIntercambio.Count > 0)
                return ColIntercambio;
            else
                return null;
        }

        public DataTable ObtenerServiciosAgenciaInternet(int codigoCompania, int codigoCliente, String fechaInicio, String fechaFin)
        {
            DataTable Dt = new DataTable();

            HM.MMS.AR.Client.Agentes.AgenteGestionMaestros agenteSerAgenciaInternet = new HM.MMS.AR.Client.Agentes.AgenteGestionMaestros();

            Dt = agenteSerAgenciaInternet.ObtenerServiciosAgencia(codigoCompania, codigoCliente, fechaInicio, fechaFin);

            return Dt;
        }

        #endregion Presupuestos
    }
}