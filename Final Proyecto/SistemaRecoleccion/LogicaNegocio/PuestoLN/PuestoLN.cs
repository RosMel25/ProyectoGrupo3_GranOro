using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.DataBase;

namespace LogicaNegocio.PuestoLN
{
    public class PuestoLN
    {
        private ClsPuestoDB puestoDB = new ClsPuestoDB(); // Instancia de la capa de datos

        public DataTable ObtenerPuestos()
        {
            return puestoDB.ListarPuestos();
        }

        public void AgregarPuesto(int id, string nombre, decimal minSalario, decimal maxSalario)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre del puesto no puede estar vacío.");

            if (minSalario < 0 || maxSalario < 0)
                throw new ArgumentException("Los salarios no pueden ser negativos.");

            if (minSalario > maxSalario)
                throw new ArgumentException("El salario mínimo no puede ser mayor que el máximo.");

            puestoDB.InsertarPuesto(id, nombre, minSalario, maxSalario);
        }
        public void ActualizarPuesto(int id, string nombre, decimal minSalario, decimal maxSalario)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre del puesto no puede estar vacío.");

            if (minSalario < 0 || maxSalario < 0)
                throw new ArgumentException("Los salarios no pueden ser negativos.");

            if (minSalario > maxSalario)
                throw new ArgumentException("El salario mínimo no puede ser mayor que el máximo.");

            puestoDB.ActualizarPuesto(id, nombre, minSalario, maxSalario);
        }

        public void EliminarPuesto(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El ID del puesto debe ser mayor a 0.");

            puestoDB.EliminarPuesto(id);
        }

        public DataTable BuscarPuesto(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El ID del puesto debe ser mayor a 0.");

            return puestoDB.BuscarPuesto(id);
        }

    }
}
