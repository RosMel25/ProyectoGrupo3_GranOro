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
    public partial class Frm_Cortes : Form
    {
        DataTable dtINformacion = new DataTable();
        public LogicaNegocio.RecoleccionLN.ClsCortesLN CorteInfo;
        private bool Editar = false;
        public Frm_Cortes()
        {
            InitializeComponent();
            this.CorteInfo = new LogicaNegocio.RecoleccionLN.ClsCortesLN();
            dtINformacion.Columns.Add("Mensaje", typeof(string));
            Mostrar_Valores.DataSource = CargarCorte();
            DiseñoGriew();
            Listarfinca();
        }

        private void limpiarForm()
        {
            txtID.Clear();
            txtNomCorte.Clear();

        }

        public int Verificar_eliminar(int cod)
        {

            dtINformacion = CorteInfo.VERFICAR_CORTE(cod);
            string dato = dtINformacion.Rows[0]["TOTAL"].ToString();
            int count = int.Parse(dato);
            return count;
        }

        private string Validarfinca() { 

            string valorBuscado = cbFinca.Text;
            string cod;

            dtINformacion = CorteInfo.VerFinca();

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

        private  void Listarfinca()
        {
            dtINformacion = CorteInfo.VerFinca();

               if (dtINformacion.Rows.Count == 0)
               {
                    MessageBox.Show("Por Favor primero registre un finca", "No Hay Fincas Registradas", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private DataTable CargarCorte()
        {
            return CorteInfo.MostrarCorte();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string cod = txtID.Text;
            string Nom = txtNomCorte.Text;
            string Finca = Validarfinca();



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
                    if (cod.Equals("") || Nom.Equals(""))
                    {
                        MessageBox.Show("TODOS LOS ESPACIOS DEBEN ESTAR COMPLETOS", "Resultao de Ejecución", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int cod_ = int.Parse(cod);
                        CorteInfo.GuardarCorte(new Entidad.ClsCorte { ID_Corte = cod_, Nom_Corte = Nom, NO_Finca = Finca });
                        MessageBox.Show("Finca Registrada", "Resultado de Ejecución", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limpiarForm();
                    }

                    Mostrar_Valores.DataSource = CargarCorte();
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
                        CorteInfo.EditarCorte(new Entidad.ClsCorte { ID_Corte = cod_, Nom_Corte = Nom, NO_Finca = Finca });
                        MessageBox.Show("Finca Actualizada", "Resultado de Ejecución", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limpiarForm();
                    }

                    Mostrar_Valores.DataSource = CargarCorte();
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
            int Valor_Count;

            if (Mostrar_Valores.SelectedRows.Count > 0)
            {

                Datofila = Mostrar_Valores.CurrentRow.Cells["ID_CORTE"].Value.ToString();
                Cod = int.Parse(Datofila);
                Valor_Count = Verificar_eliminar(Cod);

                if (Valor_Count == 0)
                {
                    CorteInfo.EliminarCorte(new Entidad.ClsCorte { ID_Corte = Cod });
                    MessageBox.Show("Registro Eliminado", "Resultado de Ejecución", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mostrar_Valores.DataSource = CargarCorte();
                }
                else
                {
                    MessageBox.Show("El Corte a eliminar cuenta con datos asociados", "Elimine los reportes Primero", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

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
                txtID.Text = Mostrar_Valores.CurrentRow.Cells["ID_CORTE"].Value.ToString();
                txtNomCorte.Text = Mostrar_Valores.CurrentRow.Cells["NOMBRE_CORTE"].Value.ToString();
                cbFinca.Text = Mostrar_Valores.CurrentRow.Cells["NOMBRE_FINCA"].Value.ToString();


            }
            else
                MessageBox.Show("Debe seleccionar el registro a editar", "Resultao de Ejecución", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void BtnFinca_Click(object sender, EventArgs e)
        {
            FrmFincas formulario2 = new FrmFincas();

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

        private void Frm_Cortes_Load(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            string DatoBuscar = txtBuscar.Text;

            if (DatoBuscar.Equals(""))
            {
                MessageBox.Show("Ho hay ningun valor para buscar", "Resultado de Ejecución", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dtINformacion = CorteInfo.BuscarCorte(new Entidad.ClsCorte  { Nom_Corte = DatoBuscar });

                if (dtINformacion.Rows.Count == 0)
                {
                    MessageBox.Show("El nombre digitado no corresponde a ninguno de los Recolectores registrados", "Informacion incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarCorte();
                }
                else
                {
                    Mostrar_Valores.DataSource = dtINformacion;
                }

            }
        }

        private void Btn_refrescar_Click(object sender, EventArgs e)
        {
            Mostrar_Valores.DataSource = CargarCorte();
            txtBuscar.Clear();
            limpiarForm();
        }

        private void BtnRecoleccion_Click(object sender, EventArgs e)
        {
            FrmRecolecion formulario2 = new FrmRecolecion();

            // Mostrar Form2
            formulario2.Show();

            // Opcionalmente, ocultar Form1 si es necesario
            this.Hide();
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            FrmReportes formulario2 = new FrmReportes();

            // Mostrar Form2
            formulario2.Show();

            // Opcionalmente, ocultar Form1 si es necesario
            this.Hide();
        }

        private void BtnCorte_Click(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            FrmInicio formulario2 = new FrmInicio();

            // Mostrar Form2
            formulario2.Show();

            // Opcionalmente, ocultar Form1 si es necesario
            this.Hide();
        }
    }
}
