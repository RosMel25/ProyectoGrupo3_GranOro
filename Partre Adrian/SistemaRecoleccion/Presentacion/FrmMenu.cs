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

namespace Presentacion
{
    public partial class FrmMenu: Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        private void btnAbrirFinca_Click(object sender, EventArgs e)
        {
            FrmFincas fincaForm = new FrmFincas();
            fincaForm.TopMost = true;
            fincaForm.Show();
        }

        private void btnAbrirEmpleados_Click(object sender, EventArgs e)
        {            
            FrmEmpleados empleadosForm = new FrmEmpleados();
            empleadosForm.TopMost = true;
            empleadosForm.Show();
        }

        private void btnAbrirPuestos_Click(object sender, EventArgs e)
        {
            FrmPuestos puestosForm = new FrmPuestos();
            puestosForm.TopMost = true;
            puestosForm.Show();
        }

        private void btnAbrirEmpleados_Click_1(object sender, EventArgs e)
        {
            this.btnAbrirEmpleados.Click += new System.EventHandler(this.btnAbrirEmpleados_Click);

        }

        private void btnAbrirPuestos_Click_1(object sender, EventArgs e)
        {
            this.btnAbrirPuestos.Click += new System.EventHandler(this.btnAbrirPuestos_Click);

        }

        private void btnAbrirFinca_Click_1(object sender, EventArgs e)
        {
            this.btnAbrirFinca.Click += new System.EventHandler(this.btnAbrirFinca_Click);

        }
    }
}
