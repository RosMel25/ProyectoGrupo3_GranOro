using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Recoleccion
{
    public partial class FrmFincas : Form
    {
        DataTable dtINformacion = new DataTable();
        public LogicaNegocio.FincaLN.FincaLN FincaInfo;
        private bool Editar = false;
        public FrmFincas()
        {
            InitializeComponent();
            this.FincaInfo = new LogicaNegocio.FincaLN.FincaLN();
            dtINformacion.Columns.Add("Mensaje", typeof(string));
            Mostrar_Valores.DataSource = CargarFinca();
        }

        private void limpiarForm()
        {
            txtNoFinca.Clear();
            txtNombre.Clear();
            txtTamaño.Clear();
            txtUbicacion.Clear();
        }
        private DataTable CargarFinca()
        {
            return FincaInfo.MostrarFinca();

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string cod = txtNoFinca.Text;
            string Nom = txtNombre.Text;
            string Tam = txtTamaño.Text;
            string Ubi = txtUbicacion.Text;


            // Guardar Nuevo Registro
            if (Editar == false)
            {
                try
                {
                    if (cod.Equals("") || Nom.Equals("") || Tam.Equals("") || Ubi.Equals(""))
                    {
                        MessageBox.Show("TODOS LOS ESPACIOS DEBEN ESTAR COMPLETOS", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int cod_ = int.Parse(cod);
                        FincaInfo.GuardarFinca(new Entidad.Finca.ClsFinca{ No_Finca = cod_, Nom_Finca = Nom, Tam_Finca = Tam, Ubi_Finca = Ubi });
                        MessageBox.Show("Finca Registrada", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limpiarForm();
                    }

                    Mostrar_Valores.DataSource = CargarFinca();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo insertar los datos por: " + ex);
                }
            }
            //EDITAR registro existente
            if (Editar == true)
            {

                try
                {
                    if (cod.Equals("") || Nom.Equals("") || Tam.Equals("") || Ubi.Equals(""))
                    {
                        MessageBox.Show("TODOS LOS ESPACIOS DEBEN ESTAR COMPLETOS", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int cod_ = int.Parse(cod);
                        FincaInfo.EditarFinca(new Entidad.Finca.ClsFinca { No_Finca = cod_, Nom_Finca = Nom, Tam_Finca = Tam, Ubi_Finca = Ubi });
                        MessageBox.Show("Finca Actualizada", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limpiarForm();
                    }

                    Mostrar_Valores.DataSource = CargarFinca();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar los datos: " + ex, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (Mostrar_Valores.SelectedRows.Count > 0)
            {
                Editar = true;
                txtNoFinca.Text = Mostrar_Valores.CurrentRow.Cells["NO_FINCA"].Value.ToString();
                txtNombre.Text = Mostrar_Valores.CurrentRow.Cells["NOMBRE_FINCA"].Value.ToString();
                txtTamaño.Text = Mostrar_Valores.CurrentRow.Cells["TAMAÑO_FINCA"].Value.ToString();
                txtUbicacion.Text = Mostrar_Valores.CurrentRow.Cells["UBICACION_FINCA"].Value.ToString();

            }
            else
                MessageBox.Show("Debe seleccionar el registro a editar", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string Datofila;
            int Cod;

            if (Mostrar_Valores.SelectedRows.Count > 0)
            {

                Datofila = Mostrar_Valores.CurrentRow.Cells["NO_FINCA"].Value.ToString();
                Cod = int.Parse(Datofila);
                FincaInfo.EliminarFinca(new Entidad.Finca.ClsFinca { No_Finca = Cod });
                MessageBox.Show("Registro Eliminado", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarFinca();
            }
            else
                MessageBox.Show("Debe seleccionar el registro a eliminar", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            string DatoBuscar = txtBuscar.Text;
            int Cod;

            if (DatoBuscar.Equals(""))
            {
                Cod = int.Parse(DatoBuscar);
                dtINformacion = FincaInfo.BuscarFinca(new Entidad.Finca.ClsFinca { No_Finca = Cod });

                if (dtINformacion.Rows.Count == 0)
                {
                    MessageBox.Show("El numero de finca no corresponde a ninguna de las dincas registradas", "Informacion incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarFinca();
                }
                else
                {
                    Mostrar_Valores.DataSource = dtINformacion;
                }
            }
            else
                MessageBox.Show("Debe seleccionar el registro a eliminar", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #region Validaciones
        private void Mostrar_Valores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Cambiar el fondo y el color de texto del encabezado
            Mostrar_Valores.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.Coral;
            Mostrar_Valores.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            Mostrar_Valores.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            Mostrar_Valores.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //Cambiar el fondo y el color de las celdas (Filas de datos)
            Mostrar_Valores.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            Mostrar_Valores.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            Mostrar_Valores.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8);

            // Cambiar el color de las filas alternas
            Mostrar_Valores.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.AliceBlue;

            // Establecer bordes
            Mostrar_Valores.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            Mostrar_Valores.BorderStyle = BorderStyle.Fixed3D;
        }

        private void txtNoFinca_TextChanged(object sender, EventArgs e)
        {
            string input = txtNoFinca.Text;
            if (!Regex.IsMatch(input, "^[0-9]+$"))
            {
                MessageBox.Show("Por favor, ingrese solo números.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNoFinca.Text = "";
            }
        }

        private void txtTamaño_TextChanged(object sender, EventArgs e)
        {
            string input = txtTamaño.Text;
            if (!Regex.IsMatch(input, "^[0-9]+$"))
            {
                MessageBox.Show("Por favor, ingrese solo números.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNoFinca.Text = "";
            }
        }

        #endregion
    }
}
