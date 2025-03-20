using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Vehiculos
{
    public class ClsVehiculos
    {
        public AccesoDatos.DataBase.ClsDataBase data;

        public ClsVehiculos()
        {
            this.data = new AccesoDatos.DataBase.ClsDataBase();
        }

        #region Metodos de Acceso

        // Mostrar Vehículos
         public DataTable MostrarVehiculo()
        {
            string ProcedimientoBD = "PROCE_VEHICULOS.LISTAR_VEHICULOS";
            string TipoProcedimiento = "CUR_VEHICULOS";

            // Aquí puedes pasar un arreglo vacío o el arreglo de parámetros si el procedimiento requiere algún parámetro adicional
            return data.ejecutarProcedimientoMOSTRAR(ProcedimientoBD, TipoProcedimiento);
        }


        // Guardar Vehículo
        public DataTable GuardarVehiculo(Entidad.ClsVehiculos NewVehiculo)
        {
            string Procedimiento = "PROCE_VEHICULOS.AGREGAR_VEHICULO";

            return data.ejecutarProcedimientoCRUD(
                Procedimiento,
                new string[] { "pPlaca", "pMarca", "pModelo", "pValorFiscal", "pNoFinca", "pIdentificacionEmpleado", "pIdProveedor" },
                new string[] {
                NewVehiculo.Placa_Vehiculo,
                NewVehiculo.Marca_Vehiculo,
                NewVehiculo.Modelo_Vehiculo,
                NewVehiculo.Valor_Fiscal.ToString(),
                NewVehiculo.No_Finca.ToString(),
                NewVehiculo.Identificacion_Empleado.ToString(),
                NewVehiculo.Id_Proveedor.ToString()
                }
            );
        }

        // Eliminar Vehículo
        public DataTable EliminarVehiculo(Entidad.ClsVehiculos NewVehiculo)
        {
            string Procedimiento = "PROCE_VEHICULOS.ELIMINAR_VEHICULO";

            return data.ejecutarProcedimientoCRUD(
                Procedimiento,
                new string[] { "pPlaca" },
                new string[] { NewVehiculo.Placa_Vehiculo }
            );
        }

        // Editar Vehículo
        public DataTable EditarVehiculo(Entidad.ClsVehiculos NewVehiculo)
        {
            string Procedimiento = "PROCE_VEHICULOS.EDITAR_VEHICULO";

            return data.ejecutarProcedimientoCRUD(
                Procedimiento,
                new string[] { "pPlaca", "pMarca", "pModelo", "pValorFiscal", "pNoFinca", "pIdentificacionEmpleado", "pIdProveedor" },
                new string[] {
                NewVehiculo.Placa_Vehiculo,
                NewVehiculo.Marca_Vehiculo,
                NewVehiculo.Modelo_Vehiculo,
                NewVehiculo.Valor_Fiscal.ToString(),
                NewVehiculo.No_Finca.ToString(),
                NewVehiculo.Identificacion_Empleado.ToString(),
                NewVehiculo.Id_Proveedor.ToString()
                }
            );
        }

        // Buscar Vehículo
        public DataTable BuscarVehiculo(Entidad.ClsVehiculos NewVehiculo)
        {
            string Procedimiento = "PROCE_VEHICULOS.BUSCAR_VEHICULO";

            return data.ejecutarProcedimientoCRUD(
                Procedimiento,
                new string[] { "pPlaca" },
                new string[] { NewVehiculo.Placa_Vehiculo }
            );
        }

        #endregion

    }
}

