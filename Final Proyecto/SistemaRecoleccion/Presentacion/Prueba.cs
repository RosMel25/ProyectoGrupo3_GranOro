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
            this.FincaInfo = new LogicaNegocio.FincaLN.FincaLN();
            dtINformacion.Columns.Add("Mensaje", typeof(string));
            Mostrar_Valores.DataSource = CargarFinca();

        }

        private DataTable CargarFinca()
        {
            return FincaInfo.MostrarUsuarios();
        }


        private void btn_agregar_Click(object sender, EventArgs e)
        {

            int cod = int.Parse(txt_ID.Text);
            string Nom = txt_NOM.Text;
            string Tam = txt_TAM.Text;
            string Ubi = txt_UBI.Text;

            if (cod.Equals("") || Nom.Equals("") || Tam.Equals("") || Ubi.Equals("") )
            {
                MessageBox.Show("TODOS LOS ESPACIOS DEBEN ESTAR COMPLETOS");
            }
            else
            {
                FincaInfo.GuardarFinca(new Entidad.Finca.ClsFinca{ No_Finca = cod , Nom_Finca = Nom , Tam_Finca = Tam , Ubi_Finca = Ubi });
                MessageBox.Show("Finca Agregada con exito");
            }


            Mostrar_Valores.DataSource = CargarFinca();
        }


    }
}
