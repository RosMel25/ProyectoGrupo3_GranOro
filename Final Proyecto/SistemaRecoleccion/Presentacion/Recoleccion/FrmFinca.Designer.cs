namespace Presentacion.Recoleccion
{
    partial class FrmFinca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFinca));
            this.PanelApp = new System.Windows.Forms.Panel();
            this.Btn_refrescar = new System.Windows.Forms.Button();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTamaño = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNoFinca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Mostrar_Valores = new System.Windows.Forms.DataGridView();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.BtnUser = new System.Windows.Forms.Button();
            this.BtnReportes = new System.Windows.Forms.Button();
            this.Recoleccion = new System.Windows.Forms.Button();
            this.BtnPrecio = new System.Windows.Forms.Button();
            this.BtnCorte = new System.Windows.Forms.Button();
            this.BtnFinca = new System.Windows.Forms.Button();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.PanelApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar_Valores)).BeginInit();
            this.PanelMenu.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelApp
            // 
            this.PanelApp.AutoSize = true;
            this.PanelApp.Controls.Add(this.Btn_refrescar);
            this.PanelApp.Controls.Add(this.Btn_buscar);
            this.PanelApp.Controls.Add(this.txtBuscar);
            this.PanelApp.Controls.Add(this.label6);
            this.PanelApp.Controls.Add(this.label5);
            this.PanelApp.Controls.Add(this.txtNombre);
            this.PanelApp.Controls.Add(this.btnEliminar);
            this.PanelApp.Controls.Add(this.btnEditar);
            this.PanelApp.Controls.Add(this.btnGuardar);
            this.PanelApp.Controls.Add(this.txtUbicacion);
            this.PanelApp.Controls.Add(this.label4);
            this.PanelApp.Controls.Add(this.txtTamaño);
            this.PanelApp.Controls.Add(this.label3);
            this.PanelApp.Controls.Add(this.label2);
            this.PanelApp.Controls.Add(this.txtNoFinca);
            this.PanelApp.Controls.Add(this.label1);
            this.PanelApp.Controls.Add(this.Mostrar_Valores);
            this.PanelApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelApp.Location = new System.Drawing.Point(173, 0);
            this.PanelApp.Name = "PanelApp";
            this.PanelApp.Size = new System.Drawing.Size(978, 508);
            this.PanelApp.TabIndex = 5;
            this.PanelApp.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelApp_Paint);
            // 
            // Btn_refrescar
            // 
            this.Btn_refrescar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_refrescar.BackgroundImage")));
            this.Btn_refrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_refrescar.Location = new System.Drawing.Point(497, 44);
            this.Btn_refrescar.Name = "Btn_refrescar";
            this.Btn_refrescar.Size = new System.Drawing.Size(39, 35);
            this.Btn_refrescar.TabIndex = 59;
            this.Btn_refrescar.UseVisualStyleBackColor = true;
            this.Btn_refrescar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_buscar.BackgroundImage")));
            this.Btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_buscar.Location = new System.Drawing.Point(431, 44);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(39, 35);
            this.Btn_buscar.TabIndex = 58;
            this.Btn_buscar.UseVisualStyleBackColor = true;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(135, 44);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(276, 35);
            this.txtBuscar.TabIndex = 57;
            this.txtBuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 56;
            this.label6.Text = "N° Finca: ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(723, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 25);
            this.label5.TabIndex = 55;
            this.label5.Text = "Datos de la Finca";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(748, 205);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(216, 50);
            this.txtNombre.TabIndex = 54;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Location = new System.Drawing.Point(370, 431);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(123, 52);
            this.btnEliminar.TabIndex = 53;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Location = new System.Drawing.Point(183, 431);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(123, 52);
            this.btnEditar.TabIndex = 52;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Location = new System.Drawing.Point(785, 431);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(123, 52);
            this.btnGuardar.TabIndex = 51;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(748, 346);
            this.txtUbicacion.Multiline = true;
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(216, 50);
            this.txtUbicacion.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(659, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 49;
            this.label4.Text = "Ubicación";
            // 
            // txtTamaño
            // 
            this.txtTamaño.Location = new System.Drawing.Point(748, 277);
            this.txtTamaño.Multiline = true;
            this.txtTamaño.Name = "txtTamaño";
            this.txtTamaño.Size = new System.Drawing.Size(216, 50);
            this.txtTamaño.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(659, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Tamaño";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(659, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Nombre:";
            // 
            // txtNoFinca
            // 
            this.txtNoFinca.Location = new System.Drawing.Point(748, 139);
            this.txtNoFinca.Multiline = true;
            this.txtNoFinca.Name = "txtNoFinca";
            this.txtNoFinca.Size = new System.Drawing.Size(216, 50);
            this.txtNoFinca.TabIndex = 45;
            this.txtNoFinca.TextChanged += new System.EventHandler(this.txtNoFinca_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(659, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "N°de finca:";
            // 
            // Mostrar_Valores
            // 
            this.Mostrar_Valores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Mostrar_Valores.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Mostrar_Valores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Mostrar_Valores.Location = new System.Drawing.Point(14, 94);
            this.Mostrar_Valores.Name = "Mostrar_Valores";
            this.Mostrar_Valores.ReadOnly = true;
            this.Mostrar_Valores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Mostrar_Valores.Size = new System.Drawing.Size(632, 302);
            this.Mostrar_Valores.TabIndex = 43;
            this.Mostrar_Valores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Mostrar_Valores_CellContentClick_1);
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PanelMenu.Controls.Add(this.BtnUser);
            this.PanelMenu.Controls.Add(this.BtnReportes);
            this.PanelMenu.Controls.Add(this.Recoleccion);
            this.PanelMenu.Controls.Add(this.BtnPrecio);
            this.PanelMenu.Controls.Add(this.BtnCorte);
            this.PanelMenu.Controls.Add(this.BtnFinca);
            this.PanelMenu.Controls.Add(this.PanelLogo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(173, 508);
            this.PanelMenu.TabIndex = 4;
            // 
            // BtnUser
            // 
            this.BtnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnUser.FlatAppearance.BorderSize = 0;
            this.BtnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUser.ForeColor = System.Drawing.Color.White;
            this.BtnUser.Image = ((System.Drawing.Image)(resources.GetObject("BtnUser.Image")));
            this.BtnUser.Location = new System.Drawing.Point(0, 420);
            this.BtnUser.Name = "BtnUser";
            this.BtnUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnUser.Size = new System.Drawing.Size(173, 88);
            this.BtnUser.TabIndex = 6;
            this.BtnUser.Text = "Usuario";
            this.BtnUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnUser.UseVisualStyleBackColor = true;
            // 
            // BtnReportes
            // 
            this.BtnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnReportes.FlatAppearance.BorderSize = 0;
            this.BtnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReportes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReportes.ForeColor = System.Drawing.Color.White;
            this.BtnReportes.Location = new System.Drawing.Point(0, 333);
            this.BtnReportes.Name = "BtnReportes";
            this.BtnReportes.Size = new System.Drawing.Size(173, 47);
            this.BtnReportes.TabIndex = 5;
            this.BtnReportes.Text = "Reportes";
            this.BtnReportes.UseVisualStyleBackColor = true;
            // 
            // Recoleccion
            // 
            this.Recoleccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.Recoleccion.FlatAppearance.BorderSize = 0;
            this.Recoleccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Recoleccion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recoleccion.ForeColor = System.Drawing.Color.White;
            this.Recoleccion.Location = new System.Drawing.Point(0, 286);
            this.Recoleccion.Name = "Recoleccion";
            this.Recoleccion.Size = new System.Drawing.Size(173, 47);
            this.Recoleccion.TabIndex = 4;
            this.Recoleccion.Text = "Recoleccion";
            this.Recoleccion.UseVisualStyleBackColor = true;
            // 
            // BtnPrecio
            // 
            this.BtnPrecio.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPrecio.FlatAppearance.BorderSize = 0;
            this.BtnPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrecio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrecio.ForeColor = System.Drawing.Color.White;
            this.BtnPrecio.Location = new System.Drawing.Point(0, 239);
            this.BtnPrecio.Name = "BtnPrecio";
            this.BtnPrecio.Size = new System.Drawing.Size(173, 47);
            this.BtnPrecio.TabIndex = 3;
            this.BtnPrecio.Text = "Precios";
            this.BtnPrecio.UseVisualStyleBackColor = true;
            // 
            // BtnCorte
            // 
            this.BtnCorte.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCorte.FlatAppearance.BorderSize = 0;
            this.BtnCorte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCorte.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCorte.ForeColor = System.Drawing.Color.White;
            this.BtnCorte.Location = new System.Drawing.Point(0, 192);
            this.BtnCorte.Name = "BtnCorte";
            this.BtnCorte.Size = new System.Drawing.Size(173, 47);
            this.BtnCorte.TabIndex = 2;
            this.BtnCorte.Text = "Cortes";
            this.BtnCorte.UseVisualStyleBackColor = true;
            // 
            // BtnFinca
            // 
            this.BtnFinca.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnFinca.FlatAppearance.BorderSize = 0;
            this.BtnFinca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFinca.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFinca.ForeColor = System.Drawing.Color.White;
            this.BtnFinca.Location = new System.Drawing.Point(0, 145);
            this.BtnFinca.Name = "BtnFinca";
            this.BtnFinca.Size = new System.Drawing.Size(173, 47);
            this.BtnFinca.TabIndex = 1;
            this.BtnFinca.Text = "Fincas";
            this.BtnFinca.UseVisualStyleBackColor = true;
            // 
            // PanelLogo
            // 
            this.PanelLogo.Controls.Add(this.Logo);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(173, 145);
            this.PanelLogo.TabIndex = 0;
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(3, 3);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(167, 139);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // FrmFinca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 508);
            this.Controls.Add(this.PanelApp);
            this.Controls.Add(this.PanelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmFinca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmFinca";
            this.Load += new System.EventHandler(this.FrmFinca_Load);
            this.PanelApp.ResumeLayout(false);
            this.PanelApp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar_Valores)).EndInit();
            this.PanelMenu.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelApp;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Button BtnUser;
        private System.Windows.Forms.Button BtnReportes;
        private System.Windows.Forms.Button Recoleccion;
        private System.Windows.Forms.Button BtnPrecio;
        private System.Windows.Forms.Button BtnCorte;
        private System.Windows.Forms.Button BtnFinca;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTamaño;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNoFinca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Mostrar_Valores;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_refrescar;
        private System.Windows.Forms.Button Btn_buscar;
    }
}