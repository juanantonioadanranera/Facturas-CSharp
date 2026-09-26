partial class Form_Prompt_Proveedores : System.Windows.Forms.Form {
   
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
            this.Marco = new System.Windows.Forms.GroupBox();
            this.dcProveedores = new System.Windows.Forms.ComboBox();
            this.Label_Prompt = new System.Windows.Forms.Label();
            this.Aceptar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Marco.SuspendLayout();
            this.SuspendLayout();
            // 
            // Marco
            // 
            this.Marco.BackColor = System.Drawing.SystemColors.Control;
            this.Marco.Controls.Add(this.dcProveedores);
            this.Marco.Controls.Add(this.Label_Prompt);
            this.Marco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Marco.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Marco.Location = new System.Drawing.Point(8, 16);
            this.Marco.Name = "Marco";
            this.Marco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Marco.Size = new System.Drawing.Size(577, 121);
            this.Marco.TabIndex = 3;
            this.Marco.TabStop = false;
            this.Marco.Text = "Proveedores";
            // 
            // dcProveedores
            // 
            this.dcProveedores.DisplayMember = "NOMBRE";
            this.dcProveedores.Location = new System.Drawing.Point(240, 48);
            this.dcProveedores.Name = "dcProveedores";
            this.dcProveedores.Size = new System.Drawing.Size(320, 28);
            this.dcProveedores.TabIndex = 5;
            // 
            // Label_Prompt
            // 
            this.Label_Prompt.BackColor = System.Drawing.SystemColors.Control;
            this.Label_Prompt.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_Prompt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label_Prompt.Location = new System.Drawing.Point(16, 48);
            this.Label_Prompt.Name = "Label_Prompt";
            this.Label_Prompt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label_Prompt.Size = new System.Drawing.Size(209, 25);
            this.Label_Prompt.TabIndex = 4;
            this.Label_Prompt.Text = "Seleccione el proveedor:";
            // 
            // Aceptar
            // 
            this.Aceptar.BackColor = System.Drawing.SystemColors.Control;
            this.Aceptar.Cursor = System.Windows.Forms.Cursors.Default;
            this.Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Aceptar.Location = new System.Drawing.Point(600, 24);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Aceptar.Size = new System.Drawing.Size(89, 25);
            this.Aceptar.TabIndex = 1;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = false;
            this.Aceptar.Click += new System.EventHandler(Aceptar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.SystemColors.Control;
            this.Cancelar.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Cancelar.Location = new System.Drawing.Point(600, 64);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Cancelar.Size = new System.Drawing.Size(89, 25);
            this.Cancelar.TabIndex = 2;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(Cancelar_Click);
            // 
            // Form_Prompt_Proveedores
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(703, 150);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Marco);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(3, 22);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Prompt_Proveedores";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.Text = "Proveedores";
            this.Marco.ResumeLayout(false);
            this.ResumeLayout(false);
            this.Load += new System.EventHandler(Form_Prompt_Proveedores_Load);

    }
#endregion
        // Requerido por el Diseñador de Windows Forms

        private System.Windows.Forms.Label Label_Prompt;
        private System.Windows.Forms.GroupBox Marco;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.ComboBox dcProveedores;
}