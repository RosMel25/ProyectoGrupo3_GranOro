using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.PuestoLN
{
    public class PuestoLN
    {
        public AccesoDatos.DataBase.ClsDataBase data;

        public PuestoLN()
        {
            this.data = new AccesoDatos.DataBase.ClsDataBase();
        }

        #region Metodos de Acceso

        // Mostrar Usuarios

        public DataTable ObtenerPuestos()
        {
            string Procedimiento = "PROCE_PUESTO.ListarPuesto";
            string TipoProcedimiento = "CUR_PUESTOS";

            return data.ejecutarProcedimientoMOSTRAR(
                Procedimiento,
                TipoProcedimiento
                );
        }

        public DataTable AgregarPuesto(Entidad.ClsPuesto NewPuesto)
        {

            string Procedimiento = "PROCE_PUESTO.AGREGAR_PUESTO";

            return data.ejecutarProcedimientoCRUD(
            Procedimiento,
            new string[] { "pID", "pNOMBRE_PUESTO", "pMIN_SALARIO", "pMAX_SALARIO" },
            new string[] { NewPuesto.Id_Puesto.ToString(),
                    NewPuesto.Nom_Puesto.ToString(), NewPuesto.MINSal_Puesto.ToString(),
                    NewPuesto.MAXSal_Puesto.ToString(), }

             );
        }
        public DataTable EditarPuesto(Entidad.ClsPuesto NewPuesto)
        {

            string Procedimiento = "PROCE_PUESTO.EDITAR_PUESTO";

            return data.ejecutarProcedimientoCRUD(
            Procedimiento,
            new string[] { "pID", "pNOMBRE_PUESTO", "pMIN_SALARIO", "pMAX_SALARIO" },
            new string[] { NewPuesto.Id_Puesto.ToString(),
                    NewPuesto.Nom_Puesto.ToString(), NewPuesto.MINSal_Puesto.ToString(),
                    NewPuesto.MAXSal_Puesto.ToString(), }

             );
        }

        public DataTable EliminarPuesto(Entidad.ClsPuesto NewPuesto)
        {
            string Procedimiento = "PROCE_PUESTO.ELIMINAR_PUESTO";

            return data.ejecutarProcedimientoCRUD(
                Procedimiento,
                new string[] { "pID"},
                new string[] { NewPuesto.Id_Puesto.ToString() }

            );
        }

        public DataTable BuscarPuesto(Entidad.ClsPuesto NewPuesto)
        {
            string Procedimiento = "PROCE_PUESTO.BUSCAR_PUESTO";

            return data.ejecutarProcedimientoCRUD(
                 Procedimiento,
                 new string[] { "pID" },
                 new string[] { NewPuesto.Id_Puesto.ToString() }

             );

        }

        public DataTable AumentarSalarioMaximo(decimal porcentaje)
        {
            string procedimiento = "PROCE_PUESTO.AUMENTAR_SALARIOS_MAXIMOS";

            return data.ejecutarProcedimientoCRUD(
                procedimiento,
                new string[] { "pPORCENTAJE" },
                new string[] { porcentaje.ToString() }
            );
        }

        public DataTable UnificarSalarioMinimo(decimal salario)
        {
            string procedimiento = "PROCE_PUESTO.UNIFICAR_SALARIOS_MINIMOS";

            return data.ejecutarProcedimientoCRUD(
                procedimiento,
                new string[] { "pSALARIO" },
                new string[] { salario.ToString() }
            );
        }

        public DataTable MostrarPuestosConMuchosEmpleados(int cantidadMinima)
        {
            string procedimiento = "PROCE_PUESTO.MOSTRAR_PUESTOS_CON_MUCHOS_EMPLEADOS";

            return data.ejecutarProcedimientoMOSTRAR(
                procedimiento,
                new string[] { "pMIN_CANTIDAD" },
                new object[] { cantidadMinima },
                "cur_PUESTOS"
            );
        }

        public DataTable ObtenerPuestosCantidad()
        {
            string procedimiento = "PROCE_PUESTO.MOSTRAR_PUESTOS_CANTIDAD";

            return data.ejecutarProcedimientoMOSTRAR(
                procedimiento,
                new string[] { },         // No parámetros IN
                new object[] { },
                "cur_puestos"            // Nombre del parámetro OUT
            );
        }







        #endregion
    }
}
