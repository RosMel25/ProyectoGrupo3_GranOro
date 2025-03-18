namespace Presentacion
{
    partial class FrmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarios));
            this.PanelApp = new System.Windows.Forms.Panel();
            this.txtROL = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Btn_refrescar = new System.Windows.Forms.Button();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtEMAIL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCEDULA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Mostrar_Valores = new System.Windows.Forms.DataGridView();
            this.PanelApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar_Valores)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelApp
            // 
            this.PanelApp.AutoSize = true;
            this.PanelApp.Controls.Add(this.txtROL);
            this.PanelApp.Controls.Add(this.label7);
            this.PanelApp.Controls.Add(this.Btn_refrescar);
            this.PanelApp.Controls.Add(this.Btn_buscar);
            this.PanelApp.Controls.Add(this.txtBuscar);
            this.PanelApp.Controls.Add(this.label6);
            this.PanelApp.Controls.Add(this.label5);
            this.PanelApp.Controls.Add(this.txtNombre);
            this.PanelApp.Controls.Add(this.btnEliminar);
            this.PanelApp.Controls.Add(this.btnEditar);
            this.PanelApp.Controls.Add(this.btnGuardar);
            this.PanelApp.Controls.Add(this.txtEMAIL);
            this.PanelApp.Controls.Add(this.label4);
            this.PanelApp.Controls.Add(this.txtCEDULA);
            this.PanelApp.Controls.Add(this.label3);
            this.PanelApp.Controls.Add(this.label2);
            this.PanelApp.Controls.Add(this.txtID);
            this.PanelApp.Controls.Add(this.label1);
            this.PanelApp.Controls.Add(this.Mostrar_Valores);
            this.PanelApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelApp.Location = new System.Drawing.Point(0, 0);
            this.PanelApp.Name = "PanelApp";
            this.PanelApp.Size = new System.Drawing.Size(1019, 522);
            this.PanelApp.TabIndex = 8;
            // 
            // txtROL
            // 
            this.txtROL.Location = new System.Drawing.Point(779, 333);
            this.txtROL.Multiline = true;
            this.txtROL.Name = "txtROL";
            this.txtROL.Size = new System.Drawing.Size(185, 30);
            this.txtROL.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(659, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 60;
            this.label7.Text = "Rol de Usuario:";
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
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(135, 44);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(276, 35);
            this.txtBuscar.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 56;
            this.label6.Text = "ID Precio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(674, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 25);
            this.label5.TabIndex = 55;
            this.label5.Text = "Registro de Usuarios\r\n";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(761, 183);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(203, 30);
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
            // txtEMAIL
            // 
            this.txtEMAIL.Location = new System.Drawing.Point(717, 286);
            this.txtEMAIL.Multiline = true;
            this.txtEMAIL.Name = "txtEMAIL";
            this.txtEMAIL.Size = new System.Drawing.Size(247, 30);
            this.txtEMAIL.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(659, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 49;
            this.label4.Text = "Email:";
            // 
            // txtCEDULA
            // 
            this.txtCEDULA.Location = new System.Drawing.Point(732, 239);
            this.txtCEDULA.Multiline = true;
            this.txtCEDULA.Name = "txtCEDULA";
            this.txtCEDULA.Size = new System.Drawing.Size(232, 30);
            this.txtCEDULA.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(659, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Cedula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(659, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 40);
            this.label2.TabIndex = 46;
            this.label2.Text = "Nombre de \r\nUsuario:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(748, 139);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(216, 30);
            this.txtID.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(659, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "ID Usuario:";
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
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 522);
            this.Controls.Add(this.PanelApp);
            this.Name = "FrmUsuarios";
            this.Text = "FrmUsuarios";
            this.PanelApp.ResumeLayout(false);
            this.PanelApp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar_Valores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelApp;
        private System.Windows.Forms.TextBox txtROL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Btn_refrescar;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtEMAIL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCEDULA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Mostrar_Valores;
    }
}