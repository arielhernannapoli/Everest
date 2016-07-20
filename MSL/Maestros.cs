using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using HM.Comun.DeclaracionesGlobales;
using HM.Comun.ExecutionArchitecture.Security;
using HM.Comun.Persistencia.Entidad;
using HM.Comun.Utilidades;
using HM.Comun.Varios;
using HM.Contratos.Entidad.Campanas;
using HM.Contratos.Entidad.Cliente;
using HM.Contratos.Entidad.Maestros;
using HM.Contratos.Entidad.Seguridad;
using HM.Contratos.Entidad.Soportes;
using MSL.EverestDispatchingService;
using SIM;
using SIM.DataMapper;

namespace MSL
{
    /// <summary>
    /// Esta clase "MAESTRO", es utilizada para crear toda la esctructura del los DataTables, que contendran los datos de los maestros y ademas se    ///utiliza para
    ///Cargar los mismos. Con las colecciones obtenidas de los servicios web., segun el tipo de maestro que se este necesitando.
    ///Todos los metodos de esta clase "?TraerTodos", son publico y a su vez se invocan desde los metodos ubicados en el proyecto "DBL".              ///Retornando los DataTables ya cargados con los datos.
    /// </summary>
    public class Maestros
    {
        #region Propiedades

        private OrdenTvDataMapper _OrdenTvDataMapper;
        private OrdenPrensaDataMapper _OrdenPrensaDataMapper;
        private OrdenRadioDataMapper _OrdenRadioDataMapper;
        private OrdenRevistaDataMapper _OrdenRevistaDataMapper;

        #endregion Propiedades

        #region Secciones

        public DataTable seccionesObtener(int id_medio)
        {
            DatosMms oSecciones = new DatosMms();
            DataTable dtSecciones;
            ColeccionNegocioBase<EntidadLectura> lstSecciones = null;
            lstSecciones = oSecciones.ObtenerSecciones(32, id_medio);
            dtSecciones = ObtenerEstructuraDataTable(MaestrosFiltro.TipoMaestros.Secciones);
            dtSecciones = llenarTablaSecciones(lstSecciones, dtSecciones);
            return dtSecciones;
        }

        #endregion Secciones

        #region Colocaciones

        public DataTable ObtenerColocaciones(int id_medio)
        {
            DatosMms oColocaciones = new DatosMms();
            DataTable dtColocaciones;
            ColeccionNegocioBase<EntidadLectura> lstColocaciones = null;
            lstColocaciones = oColocaciones.ObtenerColocacion(id_medio);
            dtColocaciones = ObtenerEstructuraDataTable(MaestrosFiltro.TipoMaestros.Colocaciones);
            dtColocaciones = llenarTablaColocaciones(lstColocaciones, dtColocaciones);
            return dtColocaciones;
        }

        #endregion Colocaciones

        #region Formatos

        public DataTable ObtenerFormatos(int id_medio)
        {
            DatosMms oFormatos = new DatosMms();
            DataTable dtFormatos;
            ColeccionNegocioBase<EntidadLectura> lstFormatos = null;
            lstFormatos = oFormatos.ObtenerFormatos(id_medio);
            dtFormatos = ObtenerEstructuraDataTable(MaestrosFiltro.TipoMaestros.Formatos);
            dtFormatos = llenarTablaFormatos(lstFormatos, dtFormatos);
            return dtFormatos;
        }

        #endregion Formatos

        #region Poblaciones

        public DataTable poblaciones1Obtener(int id_pais)
        {
            DatosMms oPoblacion = new DatosMms();
            DataTable dtPoblacion;
            ColeccionNegocioBase<PoblacionEntidad> lstPoblaciones = null;
            //ColeccionNegocioBase<SeccionEntidad> lstSecciones = null;
            lstPoblaciones = oPoblacion.ObtenerPoblaciones(id_pais);
            dtPoblacion = LlenarTablaPoblacion1(lstPoblaciones, ObtenerEstructuraDataTable(MaestrosFiltro.TipoMaestros.Poblacion1));
            return dtPoblacion;
        }

        /// <summary>
        /// Obtenemos poblaciones_nivel3 de MMS equivale a poblaciones2 de Everest Argentina
        /// </summary>
        /// <returns></returns>
        public DataTable poblaciones2Obtener(int id_pais, int id_provincia)
        {
            DatosMms oPoblacion = new DatosMms();
            DataTable dtPoblacion;
            ColeccionNegocioBase<PoblacionEntidad> lstPoblaciones = null;
            lstPoblaciones = oPoblacion.ObtenerLocalidades(id_pais, id_provincia);
            dtPoblacion = LlenarTablaPoblacion2(lstPoblaciones, ObtenerEstructuraDataTable(MaestrosFiltro.TipoMaestros.Poblacion2));
            return dtPoblacion;
        }

        public DataTable poblaciones2ObtenerAlternativa(int id_pais, int id_provincia, int id_localidad)
        {
            DatosMms oPoblacion = new DatosMms();
            DataTable dtPoblacion;
            ColeccionNegocioBase<PoblacionEntidad> lstPoblaciones = null;
            lstPoblaciones = oPoblacion.ObtenerLocalidadesAlternativa(id_pais, id_provincia, id_localidad);
            dtPoblacion = LlenarTablaPoblacion2(lstPoblaciones, ObtenerEstructuraDataTable(MaestrosFiltro.TipoMaestros.Poblacion2));
            return dtPoblacion;
        }

        #endregion Poblaciones

        #region Medios

        /// <summary>
        /// Recupera los medios.
        /// </summary>
        /// <param name="IdPais">Id Pais</param>
        /// <returns>DataTable con los medios</returns>
        public DataTable MediosTraerTodos(int IdPais)
        {
            DataTable DtMedios;
            DatosMms OMedios = new DatosMms();
            ColeccionNegocioBase<EntidadLectura> ColeccionMedios = new ColeccionNegocioBase<EntidadLectura>();
            ColeccionMedios = OMedios.ObtenerMediosLectura(IdPais);
            DtMedios = LlenarDatosMedios(ColeccionMedios, ObtenerEstructuraDataTable(MaestrosFiltro.TipoMaestros.Medios));

            //Filtro los medios.
            for (int i = 0; i < DtMedios.Rows.Count; i++)
            {
                int idMedio = int.Parse(DtMedios.Rows[i].ItemArray[0].ToString());
                if (idMedio == 8 | idMedio == 9 | idMedio == 10 | idMedio == 11 | idMedio == 13 | idMedio == 0)
                {
                    DtMedios.Rows[i].Delete();
                }
            }

            DtMedios.AcceptChanges();

            return DtMedios;
        }

        /// <summary>
        /// Recupera las companias.
        /// </summary>
        /// <param name="IdPais">Id Pais</param>
        /// <returns>DataTable con las compañias</returns>
        public DataTable CompaniasTraerTodas(int IdPais)
        {
            DataTable DtCompanias;
            UsuarioAgente AgenteUsuario = new UsuarioAgente();
            UsuarioEntidad usuario = AgenteUsuario.ObtenerUsuarioActivo();

            DtCompanias = LlenarDatosCompania(usuario.Companias, ObtenerEstructuraDataTable(MaestrosFiltro.TipoMaestros.Compania));

            DtCompanias.AcceptChanges();

            return DtCompanias;
        }

        public String ObtenerDescripcionCompaniaActual()
        {
            UsuarioAgente AgenteUsuario = new UsuarioAgente();
            UsuarioEntidad usuario = AgenteUsuario.ObtenerUsuarioActivo();

            return usuario.Companias.Where(x => x.Codigo == usuario.CodCompania).ToList()[0].Descripcion;
        }

        public void CambiarCompania(short IdCompaniaDestino, int IdDelegacionDestino)
        {
            UsuarioAgente agente = new UsuarioAgente();
            UsuarioEntidad usuario;

            usuario = (UsuarioEntidad)agente.ObtenerUsuarioActivo();

            if (usuario != null)
            {
                Hashtable configuracionesHash = Funciones.ConvertirAHastable(usuario.ConfiguracionesUsuario);

                if (configuracionesHash != null)
                {
                    (configuracionesHash[DeclaracionesConfiguracion.COMPANIA_ACTUAL] as ConfiguracionEntidad).Valor = IdCompaniaDestino.ToString();
                    (configuracionesHash[DeclaracionesConfiguracion.COMPANIA_ACTUAL] as ConfiguracionEntidad).Operacion = TiposOperacion.Modificar;
                    (configuracionesHash[DeclaracionesConfiguracion.COMPANIA_ACTUAL] as ConfiguracionEntidad).OrigenObjeto = OrigenObjetoNegocio.ObjetoCargado;

                    usuario.CodCompania = IdCompaniaDestino;

                    usuario.ConfiguracionesUsuario = Funciones.ConvertirAColeccion(configuracionesHash);
                    agente.Usuario_ActualizarDatos(usuario);
                    agente.CargarConfiguracion(usuario);
                }
                Information.RefreshUserInformation();
            }
        }

        /// <summary>
        /// Recupera las delegaciones.
        /// </summary>
        /// <param name="IdPais">Id Pais</param>
        /// <returns>DataTable con las compañias</returns>
        public DataTable ObtenerDelegacionByCodCompania(int idCompania)
        {
            DataTable DtDelegaciones;
            CompaniaAgente AgenteCompania = new CompaniaAgente();

            ColeccionNegocioBase<CompaniaEntidad> companias = new UsuarioAgente().ObtenerUsuarioActivo().Companias;
            ColeccionNegocioBase<DelegacionEntidad> delegaciones = new ColeccionNegocioBase<DelegacionEntidad>();

            foreach (var item in companias)
            {
                if (item.Codigo == idCompania)
                {
                    delegaciones = item.Delegaciones;
                    break;
                }
            }

            DtDelegaciones = LlenarDatosDelegacion(delegaciones, ObtenerEstructuraDataTable(MaestrosFiltro.TipoMaestros.Delegacion));

            DtDelegaciones.AcceptChanges();

            return DtDelegaciones;
        }

        public DataTable MediosTraerConvenios(int IdPais)
        {
            DataTable DtMedios;
            DatosMms OMedios = new DatosMms();
            ColeccionNegocioBase<EntidadLectura> ColeccionMedios = new ColeccionNegocioBase<EntidadLectura>();
            ColeccionMedios = OMedios.ObtenerMediosLectura(IdPais);
            DtMedios = LlenarDatosMedios(ColeccionMedios, ObtenerEstructuraDataTable(MaestrosFiltro.TipoMaestros.Medios));

            //Filtro los medios.
            for (int i = 0; i < DtMedios.Rows.Count; i++)
            {
                int idMedio = int.Parse(DtMedios.Rows[i].ItemArray[0].ToString());
                if (idMedio == 8 | idMedio == 9 | idMedio == 10 | idMedio == 11 | idMedio == 13 | idMedio == 0)
                {
                    DtMedios.Rows[i].Delete();
                }
            }

            DtMedios.AcceptChanges();

            return DtMedios;
        }

        #endregion Medios

        #region Tipo_Soportes

        public DataTable TipoSoporteTraerByMedio(int IdPais, int IdMedio)
        {
            DataTable DtTipoSoporte;
            DatosMms OTSoporte = new DatosMms();
            ColeccionNegocioBase<EntidadBase> ColeccionTipoSoporte = new ColeccionNegocioBase<EntidadBase>();
            ColeccionTipoSoporte = OTSoporte.obtenerTipoSoporte(IdPais, IdMedio);//.ObtenerTipoSoporteLectura(IdPais);
            DtTipoSoporte = LlenarDatosTSoporte(ColeccionTipoSoporte, ObtenerEstructuraDataTable(MaestrosFiltro.TipoMaestros.TipoSoporte));
            return DtTipoSoporte;
        }

        public DataTable ObtenerTipoSoportes(int IdPais)
        {
            DataTable DtTipoSoporte;
            DataRow Dr;
            DatosMms OTSoporte = new DatosMms();
            ColeccionNegocioBase<TipoSoporteEntidad> ColeccionTipoSoporte = new ColeccionNegocioBase<TipoSoporteEntidad>();
            ColeccionTipoSoporte = OTSoporte.ObtenerTipoSoporte(IdPais);
            DtTipoSoporte = ObtenerEstructuraDataTable(MaestrosFiltro.TipoMaestros.TipoSoporte);
            DtTipoSoporte.Columns.Add("DESC_MEDIO", typeof(String));
            foreach (TipoSoporteEntidad TSoporte in ColeccionTipoSoporte)
            {
                Dr = DtTipoSoporte.NewRow();
                Dr["ID_MEDIO"] = TSoporte.Medio.CodMedio;
                Dr["DESCRIPCION"] = TSoporte.Descripcion.ToString();
                Dr["ID_TIPO_SOPORTE"] = TSoporte.Codigo;
                Dr["DESC_MEDIO"] = TSoporte.Medio.DesMedio.ToString();
                DtTipoSoporte.Rows.Add(Dr);
            }
            DtTipoSoporte.AcceptChanges();
            return DtTipoSoporte;
        }

        public DataTable TipoSoporteByMedioByTipoSoporte(int IdPais, int IdMedio, List<int> tipoSoportes)
        {
            DataTable DtTipoSoporte;
            DataTable DtTipoSoporteAux;
            DatosMms OTSoporte = new DatosMms();

            ColeccionNegocioBase<EntidadBase> ColeccionTipoSoporte = new ColeccionNegocioBase<EntidadBase>();
            ColeccionTipoSoporte = OTSoporte.obtenerTipoSoporte(IdPais, IdMedio);
            DtTipoSoporteAux = LlenarDatosTSoporte(ColeccionTipoSoporte, ObtenerEstructuraDataTable(MaestrosFiltro.TipoMaestros.TipoSoporte));

            DtTipoSoporte = DtTipoSoporteAux.Clone();

            foreach (int ts in tipoSoportes)
            {
                var row = DtTipoSoporteAux.Select("id_tipo_soporte = " + ts);

                if (row != null)
                    DtTipoSoporte.Rows.Add(row[0][0], row[0][1], row[0][2]);
            }

            return DtTipoSoporte;
        }

        #endregion Tipo_Soportes

        #region Soportes

        public DataTable soporteObtenerTodos(int id_pais)
        {
            DatosMms oSoportes = new DatosMms();
            DataTable dtSoportes;
            ColeccionNegocioBase<EntidadLectura> coleccionSoporte = null;
            int medios = 12;
            dtSoportes = ObtenerEstructuraDataTable(MaestrosFiltro.TipoMaestros.SoportesTodos);

            for (int i = 0; i < medios; i++)
            {
                DataTable dt;

                if (i != 10 && i != 11)
                {
                    coleccionSoporte = oSoportes.obtenerSoporteTodos(id_pais, i);
                    dt = LlenarDatosSoporteTodos(coleccionSoporte, dtSoportes, i);
                    dtSoportes = dt;
                }
            }
            return dtSoportes;
        }

        public DataTable soporteObtenerXid(int id_medio, int id_soporte)
        {
            DatosMms oSoportes = new DatosMms();
            DataTable dt;
            ColeccionNegocioBase<SoporteEntidad> coleccionSoporte = null;
            coleccionSoporte = oSoportes.obtenerSoporteXid(id_medio, id_soporte);
            dt = LlenarDatosSoporte(coleccionSoporte, ObtenerEstructuraDataTable(MaestrosFiltro.TipoMaestros.Soporte));
            return dt;
        }

        public string SoporteDescripcionObtener(int id_pais, int id_medio, int id_soporte)
        {
            DatosMms oSoporte = new DatosMms();
            string soporteDescripcion = "";
            soporteDescripcion = oSoporte.ObtenerSoporteDescripcion(id_pais, id_medio, id_soporte);
            return soporteDescripcion;
        }

        //--------------------------------------------------------------------------------------------------------
        public DataTable SoporteTraerTodos(int IdPais)
        {
            DataTable DtSoporte;
            DatosMms OSoporte = new DatosMms();
            ColeccionNegocioBase<EntidadLectura> ColeccionSoporte = new ColeccionNegocioBase<EntidadLectura>();
            ColeccionSoporte = OSoporte.ObtenerSoporteLectura(IdPais);
            DtSoporte = LlenarDatosSoporte(ColeccionSoporte, ObtenerEstructuraDataTable(MaestrosFiltro.TipoMaestros.Soporte));
            return DtSoporte;
        }

        public DataTable SoporteTraerbyMedio(int IdPais, int IdMedio)
        {
            DataTable DtSoporte;
            DatosMms OSoporte = new DatosMms();
            ColeccionNegocioBase<EntidadLectura> ColeccionSoporte = new ColeccionNegocioBase<EntidadLectura>();
            ColeccionSoporte = OSoporte.ObtenerSoporteLectura(IdPais, IdMedio);
            DtSoporte = LlenarDatosSoporte(ColeccionSoporte, ObtenerEstructuraDataTable(MaestrosFiltro.TipoMaestros.Soporte));
            return DtSoporte;
        }

        public DataTable SoporteTraerbyMedio(int IdPais, int IdMedio, int IdPlaza, int IdTipoSoporte)
        {
            DataTable DtSoporte;
            DatosMms OSoporte = new DatosMms();
            ColeccionNegocioBase<EntidadLectura> ColeccionSoporte = new ColeccionNegocioBase<EntidadLectura>();
            ColeccionNegocioBase<SoporteEntidad> ColeccionSoportes = new ColeccionNegocioBase<SoporteEntidad>();
            ColeccionSoportes = OSoporte.ObtenerSoportes(IdPais, IdMedio, IdTipoSoporte, IdPlaza);
            DtSoporte = LlenarDatosSoporte(ColeccionSoportes, ObtenerEstructuraDataTable(MaestrosFiltro.TipoMaestros.Soporte));
            return DtSoporte;
        }

        public DataTable SoportePorEditorial(int IdPais, int IdMedio, int idEditorial)
        {
            DataTable DtSoporte;
            DatosMms OSoporte = new DatosMms();
            ColeccionNegocioBase<EntidadLectura> ColeccionSoporte = new ColeccionNegocioBase<EntidadLectura>();
            ColeccionSoporte = OSoporte.ObtenerSoporteEditorial(IdPais, IdMedio, idEditorial);
            DtSoporte = LlenarDatosSoporte(ColeccionSoporte, ObtenerEstructuraDataTable(MaestrosFiltro.TipoMaestros.Soporte));
            return DtSoporte;
        }

        public DataTable SoportePorCobertura(int IdPais, int IdMedio, int IdSoporte, int Id_TipoSoporte)
        {
            DataTable DtSopCobertura;
            DatosMms OSopCobertura = new DatosMms();
            ColeccionNegocioBase<SoporteEntidad> ColeccionSoporte = new ColeccionNegocioBase<SoporteEntidad>();
            ColeccionSoporte = OSopCobertura.ObtenerSoportePorCobertura(IdPais, IdMedio, IdSoporte, Id_TipoSoporte);
            DtSopCobertura = LlenarDatosSoporte(ColeccionSoporte, ObtenerEstructuraDataTable(MaestrosFiltro.TipoMaestros.SoporteCobertua));
            return DtSopCobertura;
        }

        public DataTable ProveedorTraerTodos(int IdPais)
        {
            DataTable DtProveedor;
            DatosMms OProveedor = new DatosMms();
            ColeccionNegocioBase<ProveedorEntidad> ColeccionProveedor = new ColeccionNegocioBase<ProveedorEntidad>();
            ColeccionProveedor = OProveedor.ObtenerProveedor(IdPais);
            DtProveedor = this.LlenarDatosPorveedores(ColeccionProveedor, ObtenerEstructuraDataTable(MaestrosFiltro.TipoMaestros.ProveedorCUIT));
            return DtProveedor;
        }

        //    public DataTable soporteporId(int id_pais,int id_medio,int id_soporte)
        //    {
        //        DataTable dt;
        //        DatosMms oSoporte = new DatosMms();
        //        ColeccionNegocioBase<EntidadLectura> ColeccionSoporte = new ColeccionNegocioBase<EntidadLectura>();
        //        ColeccionSoporte = oSoporte.ObtenerSoporteLectura(id_pais, id_medio, id_soporte);
        //        dt = LlenarDatosSoporte(ColeccionSoporte, ObtenerEstructuraDataTable(MaestrosFiltro.TipoMaestros.Soporte));
        //        return dt;
        //    }

        //    //MODIFICACION JJP 23/09/08 SoporteTipoSoporte
        //    //public DataTable SoporteMedioTipo(int id_pais, int id_medio, int id_tipo_soporte)
        //    //{
        //    //    DataTable dt;
        //    //    Boolean es = new Boolean();
        //    //    DatosMms oSoporte = new DatosMms();

        //    //    ColeccionNegocioBase<SoporteEntidad> ColeccionSoporte = new ColeccionNegocioBase<SoporteEntidad>();
        //    //    ColeccionSoporte=oSoporte.

        //    //    ColeccionNegocioBase<EntidadLectura> ColeccionTSoporte = new ColeccionNegocioBase<EntidadLectura>();
        //    //    ColeccionTSoporte = oSoporte.ObtenerSoportesTipoMedio(id_pais, id_medio, id_tipo_soporte);
        //    //    dt = LlenarDatosSoporteTipoMedio(ColeccionTSoporte, ObtenerEstructuraDataTable(MaestrosFiltro.TipoMaestros.SoporteTipoMedio));

        //    //    return dt;
        //    //}
        //    //

        #endregion Soportes

        #region Productos

        /// <summary>
        /// Obtiene todos los productos por cliente
        /// </summary>
        /// <param name="IdPais"></param>
        /// <param name="IdCliente"></param>
        /// <returns></returns>
        public DataTable ProductosTraerTodos(int IdPais, int IdCliente)
        {
            DataTable DtProductos;
            DatosMms OProductos = new DatosMms();
            ColeccionNegocioBase<ProductoEntidad> ColeccionProductos = new ColeccionNegocioBase<ProductoEntidad>();
            //ColeccionNegocioBase<EntidadLectura> ColeccionProductos = new ColeccionNegocioBase<EntidadLectura>();
            //ColeccionProductos = OProductos.ObtenerProductosLectura(IdPais, IdCliente);
            ColeccionProductos = OProductos.GetProductoCompleto(IdCliente);
            DtProductos = LlenarDatosProductos(ColeccionProductos, ObtenerEstructuraDataTable(MaestrosFiltro.TipoMaestros.Productos), IdCliente);
            return DtProductos;
        }

        public string productoDescripcion(int idCliente, int idProducto)
        {
            DatosMms oProducto = new DatosMms();
            string sProductoDescripcion = "";
            sProductoDescripcion = oProducto.productoDescripcionByidProductoCliente(idCliente, idProducto);
            return sProductoDescripcion;
        }

        #endregion Productos

        #region Materiales

        public string materialDescripcionDura(int idPais, int idCliente, int idMaterial)
        {
            ColeccionNegocioBase<MaterialEntidad> coleccionMeterial = new ColeccionNegocioBase<MaterialEntidad>();
            string sDescripcionMaterial = "";
            DatosMms oMaterial = new DatosMms();
            coleccionMeterial = oMaterial.ObtenerMaterialporMaterial(idPais, idCliente, idMaterial);
            foreach (MaterialEntidad material in coleccionMeterial)
            {
                sDescripcionMaterial = material.Descripcion != "" ? material.Descripcion : "";
            }
            return sDescripcionMaterial;
        }

        public DataTable materialXidMaterial(int IdPais, int IdCliente, int IdMaterial)
        {
            DataTable DtMateriales;
            DatosMms OMateriales = new DatosMms();
            ColeccionNegocioBase<MaterialEntidad> ColeccionMateriales = new ColeccionNegocioBase<MaterialEntidad>();
            ColeccionMateriales = OMateriales.ObtenerMaterialporMaterial(IdPais, IdCliente, IdMaterial);
            DtMateriales = LlenarDatosMateriales(ColeccionMateriales, ObtenerEstructuraDataTable(MaestrosFiltro.TipoMaestros.Materiales));
            return DtMateriales;
        }

        public DataTable MaterialesTraerMedio(int IdPais, int IdCliente, int IdProducto, int id_medio)
        {
            DataTable DtMateriales;
            DatosMms OMateriales = new DatosMms();
            ColeccionNegocioBase<MaterialEntidad> ColeccionMateriales = new ColeccionNegocioBase<MaterialEntidad>();
            ColeccionMateriales = OMateriales.ObtenerMaterialesLectura(IdPais, IdCliente, IdProducto, id_medio);
            DtMateriales = LlenarDatosMateriales(ColeccionMateriales, ObtenerEstructuraDataTable(MaestrosFiltro.TipoMaestros.Materiales));
            return DtMateriales;
        }

        public DataTable MaterialesTraerTodos(int IdPais, int IdCliente, int IdProducto)
        {
            DataTable DtMateriales;
            DatosMms OMateriales = new DatosMms();
            ColeccionNegocioBase<MaterialEntidad> ColeccionMateriales = new ColeccionNegocioBase<MaterialEntidad>();
            ColeccionMateriales = OMateriales.ObtenerMaterialesLectura(IdPais, IdCliente, IdProducto);
            DtMateriales = LlenarDatosMateriales(ColeccionMateriales, ObtenerEstructuraDataTable(MaestrosFiltro.TipoMaestros.Materiales));
            return DtMateriales;
        }

        public string MaterialDescripcion(int id_pais, int id_cliente, int id_material)
        {
            string descMaterial = Constantes.SIN_DESC;
            DatosMms mMaterial = new DatosMms();
            ColeccionNegocioBase<MaterialEntidad> lstMateriales = null;
            lstMateriales = mMaterial.ObtenerMaterialporMaterial(id_pais, id_cliente, id_material);
            if (lstMateriales.Count > 0)
                descMaterial = lstMateriales[0].Descripcion;
            return descMaterial;
        }

        public DataTable TraerMaterial(int id_pais, int id_cliente, int id_material)
        {
            DataTable DtMateriales;
            DatosMms OMateriales = new DatosMms();
            ColeccionNegocioBase<MaterialEntidad> ColeccionMateriales = new ColeccionNegocioBase<MaterialEntidad>();
            ColeccionMateriales = OMateriales.ObtenerMaterialporMaterial(id_pais, id_cliente, id_material);
            DtMateriales = LlenarDatosMateriales(ColeccionMateriales, ObtenerEstructuraDataTable(MaestrosFiltro.TipoMaestros.Materiales));
            return DtMateriales;
        }

        //20101001 Obtiene los materiales filtrando solo por cliente
        public DataTable TraerMaterialesCliente(int id_pais, int id_cliente)
        {
            DataTable DtMateriales;
            DatosMms OMateriales = new DatosMms();
            ColeccionNegocioBase<MaterialEntidad> ColeccionMateriales = new ColeccionNegocioBase<MaterialEntidad>();
            ColeccionMateriales = OMateriales.ObtenerMaterialporCliente(id_pais, id_cliente);
            DtMateriales = LlenarDatosMaterialesCliente(ColeccionMateriales, ObtenerEstructuraDataTable(MaestrosFiltro.TipoMaestros.Materiales));
            return DtMateriales;
        }

        public Boolean ExisteCodigoAfsca(int id_pais, string codigo_afsca, int codigo_material)
        {
            DatosMms OMateriales = new DatosMms();
            return OMateriales.ExisteCodigoAfsca(id_pais, codigo_afsca, codigo_material);
        }

        public String AgregarCodigoAfsca(int id_pais, string codigo_afsca, int codigo_material)
        {
            DatosMms OMateriales = new DatosMms();
            return OMateriales.AgregarCodigoAfsca(id_pais, codigo_afsca, codigo_material);
        }

        public String SetNacionalExtranjeroFlag(Boolean esNacional, int codigo_material)
        {
            DatosMms OMateriales = new DatosMms();
            return OMateriales.SetNacionalExtranjeroFlag(esNacional, codigo_material);
        }

        public Boolean ExisteCodigoAfscaByMaterial(int id_pais, int codigo_material)
        {
            DatosMms OMateriales = new DatosMms();
            return OMateriales.ExisteCodigoAfscaByMaterial(id_pais, codigo_material);
        }

        public String ActualizarCodigoAfsca(int id_pais, string codigo_afsca, int codigo_material)
        {
            DatosMms OMateriales = new DatosMms();
            return OMateriales.ActualizarCodigoAfsca(id_pais, codigo_afsca, codigo_material);
        }

        #endregion Materiales

        #region Clientes

        /// <summary>
        /// obtiene un datatable con los clientes de un determinado pais
        /// </summary>
        /// <param name="IdPais">int IdPais</param>
        /// <returns></returns>
        public DataTable ClientesTraerTodos(int IdPais)
        {
            DataTable DtClientes;
            DatosMms OClientes = new DatosMms();
            ColeccionNegocioBase<EntidadLectura> ColeccionClientes = new ColeccionNegocioBase<EntidadLectura>();
            ColeccionClientes = OClientes.ObtenerClientesLectura(IdPais);
            DtClientes = LlenarDatosClientes(ColeccionClientes, ObtenerEstructuraDataTable(MaestrosFiltro.TipoMaestros.Clientes));
            return DtClientes;
        }

        /// <summary>
        /// obtiene un datatable con un cliente
        /// </summary>
        /// <param name="IdPais">int IdPais</param>
        /// <param name="IdCliente">int IdCliente</param>
        /// <returns></returns>
        public DataTable ClientesTraerporID(int IdPais, int IdCliente)
        {
            DataTable DtClientes;
            DatosMms OClientes = new DatosMms();
            ColeccionNegocioBase<EntidadLectura> ColeccionClientes = new ColeccionNegocioBase<EntidadLectura>();
            ColeccionClientes = OClientes.ObtenerClientesLecturaporID(IdPais, IdCliente);
            DtClientes = LlenarDatosClientes(ColeccionClientes, ObtenerEstructuraDataTable(MaestrosFiltro.TipoMaestros.Clientes));
            return DtClientes;
        }

        #endregion Clientes

        #region Plazas

        public DataTable PlazasTraerTodos(int IdPais)
        {
            DataTable DtPlazas = new DataTable();
            DatosMms OPlazas = new DatosMms();
            ColeccionNegocioBase<CoberturaEntidad> ColeccionPlazas = new ColeccionNegocioBase<CoberturaEntidad>();
            ColeccionPlazas = OPlazas.ObtenerPlazas(IdPais);
            DtPlazas = LlenarDatosPlazas(ColeccionPlazas, ObtenerEstructuraDataTable(MaestrosFiltro.TipoMaestros.Plazas));
            return DtPlazas;
        }

        #endregion Plazas

        #region Impuestos

        //    public DataTable ImpuestosTraerTodos(int IdPais, int IdImpuesto)
        //    {
        //        DataTable DtImpuestos;
        //        DatosMms OImpuestos = new DatosMms();
        //        ColeccionNegocioBase<EntidadLectura> ColeccionImpuestos = new ColeccionNegocioBase<EntidadLectura>();

        //        ColeccionImpuestos = OImpuestos.ObtenerImpuestos(IdPais);//,IdImpuesto);
        //        DtImpuestos = LlenarDatosImpuestos(ColeccionImpuestos, ObtenerEstructuraDataTable(MaestrosFiltro.TipoMaestros.Impuestos));
        //        return DtImpuestos;
        //    }

        #endregion Impuestos

        #region Editorial

        //    public DataTable EditorialTraerTodos(int IdPais)
        //    {
        //        DataTable dtEditorial;
        //        DatosMms oEditorial = new DatosMms();
        //        ColeccionNegocioBase<EntidadLectura> ColeccionEditorial = new ColeccionNegocioBase<EntidadLectura>();
        //        ColeccionEditorial = oEditorial.obtenerEditorial(IdPais);
        //        dtEditorial = llenarDatosEditorial(ColeccionEditorial, ObtenerEstructuraDataTable(MaestrosFiltro.TipoMaestros.Editorial));
        //        return dtEditorial;
        //    }

        //    public DataTable EditorialTraerporId(int IdPais, int IdEditorial)
        //    {
        //        DataTable dtEditorial;
        //        DatosMms oEditorial = new DatosMms();
        //        ColeccionNegocioBase<EntidadLectura> ColeccionEditorial = new ColeccionNegocioBase<EntidadLectura>();
        //        ColeccionEditorial = oEditorial.obtenerEditorialporID(IdPais, IdEditorial);
        //        dtEditorial = llenarDatosEditorial(ColeccionEditorial, ObtenerEstructuraDataTable(MaestrosFiltro.TipoMaestros.Editorial));
        //        return dtEditorial;
        //    }

        #endregion Editorial

        #region Campana

        public DataTable campanasTraerTodos(int id_pais, int id_compania, int id_cliente, int id_producto, string f_desde, string f_hasta)
        {
            DataTable dtCampanas = new DataTable();
            DatosMms oCampanas = new DatosMms();
            ColeccionNegocioBase<CampanaEntidad> coleccionCampana = null;
            coleccionCampana = oCampanas.obtenerCampanas(id_pais, id_compania, id_cliente, id_producto, f_desde, f_hasta);
            dtCampanas = LLenarTablaCampanas(coleccionCampana, ObtenerEstructuraDataTable(MaestrosFiltro.TipoMaestros.Campanas));
            return dtCampanas;
        }

        public int InsertarCampanias(int Id_Cliente, int Id_Producto, string DesCampania, int Id_Pais, int Id_Compania, DateTime F_Creacion, int Id_Usuario)
        {
            int CodCampania;
            DatosMms oCampanas = new DatosMms();
            CodCampania = oCampanas.InsertarCampania(Id_Cliente, Id_Producto, DesCampania, Id_Pais, Id_Compania, F_Creacion, Id_Usuario);
            return CodCampania;
        }

        #endregion Campana

        #region SubCampanas

        public DataTable subCampanasTraerTodos(int id_pais, int id_compania, int id_campania, int id_medio)
        {
            DataTable dtCampanas = new DataTable();
            DatosMms oSubCampanas = new DatosMms();
            ColeccionNegocioBase<SubcampanaEntidad> coleccionSubCampana = null;
            coleccionSubCampana = oSubCampanas.obtenerSubCampanas(id_pais, id_compania, id_campania, id_medio);
            dtCampanas = LLenarTablaSubcampanas(coleccionSubCampana, ObtenerEstructuraDataTable(MaestrosFiltro.TipoMaestros.Subcampanas));
            return dtCampanas;
        }

        public int? InsertarSubCampania(int Id_Cliente, int Id_medio, int Id_Campania, string DesSubCampania, int Id_Pais, int Id_Compania, DateTime F_Inicio, DateTime F_Fin, DateTime F_Creacion)
        {
            int? Cod_SubCampania;
            DatosMms oSubCampanas = new DatosMms();
            Cod_SubCampania = oSubCampanas.InsertarSubCampania(Id_Cliente, Id_medio, Id_Campania, DesSubCampania, Id_Pais, Id_Compania, F_Inicio, F_Fin, F_Creacion);
            return Cod_SubCampania;
        }

        #endregion SubCampanas

        #region Presupuesto

        public DataTable presupuestoTraerTodos(int id_pais, int id_compania, int id_campania, int id_subcampania, DateTime f_desde, DateTime f_hasta)
        {
            DataTable dtPresupuesto = new DataTable();
            DatosMms oPresupuesto = new DatosMms();
            ColeccionNegocioBase<PresupuestoEntidad> coleccionSubCampana = null;
            coleccionSubCampana = oPresupuesto.obtenerPresupuestos(id_pais, id_compania, id_campania, id_subcampania, f_desde, f_hasta);
            dtPresupuesto = LLenarTablaPresupuestos(coleccionSubCampana, ObtenerEstructuraDataTable(MaestrosFiltro.TipoMaestros.Presupuesto));
            return dtPresupuesto;
        }

        public int ObtenerTipoSoporteByPresupuesto(int id_pais, int id_compania, int id_campania, int id_subcampania, String id_presupuesto, int cod_medio)
        {
            HM.MMS.AR.Client.Agentes.AgenteGestionMaestros agenteGestionMaestros = new HM.MMS.AR.Client.Agentes.AgenteGestionMaestros();

            int codigoTipoSoporte = agenteGestionMaestros.ObtenerTipoSoporteByPresupuesto(id_pais, id_compania, id_campania, id_subcampania, id_presupuesto, cod_medio);
            return codigoTipoSoporte;
        }

        public Boolean ObtenerEstadoBloqueadoPresupuesto(int id_compania, String id_presupuesto)
        {
            HM.MMS.AR.Client.Agentes.AgenteGestionMaestros agenteGestionMaestros = new HM.MMS.AR.Client.Agentes.AgenteGestionMaestros();

            return agenteGestionMaestros.ObtenerEstadoBloqueadoPresupuesto(id_compania, id_presupuesto);
        }

        public int ObtenerTipoPresupuestoByPresupuesto(int id_pais, int id_compania, int id_campania, int id_subcampania, String id_presupuesto, int cod_medio)
        {
            HM.MMS.AR.Client.Agentes.AgenteGestionMaestros agenteGestionMaestros = new HM.MMS.AR.Client.Agentes.AgenteGestionMaestros();

            int codigoTipoSoporte = agenteGestionMaestros.ObtenerTipoPresupuestoByPresupuesto(id_pais, id_compania, id_campania, id_subcampania, id_presupuesto, cod_medio);
            return codigoTipoSoporte;
        }

        public String ObtenerOCByPresupuesto(int id_pais, int id_compania, int id_campania, int id_subcampania, String id_presupuesto, int cod_medio)
        {
            HM.MMS.AR.Client.Agentes.AgenteGestionMaestros agenteGestionMaestros = new HM.MMS.AR.Client.Agentes.AgenteGestionMaestros();

            String NumeroOC = agenteGestionMaestros.ObtenerOCByPresupuesto(id_pais, id_compania, id_campania, id_subcampania, id_presupuesto, cod_medio);
            return NumeroOC;
        }

        public String ObtenerDiasLimiteCreacionPresupuesto(int id_compania)
        {
            HM.MMS.AR.Client.Agentes.AgenteGestionMaestros agenteGestionMaestros = new HM.MMS.AR.Client.Agentes.AgenteGestionMaestros();

            String DiasLimiteCreacionPresupuesto = agenteGestionMaestros.ObtenerDiasLimiteCreacionPresupuesto(id_compania);
            return DiasLimiteCreacionPresupuesto;
        }

        public void ActualizarOCPresupuesto(int id_compania, int id_presupuesto, String NumeroOC)
        {
            DatosMms OPresupuestos = new DatosMms();
            OPresupuestos.ActualizarPresupuestoOC(id_compania, id_presupuesto, NumeroOC);
        }

        public int? InsertarPresupuestoSinIntercambio(int Id_Cliente, int Id_TPresupuesto, int Id_Campania, int Id_SubCampania, int Id_Pais, int Id_Compania, DateTime F_EmisionOrden, String NumeroOC)
        {
            int? Cod_Presupuesto;
            DatosMms OPresupuestos = new DatosMms();
            Cod_Presupuesto = OPresupuestos.InsertarPresupuestoSinIntercambio(Id_Cliente, Id_TPresupuesto, Id_Campania, Id_SubCampania, Id_Pais, Id_Compania, F_EmisionOrden, NumeroOC);
            return Cod_Presupuesto;
        }

        public int? InsertarPresupuesto(int Id_Cliente, int Id_TPresupuesto, int Id_Campania, int Id_SubCampania, int Id_Pais, int Id_Compania, DateTime F_EmisionOrden, string id_intercambio, String NumeroOC)
        {
            int? Cod_Presupuesto;
            DatosMms OPresupuestos = new DatosMms();
            Cod_Presupuesto = OPresupuestos.InsertarPresupuesto(Id_Cliente, Id_TPresupuesto, Id_Campania, Id_SubCampania, Id_Pais, Id_Compania, F_EmisionOrden, id_intercambio, NumeroOC);
            return Cod_Presupuesto;
        }

        public PresupuestoEntidad presupuestoTraer(int id_pais, int id_compania, int id_presupuesto)
        {
            DataTable dtPresupuesto = new DataTable();
            DatosMms oPresupuesto = new DatosMms();
            ColeccionNegocioBase<PresupuestoEntidad> coleccionSubCampana = new ColeccionNegocioBase<PresupuestoEntidad>();
            // Aguzzardi Descomentar ----------------------------------------------------
            PresupuestoEntidad presupuesto = oPresupuesto.obtenerPresupuesto(id_pais, id_compania, id_presupuesto);
            //-----------------------------------------------------------------------------------
            //if (presupuesto != null)
            //    coleccionSubCampana.Add(presupuesto);

            //dtPresupuesto = LLenarTablaPresupuestos(coleccionSubCampana, ObtenerEstructuraDataTable(MaestrosFiltro.TipoMaestros.Presupuesto));
            return presupuesto;
        }

        #endregion Presupuesto

        public string ObtenerMedioPagosCliente(int id_pais, int id_compania, int id_cliente, int id_medio)
        {
            DatosMms OMedioPago = new DatosMms();
            ClienteEntidad MedioPago = null;
            string PorcentajeSag = "";
            MedioPago = OMedioPago.ObtenerMedioPagosCliente(id_pais, id_compania, id_cliente, id_medio);
            if (MedioPago == null) { return PorcentajeSag = "0"; }
            ColeccionNegocioBase<ClienteEntidad> ColeccionClientes = new ColeccionNegocioBase<ClienteEntidad>();
            PorcentajeSag = MedioPago.ClienteCompanias[0].PagosMedio[0].PctSAG.ToString();
            return PorcentajeSag;
        }

        /// <summary>
        /// devuelve un datatable con los sags de clientes
        /// </summary>
        /// <param name="id_pais"></param>
        /// <param name="id_compania"></param>
        /// <param name="id_cliente"></param>
        /// <param name="id_medio"></param>
        /// <param name="f_inicio"></param>
        /// <param name="f_fin"></param>
        /// <returns></returns>
        public DataTable ObtenerMediosPagosClientes(int id_pais, int id_compania, int id_cliente, int id_medio)//, DateTime f_inicio,DateTime f_fin)
        {
            DataTable dtSag;
            DatosMms OMedioPago = new DatosMms();
            ClienteEntidad MedioPago = null;
            string PorcentajeSag = "";
            MedioPago = OMedioPago.ObtenerMedioPagosCliente(id_pais, id_compania, id_cliente, id_medio);
            //if (MedioPago == null) { return PorcentajeSag = "0"; }
            ColeccionNegocioBase<ClienteEntidad> ColeccionClientes = new ColeccionNegocioBase<ClienteEntidad>();
            PorcentajeSag = MedioPago.ClienteCompanias[0].PagosMedio[0].PctSAG.ToString();
            dtSag = new DataTable();
            return dtSag;
        }

        public DataTable ObtenerServicioAgenciaInternet(int codigoCompania, int codigoCliente, String fechaInicio, String fechaFin)
        {
            DataTable Dt = new DataTable();
            DatosMms OSerAgenciaInternet = new DatosMms();

            Dt = OSerAgenciaInternet.ObtenerServiciosAgenciaInternet(codigoCompania, codigoCliente, fechaInicio, fechaFin);
            return Dt;
        }

        public DataTable ObtenerIntercambio(int id_pais, int codcompania, int id_cliente, DateTime Fdesde, DateTime Fhasta, string codintercambio)
        {
            DataTable DtIntercambio = null;
            DatosMms OIntercambio = new DatosMms();
            ColeccionNegocioBase<IntercambioEntidad> ColIntercambio = new ColeccionNegocioBase<IntercambioEntidad>();

            ColIntercambio = OIntercambio.obtenerIntercambios(id_pais, codcompania, id_cliente, Fdesde, Fhasta, codintercambio);

            if (ColIntercambio == null)
            {
            }
            else
            {
                DtIntercambio = llenarTablaIntercambios(ColIntercambio, ObtenerEstructuraDataTable(MaestrosFiltro.TipoMaestros.Intercambio));
            }

            return DtIntercambio;
        }

        #region ArmarDataTables

        public DataTable ObtenerEstructuraDataTable(MaestrosFiltro.TipoMaestros Maestro)
        {
            DataSet DtsMaestros = new DataSet();
            DataTable DtMaestro = new DataTable();

            switch (Maestro)
            {
                case MaestrosFiltro.TipoMaestros.Secciones:
                    DtMaestro.TableName = DtMaestro + MaestrosFiltro.TipoMaestros.Secciones.ToString();
                    DtMaestro.Columns.Add("id_pais", typeof(String));
                    DtMaestro.Columns.Add("id_medio", typeof(String));
                    DtMaestro.Columns.Add("id_seccion", typeof(String));
                    DtMaestro.Columns.Add("Clave4", typeof(String));
                    DtMaestro.Columns.Add("descripcion", typeof(String));
                    DtMaestro.Columns.Add("f_baja", typeof(String));
                    DtMaestro.Columns.Add("descripcion3", typeof(String));
                    DtMaestro.Columns.Add("descripcion4", typeof(String));
                    DtMaestro.Columns.Add("descripcion5", typeof(String));
                    DtsMaestros.Tables.Add(DtMaestro);
                    break;
                case MaestrosFiltro.TipoMaestros.Poblacion2: //POBLACION_2 PARA EVEREST ES <=> POBLACION_NIVEL 3 DE MMS D_C
                    DtMaestro.TableName = "dt" + MaestrosFiltro.TipoMaestros.Poblacion1.ToString();
                    DtMaestro.Columns.Add("ID_PAIS", typeof(Int32));
                    DtMaestro.Columns.Add("Cod_Pobl2", typeof(Int32));
                    DtMaestro.Columns.Add("Nom_Pobl2", typeof(String));
                    DtMaestro.Columns.Add("IDENTIFICADOR", typeof(String));
                    DtsMaestros.Tables.Add(DtMaestro);
                    break;
                case MaestrosFiltro.TipoMaestros.Poblacion1: //POBLACION_1 PARA EVEREST ES <=> POBLACION_NIVEL2 DE MMS D_C
                    DtMaestro.TableName = "dt" + MaestrosFiltro.TipoMaestros.Poblacion1.ToString();
                    DtMaestro.Columns.Add("ID_PAIS", typeof(Int32));
                    DtMaestro.Columns.Add("Cod_Pobl1", typeof(Int32));
                    DtMaestro.Columns.Add("Nom_Pobl1", typeof(String));
                    DtMaestro.Columns.Add("IDENTIFICADOR", typeof(String));
                    DtsMaestros.Tables.Add(DtMaestro);
                    break;
                case MaestrosFiltro.TipoMaestros.Clientes:
                    DtMaestro.TableName = "Dt" + MaestrosFiltro.TipoMaestros.Clientes.ToString();
                    DtMaestro.Columns.Add("ID_PAIS", typeof(Int32));
                    DtMaestro.Columns.Add("ID_CLIENTE", typeof(Int32));
                    DtMaestro.Columns.Add("DESCRIPCION", typeof(String));
                    DtMaestro.Columns.Add("ID_GRUPO", typeof(Int32));
                    DtsMaestros.Tables.Add(DtMaestro);
                    break;
                case MaestrosFiltro.TipoMaestros.Materiales:
                    DtMaestro.TableName = "Dt" + MaestrosFiltro.TipoMaestros.Materiales.ToString();
                    DtMaestro.Columns.Add("ID_PAIS", typeof(Int32));
                    DtMaestro.Columns.Add("ID_MATERIAL", typeof(Int32));
                    DtMaestro.Columns.Add("ID_CLIENTE", typeof(String));
                    DtMaestro.Columns.Add("ID_PRODUCTO", typeof(String));
                    DtMaestro.Columns.Add("CLAVE_MATERIAL", typeof(String));
                    DtMaestro.Columns.Add("DESCRIPCION", typeof(String));
                    DtMaestro.Columns.Add("DURACION", typeof(String));
                    DtMaestro.Columns.Add("ID_MEDIO", typeof(Int32));
                    DtsMaestros.Tables.Add(DtMaestro);
                    break;
                case MaestrosFiltro.TipoMaestros.Medios:
                    DtMaestro.TableName = "Dt" + MaestrosFiltro.TipoMaestros.Medios.ToString();
                    DtMaestro.Columns.Add("ID_MEDIO", typeof(Int32));
                    DtMaestro.Columns.Add("DESCRIPCION", typeof(String));
                    DtsMaestros.Tables.Add(DtMaestro);
                    break;
                case MaestrosFiltro.TipoMaestros.Plazas:
                    DtMaestro.TableName = "Dt" + MaestrosFiltro.TipoMaestros.Plazas.ToString();
                    DtMaestro.Columns.Add("ID_PLAZA", typeof(Int32));
                    DtMaestro.Columns.Add("DESCRIPCION", typeof(String));
                    DtsMaestros.Tables.Add(DtMaestro);
                    break;
                case MaestrosFiltro.TipoMaestros.Productos:
                    DtMaestro.TableName = "Dt" + MaestrosFiltro.TipoMaestros.Productos.ToString();
                    DtMaestro.Columns.Add("ID_CLIENTE", typeof(Int32));
                    DtMaestro.Columns.Add("ID_PRODUCTO", typeof(Int32));
                    DtMaestro.Columns.Add("DESCRIPCION", typeof(String));
                    DtMaestro.Columns.Add("DESCRIPCION2", typeof(String));
                    DtMaestro.Columns.Add("FECHAFIN", typeof(DateTime));
                    DtsMaestros.Tables.Add(DtMaestro);
                    break;
                case MaestrosFiltro.TipoMaestros.Soporte:
                    DtMaestro.TableName = "Dt" + MaestrosFiltro.TipoMaestros.Soporte.ToString();
                    DtMaestro.Columns.Add("ID_PAIS", typeof(Int32));
                    DtMaestro.Columns.Add("ID_MEDIO", typeof(Int32));
                    DtMaestro.Columns.Add("ID_SOPORTE", typeof(Int32));
                    DtMaestro.Columns.Add("DESCRIPCION", typeof(String));
                    DtMaestro.Columns.Add("ID_MONEDA", typeof(String));
                    DtMaestro.Columns.Add("ID_IDIOMA", typeof(String));
                    DtMaestro.Columns.Add("ID_PLAZA", typeof(String));
                    DtMaestro.Columns.Add("ID_TIPO_SOPORTE", typeof(String));
                    DtMaestro.Columns.Add("ID_CADENA", typeof(String));
                    DtsMaestros.Tables.Add(DtMaestro);
                    break;
                case MaestrosFiltro.TipoMaestros.TipoSoporte:
                    DtMaestro.TableName = "Dt" + MaestrosFiltro.TipoMaestros.TipoSoporte.ToString();
                    DtMaestro.Columns.Add("ID_MEDIO", typeof(Int32));
                    DtMaestro.Columns.Add("ID_TIPO_SOPORTE", typeof(Int32));
                    DtMaestro.Columns.Add("DESCRIPCION", typeof(String));
                    DtsMaestros.Tables.Add(DtMaestro);
                    break;
                case MaestrosFiltro.TipoMaestros.Impuestos:
                    DtMaestro.TableName = "Dt" + MaestrosFiltro.TipoMaestros.Impuestos.ToString();
                    DtMaestro.Columns.Add("ID_PAIS", typeof(Int32));
                    DtMaestro.Columns.Add("ID_IMPUESTO", typeof(Int32));
                    DtMaestro.Columns.Add("DESCRIPCION", typeof(String));
                    DtsMaestros.Tables.Add(DtMaestro);
                    break;
                case MaestrosFiltro.TipoMaestros.Editorial:
                    DtMaestro.TableName = "Dt" + MaestrosFiltro.TipoMaestros.Editorial.ToString();
                    DtMaestro.Columns.Add("ID_EDITORIAL", typeof(Int32));
                    DtMaestro.Columns.Add("DESCRIPCION", typeof(string));
                    DtsMaestros.Tables.Add(DtMaestro);
                    break;
                case MaestrosFiltro.TipoMaestros.SoporteTipoMedio:
                    DtMaestro.Columns.Add("ID_MEDIO", typeof(Int32));
                    DtMaestro.Columns.Add("ID_TIPO_SOPORTE", typeof(Int32));
                    DtMaestro.Columns.Add("ID_SOPORTE", typeof(Int32));
                    DtMaestro.Columns.Add("DESCRIPCION", typeof(String));
                    DtsMaestros.Tables.Add(DtMaestro);
                    break;
                case MaestrosFiltro.TipoMaestros.Campanas:
                    DtMaestro.Columns.Add("ID_CAMPANA", typeof(Int32));
                    DtMaestro.Columns.Add("DESCRIPCION", typeof(String));
                    DtMaestro.Columns.Add("FCREACION", typeof(String));
                    DtsMaestros.Tables.Add(DtMaestro);
                    break;
                case MaestrosFiltro.TipoMaestros.Subcampanas:
                    DtMaestro.Columns.Add("ID_SUBCAMPANA", typeof(Int32));
                    DtMaestro.Columns.Add("DESCRIPCION", typeof(String));
                    DtMaestro.Columns.Add("ID_CAMPANA", typeof(Int32));
                    DtMaestro.Columns.Add("FINICIO", typeof(String));
                    DtsMaestros.Tables.Add(DtMaestro);
                    break;
                case MaestrosFiltro.TipoMaestros.Presupuesto:
                    DtMaestro.Columns.Add("MES", typeof(String));
                    DtMaestro.Columns.Add("ANO", typeof(String));
                    DtMaestro.Columns.Add("ID_PRESUPUESTO", typeof(Int32));
                    DtMaestro.Columns.Add("ID_INTERCAMBIO", typeof(String));
                    DtMaestro.Columns.Add("ID_CAMPANA", typeof(Int32));
                    DtMaestro.Columns.Add("ID_SUBCAMPANA", typeof(Int32));
                    DtsMaestros.Tables.Add(DtMaestro);
                    break;
                case MaestrosFiltro.TipoMaestros.SoportesTodos:
                    DtMaestro.Columns.Add("ID_MEDIO", typeof(Int32));
                    DtMaestro.Columns.Add("ID_SOPORTE", typeof(Int32));
                    DtMaestro.Columns.Add("DESCRIPCION", typeof(String));
                    DtsMaestros.Tables.Add(DtMaestro);
                    break;
                case MaestrosFiltro.TipoMaestros.Proveedor:
                    DtMaestro.Columns.Add("ID_PROVEEDOR", typeof(Int32));
                    DtMaestro.Columns.Add("ID_EMPRESA", typeof(Int32));
                    DtMaestro.Columns.Add("DESCRIPCION", typeof(String));
                    DtsMaestros.Tables.Add(DtMaestro);
                    break;
                case MaestrosFiltro.TipoMaestros.SoporteCobertua:
                    DtMaestro.Columns.Add("ID_COBERTURA", typeof(Int32));
                    DtMaestro.Columns.Add("ID_MEDIO", typeof(Int32));
                    DtMaestro.Columns.Add("ID_SOPORTE", typeof(Int32));
                    DtsMaestros.Tables.Add(DtMaestro);
                    break;
                case MaestrosFiltro.TipoMaestros.PagoMedio:
                    DtMaestro.Columns.Add("ID_CLIENTE", typeof(Int32));
                    DtMaestro.Columns.Add("ID_MEDIO", typeof(Int32));
                    DtMaestro.Columns.Add("PORCENTAJE_SAG", typeof(Int32));
                    DtsMaestros.Tables.Add(DtMaestro);
                    break;
                case MaestrosFiltro.TipoMaestros.Intercambio:
                    DtMaestro.Columns.Add("COD_COMPANIA", typeof(Int32));
                    DtMaestro.Columns.Add("COD_INTERCAMBIO", typeof(Int32));
                    DtMaestro.Columns.Add("DES_INTERCAMBIO", typeof(String));
                    DtMaestro.Columns.Add("COD_CLIENTE", typeof(Int32));
                    DtMaestro.Columns.Add("PORCENTAJE_SAG", typeof(Int32));
                    DtMaestro.Columns.Add("FECHAINICIO", typeof(DateTime));
                    DtMaestro.Columns.Add("FECHAFIN", typeof(DateTime));
                    DtMaestro.Columns.Add("IMPINTERCAMBIO", typeof(Decimal));
                    DtsMaestros.Tables.Add(DtMaestro);
                    break;
                case MaestrosFiltro.TipoMaestros.Compania:
                    DtMaestro.Columns.Add("COD_COMPANIA", typeof(Int32));
                    DtMaestro.Columns.Add("DESCRIPCION", typeof(String));
                    DtsMaestros.Tables.Add(DtMaestro);
                    break;
                case MaestrosFiltro.TipoMaestros.Delegacion:
                    DtMaestro.Columns.Add("COD_DELEGACION", typeof(Int32));
                    DtMaestro.Columns.Add("DESCRIPCION", typeof(String));
                    DtsMaestros.Tables.Add(DtMaestro);
                    break;
                case MaestrosFiltro.TipoMaestros.Colocaciones:
                    DtMaestro.Columns.Add("ID_MEDIO", typeof(Int32));
                    DtMaestro.Columns.Add("ID_COLOCACION", typeof(Int32));
                    DtMaestro.Columns.Add("DESCRIPCION", typeof(String));
                    DtsMaestros.Tables.Add(DtMaestro);
                    break;
                case MaestrosFiltro.TipoMaestros.Formatos:
                    DtMaestro.Columns.Add("ID_MEDIO", typeof(Int32));
                    DtMaestro.Columns.Add("ID_ANUNCIO", typeof(String));
                    DtMaestro.Columns.Add("DESCRIPCION", typeof(String));
                    DtsMaestros.Tables.Add(DtMaestro);
                    break;
                case MaestrosFiltro.TipoMaestros.ProveedorCUIT:
                    DtMaestro.Columns.Add("ID_PROVEEDOR", typeof(Int32));
                    DtMaestro.Columns.Add("ID_EMPRESA", typeof(Int32));
                    DtMaestro.Columns.Add("DESCRIPCION", typeof(String));
                    DtMaestro.Columns.Add("CUIT", typeof(String));
                    DtsMaestros.Tables.Add(DtMaestro);
                    break;
            }

            return DtsMaestros.Tables[0];
        }

        #endregion ArmarDataTables

        #region Funciones_Llenar_DataTables

        #region MyRegion

        public DataTable LlenarTablaPoblacion2(ColeccionNegocioBase<PoblacionEntidad> Coleccion, DataTable dtMaestro)
        {
            DataRow drRow;
            dtMaestro.Rows.Clear();
            foreach (PoblacionEntidad var in Coleccion)
            {
                //POBLACION_2 PARA EVEREST ES <=> POBLACION_NIVEL 3 DE MMS D_C
                drRow = dtMaestro.NewRow();
                drRow["Cod_Pobl2"] = var.Codigo;//
                drRow["Nom_Pobl2"] = var.Nombre;//DESCRIPCION
                drRow["ID_PAIS"] = var.Pais.CodPais;
                drRow["IDENTIFICADOR"] = var.Identificador;
                dtMaestro.Rows.Add(drRow);
            } // foreach
            dtMaestro.AcceptChanges();
            return dtMaestro;
        }

        public DataTable LlenarTablaPoblacion1(ColeccionNegocioBase<PoblacionEntidad> Coleccion, DataTable dtMaestro)
        {
            //POBLACION_1 PARA EVEREST ES <=> POBLACION_NIVEL 2 DE MMS D_C
            DataRow drRow;
            dtMaestro.Rows.Clear();
            foreach (PoblacionEntidad var in Coleccion)
            {
                drRow = dtMaestro.NewRow();
                drRow["Cod_Pobl1"] = var.Codigo;//
                drRow["Nom_Pobl1"] = var.Nombre;//DESCRIPCION
                drRow["ID_PAIS"] = var.Pais.CodPais;
                drRow["IDENTIFICADOR"] = var.Identificador;
                dtMaestro.Rows.Add(drRow);
            } // foreach
            dtMaestro.AcceptChanges();
            return dtMaestro;
        }

        #endregion MyRegion

        #region LlenarColocaciones

        public DataTable llenarTablaColocaciones(ColeccionNegocioBase<EntidadLectura> coleccion, DataTable dtMaestro)
        {
            DataRow dr;
            dtMaestro.Rows.Clear();
            foreach (EntidadLectura colocaciones in coleccion)
            {
                dr = dtMaestro.NewRow();
                dr["ID_MEDIO"] = colocaciones.Clave2;
                dr["ID_COLOCACION"] = colocaciones.Clave3;
                dr["DESCRIPCION"] = colocaciones.Descripcion1;
                dtMaestro.Rows.Add(dr);
            }
            return dtMaestro;
        }

        #endregion LlenarColocaciones

        #region LlenarFormatos

        public DataTable llenarTablaFormatos(ColeccionNegocioBase<EntidadLectura> coleccion, DataTable dtMaestro)
        {
            DataRow dr;
            dtMaestro.Rows.Clear();
            foreach (EntidadLectura colocaciones in coleccion)
            {
                dr = dtMaestro.NewRow();
                dr["ID_MEDIO"] = colocaciones.Clave1;
                dr["ID_ANUNCIO"] = colocaciones.Clave2;
                dr["DESCRIPCION"] = colocaciones.Descripcion1;
                dtMaestro.Rows.Add(dr);
            }
            return dtMaestro;
        }

        #endregion LlenarFormatos

        #region LlenarIntercambios

        public DataTable llenarTablaIntercambios(ColeccionNegocioBase<IntercambioEntidad> coleccion, DataTable DtMaestro)
        {
            DataRow dr;
            DtMaestro.Rows.Clear();

            foreach (IntercambioEntidad intercambio in coleccion)
            {
                dr = DtMaestro.NewRow();
                dr["COD_COMPANIA"] = Int32.Parse(intercambio.Compania.Codigo.ToString());
                dr["COD_INTERCAMBIO"] = Int32.Parse(intercambio.Codigo.ToString());
                if (intercambio.Descripcion == null)
                { dr["DES_INTERCAMBIO"] = ""; }
                else { dr["DES_INTERCAMBIO"] = intercambio.Descripcion.ToString(); }
                dr["COD_CLIENTE"] = Int32.Parse(intercambio.Cliente.CodigoCliente.ToString());
                if (intercambio.PorcentFactura == null)
                { dr["PORCENTAJE_SAG"] = 0; }
                else { dr["PORCENTAJE_SAG"] = intercambio.PorcentFactura; }
                if (intercambio.Importe == null)
                { dr["IMPINTERCAMBIO"] = 0; }
                else { dr["IMPINTERCAMBIO"] = intercambio.Importe; }
                dr["FECHAINICIO"] = DateTime.Parse(intercambio.FechaInicio.ToString());
                dr["FECHAFIN"] = DateTime.Parse(intercambio.FechaFin.ToString());
                DtMaestro.Rows.Add(dr);
            }
            return DtMaestro;
        }

        public DataTable InsertarIntercambio(int codpais, int codcompania, int codcliente, string descripcion, decimal importe, DateTime Fdesde, DateTime FFin)
        {
            DataTable Intercambio = null;
            int CodIntercambio;
            DatosMms oIntercambio = new DatosMms();
            CodIntercambio = oIntercambio.InsertarIntercambio(codpais, codcompania, codcliente, descripcion, importe, Fdesde, FFin);
            return Intercambio;
        }

        #endregion LlenarIntercambios

        #region LlenarSecciones

        public DataTable llenarTablaSecciones(ColeccionNegocioBase<EntidadLectura> coleccion, DataTable dtMaestro)
        {
            DataRow dr;
            dtMaestro.Rows.Clear();
            foreach (EntidadLectura seccion in coleccion)
            {
                dr = dtMaestro.NewRow();
                dr["id_pais"] = seccion.Clave1;
                dr["id_medio"] = seccion.Clave2;
                dr["id_seccion"] = seccion.Clave3;
                dr["Clave4"] = seccion.Clave4;
                dr["descripcion"] = seccion.Descripcion1;
                dr["f_baja"] = seccion.Descripcion2;
                dr["descripcion3"] = seccion.Descripcion3;
                dr["descripcion4"] = seccion.Descripcion4;
                dr["descripcion5"] = seccion.Descripcion5;
                dtMaestro.Rows.Add(dr);
            }
            return dtMaestro;
        }

        #endregion LlenarSecciones

        #region Funciones_Campanas

        public DataTable LLenarTablaCampanas(ColeccionNegocioBase<CampanaEntidad> Coleccion, DataTable dtMaestro)
        {
            DataRow drRow;
            dtMaestro.Rows.Clear();
            foreach (CampanaEntidad campana in Coleccion)
            {
                drRow = dtMaestro.NewRow();
                drRow["ID_CAMPANA"] = campana.Codigo;
                drRow["DESCRIPCION"] = campana.Descripcion != "" ? campana.Descripcion : Constantes.SIN_DESC;
                drRow["FCREACION"] = campana.FechaCreacion.ToShortDateString();
                dtMaestro.Rows.Add(drRow);
            }
            dtMaestro.AcceptChanges();
            return dtMaestro;
        }

        #endregion Funciones_Campanas

        #region Funciones_SubCampanas

        public DataTable LLenarTablaSubcampanas(ColeccionNegocioBase<SubcampanaEntidad> Coleccion, DataTable dtMaestro)
        {
            DataRow drRow;
            dtMaestro.Rows.Clear();
            foreach (SubcampanaEntidad subcampana in Coleccion)
            {
                drRow = dtMaestro.NewRow();
                drRow["ID_SUBCAMPANA"] = subcampana.Codigo;
                drRow["DESCRIPCION"] = subcampana.Descripcion != "" ? subcampana.Descripcion : Constantes.SIN_DESC;
                drRow["ID_CAMPANA"] = subcampana.Campana.Codigo;
                drRow["FINICIO"] = subcampana.FechaInicio.ToString();
                dtMaestro.Rows.Add(drRow);
            }
            dtMaestro.AcceptChanges();
            return dtMaestro;
        }

        #endregion Funciones_SubCampanas

        #region Funciones_Presupuestos

        public DataTable LLenarTablaPresupuestos(ColeccionNegocioBase<PresupuestoEntidad> Coleccion, DataTable dtMaestro)
        {
            DataRow drRow;
            dtMaestro.Rows.Clear();
            foreach (PresupuestoEntidad Presupueto in Coleccion)
            {
                if (Presupueto.Tipo.Codigo != 3) //Quito los presupuestos del tipo Pago anticipado
                {
                    drRow = dtMaestro.NewRow();
                    drRow["ID_SUBCAMPANA"] = Presupueto.Subcampana.Codigo;
                    drRow["ID_CAMPANA"] = Presupueto.Subcampana.Campana.Codigo;
                    drRow["ID_PRESUPUESTO"] = Presupueto.Codigo;
                    if (Presupueto.Intercambio == null)
                    { drRow["ID_INTERCAMBIO"] = ""; }
                    else { drRow["ID_INTERCAMBIO"] = Presupueto.Intercambio.Codigo; }
                    drRow["MES"] = Presupueto.FechaEmisionString.Substring(3, 2);
                    drRow["ANO"] = Presupueto.FechaEmisionString.Substring(6, 4);
                    dtMaestro.Rows.Add(drRow);
                }
            }
            dtMaestro.AcceptChanges();
            return dtMaestro;
        }

        #endregion Funciones_Presupuestos

        #region Funciones_Medios

        public DataTable LlenarTablaMedios(ColeccionNegocioBase<EntidadLectura> Coleccion, DataTable dtMaestro)
        {
            DataRow drRow;
            dtMaestro.Rows.Clear();
            foreach (EntidadLectura Medios in Coleccion)
            {
                drRow = dtMaestro.NewRow();
                drRow["ID_MEDIO"] = Medios.Clave1;
                drRow["DESCRIPCION"] = Medios.Descripcion1 != null ? Medios.Descripcion1 : Constantes.SIN_DESC;
                dtMaestro.Rows.Add(drRow);
            }
            dtMaestro.AcceptChanges();
            return dtMaestro;
        }

        private DataTable LlenarDatosMedios(ColeccionNegocioBase<EntidadLectura> Coleccion, DataTable DtMaestro)
        {
            DataRow DrRow;
            DtMaestro.Rows.Clear();
            foreach (EntidadLectura Medios in Coleccion)
            {
                if (Medios.Clave1 != ((int)MaestrosFiltro.MFMedios.Cine).ToString())
                {
                    DrRow = DtMaestro.NewRow();
                    if (Medios.Clave1 == null) { DrRow["ID_MEDIO"] = DBNull.Value; } else { DrRow["ID_MEDIO"] = Medios.Clave1; }
                    DrRow["DESCRIPCION"] = Medios.Descripcion1 != null ? Medios.Descripcion1.ToString().ToUpper() : "";
                    DtMaestro.Rows.Add(DrRow);
                }
            }
            DtMaestro.AcceptChanges();
            DtMaestro.DefaultView.Sort = "descripcion";
            return DtMaestro;
        }

        private DataTable LlenarDatosCompania(ColeccionNegocioBase<CompaniaEntidad> Coleccion, DataTable DtMaestro)
        {
            DataRow DrRow;
            DtMaestro.Rows.Clear();
            foreach (CompaniaEntidad Compania in Coleccion)
            {
                DrRow = DtMaestro.NewRow();
                if (Compania.Codigo == null) { DrRow["COD_COMPANIA"] = DBNull.Value; } else { DrRow["COD_COMPANIA"] = Compania.Codigo; }
                DrRow["DESCRIPCION"] = Compania.Descripcion != null ? Compania.Descripcion.ToString().ToUpper() : "";
                DtMaestro.Rows.Add(DrRow);
            }
            DtMaestro.AcceptChanges();
            DtMaestro.DefaultView.Sort = "DESCRIPCION";
            return DtMaestro;
        }

        private DataTable LlenarDatosDelegacion(ColeccionNegocioBase<DelegacionEntidad> Coleccion, DataTable DtMaestro)
        {
            DataRow DrRow;
            DtMaestro.Rows.Clear();
            foreach (DelegacionEntidad delegacion in Coleccion)
            {
                DrRow = DtMaestro.NewRow();
                if (delegacion.CodDelegacion == null) { DrRow["COD_DELEGACION"] = DBNull.Value; } else { DrRow["COD_DELEGACION"] = delegacion.CodDelegacion; }
                DrRow["DESCRIPCION"] = delegacion.DesDelegacion != null ? delegacion.DesDelegacion.ToString().ToUpper() : "";
                DtMaestro.Rows.Add(DrRow);
            }
            DtMaestro.AcceptChanges();
            DtMaestro.DefaultView.Sort = "DESCRIPCION";
            return DtMaestro;
        }

        #endregion Funciones_Medios

        #region Funciones_Soportes

        private DataTable LlenarDatosSoporteTodos(ColeccionNegocioBase<EntidadLectura> coleccion, DataTable DtMaestro, int id_medio)
        {
            DataRow DrRow;
            foreach (EntidadLectura Soporte in coleccion)
            {
                DrRow = DtMaestro.NewRow();
                DrRow["ID_MEDIO"] = id_medio;
                DrRow["ID_SOPORTE"] = int.Parse(Soporte.Clave3);
                DrRow["DESCRIPCION"] = Soporte.Descripcion1.ToString();
                DtMaestro.Rows.Add(DrRow);
            }
            DtMaestro.DefaultView.Sort = "DESCRIPCION";
            DtMaestro.AcceptChanges();
            return DtMaestro;
        }

        private DataTable LlenarDatosTSoporte(ColeccionNegocioBase<EntidadBase> coleccion, DataTable DtMaestro)
        {
            DataRow DrRow;
            DtMaestro.Rows.Clear();
            foreach (EntidadBase soporte in coleccion)
            {
                DrRow = DtMaestro.NewRow();
                DrRow["descripcion"] = soporte.ToString() != "" ? soporte.ToString() : "";
                DrRow["id_tipo_soporte"] = soporte.Identificador.ToString().Split('#')[2] != null ? soporte.Identificador.ToString().Split('#')[2] : null;
                DrRow["id_medio"] = soporte.Identificador.ToString().Split('#')[1] != null ? soporte.Identificador.ToString().Split('#')[1] : null;
                DtMaestro.Rows.Add(DrRow);
            }
            DtMaestro.AcceptChanges();
            return DtMaestro;
        }

        private DataTable LlenarDatosSoporte(ColeccionNegocioBase<SoporteEntidad> coleccion, DataTable DtMaestro)
        {
            DataRow DrRow;
            DtMaestro.Rows.Clear();
            foreach (SoporteEntidad soporte in coleccion)
            {
                DrRow = DtMaestro.NewRow();
                DrRow["id_pais"] = soporte.Identificador != null ? int.Parse(soporte.Identificador.ToString().Split('#')[0]) : 0;
                DrRow["id_soporte"] = soporte.Codigo;
                DrRow["id_medio"] = soporte.Medio.CodMedio != null ? soporte.Medio.CodMedio : null;
                DrRow["descripcion"] = soporte.Descripcion != null ? soporte.Descripcion : "Sin Descripción";
                DrRow["id_moneda"] = soporte.Moneda.Codigo;
                DrRow["id_idioma"] = soporte.Idioma.Codigo;
                DrRow["id_plaza"] = soporte.Coberturas != null ? soporte.Coberturas[0].Codigo : null;
                if (soporte.TiposSoporte != null) { DrRow["id_tipo_soporte"] = soporte.TiposSoporte.Count > 0 ? soporte.TiposSoporte[0].Codigo : null; }
                DrRow["id_cadena"] = soporte.Editorial != null ? soporte.Editorial.Codigo : null;
                DtMaestro.Rows.Add(DrRow);
            }
            DtMaestro.DefaultView.Sort = "descripcion";
            DtMaestro.AcceptChanges();
            return DtMaestro;
        }

        private DataTable LlenarDatosSoporte(ColeccionNegocioBase<EntidadLectura> coleccion, DataTable DtMaestro)
        {
            DataRow DrRow;
            DtMaestro.Rows.Clear();
            foreach (EntidadLectura Soporte in coleccion)
            {
                DrRow = DtMaestro.NewRow();
                DrRow["id_soporte"] = Soporte.Clave3 != null ? Soporte.Clave3 : null;
                DrRow["id_medio"] = Soporte.Clave2 != null ? Soporte.Clave2 : null;
                DrRow["descripcion"] = Soporte.Descripcion1 != null ? Soporte.Descripcion1.ToString().ToUpper() : "";
                DrRow["id_moneda"] = Soporte.Descripcion2 != null ? Soporte.Descripcion2.ToString() : "";
                DrRow["id_idioma"] = Soporte.Descripcion3 != null ? Soporte.Descripcion3.ToString() : "";
                DtMaestro.Rows.Add(DrRow);
            }
            DtMaestro.AcceptChanges();
            return DtMaestro;
        }

        private DataTable LlenarDatosSoporteTipoMedio(ColeccionNegocioBase<EntidadLectura> Coleccion, DataTable DtMaestro)
        {
            DataRow DrRow;
            DtMaestro.Rows.Clear();
            foreach (EntidadLectura Soporte in Coleccion)
            {
                DrRow = DtMaestro.NewRow();
                if (Soporte.Clave2 == null) { DrRow["ID_MEDIO"] = DBNull.Value; } else { DrRow["ID_MEDIO"] = Soporte.Clave2; }
                DrRow["ID_TIPO_SOPORTE"] = DBNull.Value;
                if (Soporte.Clave3 == null) { DrRow["ID_SOPORTE"] = DBNull.Value; } else { DrRow["ID_SOPORTE"] = Soporte.Clave3; }
                DrRow["DESCRIPCION"] = Soporte.Descripcion1 != null ? Soporte.Descripcion1.ToString().ToUpper() : "";
                DtMaestro.Rows.Add(DrRow);
            }
            DtMaestro.AcceptChanges();
            return DtMaestro;
        }

        private DataTable LlenarDatosSoportePorCobertura(ColeccionNegocioBase<SoporteEntidad> Coleccion, DataTable DtMaestro)
        {
            DataRow DrRow;
            foreach (SoporteEntidad SopCobertura in Coleccion)
            {
                DrRow = DtMaestro.NewRow();
                DrRow["ID_COBERTURA"] = SopCobertura.Coberturas;
                DrRow["ID_MEDIO"] = SopCobertura.Medio.CodMedio;
                DrRow["ID_SOPORTE"] = SopCobertura.Codigo;
                DtMaestro.Rows.Add(DrRow);
            }
            DtMaestro.AcceptChanges();
            return DtMaestro;
        }

        #endregion Funciones_Soportes

        #region Funciones_Materiales

        private DataTable LlenarDatosMateriales(ColeccionNegocioBase<MaterialEntidad> Coleccion, DataTable DtMaestro)
        {
            DataRow DrRow;
            DtMaestro.Rows.Clear();
            foreach (MaterialEntidad Materiales in Coleccion)
            {
                DrRow = DtMaestro.NewRow();
                DrRow["DESCRIPCION"] = Materiales.Descripcion != null ? Materiales.Descripcion : "";
                DrRow["ID_MATERIAL"] = Materiales.Codigo != null ? Materiales.Codigo : 0;
                DrRow["ID_PRODUCTO"] = Materiales.Producto.CodigoProducto != null ? Materiales.Producto.CodigoProducto : 0;
                DrRow["DURACION"] = Materiales.Tamano != null ? Materiales.Tamano.ToString() : "";
                DrRow["CLAVE_MATERIAL"] = Materiales.Clave != null ? Materiales.Clave.ToString() : "";
                DrRow["ID_MEDIO"] = Materiales.Medio.CodMedio != null ? Materiales.Medio.CodMedio : null;
                DtMaestro.Rows.Add(DrRow);
            }
            DtMaestro.AcceptChanges();
            return DtMaestro;
        }

        //20101001 Llena los datos de materiales
        private DataTable LlenarDatosMaterialesCliente(ColeccionNegocioBase<MaterialEntidad> Coleccion, DataTable DtMaestro)
        {
            DataRow DrRow;
            string[] identificador;
            DtMaestro.Rows.Clear();
            foreach (MaterialEntidad Materiales in Coleccion)
            {
                DrRow = DtMaestro.NewRow();
                DrRow["DESCRIPCION"] = Materiales.Descripcion != null ? Materiales.Descripcion : "";
                DrRow["ID_MATERIAL"] = Materiales.Codigo != null ? Materiales.Codigo : 0;
                DrRow["ID_PRODUCTO"] = Materiales.Producto.CodigoProducto != null ? Materiales.Producto.CodigoProducto : 0;
                DrRow["DURACION"] = Materiales.Tamano != null ? Materiales.Tamano.ToString() : "";
                DrRow["CLAVE_MATERIAL"] = Materiales.Clave != null ? Materiales.Clave.ToString() : "";
                DrRow["ID_MEDIO"] = Materiales.Medio.CodMedio != null ? Materiales.Medio.CodMedio : null;
                identificador = Materiales.Producto.Identificador.Split('#');
                DrRow["ID_CLIENTE"] = identificador.Length == 3 ? int.Parse(identificador[2].ToString()) : 0;
                DtMaestro.Rows.Add(DrRow);
            }
            DtMaestro.AcceptChanges();
            return DtMaestro;
        }

        public string InsertarMateriales(int Id_Pais, int Id_Cliente, int Id_Medio, int Id_Producto, string Id_Material, int Duracion, string DescripcionMaterial)
        {
            string Cod_Material;
            DatosMms OMaterial = new DatosMms();
            Cod_Material = OMaterial.InsertarMateriales(Id_Pais, Id_Cliente, Id_Medio, Id_Producto, Id_Material, Duracion, DescripcionMaterial);
            return Cod_Material;
        }

        public string ActualizarMaterial(int Id_Pais, int Id_Cliente, int Id_Medio, int Id_Producto, string Id_Material, int Duracion, string DescripcionMaterial)
        {
            string Cod_Material;
            DatosMms OMaterial = new DatosMms();
            Cod_Material = OMaterial.ActualizarMateriales(Id_Pais, Id_Cliente, Id_Medio, Id_Producto, Id_Material, Duracion, DescripcionMaterial);
            return Cod_Material;
        }

        #endregion Funciones_Materiales

        #region Funciones_Plazas

        private DataTable LlenarDatosPlazas(ColeccionNegocioBase<CoberturaEntidad> Coleccion, DataTable DtMaestro)
        {
            DataRow DrRow;
            DtMaestro.Rows.Clear();
            foreach (CoberturaEntidad Plaza in Coleccion)
            {
                DrRow = DtMaestro.NewRow();
                DrRow["ID_PLAZA"] = Plaza.Codigo != null ? Plaza.Codigo : 0;
                DrRow["DESCRIPCION"] = Plaza.Descripcion != null ? Plaza.Descripcion : "";
                DtMaestro.Rows.Add(DrRow);
            }
            DtMaestro.AcceptChanges();
            return DtMaestro;
        }

        #endregion Funciones_Plazas

        #region Funciones_Productos

        private DataTable LlenarDatosProductos(ColeccionNegocioBase<ProductoEntidad> Coleccion, DataTable DtMaestro, int IdCliente)
        {
            DataRow DrRow;
            DtMaestro.Rows.Clear();
            foreach (ProductoEntidad Producto in Coleccion)
            {
                DrRow = DtMaestro.NewRow();
                if (Producto.CodigoProducto == null) { DrRow["ID_PRODUCTO"] = DBNull.Value; } else { DrRow["ID_PRODUCTO"] = Producto.CodigoProducto; }
                if (Producto.FechaFin == null) { DrRow["FECHAFIN"] = DBNull.Value; } else { DrRow["FECHAFIN"] = Producto.FechaFin; }
                DrRow["ID_CLIENTE"] = IdCliente;
                DrRow["DESCRIPCION"] = Producto.Descripcion != null ? Producto.Descripcion.ToString().ToUpper() : "";
                DrRow["DESCRIPCION2"] = String.Concat(DrRow["DESCRIPCION"], " (", DrRow["ID_PRODUCTO"], ")");
                if (Producto.FechaFin != null)
                {
                    DrRow["DESCRIPCION2"] += " --BAJA"; 
                }
                DtMaestro.Rows.Add(DrRow);
            }
            DtMaestro.AcceptChanges();
            return DtMaestro;
        }

        private DataTable LlenarDatosProductos(ColeccionNegocioBase<EntidadLectura> Coleccion, DataTable DtMaestro)
        {
            DataRow DrRow;
            DtMaestro.Rows.Clear();
            foreach (EntidadLectura Productos in Coleccion)
            {
                DrRow = DtMaestro.NewRow();
                if (Productos.Clave1 == null) { DrRow["ID_PRODUCTO"] = DBNull.Value; } else { DrRow["ID_PRODUCTO"] = Productos.Clave1; }
                if (Productos.Clave2 == null) { DrRow["ID_CLIENTE"] = DBNull.Value; } else { DrRow["ID_CLIENTE"] = Productos.Clave2; }
                DrRow["DESCRIPCION"] = Productos.Descripcion1 != null ? Productos.Descripcion1.ToString().ToUpper() : "";
                DrRow["DESCRIPCION2"] = String.Concat(DrRow["DESCRIPCION"], " (", DrRow["ID_PRODUCTO"], ")");
                DtMaestro.Rows.Add(DrRow);
            }
            DtMaestro.AcceptChanges();
            return DtMaestro;
        }

        #endregion Funciones_Productos

        #region Funciones_Coberturas

        #endregion Funciones_Coberturas

        #region Funciones_Impuestos

        //    private DataTable LlenarDatosImpuestos(ColeccionNegocioBase<EntidadLectura> Coleccion, DataTable DtMaestro)
        //    {
        //        DataRow DrRow;
        //        DtMaestro.Rows.Clear();
        //        foreach (EntidadLectura Impuestos in Coleccion)
        //        {
        //            DrRow = DtMaestro.NewRow();
        //            if (Impuestos.Clave1 == null) { DrRow["ID_PAIS"] = DBNull.Value; } else { DrRow["ID_PAIS"] = Impuestos.Clave1; }
        //            if (Impuestos.Clave2 == null) { DrRow["ID_IMPUESTO"] = DBNull.Value; } else { DrRow["ID_IMPUESTO"] = Impuestos.Clave2; }
        //            DrRow["DESCRIPCION"] = Impuestos.Descripcion1 != null ? Impuestos.Descripcion1.ToString().ToUpper() : "";
        //            DtMaestro.Rows.Add(DrRow);
        //        }
        //        DtMaestro.AcceptChanges();
        //        return DtMaestro;
        //    }

        #endregion Funciones_Impuestos

        #region Funciones_Editorial

        //    private DataTable llenarDatosEditorial(ColeccionNegocioBase<EntidadLectura> Coleccion, DataTable dtMaestro)
        //    {
        //        DataRow drEditorial;
        //        dtMaestro.Rows.Clear();
        //        foreach (EntidadLectura Editorial in Coleccion)
        //        {
        //            drEditorial = dtMaestro.NewRow();
        //            if (Editorial.Clave1 == null) { drEditorial["ID_EDITORIAL"] = DBNull.Value; } else { drEditorial["ID_EDITORIAL"] = Editorial.Clave1; }
        //            drEditorial["DESCRIPCION"] = Editorial.Descripcion1 != null ? Editorial.Descripcion1.ToString().ToUpper() : "";
        //            dtMaestro.Rows.Add(drEditorial);
        //        }
        //        dtMaestro.AcceptChanges();
        //        return dtMaestro;
        //    }

        #endregion Funciones_Editorial

        #region Funciones_Clientes

        private DataTable LlenarDatosClientes(ColeccionNegocioBase<EntidadLectura> Coleccion, DataTable DtMaestro)
        {
            DataRow DrRow;
            DtMaestro.Rows.Clear();
            foreach (EntidadLectura Clientes in Coleccion)
            {
                DrRow = DtMaestro.NewRow();
                if (Clientes.Clave1 == null) { DrRow["ID_CLIENTE"] = DBNull.Value; } else { DrRow["ID_CLIENTE"] = Clientes.Clave1; }
                if (Clientes.Clave2 == null) { DrRow["ID_PAIS"] = DBNull.Value; } else { DrRow["ID_PAIS"] = Clientes.Clave2; }
                if (Clientes.Clave3 == null) { DrRow["ID_GRUPO"] = DBNull.Value; } else { DrRow["ID_GRUPO"] = Clientes.Clave3; }
                DrRow["DESCRIPCION"] = Clientes.Descripcion1 != null ? Clientes.Descripcion1.ToString().ToUpper() : "";
                DtMaestro.Rows.Add(DrRow);
            }
            DtMaestro.AcceptChanges();
            return DtMaestro;
        }

        #endregion Funciones_Clientes

        #region Funciones_MedioPagos

        private DataTable LlenarDatosPagosMedio(ColeccionNegocioBase<ProveedorEntidad> Coleccion, DataTable DtMaestro)
        {
            DataRow DrRow;
            foreach (ProveedorEntidad Proveedor in Coleccion)
            {
                DrRow = DtMaestro.NewRow();
                DrRow["ID_CLIENTE"] = Proveedor.Codigo;
                DrRow["ID_MEDIO"] = Proveedor.Empresa.Codigo;
                DrRow["PORCENTAJE_SAG"] = Proveedor.Descripcion.ToString();
                DtMaestro.Rows.Add(DrRow);
            }
            DtMaestro.AcceptChanges();
            return DtMaestro;
        }

        #endregion Funciones_MedioPagos

        #region Funciones_Proveedores

        private DataTable LlenarDatosPorveedores(ColeccionNegocioBase<ProveedorEntidad> Coleccion, DataTable DtMaestro)
        {
            DataRow DrRow;
            foreach (ProveedorEntidad Proveedor in Coleccion)
            {
                if (Proveedor.FechaBaja == null)
                {
                    DrRow = DtMaestro.NewRow();
                    DrRow["ID_PROVEEDOR"] = Proveedor.Codigo;
                    DrRow["ID_EMPRESA"] = Proveedor.Empresa.Codigo;
                    DrRow["DESCRIPCION"] = Proveedor.Descripcion.ToString();
                    DrRow["CUIT"] = Proveedor.Empresa.CodigoFiscal.ToString();
                    DtMaestro.Rows.Add(DrRow);
                }
            }
            DtMaestro.AcceptChanges();
            return DtMaestro;
        }

        public DataTable ObtenerProveedorCUIT(int id_pais, int CodProveedor)
        {
            DatosMms oProveedores = new DatosMms();
            DataTable dtPorveedores;
            ColeccionNegocioBase<ProveedorEntidad> lstProveedores = null;
            lstProveedores = oProveedores.ObtenerProveedorCuit(id_pais, CodProveedor);
            dtPorveedores = ObtenerEstructuraDataTable(MaestrosFiltro.TipoMaestros.ProveedorCUIT);
            dtPorveedores = LlenarDatosPorveedores(lstProveedores, dtPorveedores);
            return dtPorveedores;
        }

        #endregion Funciones_Proveedores

        #endregion Funciones_Llenar_DataTables

        #region Ordenes

        /// <summary>
        /// Inserta una Orden TV.
        /// </summary>
        /// <param name="_value"></param>
        /// <param name="idCampaniaMMS"></param>
        /// <param name="idSubCampanaMms"></param>
        /// <param name="mmsCodPais"></param>
        /// <param name="mmsCodUsuario"></param>
        /// <param name="mmsCodCompania"></param>
        /// <returns></returns>
        public DataTable InsertarOrden(DataTable _value, int idCampaniaMMS, int idSubCampanaMms, int mmsCodPais, int mmsCodUsuario, int mmsCodCompania, int mmsCodCliente)
        {
            _OrdenTvDataMapper = new OrdenTvDataMapper();
            _OrdenTvDataMapper._dtDatos = _value;
            _OrdenTvDataMapper.idCampaniaMMS = idCampaniaMMS;
            _OrdenTvDataMapper.idSubCampanaMms = idSubCampanaMms;
            _OrdenTvDataMapper.mmsCodCompania = mmsCodCompania;
            _OrdenTvDataMapper.mmsCodPais = mmsCodPais;
            _OrdenTvDataMapper.mmsCodUsuario = mmsCodUsuario;
            _OrdenTvDataMapper.mmsCodCliente = mmsCodCliente;
            return _OrdenTvDataMapper.SetNewOrdenObject();
        }

        /// <summary>
        /// Setea los datos necesarios para insertar una orden Prensa.
        /// </summary>
        /// <returns></returns>
        public DataTable InsertarOdenPrensa(DataTable _value, int idCampaniaMMS, int idSubCampanaMms, int mmsCodPais, int mmsCodUsuario, int mmsCodCompania)
        {
            //Warning: Jsperk - Verificar las fechas.
            DateTime desde = new DateTime(2010, 01, 01);
            DateTime hasta = new DateTime(2010, 12, 01);
            DatosMms oPresupuesto = new DatosMms();
            //
            _OrdenPrensaDataMapper = new OrdenPrensaDataMapper(_value, idCampaniaMMS, idSubCampanaMms, mmsCodPais, mmsCodUsuario, mmsCodCompania);
            _OrdenPrensaDataMapper.lstPresupuestos = oPresupuesto.obtenerPresupuestos(mmsCodPais, mmsCodCompania, idCampaniaMMS, idSubCampanaMms, desde, hasta); //this.LstPresupuestos;
            _OrdenPrensaDataMapper.SetNewOrdenPrensaObject();
            return _OrdenPrensaDataMapper.dtAvisosInsertados;
        }

        /// <summary>
        /// Inserta una nueva Orden Radio.
        /// </summary>
        /// <param name="_value">Valores a insertar</param>
        /// <param name="idCampaniaMMS">Codigo de campania</param>
        /// <param name="idSubCampanaMms">Codigo de Sub Campania</param>
        /// <param name="mmsCodPais">Codigo de Pais</param>
        /// <param name="mmsCodUsuario">Codigo de Usuario</param>
        /// <param name="mmsCodCompania">Codigo de Compania</param>
        /// <returns>Ordenes Insertadas.</returns>
        public DataTable InsertarOrdenRadio(DataTable _value, int idCampaniaMMS, int idSubCampanaMms, int mmsCodPais, int mmsCodUsuario, int mmsCodCompania)
        {
            try
            {
                _OrdenRadioDataMapper = new OrdenRadioDataMapper(_value, idCampaniaMMS, idSubCampanaMms, mmsCodPais, mmsCodUsuario, mmsCodCompania);
                return _OrdenRadioDataMapper.SetNewOrdenRadioObject();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Inserta una nueva orden de tipo Orden Exterior
        /// </summary>
        /// <param name="_value">DataTable con los valores</param>
        /// <param name="idCampaniaMMS">id campania MMS</param>
        /// <param name="idSubCampanaMms">Id Sub Campania MMS</param>
        /// <param name="mmsCodPais">Codigo Pais</param>
        /// <param name="mmsCodUsuario">Codigo Usuario</param>
        /// <param name="mmsCodCompania">Codigo Compania MMS</param>
        /// <returns></returns>
        public DataTable InsertarOrdenExt(DataTable _value, int idCampaniaMMS, int idSubCampanaMms, int mmsCodPais, int mmsCodUsuario, int mmsCodCompania)
        {
            OrdenExtDataMapper mprExterior = new OrdenExtDataMapper(_value, idCampaniaMMS, idSubCampanaMms, mmsCodPais, mmsCodUsuario, mmsCodCompania);
            return mprExterior.SetNewOrdenExtObject();
        }

        /// <summary>
        /// Inserta ordenes del medio Revista.
        /// </summary>
        /// <param name="_value">DataTable con los valores</param>
        /// <param name="idCampaniaMMS">ID Campania MMS</param>
        /// <param name="idSubCampanaMms">ID Subcampania MMS</param>
        /// <param name="mmsCodPais">Codigo Pais</param>
        /// <param name="mmsCodUsuario">Codigo Usuario</param>
        /// <param name="mmsCodCompania">Codigo Compania</param>
        /// <returns></returns>
        public DataTable InsertarOrdenRevista(DataTable _value, int idCampaniaMMS, int idSubCampanaMms, int mmsCodPais, int mmsCodUsuario, int mmsCodCompania)
        {
            _OrdenRevistaDataMapper = new OrdenRevistaDataMapper(_value, idCampaniaMMS, idSubCampanaMms, mmsCodPais, mmsCodUsuario, mmsCodCompania);
            _OrdenRevistaDataMapper.SetNewOrdenObject();
            return _OrdenRevistaDataMapper.dtAvisosInsertados;
        }

        public DataTable InsertarOrdenPro(DataTable _value, int idCampaniaMMS, int idSubCampanaMms, int mmsCodPais, int mmsCodUsuario, int mmsCodCompania)
        {
            //AG Produccion +++++++++++++++++++++++++++
            OrdenProDataMapper mpProduccion = new OrdenProDataMapper(_value, idCampaniaMMS, idSubCampanaMms, mmsCodPais, mmsCodUsuario, mmsCodCompania);
            return mpProduccion.SetNewOrdenProObject();
        }

        public DataTable InsertarOrdenInternet(DataTable _value, int idCampaniaMMS, int idSubCampanaMms, int mmsCodPais, int mmsCodUsuario, int mmsCodCompania, int mmsCodCliente, string mesPresupuestos, string anioPresupuestos, string codigoPresupuestos, bool esEnvioDoble)
        {
            OrdenIntDataMapper mpInternet = new OrdenIntDataMapper(_value, idCampaniaMMS, idSubCampanaMms, mmsCodPais, mmsCodUsuario, mmsCodCompania, mmsCodCliente, mesPresupuestos, anioPresupuestos, codigoPresupuestos, esEnvioDoble);
            return mpInternet.SetNewOrdenExtObject();
        }

        #endregion Ordenes

        #region Tipos Soportes

        /// <summary>
        /// Obtiene los tipos de Soportes mediante Servicio WCF.
        /// </summary>
        /// <param name="codPais">Codigo de Pais</param>
        /// <returns>Tipos de Soportes</returns>
        public DataTable ObtenerSoportes(int codPais)
        {
            try
            {
                DataTable dtSoportes = new DataTable();
                EverestDispatchingServiceClient service = new EverestDispatchingServiceClient();
                dtSoportes = service.ObtenerSoportes(codPais).Tables[0];
                service.Close();
                return dtSoportes;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion Tipos Soportes
    }
}
