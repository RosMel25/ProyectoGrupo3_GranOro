using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class ClsVehiculos
    {
        #region Atributos Privados

        private string _Placa_Vehiculo;
        private string _Marca_Vehiculo;
        private string _Modelo_Vehiculo;
        private decimal _Valor_Fiscal;
        private int _No_Finca;
        private int _Identificacion_Empleado;
        private int _Id_Proveedor;

        #endregion

        #region Atributos Publicos

        public string Placa_Vehiculo { get => _Placa_Vehiculo; set => _Placa_Vehiculo = value; }
        public string Marca_Vehiculo { get => _Marca_Vehiculo; set => _Marca_Vehiculo = value; }
        public string Modelo_Vehiculo { get => _Modelo_Vehiculo; set => _Modelo_Vehiculo = value; }
        public decimal Valor_Fiscal { get => _Valor_Fiscal; set => _Valor_Fiscal = value; }
        public int No_Finca { get => _No_Finca; set => _No_Finca = value; }
        public int Identificacion_Empleado { get => _Identificacion_Empleado; set => _Identificacion_Empleado = value; }
        public int Id_Proveedor { get => _Id_Proveedor; set => _Id_Proveedor = value; }

        #endregion
    }
}
