using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Empleados
{
    public partial class FrmEmpleados : Form
    {
    DataTable dtResultado = new DataTable();
    public LogicaNegocio.EmpleadoLN.EmpleadoLN EmpleadoInfo;
    private bool Editar = false;

        public FrmEmpleados()
        {
            InitializeComponent();
            this.EmpleadoInfo = new LogicaNegocio.EmpleadoLN.EmpleadoLN();
            dtResultado.Columns.Add("Mensaje", typeof(string));
            Mostrar_Valores.DataSource = CargarEmpleado();
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
            txtIdFinca.Clear();
        }

        private DataTable CargarEmpleado()
        {
            return EmpleadoInfo.ObtenerEmpleados();
        }
        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string email = txtEmail.Text;
            string telefono = txtTelefono.Text;
            string salario = txtSalario.Text;
            string idPuesto = txtIdPuesto.Text;
            string idFinca = txtIdFinca.Text;

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

                    if (id.Equals("") || nombre.Equals ("") || apellido.Equals("") || email.Equals("") || telefono.Equals("") || salario.Equals("") || idPuesto.Equals("") || idFinca.Equals(""))
                    {
                        MessageBox.Show("Todos los campos deben estar completos", "Resultado de Ejecución", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int id_ = int.Parse(id);
                        EmpleadoInfo.AgregarEmpleado(new Entidad.ClsEmpleado { Id_Empleado = id_, Nom_Empleado = nombre, Ape_Empleado = apellido, Email_Empleado = email, Tel_Empleado = telefono, Sal_Empleado = salario, Id_Puesto_Empleado = idPuesto, No_Finca = idFinca });
                        MessageBox.Show("Empleado Registrado", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limpiarForm();
                    }

                    Mostrar_Valores.DataSource = CargarEmpleado();
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

                    if (id.Equals("") || nombre.Equals("") || apellido.Equals("") || email.Equals("") || telefono.Equals("") || salario.Equals("") || idPuesto.Equals("") || idFinca.Equals(""))
                    {
                        MessageBox.Show("Todos los espacios deben estar completos", "Resultado de Ejecución", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int id_ = int.Parse(id);
                        EmpleadoInfo.EditarEmpleado(new Entidad.ClsEmpleado { Id_Empleado = id_, Nom_Empleado = nombre, Ape_Empleado = apellido, Email_Empleado = email, Tel_Empleado = telefono, Sal_Empleado = salario, Id_Puesto_Empleado = idPuesto, No_Finca = idFinca });
                        MessageBox.Show("Empleado Actualizado", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limpiarForm();
                    }
                    Mostrar_Valores.DataSource = CargarEmpleado();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar los datos: " + ex, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            txtId.Enabled = false;

            if (Mostrar_Valores.SelectedRows.Count > 0)
            {
                Editar = true;
                txtId.Text = Mostrar_Valores.CurrentRow.Cells["ID_EMPLEADO"].Value.ToString();
                txtNombre.Text = Mostrar_Valores.CurrentRow.Cells["NOMBRE_EMPLEADO"].Value.ToString();
                txtApellido.Text = Mostrar_Valores.CurrentRow.Cells["APELLIDO_EMPLEADO"].Value.ToString();
                txtEmail.Text = Mostrar_Valores.CurrentRow.Cells["EMAIL"].Value.ToString();
                txtTelefono.Text = Mostrar_Valores.CurrentRow.Cells["TELEFONO"].Value.ToString();
                txtSalario.Text = Mostrar_Valores.CurrentRow.Cells["SALARIO"].Value.ToString();
                txtIdPuesto.Text = Mostrar_Valores.CurrentRow.Cells["ID_PUESTO"].Value.ToString();
                txtIdFinca.Text = Mostrar_Valores.CurrentRow.Cells["NO_FINCA"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro a editar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Mostrar_Valores.SelectedRows.Count > 0)
            {
                int id = int.Parse(Mostrar_Valores.CurrentRow.Cells["ID_EMPLEADO"].Value.ToString());

                try
                {
                    EmpleadoInfo.EliminarEmpleado(new Entidad.ClsEmpleado { Id_Empleado = id });
                    MessageBox.Show("Empleado eliminado", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mostrar_Valores.DataSource = CargarEmpleado();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }

        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBuscar.Text, out int id))
            {
                dtResultado = EmpleadoInfo.BuscarEmpleado(new Entidad.ClsEmpleado { Id_Empleado = id });

                if (dtResultado.Rows.Count > 0)
                {
                    Mostrar_Valores.DataSource = dtResultado;
                }
                else
                {
                    MessageBox.Show("No se encontró el puesto con ese ID");
                    Mostrar_Valores.DataSource = CargarEmpleado();
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número válido");
            }
        }

        private void btnBuscarSalarioAlto_Click_1(object sender, EventArgs e)
        {
            decimal salarioMin;
            if (decimal.TryParse(txtBuscarSalario.Text, out salarioMin))
                Mostrar_Valores.DataSource = EmpleadoInfo.ObtenerEmpleadosSalarioAlto(salarioMin);
            else
                MessageBox.Show("Ingrese un salario válido.");
        }

        private void btnContar_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdPuesto.Text, out int idPuesto))
            {
                int cantidad = EmpleadoInfo.ContarEmpleadosPorPuesto(idPuesto);
                MessageBox.Show($"Cantidad: {cantidad}");
            }
        }

        private void btnEliminarSalarioBajo_Click_1(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtSalario.Text, out decimal salarioLimite))
            {
                EmpleadoInfo.EliminarEmpleadosBajoSalario(salarioLimite);
                Mostrar_Valores.DataSource = EmpleadoInfo.ObtenerEmpleados();
            }
        }
        private void btnBuscarPorNombre_Click_1(object sender, EventArgs e)
        {
            string nombreBuscar = txtNombre.Text.Trim();
            Mostrar_Valores.DataSource = EmpleadoInfo.BuscarEmpleadosPorNombre(nombreBuscar);
        }

        private void btnTotalSalarios_Click_1(object sender, EventArgs e)
        {
            decimal total = EmpleadoInfo.ObtenerSalarioTotal();
            MessageBox.Show($"Salario total: ₡{total:N2}");
        }

        private void btnNombreCompleto_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtId.Text, out int id))
                MessageBox.Show("Nombre completo: " + EmpleadoInfo.ObtenerNombreCompletoPorID(id));
        }
        private void btnTotalPorFinca_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdFinca.Text, out int noFinca))
                MessageBox.Show($"Total por finca: {EmpleadoInfo.TotalEmpleadosPorFinca(noFinca)}");
        }
        private void btnCorreoInstitucional_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdCorreo.Text, out int id))
                MessageBox.Show("Correo institucional: " + EmpleadoInfo.TieneCorreoInstitucional(id));
        }
        private void btnContarRangoSalario_Click_1(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtSalarioMin.Text, out decimal min) &&
                decimal.TryParse(txtSalarioMax.Text, out decimal max))
                lblResultadoRango.Text = $"Total en rango: {EmpleadoInfo.ContarEmpleadosEnRango(min, max)}";
        }

        private void btnSalarioPromedio_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdPuesto.Text, out int idPuesto))
                MessageBox.Show($"Promedio: ₡{EmpleadoInfo.ObtenerSalarioPromedioPorPuesto(idPuesto):N2}");
        }
        private void btnListarEmails_Click_1(object sender, EventArgs e)
        {
            Mostrar_Valores.DataSource = EmpleadoInfo.ListarNombreEmailEmpleados();
        }
        private void btnMayorSalario_Click_1(object sender, EventArgs e)
        {
            Mostrar_Valores.DataSource = EmpleadoInfo.ObtenerEmpleadosMayorSalario();
        }
        private void btnVerContactos_Click_1(object sender, EventArgs e)
        {
            Mostrar_Valores.DataSource = EmpleadoInfo.ObtenerContactosDeEmpleados();
        }

        private void btnVerEmpleadosXPuesto_Click_1(object sender, EventArgs e)
        {
            Mostrar_Valores.DataSource = EmpleadoInfo.ObtenerEmpleadosPorPuesto();
        }

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

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }       

        private void txtBuscarSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
        private void FrmEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void lblResultadoRango_Click(object sender, EventArgs e)
        {

        }
    }
}