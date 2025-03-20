using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class ClsPuesto
    {
        #region Atributos Privados

        private int _Id_Puesto;
        private string _Nom_Puesto;
        private string _MINSal_Puesto;
        private string _MAXSal_Puesto;

        #endregion

        #region Atributos Publicos
        public int Id_Puesto { get => _Id_Puesto; set => _Id_Puesto = value; }
        public string Nom_Puesto { get => _Nom_Puesto; set => _Nom_Puesto = value; }
        public string MINSal_Puesto { get => _MINSal_Puesto; set => _MINSal_Puesto = value; }
        public string MAXSal_Puesto { get => _MAXSal_Puesto; set => _MAXSal_Puesto = value; }

        #endregion
    }
}
