using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace AccesoDatos.DataBase
{
    public class ClsDataBase
    {
        #region Variables Privadas.

        private OracleConnection _objOracleConnection;
        private OracleDataAdapter _objOracleDataAdapter;
        private OracleCommand _objOracleCommand;
        private DataSet dsResultados;
        private DataTable dtParametros;
        
        private string ProcedimientoBD;

        private string Ruta_NomBD;

        #endregion

        #region Variables Publicas.
        public OracleConnection ObjOracleConnection { get => ObjOracleConnection1; set => ObjOracleConnection1 = value; }
        public OracleDataAdapter ObjOracleDataAdapter { get => ObjOracleDataAdapter1; set => ObjOracleDataAdapter1 = value; }
        public OracleCommand ObjOracleCommand { get => ObjOracleCommand1; set => ObjOracleCommand1 = value; }
        public DataSet DsResultados { get => DsResultados1; set => DsResultados1 = value; }
        public DataTable DtParametros { get => DtParametros1; set => DtParametros1 = value; }
        public string ProcedimientoBD1 { get => ProcedimientoBD; set => ProcedimientoBD = value; }
        public string Ruta_NomBD1 { get => Ruta_NomBD; set => Ruta_NomBD = value; }
        public OracleConnection ObjOracleConnection1 { get => _objOracleConnection; set => _objOracleConnection = value; }
        public OracleDataAdapter ObjOracleDataAdapter1 { get => _objOracleDataAdapter; set => _objOracleDataAdapter = value; }
        public OracleCommand ObjOracleCommand1 { get => _objOracleCommand; set => _objOracleCommand = value; }
        public DataSet DsResultados1 { get => dsResultados; set => dsResultados = value; }
        public DataTable DtParametros1 { get => dtParametros; set => dtParametros = value; }

        #endregion

        #region Constructores

        public ClsDataBase()
        {
            this.Ruta_NomBD = "Data source=orcl; user id=ESTUDIANTE;password=123";
            this.DsResultados1 = new DataSet();
            this.DtParametros1 = new DataTable();    

        }
        #endregion


    

        #region metodos Publicos.




        public DataTable ejecutarProcedimientoCRUD(string procedureName, string[] paramNames, string[] valueNames)
        {
            DsResultados1.Tables.Clear();
            using (ObjOracleConnection = new OracleConnection(Ruta_NomBD))
            {
                ObjOracleConnection.Open();
                try
                {
                    ObjOracleCommand = new OracleCommand(procedureName, ObjOracleConnection);                  
                    for (int i = 0; i < paramNames.Length; i++)
                    {
                        ObjOracleCommand.Parameters.Add(paramNames[i], valueNames[i]);
                    }
                    ObjOracleCommand.CommandType = CommandType.StoredProcedure;


                    ObjOracleDataAdapter = new OracleDataAdapter();
                    ObjOracleDataAdapter.SelectCommand = ObjOracleCommand;
                    ObjOracleDataAdapter.Fill(DsResultados1);
                    return DsResultados1.Tables[0];

                }
                catch (Exception e)
                {
                    string procedure = procedureName;
                    string[] param = paramNames;
                    string[] valueName = valueNames;
                    return null;
                }
            }

        }

        public DataTable ejecutarProcedimientoMOSTRAR(string procedureName, string TipoProcedimiento)
        {
            DsResultados1.Tables.Clear();
            using (ObjOracleConnection = new OracleConnection(Ruta_NomBD))
            {
                ObjOracleConnection.Open();
                try
                {
                    ObjOracleCommand = new OracleCommand(procedureName, ObjOracleConnection);
                    ObjOracleCommand.Parameters.Add(new OracleParameter(TipoProcedimiento, OracleDbType.RefCursor, ParameterDirection.Output));
                        //TipoProcedimiento, OracleDbType.RefCursor, ParameterDirection.Output);
                    
                    ObjOracleCommand.CommandType = CommandType.StoredProcedure;


                    ObjOracleDataAdapter = new OracleDataAdapter();
                    ObjOracleDataAdapter.SelectCommand = ObjOracleCommand;
                    ObjOracleDataAdapter.Fill(DsResultados1);
                    return DsResultados1.Tables[0];

                }
                catch (Exception e)
                {
                    string procedure = procedureName;
                    string param = TipoProcedimiento;
     
                    return null;
                }
            }

        }

        // Nueva sobrecarga: procedimientos con parámetros IN y SYS_REFCURSOR
        public DataTable ejecutarProcedimientoMOSTRAR(string procedureName, string[] paramNames, object[] paramValues, string outputCursorName)
        {
            DsResultados1.Tables.Clear();
            using (ObjOracleConnection = new OracleConnection(Ruta_NomBD))
            {
                ObjOracleConnection.Open();
                try
                {
                    ObjOracleCommand = new OracleCommand(procedureName, ObjOracleConnection);
                    ObjOracleCommand.CommandType = CommandType.StoredProcedure;

                    // Agregar parámetros de entrada
                    for (int i = 0; i < paramNames.Length; i++)
                    {
                        ObjOracleCommand.Parameters.Add(paramNames[i], paramValues[i]);
                    }

                    // Agregar parámetro de salida tipo cursor
                    ObjOracleCommand.Parameters.Add(outputCursorName, OracleDbType.RefCursor, ParameterDirection.Output);

                    // Ejecutar
                    ObjOracleDataAdapter = new OracleDataAdapter();
                    ObjOracleDataAdapter.SelectCommand = ObjOracleCommand;
                    ObjOracleDataAdapter.Fill(DsResultados1);

                    return DsResultados1.Tables[0];
                }
                catch (Exception e)
                {                    
                    return null;
                }
            }
        }

        public int ejecutarProcedimientoScalar(string procedureName, string[] paramNames, object[] paramValues, string outputParamName)
        {
            using (ObjOracleConnection = new OracleConnection(Ruta_NomBD))
            {
                ObjOracleConnection.Open();
                try
                {
                    ObjOracleCommand = new OracleCommand(procedureName, ObjOracleConnection);
                    ObjOracleCommand.CommandType = CommandType.StoredProcedure;

                    // Param IN
                    for (int i = 0; i < paramNames.Length; i++)
                    {
                        ObjOracleCommand.Parameters.Add(paramNames[i], paramValues[i]);
                    }

                    // Param OUT
                    OracleParameter outputParam = new OracleParameter(outputParamName, OracleDbType.Int32);
                    outputParam.Direction = ParameterDirection.Output;
                    ObjOracleCommand.Parameters.Add(outputParam);

                    ObjOracleCommand.ExecuteNonQuery();

                    return Convert.ToInt32(outputParam.Value);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al ejecutar procedimiento scalar: " + ex.Message);
                    return -1;
                }
            }
        }
        public string ejecutarFuncionScalar(string functionName, string[] paramNames, object[] paramValues)
        {
            using (ObjOracleConnection = new OracleConnection(Ruta_NomBD))
            {
                ObjOracleConnection.Open();
                try
                {
                    string sql = $"SELECT {functionName}(:{string.Join(", :", paramNames)}) FROM DUAL";
                    ObjOracleCommand = new OracleCommand(sql, ObjOracleConnection);
                    ObjOracleCommand.CommandType = CommandType.Text;
                    for (int i = 0; i < paramNames.Length; i++)
                    {
                        ObjOracleCommand.Parameters.Add(paramNames[i], paramValues[i]);
                    }
                    object result = ObjOracleCommand.ExecuteScalar();
                    return result?.ToString() ?? "NO ENCONTRADO";
                }
                catch (Exception ex)
                {
                    return "ERROR: " + ex.Message;
                }
            }
        }
    }
    #endregion


}
