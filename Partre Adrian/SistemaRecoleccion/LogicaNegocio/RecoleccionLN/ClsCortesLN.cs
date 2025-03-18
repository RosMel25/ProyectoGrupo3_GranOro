using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.RecoleccionLN
{
    public class ClsCortesLN
    {
        public AccesoDatos.DataBase.ClsDataBase data;

        public ClsCortesLN()
        {
            this.data = new AccesoDatos.DataBase.ClsDataBase();
        }


        #region Metodos de Acceso

        
        public DataTable MostrarCorte()
        {
            string ProcedimientoBD = "PROCE_CORTE.LISTAR_CORTE";
            string TipoProcedimiento = "CUR_CORTE";

            return data.ejecutarProcedimientoMOSTRAR(ProcedimientoBD, TipoProcedimiento);
        }


        public DataTable GuardarCorte(Entidad.ClsCorte NewCorte)
        {
            string Procedimiento = "PROCE_CORTE.AGREGAR_CORTE";

            return data.ejecutarProcedimientoCRUD(
                Procedimiento,
                new string[] { "pID", "pNOMBRE", "pID_FINCA" },
                new string[] {NewCorte.ID_Corte.ToString(),
                    NewCorte.Nom_Corte.ToString(),
                    NewCorte.NO_Finca.ToString() }

                );
        }

        public DataTable EliminarCorte(Entidad.ClsCorte NewCorte)
        {
            string Procedimiento = "PROCE_CORTE.ELIMINAR_CORTE";

            return data.ejecutarProcedimientoCRUD(
                Procedimiento,
                new string[] { "pID" },
                new string[] { NewCorte.ID_Corte.ToString() }

                );
        }

        public DataTable EditarCorte(Entidad.ClsCorte NewCorte)
        {
            string Procedimiento = "PROCE_CORTE.EDITAR_CORTE";

            return data.ejecutarProcedimientoCRUD(
                Procedimiento,
                new string[] { "pID", "pNOMBRE", "pID_FINCA" },
                new string[] { NewCorte.ID_Corte.ToString(),
                    NewCorte.Nom_Corte.ToString(),
                    NewCorte.NO_Finca.ToString() }

                );
        }

        public DataTable BuscarCorte(Entidad.Finca.ClsFinca Newfinca)
        {
            string Procedimiento = "PROCE_CORTE.BUSCAR_FINCA";

            return data.ejecutarProcedimientoCRUD(
                Procedimiento,
                new string[] { "pID" },
                new string[] { Newfinca.No_Finca.ToString() }

                );
        }

        #endregion
    }
}
