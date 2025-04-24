using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.Empleados;
using Presentacion.Puestos;
using Presentacion.Recoleccion;
using Presentacion.Vehiculos;

namespace Presentacion
{
    public partial class FrmMenu: Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
    
        private void btnAbrirFinca_Click_1(object sender, EventArgs e)
        {
            FrmLogin empleadosForm = new FrmLogin();
            empleadosForm.TopMost = true;
            empleadosForm.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FrmUsuarios USER = new FrmUsuarios();
            USER.TopMost = true;
            USER.Show();
        }
    }
}
