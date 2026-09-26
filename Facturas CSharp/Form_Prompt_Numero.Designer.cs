partial class Form_Prompt_Numero : System.Windows.Forms.Form {
   
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
            this.Cancelar = new System.Windows.Forms.Button();
            this.Aceptar = new System.Windows.Forms.Button();
            this.Marco = new System.Windows.Forms.GroupBox();
            this.dcFacturasVentas = new System.Windows.Forms.ComboBox();
            this.Text_Numero = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Marco.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.SystemColors.Control;
            this.Cancelar.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Cancelar.Location = new System.Drawing.Point(488, 72);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Cancelar.Size = new System.Drawing.Size(89, 25);
            this.Cancelar.TabIndex = 2;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Aceptar
            // 
            this.Aceptar.BackColor = System.Drawing.SystemColors.Control;
            this.Aceptar.Cursor = System.Windows.Forms.Cursors.Default;
            this.Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Aceptar.Location = new System.Drawing.Point(488, 32);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Aceptar.Size = new System.Drawing.Size(89, 25);
            this.Aceptar.TabIndex = 1;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = false;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // Marco
            // 
            this.Marco.BackColor = System.Drawing.SystemColors.Control;
            this.Marco.Controls.Add(this.dcFacturasVentas);
            this.Marco.Controls.Add(this.Text_Numero);
            this.Marco.Controls.Add(this.Label1);
            this.Marco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Marco.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Marco.Location = new System.Drawing.Point(16, 16);
            this.Marco.Name = "Marco";
            this.Marco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Marco.Size = new System.Drawing.Size(457, 145);
            this.Marco.TabIndex = 3;
            this.Marco.TabStop = false;
            this.Marco.Text = "Número de Factura";
            // 
            // dcFacturasVentas
            // 
            this.dcFacturasVentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dcFacturasVentas.FormattingEnabled = true;
            this.dcFacturasVentas.Location = new System.Drawing.Point(280, 64);
            this.dcFacturasVentas.Name = "dcFacturasVentas";
            this.dcFacturasVentas.Size = new System.Drawing.Size(161, 28);
            this.dcFacturasVentas.TabIndex = 6;
            this.dcFacturasVentas.SelectedIndexChanged += new System.EventHandler(this.dcFacturasVentas_SelectedIndexChanged);
            // 
            // Text_Numero
            // 
            this.Text_Numero.AcceptsReturn = true;
            this.Text_Numero.BackColor = System.Drawing.SystemColors.Window;
            this.Text_Numero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_Numero.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Text_Numero.Location = new System.Drawing.Point(280, 64);
            this.Text_Numero.MaxLength = 0;
            this.Text_Numero.Name = "Text_Numero";
            this.Text_Numero.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text_Numero.Size = new System.Drawing.Size(161, 26);
            this.Text_Numero.TabIndex = 0;
            this.Text_Numero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(8, 64);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(265, 25);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Introduzca el número de factura:";
            // 
            // Form_Prompt_Numero
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(590, 176);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.Marco);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(162, 231);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Prompt_Numero";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Número de Factura";
            this.Load += new System.EventHandler(this.Form_Prompt_Numero_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_Prompt_Numero_Closing);
            this.Marco.ResumeLayout(false);
            this.Marco.PerformLayout();
            this.ResumeLayout(false);

    }
#endregion
        // Requerido por el Diseñador de Windows Forms
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.TextBox Text_Numero;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.GroupBox Marco;
        private System.Windows.Forms.ComboBox dcFacturasVentas;
}