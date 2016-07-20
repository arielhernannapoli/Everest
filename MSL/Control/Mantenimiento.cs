using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using HM.Comun.SolutionEntityFramework;
using HM.Comun.Utilidades.Excepciones;
using HM.Comun.Varios;
using HM.MMS.AR.Client.Agentes.Control;
using HM.MMS.AR.Server.BusinessEntity.Control;
using HM.MMS.AR.Server.Service;
using HM.MMS.Core.Server.BusinessEntity.Ordenes.TV;
using HM.MMS.Core.Server.BusinessEntity.Seguridad;
using HM.MMS.ES.Server.BusinessEntity.Confirmacion.TV;

using BussEntOrd = HM.MMS.Core.Server.BusinessEntity.Ordenes.TV;

using ServiceConfirmacionTV = HM.MMS.AR.Client.View.Confirmacion.ServiceCliente.AR.ConfirmacionTV.GestionConfirmacionTVClient;
using User = HM.Comun.ExecutionArchitecture.Security.Information;

namespace MSL.Control
{
    public enum TipoOrden
    {
        SoporteFecha = 1,
        FechaSoporte = 2
    }

    public class Mantenimiento
    {
        private AgenteGestionControl agenteControl = new AgenteGestionControl();

        protected void DispararErrorSiEsNecesario(ResultadoWS resultado)
        {
            if (resultado.EsError)
                throw new Exception(resultado.MensajeError);
        }

        private void ConfirmarOrdenesTV()
        {
            Usuario user = new Usuario();
            //user.CodPaisActual = mmsCodPais;
            //user.CodUsuario = mmsCodUsuario;
            //user.CodCompaniaActual = mmsCodCompania;

            SolutionEntityList<ConfirmacionTV> lConfirmacionTV = new SolutionEntityList<ConfirmacionTV>();
            SolutionEntityList<BussEntOrd.OrdenTV> lOrdenes = new SolutionEntityList<BussEntOrd.OrdenTV>();

            ServiceConfirmacionTV srvConfirmacion = new ServiceConfirmacionTV();
            Guid correcto = new Guid();

            try
            {
                //    correcto = srvConfirmacion.ConfirmacionNumeroOrden(,lOrdenes,lConfirmacionTV);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet ObtenerOrdenesSinConfirmar(int codCompania, int codPresupuesto, bool facturadas)
        {
            DataSet resultado = null;

            try
            {
                resultado = agenteControl.ObtenerOrdenesSinConfirmar(codCompania, codPresupuesto, facturadas);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return resultado;
        }

        public List<AvisoPresupuesto> ObtenerPresupuestosPendientes(int codCompania, DateTime fechaDesde, DateTime fechaHasta)
        {
            List<AvisoPresupuesto> lAvisos = new List<AvisoPresupuesto>();

            try
            {
                lAvisos = agenteControl.ObtenerPresupuestosPendientes(codCompania, fechaDesde, fechaHasta);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lAvisos;
        }

        public List<AvisoCaido> ObtenerAvisosCaidos(int codCompania, int codPresupuesto)
        {
            List<AvisoCaido> lAvisos = new List<AvisoCaido>();

            try
            {
                lAvisos = agenteControl.ObtenerAvisosCaidos(codCompania, codPresupuesto);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lAvisos;
            //SolutionEntityList<OrdenTV> lOrden = new SolutionEntityList<OrdenTV>();
            //SolutionEntityList<OrdenTV> lOrdenAux = new SolutionEntityList<OrdenTV>();
            //OrdenTV ordenTV;
            //DataSet ds = new DataSet();
            //int codPresupuesto, codPresupuestoAnt;

            //try
            //{
            //    codPresupuestoAnt = int.Parse(dtAvisosCaidos.Rows[0]["COD_PRESUPUESTO"].ToString());

            //    foreach (DataRow dr in dtAvisosCaidos.Rows)
            //    {
            //        codPresupuesto = int.Parse(dtAvisosCaidos.Rows[0]["COD_PRESUPUESTO"].ToString());

            //        if (codPresupuesto != codPresupuestoAnt)
            //        {
            //            //lOrdenAux = Obtenerordenes
            //        }

            //        var orden = lOrdenAux.Where(x => ((OrdenTV)(x.BusinessEntity)).CodigoOrden == int.Parse(dr["COD_ORDEN"].ToString()));
            //        if (orden.Count() == 1)
            //        {
            //            lOrden.Add(orden.ElementAt(0));
            //            lOrdenAux.Remove(orden.ElementAt(0));
            //        }

            //        codPresupuestoAnt = codPresupuesto;
            //    }

            //    DataTable dt = ArmarAvisosCaidos(lOrden);
            //    ds.Tables.Add(dt);
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception("Error obteniendo los avisos." + ex.Message);
            //}

            //return ds;
        }

        public List<AvisoNoConfirmado> ObtenerAvisosNoConfirmados(int codCompania, int codPresupuesto)
        {
            List<AvisoNoConfirmado> lAvisos = new List<AvisoNoConfirmado>();

            try
            {
                lAvisos = agenteControl.ObtenerAvisosNoConfirmados(codCompania, codPresupuesto);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lAvisos;
        }

        public List<AvisoNoConfirmado> ObtenerAvisosReporteFacturacion(int codCompania, int codPresupuesto)
        {
            List<AvisoNoConfirmado> lAvisos = new List<AvisoNoConfirmado>();

            try
            {
                lAvisos = agenteControl.ObtenerAvisosReporteFacturacion(codCompania, codPresupuesto);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lAvisos;
        }

        public Dictionary<string, List<OrdenMatcheo>> ObtenerOrdenesMatcheo(int codCompania, int codPresupuesto)
        {
            Dictionary<string, List<OrdenMatcheo>> lOrdenes = new Dictionary<string, List<OrdenMatcheo>>();

            try
            {
                lOrdenes = agenteControl.ObtenerOrdenesMatcheo(codCompania, codPresupuesto);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lOrdenes;
        }

        private DataTable ArmarAvisosCaidos(SolutionEntityList<OrdenTV> lOrden)
        {
            DataTable dtAvisos = new DataTable();
            dtAvisos.Columns.Add("ORDEN", typeof(int));
            dtAvisos.Columns.Add("SOPORTE", typeof(string));
            dtAvisos.Columns.Add("FECHA", typeof(DateTime));
            dtAvisos.Columns.Add("HORA", typeof(int));
            dtAvisos.Columns.Add("MIN", typeof(int));
            dtAvisos.Columns.Add("DURACION", typeof(int));
            dtAvisos.Columns.Add("PROGRAMA", typeof(string));
            dtAvisos.AcceptChanges();

            DataRow drAviso;
            OrdenTV orden;

            try
            {
                foreach (var ordenTV in lOrden)
                {
                    orden = (OrdenTV)(ordenTV.BusinessEntity);

                    drAviso = dtAvisos.NewRow();
                    drAviso["ORDEN"] = orden.CodigoOrden.Value;
                    drAviso["SOPORTE"] = orden.SoporteDescripcion;
                    drAviso["FECHA"] = orden.FechaEjecucion;
                    drAviso["HORA"] = orden.HoraPublicidad.Hora;
                    drAviso["MIN"] = orden.HoraPublicidad.Minuto;
                    drAviso["DURACION"] = orden.Duracion.Value;
                    drAviso["PROGRAMA"] = orden.Bloque;

                    dtAvisos.Rows.Add(drAviso);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en ArmarAvisosCaidos." + ex.Message);
            }

            return dtAvisos;
        }

        public string InsertarAvisosConfirmados(int codUsuario, int codPais, int codCompania, List<AvisoConfirmado> lAvisos)
        {
            string resultado = "";
            Usuario usuario = new Usuario { CodUsuario = codUsuario, CodPaisActual = codPais, CodCompaniaActual = codCompania };

            using (AgenteGestionControl agente = new AgenteGestionControl())
            {
                try
                {
                    resultado = agente.InsertarAvisosConfirmados(usuario, lAvisos);
                }
                catch (Exception ex)
                {
                    resultado = ex.ToString();
                }
            }

            return resultado;
        }

        public string InsertarAvisosNoConfirmados(int codUsuario, int codPais, int codCompania, List<AvisoNoConfirmado> lAvisos)
        {
            string resultado = "";
            Usuario usuario = new Usuario { CodUsuario = codUsuario, CodPaisActual = codPais, CodCompaniaActual = codCompania };

            using (AgenteGestionControl agente = new AgenteGestionControl())
            {
                try
                {
                    resultado = agente.InsertarAvisosNoConfirmados(usuario, lAvisos);
                }
                catch (Exception ex)
                {
                    resultado = ex.ToString();
                }
            }

            return resultado;
        }

        public string InsertarAvisosManuales(int codUsuario, int codPais, int codCompania, List<AvisoConfirmado> lAvisos)
        {
            string resultado = "";
            Usuario usuario = new Usuario { CodUsuario = codUsuario, CodPaisActual = codPais, CodCompaniaActual = codCompania };

            using (AgenteGestionControl agente = new AgenteGestionControl())
            {
                try
                {
                    resultado = agente.InsertarAvisosManuales(usuario, lAvisos);
                }
                catch (Exception ex)
                {
                    resultado = ex.ToString();
                }
            }

            return resultado;
        }

        public string InsertarAvisosCaidos(int codUsuario, int codPais, int codCompania, List<AvisoCaido> lAvisos)
        {
            string resultado = "";
            Usuario usuario = new Usuario { CodUsuario = codUsuario, CodPaisActual = codPais, CodCompaniaActual = codCompania };

            using (AgenteGestionControl agente = new AgenteGestionControl())
            {
                try
                {
                    resultado = agente.InsertarAvisosCaidos(usuario, lAvisos);
                }
                catch (Exception ex)
                {
                    resultado = ex.ToString();
                }
            }

            return resultado;
        }

        public string ActualizarAvisosNoConfirmados(int codUsuario, int codPais, int codCompania, List<AvisoNoConfirmado> lAvisos)
        {
            string resultado = "";
            Usuario usuario = new Usuario { CodUsuario = codUsuario, CodPaisActual = codPais, CodCompaniaActual = codCompania };

            using (AgenteGestionControl agente = new AgenteGestionControl())
            {
                try
                {
                    resultado = agente.ActualizarAvisosNoConfirmados(usuario, lAvisos);
                }
                catch (Exception ex)
                {
                    resultado = ex.ToString();
                }
            }

            return resultado;
        }

        public string EliminarAvisosNoConfirmados(int codUsuario, int codPais, int codCompania, List<AvisoNoConfirmado> lAvisos)
        {
            string resultado = "";
            Usuario usuario = new Usuario { CodUsuario = codUsuario, CodPaisActual = codPais, CodCompaniaActual = codCompania };

            using (AgenteGestionControl agente = new AgenteGestionControl())
            {
                try
                {
                    resultado = agente.EliminarAvisosNoConfirmados(usuario, lAvisos);
                }
                catch (Exception ex)
                {
                    resultado = ex.ToString();
                }
            }

            return resultado;
        }

        public string EliminarAvisosManuales(int codUsuario, int codPais, int codCompania, List<AvisoConfirmado> lAvisos)
        {
            string resultado = "";
            Usuario usuario = new Usuario { CodUsuario = codUsuario, CodPaisActual = codPais, CodCompaniaActual = codCompania };

            using (AgenteGestionControl agente = new AgenteGestionControl())
            {
                try
                {
                    resultado = agente.EliminarAvisosManuales(usuario, lAvisos);
                }
                catch (Exception ex)
                {
                    resultado = ex.ToString();
                }
            }

            return resultado;
        }

        public string EliminarAvisoCaido(int codUsuario, int codCompania, int codPais, List<AvisoCaido> lAvisos)
        {
            string resultado = "";
            Usuario usuario = new Usuario { CodUsuario = codUsuario, CodPaisActual = codPais, CodCompaniaActual = codCompania };

            using (AgenteGestionControl agente = new AgenteGestionControl())
            {
                try
                {
                    resultado = agente.EliminarAvisosCaidos(usuario, lAvisos);
                }
                catch (Exception ex)
                {
                    resultado = ex.ToString();
                }
            }

            return resultado;
        }

        public string ConfirmarAvisos(int codUsuario, int codPais, int codCompania, string login, string password, List<AvisoConfirmado> lAvisos)
        {
            string resultado = "";
            Usuario usuario = new Usuario { CodUsuario = codUsuario, CodPaisActual = codPais, CodCompaniaActual = codCompania };

            UsuarioAgente agenteU = new UsuarioAgente();
            agenteU.Usuario_Validar(login, password);
            usuario = User.GetUserInformationLogged();

            using (AgenteGestionControl agente = new AgenteGestionControl())
            {
                try
                {
                    resultado = agente.ConfirmarAvisos(usuario, lAvisos);
                }
                catch (Exception ex)
                {
                    resultado = ex.ToString();
                }
            }

            return resultado;
        }

        public Dictionary<string, List<AvisoConfirmado>> ObtenerAvisosConfirmados(int codCompania, List<int> lSoportes, DateTime fechaDesde, DateTime fechaHasta)
        {
            Dictionary<string, List<AvisoConfirmado>> lAvisos = new Dictionary<string, List<AvisoConfirmado>>();

            try
            {
                lAvisos = agenteControl.ObtenerAvisosConfirmados(codCompania, lSoportes, fechaDesde, fechaHasta);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lAvisos;
        }

        public string DesconfirmarAvisos(int codUsuario, int codPais, int codCompania, List<AvisoConfirmado> lAvisos)
        {
            string resultado = "";
            Usuario usuario = new Usuario { CodUsuario = codUsuario, CodPaisActual = codPais, CodCompaniaActual = codCompania };

            using (AgenteGestionControl agente = new AgenteGestionControl())
            {
                try
                {
                    resultado = agente.DesconfirmarAvisos(usuario, lAvisos);
                }
                catch (Exception ex)
                {
                    resultado = ex.ToString();
                }
            }

            return resultado;
        }

        public Dictionary<string, List<AvisoConfirmado>> ObtenerOrdenesConfirmadas(int codCompania, int codPresupuesto, string ordenamiento)
        {
            Dictionary<string, List<AvisoConfirmado>> lOrdenes = new Dictionary<string, List<AvisoConfirmado>>();
            List<AvisoConfirmado> lAvisos = new List<AvisoConfirmado>();

            try
            {
                lOrdenes = agenteControl.ObtenerOrdenesConfirmadas(codCompania, codPresupuesto);

                if (string.IsNullOrEmpty(lOrdenes.Keys.ElementAt(0).ToString()))
                {
                    string key = lOrdenes.Keys.ElementAt(0);

                    if (!string.IsNullOrEmpty(ordenamiento))
                    {
                        if (ordenamiento == "Fec_Spot,Des_Soporte ASC")
                            lAvisos = lOrdenes.Values.ElementAt(0).OrderBy(x => x.FechaReal).ThenBy(y => y.DescripcionSoporte).ToList();
                        else
                            lAvisos = lOrdenes.Values.ElementAt(0).OrderBy(x => x.DescripcionSoporte).ThenBy(y => y.FechaReal).ToList();
                    }
                    else
                        lAvisos = lOrdenes.Values.ElementAt(0);

                    lOrdenes.Clear();
                    lOrdenes.Add(key, lAvisos);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lOrdenes;
        }

        public Dictionary<string, List<OrdenConfirmada>> ObtenerOrdenesConfirmadasCPR(int codCompania, int codCliente, DateTime fDesde, DateTime fHasta)
        {
            Dictionary<string, List<OrdenConfirmada>> lOrdenes = new Dictionary<string, List<OrdenConfirmada>>();

            try
            {
                lOrdenes = agenteControl.ObtenerOrdenesConfirmadasCPR(codCompania, codCliente, fDesde, fHasta);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lOrdenes;
        }

        public string InsertarAvisosAjuste(List<AvisosAjustes> lAvisosAjuste)
        {
            string resultado = "";
            using (AgenteGestionControl agente = new AgenteGestionControl())
            {
                try
                {
                    resultado = agente.InsertarAvisosAjustar(lAvisosAjuste);
                }
                catch (Exception ex)
                {
                    resultado = ex.ToString();
                }
            }
            return resultado;
        }

        public List<AvisosAjustes> GenerarAjustesOrdenes(int CodCompania, int CodPresupuesto)
        {
            List<AvisosAjustes> LOrdenesAjustadas = new List<AvisosAjustes>();
            using (AgenteGestionControl agente = new AgenteGestionControl())
            {
                try
                {
                    LOrdenesAjustadas = agente.GenerarAjustesOrdenes(CodCompania, CodPresupuesto);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return LOrdenesAjustadas;
        }

        public List<int> ValidarAjustesExistentes(int CodCompania, int CodPresupuesto)
        {
            List<int> OrdenesAjustadas = new List<int>();
            using (AgenteGestionControl agente = new AgenteGestionControl())
            {
                try
                {
                    OrdenesAjustadas = agente.ValidarAjustesExistentes(CodCompania, CodPresupuesto);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return OrdenesAjustadas;
        }

        public List<PresupuestoPA> ObtenerPresupuestoPA(int codCompania, int codMedio, int codCliente, int codSoporte, DateTime fPrimerAviso, DateTime fUltimoAviso, decimal montoEverest)
        {
            List<PresupuestoPA> LPresupuestoPA = new List<PresupuestoPA>();
            using (AgenteGestionControl agente = new AgenteGestionControl())
            {
                try
                {
                    LPresupuestoPA = agente.ObtenerPresupuestoPA(codCompania, codMedio, codCliente, codSoporte, fPrimerAviso, fUltimoAviso, montoEverest);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return LPresupuestoPA;
        }

        public string InsertarPAPC(int codCompania, int codPresupuestoC, int codPresupuestoA)
        {
            string resultado = "";
            using (AgenteGestionControl agente = new AgenteGestionControl())
            {
                try
                {
                    resultado = agente.InsertarPAPC(codCompania, codPresupuestoC, codPresupuestoA);
                }
                catch (Exception ex)
                {
                    resultado = ex.ToString();
                }
            }
            return resultado;
        }

        public List<PresupuestoPA> ObtenerSoportesPA(int codCompania, int codPresupuestoPA)
        {
            List<PresupuestoPA> LPresupuestoPA = new List<PresupuestoPA>();
            using (AgenteGestionControl agente = new AgenteGestionControl())
            {
                try
                {
                    LPresupuestoPA = agente.ObtenerSoportesPAPA(codCompania, codPresupuestoPA); 
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return LPresupuestoPA;
        }

    }
}
