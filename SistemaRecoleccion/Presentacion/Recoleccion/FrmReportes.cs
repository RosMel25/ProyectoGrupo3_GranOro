using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad.Finca;
using Entidad.Recoleccion;

namespace Presentacion.Recoleccion
{
    public partial class FrmReportes : Form
    {
        DataTable dtINformacion = new DataTable();
        public LogicaNegocio.RecoleccionLN.ClsRecoleccionLN RecoleccionInfo;
        public LogicaNegocio.RecoleccionLN.ClsReporteLN ReporteInfo;

        string reporteG = "Reporte General de Recolección";
        string reporteGR = "Reporte General de Recolección por Recolector";
        string reporteR = "Reporte Diario por Recolector";

        public FrmReportes()
        {
            InitializeComponent();
            this.RecoleccionInfo = new LogicaNegocio.RecoleccionLN.ClsRecoleccionLN();
            this.ReporteInfo = new LogicaNegocio.RecoleccionLN.ClsReporteLN();
            dtINformacion.Columns.Add("Mensaje", typeof(string));
            ListarRecolector();
            ListarFinca();
        }

        #region ListarDatos
        private void ListarRecolector()
        {
            dtINformacion = RecoleccionInfo.VerRecolector();

            if (dtINformacion.Rows.Count == 0)
            {
                MessageBox.Show("Por favor registre un recolector", "No Hay Recolectores Registrados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmRecolector formulario2 = new FrmRecolector();

                // Mostrar Form2
                formulario2.Show();

                // Opcionalmente, ocultar Form1 si es necesario
                this.Hide();
            }
            else
            {
                cbRecolector.DataSource = dtINformacion;
                cbRecolector.DisplayMember = "Recolector";
                cbRecolector.ValueMember = "NOMBRE_RECOLECTOR";

            }

        }

        private void ListarFinca()
        {
            dtINformacion = RecoleccionInfo.VerFinca();

            if (dtINformacion.Rows.Count == 0)
            {
                MessageBox.Show("Por Favor registre una finca", "No Hay Fincas Registradas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmFincas formulario2 = new FrmFincas();

                // Mostrar Form2
                formulario2.Show();

                // Opcionalmente, ocultar Form1 si es necesario
                this.Hide();
            }
            else
            {
                cbFinca.DataSource = dtINformacion;
                cbFinca.DisplayMember = "Finca";
                cbFinca.ValueMember = "NOMBRE_FINCA";

            }

        }
        #endregion

        #region ExtraerValorCB
        public string cbFincarDATO()
        {
            string nombreSeleccionado;
            if (cbFinca.SelectedItem != null)
            {
                DataRowView fila = (DataRowView)cbFinca.SelectedItem;
                nombreSeleccionado = fila["NOMBRE_FINCA"].ToString();

                return nombreSeleccionado;
            }
            else
            {
                MessageBox.Show("No hay selección de Recolector");
                return nombreSeleccionado = "No funciono";
            }
        }

        public string cbRecolectorDATO()
        {
            string nombreSeleccionado;
            if (cbRecolector.SelectedItem != null)
            {
                DataRowView fila = (DataRowView)cbRecolector.SelectedItem;
                nombreSeleccionado = fila["NOMBRE_RECOLECTOR"].ToString();

                return nombreSeleccionado;
            }
            else
            {
                MessageBox.Show("No hay selección de Recolector");
                return nombreSeleccionado = "No funciono";
            }
        }
        #endregion


        #region validar datos
        private string ValidarRecolector()
        {
            string valorBuscado = cbRecolectorDATO();
            string cod;

            dtINformacion = RecoleccionInfo.VerRecolector();

            DataRow[] filas = dtINformacion.Select($"NOMBRE_RECOLECTOR = '{valorBuscado}'");

            if (filas.Length > 0)
            {
                DataRow fila = filas[0]; // Primera coincidencia
                cod = fila["IDENTIFICACION_RECOLECTOR"].ToString();

                return cod;

            }
            else
            {
                return cod = " Incorrecto ";
            }

        }

        private string Validarfinca()
        {
            string valorBuscado = cbFincarDATO();
            string cod;

            dtINformacion = RecoleccionInfo.VerFinca();

            DataRow[] filas = dtINformacion.Select($"NOMBRE_FINCA = '{valorBuscado}'");

            if (filas.Length > 0)
            {
                DataRow fila = filas[0]; // Primera coincidencia
                cod = fila["NO_FINCA"].ToString();

                return cod;

            }
            else
            {
                return cod = " Incorrecto ";
            }

        }
        #endregion

        #region MetodosReportes
        public DataTable ReporteGeneral(string F_incio, string F_final)
        {
            dtINformacion = ReporteInfo.ReporteGeneral(F_incio ,F_final);
            return dtINformacion;
        }
        public DataTable ReporteGeneralRecolector(string Codigo, string F_incio, string F_Final)
        {
            dtINformacion = ReporteInfo.ReporteGenerlaRecolector(Codigo, F_incio, F_Final);
            return dtINformacion;
        }

        public DataTable ReporteRecolector(string Cedula, string F_incio, string F_Final)
        {
            dtINformacion = ReporteInfo.ReporteRecolector(Cedula, F_incio, F_Final);
            return dtINformacion;
        }

        #endregion
        private void cbReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Inicio = dtpfecha_inicio.Value.ToString("dd/MM/yyyy"); ;
            string Final = dtpfecha_final.Value.ToString("dd/MM/yyyy");


            string Reporte = cbReporte.SelectedItem.ToString();

            if (Reporte == reporteG) 
            {
                dtINformacion = ReporteGeneral(Inicio,Final);

                if (dtINformacion.Rows.Count != 0)
                {
                    Mostrar_Valores.DataSource = dtINformacion;
                }
                else
                    MessageBox.Show("No hay Registros para Mostrar", "Resultado de Ejecución", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Reporte == reporteGR) 
            {
                string Finca = Validarfinca();
                dtINformacion = ReporteGeneralRecolector(Finca, Inicio, Final);

                if (dtINformacion.Rows.Count != 0)
                {
                    Mostrar_Valores.DataSource = dtINformacion;
                }
                else
                    MessageBox.Show("No hay Registros para Mostrar", "Resultado de Ejecución", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Reporte == reporteR)
            {
                string Recolector = ValidarRecolector();
                dtINformacion = ReporteRecolector(Recolector,Inicio, Final);

                if (dtINformacion.Rows.Count != 0)
                {
                    Mostrar_Valores.DataSource = dtINformacion;
                }
                else
                    MessageBox.Show("No hay Registros para Mostrar", "Resultado de Ejecución", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else{ MessageBox.Show("Debe Seleccionar un Reporte", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }


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

        private void Recoleccion_Click(object sender, EventArgs e)
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

        private void Logo_Click(object sender, EventArgs e)
        {
            FrmInicio formulario2 = new FrmInicio();

            // Mostrar Form2
            formulario2.Show();

            // Opcionalmente, ocultar Form1 si es necesario
            this.Hide();
        }
    }
}
