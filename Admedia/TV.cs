using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using dbSQL = Admedia.DAL.SQLDatos;

namespace Admedia
{
    public class TV
    {
        public int Cantidad (string canal)
        {
            int cantAvisos=0;
            /*
            using (dbAdmediaDataContext db = new dbAdmediaDataContext())
            {
                var datos = (from avisos in db.emision_TVs
                             where avisos.nFecha == 20090707
                             where avisos.nCod_Vehiculo == 77
                             select new
                             {
                                 aviso = avisos.nTot_Avisos_Bloque
                             });
                foreach (var dato in datos)
                {
                    cantAvisos += 1;
                }
            }
            */

            dbSQL Admedia = new Admedia.DAL.SQLDatos();

            Admedia.GetDataTable("SpObtenerSpots", 20090701, 20090930, 6, 6152, 106368, 74, 2);

            return cantAvisos;

        }
    }
}
