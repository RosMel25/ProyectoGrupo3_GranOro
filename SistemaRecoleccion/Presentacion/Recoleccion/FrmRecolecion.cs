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
using LogicaNegocio.FincaLN;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion.Recoleccion
{
    public partial class FrmRecolecion : Form
    {
        DataTable dtINformacion = new DataTable();
        DataTable dtVERIFICAR = new DataTable();
        public LogicaNegocio.RecoleccionLN.ClsRecoleccionLN RecoleccionInfo;
        private bool Editar = false;

        public FrmRecolecion()
        {
            InitializeComponent();
            this.RecoleccionInfo = new LogicaNegocio.RecoleccionLN.ClsRecoleccionLN();
            dtINformacion.Columns.Add("Mensaje", typeof(string));
            Mostrar_Valores.DataSource = CargarRecoleccion();
            DiseñoGriew();
            ListarRecolector();
            ListarFinca();
            ListarCategoria();
            ListarFincaBuscar();
            ListarCorteBuscar();
            ListarRecolectorBuscar();
            txtTotalcajuela.Enabled = false;
            txtTotalcuartillo.Enabled = false;
            txtTotalPago.Enabled = false;
        }

        public void sumadatos()
        {
            double Valorcaj = Convert.ToDouble(ValorCajuela());
            double Valorcuar = Convert.ToDouble(ValorCuartillo());


            if (txtCajuela.Text.Equals("") || txtCuartillo.Text.Equals(""))
            {
                MessageBox.Show("TODOS LOS ESPACIOS DEBEN ESTAR COMPLETOS", "Resultado de Ejecución", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int caj = int.Parse(txtCajuela.Text);
                int cuar = int.Parse(txtCuartillo.Text);

                double totalcajuela = Valorcaj * caj;
                double totalcuartillo = Valorcuar * cuar;
                double totalPago = totalcajuela + totalcuartillo;

                txtTotalcajuela.Text = totalcajuela.ToString();
                txtTotalcuartillo.Text = totalcuartillo.ToString();
                txtTotalPago.Text = totalPago.ToString();

            }

        }

        private void limpiarForm()
        {
            txtCajuela.Clear();
            txtCuartillo.Clear();
            txtTotalcajuela.Clear();
            txtTotalcuartillo.Clear();
            txtTotalPago.Clear();
        }

        
        #region ValidarCampos
        private string ValidarRecolector()
        {

            string valorBuscado = cbRecolectorDATO();
            string cod;

            dtINformacion = RecoleccionInfo.VerRecolector();

            DataRow[] filas = dtINformacion.Select($"NOMBRE_RECOLECTOR = '{valorBuscado}'");

            if (filas.Length > 0)
            {
                DataRow fila = filas[0]; // Primera coincidencia
                cod = fila["IDENTIFICACION_RECOLECTOR"].ToString();

                return cod;

            }
            else
            {
                return cod = " Incorrecto ";
            }

        }

        private string ValidarRecolectorBuscar()
        {

            string valorBuscado = cbRecolectorDATOBuscar();
            string cod;

            dtINformacion = RecoleccionInfo.VerRecolector();

            DataRow[] filas = dtINformacion.Select($"NOMBRE_RECOLECTOR = '{valorBuscado}'");

            if (filas.Length > 0)
            {
                DataRow fila = filas[0]; // Primera coincidencia
                cod = fila["IDENTIFICACION_RECOLECTOR"].ToString();

                return cod;

            }
            else
            {
                return cod = " Incorrecto ";
            }

        }

        private string Validarfinca()
        {

            string valorBuscado = cbfincaDATO();
            string cod;

            dtINformacion = RecoleccionInfo.VerFinca();

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
        private string ValidarfincaBuscar()
        {

            string valorBuscado = cbfincaDATOBuscar();
            string cod;

            dtINformacion = RecoleccionInfo.VerFinca();

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

        private string ValidarCorte()
         {

            string valorBuscado = cbCorteaDATO();
            string cod;

            string No_Finca = Validarfinca();
            dtINformacion = RecoleccionInfo.VerCorte(new Entidad.Finca.ClsFinca { No_Finca = int.Parse(No_Finca) }); ;

             DataRow[] filas = dtINformacion.Select($"NOMBRE_CORTE = '{valorBuscado}'");

             if (filas.Length > 0)
             {
                 DataRow fila = filas[0]; // Primera coincidencia
                 cod = fila["ID_CORTE"].ToString();

                 return cod;

             }
             else
             {
                 return cod = " Incorrecto ";
             }

        }

        private string ValidarCorteBuscar()
        {

            string valorBuscado = cbCorteDATOBuscar();
            string cod;

            string No_Finca = ValidarfincaBuscar();
            dtINformacion = RecoleccionInfo.VerCorte(new Entidad.Finca.ClsFinca { No_Finca = int.Parse(No_Finca) }); ;

            DataRow[] filas = dtINformacion.Select($"NOMBRE_CORTE = '{valorBuscado}'");

            if (filas.Length > 0)
            {
                DataRow fila = filas[0]; // Primera coincidencia
                cod = fila["ID_CORTE"].ToString();

                return cod;

            }
            else
            {
                return cod = " Incorrecto ";
            }

        }

        private string ValidarCategoria()
        {

            string valorBuscado = cbCategoriaDATO();
            string cod;

            dtINformacion = RecoleccionInfo.VerCategoria();

            DataRow[] filas = dtINformacion.Select($"NOMBRE_CATEGORIA = '{valorBuscado}'");

            if (filas.Length > 0)
            {
                DataRow fila = filas[0]; // Primera coincidencia
                cod = fila["ID_PRECIO"].ToString();

                return cod;

            }
            else
            {
                return cod = " Incorrecto ";
            }

        }
        #endregion

        #region ValoresParaCalculo
        private string ValorCajuela()
        {

            string valorBuscado = cbCategoriaDATO();
            string cod;

            dtINformacion = RecoleccionInfo.VerCategoria();

            DataRow[] filas = dtINformacion.Select($"NOMBRE_CATEGORIA = '{valorBuscado}'");

            if (filas.Length > 0)
            {
                DataRow fila = filas[0]; // Primera coincidencia
                cod = fila["VALOR_CAJUELA"].ToString();

                return cod;

            }
            else
            {
                return cod = " Incorrecto ";
            }

        }

        private string ValorCuartillo()
        {

            string valorBuscado = cbCategoriaDATO();
            string cod;

            dtINformacion = RecoleccionInfo.VerCategoria();

            DataRow[] filas = dtINformacion.Select($"NOMBRE_CATEGORIA = '{valorBuscado}'");

            if (filas.Length > 0)
            {
                DataRow fila = filas[0]; // Primera coincidencia
                cod = fila["VALOR_CUARTILLO"].ToString();

                return cod;

            }
            else
            {
                return cod = " Incorrecto ";
            }

        }
        #endregion

        #region ExtracionComboBox        
        public string cbRecolectorDATO()
        {
            string nombreSeleccionado;
            if (CBRecolector.SelectedItem != null)
            {
                DataRowView fila = (DataRowView)CBRecolector.SelectedItem;
                nombreSeleccionado = fila["NOMBRE_RECOLECTOR"].ToString();

                return nombreSeleccionado;
            }
            else
            {
                MessageBox.Show("No hay selección de Recolector");
                return nombreSeleccionado = "No funciono";
            }
        }

        public string cbRecolectorDATOBuscar()
        {
            string nombreSeleccionado;
            if (cbrecolector_buscar.SelectedItem != null)
            {
                DataRowView fila = (DataRowView)cbrecolector_buscar.SelectedItem;
                nombreSeleccionado = fila["NOMBRE_RECOLECTOR"].ToString();

                return nombreSeleccionado;
            }
            else
            {
                MessageBox.Show("No hay selección de Recolector");
                return nombreSeleccionado = "No funciono";
            }
        }


        public string cbfincaDATO()
        {
            string nombreSeleccionado;
            if (cbFinca.SelectedItem != null)
            {
                DataRowView fila = (DataRowView)cbFinca.SelectedItem;
                nombreSeleccionado = fila["NOMBRE_FINCA"].ToString();

                return nombreSeleccionado;
            }
            else
            {
                MessageBox.Show("No hay selección de finca");
                return nombreSeleccionado = "No funciono";
            }
        }
        public string cbfincaDATOBuscar()
        {
            string nombreSeleccionado;
            if (cbfinca_buscar.SelectedItem != null)
            {
                DataRowView fila = (DataRowView)cbfinca_buscar.SelectedItem;
                nombreSeleccionado = fila["NOMBRE_FINCA"].ToString();

                return nombreSeleccionado;
            }
            else
            {
                MessageBox.Show("No hay selección de finca");
                return nombreSeleccionado = "No funciono";
            }
        }
        public string cbCorteaDATO()
        {
            string nombreSeleccionado;
            if (cbCorte.SelectedItem != null)
            {
                DataRowView fila = (DataRowView)cbCorte.SelectedItem;
                nombreSeleccionado = fila["NOMBRE_CORTE"].ToString();

                return nombreSeleccionado;
            }
            else
            {
                MessageBox.Show("No hay selección de Corte");
                return nombreSeleccionado = "No funciono";
            }
        }

        public string cbCorteDATOBuscar()
        {
            string nombreSeleccionado;
            if (cbcorte_buscar.SelectedItem != null)
            {
                DataRowView fila = (DataRowView)cbcorte_buscar.SelectedItem;
                nombreSeleccionado = fila["NOMBRE_CORTE"].ToString();

                return nombreSeleccionado;
            }
            else
            {
                MessageBox.Show("No hay selección de Corte");
                return nombreSeleccionado = "No funciono";
            }
        }

        public string cbCategoriaDATO()
        {
            string nombreSeleccionado;
            if (cbcategoria.SelectedItem != null)
            {
                DataRowView fila = (DataRowView)cbcategoria.SelectedItem;
                nombreSeleccionado = fila["NOMBRE_CATEGORIA"].ToString();

                return nombreSeleccionado;
            }
            else
            {
                MessageBox.Show("No hay selección de Categoria");
                return nombreSeleccionado = "No funciono";
            }
        }
        #endregion

        #region ListarDatos

        private void ListarRecolector()
        {
            dtINformacion = RecoleccionInfo.VerRecolector();

            if (dtINformacion.Rows.Count == 0)
            {
                MessageBox.Show("Por favor registre un recolector", "No Hay Recolectores Registrados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmRecolector formulario2 = new FrmRecolector();

                // Mostrar Form2
                formulario2.Show();

                // Opcionalmente, ocultar Form1 si es necesario
                this.Hide();
            }
            else
            {
                CBRecolector.DataSource = dtINformacion;
                CBRecolector.DisplayMember = "Recolector";
                CBRecolector.ValueMember = "NOMBRE_RECOLECTOR";

                cbrecolector_buscar.DataSource = dtINformacion;
                cbrecolector_buscar.DisplayMember = "Recolector";
                cbrecolector_buscar.ValueMember = "NOMBRE_RECOLECTOR";
            }

        }


        private void ListarRecolectorBuscar()
        {
            dtINformacion = RecoleccionInfo.VerRecolector();

            if (dtINformacion.Rows.Count == 0)
            {
                MessageBox.Show("Por favor registre un recolector", "No Hay Recolectores Registrados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmRecolector formulario2 = new FrmRecolector();

                // Mostrar Form2
                formulario2.Show();

                // Opcionalmente, ocultar Form1 si es necesario
                this.Hide();
            }
            else
            {
                cbrecolector_buscar.DataSource = dtINformacion;
                cbrecolector_buscar.DisplayMember = "Recolector";
                cbrecolector_buscar.ValueMember = "NOMBRE_RECOLECTOR";
            }

        }
        private void ListarFinca()
        {
            dtINformacion = RecoleccionInfo.VerFinca();

            if (dtINformacion.Rows.Count == 0)
            {
                MessageBox.Show("Por Favor registre una finca", "No Hay Fincas Registradas", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            cbFinca.SelectedIndexChanged += cbFinca_SelectedIndexChanged;

        }

        private void ListarFincaBuscar()
        {
            dtINformacion = RecoleccionInfo.VerFinca();

            if (dtINformacion.Rows.Count == 0)
            {
                MessageBox.Show("Por Favor registre una finca", "No Hay Fincas Registradas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmFincas formulario2 = new FrmFincas();

                // Mostrar Form2
                formulario2.Show();

                // Opcionalmente, ocultar Form1 si es necesario
                this.Hide();
            }
            else
            {
                cbfinca_buscar.DataSource = dtINformacion;
                cbfinca_buscar.DisplayMember = "Finca";
                cbfinca_buscar.ValueMember = "NOMBRE_FINCA";
            }
            cbfinca_buscar.SelectedIndexChanged += cbfinca_buscar_SelectedIndexChanged;

        }
        private void ListarCorte()
        {

            string cod = Validarfinca();
            dtINformacion = RecoleccionInfo.VerCorte(new Entidad.Finca.ClsFinca {No_Finca = int.Parse(cod) }); ;

            if (dtINformacion.Rows.Count == 0)
            {
                MessageBox.Show("Por Favor primero registre un corte", "No Hay Cortes Registrados en Ninguna Finca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmFincas formulario2 = new FrmFincas();

                // Mostrar Form2
                formulario2.Show();

                // Opcionalmente, ocultar Form1 si es necesario
                this.Hide();
            }
            else
            {
                cbCorte.DataSource = dtINformacion;
                cbCorte.DisplayMember = "Corte";
                cbCorte.ValueMember = "NOMBRE_CORTE";

            }

        }

        private void ListarCorteBuscar()
        {

            string cod = ValidarfincaBuscar();
            dtINformacion = RecoleccionInfo.VerCorte(new Entidad.Finca.ClsFinca { No_Finca = int.Parse(cod) }); ;

            if (dtINformacion.Rows.Count == 0)
            {
                MessageBox.Show("Por Favor primero registre un corte", "No Hay Cortes Registrados en Ninguna Finca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmFincas formulario2 = new FrmFincas();

                // Mostrar Form2
                formulario2.Show();

                // Opcionalmente, ocultar Form1 si es necesario
                this.Hide();
            }
            else
            {

                cbcorte_buscar.DataSource = dtINformacion;
                cbcorte_buscar.DisplayMember = "Corte";
                cbcorte_buscar.ValueMember = "NOMBRE_CORTE";
            }

        }

        private void ListarCategoria()
        {

            dtINformacion = RecoleccionInfo.VerCategoria(); ;

            if (dtINformacion.Rows.Count == 0)
            {
                MessageBox.Show("Por Favor primero registre un PRECIO", "No Hay PRECIOS Registrados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmFincas formulario2 = new FrmFincas();

                // Mostrar Form2
                formulario2.Show();

                // Opcionalmente, ocultar Form1 si es necesario
                this.Hide();
            }
            else
            {
                cbcategoria.DataSource = dtINformacion;
                cbcategoria.DisplayMember = "Precio";
                cbcategoria.ValueMember = "NOMBRE_CATEGORIA";
            }

        }

        private DataTable CargarRecoleccion()
        {
            return RecoleccionInfo.MostrarRecoleccion();
        }
        #endregion

        #region OTROS

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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
        #endregion

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            string recolector = ValidarRecolector();
            string finca = Validarfinca();
            string corte = ValidarCorte();
            string fecha = dtpFecha.Value.ToString("dd/MM/yyyy");
            string cajuelas = txtCajuela.Text;
            string cuatillos = txtCuartillo.Text;
            string precio = ValidarCategoria();
            string pago_total = txtTotalPago.Text;

            dtVERIFICAR = RecoleccionInfo.VALIDAR_REGISTRO(recolector,fecha);
            int count = dtVERIFICAR.Rows.Count;

            if (count == 0)
            {
                // Guardar Nuevo Registro o editar existente
                if (Editar == false)
                {
                    try
                    {
                        if (!Regex.IsMatch(cajuelas, "^[0-9]+$") || !Regex.IsMatch(cuatillos, "^[0-9]+$"))
                        {
                            MessageBox.Show("Por favor, ingrese solo números.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtCajuela.Text = "";
                            txtCuartillo.Text = "";
                        }
                        if (recolector.Equals("") || finca.Equals("") || corte.Equals("") || fecha.Equals("") || cajuelas.Equals("") || cuatillos.Equals(""))
                        {
                            MessageBox.Show("TODOS LOS ESPACIOS DEBEN ESTAR COMPLETOS", "Resultado de Ejecución", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            RecoleccionInfo.GuardarRecoleccion(new Entidad.Recoleccion.ClsRecolecion
                            {
                                Id_Recolector = recolector,
                                No_Finca = int.Parse(finca),
                                Id_Corte = int.Parse(corte),
                                Fecha_Recoleccion = fecha,
                                Cajuelas = int.Parse(cajuelas),
                                Cuartillos = int.Parse(cuatillos),
                                Id_Precio = int.Parse(precio),
                                Precio_Total = int.Parse(pago_total)
                            });
                            MessageBox.Show("Registro Guardado con exito", "Resultado de Ejecución", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            limpiarForm();
                        }

                        Mostrar_Valores.DataSource = CargarRecoleccion();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("no se pudo insertar los datos por: " + ex);
                    }
                }
                //EDITAR registro existente
                if (Editar == true)
                {
                    int cod = int.Parse(Mostrar_Valores.CurrentRow.Cells["ID"].Value.ToString());
                    try
                    {
                        if (!Regex.IsMatch(cajuelas, "^[0-9]+$") || !Regex.IsMatch(cuatillos, "^[0-9]+$"))
                        {
                            MessageBox.Show("Por favor, ingrese solo números.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtCajuela.Text = "";
                            txtCuartillo.Text = "";
                        }
                        if (recolector.Equals("") || finca.Equals("") || corte.Equals("") || fecha.Equals("") || cajuelas.Equals("") || cuatillos.Equals(""))
                        {
                            MessageBox.Show("TODOS LOS ESPACIOS DEBEN ESTAR COMPLETOS", "Resultado de Ejecución", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            RecoleccionInfo.EditarRecolecion(new Entidad.Recoleccion.ClsRecolecion
                            {
                                Id_Recoleccion = cod,
                                Id_Recolector = recolector,
                                No_Finca = int.Parse(finca),
                                Id_Corte = int.Parse(corte),
                                Fecha_Recoleccion = fecha,
                                Cajuelas = int.Parse(cajuelas),
                                Cuartillos = int.Parse(cuatillos),
                                Id_Precio = int.Parse(precio),
                                Precio_Total = int.Parse(pago_total)
                            });
                            MessageBox.Show("Registro Editado con exito", "Resultado de Ejecución", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            limpiarForm();
                        }

                        Mostrar_Valores.DataSource = CargarRecoleccion();
                        Editar = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar los datos: " + ex, "Resultado de Ejecución", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                
            }
            else
            {
                MessageBox.Show("Ya existe un registro para la fecha del "+fecha+ " del recolector seleccionado", "Registro Repetido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCajuela.Clear();
                txtCuartillo.Clear();
                txtTotalcajuela.Clear();
                txtTotalcuartillo.Clear();
                txtTotalPago.Clear();
            }



        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (Mostrar_Valores.SelectedRows.Count > 0)
            {
                Editar = true;
                CBRecolector.Text = Mostrar_Valores.CurrentRow.Cells["RECOLECTOR"].Value.ToString();
                cbFinca.Text = Mostrar_Valores.CurrentRow.Cells["FINCA"].Value.ToString();
                cbCorte.Text = Mostrar_Valores.CurrentRow.Cells["CORTE"].Value.ToString();
                cbcategoria.Text = Mostrar_Valores.CurrentRow.Cells["CATEGORIA"].Value.ToString();
                dtpFecha.Text = Mostrar_Valores.CurrentRow.Cells["FECHA"].Value.ToString();
                txtCajuela.Text = Mostrar_Valores.CurrentRow.Cells["CAJUELA"].Value.ToString();
                txtCuartillo.Text = Mostrar_Valores.CurrentRow.Cells["CUARTILLO"].Value.ToString();
                txtTotalPago.Text = Mostrar_Valores.CurrentRow.Cells["TOTAL A PAGAR"].Value.ToString();


            }
            else
                MessageBox.Show("Debe seleccionar el registro a editar", "Resultao de Ejecución", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string Datofila;
            int Cod;

            if (Mostrar_Valores.SelectedRows.Count > 0)
            {

                Datofila = Mostrar_Valores.CurrentRow.Cells["ID"].Value.ToString();
                Cod = int.Parse(Datofila);
                RecoleccionInfo.EliminarRecoleccion(new Entidad.Recoleccion.ClsRecolecion { Id_Recoleccion = Cod });
                MessageBox.Show("Registro Eliminado", "Resultado de Ejecución", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Mostrar_Valores.DataSource = CargarRecoleccion();
            }
            else
                MessageBox.Show("Debe seleccionar el registro a eliminar", "Resultado de Ejecución", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        #region Ir_a_Forms
        private void BtnRecoleccion_Click(object sender, EventArgs e)
        {
            FrmRecolecion formulario2 = new FrmRecolecion();

            // Mostrar Form2
            formulario2.Show();

            // Opcionalmente, ocultar Form1 si es necesario
            this.Hide();
        }

        private void BtnFinca_Click(object sender, EventArgs e)
        {
            FrmFincas formulario2 = new FrmFincas();

            // Mostrar Form2
            formulario2.Show();

            // Opcionalmente, ocultar Form1 si es necesario
            this.Hide();
        }

        private void BtnCorte_Click(object sender, EventArgs e)
        {
            Frm_Cortes formulario2 = new Frm_Cortes();

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
#endregion

        #region otros

        private void CBRecolector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbFinca_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarCorte();
        }

        private void FrmRecolecion_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cbCorte_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            sumadatos();
        }

        private void txtCajuela_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalPago_TextChanged(object sender, EventArgs e)
        {
        }
        #endregion

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cbfinca_buscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarCorteBuscar();
        }

        private void cbcorte_buscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_fecha_buscar_Click(object sender, EventArgs e)
        {
            string fecha = dtpfecha_buscar.Value.ToString("dd/MM/yyyy");

            dtINformacion = RecoleccionInfo.MostrarRecoleccionFecha(new Entidad.Recoleccion.ClsRecolecion { Fecha_Recoleccion = fecha });

            if (dtINformacion.Rows.Count == 0)
            {
                MessageBox.Show("No hay Datos de acuerdo a la Fecha Buscada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                Mostrar_Valores.DataSource = dtINformacion;
            }
 
        }

        private void btn_recoelctor_buscar_Click(object sender, EventArgs e)
        {
            string recolector = ValidarRecolectorBuscar();

            dtINformacion = RecoleccionInfo.MostrarRecoleccionRecolector(new Entidad.Recoleccion.ClsRecolector { Identificacion = int.Parse(recolector) });

            if (dtINformacion.Rows.Count == 0)
            {
                MessageBox.Show("No hay Datos de acuerdo al Recolector Buscado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                Mostrar_Valores.DataSource = dtINformacion;
            }
        }

        private void Btn_refrescar_Click(object sender, EventArgs e)
        {
            Mostrar_Valores.DataSource = CargarRecoleccion();
        }

        private void Btn_finca_buscar_Click(object sender, EventArgs e)
        {
            string Finca = ValidarfincaBuscar();

            dtINformacion = RecoleccionInfo.MostrarRecoleccionFinca(new Entidad.Finca.ClsFinca { No_Finca = int.Parse(Finca) });

            if (dtINformacion.Rows.Count == 0)
            {
                MessageBox.Show("No hay Datos de acuerdo a la Finca Buscada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                Mostrar_Valores.DataSource = dtINformacion;
            }
        }

        private void btn_corte_buscar_Click(object sender, EventArgs e)
        {
            string corte = ValidarCorteBuscar();

            dtINformacion = RecoleccionInfo.MostrarRecoleccionFincaCorte(new Entidad.ClsCorte { ID_Corte = int.Parse(corte) });

            if (dtINformacion.Rows.Count == 0)
            {
                MessageBox.Show("No hay Datos de acuerdo al Corte Buscado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                Mostrar_Valores.DataSource = dtINformacion;
            }
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            FrmReportes formulario2 = new FrmReportes();

            // Mostrar Form2
            formulario2.Show();

            // Opcionalmente, ocultar Form1 si es necesario
            this.Hide();
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            FrmInicio formulario2 = new FrmInicio();

            // Mostrar Form2
            formulario2.Show();

            // Opcionalmente, ocultar Form1 si es necesario
            this.Hide();
        }
    }
}
