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
            string Procedimiento = "PROCE_FINCAS.EDITAR_EMPLEADO";

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

        #endregion


    }
}
