using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.DataBase;
using Entidad.Usuarios;



namespace LogicaNegocio.FincaLN
{
    public class FincaLN
    {
        public AccesoDatos.DataBase.ClsDataBase data;

        public FincaLN()
        {
            this.data = new AccesoDatos.DataBase.ClsDataBase();
        }


        #region Metodos de Acceso

        // Mostrar Usuarios
        public DataTable MostrarFinca()
        {
            string ProcedimientoBD = "PROCE_FINCAS.LISTAR_FINCA";
            string TipoProcedimiento = "CUR_FINCAS";

            return data.ejecutarProcedimientoMOSTRAR(ProcedimientoBD, TipoProcedimiento);
        }


        public DataTable GuardarFinca(Entidad.Finca.ClsFinca Newfinca)
        {
            string Procedimiento = "PROCE_FINCAS.AGREGAR_FINCA";

            return data.ejecutarProcedimientoCRUD(
                Procedimiento,
                new string[] { "pID", "pNOMBRE", "pTAMAÑO", "pUBICACION" },
                new string[] { Newfinca.No_Finca.ToString(),
                    Newfinca.Nom_Finca.ToString(), Newfinca.Tam_Finca.ToString(),
                    Newfinca.Ubi_Finca.ToString(), }

                );
        }

        public DataTable EliminarFinca(Entidad.Finca.ClsFinca Newfinca)
        {
            string Procedimiento = "PROCE_FINCAS.ELIMINAR_FINCA";

            return data.ejecutarProcedimientoCRUD(
                Procedimiento,
                new string[] { "pID" },
                new string[] { Newfinca.No_Finca.ToString() }

                );
        }

        public DataTable EditarFinca(Entidad.Finca.ClsFinca Newfinca)
        {
            string Procedimiento = "PROCE_FINCAS.EDITAR_FINCA";

            return data.ejecutarProcedimientoCRUD(
                Procedimiento,
                new string[] { "pID", "pNOMBRE", "pTAMAÑO", "pUBICACION" },
                new string[] { Newfinca.No_Finca.ToString(),
                    Newfinca.Nom_Finca.ToString(), Newfinca.Tam_Finca.ToString(),
                    Newfinca.Ubi_Finca.ToString(), }

                );
        }

        public DataTable BuscarFinca(Entidad.Finca.ClsFinca Newfinca)
        {
            string Procedimiento = "PROCE_FINCAS.BUSCAR_FINCA";
            string TipoProcedimiento = "CUR_UNA_FINCA";

            return data.ejecutarProcedimiento_BUSQUEDA(
                Procedimiento,
                new string[] { "pID"},
                new string[] { Newfinca.No_Finca.ToString()}, 
                TipoProcedimiento);

        }

        public DataTable VERFICAR_FINCA(int cod)
        {
            string Procedimiento = "PROCE_FINCAS.Validar_Registro";
            string TipoProcedimiento = "CUR_VALIDAR";

            return data.ejecutarProcedimiento_BUSQUEDA(
                Procedimiento,
                new string[] { "p_num" },
                new string[] { cod.ToString() },
                TipoProcedimiento);
        }

        #endregion


    }
}
