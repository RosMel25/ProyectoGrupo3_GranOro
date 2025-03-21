using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.InventarioFinca
{
    public class ClsInventarioFinca
    {
        #region Atributos Privados

        private int _Cod_Producto;
        private string _Nombre_Producto;
        private int _Cantidad_Producto;
        private int _No_Finca;
        private int _Id_Proveedor;

        // Atributos de manejo en la base de datos.
        private string _MjsError;
        private string _ValorScalar;
        private DataTable _dtResulatados;

        #endregion


        #region Atributos Publicos

        public int Cod_Producto { get => _Cod_Producto; set => _Cod_Producto = value; }
        public string Nombre_Producto { get => _Nombre_Producto; set => _Nombre_Producto = value; }
        public int Cantidad_Producto { get => _Cantidad_Producto; set => _Cantidad_Producto = value; }
        public int No_Finca { get => _No_Finca; set => _No_Finca = value; }
        public int Id_Proveedor { get => _Id_Proveedor; set => _Id_Proveedor = value; }


        #endregion

    }
}