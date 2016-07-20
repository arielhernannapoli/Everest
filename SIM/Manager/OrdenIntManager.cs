
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HM.MMS.Core.Server.BusinessEntity.Seguridad;
using HM.MMS.AR.Server.BusinessEntity.Ordenes;
using HM.MMS.AR.Client.Agentes.Internet;
using HM.MMS.AR.Server.BusinessEntity.Ordenes.Internet;
using HM.Contratos.Entidad.Maestros;
using HM.MMS.AR.Client.Agentes;

namespace SIM.Manager
{
    public class OrdenIntManager
    {

        private static volatile OrdenIntManager instance = null;
        /// <summary>
        /// Objeto que se utiliza para asegurar que sólo un thread puede crear la instancia Singleton.
        /// </summary>
        private static object syncRoot = new object();

        internal static OrdenIntManager Instance
        {
            get
            {
                // Sólo crea una nueva instancia si aún no existe una.
                if (OrdenIntManager.instance == null)
                {
                    // Este bloqueo asegura que sólo un thread sea capaz crear la instancia con en este bloque de código.
                    lock (OrdenIntManager.syncRoot)
                    {
                        if (OrdenIntManager.instance == null)
                            OrdenIntManager.instance = new OrdenIntManager();
                    } // lock
                } // if

                // Devuelve la instancia que fue creada recién o que ya existía.
                return (OrdenIntManager.instance);
            }
        }

        static public Dictionary<OrdenEverest, int?> insertar_spotInt(List<OrdenInternet> _value, int idCampaniaMMS, int idSubCampanaMms, int mmsCodPais, int mmsCodUsuario, int mmsCodCompania)
        {
            Usuario user = new Usuario();
            user.CodPaisActual = mmsCodPais;
            user.CodUsuario = mmsCodUsuario;
            user.CodCompaniaActual = mmsCodCompania;

            var result = new Dictionary<OrdenEverest, int?>();

            using (var agente = new AgenteGestionOrdenes())
            {
                result = agente.InsertarOrdenesEverest(user, idCampaniaMMS, idSubCampanaMms, _value);
            }
            return result;
        }
    }
}
