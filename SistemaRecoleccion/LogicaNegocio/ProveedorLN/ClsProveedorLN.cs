using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.ProveedorLN
{
    public class ClsProveedorLN
    {
        public AccesoDatos.DataBase.ClsDataBase data;

        public ClsProveedorLN()
        {
            this.data = new AccesoDatos.DataBase.ClsDataBase();
        }


        #region Metodos de Acceso


        

        public DataTable GuardarProveedor(Entidad.ClsProveedor NewProveedor)
        {
            string Procedimiento = "PROCE_Proveedores.Agregar_Proveedor";

            return data.ejecutarProcedimientoCRUD(
                Procedimiento,
                new string[] { "pId_Proveedor", "pNombre_Proveedor", "pUbicacion_Proveedor", "pTelefonoProveedor", "pEmail_Proveedor" },
                new string[] {NewProveedor.Id_Proveedor.ToString(),
                    NewProveedor.Nombre_Proveedor.ToString(),
                    NewProveedor.Ubicacion_Proveedor.ToString(),
                    NewProveedor.Telefono_Proveedor.ToString(),
                    NewProveedor.Email_Proveedor.ToString()}

                );
        }

        public DataTable BuscarProveedor(Entidad.ClsProveedor NewProveedor)
        {
            string Procedimiento = "PROCE_Proveedores.Buscar_Proveedor";

            return data.ejecutarProcedimientoCRUD(
                Procedimiento,
                new string[] { "pId_Proveedor" },
                new string[] { NewProveedor.Id_Proveedor.ToString() }

                );
        }

        public DataTable EditarProveedor(Entidad.ClsProveedor NewProveedor)
        {
            string Procedimiento = "PROCE_Proveedores.Editar_Proveedor";

            return data.ejecutarProcedimientoCRUD(
                Procedimiento,
                new string[] { "pId_Proveedor", "pNombre_Proveedor", "pUbicacion_Proveedor", "pTelefonoProveedor", "pEmail_Proveedor" },
                new string[] {NewProveedor.Id_Proveedor.ToString(),
                    NewProveedor.Nombre_Proveedor.ToString(),
                    NewProveedor.Ubicacion_Proveedor.ToString(),
                    NewProveedor.Telefono_Proveedor.ToString(),
                    NewProveedor.Email_Proveedor.ToString()}

                );
        }

        public DataTable EliminarProveedor(Entidad.ClsProveedor NewProveedor)
        {
            string Procedimiento = "PROCE_Proveedores.Eliminar_Proveedor";

            return data.ejecutarProcedimientoCRUD(
                Procedimiento,
                new string[] { "pId_Proveedor" },
                new string[] { NewProveedor.Id_Proveedor.ToString() }

                );
        }
                

        #endregion
    }
}
