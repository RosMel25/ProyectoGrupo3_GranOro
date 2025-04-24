namespace Presentacion.Recoleccion
{
    partial class FrmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportes));
            this.PanelFinca = new System.Windows.Forms.Panel();
            this.dtpfecha_final = new System.Windows.Forms.DateTimePicker();
            this.dtpfecha_inicio = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbFinca = new System.Windows.Forms.ComboBox();
            this.cbRecolector = new System.Windows.Forms.ComboBox();
            this.cbReporte = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.Logo = new System.Windows.Forms.PictureBox();
            this.PanelFinca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar_Valores)).BeginInit();
            this.PanelMenu.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelFinca
            // 
            this.PanelFinca.AutoSize = true;
            this.PanelFinca.Controls.Add(this.dtpfecha_final);
            this.PanelFinca.Controls.Add(this.dtpfecha_inicio);
            this.PanelFinca.Controls.Add(this.label6);
            this.PanelFinca.Controls.Add(this.label5);
            this.PanelFinca.Controls.Add(this.button1);
            this.PanelFinca.Controls.Add(this.cbFinca);
            this.PanelFinca.Controls.Add(this.cbRecolector);
            this.PanelFinca.Controls.Add(this.cbReporte);
            this.PanelFinca.Controls.Add(this.label4);
            this.PanelFinca.Controls.Add(this.label3);
            this.PanelFinca.Controls.Add(this.label2);
            this.PanelFinca.Controls.Add(this.label1);
            this.PanelFinca.Controls.Add(this.Mostrar_Valores);
            this.PanelFinca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelFinca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFinca.Location = new System.Drawing.Point(173, 0);
            this.PanelFinca.Name = "PanelFinca";
            this.PanelFinca.Size = new System.Drawing.Size(981, 554);
            this.PanelFinca.TabIndex = 11;
            // 
            // dtpfecha_final
            // 
            this.dtpfecha_final.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfecha_final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfecha_final.Location = new System.Drawing.Point(179, 333);
            this.dtpfecha_final.Name = "dtpfecha_final";
            this.dtpfecha_final.Size = new System.Drawing.Size(131, 22);
            this.dtpfecha_final.TabIndex = 107;
            this.dtpfecha_final.Value = new System.DateTime(2025, 4, 18, 17, 37, 48, 0);
            // 
            // dtpfecha_inicio
            // 
            this.dtpfecha_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfecha_inicio.Location = new System.Drawing.Point(26, 333);
            this.dtpfecha_inicio.Name = "dtpfecha_inicio";
            this.dtpfecha_inicio.Size = new System.Drawing.Size(131, 22);
            this.dtpfecha_inicio.TabIndex = 106;
            this.dtpfecha_inicio.Value = new System.DateTime(2025, 4, 18, 17, 37, 48, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 54;
            this.label6.Text = "Fecha Inicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(204, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 53;
            this.label5.Text = "Fecha Final";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(93, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 79);
            this.button1.TabIndex = 52;
            this.button1.Text = "Generar \r\nRegistro";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbFinca
            // 
            this.cbFinca.FormattingEnabled = true;
            this.cbFinca.Location = new System.Drawing.Point(26, 171);
            this.cbFinca.Name = "cbFinca";
            this.cbFinca.Size = new System.Drawing.Size(284, 21);
            this.cbFinca.TabIndex = 51;
            // 
            // cbRecolector
            // 
            this.cbRecolector.FormattingEnabled = true;
            this.cbRecolector.Location = new System.Drawing.Point(26, 254);
            this.cbRecolector.Name = "cbRecolector";
            this.cbRecolector.Size = new System.Drawing.Size(284, 21);
            this.cbRecolector.TabIndex = 50;
            // 
            // cbReporte
            // 
            this.cbReporte.FormattingEnabled = true;
            this.cbReporte.Items.AddRange(new object[] {
            "Reporte General de Recolección",
            "Reporte General de Recolección por Recolector",
            "Reporte Diario por Recolector"});
            this.cbReporte.Location = new System.Drawing.Point(26, 81);
            this.cbReporte.Name = "cbReporte";
            this.cbReporte.Size = new System.Drawing.Size(284, 21);
            this.cbReporte.TabIndex = 49;
            this.cbReporte.Text = "Seleccione un reporte";
            this.cbReporte.SelectedIndexChanged += new System.EventHandler(this.cbReporte_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "Nombre de Finca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Nombre Recolector";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Tipo de Reporte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(505, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 25);
            this.label1.TabIndex = 44;
            this.label1.Text = "Información Solicitada";
            // 
            // Mostrar_Valores
            // 
            this.Mostrar_Valores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Mostrar_Valores.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Mostrar_Valores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Mostrar_Valores.Location = new System.Drawing.Point(337, 53);
            this.Mostrar_Valores.Name = "Mostrar_Valores";
            this.Mostrar_Valores.ReadOnly = true;
            this.Mostrar_Valores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Mostrar_Valores.Size = new System.Drawing.Size(632, 489);
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
            this.PanelMenu.TabIndex = 10;
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
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 554);
            this.Controls.Add(this.PanelFinca);
            this.Controls.Add(this.PanelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReportes";
            this.PanelFinca.ResumeLayout(false);
            this.PanelFinca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar_Valores)).EndInit();
            this.PanelMenu.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelFinca;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Button BtnReportes;
        private System.Windows.Forms.Button BtnUser;
        private System.Windows.Forms.Button BtnRecoleccion;
        private System.Windows.Forms.Button Recoleccion;
        private System.Windows.Forms.Button BtnPrecio;
        private System.Windows.Forms.Button BtnCorte;
        private System.Windows.Forms.Button BtnFinca;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.ComboBox cbReporte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Mostrar_Valores;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbFinca;
        private System.Windows.Forms.ComboBox cbRecolector;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpfecha_final;
        private System.Windows.Forms.DateTimePicker dtpfecha_inicio;
        private System.Windows.Forms.PictureBox Logo;
    }
}