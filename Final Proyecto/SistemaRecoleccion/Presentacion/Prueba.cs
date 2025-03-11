using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Entidad.Usuarios;
using LogicaNegocio.Usuarios;

namespace Presentacion
{
    public partial class Prueba : Form
    {

        DataTable dtINformacion = new DataTable();
        public LogicaNegocio.FincaLN.FincaLN FincaInfo;

        public Prueba()
        {
            InitializeComponent();
           

        }

        private DataTable CargarFinca()
        {
            return FincaInfo.MostrarUsuarios();
        }


        private void btn_agregar_Click(object sender, EventArgs e)
        {

          
        }


    }
}
