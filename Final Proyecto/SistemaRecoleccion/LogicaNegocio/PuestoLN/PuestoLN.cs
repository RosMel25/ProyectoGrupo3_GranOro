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
        public AccesoDatos.DataBase.ClsDataBase data;

        public PuestoLN()
        {
            this.data = new AccesoDatos.DataBase.ClsDataBase();
        }

        public DataTable ObtenerPuestos()
        {
            string Procedimiento = "PROCE_EMPLEADO.ListarPuestos";
            string TipoProcedimiento = "p_cursor";

            return data.ejecutarProcedimientoMOSTRAR(
                Procedimiento,
                TipoProcedimiento
                );
        }

        public DataTable AgregarPuesto(int id, string nombre, decimal minSalario, decimal maxSalario)
        {

            string Procedimiento = "PROCE_EMPLEADO.InsertarPuesto";

            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre del puesto no puede estar vacío.");

            if (minSalario < 0 || maxSalario < 0)
                throw new ArgumentException("Los salarios no pueden ser negativos.");

            if (minSalario > maxSalario)
                throw new ArgumentException("El salario mínimo no puede ser mayor que el máximo.");

            return data.ejecutarProcedimientoCRUD(
            Procedimiento,
            new string[] { "p_Id_Puesto", "p_Nombre_Puesto", "p_Min_Salario", "p_Max_Salario" },
            new string[] { Newfinca.No_Finca.ToString(),
                    Newfinca.Nom_Finca.ToString(), Newfinca.Tam_Finca.ToString(),
                    Newfinca.Ubi_Finca.ToString(), }

             );
        }
        public DataTable ActualizarPuesto(int id, string nombre, decimal minSalario, decimal maxSalario)
        {

            string Procedimiento = "PROCE_EMPLEADO.ActualizarPuesto";

            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre del puesto no puede estar vacío.");

            if (minSalario < 0 || maxSalario < 0)
                throw new ArgumentException("Los salarios no pueden ser negativos.");

            if (minSalario > maxSalario)
                throw new ArgumentException("El salario mínimo no puede ser mayor que el máximo.");

            return data.ejecutarProcedimientoCRUD(
            Procedimiento,
            new string[] { "p_Id_Puesto", "p_Nombre_Puesto", "p_Min_Salario", "p_Max_Salario" },
            new string[] { Newfinca.No_Finca.ToString(),
                    Newfinca.Nom_Finca.ToString(), Newfinca.Tam_Finca.ToString(),
                    Newfinca.Ubi_Finca.ToString(), }

             );
        }

        public DataTable EliminarPuesto(int id)
        {
            string Procedimiento = "PROCE_EMPLEADO.ActualizarPuesto";

            if (id <= 0)
                throw new ArgumentException("El ID del puesto debe ser mayor a 0.");

            return data.ejecutarProcedimientoCRUD(
                Procedimiento,
                new string[] { "p_Id_Puesto" },
                new string[] { Newfinca.No_Finca.ToString() }

            );
        }

        public DataTable BuscarPuesto(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El ID del puesto debe ser mayor a 0.");

            return puestoDB.BuscarPuesto(id);
        }

    }
}
