using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Recoleccion
{
    public class ClsRecolecion
    {
        #region Atributos Privados

        private int _Id_Recoleccion;
        private string _Id_Recolector;
        private int _No_Finca;
        private int _Id_Corte;
        private string _Fecha_Recoleccion;
        private int _Cajuelas;
        private int _Cuartillos;
        private int _Id_Precio;
        private double _Precio_Total;


        #endregion



        #region Atributos Publicos

        public string Id_Recolector { get => _Id_Recolector; set => _Id_Recolector = value; }
        public int No_Finca { get => _No_Finca; set => _No_Finca = value; }
        public int Id_Corte { get => _Id_Corte; set => _Id_Corte = value; }
        public string Fecha_Recoleccion { get => _Fecha_Recoleccion; set => _Fecha_Recoleccion = value; }
        public int Cajuelas { get => _Cajuelas; set => _Cajuelas = value; }
        public int Cuartillos { get => _Cuartillos; set => _Cuartillos = value; }
        public double Precio_Total { get => _Precio_Total; set => _Precio_Total = value; }
        public int Id_Precio { get => _Id_Precio; set => _Id_Precio = value; }
        public int Id_Recoleccion { get => _Id_Recoleccion; set => _Id_Recoleccion = value; }

        #endregion

    }
}
