partial class Form_Cantidad : System.Windows.Forms.Form {
   
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

        // Requerido por el Diseñador de Windows Forms

        this.Cancelar = new System.Windows.Forms.Button();
        this.Aceptar = new System.Windows.Forms.Button();
        this.Frame1 = new System.Windows.Forms.GroupBox();
        this.dcMateriales = new System.Windows.Forms.ComboBox();
        this.Text_Cantidad = new System.Windows.Forms.TextBox();
        this.Label_Articulo = new System.Windows.Forms.Label();
        this.Label_Cantidad = new System.Windows.Forms.Label();
        this.Frame1.SuspendLayout();
        this.SuspendLayout();
        // 
        // Cancelar
        // 
        this.Cancelar.BackColor = System.Drawing.SystemColors.Control;
        this.Cancelar.Cursor = System.Windows.Forms.Cursors.Default;
        this.Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.Cancelar.ForeColor = System.Drawing.SystemColors.ControlText;
        this.Cancelar.Location = new System.Drawing.Point(560, 72);
        this.Cancelar.Name = "Cancelar";
        this.Cancelar.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.Cancelar.Size = new System.Drawing.Size(89, 25);
        this.Cancelar.TabIndex = 3;
        this.Cancelar.Text = "Cancelar";
        this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(Cancelar_Click);
        this.Aceptar.BackColor = System.Drawing.SystemColors.Control;
        this.Aceptar.Cursor = System.Windows.Forms.Cursors.Default;
        this.Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.Aceptar.ForeColor = System.Drawing.SystemColors.ControlText;
        this.Aceptar.Location = new System.Drawing.Point(560, 32);
        this.Aceptar.Name = "Aceptar";
        this.Aceptar.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.Aceptar.Size = new System.Drawing.Size(89, 25);
        this.Aceptar.TabIndex = 2;
        this.Aceptar.Text = "Aceptar";
        this.Aceptar.UseVisualStyleBackColor = false;
            this.Aceptar.Click += new System.EventHandler(Aceptar_Click);
        this.Frame1.BackColor = System.Drawing.SystemColors.Control;
        this.Frame1.Controls.Add(this.dcMateriales);
        this.Frame1.Controls.Add(this.Text_Cantidad);
        this.Frame1.Controls.Add(this.Label_Articulo);
        this.Frame1.Controls.Add(this.Label_Cantidad);
        this.Frame1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
        this.Frame1.Location = new System.Drawing.Point(16, 16);
        this.Frame1.Name = "Frame1";
        this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.Frame1.Size = new System.Drawing.Size(529, 169);
        this.Frame1.TabIndex = 4;
        this.Frame1.TabStop = false;
        this.Frame1.Text = "Cantidad";
        this.dcMateriales.DisplayMember = "DESCRIPCION";
        this.dcMateriales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.dcMateriales.Location = new System.Drawing.Point(216, 104);
        this.dcMateriales.Name = "dcMateriales";
        this.dcMateriales.Size = new System.Drawing.Size(288, 28);
        this.dcMateriales.TabIndex = 1;
        // 
        // Text_Cantidad
        // 
        this.Text_Cantidad.AcceptsReturn = true;
        this.Text_Cantidad.BackColor = System.Drawing.SystemColors.Window;
        this.Text_Cantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
        this.Text_Cantidad.ForeColor = System.Drawing.SystemColors.WindowText;
        this.Text_Cantidad.Location = new System.Drawing.Point(216, 48);
        this.Text_Cantidad.MaxLength = 0;
        this.Text_Cantidad.Name = "Text_Cantidad";
        this.Text_Cantidad.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.Text_Cantidad.Size = new System.Drawing.Size(73, 26);
        this.Text_Cantidad.TabIndex = 0;
        this.Text_Cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // Label_Articulo
        // 
        this.Label_Articulo.BackColor = System.Drawing.SystemColors.Control;
        this.Label_Articulo.Cursor = System.Windows.Forms.Cursors.Default;
        this.Label_Articulo.ForeColor = System.Drawing.SystemColors.ControlText;
        this.Label_Articulo.Location = new System.Drawing.Point(16, 104);
        this.Label_Articulo.Name = "Label_Articulo";
        this.Label_Articulo.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.Label_Articulo.Size = new System.Drawing.Size(193, 25);
        this.Label_Articulo.TabIndex = 6;
        this.Label_Articulo.Text = "Seleccione el artículo:";
        this.Label_Cantidad.BackColor = System.Drawing.SystemColors.Control;
        this.Label_Cantidad.Cursor = System.Windows.Forms.Cursors.Default;
        this.Label_Cantidad.ForeColor = System.Drawing.SystemColors.ControlText;
        this.Label_Cantidad.Location = new System.Drawing.Point(16, 56);
        this.Label_Cantidad.Name = "Label_Cantidad";
        this.Label_Cantidad.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.Label_Cantidad.Size = new System.Drawing.Size(193, 25);
        this.Label_Cantidad.TabIndex = 5;
        this.Label_Cantidad.Text = "Introduzca la cantidad:";
        this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
        this.BackColor = System.Drawing.SystemColors.Control;
        this.ClientSize = new System.Drawing.Size(670, 198);
        this.Controls.Add(this.Cancelar);
        this.Controls.Add(this.Aceptar);
        this.Controls.Add(this.Frame1);
        this.Cursor = System.Windows.Forms.Cursors.Default;
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.Location = new System.Drawing.Point(185, 301);
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "Form_Cantidad";
        this.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
        this.Text = "Albaranes";
        this.Frame1.ResumeLayout(false);
        this.Frame1.PerformLayout();
        this.ResumeLayout(false);
            this.Load += new System.EventHandler(Form_Cantidad_Load);
            this.Shown += new System.EventHandler(Form_Cantidad_Shown);
    }
#endregion
        // Requerido por el Diseñador de Windows Forms

        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Aceptar;
        public System.Windows.Forms.TextBox Text_Cantidad;
        private System.Windows.Forms.Label Label_Articulo;
        private System.Windows.Forms.Label Label_Cantidad;
        private System.Windows.Forms.GroupBox Frame1; 
        public System.Windows.Forms.ComboBox dcMateriales;
}