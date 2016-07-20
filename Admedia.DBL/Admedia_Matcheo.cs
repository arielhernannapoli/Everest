using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Admedia.DBL
{
    public class Admedia_Matcheo
    {
        Admedia.DAL.SQLDatos AdmediaDAL = new Admedia.DAL.SQLDatos();

        public DataSet TraerSpotsMatcheo(DateTime fechaInicio, DateTime fechafin, string codSoporte,
            int codCliente, string codProducto, string tipoAviso, int codTipoSoporte)
        {
            int fInicio, fFin;

            fInicio = int.Parse(fechaInicio.ToShortDateString().Substring(6, 4) + fechaInicio.ToShortDateString().Substring(3, 2) + fechaInicio.ToShortDateString().Substring(0, 2));
            fFin = int.Parse(fechafin.ToShortDateString().Substring(6, 4) + fechafin.ToShortDateString().Substring(3, 2) + fechafin.ToShortDateString().Substring(0, 2));
            //fInicio = int.Parse(fechaInicio.Year.ToString() + "0" + fechaInicio.Month.ToString() + "0" + fechaInicio.Day.ToString());
            //fFin = int.Parse(fechafin.Year.ToString() + "0" + fechafin.Month.ToString() + fechafin.Day.ToString());

            return AdmediaDAL.GetDataSet("SpObtenerSpots", fInicio, fFin, codSoporte, codCliente, codProducto,
                tipoAviso, codTipoSoporte);
        }


        public DataSet TraerSpotConfirmado(int codProducto, int codCliente, string codSoporte, int hora,
            int segundos, DateTime fecha, int codTipoSoporte)
        {
            int Fecha;

            Fecha = int.Parse(fecha.ToShortDateString().Substring(6, 4) + fecha.ToShortDateString().Substring(3, 2) + fecha.ToShortDateString().Substring(0, 2));

            return AdmediaDAL.GetDataSet("SpObtenerSpot", codProducto, codCliente, codSoporte, hora, segundos, Fecha, codTipoSoporte);
        }

        public DataSet TraerSpotsMatcheoInterior(DateTime fechaInicio, DateTime fechafin, string codSoporte,
                                                int codCliente, string codProducto, string tipoAviso, int codTipoSoporte)
        {
            int fInicio, fFin;

            fInicio = int.Parse(fechaInicio.ToShortDateString().Substring(6, 4) + fechaInicio.ToShortDateString().Substring(3, 2) + fechaInicio.ToShortDateString().Substring(0, 2));
            fFin = int.Parse(fechafin.ToShortDateString().Substring(6, 4) + fechafin.ToShortDateString().Substring(3, 2) + fechafin.ToShortDateString().Substring(0, 2));
            
            return AdmediaDAL.GetDataSet("SpObtenerSpots", fInicio, fFin, codSoporte, codCliente, codProducto,
                                                            tipoAviso, codTipoSoporte);
        }
        public DataTable ObtenerAnunciante(int codAnunciante)
        {
            DataTable dtAnunciantes = new DataTable();

            var dt = AdmediaDAL.GetDataTable("SpObtenerAnunciante", codAnunciante);

            if (dt != null && dt.Rows.Count > 0)
                dtAnunciantes = dt;
            //else
            //{
            //    dtAnunciantes = new DataTable();
            //    dtAnunciantes.Columns.Add("error");
            //    dtAnunciantes.Rows.Add("No se encontró anunciante en Admedia con código " + codAnunciante);
            //}

            return dtAnunciantes;
        }

        public DataTable ObtenerProductos(int codAnunciante, int? codProducto)
        {
            DataTable dtProductos = new DataTable();

            var dt = AdmediaDAL.GetDataTable("SpObtenerProductos", codAnunciante, codProducto.HasValue ? codProducto : -1);

            if (dt != null && dt.Rows.Count > 0)
                dtProductos = dt;

            return dtProductos;
        }

        public DataTable ObtenerEstadoActualizacion()
        {
            DataTable dtAux = new DataTable();

            var dt = AdmediaDAL.GetDataTable("SpActualizando");

            if (dt != null && dt.Rows.Count > 0)
                dtAux = dt;

            return dtAux;
        }

        public DataTable ObtenerDatosCargados(int anio, int mes)
        {
            DataTable dtAux = new DataTable();

            var dt = AdmediaDAL.GetDataTable("SpDatosDisponibles", anio, mes);

            if (dt != null && dt.Rows.Count > 0)
                dtAux = dt;

            return dtAux;
        }
    }
}
