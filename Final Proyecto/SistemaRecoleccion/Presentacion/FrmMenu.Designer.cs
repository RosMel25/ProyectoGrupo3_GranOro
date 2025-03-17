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
            this.SuspendLayout();
            // 
            // btnAbrirFinca
            // 
            this.btnAbrirFinca.Location = new System.Drawing.Point(80, 33);
            this.btnAbrirFinca.Name = "btnAbrirFinca";
            this.btnAbrirFinca.Size = new System.Drawing.Size(172, 77);
            this.btnAbrirFinca.TabIndex = 0;
            this.btnAbrirFinca.Text = "Fincas";
            this.btnAbrirFinca.UseVisualStyleBackColor = true;
            this.btnAbrirFinca.Click += new System.EventHandler(this.btnAbrirFinca_Click_1);
            // 
            // btnAbrirEmpleados
            // 
            this.btnAbrirEmpleados.Location = new System.Drawing.Point(80, 159);
            this.btnAbrirEmpleados.Name = "btnAbrirEmpleados";
            this.btnAbrirEmpleados.Size = new System.Drawing.Size(172, 72);
            this.btnAbrirEmpleados.TabIndex = 1;
            this.btnAbrirEmpleados.Text = "Empleados";
            this.btnAbrirEmpleados.UseVisualStyleBackColor = true;
            this.btnAbrirEmpleados.Click += new System.EventHandler(this.btnAbrirEmpleados_Click_1);
            // 
            // btnAbrirPuestos
            // 
            this.btnAbrirPuestos.Location = new System.Drawing.Point(80, 290);
            this.btnAbrirPuestos.Name = "btnAbrirPuestos";
            this.btnAbrirPuestos.Size = new System.Drawing.Size(172, 81);
            this.btnAbrirPuestos.TabIndex = 2;
            this.btnAbrirPuestos.Text = "Puestos";
            this.btnAbrirPuestos.UseVisualStyleBackColor = true;
            this.btnAbrirPuestos.Click += new System.EventHandler(this.btnAbrirPuestos_Click_1);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAbrirPuestos);
            this.Controls.Add(this.btnAbrirEmpleados);
            this.Controls.Add(this.btnAbrirFinca);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirFinca;
        private System.Windows.Forms.Button btnAbrirEmpleados;
        private System.Windows.Forms.Button btnAbrirPuestos;
    }
}