partial class Form_Prompt_Materiales : System.Windows.Forms.Form {
   
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
            this.Marco = new System.Windows.Forms.GroupBox();
            this.Label_Prompt = new System.Windows.Forms.Label();
            this.dcMateriales = new System.Windows.Forms.ComboBox();
            this.Aceptar = new System.Windows.Forms.Button();
            this.Marco.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.SystemColors.Control;
            this.Cancelar.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Cancelar.Location = new System.Drawing.Point(576, 64);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Cancelar.Size = new System.Drawing.Size(89, 25);
            this.Cancelar.TabIndex = 2;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(Cancelar_Click);
            // 
            // Marco
            // 
            this.Marco.BackColor = System.Drawing.SystemColors.Control;
            this.Marco.Controls.Add(this.Label_Prompt);
            this.Marco.Controls.Add(this.dcMateriales);
            this.Marco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Marco.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Marco.Location = new System.Drawing.Point(8, 16);
            this.Marco.Name = "Marco";
            this.Marco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Marco.Size = new System.Drawing.Size(553, 113);
            this.Marco.TabIndex = 0;
            this.Marco.TabStop = false;
            // 
            // Label_Prompt
            // 
            this.Label_Prompt.BackColor = System.Drawing.SystemColors.Control;
            this.Label_Prompt.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_Prompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Prompt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label_Prompt.Location = new System.Drawing.Point(24, 48);
            this.Label_Prompt.Name = "Label_Prompt";
            this.Label_Prompt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label_Prompt.Size = new System.Drawing.Size(177, 25);
            this.Label_Prompt.TabIndex = 4;
            this.Label_Prompt.Text = "Seleccione el artículo:";
            // 
            // dcMateriales
            // 
            this.dcMateriales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dcMateriales.Location = new System.Drawing.Point(208, 48);
            this.dcMateriales.Name = "dcMateriales";
            this.dcMateriales.Size = new System.Drawing.Size(312, 28);
            this.dcMateriales.TabIndex = 4;
            this.dcMateriales.SelectedIndexChanged += new System.EventHandler(this.dcMateriales_SelectedIndexChanged);
            // 
            // Aceptar
            // 
            this.Aceptar.BackColor = System.Drawing.SystemColors.Control;
            this.Aceptar.Cursor = System.Windows.Forms.Cursors.Default;
            this.Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Aceptar.Location = new System.Drawing.Point(576, 24);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Aceptar.Size = new System.Drawing.Size(89, 25);
            this.Aceptar.TabIndex = 1;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = false;
            this.Aceptar.Click += new System.EventHandler(Aceptar_Click);
            // 
            // Form_Prompt_Materiales
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(678, 150);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Marco);
            this.Controls.Add(this.Aceptar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(140, 301);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Prompt_Materiales";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Materiales";
            this.Marco.ResumeLayout(false);
            this.ResumeLayout(false);

    }
#endregion
        // Requerido por el Diseñador de Windows Forms

        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Label Label_Prompt;
        private System.Windows.Forms.GroupBox Marco;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.ComboBox dcMateriales;
}