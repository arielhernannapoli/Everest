namespace SIM
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using HM.Contratos.Entidad.Ordenes;
    using HM.MMS.Core.Server.BusinessEntity;
    using HM.MMS.Core.Server.BusinessEntity.Seguridad;
    using HM.MMS.Core.Server.BusinessEntity.Ordenes;
    using HM.MMS.AR.Server.BusinessEntity.Ordenes.Television;
    using HM.MMS.Core.Server.BusinessEntity.Ordenes.TV;
    using HM.MMS.AR.Client.Agentes.Television;
    using HM.MMS.AR.Server.BusinessEntity.Ordenes.Prensa;
    using HM.Contratos.Entidad.Campanas;
    using HM.Contratos.Entidad.Maestros;
    using HM.Contratos.Entidad.Soportes;
    using HM.MMS.AR.Server.BusinessEntity.Ordenes;

    public class OrdenTvManager
    {
        #region Properties
        #endregion

        #region OrdenTV

        /// <summary>
        /// Inserta ordenes de TV
        /// </summary>
        /// <param name="_value">Lista de ordenes TV</param>
        /// <param name="idCampaniaMMS">id_campaniaMMS</param>
        /// <returns>Dictionary con valores para actualizar base datos de Everest</returns>
        static public Dictionary<OrdenEverest, int?> insertar_spotTV(List<OrdenTelevision> _value, int idCampaniaMMS, int idSubCampanaMms, int mmsCodPais, int mmsCodUsuario, int mmsCodCompania)
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
                    results = agente.InsertarOrdenes(user, idCampaniaMMS, idSubCampanaMms, _value);
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
