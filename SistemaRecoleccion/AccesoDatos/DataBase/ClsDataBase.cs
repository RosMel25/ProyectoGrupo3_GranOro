using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

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


        public DataTable ejecutarProcedimiento_BUSQUEDA(string procedureName, string[] paramNames, string[] valueNames, string Cursor)
        {
            DsResultados1.Tables.Clear();
            using (ObjOracleConnection = new OracleConnection(Ruta_NomBD))
            {
                ObjOracleConnection.Open();
                try
                {
                    using (ObjOracleCommand = new OracleCommand(procedureName, ObjOracleConnection))
                    {
                        ObjOracleCommand.CommandType = CommandType.StoredProcedure;

                        for (int i = 0; i < paramNames.Length; i++)
                        {
                            ObjOracleCommand.Parameters.Add(paramNames[i], valueNames[i]);
                        }

                        OracleParameter output = ObjOracleCommand.Parameters.Add(Cursor, OracleDbType.RefCursor);
                        output.Direction = ParameterDirection.Output;

                        ObjOracleDataAdapter = new OracleDataAdapter();
                        ObjOracleDataAdapter.SelectCommand = ObjOracleCommand;
                        ObjOracleDataAdapter.Fill(DsResultados1);
                        return DsResultados1.Tables[0];
                    }


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


        public int ejecutarProcedimientoValidar(string procedureName, string paramNames, string valueNames)
        {
            decimal resultado = 0;
            int datos=0;


            using (ObjOracleConnection = new OracleConnection(Ruta_NomBD))
            {
                ObjOracleConnection.Open();

                using (ObjOracleCommand = new OracleCommand(procedureName, ObjOracleConnection))
                {
                    ObjOracleCommand.CommandType = System.Data.CommandType.StoredProcedure;

                    ObjOracleCommand.Parameters.Add(paramNames, OracleDbType.Int32).Value = int.Parse(valueNames);

                    // Parámetro de salida: nombre del empleado
                   ObjOracleCommand.Parameters.Add("return_value", OracleDbType.Decimal).Direction = System.Data.ParameterDirection.ReturnValue;

                    // Ejecutar el comando
                    ObjOracleCommand.ExecuteNonQuery();

                    // Obtener el valor de retorno

                    resultado = Convert.ToDecimal(ObjOracleCommand.Parameters["return_value"].Value);

                    datos = (int)resultado;

                    return datos;
                }
            }

        }


        #endregion


    }
}
