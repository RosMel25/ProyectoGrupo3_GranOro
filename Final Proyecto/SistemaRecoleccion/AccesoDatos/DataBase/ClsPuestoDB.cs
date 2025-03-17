using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace AccesoDatos.DataBase
{
    public class ClsPuestoDB
    {
        private string connectionString = "User Id=ESTUDIANTE;Password=123;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=orcl)));";


        public DataTable ListarPuestos()
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand("ListarPuestos", conn))
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

        public void InsertarPuesto(int id, string nombre, decimal minSalario, decimal maxSalario)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand("InsertarPuesto", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_Id_Puesto", OracleDbType.Int32).Value = id;
                    cmd.Parameters.Add("p_Nombre_Puesto", OracleDbType.Varchar2).Value = nombre;
                    cmd.Parameters.Add("p_Min_Salario", OracleDbType.Decimal).Value = minSalario;
                    cmd.Parameters.Add("p_Max_Salario", OracleDbType.Decimal).Value = maxSalario;
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void ActualizarPuesto(int id, string nombre, decimal minSalario, decimal maxSalario)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand("ActualizarPuesto", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_Id_Puesto", OracleDbType.Int32).Value = id;
                    cmd.Parameters.Add("p_Nombre_Puesto", OracleDbType.Varchar2).Value = nombre;
                    cmd.Parameters.Add("p_Min_Salario", OracleDbType.Decimal).Value = minSalario;
                    cmd.Parameters.Add("p_Max_Salario", OracleDbType.Decimal).Value = maxSalario;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EliminarPuesto(int id)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand("EliminarPuesto", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_Id_Puesto", OracleDbType.Int32).Value = id;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable BuscarPuesto(int id)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand("BuscarPuesto", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_Id_Puesto", OracleDbType.Int32).Value = id;
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
