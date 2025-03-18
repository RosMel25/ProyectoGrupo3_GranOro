namespace Presentacion.Puestos
{
    partial class FrmPuestos
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
            this.txtIdPuesto = new System.Windows.Forms.TextBox();
            this.txtNombrePuesto = new System.Windows.Forms.TextBox();
            this.txtMinSalario = new System.Windows.Forms.TextBox();
            this.txtMaxSalario = new System.Windows.Forms.TextBox();
            this.Mostrar_Valores = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvPuestos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar_Valores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdPuesto
            // 
            this.txtIdPuesto.Location = new System.Drawing.Point(38, 29);
            this.txtIdPuesto.Name = "txtIdPuesto";
            this.txtIdPuesto.Size = new System.Drawing.Size(100, 26);
            this.txtIdPuesto.TabIndex = 0;
            this.txtIdPuesto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNombrePuesto
            // 
            this.txtNombrePuesto.Location = new System.Drawing.Point(38, 96);
            this.txtNombrePuesto.Name = "txtNombrePuesto";
            this.txtNombrePuesto.Size = new System.Drawing.Size(100, 26);
            this.txtNombrePuesto.TabIndex = 1;
            // 
            // txtMinSalario
            // 
            this.txtMinSalario.Location = new System.Drawing.Point(38, 160);
            this.txtMinSalario.Name = "txtMinSalario";
            this.txtMinSalario.Size = new System.Drawing.Size(100, 26);
            this.txtMinSalario.TabIndex = 2;
            // 
            // txtMaxSalario
            // 
            this.txtMaxSalario.Location = new System.Drawing.Point(38, 238);
            this.txtMaxSalario.Name = "txtMaxSalario";
            this.txtMaxSalario.Size = new System.Drawing.Size(100, 26);
            this.txtMaxSalario.TabIndex = 3;
            // 
            // Mostrar_Valores
            // 
            this.Mostrar_Valores.AllowUserToOrderColumns = true;
            this.Mostrar_Valores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Mostrar_Valores.Location = new System.Drawing.Point(339, 56);
            this.Mostrar_Valores.Name = "Mostrar_Valores";
            this.Mostrar_Valores.RowHeadersWidth = 62;
            this.Mostrar_Valores.RowTemplate.Height = 28;
            this.Mostrar_Valores.Size = new System.Drawing.Size(240, 150);
            this.Mostrar_Valores.TabIndex = 4;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(240, 253);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(95, 54);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(235, 345);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 47);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(418, 253);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(96, 54);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(418, 322);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(96, 61);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(173, 29);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 26);
            this.txtId.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(173, 96);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 26);
            this.txtNombre.TabIndex = 10;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(186, 180);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 26);
            this.txtBuscar.TabIndex = 11;
            // 
            // dgvPuestos
            // 
            this.dgvPuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuestos.Location = new System.Drawing.Point(38, 331);
            this.dgvPuestos.Name = "dgvPuestos";
            this.dgvPuestos.RowHeadersWidth = 62;
            this.dgvPuestos.RowTemplate.Height = 28;
            this.dgvPuestos.Size = new System.Drawing.Size(127, 61);
            this.dgvPuestos.TabIndex = 12;
            // 
            // FrmPuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPuestos);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.Mostrar_Valores);
            this.Controls.Add(this.txtMaxSalario);
            this.Controls.Add(this.txtMinSalario);
            this.Controls.Add(this.txtNombrePuesto);
            this.Controls.Add(this.txtIdPuesto);
            this.Name = "FrmPuestos";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar_Valores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdPuesto;
        private System.Windows.Forms.TextBox txtNombrePuesto;
        private System.Windows.Forms.TextBox txtMinSalario;
        private System.Windows.Forms.TextBox txtMaxSalario;
        private System.Windows.Forms.DataGridView Mostrar_Valores;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvPuestos;
    }
}