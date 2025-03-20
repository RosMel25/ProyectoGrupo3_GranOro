using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class ClsPrecio
    {

        #region Atributos Privados

        private int _ID_Precio;
        private string _Nom_Categoria;
        private string _Tipo_Moneda;
        private double _Precio_Cajuela;
        private double _Precio_Cuartilo;


        #endregion



        #region Atributos Publicos

        public int ID_Precio { get => _ID_Precio; set => _ID_Precio = value; }
        public string Nom_Categoria { get => _Nom_Categoria; set => _Nom_Categoria = value; }
        public string Tipo_Moneda { get => _Tipo_Moneda; set => _Tipo_Moneda = value; }
        public double Precio_Cajuela { get => _Precio_Cajuela; set => _Precio_Cajuela = value; }
        public double Precio_Cuartilo { get => _Precio_Cuartilo; set => _Precio_Cuartilo = value; }



        #endregion
    }
}
