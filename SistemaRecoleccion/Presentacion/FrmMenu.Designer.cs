namespace Presentacion
{
    partial class FrmMenu
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
            this.btnAbrirFinca = new System.Windows.Forms.Button();
            this.btnAbrirEmpleados = new System.Windows.Forms.Button();
            this.btnAbrirPuestos = new System.Windows.Forms.Button();
            this.btnmante = new System.Windows.Forms.Button();
            this.btnvehiculos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAbrirFinca
            // 
            this.btnAbrirFinca.Location = new System.Drawing.Point(53, 21);
            this.btnAbrirFinca.Margin = new System.Windows.Forms.Padding(2);
            this.btnAbrirFinca.Name = "btnAbrirFinca";
            this.btnAbrirFinca.Size = new System.Drawing.Size(115, 50);
            this.btnAbrirFinca.TabIndex = 0;
            this.btnAbrirFinca.Text = "Recoleccion";
            this.btnAbrirFinca.UseVisualStyleBackColor = true;
            this.btnAbrirFinca.Click += new System.EventHandler(this.btnAbrirFinca_Click_1);
            // 
            // btnAbrirEmpleados
            // 
            this.btnAbrirEmpleados.Location = new System.Drawing.Point(53, 103);
            this.btnAbrirEmpleados.Margin = new System.Windows.Forms.Padding(2);
            this.btnAbrirEmpleados.Name = "btnAbrirEmpleados";
            this.btnAbrirEmpleados.Size = new System.Drawing.Size(115, 47);
            this.btnAbrirEmpleados.TabIndex = 1;
            this.btnAbrirEmpleados.Text = "Empleados";
            this.btnAbrirEmpleados.UseVisualStyleBackColor = true;
            this.btnAbrirEmpleados.Click += new System.EventHandler(this.btnAbrirEmpleados_Click_1);
            // 
            // btnAbrirPuestos
            // 
            this.btnAbrirPuestos.Location = new System.Drawing.Point(53, 188);
            this.btnAbrirPuestos.Margin = new System.Windows.Forms.Padding(2);
            this.btnAbrirPuestos.Name = "btnAbrirPuestos";
            this.btnAbrirPuestos.Size = new System.Drawing.Size(115, 53);
            this.btnAbrirPuestos.TabIndex = 2;
            this.btnAbrirPuestos.Text = "Puestos";
            this.btnAbrirPuestos.UseVisualStyleBackColor = true;
            this.btnAbrirPuestos.Click += new System.EventHandler(this.btnAbrirPuestos_Click_1);
            // 
            // btnmante
            // 
            this.btnmante.Location = new System.Drawing.Point(304, 174);
            this.btnmante.Margin = new System.Windows.Forms.Padding(2);
            this.btnmante.Name = "btnmante";
            this.btnmante.Size = new System.Drawing.Size(115, 50);
            this.btnmante.TabIndex = 3;
            this.btnmante.Text = "Mantenimiento \r\nde  Vehiculos";
            this.btnmante.UseVisualStyleBackColor = true;
            this.btnmante.Click += new System.EventHandler(this.btnmante_Click);
            // 
            // btnvehiculos
            // 
            this.btnvehiculos.Location = new System.Drawing.Point(304, 21);
            this.btnvehiculos.Margin = new System.Windows.Forms.Padding(2);
            this.btnvehiculos.Name = "btnvehiculos";
            this.btnvehiculos.Size = new System.Drawing.Size(115, 50);
            this.btnvehiculos.TabIndex = 4;
            this.btnvehiculos.Text = "Vehiculos";
            this.btnvehiculos.UseVisualStyleBackColor = true;
            this.btnvehiculos.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.btnvehiculos);
            this.Controls.Add(this.btnmante);
            this.Controls.Add(this.btnAbrirPuestos);
            this.Controls.Add(this.btnAbrirEmpleados);
            this.Controls.Add(this.btnAbrirFinca);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirFinca;
        private System.Windows.Forms.Button btnAbrirEmpleados;
        private System.Windows.Forms.Button btnAbrirPuestos;
        private System.Windows.Forms.Button btnmante;
        private System.Windows.Forms.Button btnvehiculos;
    }
}