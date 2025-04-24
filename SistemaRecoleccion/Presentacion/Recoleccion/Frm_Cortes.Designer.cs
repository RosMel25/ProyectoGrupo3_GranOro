namespace Presentacion.Recoleccion
{
    partial class Frm_Cortes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cortes));
            this.PanelFinca = new System.Windows.Forms.Panel();
            this.cbFinca = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Btn_refrescar = new System.Windows.Forms.Button();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomCorte = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Mostrar_Valores = new System.Windows.Forms.DataGridView();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.BtnReportes = new System.Windows.Forms.Button();
            this.BtnUser = new System.Windows.Forms.Button();
            this.BtnRecoleccion = new System.Windows.Forms.Button();
            this.Recoleccion = new System.Windows.Forms.Button();
            this.BtnPrecio = new System.Windows.Forms.Button();
            this.BtnCorte = new System.Windows.Forms.Button();
            this.BtnFinca = new System.Windows.Forms.Button();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.Button();
            this.PanelFinca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar_Valores)).BeginInit();
            this.PanelMenu.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelFinca
            // 
            this.PanelFinca.AutoSize = true;
            this.PanelFinca.Controls.Add(this.cbFinca);
            this.PanelFinca.Controls.Add(this.label7);
            this.PanelFinca.Controls.Add(this.Btn_refrescar);
            this.PanelFinca.Controls.Add(this.Btn_buscar);
            this.PanelFinca.Controls.Add(this.txtBuscar);
            this.PanelFinca.Controls.Add(this.label5);
            this.PanelFinca.Controls.Add(this.txtNomCorte);
            this.PanelFinca.Controls.Add(this.btnEliminar);
            this.PanelFinca.Controls.Add(this.btnEditar);
            this.PanelFinca.Controls.Add(this.btnGuardar);
            this.PanelFinca.Controls.Add(this.label3);
            this.PanelFinca.Controls.Add(this.label2);
            this.PanelFinca.Controls.Add(this.txtID);
            this.PanelFinca.Controls.Add(this.label1);
            this.PanelFinca.Controls.Add(this.Mostrar_Valores);
            this.PanelFinca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFinca.Location = new System.Drawing.Point(173, 0);
            this.PanelFinca.Name = "PanelFinca";
            this.PanelFinca.Size = new System.Drawing.Size(981, 554);
            this.PanelFinca.TabIndex = 9;
            // 
            // cbFinca
            // 
            this.cbFinca.FormattingEnabled = true;
            this.cbFinca.Location = new System.Drawing.Point(769, 315);
            this.cbFinca.Name = "cbFinca";
            this.cbFinca.Size = new System.Drawing.Size(195, 21);
            this.cbFinca.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 60;
            this.label7.Text = "Nombre corte: ";
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
            this.Btn_refrescar.Click += new System.EventHandler(this.Btn_refrescar_Click);
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
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(723, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 25);
            this.label5.TabIndex = 55;
            this.label5.Text = "Datos del Corte";
            // 
            // txtNomCorte
            // 
            this.txtNomCorte.Location = new System.Drawing.Point(769, 230);
            this.txtNomCorte.Multiline = true;
            this.txtNomCorte.Name = "txtNomCorte";
            this.txtNomCorte.Size = new System.Drawing.Size(195, 50);
            this.txtNomCorte.TabIndex = 54;
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
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(659, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Nombre Finca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(659, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Nombre Corte:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(748, 164);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(216, 50);
            this.txtID.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(659, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "ID Corte:";
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
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.SystemColors.Highlight;
            this.PanelMenu.Controls.Add(this.BtnReportes);
            this.PanelMenu.Controls.Add(this.BtnUser);
            this.PanelMenu.Controls.Add(this.BtnRecoleccion);
            this.PanelMenu.Controls.Add(this.Recoleccion);
            this.PanelMenu.Controls.Add(this.BtnPrecio);
            this.PanelMenu.Controls.Add(this.BtnCorte);
            this.PanelMenu.Controls.Add(this.BtnFinca);
            this.PanelMenu.Controls.Add(this.PanelLogo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(173, 554);
            this.PanelMenu.TabIndex = 8;
            // 
            // BtnReportes
            // 
            this.BtnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnReportes.FlatAppearance.BorderSize = 0;
            this.BtnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReportes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReportes.ForeColor = System.Drawing.Color.White;
            this.BtnReportes.Location = new System.Drawing.Point(0, 380);
            this.BtnReportes.Name = "BtnReportes";
            this.BtnReportes.Size = new System.Drawing.Size(173, 47);
            this.BtnReportes.TabIndex = 7;
            this.BtnReportes.Text = "Reportes";
            this.BtnReportes.UseVisualStyleBackColor = true;
            this.BtnReportes.Click += new System.EventHandler(this.BtnReportes_Click);
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
            this.BtnUser.Location = new System.Drawing.Point(0, 466);
            this.BtnUser.Name = "BtnUser";
            this.BtnUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnUser.Size = new System.Drawing.Size(173, 88);
            this.BtnUser.TabIndex = 6;
            this.BtnUser.Text = "Usuario";
            this.BtnUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnUser.UseVisualStyleBackColor = true;
            // 
            // BtnRecoleccion
            // 
            this.BtnRecoleccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRecoleccion.FlatAppearance.BorderSize = 0;
            this.BtnRecoleccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRecoleccion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRecoleccion.ForeColor = System.Drawing.Color.White;
            this.BtnRecoleccion.Location = new System.Drawing.Point(0, 333);
            this.BtnRecoleccion.Name = "BtnRecoleccion";
            this.BtnRecoleccion.Size = new System.Drawing.Size(173, 47);
            this.BtnRecoleccion.TabIndex = 5;
            this.BtnRecoleccion.Text = "Recolección";
            this.BtnRecoleccion.UseVisualStyleBackColor = true;
            this.BtnRecoleccion.Click += new System.EventHandler(this.BtnRecoleccion_Click);
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
            this.Recoleccion.Text = "Recolectores";
            this.Recoleccion.UseVisualStyleBackColor = true;
            this.Recoleccion.Click += new System.EventHandler(this.Recoleccion_Click);
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
            this.BtnPrecio.Click += new System.EventHandler(this.BtnPrecio_Click);
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
            this.BtnCorte.Click += new System.EventHandler(this.BtnCorte_Click);
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
            this.BtnFinca.Click += new System.EventHandler(this.BtnFinca_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.Controls.Add(this.btnInicio);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(173, 145);
            this.PanelLogo.TabIndex = 0;
            // 
            // btnInicio
            // 
            this.btnInicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInicio.BackgroundImage")));
            this.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInicio.Location = new System.Drawing.Point(4, 4);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(164, 136);
            this.btnInicio.TabIndex = 2;
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // Frm_Cortes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 554);
            this.Controls.Add(this.PanelFinca);
            this.Controls.Add(this.PanelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Frm_Cortes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Cortes";
            this.Load += new System.EventHandler(this.Frm_Cortes_Load);
            this.PanelFinca.ResumeLayout(false);
            this.PanelFinca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar_Valores)).EndInit();
            this.PanelMenu.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelFinca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Btn_refrescar;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomCorte;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Mostrar_Valores;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Button BtnUser;
        private System.Windows.Forms.Button BtnRecoleccion;
        private System.Windows.Forms.Button Recoleccion;
        private System.Windows.Forms.Button BtnPrecio;
        private System.Windows.Forms.Button BtnCorte;
        private System.Windows.Forms.Button BtnFinca;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.ComboBox cbFinca;
        private System.Windows.Forms.Button BtnReportes;
        private System.Windows.Forms.Button btnInicio;
    }
}