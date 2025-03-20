using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.MantVehiculos
{
    public class ClsMantVehiculos
    {
        public AccesoDatos.DataBase.ClsDataBase data;

        public ClsMantVehiculos()
        {
            this.data = new AccesoDatos.DataBase.ClsDataBase();
        }

        #region Métodos de Acceso

        // Mostrar Mantenimientos
        public DataTable MostrarMantenimiento()
        {
            string ProcedimientoBD = "PROCE_MANT_VEHICULOS.LISTAR_MANTENIMIENTOS";
            string TipoProcedimiento = "CUR_MANTENIMIENTOS";

            // Aquí puedes pasar un arreglo vacío o el arreglo de parámetros si el procedimiento requiere algún parámetro adicional
            return data.ejecutarProcedimientoMOSTRAR(ProcedimientoBD, TipoProcedimiento);
        }

        // Guardar Mantenimiento
        public DataTable GuardarMantenimiento(Entidad.ClsMantVehiculos NewMantenimiento)
        {
            string Procedimiento = "PROCE_MANT_VEHICULOS.AGREGAR_MANTENIMIENTO";

            return data.ejecutarProcedimientoCRUD(
                Procedimiento,
                new string[] { "pPlaca", "pMotivo", "pCosto" },
                new string[] {
                    NewMantenimiento.Placa_Vehiculo,
                    NewMantenimiento.Motivo_Mantenimiento,
                    NewMantenimiento.Costo_Mantenimiento.ToString()
                }
            );
        }

        // Eliminar Mantenimiento
        public DataTable EliminarMantenimiento(Entidad.ClsMantVehiculos NewMantenimiento)
        {
            string Procedimiento = "PROCE_MANT_VEHICULOS.ELIMINAR_MANTENIMIENTO";

            return data.ejecutarProcedimientoCRUD(
                Procedimiento,
                new string[] { "pIdMantenimiento" },
                new string[] { NewMantenimiento.Id_Mantenimiento.ToString() }
            );
        }

        // Editar Mantenimiento
        public DataTable EditarMantenimiento(Entidad.ClsMantVehiculos NewMantenimiento)
        {
            string Procedimiento = "PROCE_MANT_VEHICULOS.EDITAR_MANTENIMIENTO";

            return data.ejecutarProcedimientoCRUD(
                Procedimiento,
                new string[] { "pIdMantenimiento", "pPlaca", "pMotivo", "pCosto" },
                new string[] {
                    NewMantenimiento.Id_Mantenimiento.ToString(),
                    NewMantenimiento.Placa_Vehiculo,
                    NewMantenimiento.Motivo_Mantenimiento,
                    NewMantenimiento.Costo_Mantenimiento.ToString()
                }
            );
        }

        // Buscar Mantenimiento
        public DataTable BuscarMantenimiento(Entidad.ClsMantVehiculos NewMantenimiento)
        {
            string Procedimiento = "PROCE_MANT_VEHICULOS.BUSCAR_MANTENIMIENTO";

            return data.ejecutarProcedimientoCRUD(
                Procedimiento,
                new string[] { "pIdMantenimiento" },
                new string[] { NewMantenimiento.Id_Mantenimiento.ToString() }
            );
        }

        #endregion
    }
}
