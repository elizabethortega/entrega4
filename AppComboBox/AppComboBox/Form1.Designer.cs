namespace AppComboBox
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRojo = new System.Windows.Forms.Label();
            this.lblVerde = new System.Windows.Forms.Label();
            this.lblAzul = new System.Windows.Forms.Label();
            this.cmbRojo = new System.Windows.Forms.ComboBox();
            this.cmbVerde = new System.Windows.Forms.ComboBox();
            this.cmbAzul = new System.Windows.Forms.ComboBox();
            this.Colorear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRojo
            // 
            this.lblRojo.AutoSize = true;
            this.lblRojo.Location = new System.Drawing.Point(27, 23);
            this.lblRojo.Name = "lblRojo";
            this.lblRojo.Size = new System.Drawing.Size(29, 13);
            this.lblRojo.TabIndex = 0;
            this.lblRojo.Text = "Rojo";
            // 
            // lblVerde
            // 
            this.lblVerde.AutoSize = true;
            this.lblVerde.Location = new System.Drawing.Point(27, 71);
            this.lblVerde.Name = "lblVerde";
            this.lblVerde.Size = new System.Drawing.Size(35, 13);
            this.lblVerde.TabIndex = 1;
            this.lblVerde.Text = "Verde";
            // 
            // lblAzul
            // 
            this.lblAzul.AutoSize = true;
            this.lblAzul.Location = new System.Drawing.Point(27, 127);
            this.lblAzul.Name = "lblAzul";
            this.lblAzul.Size = new System.Drawing.Size(27, 13);
            this.lblAzul.TabIndex = 2;
            this.lblAzul.Text = "Azul";
            // 
            // cmbRojo
            // 
            this.cmbRojo.FormattingEnabled = true;
            this.cmbRojo.Location = new System.Drawing.Point(126, 23);
            this.cmbRojo.Name = "cmbRojo";
            this.cmbRojo.Size = new System.Drawing.Size(121, 21);
            this.cmbRojo.TabIndex = 3;
            // 
            // cmbVerde
            // 
            this.cmbVerde.FormattingEnabled = true;
            this.cmbVerde.Location = new System.Drawing.Point(126, 71);
            this.cmbVerde.Name = "cmbVerde";
            this.cmbVerde.Size = new System.Drawing.Size(121, 21);
            this.cmbVerde.TabIndex = 4;
            // 
            // cmbAzul
            // 
            this.cmbAzul.FormattingEnabled = true;
            this.cmbAzul.Location = new System.Drawing.Point(126, 127);
            this.cmbAzul.Name = "cmbAzul";
            this.cmbAzul.Size = new System.Drawing.Size(121, 21);
            this.cmbAzul.TabIndex = 5;
            // 
            // Colorear
            // 
            this.Colorear.Location = new System.Drawing.Point(172, 182);
            this.Colorear.Name = "Colorear";
            this.Colorear.Size = new System.Drawing.Size(107, 54);
            this.Colorear.TabIndex = 6;
            this.Colorear.Text = "Colorear Fondo";
            this.Colorear.UseVisualStyleBackColor = true;
            this.Colorear.Click += new System.EventHandler(this.Colorear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 262);
            this.Controls.Add(this.Colorear);
            this.Controls.Add(this.cmbAzul);
            this.Controls.Add(this.cmbVerde);
            this.Controls.Add(this.cmbRojo);
            this.Controls.Add(this.lblAzul);
            this.Controls.Add(this.lblVerde);
            this.Controls.Add(this.lblRojo);
            this.Name = "Form1";
            this.Text = "Combo Box Colores";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRojo;
        private System.Windows.Forms.Label lblVerde;
        private System.Windows.Forms.Label lblAzul;
        private System.Windows.Forms.ComboBox cmbRojo;
        private System.Windows.Forms.ComboBox cmbVerde;
        private System.Windows.Forms.ComboBox cmbAzul;
        private System.Windows.Forms.Button Colorear;
    }
}

