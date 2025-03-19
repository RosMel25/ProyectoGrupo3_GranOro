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
    public partial class FrmPrecios : Form
    {
        DataTable dtINformacion = new DataTable();
        public LogicaNegocio.RecoleccionLN.ClsPreciosLG PrecioInfo;
        private bool Editar = false;
        public FrmPrecios()
        {
            InitializeComponent();
            this.PrecioInfo = new LogicaNegocio.RecoleccionLN.ClsPreciosLG();
            dtINformacion.Columns.Add("Mensaje", typeof(string));
            Mostrar_Valores.DataSource = CargarPrecio();
            DiseñoGriew();
        }

        private void limpiarForm()
        {
            txtID.Clear();
            txtNombre.Clear();
            txtMONEDA.Clear();
            txtCAJUELA.Clear();
            txtCUARTILLO.Clear();
        }

        private DataTable CargarPrecio()
        {
            return PrecioInfo.MostrarPrecio();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string cod = txtID.Text;
            string Nom = txtNombre.Text;
            string Moneda = txtMONEDA.Text;
            string Caj = txtCAJUELA.Text;
            string Cuar = txtCUARTILLO.Text;


            // Guardar Nuevo Registro o editar existente
            if (Editar == false)
            {
                try
                {
                    if (!Regex.IsMatch(cod, "^[0-9]+$"))
                    {
                        MessageBox.Show("Por favor, ingrese solo números.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtID.Text = "";
                    }
                    if (cod.Equals("") || Nom.Equals("") || Moneda.Equals("") || Caj.Equals("") || Cuar.Equals(""))
                    {
                        MessageBox.Show("TODOS LOS ESPACIOS DEBEN ESTAR COMPLETOS", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int cod_ = int.Parse(cod);
                        int cajuela = int.Parse(Caj);
                        int cuartillo = int.Parse(Cuar);
                        PrecioInfo.GuardarPrecio(new Entidad.ClsPrecio { ID_Precio = cod_, Nom_Categoria = Nom, Tipo_Moneda = Moneda, Precio_Cajuela = cajuela, Precio_Cuartilo = cuartillo });
                        MessageBox.Show("Finca Registrada", "Resultado de Ejecución", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limpiarForm();
                    }

                    Mostrar_Valores.DataSource = CargarPrecio();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo insertar los datos por: " + ex);
                }
            }
            //EDITAR registro existente
            if (Editar == true)
            {

                txtID.Enabled = true;

                try
                {
                    if (!Regex.IsMatch(cod, "^[0-9]+$"))
                    {
                        MessageBox.Show("Por favor, ingrese solo números.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtID.Text = "";
                    }
                    if (cod.Equals("") || Nom.Equals(""))
                    {
                        MessageBox.Show("TODOS LOS ESPACIOS DEBEN ESTAR COMPLETOS", "Resultao de Ejecución", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int cod_ = int.Parse(cod);
                        int cajuela = int.Parse(Caj);
                        int cuartillo = int.Parse(Cuar);
                        PrecioInfo.EditarPrecio(new Entidad.ClsPrecio { ID_Precio = cod_, Nom_Categoria = Nom, Tipo_Moneda = Moneda, Precio_Cajuela = cajuela, Precio_Cuartilo = cuartillo });
                        MessageBox.Show("Finca Actualizada", "Resultado de Ejecución", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limpiarForm();
                    }

                    Mostrar_Valores.DataSource = CargarPrecio();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar los datos: " + ex, "Resultado de Ejecución", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string Datofila;
            int Cod;

            if (Mostrar_Valores.SelectedRows.Count > 0)
            {

                Datofila = Mostrar_Valores.CurrentRow.Cells["ID_PRECIO"].Value.ToString();
                Cod = int.Parse(Datofila);
                PrecioInfo.EliminarPrecio(new Entidad.ClsPrecio { ID_Precio = Cod });
                MessageBox.Show("Registro Eliminado", "Resultado de Ejecución", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Mostrar_Valores.DataSource = CargarPrecio();
            }
            else
                MessageBox.Show("Debe seleccionar el registro a eliminar", "Resultado de Ejecución", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtID.Enabled = false;

            if (Mostrar_Valores.SelectedRows.Count > 0)
            {
                Editar = true;
                txtID.Text = Mostrar_Valores.CurrentRow.Cells["ID_PRECIO"].Value.ToString();
                txtNombre.Text = Mostrar_Valores.CurrentRow.Cells["NOMBRE_CATEGORIA"].Value.ToString();
                txtMONEDA.Text = Mostrar_Valores.CurrentRow.Cells["TIPO_MONEDA"].Value.ToString();
                txtCAJUELA.Text = Mostrar_Valores.CurrentRow.Cells["VALOR_CAJUELA"].Value.ToString();
                txtCUARTILLO.Text = Mostrar_Valores.CurrentRow.Cells["VALOR_CUARTILLO"].Value.ToString();

            }
            else
                MessageBox.Show("Debe seleccionar el registro a editar", "Resultado de Ejecución", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void DiseñoGriew()
        {
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

        private void BtnCorte_Click(object sender, EventArgs e)
        {
            Frm_Cortes formulario2 = new Frm_Cortes();

            // Mostrar Form2
            formulario2.Show();
        }

        private void BtnFinca_Click(object sender, EventArgs e)
        {
            FrmFincas formulario2 = new FrmFincas();

            // Mostrar Form2
            formulario2.Show();
        }
    }
}
