using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class ClsEmpleado
    {
        #region Atributos Privados

        private int _Id_Empleado;
        private string _Nom_Empleado;
        private string _Ape_Empleado;
        private string _Email_Empleado;
        private string _Tel_Empleado;
        private string _Sal_Empleado;
        private string _Id_Puesto_Empleado;
        private string _No_Finca;

        #endregion


        #region Atributos Publicos

        public int Id_Empleado { get => _Id_Empleado; set => _Id_Empleado = value; }
        public string Nom_Empleado { get => _Nom_Empleado; set => _Nom_Empleado = value; }
        public string Ape_Empleado { get => _Ape_Empleado; set => _Ape_Empleado = value; }
        public string Email_Empleado { get => _Email_Empleado; set => _Email_Empleado = value; }
        public string Tel_Empleado { get => _Tel_Empleado; set => _Tel_Empleado = value; }
        public string Sal_Empleado { get => _Sal_Empleado; set => _Sal_Empleado = value; }
        public string No_Finca { get => _No_Finca; set => _No_Finca = value; }
        public string Id_Puesto_Empleado { get => _Id_Puesto_Empleado; set => _Id_Puesto_Empleado = value; }


        #endregion
    }
}