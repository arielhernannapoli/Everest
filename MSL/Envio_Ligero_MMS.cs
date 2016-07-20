using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace MSL
{
    public class Envio_Ligero_MMS
    {
        SIM.DataMapper.Envio_Ligero_MMS mEnvio_Ligero_MMS;

        public Envio_Ligero_MMS()
        {
            mEnvio_Ligero_MMS = new SIM.DataMapper.Envio_Ligero_MMS();
        }

        public DataTable Obtener_Total_Soportes_PA_TV(int cod_campania, int cod_sistema, int cod_ejercicio, int cod_producto, int cod_soporte, string tema, string fechadesde, string fechahasta, int mes, int anio, int cod_compania, int cod_subcampania_mms, int cod_campania_mms, int cod_presupuesto)
        {
            return mEnvio_Ligero_MMS.Obtener_Total_Soportes_PA_TV(cod_campania, cod_sistema, cod_ejercicio, cod_producto, cod_soporte, tema, fechadesde, fechahasta, mes, anio, cod_compania, cod_subcampania_mms, cod_campania_mms, cod_presupuesto);
        }
    }
}
