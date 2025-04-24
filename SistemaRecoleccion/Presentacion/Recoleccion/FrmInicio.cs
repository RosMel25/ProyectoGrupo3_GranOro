using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Recoleccion
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void BtnFinca_Click(object sender, EventArgs e)
        {
            FrmFincas formulario2 = new FrmFincas();

            // Mostrar Form2
            formulario2.Show();

            // Opcionalmente, ocultar Form1 si es necesario
            this.Hide();
        }

        private void BtnCorte_Click(object sender, EventArgs e)
        {
            Frm_Cortes formulario2 = new Frm_Cortes();

            // Mostrar Form2
            formulario2.Show();

            // Opcionalmente, ocultar Form1 si es necesario
            this.Hide();
        }

        private void BtnPrecio_Click(object sender, EventArgs e)
        {
            FrmPrecios formulario2 = new FrmPrecios();

            // Mostrar Form2
            formulario2.Show();

            // Opcionalmente, ocultar Form1 si es necesario
            this.Hide();
        }

        private void BtnRecolector_Click(object sender, EventArgs e)
        {
            FrmRecolector formulario2 = new FrmRecolector();

            // Mostrar Form2
            formulario2.Show();

            // Opcionalmente, ocultar Form1 si es necesario
            this.Hide();
        }

        private void BtnRecoleccion_Click(object sender, EventArgs e)
        {
            FrmRecolecion formulario2 = new FrmRecolecion();

            // Mostrar Form2
            formulario2.Show();

            // Opcionalmente, ocultar Form1 si es necesario
            this.Hide();
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            FrmReportes formulario2 = new FrmReportes();

            // Mostrar Form2
            formulario2.Show();

            // Opcionalmente, ocultar Form1 si es necesario
            this.Hide();
        }
    }
}
