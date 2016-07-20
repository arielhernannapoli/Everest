namespace SIM.Manager
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using HM.MMS.AR.Server.BusinessEntity.Ordenes;
    using HM.MMS.AR.Server.BusinessEntity.Ordenes.Revista;
    using HM.MMS.Core.Server.BusinessEntity.Seguridad;
    using HM.MMS.AR.Client.Agentes.Revista;

    public class OrdenRevistaManager
    {
        #region Constructor

        public OrdenRevistaManager()
        {

        }

        #endregion

        #region Metodos

        /// <summary>
        /// Inserta Ordenes Revista.
        /// </summary>
        /// <param name="_value">Dt con los valores.</param>
        /// <param name="idCampaniaMMS">Id campania MMS</param>
        /// <param name="idSubCampanaMms">Id Sub Campania MMS</param>
        /// <param name="mmsCodPais">Codigo Pais</param>
        /// <param name="mmsCodUsuario">Codigo Usuario</param>
        /// <param name="mmsCodCompania">Codigo Compania</param>
        /// <returns></returns>
        static public Dictionary<OrdenEverest, int?> insertar_spotRevista(List<OrdenRevista> _value, int idCampaniaMMS, int idSubCampanaMms, int mmsCodPais, int mmsCodUsuario, int mmsCodCompania)
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
                    results = agente.InsertarOrdenes(user,idCampaniaMMS, idSubCampanaMms, _value);
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
