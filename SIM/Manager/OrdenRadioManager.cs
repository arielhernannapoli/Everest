namespace SIM.Manager
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using HM.MMS.AR.Client.Agentes.Radio;
    using HM.MMS.AR.Server.BusinessEntity.Ordenes;
    using HM.MMS.Core.Server.BusinessEntity.Seguridad;
    using HM.MMS.AR.Server.BusinessEntity.Ordenes.Radio;

    internal class OrdenRadioManager
    {
        #region Singleton

        /// <summary>
        /// Esta clase implementa una versión del patrón de diseño Singleton thread-safe, lo que significa que 
        /// esta diseñada para proveer una instancia Singleton a través de todos los threads de una aplicación multi-threaded.
        /// </summary>
        private static volatile OrdenRadioManager instance = null;

        /// <summary>
        /// Objeto que se utiliza para asegurar que sólo un thread puede crear la instancia Singleton.
        /// </summary>
        private static object syncRoot = new object();

        /// <summary>
        /// Devuelve la instancia Singleton.
        /// </summary>
        internal static OrdenRadioManager Instance
        {
            get
            {
                // Sólo crea una nueva instancia si aún no existe una.
                if (OrdenRadioManager.instance == null)
                {
                    // Este bloqueo asegura que sólo un thread sea capaz crear la instancia con en este bloque de código.
                    lock (OrdenRadioManager.syncRoot)
                    {
                        if (OrdenRadioManager.instance == null)
                            OrdenRadioManager.instance = new OrdenRadioManager();
                    } // lock
                } // if

                // Devuelve la instancia que fue creada recién o que ya existía.
                return (OrdenRadioManager.instance);
            }
        }

        #endregion

        #region Propiedades

        #endregion

        #region Constructor

        public OrdenRadioManager()
        {

        }

        #endregion

        #region Metodos

        /// <summary>
        /// Inserta una nueva orden radio.
        /// </summary>
        /// <param name="_value">Lista de objetos Orden Radio</param>
        /// <param name="idCampaniaMMS">Id de campania</param>
        /// <param name="idSubCampanaMms">Id de Subcampania</param>
        /// <param name="mmsCodPais">Codigo Pais</param>
        /// <param name="mmsCodUsuario">Codigo Usuario</param>
        /// <param name="mmsCodCompania">Codigo de Campania</param>
        /// <returns></returns>
        static public Dictionary<OrdenEverest, int?> insertar_spotRadio(List<OrdenRadio> _value, int idCampaniaMMS, int idSubCampanaMms, int mmsCodPais, int mmsCodUsuario, int mmsCodCompania)
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
