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
using Entidad;
using LogicaNegocio.EmpleadoLN;
using System.Drawing.Text;

namespace Presentacion.Empleados
{
    public partial class FrmEmpleados: Form
    {
        private EmpleadoLN EmpleadoInfo;

        public bool Editar = false;
        private DataTable dtResultados;

        public FrmEmpleados()
        {
            InitializeComponent();
            this.EmpleadoInfo = new EmpleadoLN(); // Inicialización correcta
            dtResultados = new DataTable();
            dtResultados.Columns.Add("Mensaje", typeof(string));
            Mostrar_Valores.DataSource = CargarEmpleados();
        }
        private void limpiarForm()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            txtSalario.Clear();
            txtIdPuesto.Clear();
            txtNoFinca.Clear();
        }

        private DataTable CargarEmpleados()
        {
            DataTable dt = EmpleadoInfo.ObtenerEmpleados();
            if (dt == null) dt = new DataTable(); // Evita asignar un null
            return dt;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string email = txtEmail.Text;
            string telefono = txtTelefono.Text;
            string salario = txtSalario.Text;
            string idPuesto = txtIdPuesto.Text;
            string noFinca = txtNoFinca.Text;

            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(telefono) || string.IsNullOrWhiteSpace(salario) ||
                string.IsNullOrWhiteSpace(idPuesto) || string.IsNullOrWhiteSpace(noFinca))
            {
                MessageBox.Show("TODOS LOS CAMPOS DEBEN ESTAR COMPLETOS", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Formato de email incorrecto.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(telefono, @"^\d+$"))
            {
                MessageBox.Show("El teléfono debe contener solo números.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Editar)
            {
                try
                {
                    int idEmpleado = int.Parse(id);
                    decimal salarioEmpleado = decimal.Parse(salario);
                    int puesto = int.Parse(idPuesto);
                    int finca = int.Parse(noFinca);

                    EmpleadoInfo.AgregarEmpleado(idEmpleado, nombre, apellido, email, telefono, salarioEmpleado, puesto, finca);
                    MessageBox.Show("Empleado Registrado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limpiarForm();
                    Mostrar_Valores.DataSource = CargarEmpleados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    int idEmpleado = int.Parse(id);
                    decimal salarioEmpleado = decimal.Parse(salario);
                    int puesto = int.Parse(idPuesto);
                    int finca = int.Parse(noFinca);

                    EmpleadoInfo.ActualizarEmpleado(idEmpleado, nombre, apellido, email, telefono, salarioEmpleado, puesto, finca);
                    MessageBox.Show("Empleado Actualizado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limpiarForm();
                    Mostrar_Valores.DataSource = CargarEmpleados();
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
                string idEmpleado = Mostrar_Valores.CurrentRow.Cells["IDENTIFICACION_EMPLEADO"].Value.ToString();
                int id = int.Parse(idEmpleado);

                EmpleadoInfo.EliminarEmpleado(id);
                MessageBox.Show("Registro Eliminado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Mostrar_Valores.DataSource = CargarEmpleados();
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
                txtId.Text = Mostrar_Valores.CurrentRow.Cells["IDENTIFICACION_EMPLEADO"].Value.ToString();
                txtNombre.Text = Mostrar_Valores.CurrentRow.Cells["NOMBRE_EMPLEADO"].Value.ToString();
                txtApellido.Text = Mostrar_Valores.CurrentRow.Cells["APELLIDO_EMPLEADO"].Value.ToString();
                txtEmail.Text = Mostrar_Valores.CurrentRow.Cells["EMAIL"].Value.ToString();
                txtTelefono.Text = Mostrar_Valores.CurrentRow.Cells["TELEFONO"].Value.ToString();
                txtSalario.Text = Mostrar_Valores.CurrentRow.Cells["SALARIO"].Value.ToString();
                txtIdPuesto.Text = Mostrar_Valores.CurrentRow.Cells["ID_PUESTO"].Value.ToString();
                txtNoFinca.Text = Mostrar_Valores.CurrentRow.Cells["NO_FINCA"].Value.ToString();
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
                dtResultados = EmpleadoInfo.BuscarEmpleado(idBuscar);

                if (dtResultados.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró el empleado con el ID ingresado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mostrar_Valores.DataSource = CargarEmpleados();
                }
                else
                {
                    Mostrar_Valores.DataSource = dtResultados;
                }
            }
            else
            {
                MessageBox.Show("Ingrese un ID de empleado para buscar.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void Mostrar_Valores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
