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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion.Empleados
{
    public partial class FrmEmpleados: Form
    {
        DataTable dtResultados = new DataTable();
        public LogicaNegocio.EmpleadoLN.EmpleadoLN EmpleadoInfo;
        private bool Editar = false;     

        public FrmEmpleados()
        {
            InitializeComponent();
            this.EmpleadoInfo = new LogicaNegocio.EmpleadoLN.EmpleadoLN();
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
            txtIdFinca.Clear();
        }

        private DataTable CargarEmpleados()
        {
            return EmpleadoInfo.ObtenerEmpleados();
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
            string idFinca = txtIdFinca.Text;

            //Guardar Nuevo Registro
            if (Editar == false)
            {
                try
                {
                    if (id.Equals("") || nombre.Equals("") || apellido.Equals("") || email.Equals("") || telefono.Equals("") || salario.Equals("") || idPuesto.Equals("") || idFinca.Equals(""))
                    {
                        MessageBox.Show("TODOS LOS ESPACIOS DEBEN ESTAR COMPLETOS", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int id_ = int.Parse(id);
                        EmpleadoInfo.AgregarEmpleado(NewEmpleado: new Entidad.ClsEmpleado { Id_Empleado = id_, Nom_Empleado = nombre, Ape_Empleado = apellido, Email_Empleado = email, Tel_Empleado = telefono, Sal_Empleado = salario, No_Finca = idFinca,Id_Puesto_Empleado = idPuesto });
                        MessageBox.Show("Empleado Registrado", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limpiarForm();
            Mostrar_Valores.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.AliceBlue;

                    Mostrar_Valores.DataSource = CargarEmpleados();
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
                    if (id.Equals("") || nombre.Equals("") || apellido.Equals("") || email.Equals("") || telefono.Equals("") || salario.Equals("") || idPuesto.Equals("") || idFinca.Equals(""))
                    {
                        MessageBox.Show("TODOS LOS ESPACIOS DEBEN ESTAR COMPLETOS", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int id_ = int.Parse(id);
                        EmpleadoInfo.EditarEmpleado(new Entidad.ClsEmpleado { Id_Empleado = id_, Nom_Empleado = nombre, Ape_Empleado = apellido, Email_Empleado = email, Tel_Empleado = telefono, Sal_Empleado = salario, No_Finca = idFinca, Id_Puesto_Empleado = idPuesto });
                        MessageBox.Show("Finca Actualizada", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limpiarForm();
                    }

                    Mostrar_Valores.DataSource = CargarEmpleados();
                    Editar = false;
                }
                catch (Exception ex)
                {


        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (Mostrar_Valores.SelectedRows.Count > 0)
            {
                Editar = true;
                txtId.Text = Mostrar_Valores.CurrentRow.Cells["Id_Empleado"].Value.ToString();
                txtNombre.Text = Mostrar_Valores.CurrentRow.Cells["Nom_Empleado"].Value.ToString();
                txtApellido.Text = Mostrar_Valores.CurrentRow.Cells["Ape_Empleado"].Value.ToString();
                txtEmail.Text = Mostrar_Valores.CurrentRow.Cells["mail_Empleado"].Value.ToString();
                txtTelefono.Text = Mostrar_Valores.CurrentRow.Cells["Tel_Empleado"].Value.ToString();
                txtSalario.Text = Mostrar_Valores.CurrentRow.Cells["Sal_Empleado"].Value.ToString();
                txtIdPuesto.Text = Mostrar_Valores.CurrentRow.Cells["No_Finca"].Value.ToString();
                txtIdFinca.Text = Mostrar_Valores.CurrentRow.Cells["Id_Puesto_Empleado"].Value.ToString();
            }

            else
                MessageBox.Show("Debe seleccionar el registro a editar", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string Datofila;
            int Id;

            if (Mostrar_Valores.SelectedRows.Count > 0)
            {

                Datofila = Mostrar_Valores.CurrentRow.Cells["Id_Empleado"].Value.ToString();
                Id = int.Parse(Datofila);
                EmpleadoInfo.EliminarEmpleado(new Entidad.ClsEmpleado { Id_Empleado = Id });
                MessageBox.Show("Registro Eliminado", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarEmpleados();
            }
            else
                MessageBox.Show("Debe seleccionar el registro a eliminar", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string DatoBuscar = txtBuscar.Text;
            int Id;

            if (DatoBuscar.Equals(""))
            {
                Id = int.Parse(DatoBuscar);
                dtResultados = EmpleadoInfo.BuscarEmpleado(new Entidad.ClsEmpleado{ Id_Empleado = Id });

                if (dtResultados.Rows.Count == 0)
                {
                    MessageBox.Show("El numero de finca no corresponde a ninguna de las dincas registradas", "Informacion incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarEmpleados();
                }
                else
                {
                    Mostrar_Valores.DataSource = dtResultados;
                }
            }
            else
                MessageBox.Show("Debe seleccionar el registro a eliminar", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
