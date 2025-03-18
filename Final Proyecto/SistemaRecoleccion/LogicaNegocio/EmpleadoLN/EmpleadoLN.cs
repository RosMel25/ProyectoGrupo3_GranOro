using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AccesoDatos.DataBase;

namespace LogicaNegocio.EmpleadoLN

{
   public class EmpleadoLN
    {
        public AccesoDatos.DataBase.ClsDataBase data;

        public EmpleadoLN()
        {
            this.data = new AccesoDatos.DataBase.ClsDataBase();
        }
        public DataTable ObtenerEmpleados()
        {
            string Procedimiento = "PROCE_EMPLEADO.ListarEmpleados";
            string TipoProcedimiento = "p_cursor";

            return data.ejecutarProcedimientoMOSTRAR(
                Procedimiento,
                TipoProcedimiento
                );
        }

        public DataTable AgregarEmpleado(Entidad.Finca.ClsFinca fin)
        {
            if (string.IsNullOrWhiteSpace(fin.Nom_Finca.ToString()) || string.IsNullOrWhiteSpace(apellido))
                throw new ArgumentException("El nombre y apellido no pueden estar vacíos.");

            if (salario < 0)
                throw new ArgumentException("El salario no puede ser negativo.");

            string Procedimiento = "PROCE_EMPLEADO.InsertarEmpleado";

            return data.ejecutarProcedimientoCRUD(
                Procedimiento,
                new string[] { "p_Identificacion", "p_Nombre", "p_Apellido", "p_Email", "p_Telefono", "p_Salario", "p_Id_Puesto", "p_No_Finca" },
                new string[] { fin.No_Finca.ToString(),
                    fin.Nom_Finca.ToString(), fin.Tam_Finca.ToString(),
                    fin.Ubi_Finca.ToString(), }

                );
        }
        public DataTable ActualizarEmpleado(int id, string nombre, string apellido, string email, string telefono, decimal salario, int idPuesto, int noFinca)
        {
            string Procedimiento = "PROCE_FINCAS.AGREGAR";

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido))
                throw new ArgumentException("El nombre y apellido no pueden estar vacíos.");

            if (salario < 0)
                throw new ArgumentException("El salario no puede ser negativo.");

            return data.ejecutarProcedimientoCRUD(
               Procedimiento,
               new string[] { "p_Identificacion", "p_Nombre", "p_Apellido", "p_Email", "p_Telefono", "p_Salario", "p_Id_Puesto", "p_No_Finca" },
               new string[] { Newfinca.No_Finca.ToString(),
                    Newfinca.Nom_Finca.ToString(), Newfinca.Tam_Finca.ToString(),
                    Newfinca.Ubi_Finca.ToString(), }

               );

        }
        public DataTable EliminarEmpleado(int id)
        {
            string Procedimiento = "PROCE_EMPLEADO.ELIMINAR";

            if (id <= 0)
                throw new ArgumentException("El ID del empleado debe ser mayor a 0.");

            return data.ejecutarProcedimientoCRUD(
               Procedimiento,
               new string[] { "p_Identificacion"},
               new string[] { Newfinca.No_Finca.ToString() }

               );
        }

        public DataTable BuscarEmpleado(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El ID del empleado debe ser mayor a 0.");

            return empleadoDB.BuscarEmpleado(id);
        }
    }
}
