using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Recoleccion
{
    public class ClsRecolector
    {

        #region Atributos Privados

        private int _Identificacion;
        private string _Nom_Recolector;



        #endregion



        #region Atributos Publicos
        public int Identificacion { get => _Identificacion; set => _Identificacion = value; }
        public string Nom_Recolector { get => _Nom_Recolector; set => _Nom_Recolector = value; }



        #endregion
    }
}
