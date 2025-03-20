using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class ClsCorte
    {

        #region Atributos Privados

        private int _ID_Corte;
        private string _Nom_Corte;
        private string _NO_Finca;


        #endregion



        #region Atributos Publicos

        public int ID_Corte { get => _ID_Corte; set => _ID_Corte = value; }
        public string Nom_Corte { get => _Nom_Corte; set => _Nom_Corte = value; }
        public string NO_Finca { get => _NO_Finca; set => _NO_Finca = value; }



        #endregion





    }
}
