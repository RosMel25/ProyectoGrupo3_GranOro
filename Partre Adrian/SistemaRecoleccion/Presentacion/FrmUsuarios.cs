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

namespace Presentacion
{
    public partial class FrmUsuarios : Form
    {
        DataTable dtINformacion = new DataTable();
        public LogicaNegocio.ClsUsuarioLN UserInfo;
        private bool Editar = false;

        public FrmUsuarios()
        {
            InitializeComponent();
            this.UserInfo = new LogicaNegocio.ClsUsuarioLN();
            dtINformacion.Columns.Add("Mensaje", typeof(string));
            Mostrar_Valores.DataSource = CargarUser();
            DiseñoGriew();
        }

        private void limpiarForm()
        {
            txtID.Clear();
            txtNombre.Clear();
            txtCEDULA.Clear();
            txtEMAIL.Clear();
            txtROL.Clear();
        }

        private DataTable CargarUser()
        {
            return UserInfo.MostrarUsuario();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            string cod = txtID.Text;
            string Nom = txtNombre.Text;
            string Cedula = txtCEDULA.Text;
            string Email = txtEMAIL.Text;
            string Rol = txtROL.Text;


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
                    if (cod.Equals("") || Nom.Equals("") || Cedula.Equals("") || Email.Equals("") || Rol.Equals(""))
                    {
                        MessageBox.Show("TODOS LOS ESPACIOS DEBEN ESTAR COMPLETOS", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int cod_ = int.Parse(cod);
                        UserInfo.GuardarUsuario(new Entidad.Usuarios.ClsUsuario { IdUsuario = cod_, Nombre = Nom, Cedula = Cedula, Email = Email, Rol = Rol });
                        MessageBox.Show("Finca Registrada", "Resultado de Ejecución", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limpiarForm();
                    }

                    Mostrar_Valores.DataSource = CargarUser();
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

                        UserInfo.EditarUsuario(new Entidad.Usuarios.ClsUsuario { IdUsuario = cod_, Nombre = Nom, Cedula = Cedula, Email = Email, Rol = Rol });
                        MessageBox.Show("Finca Actualizada", "Resultado de Ejecución", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limpiarForm();
                    }

                    Mostrar_Valores.DataSource = CargarUser();
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

                Datofila = Mostrar_Valores.CurrentRow.Cells["ID_USUARIO"].Value.ToString();
                Cod = int.Parse(Datofila);
                UserInfo.EliminarUsuario(new Entidad.Usuarios.ClsUsuario { IdUsuario = Cod });
                MessageBox.Show("Registro Eliminado", "Resultado de Ejecución", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Mostrar_Valores.DataSource = CargarUser();
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
                txtID.Text = Mostrar_Valores.CurrentRow.Cells["ID_USUARIO"].Value.ToString();
                txtNombre.Text = Mostrar_Valores.CurrentRow.Cells["NOMBRE_USUARIO"].Value.ToString();
                txtCEDULA.Text = Mostrar_Valores.CurrentRow.Cells["IDENTIFICACION"].Value.ToString();
                txtEMAIL.Text = Mostrar_Valores.CurrentRow.Cells["CORREO_USUARIO"].Value.ToString();
                txtROL.Text = Mostrar_Valores.CurrentRow.Cells["ROL_USUARIO"].Value.ToString();

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

    }
}
