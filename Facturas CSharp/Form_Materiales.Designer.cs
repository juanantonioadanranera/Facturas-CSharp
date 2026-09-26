partial class Form_Materiales : System.Windows.Forms.Form {
   
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
            this.Text_Codigo = new System.Windows.Forms.TextBox();
            this.Text_Descripcion = new System.Windows.Forms.TextBox();
            this.Text_Precio = new System.Windows.Forms.TextBox();
            this.Label_Codigo = new System.Windows.Forms.Label();
            this.Label_Descripcion = new System.Windows.Forms.Label();
            this.Label_Precio = new System.Windows.Forms.Label();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Aceptar = new System.Windows.Forms.Button();
            this.Marco.SuspendLayout();
            this.SuspendLayout();
            // 
            // Marco
            // 
            this.Marco.BackColor = System.Drawing.SystemColors.Control;
            this.Marco.Controls.Add(this.Text_Codigo);
            this.Marco.Controls.Add(this.Text_Descripcion);
            this.Marco.Controls.Add(this.Text_Precio);
            this.Marco.Controls.Add(this.Label_Codigo);
            this.Marco.Controls.Add(this.Label_Descripcion);
            this.Marco.Controls.Add(this.Label_Precio);
            this.Marco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Marco.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Marco.Location = new System.Drawing.Point(16, 8);
            this.Marco.Name = "Marco";
            this.Marco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Marco.Size = new System.Drawing.Size(449, 169);
            this.Marco.TabIndex = 0;
            this.Marco.TabStop = false;
            this.Marco.Text = "Materiales";
            // 
            // Text_Codigo
            // 
            this.Text_Codigo.AcceptsReturn = true;
            this.Text_Codigo.BackColor = System.Drawing.SystemColors.Window;
            this.Text_Codigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_Codigo.Enabled = false;
            this.Text_Codigo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Text_Codigo.Location = new System.Drawing.Point(136, 32);
            this.Text_Codigo.MaxLength = 0;
            this.Text_Codigo.Name = "Text_Codigo";
            this.Text_Codigo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text_Codigo.Size = new System.Drawing.Size(57, 26);
            this.Text_Codigo.TabIndex = 4;
            // 
            // Text_Descripcion
            // 
            this.Text_Descripcion.AcceptsReturn = true;
            this.Text_Descripcion.BackColor = System.Drawing.SystemColors.Window;
            this.Text_Descripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_Descripcion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Text_Descripcion.Location = new System.Drawing.Point(136, 80);
            this.Text_Descripcion.MaxLength = 0;
            this.Text_Descripcion.Name = "Text_Descripcion";
            this.Text_Descripcion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text_Descripcion.Size = new System.Drawing.Size(297, 26);
            this.Text_Descripcion.TabIndex = 5;
            // 
            // Text_Precio
            // 
            this.Text_Precio.AcceptsReturn = true;
            this.Text_Precio.BackColor = System.Drawing.SystemColors.Window;
            this.Text_Precio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_Precio.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Text_Precio.Location = new System.Drawing.Point(136, 128);
            this.Text_Precio.MaxLength = 0;
            this.Text_Precio.Name = "Text_Precio";
            this.Text_Precio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text_Precio.Size = new System.Drawing.Size(57, 26);
            this.Text_Precio.TabIndex = 6;
            // 
            // Label_Codigo
            // 
            this.Label_Codigo.AutoSize = true;
            this.Label_Codigo.BackColor = System.Drawing.SystemColors.Control;
            this.Label_Codigo.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_Codigo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label_Codigo.Location = new System.Drawing.Point(16, 32);
            this.Label_Codigo.Name = "Label_Codigo";
            this.Label_Codigo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label_Codigo.Size = new System.Drawing.Size(65, 20);
            this.Label_Codigo.TabIndex = 1;
            this.Label_Codigo.Text = "Código";
            // 
            // Label_Descripcion
            // 
            this.Label_Descripcion.AutoSize = true;
            this.Label_Descripcion.BackColor = System.Drawing.SystemColors.Control;
            this.Label_Descripcion.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_Descripcion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label_Descripcion.Location = new System.Drawing.Point(16, 80);
            this.Label_Descripcion.Name = "Label_Descripcion";
            this.Label_Descripcion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label_Descripcion.Size = new System.Drawing.Size(103, 20);
            this.Label_Descripcion.TabIndex = 2;
            this.Label_Descripcion.Text = "Descripción";
            // 
            // Label_Precio
            // 
            this.Label_Precio.BackColor = System.Drawing.SystemColors.Control;
            this.Label_Precio.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_Precio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label_Precio.Location = new System.Drawing.Point(16, 128);
            this.Label_Precio.Name = "Label_Precio";
            this.Label_Precio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label_Precio.Size = new System.Drawing.Size(89, 25);
            this.Label_Precio.TabIndex = 3;
            this.Label_Precio.Text = "Precio";
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.SystemColors.Control;
            this.Cancelar.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Cancelar.Location = new System.Drawing.Point(480, 64);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Cancelar.Size = new System.Drawing.Size(89, 25);
            this.Cancelar.TabIndex = 8;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(Cancelar_Click);
            // 
            // Aceptar
            // 
            this.Aceptar.BackColor = System.Drawing.SystemColors.Control;
            this.Aceptar.Cursor = System.Windows.Forms.Cursors.Default;
            this.Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Aceptar.Location = new System.Drawing.Point(480, 24);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Aceptar.Size = new System.Drawing.Size(89, 25);
            this.Aceptar.TabIndex = 7;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = false;
            this.Aceptar.Click += new System.EventHandler(Aceptar_Click);
            // 
            // Form_Materiales
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(584, 200);
            this.Controls.Add(this.Marco);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Aceptar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(309, 372);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Materiales";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Materiales";
            this.Load += new System.EventHandler(Form_Materiales_Load);
            this.Marco.ResumeLayout(false);
            this.Marco.PerformLayout();
            this.ResumeLayout(false);

    }
    
        #endregion

        // Requerido por el Diseñador de Windows Forms
        private System.Windows.Forms.TextBox Text_Codigo;
        private System.Windows.Forms.TextBox Text_Descripcion;
        private System.Windows.Forms.TextBox Text_Precio;
        private System.Windows.Forms.Label Label_Codigo;
        private System.Windows.Forms.Label Label_Descripcion;
        private System.Windows.Forms.Label Label_Precio;
        private System.Windows.Forms.GroupBox Marco;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Aceptar;
}