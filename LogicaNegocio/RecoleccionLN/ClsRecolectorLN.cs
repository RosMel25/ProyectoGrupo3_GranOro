using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.RecoleccionLN
{
    public class ClsRecolectorLN
    {
        public AccesoDatos.DataBase.ClsDataBase data;

        public ClsRecolectorLN() {
            this.data = new AccesoDatos.DataBase.ClsDataBase();
        }


        #region Metodos de Acceso

        // Mostrar Usuarios
        public DataTable MostrarRecolector()
        {
            string ProcedimientoBD = "PROCE_RECOLECTOR.LISTAR_RECOLECTOR";
            string TipoProcedimiento = "CUR_RECOLECTOR";

            return data.ejecutarProcedimientoMOSTRAR(ProcedimientoBD, TipoProcedimiento);
        }


        public DataTable GuardarRecolector(Entidad.Recoleccion.ClsRecolector NewRecolector)
        {
            string Procedimiento = "PROCE_RECOLECTOR.AGREGAR_RECOLECTOR";

            return data.ejecutarProcedimientoCRUD(
                Procedimiento,
                new string[] { "pID", "pNOMBRE" },
                new string[] { NewRecolector.Identificacion.ToString(),
                    NewRecolector.Nom_Recolector.ToString(), }

                );
        }

        public DataTable EliminarRecolector(Entidad.Recoleccion.ClsRecolector NewRecolector)
        {
            string Procedimiento = "PROCE_RECOLECTOR.ELIMINAR_RECOLECTOR";

            return data.ejecutarProcedimientoCRUD(
                Procedimiento,
                new string[] { "pID" },
                new string[] { NewRecolector.Identificacion.ToString() }

                );
        }

        public DataTable EditarRecolector(Entidad.Recoleccion.ClsRecolector NewRecolector)
        {
            string Procedimiento = "PROCE_RECOLECTOR.EDITAR_RECOLECTOR";

            return data.ejecutarProcedimientoCRUD(
                Procedimiento,
                new string[] { "pID", "pNOMBRE" },
                new string[] { NewRecolector.Identificacion.ToString(),
                    NewRecolector.Nom_Recolector.ToString(), }

                );
        }

        public DataTable BuscarRecolector(Entidad.Finca.ClsFinca Newfinca)
        {
            string Procedimiento = "PROCE_RECOLECTOR.BUSCAR_FINCA";

            return data.ejecutarProcedimientoCRUD(
                Procedimiento,
                new string[] { "pID" },
                new string[] { Newfinca.No_Finca.ToString() }

                );
        }

        #endregion

    }
}
