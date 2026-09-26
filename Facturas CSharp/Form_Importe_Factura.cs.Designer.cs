partial class Form_Importe_Factura : System.Windows.Forms.Form {
   
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

                // Requerido por el Dise�ador de Windows Forms
        this.Frame1 = new System.Windows.Forms.GroupBox();
        this.Text_Cantidad = new System.Windows.Forms.TextBox();
        this.Label_Cantidad = new System.Windows.Forms.Label();
        this.Aceptar = new System.Windows.Forms.Button();
        this.Cancelar = new System.Windows.Forms.Button();
        this.Frame1.SuspendLayout();
        this.SuspendLayout();
        // 
        // Frame1
        // 
        this.Frame1.BackColor = System.Drawing.SystemColors.Control;
        this.Frame1.Controls.Add(this.Text_Cantidad);
        this.Frame1.Controls.Add(this.Label_Cantidad);
        this.Frame1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12, !, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
        this.Frame1.Location = new System.Drawing.Point(16, 16);
        this.Frame1.Name = "Frame1";
        this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.Frame1.Size = new System.Drawing.Size(537, 121);
        this.Frame1.TabIndex = 3;
        this.Frame1.TabStop = false;
        this.Frame1.Text = "Importe";
        this.Text_Cantidad.AcceptsReturn = true;
        this.Text_Cantidad.BackColor = System.Drawing.SystemColors.Window;
        this.Text_Cantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
        this.Text_Cantidad.ForeColor = System.Drawing.SystemColors.WindowText;
        this.Text_Cantidad.Location = new System.Drawing.Point(432, 56);
        this.Text_Cantidad.MaxLength = 0;
        this.Text_Cantidad.Name = "Text_Cantidad";
        this.Text_Cantidad.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.Text_Cantidad.Size = new System.Drawing.Size(89, 23);
        this.Text_Cantidad.TabIndex = 0;
        this.Text_Cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // Label_Cantidad
        // 
        this.Label_Cantidad.BackColor = System.Drawing.SystemColors.Control;
        this.Label_Cantidad.Cursor = System.Windows.Forms.Cursors.Default;
        this.Label_Cantidad.ForeColor = System.Drawing.SystemColors.ControlText;
        this.Label_Cantidad.Location = new System.Drawing.Point(16, 56);
        this.Label_Cantidad.Name = "Label_Cantidad";
        this.Label_Cantidad.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.Label_Cantidad.Size = new System.Drawing.Size(417, 25);
        this.Label_Cantidad.TabIndex = 4;
        this.Label_Cantidad.Text = "Introduzca el importe de la factura sin incluir el iva:";
        this.Aceptar.BackColor = System.Drawing.SystemColors.Control;
        this.Aceptar.Cursor = System.Windows.Forms.Cursors.Default;
        this.Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12, !, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.Aceptar.ForeColor = System.Drawing.SystemColors.ControlText;
        this.Aceptar.Location = new System.Drawing.Point(568, 32);
        this.Aceptar.Name = "Aceptar";
        this.Aceptar.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.Aceptar.Size = new System.Drawing.Size(89, 25);
        this.Aceptar.TabIndex = 1;
        this.Aceptar.Text = "Aceptar";
        this.Aceptar.UseVisualStyleBackColor = false;
        this.Cancelar.BackColor = System.Drawing.SystemColors.Control;
        this.Cancelar.Cursor = System.Windows.Forms.Cursors.Default;
        this.Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12, !, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.Cancelar.ForeColor = System.Drawing.SystemColors.ControlText;
        this.Cancelar.Location = new System.Drawing.Point(568, 72);
        this.Cancelar.Name = "Cancelar";
        this.Cancelar.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.Cancelar.Size = new System.Drawing.Size(89, 25);
        this.Cancelar.TabIndex = 2;
        this.Cancelar.Text = "Cancelar";
        this.Cancelar.UseVisualStyleBackColor = false;
        this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
        this.BackColor = System.Drawing.SystemColors.Control;
        this.ClientSize = new System.Drawing.Size(671, 150);
        this.Controls.Add(this.Frame1);
        this.Controls.Add(this.Aceptar);
        this.Controls.Add(this.Cancelar);
        this.Cursor = System.Windows.Forms.Cursors.Default;
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.Location = new System.Drawing.Point(3, 22);
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "Form_Importe_Factura";
        this.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.ShowInTaskbar = false;
        this.Text = "Importe Factura";
        this.Frame1.ResumeLayout(false);
        this.ResumeLayout(false);
	}
#endregion
        // Requerido por el Diseñador de Windows Forms

        private System.Windows.Forms.TextBox Text_Cantidad;
        private ystem.Windows.Forms.Label Label_Cantidad;
        private System.Windows.Forms.GroupBox Frame1;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button Cancelar;

}