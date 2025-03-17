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
        private ClsEmpleadoDB empleadoDB = new ClsEmpleadoDB();

        public DataTable ObtenerEmpleados()
        {
            DataTable dt = empleadoDB.ListarEmpleados();
            if (dt == null) dt = new DataTable(); // Previene valores nulos
            return dt;
        }

        public void AgregarEmpleado(int id, string nombre, string apellido, string email, string telefono, decimal salario, int idPuesto, int noFinca)
        {
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido))
                throw new ArgumentException("El nombre y apellido no pueden estar vacíos.");

            if (salario < 0)
                throw new ArgumentException("El salario no puede ser negativo.");

            empleadoDB.InsertarEmpleado(id, nombre, apellido, email, telefono, salario, idPuesto, noFinca);
        }
        public void ActualizarEmpleado(int id, string nombre, string apellido, string email, string telefono, decimal salario, int idPuesto, int noFinca)
        {
            empleadoDB.ActualizarEmpleado(id, nombre, apellido, email, telefono, salario, idPuesto, noFinca);
        }
        public void EliminarEmpleado(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El ID del empleado debe ser mayor a 0.");

            empleadoDB.EliminarEmpleado(id);
        }

        public DataTable BuscarEmpleado(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El ID del empleado debe ser mayor a 0.");

            return empleadoDB.BuscarEmpleado(id);
        }
    }
}
