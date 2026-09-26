partial class Form_Proveedores : System.Windows.Forms.Form {
   
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
            this.Text_Nombre = new System.Windows.Forms.TextBox();
            this.Text_NIF = new System.Windows.Forms.TextBox();
            this.Text_Direccion = new System.Windows.Forms.TextBox();
            this.Text_CodPostal = new System.Windows.Forms.TextBox();
            this.Text_Localidad = new System.Windows.Forms.TextBox();
            this.Text_Telefono = new System.Windows.Forms.TextBox();
            this.Marco = new System.Windows.Forms.GroupBox();
            this.Text_Codigo = new System.Windows.Forms.TextBox();
            this.Label_Codigo = new System.Windows.Forms.Label();
            this.Label_Telefono = new System.Windows.Forms.Label();
            this.Label_Localidad = new System.Windows.Forms.Label();
            this.Label_CodPostal = new System.Windows.Forms.Label();
            this.Label_Direccion = new System.Windows.Forms.Label();
            this.Label_NIF = new System.Windows.Forms.Label();
            this.Label_Nombre = new System.Windows.Forms.Label();
            this.Aceptar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Marco.SuspendLayout();
            this.SuspendLayout();
            // 
            // Text_Nombre
            // 
            this.Text_Nombre.AcceptsReturn = true;
            this.Text_Nombre.BackColor = System.Drawing.SystemColors.Window;
            this.Text_Nombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Nombre.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Text_Nombre.Location = new System.Drawing.Point(224, 80);
            this.Text_Nombre.MaxLength = 0;
            this.Text_Nombre.Name = "Text_Nombre";
            this.Text_Nombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text_Nombre.Size = new System.Drawing.Size(297, 26);
            this.Text_Nombre.TabIndex = 1;
            // 
            // Text_NIF
            // 
            this.Text_NIF.AcceptsReturn = true;
            this.Text_NIF.BackColor = System.Drawing.SystemColors.Window;
            this.Text_NIF.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_NIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_NIF.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Text_NIF.Location = new System.Drawing.Point(224, 120);
            this.Text_NIF.MaxLength = 0;
            this.Text_NIF.Name = "Text_NIF";
            this.Text_NIF.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text_NIF.Size = new System.Drawing.Size(129, 26);
            this.Text_NIF.TabIndex = 2;
            // 
            // Text_Direccion
            // 
            this.Text_Direccion.AcceptsReturn = true;
            this.Text_Direccion.BackColor = System.Drawing.SystemColors.Window;
            this.Text_Direccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_Direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Direccion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Text_Direccion.Location = new System.Drawing.Point(224, 160);
            this.Text_Direccion.MaxLength = 0;
            this.Text_Direccion.Name = "Text_Direccion";
            this.Text_Direccion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text_Direccion.Size = new System.Drawing.Size(297, 26);
            this.Text_Direccion.TabIndex = 3;
            // 
            // Text_CodPostal
            // 
            this.Text_CodPostal.AcceptsReturn = true;
            this.Text_CodPostal.BackColor = System.Drawing.SystemColors.Window;
            this.Text_CodPostal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_CodPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_CodPostal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Text_CodPostal.Location = new System.Drawing.Point(224, 208);
            this.Text_CodPostal.MaxLength = 0;
            this.Text_CodPostal.Name = "Text_CodPostal";
            this.Text_CodPostal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text_CodPostal.Size = new System.Drawing.Size(81, 26);
            this.Text_CodPostal.TabIndex = 4;
            this.Text_CodPostal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Text_Localidad
            // 
            this.Text_Localidad.AcceptsReturn = true;
            this.Text_Localidad.BackColor = System.Drawing.SystemColors.Window;
            this.Text_Localidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_Localidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Localidad.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Text_Localidad.Location = new System.Drawing.Point(224, 248);
            this.Text_Localidad.MaxLength = 0;
            this.Text_Localidad.Name = "Text_Localidad";
            this.Text_Localidad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text_Localidad.Size = new System.Drawing.Size(297, 26);
            this.Text_Localidad.TabIndex = 5;
            // 
            // Text_Telefono
            // 
            this.Text_Telefono.AcceptsReturn = true;
            this.Text_Telefono.BackColor = System.Drawing.SystemColors.Window;
            this.Text_Telefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Telefono.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Text_Telefono.Location = new System.Drawing.Point(224, 288);
            this.Text_Telefono.MaxLength = 0;
            this.Text_Telefono.Name = "Text_Telefono";
            this.Text_Telefono.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text_Telefono.Size = new System.Drawing.Size(129, 26);
            this.Text_Telefono.TabIndex = 6;
            this.Text_Telefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Marco
            // 
            this.Marco.BackColor = System.Drawing.SystemColors.Control;
            this.Marco.Controls.Add(this.Text_Codigo);
            this.Marco.Controls.Add(this.Label_Codigo);
            this.Marco.Controls.Add(this.Label_Telefono);
            this.Marco.Controls.Add(this.Label_Localidad);
            this.Marco.Controls.Add(this.Label_CodPostal);
            this.Marco.Controls.Add(this.Label_Direccion);
            this.Marco.Controls.Add(this.Label_NIF);
            this.Marco.Controls.Add(this.Label_Nombre);
            this.Marco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Marco.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Marco.Location = new System.Drawing.Point(16, 16);
            this.Marco.Name = "Marco";
            this.Marco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Marco.Size = new System.Drawing.Size(569, 313);
            this.Marco.TabIndex = 9;
            this.Marco.TabStop = false;
            this.Marco.Text = "Proveedores";
            // 
            // Text_Codigo
            // 
            this.Text_Codigo.AcceptsReturn = true;
            this.Text_Codigo.BackColor = System.Drawing.SystemColors.Window;
            this.Text_Codigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_Codigo.Enabled = false;
            this.Text_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Codigo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Text_Codigo.Location = new System.Drawing.Point(208, 24);
            this.Text_Codigo.MaxLength = 0;
            this.Text_Codigo.Name = "Text_Codigo";
            this.Text_Codigo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text_Codigo.Size = new System.Drawing.Size(81, 26);
            this.Text_Codigo.TabIndex = 0;
            this.Text_Codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label_Codigo
            // 
            this.Label_Codigo.BackColor = System.Drawing.SystemColors.Control;
            this.Label_Codigo.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_Codigo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label_Codigo.Location = new System.Drawing.Point(40, 32);
            this.Label_Codigo.Name = "Label_Codigo";
            this.Label_Codigo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label_Codigo.Size = new System.Drawing.Size(81, 25);
            this.Label_Codigo.TabIndex = 16;
            this.Label_Codigo.Text = "Código";
            // 
            // Label_Telefono
            // 
            this.Label_Telefono.BackColor = System.Drawing.SystemColors.Control;
            this.Label_Telefono.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_Telefono.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label_Telefono.Location = new System.Drawing.Point(40, 272);
            this.Label_Telefono.Name = "Label_Telefono";
            this.Label_Telefono.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label_Telefono.Size = new System.Drawing.Size(81, 25);
            this.Label_Telefono.TabIndex = 15;
            this.Label_Telefono.Text = "Teléfono";
            // 
            // Label_Localidad
            // 
            this.Label_Localidad.BackColor = System.Drawing.SystemColors.Control;
            this.Label_Localidad.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_Localidad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label_Localidad.Location = new System.Drawing.Point(40, 232);
            this.Label_Localidad.Name = "Label_Localidad";
            this.Label_Localidad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label_Localidad.Size = new System.Drawing.Size(89, 25);
            this.Label_Localidad.TabIndex = 14;
            this.Label_Localidad.Text = "Localidad";
            // 
            // Label_CodPostal
            // 
            this.Label_CodPostal.BackColor = System.Drawing.SystemColors.Control;
            this.Label_CodPostal.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_CodPostal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label_CodPostal.Location = new System.Drawing.Point(40, 192);
            this.Label_CodPostal.Name = "Label_CodPostal";
            this.Label_CodPostal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label_CodPostal.Size = new System.Drawing.Size(113, 25);
            this.Label_CodPostal.TabIndex = 13;
            this.Label_CodPostal.Text = "Código Postal";
            // 
            // Label_Direccion
            // 
            this.Label_Direccion.BackColor = System.Drawing.SystemColors.Control;
            this.Label_Direccion.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_Direccion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label_Direccion.Location = new System.Drawing.Point(40, 152);
            this.Label_Direccion.Name = "Label_Direccion";
            this.Label_Direccion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label_Direccion.Size = new System.Drawing.Size(89, 17);
            this.Label_Direccion.TabIndex = 12;
            this.Label_Direccion.Text = "Dirección";
            // 
            // Label_NIF
            // 
            this.Label_NIF.BackColor = System.Drawing.SystemColors.Control;
            this.Label_NIF.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_NIF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label_NIF.Location = new System.Drawing.Point(40, 112);
            this.Label_NIF.Name = "Label_NIF";
            this.Label_NIF.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label_NIF.Size = new System.Drawing.Size(81, 17);
            this.Label_NIF.TabIndex = 11;
            this.Label_NIF.Text = "NIF";
            // 
            // Label_Nombre
            // 
            this.Label_Nombre.BackColor = System.Drawing.SystemColors.Control;
            this.Label_Nombre.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_Nombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label_Nombre.Location = new System.Drawing.Point(40, 72);
            this.Label_Nombre.Name = "Label_Nombre";
            this.Label_Nombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label_Nombre.Size = new System.Drawing.Size(81, 25);
            this.Label_Nombre.TabIndex = 10;
            this.Label_Nombre.Text = "Nombre";
            // 
            // Aceptar
            // 
            this.Aceptar.BackColor = System.Drawing.SystemColors.Control;
            this.Aceptar.Cursor = System.Windows.Forms.Cursors.Default;
            this.Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Aceptar.Location = new System.Drawing.Point(600, 32);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Aceptar.Size = new System.Drawing.Size(89, 25);
            this.Aceptar.TabIndex = 7;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = false;
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.SystemColors.Control;
            this.Cancelar.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Cancelar.Location = new System.Drawing.Point(600, 72);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Cancelar.Size = new System.Drawing.Size(89, 25);
            this.Cancelar.TabIndex = 8;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            // 
            // Form_Proveedores
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(702, 342);
            this.Controls.Add(this.Text_Nombre);
            this.Controls.Add(this.Text_NIF);
            this.Controls.Add(this.Text_Direccion);
            this.Controls.Add(this.Text_CodPostal);
            this.Controls.Add(this.Text_Localidad);
            this.Controls.Add(this.Text_Telefono);
            this.Controls.Add(this.Marco);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.Cancelar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(3, 22);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Proveedores";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.Text = "Proveedores";
            this.Marco.ResumeLayout(false);
            this.Marco.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    
        #endregion

        private System.Windows.Forms.TextBox Text_Nombre;
        private System.Windows.Forms.TextBox Text_NIF;
        private System.Windows.Forms.TextBox Text_Direccion;
        private System.Windows.Forms.TextBox Text_CodPostal;
        private System.Windows.Forms.TextBox Text_Localidad;
        private System.Windows.Forms.TextBox Text_Telefono;
        private System.Windows.Forms.TextBox Text_Codigo;
        private System.Windows.Forms.Label Label_Codigo;
        private System.Windows.Forms.Label Label_Telefono;
        private System.Windows.Forms.Label Label_Localidad;
        private System.Windows.Forms.Label Label_CodPostal;
        private System.Windows.Forms.Label Label_Direccion;
        private System.Windows.Forms.Label Label_NIF;
        private System.Windows.Forms.Label Label_Nombre;
        private System.Windows.Forms.GroupBox Marco;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button Cancelar;
}