using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class ClsUsuarioLN
    {
        public AccesoDatos.DataBase.ClsDataBase data;
        public ClsUsuarioLN()
        {
            this.data = new AccesoDatos.DataBase.ClsDataBase();
        }


        #region Metodos de Acceso


        public DataTable MostrarUsuario()
        {
            string ProcedimientoBD = "PROCE_USUARIOS.LISTAR_USER";
            string TipoProcedimiento = "CUR_USER";

            return data.ejecutarProcedimientoMOSTRAR(ProcedimientoBD, TipoProcedimiento);
        }


        public DataTable GuardarUsuario(Entidad.Usuarios.ClsUsuario NewUser)
        {
            string Procedimiento = "PROCE_USUARIOS.AGREGAR_USER";

            return data.ejecutarProcedimientoCRUD(
                Procedimiento,
                new string[] { "pID", "pNOMBRE", "pCEDULA", "pEMAIL", "pROL" },
                new string[] {NewUser.IdUsuario.ToString(),
                    NewUser.Nombre.ToString(),
                    NewUser.Cedula.ToString(),
                    NewUser.Email.ToString(),
                    NewUser.Rol.ToString()}

                );
        }

        public DataTable EliminarUsuario(Entidad.Usuarios.ClsUsuario NewUser)
        {
            string Procedimiento = "PROCE_USUARIOS.ELIMINAR_USER";

            return data.ejecutarProcedimientoCRUD(
                Procedimiento,
                new string[] { "pID" },
                new string[] { NewUser.IdUsuario.ToString() }

                );
        }

        public DataTable EditarUsuario(Entidad.Usuarios.ClsUsuario NewUser)
        {
            string Procedimiento = "PROCE_USUARIOS.EDITAR_USER";

            return data.ejecutarProcedimientoCRUD(
                Procedimiento,
                new string[] { "pID", "pNOMBRE", "pCEDULA", "pEMAIL", "pROL" },
                new string[] { NewUser.IdUsuario.ToString(),
                    NewUser.Nombre.ToString(),
                    NewUser.Cedula.ToString(),
                    NewUser.Email.ToString(),
                    NewUser.Rol.ToString()}

                );
        }

        public DataTable BuscarPrecio(Entidad.Finca.ClsFinca Newfinca)
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
