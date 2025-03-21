using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.InventarioLN
{
    public class ClsInventarioFincaLN
    {
        public AccesoDatos.DataBase.ClsDataBase data;

        public ClsInventarioFincaLN()
        {
            this.data = new AccesoDatos.DataBase.ClsDataBase();
        }


        #region Metodos de Acceso


        public DataTable GuardarProducto(Entidad.ClsInventarioFinca NewInventario)
        {
            string Procedimiento = "PROCE_Inventario_Finca.Agregar_Producto";

            return data.ejecutarProcedimientoCRUD(
                Procedimiento,
                new string[] {"pCod_Producto", "pNombre_Producto", "pCantidad_Producto", "pNo_Finca", "pId_Proveedor"},
                new string[] {NewInventario.Cod_Producto.ToString(),
                    NewInventario.Nombre_Producto.ToString(),
                    NewInventario.Cantidad_Producto.ToString(),
                    NewInventario.No_Finca.ToString(),
                    NewInventario.Id_Proveedor.ToString()}

                );
        }

        public DataTable BuscarProducto(Entidad.ClsInventarioFinca NewInventario)
        {
            string Procedimiento = "PROCE_Inventario_Finca.Buscar_Producto";

            return data.ejecutarProcedimientoCRUD(
                Procedimiento,
                new string[] { "pCod_Producto" },
                new string[] { NewInventario.Cod_Producto.ToString() }

                );
        }

        public DataTable EditarProducto(Entidad.ClsInventarioFinca NewInventario)
        {
            string Procedimiento = "PROCE_Inventario_Finca.Editar_Producto";

            return data.ejecutarProcedimientoCRUD(
                Procedimiento,
                new string[] { "pCod_Producto", "pNombre_Producto", "pCantidad_Producto", "pNo_Finca", "pId_Proveedor" },
                new string[] {NewInventario.Cod_Producto.ToString(),
                    NewInventario.Nombre_Producto.ToString(),
                    NewInventario.Cantidad_Producto.ToString(),
                    NewInventario.No_Finca.ToString(),
                    NewInventario.Id_Proveedor.ToString()}

                );
        }

        public DataTable EliminarProducto(Entidad.ClsInventarioFinca NewInventario)
        {
            string Procedimiento = "PROCE_Inventario_Finca.Eliminar_Producto";

            return data.ejecutarProcedimientoCRUD(
                Procedimiento,
                new string[] { "pCod_Producto" },
                new string[] { NewInventario.Cod_Producto.ToString() }

                );
        }

        

        

        #endregion
    }
}
