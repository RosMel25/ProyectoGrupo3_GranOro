using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Puestos
{
    public partial class FrmPuestos: Form
    {
        DataTable dtInformacion = new DataTable();
        public LogicaNegocio.PuestoLN.PuestoLN PuestoInfo;
        private bool Editar = false;        
                
        public FrmPuestos()
        {
            InitializeComponent();
            this.PuestoInfo = new LogicaNegocio.PuestoLN.PuestoLN();
            dtInformacion.Columns.Add("Mensaje", typeof(string));
            Mostrar_Valores.DataSource = CargarPuesto();
        }
        private void limpiarForm()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtMinSalario.Clear();
            txtMaxSalario.Clear();
        }        

        private DataTable CargarPuesto()
        {
            return PuestoInfo.ObtenerPuestos();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string nombre = txtNombre.Text;
            string minSalario = txtMinSalario.Text;
            string maxSalario = txtMaxSalario.Text;


            // Guardar Nuevo Registro
            if (Editar == false)
            {
                try
                {
                    if (!Regex.IsMatch(id, "^[0-9]+$"))
                    {
                        MessageBox.Show("Por favor, ingrese solo números.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtId.Text = "";

                    }
                    if (id.Equals("") || nombre.Equals("") || minSalario.Equals("") || maxSalario.Equals(""))
                    {
                        MessageBox.Show("TODOS LOS ESPACIOS DEBEN ESTAR COMPLETOS", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int id_ = int.Parse(id);
                        PuestoInfo.AgregarPuesto(new Entidad.ClsPuesto { Id_Puesto = id_, Nom_Puesto = nombre, MINSal_Puesto = minSalario, MAXSal_Puesto = maxSalario });
                        MessageBox.Show("Puesto Registrada", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limpiarForm();
                    }

                    Mostrar_Valores.DataSource = CargarPuesto();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar los datos por: " + ex);
                }
            }

            // Editar Registro Existente
            if (Editar == true)
            {
                txtId.Enabled = true;
                try
                {
                    if (!Regex.IsMatch(id, "^[0-9]+$"))
                    {
                        MessageBox.Show("Por favor, ingrese solo números.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtId.Text = "";
                    }
                    if (id.Equals("") || nombre.Equals("") || minSalario.Equals("") || maxSalario.Equals(""))
                    {
                        MessageBox.Show("TODOS LOS ESPACIOS DEBEN ESTAR COMPLETOS", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int id_ = int.Parse(id);
                        PuestoInfo.EditarPuesto(new Entidad.ClsPuesto { Id_Puesto = id_, Nom_Puesto = nombre, MINSal_Puesto = minSalario, MAXSal_Puesto = maxSalario });
                        MessageBox.Show("Finca Actualizada", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limpiarForm();
                    }

                    Mostrar_Valores.DataSource = CargarPuesto();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar los datos: " + ex, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (Mostrar_Valores.SelectedRows.Count > 0)
            {
                Editar = true;
                txtId.Text = Mostrar_Valores.CurrentRow.Cells["Id_Puesto"].Value.ToString();
                txtNombre.Text = Mostrar_Valores.CurrentRow.Cells["Nom_Puesto"].Value.ToString();
                txtMinSalario.Text = Mostrar_Valores.CurrentRow.Cells["MINSal_Puesto"].Value.ToString();
                txtMaxSalario.Text = Mostrar_Valores.CurrentRow.Cells["MAXSal_Puesto"].Value.ToString();
           
            }
            else
                MessageBox.Show("Debe seleccionar el registro a editar", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {         


            if (Mostrar_Valores.SelectedRows.Count > 0)
            {

                int id = int.Parse(Mostrar_Valores.CurrentRow.Cells["Id_Puesto"].Value.ToString());

                try
                {
                    PuestoInfo.EliminarPuesto(new Entidad.ClsPuesto { Id_Puesto = id });
                    MessageBox.Show("Registro eliminado con éxito", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mostrar_Valores.DataSource = CargarPuesto();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtBuscar.Text, out int id))
            {
                dtInformacion = PuestoInfo.BuscarPuesto(new Entidad.ClsPuesto { Id_Puesto = id });

                if (dtInformacion.Rows.Count > 0)
                {
                    Mostrar_Valores.DataSource = dtInformacion;
                }
                else
                {
                    MessageBox.Show("No se encontró el puesto con ese ID");
                    Mostrar_Valores.DataSource = CargarPuesto();
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número válido");
            }
        }

        private void btnAumentarSalario_Click_1(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtPorcentajeAumento.Text, out decimal porcentaje))
            {
                PuestoInfo.AumentarSalarioMaximo(porcentaje);
                MessageBox.Show("Salarios máximos actualizados");
                Mostrar_Valores.DataSource = CargarPuesto();
            }
            else
            {
                MessageBox.Show("Ingrese un porcentaje válido");
            }
        }

        private void btnUnificarSalarioMinimo_Click_1(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtSalarioUnificado.Text, out decimal salario))
            {
                PuestoInfo.UnificarSalarioMinimo(salario);
                MessageBox.Show("Salarios mínimos actualizados");
                Mostrar_Valores.DataSource = CargarPuesto();
            }
            else
            {
                MessageBox.Show("Ingrese un valor válido para el salario mínimo");
            }
        }

        private void btnVerPuestoConMuchosEmpleados_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtMinEmpleados.Text, out int cantidad))
            {
                Mostrar_Valores.DataSource = PuestoInfo.MostrarPuestosConMuchosEmpleados(cantidad);
            }
            else
            {
                MessageBox.Show("Ingrese un número válido para cantidad mínima de empleados");
            }
        }

        private void btnVerCantidadEmpleados_Click_1(object sender, EventArgs e)
        {
            DataTable resultado = PuestoInfo.ObtenerPuestosCantidad();

            if (resultado.Rows.Count > 0)
            {
                Mostrar_Valores.DataSource = resultado;
            }
            else
            {
                MessageBox.Show("No hay datos disponibles");
            }
        }

        #region Validaciones y Diseños

        private void Mostrar_Valores_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void txtId_TextChanged_1(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtId.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Por favor, ingrese solo números en el ID.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtId.Clear();
            }
        }

        private void txtMinSalario_TextChanged_1(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtMinSalario.Text, "^[0-9]+(\\.[0-9]{1,2})?$"))
            {
                MessageBox.Show("Por favor, ingrese un valor válido para el salario mínimo.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMinSalario.Clear();
            }
        }

        private void txtMaxSalario_TextChanged_1(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtMaxSalario.Text, "^[0-9]+(\\.[0-9]{1,2})?$"))
            {
                MessageBox.Show("Por favor, ingrese un valor válido para el salario máximo.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaxSalario.Clear();
            }
        }

        #endregion

        private void FrmPuestos_Load(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdPuesto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombrePuesto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPorcentajeAumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSalarioUnificado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMinEmpleados_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
