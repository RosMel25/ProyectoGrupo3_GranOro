using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio;
using LogicaNegocio.PuestoLN;
using Entidad;

namespace Presentacion.Puestos
{
    public partial class FrmPuestos: Form
    {
        private PuestoLN puestoLN = new PuestoLN();
        DataTable dtInformacion = new DataTable();
        public PuestoLN PuestoInfo;
        private bool Editar = false;
                
        public FrmPuestos()
        {
            InitializeComponent();
            this.PuestoInfo = new PuestoLN();
            dtInformacion.Columns.Add("Mensaje", typeof(string));
            Mostrar_Valores.DataSource = CargarPuesto();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvPuestos.DataSource = puestoLN.ObtenerPuestos();
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string nombre = txtNombre.Text;
            string minSalario = txtMinSalario.Text;
            string maxSalario = txtMaxSalario.Text;

            // Verificación de campos vacíos
            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(minSalario) || string.IsNullOrWhiteSpace(maxSalario))
            {
                MessageBox.Show("TODOS LOS CAMPOS DEBEN ESTAR COMPLETOS", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Guardar Nuevo Registro
            if (!Editar)
            {
                try
                {
                    int idPuesto = int.Parse(id);
                    decimal salarioMin = decimal.Parse(minSalario);
                    decimal salarioMax = decimal.Parse(maxSalario);

                    PuestoInfo.AgregarPuesto(idPuesto, nombre, salarioMin, salarioMax);
                    MessageBox.Show("Puesto Registrado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limpiarForm();
                    Mostrar_Valores.DataSource = CargarPuesto();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // Editar Registro Existente
            else
            {
                try
                {
                    int idPuesto = int.Parse(id);
                    decimal salarioMin = decimal.Parse(minSalario);
                    decimal salarioMax = decimal.Parse(maxSalario);

                    PuestoInfo.ActualizarPuesto(idPuesto, nombre, salarioMin, salarioMax);
                    MessageBox.Show("Puesto Actualizado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limpiarForm();
                    Mostrar_Valores.DataSource = CargarPuesto();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Mostrar_Valores.SelectedRows.Count > 0)
            {
                string idPuesto = Mostrar_Valores.CurrentRow.Cells["ID_PUESTO"].Value.ToString();
                int id = int.Parse(idPuesto);

                PuestoInfo.EliminarPuesto(id);
                MessageBox.Show("Registro Eliminado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Mostrar_Valores.DataSource = CargarPuesto();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro a eliminar", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (Mostrar_Valores.SelectedRows.Count > 0)
            {
                Editar = true;
                txtId.Text = Mostrar_Valores.CurrentRow.Cells["ID_PUESTO"].Value.ToString();
                txtNombre.Text = Mostrar_Valores.CurrentRow.Cells["NOMBRE_PUESTO"].Value.ToString();
                txtMinSalario.Text = Mostrar_Valores.CurrentRow.Cells["MIN_SALARIO"].Value.ToString();
                txtMaxSalario.Text = Mostrar_Valores.CurrentRow.Cells["MAX_SALARIO"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro a editar", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string datoBuscar = txtBuscar.Text;

            if (!string.IsNullOrWhiteSpace(datoBuscar))
            {
                int idBuscar = int.Parse(datoBuscar);
                dtInformacion = PuestoInfo.BuscarPuesto(idBuscar);

                if (dtInformacion.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró el puesto con el ID ingresado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mostrar_Valores.DataSource = CargarPuesto();
                }
                else
                {
                    Mostrar_Valores.DataSource = dtInformacion;
                }
            }
            else
            {
                MessageBox.Show("Ingrese un ID de puesto para buscar.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #region Validaciones y Diseños

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtId.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Por favor, ingrese solo números en el ID.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtId.Clear();
            }
        }

        private void txtMinSalario_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtMinSalario.Text, "^[0-9]+(\\.[0-9]{1,2})?$"))
            {
                MessageBox.Show("Por favor, ingrese un valor válido para el salario mínimo.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMinSalario.Clear();
            }
        }

        private void txtMaxSalario_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtMaxSalario.Text, "^[0-9]+(\\.[0-9]{1,2})?$"))
            {
                MessageBox.Show("Por favor, ingrese un valor válido para el salario máximo.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaxSalario.Clear();
            }
        }

        #endregion

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
