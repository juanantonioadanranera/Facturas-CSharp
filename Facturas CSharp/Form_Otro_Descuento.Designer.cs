partial class Form_Otro_Descuento : System.Windows.Forms.Form {
   
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
		this.Aceptar = new System.Windows.Forms.Button();
        this.Cancelar = new System.Windows.Forms.Button();
        this.Marco = new System.Windows.Forms.GroupBox();
        this.Text_Concepto = new System.Windows.Forms.TextBox();
        this.Label1 = new System.Windows.Forms.Label();
        this.Label_Titulo = new System.Windows.Forms.Label();
        this.Marco.SuspendLayout();
        this.SuspendLayout();
        // 
        // Aceptar
        // 
        this.Aceptar.BackColor = System.Drawing.SystemColors.Control;
        this.Aceptar.Cursor = System.Windows.Forms.Cursors.Default;
        this.Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.Aceptar.ForeColor = System.Drawing.SystemColors.ControlText;
        this.Aceptar.Location = new System.Drawing.Point(488, 24);
        this.Aceptar.Name = "Aceptar";
        this.Aceptar.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.Aceptar.Size = new System.Drawing.Size(89, 25);
        this.Aceptar.TabIndex = 5;
        this.Aceptar.Text = "Aceptar";
        this.Aceptar.UseVisualStyleBackColor = false;
        this.Cancelar.BackColor = System.Drawing.SystemColors.Control;
        this.Cancelar.Cursor = System.Windows.Forms.Cursors.Default;
        this.Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.Cancelar.ForeColor = System.Drawing.SystemColors.ControlText;
        this.Cancelar.Location = new System.Drawing.Point(488, 64);
        this.Cancelar.Name = "Cancelar";
        this.Cancelar.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.Cancelar.Size = new System.Drawing.Size(89, 25);
        this.Cancelar.TabIndex = 4;
        this.Cancelar.Text = "Cancelar";
        this.Cancelar.UseVisualStyleBackColor = false;
        this.Marco.BackColor = System.Drawing.SystemColors.Control;
        this.Marco.Controls.Add(this.Text_Concepto);
        this.Marco.Controls.Add(this.Label1);
        this.Marco.Controls.Add(this.Label_Titulo);
        this.Marco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.Marco.ForeColor = System.Drawing.SystemColors.ControlText;
        this.Marco.Location = new System.Drawing.Point(8, 8);
        this.Marco.Name = "Marco";
        this.Marco.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.Marco.Size = new System.Drawing.Size(465, 145);
        this.Marco.TabIndex = 0;
        this.Marco.TabStop = false;
        this.Text_Concepto.AcceptsReturn = true;
        this.Text_Concepto.BackColor = System.Drawing.SystemColors.Window;
        this.Text_Concepto.Cursor = System.Windows.Forms.Cursors.IBeam;
        this.Text_Concepto.ForeColor = System.Drawing.SystemColors.WindowText;
        this.Text_Concepto.Location = new System.Drawing.Point(168, 88);
        this.Text_Concepto.MaxLength = 0;
        this.Text_Concepto.Name = "Text_Concepto";
        this.Text_Concepto.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.Text_Concepto.Size = new System.Drawing.Size(249, 28);
        this.Text_Concepto.TabIndex = 3;
        // 
        // Label1
        // 
        this.Label1.BackColor = System.Drawing.SystemColors.Control;
        this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
        this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
        this.Label1.Location = new System.Drawing.Point(32, 96);
        this.Label1.Name = "Label1";
        this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.Label1.Size = new System.Drawing.Size(129, 25);
        this.Label1.TabIndex = 2;
        this.Label1.Text = "Descuento por:";
        this.Label_Titulo.BackColor = System.Drawing.SystemColors.Control;
        this.Label_Titulo.Cursor = System.Windows.Forms.Cursors.Default;
        this.Label_Titulo.ForeColor = System.Drawing.SystemColors.ControlText;
        this.Label_Titulo.Location = new System.Drawing.Point(16, 32);
        this.Label_Titulo.Name = "Label_Titulo";
        this.Label_Titulo.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.Label_Titulo.Size = new System.Drawing.Size(433, 33);
        this.Label_Titulo.TabIndex = 1;
        this.Label_Titulo.Text = "Introduzca el concepto por que se hace el descuento:";
        this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
        this.BackColor = System.Drawing.SystemColors.Control;
        this.ClientSize = new System.Drawing.Size(590, 171);
        this.Controls.Add(this.Aceptar);
        this.Controls.Add(this.Cancelar);
        this.Controls.Add(this.Marco);
        this.Cursor = System.Windows.Forms.Cursors.Default;
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.Location = new System.Drawing.Point(3, 22);
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "Form_Otro_Descuento";
        this.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.ShowInTaskbar = false;
        this.Text = "Concepto de Descuento";
        this.Marco.ResumeLayout(false);
        this.ResumeLayout(false);
	}
#endregion
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.TextBox Text_Concepto;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label_Titulo;
        private System.Windows.Forms.GroupBox Marco;
}