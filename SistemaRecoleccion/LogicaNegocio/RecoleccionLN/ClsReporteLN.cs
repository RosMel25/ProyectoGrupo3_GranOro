using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.RecoleccionLN
{
    public class ClsReporteLN
    {
        public AccesoDatos.DataBase.ClsDataBase data;

        public ClsReporteLN()
        {
            this.data = new AccesoDatos.DataBase.ClsDataBase();
        }

        public DataTable ReporteGeneral(string F_incio, string F_Final)
        {
            string Procedimiento = "PROCE_REPORTES.REPORTE_GENERAL";
            string TipoProcedimiento = "CUR_BUSCAR";

            return data.ejecutarProcedimiento_BUSQUEDA(
                Procedimiento,
                new string[] { "pFECHA_INICIO", "pFECHA_FINAL" },
                new string[] { F_incio, F_Final },
                TipoProcedimiento);

        }

        public DataTable ReporteGenerlaRecolector(string codigo, string F_incio, string F_Final)
        {
            string Procedimiento = "PROCE_REPORTES.REPORTE_GENERAL_RECOLECTOR";
            string TipoProcedimiento = "CUR_BUSCAR";

            return data.ejecutarProcedimiento_BUSQUEDA(
                Procedimiento,
                new string[] { "pID_FINCA", "pFECHA_INICIO", "pFECHA_FINAL" },
                new string[] { codigo, F_incio, F_Final },
                TipoProcedimiento);

        }

        public DataTable ReporteRecolector(string cedula, string F_incio, string F_Final)
        {
            string Procedimiento = "PROCE_REPORTES.REPORTE_RECOLECTOR";
            string TipoProcedimiento = "CUR_BUSCAR";

            return data.ejecutarProcedimiento_BUSQUEDA(
                Procedimiento,
                new string[] { "pID_CEDULA", "pFECHA_INICIO", "pFECHA_FINAL" },
                new string[] { cedula, F_incio, F_Final },
                TipoProcedimiento);

        }
    }
}
