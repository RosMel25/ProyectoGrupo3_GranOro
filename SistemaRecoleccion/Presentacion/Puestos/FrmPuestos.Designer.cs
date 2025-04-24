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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAumentarSalario = new System.Windows.Forms.Button();
            this.txtPorcentajeAumento = new System.Windows.Forms.TextBox();
            this.btnUnificarSalarioMinimo = new System.Windows.Forms.Button();
            this.txtSalarioUnificado = new System.Windows.Forms.TextBox();
            this.btnVerPuestoConMuchosEmpleados = new System.Windows.Forms.Button();
            this.txtMinEmpleados = new System.Windows.Forms.TextBox();
            this.btnVerCantidadEmpleados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar_Valores)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdPuesto
            // 
            this.txtIdPuesto.Location = new System.Drawing.Point(885, 26);
            this.txtIdPuesto.Name = "txtIdPuesto";
            this.txtIdPuesto.Size = new System.Drawing.Size(100, 26);
            this.txtIdPuesto.TabIndex = 0;
            this.txtIdPuesto.TextChanged += new System.EventHandler(this.txtIdPuesto_TextChanged);
            // 
            // txtNombrePuesto
            // 
            this.txtNombrePuesto.Location = new System.Drawing.Point(885, 205);
            this.txtNombrePuesto.Name = "txtNombrePuesto";
            this.txtNombrePuesto.Size = new System.Drawing.Size(100, 26);
            this.txtNombrePuesto.TabIndex = 1;
            this.txtNombrePuesto.TextChanged += new System.EventHandler(this.txtNombrePuesto_TextChanged);
            // 
            // txtMinSalario
            // 
            this.txtMinSalario.Location = new System.Drawing.Point(885, 253);
            this.txtMinSalario.Name = "txtMinSalario";
            this.txtMinSalario.Size = new System.Drawing.Size(100, 26);
            this.txtMinSalario.TabIndex = 2;
            this.txtMinSalario.TextChanged += new System.EventHandler(this.txtMinSalario_TextChanged_1);
            // 
            // txtMaxSalario
            // 
            this.txtMaxSalario.Location = new System.Drawing.Point(885, 307);
            this.txtMaxSalario.Name = "txtMaxSalario";
            this.txtMaxSalario.Size = new System.Drawing.Size(100, 26);
            this.txtMaxSalario.TabIndex = 3;
            this.txtMaxSalario.TextChanged += new System.EventHandler(this.txtMaxSalario_TextChanged_1);
            // 
            // Mostrar_Valores
            // 
            this.Mostrar_Valores.AllowUserToOrderColumns = true;
            this.Mostrar_Valores.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Mostrar_Valores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Mostrar_Valores.Location = new System.Drawing.Point(96, 82);
            this.Mostrar_Valores.Name = "Mostrar_Valores";
            this.Mostrar_Valores.RowHeadersWidth = 62;
            this.Mostrar_Valores.RowTemplate.Height = 28;
            this.Mostrar_Valores.Size = new System.Drawing.Size(555, 434);
            this.Mostrar_Valores.TabIndex = 4;
            this.Mostrar_Valores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Mostrar_Valores_CellContentClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(438, 545);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(91, 39);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(528, 18);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(76, 43);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(885, 84);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 26);
            this.txtId.TabIndex = 9;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged_1);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(885, 150);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 26);
            this.txtNombre.TabIndex = 10;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(270, 24);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(222, 26);
            this.txtBuscar.TabIndex = 11;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(307, 537);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(89, 47);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(160, 537);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(99, 47);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(791, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Id Puesto:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(816, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(791, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nombre:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(737, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nombre Puesto:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(737, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Salario Mínimo:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(733, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Salario Máximo:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(130, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "N° Puesto:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnAumentarSalario
            // 
            this.btnAumentarSalario.Location = new System.Drawing.Point(728, 363);
            this.btnAumentarSalario.Name = "btnAumentarSalario";
            this.btnAumentarSalario.Size = new System.Drawing.Size(125, 64);
            this.btnAumentarSalario.TabIndex = 19;
            this.btnAumentarSalario.Text = "Aumentar Salario";
            this.btnAumentarSalario.UseVisualStyleBackColor = true;
            this.btnAumentarSalario.Click += new System.EventHandler(this.btnAumentarSalario_Click_1);
            // 
            // txtPorcentajeAumento
            // 
            this.txtPorcentajeAumento.Location = new System.Drawing.Point(885, 382);
            this.txtPorcentajeAumento.Name = "txtPorcentajeAumento";
            this.txtPorcentajeAumento.Size = new System.Drawing.Size(100, 26);
            this.txtPorcentajeAumento.TabIndex = 20;
            this.txtPorcentajeAumento.TextChanged += new System.EventHandler(this.txtPorcentajeAumento_TextChanged);
            // 
            // btnUnificarSalarioMinimo
            // 
            this.btnUnificarSalarioMinimo.Location = new System.Drawing.Point(720, 443);
            this.btnUnificarSalarioMinimo.Name = "btnUnificarSalarioMinimo";
            this.btnUnificarSalarioMinimo.Size = new System.Drawing.Size(133, 73);
            this.btnUnificarSalarioMinimo.TabIndex = 21;
            this.btnUnificarSalarioMinimo.Text = "Unificar Salarios Minimos";
            this.btnUnificarSalarioMinimo.UseVisualStyleBackColor = true;
            this.btnUnificarSalarioMinimo.Click += new System.EventHandler(this.btnUnificarSalarioMinimo_Click_1);
            // 
            // txtSalarioUnificado
            // 
            this.txtSalarioUnificado.Location = new System.Drawing.Point(885, 478);
            this.txtSalarioUnificado.Name = "txtSalarioUnificado";
            this.txtSalarioUnificado.Size = new System.Drawing.Size(100, 26);
            this.txtSalarioUnificado.TabIndex = 22;
            this.txtSalarioUnificado.TextChanged += new System.EventHandler(this.txtSalarioUnificado_TextChanged);
            // 
            // btnVerPuestoConMuchosEmpleados
            // 
            this.btnVerPuestoConMuchosEmpleados.Location = new System.Drawing.Point(688, 546);
            this.btnVerPuestoConMuchosEmpleados.Name = "btnVerPuestoConMuchosEmpleados";
            this.btnVerPuestoConMuchosEmpleados.Size = new System.Drawing.Size(165, 50);
            this.btnVerPuestoConMuchosEmpleados.TabIndex = 23;
            this.btnVerPuestoConMuchosEmpleados.Text = "Ver Puestos Con Empleados";
            this.btnVerPuestoConMuchosEmpleados.UseVisualStyleBackColor = true;
            this.btnVerPuestoConMuchosEmpleados.Click += new System.EventHandler(this.btnVerPuestoConMuchosEmpleados_Click);
            // 
            // txtMinEmpleados
            // 
            this.txtMinEmpleados.Location = new System.Drawing.Point(883, 558);
            this.txtMinEmpleados.Name = "txtMinEmpleados";
            this.txtMinEmpleados.Size = new System.Drawing.Size(102, 26);
            this.txtMinEmpleados.TabIndex = 24;
            this.txtMinEmpleados.TextChanged += new System.EventHandler(this.txtMinEmpleados_TextChanged);
            // 
            // btnVerCantidadEmpleados
            // 
            this.btnVerCantidadEmpleados.Location = new System.Drawing.Point(354, 624);
            this.btnVerCantidadEmpleados.Name = "btnVerCantidadEmpleados";
            this.btnVerCantidadEmpleados.Size = new System.Drawing.Size(221, 43);
            this.btnVerCantidadEmpleados.TabIndex = 25;
            this.btnVerCantidadEmpleados.Text = "Ver Cantidad de Empleados";
            this.btnVerCantidadEmpleados.UseVisualStyleBackColor = true;
            this.btnVerCantidadEmpleados.Click += new System.EventHandler(this.btnVerCantidadEmpleados_Click_1);
            // 
            // FrmPuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 693);
            this.Controls.Add(this.btnVerCantidadEmpleados);
            this.Controls.Add(this.txtMinEmpleados);
            this.Controls.Add(this.btnVerPuestoConMuchosEmpleados);
            this.Controls.Add(this.txtSalarioUnificado);
            this.Controls.Add(this.btnUnificarSalarioMinimo);
            this.Controls.Add(this.txtPorcentajeAumento);
            this.Controls.Add(this.btnAumentarSalario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.Text = "FrmPuestos";
            this.Load += new System.EventHandler(this.FrmPuestos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar_Valores)).EndInit();
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
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAumentarSalario;
        private System.Windows.Forms.TextBox txtPorcentajeAumento;
        private System.Windows.Forms.Button btnUnificarSalarioMinimo;
        private System.Windows.Forms.TextBox txtSalarioUnificado;
        private System.Windows.Forms.Button btnVerPuestoConMuchosEmpleados;
        private System.Windows.Forms.TextBox txtMinEmpleados;
        private System.Windows.Forms.Button btnVerCantidadEmpleados;
    }
}