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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private void btnGuardar_Click(object sender, EventArgs e)
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
                    MessageBox.Show("no se pudo insertar los datos por: " + ex);
                }
            }

            // Editar Registro Existente
            if (Editar == true)
            {
                try
                {
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (Mostrar_Valores.SelectedRows.Count > 0)
            {
                Editar = true;
                txtId.Text = Mostrar_Valores.CurrentRow.Cells["Id_Puesto"].Value.ToString();
                txtNombre.Text = Mostrar_Valores.CurrentRow.Cells["Nom_Puesto"].Value.ToString();
                txtMinSalario.Text = Mostrar_Valores.CurrentRow.Cells["MINSal_Puesto"].Value.ToString();
                txtMaxSalario.Text = Mostrar_Valores.CurrentRow.Cells["AXSal_Puesto"].Value.ToString();

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

                Datofila = Mostrar_Valores.CurrentRow.Cells["Id_Puesto"].Value.ToString();
                Id = int.Parse(Datofila);
                PuestoInfo.EliminarPuesto(new Entidad.ClsPuesto { Id_Puesto = Id });
                MessageBox.Show("Registro Eliminado", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarPuesto();
            }
            else
                MessageBox.Show("Debe seleccionar el registro a eliminar", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            string DatoBuscar = txtBuscar.Text;
            int Id;

            if (DatoBuscar.Equals(""))
            {
                Id = int.Parse(DatoBuscar);
                dtInformacion = PuestoInfo.BuscarPuesto(new Entidad.ClsPuesto { Id_Puesto = Id });

                if (dtInformacion.Rows.Count == 0)
                {
                    MessageBox.Show("El numero de finca no corresponde a ninguna de las dincas registradas", "Informacion incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarPuesto();
                }
                else
                {
                    Mostrar_Valores.DataSource = dtInformacion;
                }
            }
            else
                MessageBox.Show("Debe seleccionar el registro a eliminar", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
