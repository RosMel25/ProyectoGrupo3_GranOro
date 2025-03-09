using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Usuarios
{
    public class ClsFinca
    {
        #region Atributos Privados

        private int _idUsuario;
        private string _Cedula;
        private string _Nombre;
        private string _Rol;

        // Atributos de manejo en la base de datos.
        private string _MjsError;
        private string _ValorScalar;
        private DataTable _dtResulatados;
        #endregion


        #region Atributos Publicos

        public int IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public string Cedula { get => _Cedula; set => _Cedula = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Rol { get => _Rol; set => _Rol = value; }
        public string MjsError { get => _MjsError; set => _MjsError = value; }
        public string ValorScalar { get => _ValorScalar; set => _ValorScalar = value; }
        public DataTable DtResulatados { get => _dtResulatados; set => _dtResulatados = value; }

        #endregion













    }
}
