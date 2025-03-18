using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Usuarios
{
    public class ClsUsuario
    {
        #region Atributos Privados

        private int _idUsuario;
        private string _Nombre;
        private string _Cedula;
        private string _Email;
        private string _Rol;


        #endregion


        #region Atributos Publicos

        public int IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Cedula { get => _Cedula; set => _Cedula = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Rol { get => _Rol; set => _Rol = value; }

        #endregion













    }
}
