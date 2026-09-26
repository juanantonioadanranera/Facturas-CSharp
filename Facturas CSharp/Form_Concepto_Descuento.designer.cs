partial class Form_Concepto_Descuento : System.Windows.Forms.Form {
   
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

        this.components = new System.ComponentModel.Container();
        this.cConcepto = new System.Windows.Forms.ComboBox();
        this.Otro = new System.Windows.Forms.Button();
        this.Cancelar = new System.Windows.Forms.Button();
        this.Aceptar = new System.Windows.Forms.Button();
        this.Frame1 = new System.Windows.Forms.GroupBox();
        this.Label1 = new System.Windows.Forms.Label();
        this.Label_Titulo = new System.Windows.Forms.Label();
        this.Frame1.SuspendLayout();
        this.SuspendLayout();
        // 
        // cConcepto
        // 
        this.cConcepto.BackColor = System.Drawing.SystemColors.Window;
        this.cConcepto.Cursor = System.Windows.Forms.Cursors.Default;
        this.cConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.cConcepto.ForeColor = System.Drawing.SystemColors.WindowText;
        this.cConcepto.Location = new System.Drawing.Point(176, 80);
        this.cConcepto.Name = "cConcepto";
        this.cConcepto.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.cConcepto.Size = new System.Drawing.Size(289, 28);
        this.cConcepto.TabIndex = 6;
        // 
        // Otro
        // 
        this.Otro.BackColor = System.Drawing.SystemColors.Control;
        this.Otro.Cursor = System.Windows.Forms.Cursors.Default;
        this.Otro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.Otro.ForeColor = System.Drawing.SystemColors.ControlText;
        this.Otro.Location = new System.Drawing.Point(512, 96);
        this.Otro.Name = "Otro";
        this.Otro.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.Otro.Size = new System.Drawing.Size(89, 25);
        this.Otro.TabIndex = 5;
        this.Otro.Text = "Otro";
        this.Otro.UseVisualStyleBackColor = false;
            this.Otro.Click += new System.EventHandler(Otro_Click);
        this.Cancelar.BackColor = System.Drawing.SystemColors.Control;
        this.Cancelar.Cursor = System.Windows.Forms.Cursors.Default;
        this.Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.Cancelar.ForeColor = System.Drawing.SystemColors.ControlText;
        this.Cancelar.Location = new System.Drawing.Point(512, 56);
        this.Cancelar.Name = "Cancelar";
        this.Cancelar.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.Cancelar.Size = new System.Drawing.Size(89, 25);
        this.Cancelar.TabIndex = 4;
        this.Cancelar.Text = "Cancelar";
        this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(Cancelar_Click);
        this.Aceptar.BackColor = System.Drawing.SystemColors.Control;
        this.Aceptar.Cursor = System.Windows.Forms.Cursors.Default;
        this.Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.Aceptar.ForeColor = System.Drawing.SystemColors.ControlText;
        this.Aceptar.Location = new System.Drawing.Point(512, 16);
        this.Aceptar.Name = "Aceptar";
        this.Aceptar.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.Aceptar.Size = new System.Drawing.Size(89, 25);
        this.Aceptar.TabIndex = 3;
        this.Aceptar.Text = "Aceptar";
        this.Aceptar.UseVisualStyleBackColor = false;
            this.Aceptar.Click += new System.EventHandler(Aceptar_Click);
        this.Frame1.BackColor = System.Drawing.SystemColors.Control;
        this.Frame1.Controls.Add(this.Label1);
        this.Frame1.Controls.Add(this.Label_Titulo);
        this.Frame1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
        this.Frame1.Location = new System.Drawing.Point(16, 16);
        this.Frame1.Name = "Frame1";
        this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.Frame1.Size = new System.Drawing.Size(473, 113);
        this.Frame1.TabIndex = 0;
        this.Frame1.TabStop = false;
        this.Frame1.Text = "Descuento";
        this.Label1.BackColor = System.Drawing.SystemColors.Control;
        this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
        this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
        this.Label1.Location = new System.Drawing.Point(16, 72);
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
        this.ClientSize = new System.Drawing.Size(615, 142);
        this.Controls.Add(this.cConcepto);
        this.Controls.Add(this.Otro);
        this.Controls.Add(this.Cancelar);
        this.Controls.Add(this.Aceptar);
        this.Controls.Add(this.Frame1);
        this.Cursor = System.Windows.Forms.Cursors.Default;
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.Location = new System.Drawing.Point(3, 22);
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "Form_Concepto_Descuento";
        this.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.ShowInTaskbar = false;
        this.Text = "Concepto de Descuento";
        this.Frame1.ResumeLayout(false);
        this.ResumeLayout(false);
            this.Load += new System.EventHandler(Form_Concepto_Descuento_Load);

	}
#endregion
    // Requerido por el Diseñador de Windows Forms
    private System.Windows.Forms.ComboBox cConcepto;
    private System.Windows.Forms.Button Otro;
    private System.Windows.Forms.Button Cancelar;
    private System.Windows.Forms.Button Aceptar;
    private System.Windows.Forms.Label Label1;
    private System.Windows.Forms.Label Label_Titulo;
    private System.Windows.Forms.GroupBox Frame1;
}