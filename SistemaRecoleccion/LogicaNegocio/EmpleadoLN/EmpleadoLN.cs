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

        #region Metodos de Acceso

        // Mostrar Usuarios
        public DataTable ObtenerEmpleados()
        {
            string Procedimiento = "PROCE_EMPLEADO.ListarEmpleado";
            string TipoProcedimiento = "CUR_EMPLEADOS";

            return data.ejecutarProcedimientoMOSTRAR(
                Procedimiento,
                TipoProcedimiento
                );
        }

        public DataTable AgregarEmpleado(Entidad.ClsEmpleado NewEmpleado)
        {

            if (string.IsNullOrWhiteSpace(NewEmpleado.Nom_Empleado.ToString()) || string.IsNullOrWhiteSpace(NewEmpleado.Ape_Empleado.ToString()))
            throw new ArgumentException("El nombre y apellido no pueden estar vacíos.");           

            string Procedimiento = "PROCE_EMPLEADO.AGREGAR_EMPLEADO";

            return data.ejecutarProcedimientoCRUD(
                Procedimiento,
                new string[] { "pID", "pNOMBRE", "pAPELLIDO", "pEMAIL", "pTELEFONO", "pSALARIO", "pIDPuesto", "pIDFinca" },
                new string[] { NewEmpleado.Id_Empleado.ToString(),
                    NewEmpleado.Nom_Empleado.ToString(), NewEmpleado.Ape_Empleado.ToString(),
                    NewEmpleado.Email_Empleado.ToString(), NewEmpleado.Tel_Empleado.ToString(),
                    NewEmpleado.Sal_Empleado.ToString(), NewEmpleado.No_Finca.ToString(), NewEmpleado.Id_Puesto_Empleado.ToString(),}

                );
        }
        public DataTable EditarEmpleado(Entidad.ClsEmpleado NewEmpleado)
        {
            string Procedimiento = "PROCE_EMPLEADO.EDITAR_EMPLEADO";

            return data.ejecutarProcedimientoCRUD(
               Procedimiento,
               new string[] { "pID", "pNOMBRE", "pAPELLIDO", "pEMAIL", "pTELEFONO", "pSALARIO", "pIDPuesto", "pIDFinca" },
               new string[] { NewEmpleado.Id_Empleado.ToString(),
                    NewEmpleado.Nom_Empleado.ToString(), NewEmpleado.Ape_Empleado.ToString(),
                    NewEmpleado.Email_Empleado.ToString(), NewEmpleado.Tel_Empleado.ToString(),
                    NewEmpleado.Sal_Empleado.ToString(), NewEmpleado.No_Finca.ToString(), NewEmpleado.Id_Puesto_Empleado.ToString(),}

               );

        }
        public DataTable EliminarEmpleado(Entidad.ClsEmpleado NewEmpleado)
        {
            string Procedimiento = "PROCE_EMPLEADO.ELIMINAR_EMPLEADO";

            return data.ejecutarProcedimientoCRUD(
               Procedimiento,
               new string[] { "pID"},
               new string[] { NewEmpleado.Id_Empleado.ToString() }

               );
        }

        public DataTable BuscarEmpleado(Entidad.ClsEmpleado NewEmpleado)
        {
            string Procedimiento = "PROCE_EMPLEADO.BUSCAR_EMPLEADO";

            return data.ejecutarProcedimientoCRUD(
                Procedimiento,
                new string[] { "pID" },
                new string[] { NewEmpleado.Id_Empleado.ToString() }

                );
        }

        public DataTable ObtenerEmpleadosSalarioAlto(decimal salarioMinimo)
        {
            string procedimiento = "PROCE_EMPLEADO.EMPLEADOS_SALARIO_ALTO";
            string cursorSalida = "cur_EMPLEADOS"; // este es el nombre exacto del parámetro OUT SYS_REFCURSOR en Oracle

            return data.ejecutarProcedimientoMOSTRAR(
                procedimiento,
                new string[] { "pSALARIO_MIN" },
                new object[] { salarioMinimo },
                cursorSalida
            );
        }

        public int ContarEmpleadosPorPuesto(int idPuesto)
        {
            string procedimiento = "PROCE_EMPLEADO.CONTAR_EMPLEADOS_POR_PUESTO";

            return data.ejecutarProcedimientoScalar(
                procedimiento,
                new string[] { "pID_PUESTO" },
                new object[] { idPuesto },
                "pCANTIDAD"
            );
        }

        public void EliminarEmpleadosBajoSalario(decimal salarioLimite)
        {
            string procedimiento = "PROCE_EMPLEADO.ELIMINAR_EMPLEADOS_BAJO_SALARIO";

            data.ejecutarProcedimientoCRUD(
                procedimiento,
                new string[] { "pSALARIO_LIMITE" },
                new string[] { salarioLimite.ToString() }
            );
        }

        public DataTable BuscarEmpleadosPorNombre(string nombre)
        {
            string procedimiento = "PROCE_EMPLEADO.BUSCAR_EMPLEADOS_NOMBRE";
            string cursor = "cur_EMPLEADOS";

            return data.ejecutarProcedimientoMOSTRAR(
                procedimiento,
                new string[] { "pNOMBRE" },
                new object[] { nombre },
                cursor
            );
        }

        public decimal ObtenerSalarioTotal()
        {
            string procedimiento = "obtener_salario_total_empleados"; // Nombre exacto de la función en Oracle
            string outputParam = "RETURN_VALUE"; // Nombre del parámetro OUT para obtener el resultado

            // Llama al método ya creado en ClsDataBase
            object resultado = data.ejecutarProcedimientoScalar(
                procedimiento,
                new string[] { },
                new object[] { },
                outputParam);

            if (resultado == null || resultado == DBNull.Value)
                return 0;
            else
                return Convert.ToDecimal(resultado);
        }

        public string ObtenerNombreCompletoPorID(int idEmpleado)
        {
            string procedimiento = "nombre_completo_empleado";

            try
            {
                return data.ejecutarFuncionScalar(procedimiento, new string[] { "p_id_empleado" }, new object[] { idEmpleado });
            }
            catch (Exception ex)
            {
                return "ERROR: " + ex.Message;
            }
        }
        public string TotalEmpleadosPorFinca(int noFinca)
        {
            string procedimiento = "total_empleados_por_finca";

            return data.ejecutarFuncionScalar(
                procedimiento,
                new string[] { "p_no_finca" },
                new object[] { noFinca }
            );
        }

        public string TieneCorreoInstitucional(int idEmpleado)
        {
            string funcion = "tiene_correo_institucional";

            return data.ejecutarFuncionScalar(
                funcion,
                new string[] { "p_id_empleado" },
                new object[] { idEmpleado }
            );
        }

        public int ContarEmpleadosEnRango(decimal salarioMin, decimal salarioMax)
        {
            string funcion = "contar_empleados_rango";

            string resultado = data.ejecutarFuncionScalar(
                funcion,
                new string[] { "p_min", "p_max" },
                new object[] { salarioMin, salarioMax }
            );

            // Intentamos convertir el resultado a entero
            return int.TryParse(resultado, out int total) ? total : 0;
        }

        public decimal ObtenerSalarioPromedioPorPuesto(int idPuesto)
        {
            string funcion = "obtener_salario_promedio_puesto";

            string resultado = data.ejecutarFuncionScalar(
                funcion,
                new string[] { "p_id_puesto" },
                new object[] { idPuesto }
            );

            return decimal.TryParse(resultado, out decimal promedio) ? promedio : 0;
        }

        public DataTable ListarNombreEmailEmpleados()
        {
            string procedimiento = "PROCE_EMPLEADO.LISTAR_EMP_EMAILS";
            string tipoCursor = "cur_empleados";

            return data.ejecutarProcedimientoMOSTRAR(procedimiento, tipoCursor);
        }

        public DataTable ObtenerEmpleadosMayorSalario()
        {
            string procedimiento = "PROCE_EMPLEADO.EMPLEADOS_MAYOR_SALARIO";

            return data.ejecutarProcedimientoMOSTRAR(
                procedimiento,
                new string[] { },                 // No hay parámetros IN
                new object[] { },
                "cur_empleados"                 // Nombre del parámetro OUT SYS_REFCURSOR
            );
        }

        public DataTable ObtenerContactosDeEmpleados()
        {
            string procedimiento = "PROCE_EMPLEADO.MOSTRAR_CONTACTO_EMPLEADOS";

            return data.ejecutarProcedimientoMOSTRAR(
                procedimiento,
                new string[] { },             // No parámetros IN
                new object[] { },
                "cur_contacto"                // Nombre del parámetro OUT en Oracle
            );
        }

        public DataTable ObtenerEmpleadosPorPuesto()
        {
            string procedimiento = "PROCE_EMPLEADO.EMPLEADOS_X_PUESTO";

            return data.ejecutarProcedimientoMOSTRAR(
                procedimiento,
                new string[] { },          // Sin parámetros IN
                new object[] { },
                "p_cursor"                 // Nombre del parámetro OUT (cursor)
            );
        }
















        #endregion


    }
}
