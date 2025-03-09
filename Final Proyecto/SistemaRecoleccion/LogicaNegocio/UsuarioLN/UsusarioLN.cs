using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.DataBase;
using Entidad.Usuarios;



namespace LogicaNegocio.Usuarios
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
        public DataTable MostrarUsuarios()
        {
            string Procedimiento = "PROCE_FINCAS.LISTAR";
            string TipoProcedimiento = "CUR_FINCAS";

            return data.ejecutarProcedimientoMOSTRAR(
                Procedimiento,
                TipoProcedimiento
                );
        }


        public DataTable GuardarFinca(Entidad.Finca.ClsFinca Newfinca)
        {
            string Procedimiento = "PROCE_FINCAS.AGREGAR";

            return data.ejecutarProcedimientoCRUD(
                Procedimiento,
                new string[] { "pID", "pNOMBRE", "pTAMAÑO", "pUBICACION" },
                new string[] { Newfinca.No_Finca.ToString(), 
                    Newfinca.Nom_Finca.ToString(), Newfinca.Tam_Finca.ToString(),
                    Newfinca.Ubi_Finca.ToString(), }

                );
        }

        #endregion


    }
}
