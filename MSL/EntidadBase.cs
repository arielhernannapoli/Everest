using System;
using System.IO;
using HM.Comun.Agentes;
using HM.Comun.Compresion;
using HM.Comun.Persistencia;
using HM.Comun.Persistencia.Entidad;
using HM.Comun.Persistencia.Entidad.CriterioFiltro;
using HM.Comun.Utilidades;
using HM.Comun.Varios;
using HM.Contratos;
using HM.Contratos.Entidad.Cliente;
using HM.Contratos.Entidad.Maestros;
using HM.Contratos.Entidad.Seguridad;
using HM.Contratos.Entidad.Soportes;
using HM.Contratos.Servicio;
using HM.MMS.Agentes.Proveedores;
using HM.MMS.Core.Server.BusinessEntity.Seguridad;
using User = HM.Comun.ExecutionArchitecture.Security.Information;

namespace MSL
{
    public partial class DatosMms
    {
        #region Productos

        /// <summary>
        /// Obtiene todos los productos
        /// </summary>
        /// <param name="id_pais"></param>
        /// <returns></returns>
        public ColeccionNegocioBase<EntidadLectura> ObtenerProductosLectura(int id_pais)
        {
            ColeccionNegocioBase<EntidadLectura> lstProducto = new ColeccionNegocioBase<EntidadLectura>();
            using (GenericProxy<IProductoServicio> servicio = new GenericProxy<IProductoServicio>("WSHttpBinding_IProductoServicio"))
            {
                servicio.InvocarOperacion(delegate(IProductoServicio serv)
                {
                    lstProducto = serv.obtenerProductosLectura(null);
                });
            }
            return lstProducto;
        }

        /// <summary>
        /// obtiene todos los productos de un cliente
        /// </summary>
        /// <param name="id_pais"></param>
        /// <param name="id_cliente"></param>
        /// <returns></returns>
        public ColeccionNegocioBase<EntidadLectura> ObtenerProductosLectura(int id_pais, int id_cliente)
        {
            ColeccionNegocioBase<EntidadLectura> lstProducto = new ColeccionNegocioBase<EntidadLectura>();
            ProductoFiltro filtroProducto = new ProductoFiltro();
            filtroProducto.Criterio = Expresion.And(filtroProducto.Criterio, Expresion.Eq(ProductoFiltro.COD_PAIS, id_pais));
            filtroProducto.Criterio = Expresion.And(filtroProducto.Criterio, Expresion.Eq(ProductoFiltro.COD_CLIENTE, id_cliente));
            //.SP_FILTRO_TEMAS", Id_Cliente, Id_Campania, Id_Medio, Id_Tipo_Soporte, Id_Target).Tables
            //filtroProducto.Criterio = Expresion.And(filtroProducto.Criterio, Expresion.Eq(ProductoFiltro
            using (GenericProxy<IProductoServicio> servicio = new GenericProxy<IProductoServicio>("WSHttpBinding_IProductoServicio"))
            {
                servicio.InvocarOperacion(delegate(IProductoServicio serv)
                {
                    lstProducto = serv.obtenerProductosLectura(filtroProducto);//null);
                });
            }

            return lstProducto;
        }

        /// <summary>
        /// Obtiene un producto por codigo de producto
        /// </summary>
        /// <param name="id_pais"></param>
        /// <param name="id_cliente"></param>
        /// <param name="id_producto"></param>
        /// <returns></returns>
        public ColeccionNegocioBase<EntidadLectura> ObtenerProductoLecturaByProducto(int id_pais, int id_cliente, int id_producto)
        {
            ColeccionNegocioBase<EntidadLectura> lstProducto = new ColeccionNegocioBase<EntidadLectura>();
            ProductoFiltro filtroProducto = new ProductoFiltro();
            //filtroProducto.Criterio = Expresion.And(filtroProducto.Criterio, Expresion.Eq(ProductoFiltro.COD_PAIS, id_pais));
            //filtroProducto.Criterio = Expresion.And(filtroProducto.Criterio, Expresion.Eq(ProductoFiltro.COD_CLIENTE, id_cliente));
            filtroProducto.Criterio = Expresion.And(filtroProducto.Criterio, Expresion.Eq(ProductoFiltro.COD_PRODUCTO, id_producto));

            using (GenericProxy<IProductoServicio> servicio = new GenericProxy<IProductoServicio>("WSHttpBinding_IProductoServicio"))
            {
                servicio.InvocarOperacion(delegate(IProductoServicio serv)
                {
                    lstProducto = serv.obtenerProductosLectura(filtroProducto);//null);
                });
            }
            return lstProducto;
        }

        //DESCRIPCION
        public string productoDescripcionByidProductoCliente(int id_cliente, int id_producto)//int id_pais, int id_cliente, int id_producto)
        {
            ColeccionNegocioBase<EntidadLectura> lstProducto = new ColeccionNegocioBase<EntidadLectura>();
            ProductoFiltro filtroProducto = new ProductoFiltro();
            string sProducto = "";
            //filtroProducto.Criterio = Expresion.And(filtroProducto.Criterio, Expresion.Eq(ProductoFiltro.COD_PAIS, id_pais));
            filtroProducto.Criterio = Expresion.And(filtroProducto.Criterio, Expresion.Eq(ProductoFiltro.COD_CLIENTE, id_cliente));
            filtroProducto.Criterio = Expresion.And(filtroProducto.Criterio, Expresion.Eq(ProductoFiltro.COD_PRODUCTO, id_producto));

            using (GenericProxy<IProductoServicio> servicio = new GenericProxy<IProductoServicio>("WSHttpBinding_IProductoServicio"))
            {
                servicio.InvocarOperacion(delegate(IProductoServicio serv)
                {
                    lstProducto = serv.obtenerProductosLectura(filtroProducto);//null);
                });
            }
            sProducto = lstProducto[0].Descripcion1;
            return sProducto;
        }

        public ColeccionNegocioBase<ProductoEntidad> GetProductoCompleto(int id_cliente)
        {        
            ProductoFiltro filtro = new ProductoFiltro();
            filtro.Criterio = Expresion.And(filtro.Criterio, Expresion.Eq(ProductoFiltro.COD_CLIENTE, id_cliente));

            ColeccionNegocioBase<ProductoEntidad> productos = new HM.MMS.Agentes.Comun.AgenteMaestro().obtenerElementosProductoEntidad(filtro);

            return productos;
        }        
        
        #endregion Productos

        #region Soportes

        #region Funciones Busqueda Soportes x cada Medio

        public ColeccionNegocioBase<EntidadLectura> obtenerSoporteTodos(int id_pais, int id_medio)
        {
            ColeccionNegocioBase<EntidadLectura> lstSoportes = null;
            SoporteFiltro filtroSoporte = new SoporteFiltro();
            filtroSoporte.Criterio = Expresion.Eq(SoporteFiltro.COD_PAIS, id_pais);
            filtroSoporte.Criterio = Expresion.And(filtroSoporte.Criterio, Expresion.Eq(SoporteFiltro.COD_MEDIO, id_medio));
            using (GenericProxy<ISoporteServicio> servicio = new GenericProxy<ISoporteServicio>("WSHttpBinding_ISoporteServicio"))
            {
                servicio.InvocarOperacion(delegate(ISoporteServicio serv)
                {
                    lstSoportes = serv.obtenerSoportesLectura(filtroSoporte);
                });
            }
            return lstSoportes;
        }

        #endregion Funciones Busqueda Soportes x cada Medio

        public ColeccionNegocioBase<SoporteEntidad> obtenerSoporteXid(int id_medio, int id_soporte)
        {
            ColeccionNegocioBase<SoporteEntidad> lstSoportes = null;
            SoporteEntidad eSoporte;
            SoporteFiltro filtroSoporte = new SoporteFiltro();
            filtroSoporte.Criterio = Expresion.And(filtroSoporte.Criterio, Expresion.Eq(SoporteFiltro.COD_MEDIO, id_medio));
            filtroSoporte.Criterio = Expresion.And(filtroSoporte.Criterio, Expresion.Eq(SoporteFiltro.COD_SOPORTE, id_soporte));
            using (GenericProxy<ISoporteServicio> servicio = new GenericProxy<ISoporteServicio>("WSHttpBinding_ISoporteServicio"))
            {
                servicio.InvocarOperacion(delegate(ISoporteServicio serv)
                {
                    lstSoportes = serv.obtenerSoportes(filtroSoporte, null, false);
                });
            }
            return lstSoportes;
        }

        /// <summary>
        /// obtener soportes cliente
        /// </summary>
        /// <param name="id_pais"></param>
        /// <param name="id_cliente"></param>
        /// <returns></returns>
        public ColeccionNegocioBase<SoporteEntidad> ObtenerSoporteLecturaCliente(int id_pais, int id_cliente)
        {
            ColeccionNegocioBase<SoporteEntidad> lstSoportes = new ColeccionNegocioBase<SoporteEntidad>();
            SoporteFiltro filtroSoporte = new SoporteFiltro();
            filtroSoporte.Criterio = Expresion.And(filtroSoporte.Criterio, Expresion.Eq(SoporteFiltro.COD_PAIS, id_pais));
            using (GenericProxy<ISoporteServicio> servicio = new GenericProxy<ISoporteServicio>(""))
            {
                servicio.InvocarOperacion(delegate(ISoporteServicio serv)
                {
                    lstSoportes = serv.obtenerSoportes(filtroSoporte, null, false);
                });
            }
            return lstSoportes;
        }

        public ColeccionNegocioBase<SoporteEntidad> ObtenerSoportes(int id_pais, int id_medio, int id_tipoSoporte, int id_plaza)
        {
            ColeccionNegocioBase<SoporteEntidad> lstSoportes = new ColeccionNegocioBase<SoporteEntidad>();
            SoporteFiltro filtroSoporte = new SoporteFiltro();
            TipoSoporteFiltro filtroTipoSoporte = new TipoSoporteFiltro();
            CoberturaFiltro filtroCobertura = new CoberturaFiltro();
            filtroSoporte.Criterio = Expresion.And(filtroSoporte.Criterio, Expresion.Eq(SoporteFiltro.COD_PAIS, id_pais));
            filtroSoporte.Criterio = Expresion.And(filtroSoporte.Criterio, Expresion.Eq(SoporteFiltro.COD_MEDIO, id_medio));
            filtroTipoSoporte.Criterio = Expresion.And(filtroTipoSoporte.Criterio, Expresion.Eq(TipoSoporteFiltro.COD_TIPO_SOPORTE, id_tipoSoporte));
            filtroCobertura.Criterio = Expresion.And(filtroCobertura.Criterio, Expresion.Eq(CoberturaFiltro.COBERTURA_CODIGO, id_plaza));
            using (GenericProxy<ISoporteServicio> servicio = new GenericProxy<ISoporteServicio>("WSHttpBinding_ISoporteServicio"))
            {
                servicio.InvocarOperacion(delegate(ISoporteServicio serv)
                {
                    lstSoportes = serv.obtenerSoportesCobertura(filtroSoporte, filtroTipoSoporte, filtroCobertura, null, null, null, null);
                });
            }
            return lstSoportes;
        }

        public ColeccionNegocioBase<EntidadLectura> ObtenerSoporteLectura(int id_pais, int id_medio, int id_tipoSoporte, int id_plaza)
        {
            ColeccionNegocioBase<EntidadLectura> lstSoportes = new ColeccionNegocioBase<EntidadLectura>();
            SoporteFiltro filtroSoporte = new SoporteFiltro();
            filtroSoporte.Criterio = Expresion.And(filtroSoporte.Criterio, Expresion.Eq(SoporteFiltro.COD_PAIS, id_pais));
            filtroSoporte.Criterio = Expresion.And(filtroSoporte.Criterio, Expresion.Eq(SoporteFiltro.COD_MEDIO, id_medio));
            using (GenericProxy<ISoporteServicio> servicio = new GenericProxy<ISoporteServicio>("WSHttpBinding_ISoporteServicio"))
            {
                servicio.InvocarOperacion(delegate(ISoporteServicio serv)
                {
                    lstSoportes = serv.obtenerSoportesLectura(filtroSoporte);
                });
            }
            return lstSoportes;
        }

        /// <summary>
        /// Obtiene todos los soportes por medio
        /// </summary>
        /// <param name="id_pais"></param>
        /// <param name="id_medio"></param>
        /// <returns></returns>
        public ColeccionNegocioBase<EntidadLectura> ObtenerSoporteLectura(int id_pais, int id_medio)
        {
            ColeccionNegocioBase<EntidadLectura> lstSoportes = new ColeccionNegocioBase<EntidadLectura>();
            SoporteFiltro filtroSoporte = new SoporteFiltro();
            filtroSoporte.Criterio = Expresion.And(filtroSoporte.Criterio, Expresion.Eq(SoporteFiltro.COD_PAIS, id_pais));
            filtroSoporte.Criterio = Expresion.And(filtroSoporte.Criterio, Expresion.Eq(SoporteFiltro.COD_MEDIO, id_medio));
            using (GenericProxy<ISoporteServicio> servicio = new GenericProxy<ISoporteServicio>("WSHttpBinding_ISoporteServicio"))
            {
                servicio.InvocarOperacion(delegate(ISoporteServicio serv)
                {
                    lstSoportes = serv.obtenerSoportesLectura(filtroSoporte);//obtenerSoportes(filtroSoporte, null, false);
                });
            }
            return lstSoportes;
        }

        /// <summary>
        /// Obtener todos los soportes por pais
        /// </summary>
        /// <param name="id_pais"></param>
        /// <returns></returns>
        public ColeccionNegocioBase<EntidadLectura> ObtenerSoporteLectura(int id_pais)
        {
            ColeccionNegocioBase<EntidadLectura> lstSoportes = new ColeccionNegocioBase<EntidadLectura>();
            SoporteFiltro filtroSoporte = new SoporteFiltro();
            filtroSoporte.Criterio = Expresion.And(filtroSoporte.Criterio, Expresion.Eq(SoporteFiltro.COD_PAIS, id_pais));
            using (GenericProxy<ISoporteServicio> servicio = new GenericProxy<ISoporteServicio>("WSHttpBinding_ISoporteServicio"))
            {
                servicio.InvocarOperacion(delegate(ISoporteServicio serv)
                {
                    lstSoportes = serv.obtenerSoportesLectura(filtroSoporte);
                });
            }
            return lstSoportes;
        }

        /// <summary>
        /// obtener soportes por codigo medio / editorial
        /// </summary>
        /// <param name="id_pais"></param>
        /// <param name="id_medio"></param>
        /// <param name="id_editorial"></param>
        /// <returns></returns>
        public ColeccionNegocioBase<EntidadLectura> ObtenerSoporteEditorial(int id_pais, int id_medio, int id_editorial)
        {
            ColeccionNegocioBase<EntidadLectura> lstSoportes = new ColeccionNegocioBase<EntidadLectura>();
            SoporteFiltro filtroSoporte = new SoporteFiltro();
            filtroSoporte.Criterio = Expresion.And(filtroSoporte.Criterio, Expresion.Eq(SoporteFiltro.COD_PAIS, id_pais));
            filtroSoporte.Criterio = Expresion.And(filtroSoporte.Criterio, Expresion.Eq(SoporteFiltro.COD_MEDIO, id_medio));
            filtroSoporte.Criterio = Expresion.And(filtroSoporte.Criterio, Expresion.Eq(SoporteFiltro.COD_EDITORIAL, id_editorial));
            using (GenericProxy<ISoporteServicio> servicio = new GenericProxy<ISoporteServicio>("WSHttpBinding_ISoporteServicio"))
            {
                servicio.InvocarOperacion(delegate(ISoporteServicio serv)
                {
                    lstSoportes = serv.obtenerSoportesLectura(filtroSoporte);
                });
            }
            return lstSoportes;
        }

        public string ObtenerSoporteDescripcion(int id_pais, int id_medio, int id_soporte)
        {
            SoporteEntidad entSoporte = new SoporteEntidad();
            ColeccionNegocioBase<SoporteEntidad> lstSoportes = new ColeccionNegocioBase<SoporteEntidad>();
            SoporteFiltro filtroSoporte = new SoporteFiltro();
            filtroSoporte.Criterio = Expresion.And(filtroSoporte.Criterio, Expresion.Eq(SoporteFiltro.COD_PAIS, id_pais));
            filtroSoporte.Criterio = Expresion.And(filtroSoporte.Criterio, Expresion.Eq(SoporteFiltro.COD_MEDIO, id_medio));
            filtroSoporte.Criterio = Expresion.And(filtroSoporte.Criterio, Expresion.Eq(SoporteFiltro.COD_SOPORTE, id_soporte));
            using (GenericProxy<ISoporteServicio> servicio = new GenericProxy<ISoporteServicio>("WSHttpBinding_ISoporteServicio"))
            {
                servicio.InvocarOperacion(delegate(ISoporteServicio serv)
                {
                    lstSoportes = serv.obtenerSoportes(filtroSoporte, null, false);
                });
            }
            if (lstSoportes.Capacity > 0) entSoporte = lstSoportes[0];
            return entSoporte.Descripcion;
        }

        public ColeccionNegocioBase<SoporteEntidad> ObtenerSoportePorCobertura(int Id_Pais, int Id_Medio, int Id_Soporte, int Id_TipoSoporte)
        {
            ColeccionNegocioBase<SoporteEntidad> EntidadSopCobertura = new ColeccionNegocioBase<SoporteEntidad>();
            SoporteFiltro FiltroSoporte = new SoporteFiltro();
            SoporteAgente AgenteSoporte = new SoporteAgente();
            FiltroSoporte.Criterio = Expresion.Eq(SoporteFiltro.COD_PAIS, Id_Pais);
            //FiltroSoporte.Criterio = Expresion.And(FiltroSoporte.Criterio, Expresion.Eq(SoporteFiltro.COD_MEDIO, Id_Medio));
            //if (Id_Soporte > 0)
            //{FiltroSoporte.Criterio = Expresion.And(FiltroSoporte.Criterio, Expresion.Eq(SoporteFiltro.COD_SOPORTE, Id_Soporte));}
            return EntidadSopCobertura = AgenteSoporte.obtenerSoportesCobertura(FiltroSoporte, null, null, null, null, null, null);
        }

        #endregion Soportes

        #region Medios

        /// <summary>
        /// Obtenemos los medios
        /// </summary>
        /// <param name="IdPais"></param>
        /// <returns></returns>
        public ColeccionNegocioBase<EntidadLectura> ObtenerMediosLectura(int IdPais)
        {
            MedioFiltro filtroMedio = new MedioFiltro();
            ColeccionNegocioBase<EntidadLectura> lstGen = null;
            FiltroBase baseFiltro = filtroMedio;
            using (GenericProxy<IServicioGenerico> servicio = new GenericProxy<IServicioGenerico>("WSHttpBinding_IServicioGenerico"))
            {
                servicio.InvocarOperacion(delegate(IServicioGenerico serv)
                {
                    lstGen = serv.obtenerElementosLectura(new EntidadLectura(EntidadLectura.MEDIO), null);
                });
            }
            return lstGen;
        }

        #endregion Medios

        #region Tipo_Soporte

        public ColeccionNegocioBase<EntidadLectura> soporteTipoSoporte(int IdPais)
        {
            TipoSoporteFiltro filtrTiSop = new TipoSoporteFiltro();
            ColeccionNegocioBase<EntidadLectura> lstGen = null;
            FiltroBase baseFiltro = filtrTiSop;
            using (GenericProxy<IServicioGenerico> servicio = new GenericProxy<IServicioGenerico>("WSHttpBinding_IServicioGenerico"))
            {
                servicio.InvocarOperacion(delegate(IServicioGenerico serv)
                {
                    lstGen = serv.obtenerElementosLectura(new EntidadLectura(EntidadLectura.TIPO_SOPORTE), null);
                });
            }
            return lstGen;
        }

        public ColeccionNegocioBase<TipoSoporteEntidad> ObtenerTipoSoporte(int IdPais)
        {
            AgenteGenerico Agente = new AgenteGenerico();
            FiltroGenerico FiltroTSoporte = new FiltroGenerico();
            FiltroTSoporte.Criterio = Expresion.Eq(HM.Comun.DeclaracionesGlobales.Cliente.Constantes.TIPOSOPORTE_CODIGO_PAIS, IdPais);
            FiltroTSoporte.addOrder(new CampoOrden(HM.Comun.DeclaracionesGlobales.Cliente.Constantes.TIPOSOPORTE_DESCRIPCION, true));
            return Agente.ObtenerElementos<TipoSoporteEntidad>(new TipoSoporteEntidad(), FiltroTSoporte);
        }

        #endregion Tipo_Soporte

        #region Usuarios

        public UsuarioEntidad ValidarUsuarioMMS(string usuario, string pass)
        {
            UsuarioEntidad usr = null;
            UsuarioAgente agenteusuario = new UsuarioAgente();
            UsuarioFiltro filtroUsuario = new UsuarioFiltro();

            filtroUsuario.Criterio = Expresion.And(filtroUsuario.Criterio, Expresion.Seguridad(null));
            try
            { usr = agenteusuario.Usuario_Validar(usuario, pass); }
            catch
            {
                agenteusuario.CerrarSesion();
                agenteusuario = null;
            }
            finally
            {
                if (agenteusuario != null)
                {
                    agenteusuario.CerrarSesion();
                    agenteusuario = null;
                }
            }
            //traerAlgo(); //lo uso para prueba de los servicios D_C
            return usr;
        }

        public Usuario ObtenerUsuarioMMS(string login, string password)
        {
            Usuario usuario = new Usuario();

            UsuarioAgente agenteU = new UsuarioAgente();
            agenteU.Usuario_Validar(login, password);

            usuario = User.GetUserInformationLogged();

            return usuario;
        }

        #endregion Usuarios

        #region Compania

        public ColeccionNegocioBase<CompaniaEntidad> ObtenerCompanias()
        {
            ColeccionNegocioBase<CompaniaEntidad> lstCompania = new ColeccionNegocioBase<CompaniaEntidad>();

            CompaniaAgente agenteC = new CompaniaAgente();

            CompaniaFiltro filtroCompania = new CompaniaFiltro();
            DelegacionFiltro filtroDelegacion = new DelegacionFiltro();

            lstCompania = agenteC.ObtenerCompanias(filtroCompania, filtroDelegacion);

            return lstCompania;
        }

        #endregion Compania
    }
}
