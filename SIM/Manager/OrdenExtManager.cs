namespace SIM.Manager
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using HM.MMS.Core.Server.BusinessEntity.Seguridad;
    using HM.MMS.AR.Server.BusinessEntity.Ordenes;
    using HM.MMS.AR.Client.Agentes.ViaPublica;
    using HM.MMS.AR.Server.BusinessEntity.Ordenes.ViaPublica;

    public class OrdenExtManager
    {
        #region Singleton

        /// <summary>
        /// Esta clase implementa una versión del patrón de diseño Singleton thread-safe, lo que significa que 
        /// esta diseñada para proveer una instancia Singleton a través de todos los threads de una aplicación multi-threaded.
        /// </summary>
        private static volatile OrdenExtManager instance = null;
        /// <summary>
        /// Objeto que se utiliza para asegurar que sólo un thread puede crear la instancia Singleton.
        /// </summary>
        private static object syncRoot = new object();

        /// <summary>
        /// Devuelve la instancia Singleton.
        /// </summary>
        internal static OrdenExtManager Instance
        {
            get
            {
                // Sólo crea una nueva instancia si aún no existe una.
                if (OrdenExtManager.instance == null)
                {
                    // Este bloqueo asegura que sólo un thread sea capaz crear la instancia con en este bloque de código.
                    lock (OrdenExtManager.syncRoot)
                    {
                        if (OrdenExtManager.instance == null)
                            OrdenExtManager.instance = new OrdenExtManager();
                    } // lock
                } // if

                // Devuelve la instancia que fue creada recién o que ya existía.
                return (OrdenExtManager.instance);
            }
        }

        #endregion

        #region Propiedades
        
        #endregion
        
        #region Constructores

        #endregion
        
        #region Metodos

        /// <summary>
        /// Inserta una orden tipo exterior.
        /// </summary>
        /// <param name="_value">Valores a insertar</param>
        /// <param name="idCampaniaMMS">Id Campaña</param>
        /// <param name="idSubCampanaMms">Id Subcampaña</param>
        /// <param name="mmsCodPais">Codigo Pais</param>
        /// <param name="mmsCodUsuario">Codigo de Usuario</param>
        /// <param name="mmsCodCompania">Codigo de Compania</param>
        /// <returns></returns>
        static public Dictionary<OrdenEverest, int?> insertar_spotExt(List<OrdenViaPublica> _value, int idCampaniaMMS, int idSubCampanaMms, int mmsCodPais, int mmsCodUsuario, int mmsCodCompania)
        {
            Usuario user = new Usuario();
            user.CodPaisActual = mmsCodPais;
            user.CodUsuario = mmsCodUsuario;
            user.CodCompaniaActual = mmsCodCompania;

            var result = new Dictionary<OrdenEverest, int?>();
            using (var agente = new AgenteGestionOrdenes())
            {
                result = agente.InsertarOrdenes(user, idCampaniaMMS, idSubCampanaMms, _value);
            }
            return result;
        }

        #endregion
    }
}
