using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Configuration;

namespace Admedia.DAL
{
    public class SQLDatos
    {
        protected SqlConnection conn = new SqlConnection();

        /// <summary>
        /// Abre la conexión
        /// </summary>
        private void OpenConnection()
        {
            string Server = "sqlbas01";
            string Username = "monitor";
            string Password = "monitor";
            string Database = "AdMedia";

            string ConnectionString = "Data Source=" + Server + ";";
            ConnectionString += "User ID=" + Username + ";";
            ConnectionString += "Password=" + Password + ";";
            ConnectionString += "Initial Catalog=" + Database;
            
            conn.ConnectionString = ConfigurationSettings.AppSettings["ConnectionString"].ToString();//ConnectionString;
            
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }

        /// <summary>
        /// Cierra la conexión
        /// </summary>
        public void CloseConnection()
        {
            conn.Close();
        }

        /// <summary>
        /// Trae los datos de la base SQL y llena un datatable
        /// </summary>
        /// <param name="StoredProcedure">Nombre del stored procedure</param>
        /// <param name="Parametros">Los parámetros del stored procedure</param>
        /// <returns></returns>
        public DataTable GetDataTable(string StoredProcedure,params object[] Parametros)
        {
            SqlCommand Command = new SqlCommand(StoredProcedure, conn);
            Command.CommandType = CommandType.StoredProcedure;
           
            try
            {   //Abro la conexión
                OpenConnection();

                //Consulto los parámetros del SP
                SqlCommandBuilder.DeriveParameters(Command);

                if (Parametros.Length > 0)
                {
                    CargarParametros(Command, Parametros);
                }


                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = Command;

                DataTable dt = new DataTable();

                //Llena el datatable
                da.Fill(dt);

                //Cierro la conexión
                CloseConnection();

                return dt;

            }
            catch (Exception ex)
            {
                if (conn != null && conn.State == ConnectionState.Open)
                    CloseConnection();

                throw ex;
            }

        }

        /// <summary>
        /// Trae los datos de la base SQL y llena un dataset
        /// </summary>
        /// <param name="StoredProcedure">Nombre del stored procedure</param>
        /// <param name="Parametros">Los parámetros del stored procedure</param>
        /// <returns></returns>
        public DataSet GetDataSet(string StoredProcedure, params object[] Parametros)
        {
            SqlCommand Command = new SqlCommand(StoredProcedure, conn);
            Command.CommandType = CommandType.StoredProcedure;

            try
            {   //Abro la conexión
                OpenConnection();

                //Consulto los parámetros del SP
                SqlCommandBuilder.DeriveParameters(Command);

                if (Parametros.Length > 0)
                {
                    CargarParametros(Command, Parametros);
                }


                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = Command;

                DataSet ds = new DataSet();

                //Llena el datatable
                da.Fill(ds);

                //Cierro la conexión
                CloseConnection();

                return ds;

            }
            catch
            {
                if (conn != null && conn.State == ConnectionState.Open)
                    CloseConnection();

                throw;
            }

        }

        /// <summary>
        /// Carga en el comando los valores pasados por parámetro
        /// </summary>
        /// <param name="Comando"></param>
        /// <param name="parametros"></param>
        protected void CargarParametros(SqlCommand Comando, params Object[] parametros)
        {
            int index = 0;

            try
            {
                foreach (SqlParameter parameter in Comando.Parameters)
                {
                    if (parameter.Direction == ParameterDirection.Input ||
                         parameter.Direction == ParameterDirection.
                                                     InputOutput)
                    {
                        parameter.Value = parametros[index];
                        index++;
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }

        }


    }
}
