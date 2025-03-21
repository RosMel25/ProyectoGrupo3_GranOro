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

        private int _No_Activo;
        private string _Nombre_Equipo;
        private string _Tipo_Equipo;
        private string _Garantia_Equipo;
        private int _Id_Proveedor;
        private int _No_Finca;

        // Atributos de manejo en la base de datos.
        private string _MjsError;
        private string _ValorScalar;
        private DataTable _dtResulatados;

        #endregion


        #region Atributos Publicos

        public int No_Activo { get => _No_Activo; set => _No_Activo = value; }
        public string Nombre_Equipo { get => _Nombre_Equipo; set => _Nombre_Equipo = value; }
        public string Tipo_Equipo { get => _Tipo_Equipo; set => _Tipo_Equipo = value; }
        public string Garantia_Equipo { get => _Garantia_Equipo; set => _Garantia_Equipo = value; }
        public int Id_Proveedor { get => _Id_Proveedor; set => _Id_Proveedor = value; }
        public int No_Finca { get => _No_Finca; set => _No_Finca = value; }

        #endregion
    }
}
