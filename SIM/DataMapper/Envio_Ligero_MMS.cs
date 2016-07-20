using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MPG.DAL;

namespace SIM.DataMapper
{
    public class Envio_Ligero_MMS: Entidad
    {
        const string CONST_SP_ENVIO_CABECERA_MMS = "SP_ENVIO_CABECERA_MMS";
        const string CONST_SP_TOTAL_SOPORTES_PA_TV = "SP_TOTAL_SOPORTES_PA_TV";
        const string CONST_PKG_ENVIO_LIGERO_MMS = "SPK_ENVIO_LIGERO_MMS";

        public DataTable DtParametros { get; set; }
        public int CodCompaniaMMS { get; set; }
        public int CodCliente { get; set; }
        public int CodUsuario { get; set; }
        public int CodCampaniaMMS { get; set; }
        public int CodSubcampaniaMMS { get; set; }
        public string MesPresupuestos { get; set; }
        public string AnioPresupuestos { get; set; }
        public string CodigoPresupuestos { get; set; }

        public Envio_Ligero_MMS()
            : base("Envio_Ligero_MMS")
        {
        }

        public Envio_Ligero_MMS(DataTable dtParametros, int codCompaniaMMS, int codCliente, int codUsuario, int codCampaniaMMS, int codSubcampaniaMMS, string mesPresupuestos, string anioPresupuestos, string codPresupuestos) : base("Envio_Ligero_MMS")
        {
            DtParametros = dtParametros;
            CodCompaniaMMS = codCompaniaMMS;
            CodCliente = codCliente;
            CodUsuario = codUsuario;
            CodCampaniaMMS = codCampaniaMMS;
            CodSubcampaniaMMS = codSubcampaniaMMS;
            MesPresupuestos = mesPresupuestos;
            AnioPresupuestos = anioPresupuestos;
            CodigoPresupuestos = codPresupuestos;
        }

        public int Envio_Cabecera_MMS_TV()
        {
            int contador = 0;
            DataTable DistintoDtParametros = new DataTable();
            DistintoDtParametros = DtParametros.Clone();
            DistintoDtParametros = DtParametros.DefaultView.ToTable(true, "CAMPANIA", "SISTEMA", "EJERCICIO", "MEDIO", "PRODUCTO", "FECHADESDE", "FECHAHASTA", "TEMA", "SOPORTE", "MES", "ANIO", "MESPRESUPUESTO", "PRESUPUESTO");

            foreach (DataRow parametro in DistintoDtParametros.Rows)
            {
                object retorno = TraerValor(String.Format("{0}.{1}", CONST_PKG_ENVIO_LIGERO_MMS, CONST_SP_ENVIO_CABECERA_MMS), parametro["CAMPANIA"], parametro["SISTEMA"], parametro["EJERCICIO"], parametro["MEDIO"], parametro["PRODUCTO"], parametro["SOPORTE"], parametro["TEMA"], Convert.ToDateTime(parametro["FECHADESDE"]), Convert.ToDateTime(parametro["FECHAHASTA"]), parametro["MESPRESUPUESTO"], parametro["ANIO"], CodCompaniaMMS, CodSubcampaniaMMS, CodCampaniaMMS, parametro["PRESUPUESTO"], CodCliente, CodUsuario);
                if (retorno == null)
                    contador = 0;
                else
                    contador = contador + Convert.ToInt32(retorno);
            }
            return contador;
        }

        public DataTable Obtener_Total_Soportes_PA_TV(int cod_campania,int cod_sistema, int cod_ejercicio, int cod_producto, int cod_soporte, string tema, string fechadesde, string fechahasta, int mes, int anio, int cod_compania, int cod_subcampania_mms, int cod_campania_mms, int cod_presupuesto)
        {
            DataSet retorno = TraerDataSet(String.Format("{0}.{1}", CONST_PKG_ENVIO_LIGERO_MMS, CONST_SP_TOTAL_SOPORTES_PA_TV),
                cod_campania, cod_sistema, cod_ejercicio, cod_producto, cod_soporte, tema, fechadesde, fechahasta, mes, anio, cod_compania,
                cod_subcampania_mms, cod_campania_mms, cod_presupuesto);
            if(retorno != null)
                return retorno.Tables[0];
            return null;
        }

        protected override void ArmarObjeto(IDataReader dr)
        {
            throw new NotImplementedException();
        }

        public DataTable Envio_Cabecera_MMS_Internet()
        {
            DataTable contratos = new DataTable();

        //' Orden de parametros para procedure oracle:
        //' p_COD_CAMPANIA_EVE
        //' p_COD_SISTEMA_EVE
        //' p_COD_EJERCICIO_EVE
        //' p_COD_MEDIO_EVE
        //' p_COD_PRODUCTO_EVE
        //' p_COD_SOPORTE_EVE
        //' p_TEMA_EVE
        //' p_F_DESDE_EVE
        //' p_F_HASTA_EVE
        //' p_MES_PRESUPUESTO
        //' p_ANIO_PRESUPUESTO
        //' p_COD_COMPANIA_MMS 
        //' p_COD_SUBCAMPANA_MMS
        //' p_COD_CAMPANA_MMS
        //' p_COD_PRESUPUESTO_MMS
        //' p_COD_CLIENTE_MMS
        //' p_COD_USUARIO_MMS

            DataTable distintoDtParametros = new DataTable();
            distintoDtParametros = DtParametros.Clone();
            distintoDtParametros = DtParametros.DefaultView.ToTable(true, "CAMPANIA", "SISTEMA", "EJERCICIO", "MEDIO", "PRODUCTO", "FECHADESDE", "FECHAHASTA", "TEMA", "SOPORTE", "MES", "ANIO", "MESPRESUPUESTO", "PRESUPUESTO");

            foreach(DataRow parametro in distintoDtParametros.Rows)
            {
                DataSet retorno = TraerDataSet(String.Format("{0}.{1}", CONST_PKG_ENVIO_LIGERO_MMS, CONST_SP_ENVIO_CABECERA_MMS), parametro["CAMPANIA"], parametro["SISTEMA"], parametro["EJERCICIO"], parametro["MEDIO"], parametro["PRODUCTO"], parametro["SOPORTE"], parametro["TEMA"], parametro["FECHADESDE"], parametro["FECHAHASTA"], MesPresupuestos, AnioPresupuestos, CodCompaniaMMS, CodSubcampaniaMMS, CodCampaniaMMS, CodigoPresupuestos, CodCliente, CodUsuario);
                if(retorno !=null && retorno.Tables.Count > 0)
                {
                    if(contratos.Rows.Count == 0)
                        contratos = retorno.Tables[0].Copy();
                    else
                    {
                        foreach(DataRow row in retorno.Tables[0].Rows)
                        {
                            contratos.ImportRow(row);
                        }
                    }
                }
            }
            return contratos;
        }
    }
}
