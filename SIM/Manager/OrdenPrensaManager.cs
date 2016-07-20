namespace SIM
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using HM.MMS.Core.Server.BusinessEntity.Seguridad;
    using HM.MMS.AR.Server.BusinessEntity.Ordenes;
    using HM.MMS.AR.Client.Agentes.Prensa;
    using HM.MMS.AR.Server.BusinessEntity.Ordenes.Prensa;

    /// <summary>
    /// Manejo de Ordenes Prensa.
    /// </summary>
    public class OrdenPrensaManager
    {
        #region Singleton

        /// <summary>
        /// Esta clase implementa una versión del patrón de diseño Singleton thread-safe, lo que significa que 
        /// esta diseñada para proveer una instancia Singleton a través de todos los threads de una aplicación multi-threaded.
        /// </summary>
        private static volatile OrdenPrensaManager instance = null;
        /// <summary>
        /// Objeto que se utiliza para asegurar que sólo un thread puede crear la instancia Singleton.
        /// </summary>
        private static object syncRoot = new object();

        /// <summary>
        /// Devuelve la instancia Singleton.
        /// </summary>
        internal static OrdenPrensaManager Instance
        {
            get
            {
                // Sólo crea una nueva instancia si aún no existe una.
                if (OrdenPrensaManager.instance == null)
                {
                    // Este bloqueo asegura que sólo un thread sea capaz crear la instancia con en este bloque de código.
                    lock (OrdenPrensaManager.syncRoot)
                    {
                        if (OrdenPrensaManager.instance == null)
                            OrdenPrensaManager.instance = new OrdenPrensaManager();
                    } // lock
                } // if

                // Devuelve la instancia que fue creada recién o que ya existía.
                return (OrdenPrensaManager.instance);
            }
        }

        #endregion

        #region Constructor

        public OrdenPrensaManager()
        {

        }

        #endregion

        #region Metodos

        static public Dictionary<OrdenEverest, int?> insertar_spotPrensa(List<OrdenPrensa> _value, int idCampaniaMMS, int idSubCampanaMms, int mmsCodPais, int mmsCodUsuario, int mmsCodCompania)
        {
            try
            {
                Usuario user = new Usuario();
                user.CodPaisActual = mmsCodPais;
                user.CodUsuario = mmsCodUsuario;
                user.CodCompaniaActual = mmsCodCompania;

                var results = new Dictionary<OrdenEverest, int?>();

                using (var agente = new AgenteGestionOrdenes())
                {
                    results = agente.InsertarOrdenes(user,
                                                     idCampaniaMMS,
                                                     idSubCampanaMms,
                                                     _value);
                }
                
                return results;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion
    }
}
