partial class Form_Numero_Albaran : System.Windows.Forms.Form {
   
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
        // NOTA: el siguiente procedimiento es necesario para el Diseñador de Windows Forms
        // Se puede modificar mediante el Diseñador de Windows Forms.
        // No lo modifique con el editor de código.

        this.Marco = new System.Windows.Forms.GroupBox();
        this.dcAlbaranes = new System.Windows.Forms.ComboBox();
        this.Label_Numero = new System.Windows.Forms.Label();
        this.Aceptar = new System.Windows.Forms.Button();
        this.Cancelar = new System.Windows.Forms.Button();
        this.Marco.SuspendLayout();
        this.SuspendLayout();
        // 
        // Marco
        // 
        this.Marco.BackColor = System.Drawing.SystemColors.Control;
        this.Marco.Controls.Add(this.dcAlbaranes);
        this.Marco.Controls.Add(this.Label_Numero);
        this.Marco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.Marco.ForeColor = System.Drawing.SystemColors.ControlText;
        this.Marco.Location = new System.Drawing.Point(16, 16);
        this.Marco.Name = "Marco";
        this.Marco.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.Marco.Size = new System.Drawing.Size(425, 145);
        this.Marco.TabIndex = 2;
        this.Marco.TabStop = false;
        this.Marco.Text = "Número de Albarán";
        this.dcAlbaranes.DisplayMember = "NUMERO";
        this.dcAlbaranes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.dcAlbaranes.FormatString = "N0";
        this.dcAlbaranes.Location = new System.Drawing.Point(288, 56);
        this.dcAlbaranes.Name = "dcAlbaranes";
        this.dcAlbaranes.Size = new System.Drawing.Size(121, 28);
        this.dcAlbaranes.TabIndex = 5;
        // 
        // Label_Numero
        // 
        this.Label_Numero.BackColor = System.Drawing.SystemColors.Control;
        this.Label_Numero.Cursor = System.Windows.Forms.Cursors.Default;
        this.Label_Numero.ForeColor = System.Drawing.SystemColors.ControlText;
        this.Label_Numero.Location = new System.Drawing.Point(8, 64);
        this.Label_Numero.Name = "Label_Numero";
        this.Label_Numero.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.Label_Numero.Size = new System.Drawing.Size(281, 25);
        this.Label_Numero.TabIndex = 3;
        this.Label_Numero.Text = "Introduzca el número de albarán:";
        this.Aceptar.BackColor = System.Drawing.SystemColors.Control;
        this.Aceptar.Cursor = System.Windows.Forms.Cursors.Default;
        this.Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.Aceptar.ForeColor = System.Drawing.SystemColors.ControlText;
        this.Aceptar.Location = new System.Drawing.Point(456, 32);
        this.Aceptar.Name = "Aceptar";
        this.Aceptar.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.Aceptar.Size = new System.Drawing.Size(89, 25);
        this.Aceptar.TabIndex = 1;
        this.Aceptar.Text = "Aceptar";
        this.Aceptar.UseVisualStyleBackColor = false;
            this.Aceptar.Click += new System.EventHandler(Aceptar_Click);
        this.Cancelar.BackColor = System.Drawing.SystemColors.Control;
        this.Cancelar.Cursor = System.Windows.Forms.Cursors.Default;
        this.Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.Cancelar.ForeColor = System.Drawing.SystemColors.ControlText;
        this.Cancelar.Location = new System.Drawing.Point(456, 72);
        this.Cancelar.Name = "Cancelar";
        this.Cancelar.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.Cancelar.Size = new System.Drawing.Size(89, 25);
        this.Cancelar.TabIndex = 0;
        this.Cancelar.Text = "Cancelar";
        this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(Cancelar_Click);
        this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
        this.BackColor = System.Drawing.SystemColors.Control;
        this.ClientSize = new System.Drawing.Size(559, 176);
        this.Controls.Add(this.Marco);
        this.Controls.Add(this.Aceptar);
        this.Controls.Add(this.Cancelar);
        this.Cursor = System.Windows.Forms.Cursors.Default;
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.Location = new System.Drawing.Point(3, 22);
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "Form_Numero_Albaran";
        this.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.ShowInTaskbar = false;
        this.Text = "Albaranes";
        this.Marco.ResumeLayout(false);
        this.ResumeLayout(false);
    }
    
        #endregion

        // Requerido por el Diseñador de Windows Forms
        private System.Windows.Forms.Label Label_Numero;
        private System.Windows.Forms.GroupBox Marco;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.ComboBox dcAlbaranes;
}