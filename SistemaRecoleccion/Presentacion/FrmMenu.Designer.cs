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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAbrirFinca
            // 
            this.btnAbrirFinca.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirFinca.Location = new System.Drawing.Point(24, 60);
            this.btnAbrirFinca.Margin = new System.Windows.Forms.Padding(2);
            this.btnAbrirFinca.Name = "btnAbrirFinca";
            this.btnAbrirFinca.Size = new System.Drawing.Size(317, 137);
            this.btnAbrirFinca.TabIndex = 0;
            this.btnAbrirFinca.Text = "RECOLECCION";
            this.btnAbrirFinca.UseVisualStyleBackColor = true;
            this.btnAbrirFinca.Click += new System.EventHandler(this.btnAbrirFinca_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(24, 243);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(317, 137);
            this.button1.TabIndex = 1;
            this.button1.Text = "USUARIOS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 435);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAbrirFinca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirFinca;
        private System.Windows.Forms.Button button1;
    }
}