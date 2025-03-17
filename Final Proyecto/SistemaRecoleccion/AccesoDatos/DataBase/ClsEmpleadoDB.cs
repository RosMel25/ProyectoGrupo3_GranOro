using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;


namespace AccesoDatos.DataBase
{
    public class ClsEmpleadoDB
    {
        private string connectionString = "User Id=ESTUDIANTE;Password=123;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=orcl)));";


        public DataTable ListarEmpleados()
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand("ListarEmpleados", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor, ParameterDirection.Output);

                    OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public void InsertarEmpleado(int id, string nombre, string apellido, string email, string telefono, decimal salario, int idPuesto, int noFinca)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand("InsertarEmpleado", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_Identificacion", OracleDbType.Int32).Value = id;
                    cmd.Parameters.Add("p_Nombre", OracleDbType.Varchar2).Value = nombre;
                    cmd.Parameters.Add("p_Apellido", OracleDbType.Varchar2).Value = apellido;
                    cmd.Parameters.Add("p_Email", OracleDbType.Varchar2).Value = email;
                    cmd.Parameters.Add("p_Telefono", OracleDbType.Varchar2).Value = telefono;
                    cmd.Parameters.Add("p_Salario", OracleDbType.Decimal).Value = salario;
                    cmd.Parameters.Add("p_Id_Puesto", OracleDbType.Int32).Value = idPuesto;
                    cmd.Parameters.Add("p_No_Finca", OracleDbType.Int32).Value = noFinca;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void ActualizarEmpleado(int id, string nombre, string apellido, string email, string telefono, decimal salario, int idPuesto, int noFinca)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand("ActualizarEmpleado", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_Identificacion", OracleDbType.Int32).Value = id;
                    cmd.Parameters.Add("p_Nombre", OracleDbType.Varchar2).Value = nombre;
                    cmd.Parameters.Add("p_Apellido", OracleDbType.Varchar2).Value = apellido;
                    cmd.Parameters.Add("p_Email", OracleDbType.Varchar2).Value = email;
                    cmd.Parameters.Add("p_Telefono", OracleDbType.Varchar2).Value = telefono;
                    cmd.Parameters.Add("p_Salario", OracleDbType.Decimal).Value = salario;
                    cmd.Parameters.Add("p_Id_Puesto", OracleDbType.Int32).Value = idPuesto;
                    cmd.Parameters.Add("p_No_Finca", OracleDbType.Int32).Value = noFinca;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EliminarEmpleado(int id)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand("EliminarEmpleado", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_Identificacion", OracleDbType.Int32).Value = id;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable BuscarEmpleado(int id)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand("BuscarEmpleado", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_Identificacion", OracleDbType.Int32).Value = id;
                    cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor, ParameterDirection.Output);

                    OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
