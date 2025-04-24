using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.Recoleccion;

namespace Presentacion
{
    public partial class FrmLogin : Form
    {
        DataTable dtINformacion = new DataTable();
        public LogicaNegocio.ClsUsuarioLN UserInfo;
        private bool Editar = false;

        public FrmLogin()
        {
            InitializeComponent();
            this.UserInfo = new LogicaNegocio.ClsUsuarioLN();
            dtINformacion.Columns.Add("Mensaje", typeof(string));
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text; 
            string contra = txtContra.Text;

            dtINformacion = UserInfo.VALIDAR_USER(user,contra);


            if (dtINformacion == null)
            {
                MessageBox.Show("Usuario o Contraseña Incorrecto", "Error de Verificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUser.Clear();
                txtContra.Clear();  
            }
            else
            {
                FrmInicio formulario2 = new FrmInicio();

                // Mostrar Form2
                formulario2.Show();

                // Opcionalmente, ocultar Form1 si es necesario
                this.Hide();
            }
        }
    }
}
