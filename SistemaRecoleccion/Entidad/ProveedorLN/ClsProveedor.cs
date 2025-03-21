using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Proveedor
{
    public class ClsProveedor
    {
        #region Atributos Privados

        private int _Id_Proveedor;
        private string _Nombre_Proveedor;
        private string _Ubicacion_Proveedor;
        private string _Telefono_Proveedor;
        private string _Email_Proveedor;

        // Atributos de manejo en la base de datos.
        private string _MjsError;
        private string _ValorScalar;
        private DataTable _dtResulatados;

        #endregion


        #region Atributos Publicos

        public int Id_Proveedor { get => _Id_Proveedor; set => _Id_Proveedor = value; }
        public string Nombre_Proveedor { get => _Nombre_Proveedor; set => _Nombre_Proveedor = value; }
        public string Ubicacion_Proveedor { get => _Ubicacion_Proveedor; set => _Ubicacion_Proveedor = value; }
        public string Telefono_Proveedor { get => _Telefono_Proveedor; set => _Telefono_Proveedor = value; }
        public string Email_Proveedor { get => _Email_Proveedor; set => _Email_Proveedor = value; }


        #endregion
    }
}
