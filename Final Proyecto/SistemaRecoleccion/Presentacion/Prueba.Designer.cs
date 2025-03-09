namespace Presentacion
{
    partial class Prueba
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_NOM = new System.Windows.Forms.TextBox();
            this.txt_TAM = new System.Windows.Forms.TextBox();
            this.txt_UBI = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.Mostrar_Valores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar_Valores)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(227, 58);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 20);
            this.txt_ID.TabIndex = 0;
            // 
            // txt_NOM
            // 
            this.txt_NOM.Location = new System.Drawing.Point(227, 109);
            this.txt_NOM.Name = "txt_NOM";
            this.txt_NOM.Size = new System.Drawing.Size(100, 20);
            this.txt_NOM.TabIndex = 1;
            // 
            // txt_TAM
            // 
            this.txt_TAM.Location = new System.Drawing.Point(227, 164);
            this.txt_TAM.Name = "txt_TAM";
            this.txt_TAM.Size = new System.Drawing.Size(100, 20);
            this.txt_TAM.TabIndex = 2;
            // 
            // txt_UBI
            // 
            this.txt_UBI.Location = new System.Drawing.Point(227, 224);
            this.txt_UBI.Name = "txt_UBI";
            this.txt_UBI.Size = new System.Drawing.Size(100, 20);
            this.txt_UBI.TabIndex = 3;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(544, 160);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(164, 97);
            this.btn_agregar.TabIndex = 4;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // Mostrar_Valores
            // 
            this.Mostrar_Valores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Mostrar_Valores.Location = new System.Drawing.Point(94, 288);
            this.Mostrar_Valores.Name = "Mostrar_Valores";
            this.Mostrar_Valores.Size = new System.Drawing.Size(630, 227);
            this.Mostrar_Valores.TabIndex = 5;
            // 
            // Prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.Mostrar_Valores);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txt_UBI);
            this.Controls.Add(this.txt_TAM);
            this.Controls.Add(this.txt_NOM);
            this.Controls.Add(this.txt_ID);
            this.Name = "Prueba";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar_Valores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_NOM;
        private System.Windows.Forms.TextBox txt_TAM;
        private System.Windows.Forms.TextBox txt_UBI;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.DataGridView Mostrar_Valores;
    }
}

