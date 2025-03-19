using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class ClsMantVehiculos
    { 
  
            #region Atributos Privados

            private int _Id_Mantenimiento;
            private string _Placa_Vehiculo;
            private string _Motivo_Mantenimiento;
            private decimal _Costo_Mantenimiento;

            #endregion

            #region Atributos Públicos

            public int Id_Mantenimiento { get => _Id_Mantenimiento; set => _Id_Mantenimiento = value; }
            public string Placa_Vehiculo { get => _Placa_Vehiculo; set => _Placa_Vehiculo = value; }
            public string Motivo_Mantenimiento { get => _Motivo_Mantenimiento; set => _Motivo_Mantenimiento = value; }
            public decimal Costo_Mantenimiento { get => _Costo_Mantenimiento; set => _Costo_Mantenimiento = value; }

            #endregion
        }
    }



