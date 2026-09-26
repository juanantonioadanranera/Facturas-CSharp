partial class Form_Prompt_Albaranes : System.Windows.Forms.Form {
   
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
            this.dcAlbaranes = new System.Windows.Forms.ComboBox();
            this.Label_Prompt = new System.Windows.Forms.Label();
            this.Marco.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.SystemColors.Control;
            this.Cancelar.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Cancelar.Location = new System.Drawing.Point(464, 72);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Cancelar.Size = new System.Drawing.Size(89, 25);
            this.Cancelar.TabIndex = 4;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            // 
            // Aceptar
            // 
            this.Aceptar.BackColor = System.Drawing.SystemColors.Control;
            this.Aceptar.Cursor = System.Windows.Forms.Cursors.Default;
            this.Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Aceptar.Location = new System.Drawing.Point(464, 32);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Aceptar.Size = new System.Drawing.Size(89, 25);
            this.Aceptar.TabIndex = 3;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = false;
            // 
            // Marco
            // 
            this.Marco.BackColor = System.Drawing.SystemColors.Control;
            this.Marco.Controls.Add(this.dcAlbaranes);
            this.Marco.Controls.Add(this.Label_Prompt);
            this.Marco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Marco.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Marco.Location = new System.Drawing.Point(16, 16);
            this.Marco.Name = "Marco";
            this.Marco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Marco.Size = new System.Drawing.Size(433, 121);
            this.Marco.TabIndex = 0;
            this.Marco.TabStop = false;
            this.Marco.Text = "Albaranes";
            // 
            // dcAlbaranes
            // 
            this.dcAlbaranes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dcAlbaranes.Location = new System.Drawing.Point(296, 40);
            this.dcAlbaranes.Name = "dcAlbaranes";
            this.dcAlbaranes.Size = new System.Drawing.Size(121, 28);
            this.dcAlbaranes.TabIndex = 3;
            // 
            // Label_Prompt
            // 
            this.Label_Prompt.BackColor = System.Drawing.SystemColors.Control;
            this.Label_Prompt.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_Prompt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label_Prompt.Location = new System.Drawing.Point(16, 48);
            this.Label_Prompt.Name = "Label_Prompt";
            this.Label_Prompt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label_Prompt.Size = new System.Drawing.Size(273, 25);
            this.Label_Prompt.TabIndex = 2;
            this.Label_Prompt.Text = "Seleccione el número de albarán:";
            // 
            // Form_Prompt_Albaranes
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(567, 150);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.Marco);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(3, 22);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Prompt_Albaranes";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.Text = "Albaranes";
            this.Marco.ResumeLayout(false);
            this.ResumeLayout(false);

	}
#endregion
        // Requerido por el Diseñador de Windows Forms

        private System.Windows.Forms.Label Label_Prompt;
        private System.Windows.Forms.GroupBox Marco;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.ComboBox dcAlbaranes;
}