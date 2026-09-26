partial class Form_Tipo_Iva : System.Windows.Forms.Form {
   
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
        this.Marco = new System.Windows.Forms.GroupBox();
        this.cTipoIVA = new System.Windows.Forms.ComboBox();
        this.Label_IVA = new System.Windows.Forms.Label();
        this.Aceptar = new System.Windows.Forms.Button();
        this.Cancelar = new System.Windows.Forms.Button();
        this.Marco.SuspendLayout();
        this.SuspendLayout();
        // 
        // Marco
        // 
        this.Marco.BackColor = System.Drawing.SystemColors.Control;
        this.Marco.Controls.Add(this.cTipoIVA);
        this.Marco.Controls.Add(this.Label_IVA);
        this.Marco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.Marco.ForeColor = System.Drawing.SystemColors.ControlText;
        this.Marco.Location = new System.Drawing.Point(16, 16);
        this.Marco.Name = "Marco";
        this.Marco.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.Marco.Size = new System.Drawing.Size(417, 121);
        this.Marco.TabIndex = 3;
        this.Marco.TabStop = false;
        this.Marco.Text = "Tipo de IVA";
        this.cTipoIVA.BackColor = System.Drawing.SystemColors.Window;
        this.cTipoIVA.Cursor = System.Windows.Forms.Cursors.Default;
        this.cTipoIVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cTipoIVA.ForeColor = System.Drawing.SystemColors.WindowText;
        this.cTipoIVA.Location = new System.Drawing.Point(312, 48);
        this.cTipoIVA.Name = "cTipoIVA";
        this.cTipoIVA.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.cTipoIVA.Size = new System.Drawing.Size(73, 28);
        this.cTipoIVA.TabIndex = 0;
        // 
        // Label_IVA
        // 
        this.Label_IVA.BackColor = System.Drawing.SystemColors.Control;
        this.Label_IVA.Cursor = System.Windows.Forms.Cursors.Default;
        this.Label_IVA.ForeColor = System.Drawing.SystemColors.ControlText;
        this.Label_IVA.Location = new System.Drawing.Point(16, 56);
        this.Label_IVA.Name = "Label_IVA";
        this.Label_IVA.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.Label_IVA.Size = new System.Drawing.Size(289, 25);
        this.Label_IVA.TabIndex = 4;
        this.Label_IVA.Text = "Seleccione el tipo de IVA aplicable";
        this.Aceptar.BackColor = System.Drawing.SystemColors.Control;
        this.Aceptar.Cursor = System.Windows.Forms.Cursors.Default;
        this.Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.Aceptar.ForeColor = System.Drawing.SystemColors.ControlText;
        this.Aceptar.Location = new System.Drawing.Point(448, 32);
        this.Aceptar.Name = "Aceptar";
        this.Aceptar.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.Aceptar.Size = new System.Drawing.Size(89, 25);
        this.Aceptar.TabIndex = 1;
        this.Aceptar.Text = "Aceptar";
            this.Aceptar.Click += new System.EventHandler(Aceptar_Click);
        this.Cancelar.BackColor = System.Drawing.SystemColors.Control;
        this.Cancelar.Cursor = System.Windows.Forms.Cursors.Default;
        this.Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.Cancelar.ForeColor = System.Drawing.SystemColors.ControlText;
        this.Cancelar.Location = new System.Drawing.Point(448, 72);
        this.Cancelar.Name = "Cancelar";
        this.Cancelar.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.Cancelar.Size = new System.Drawing.Size(89, 25);
        this.Cancelar.TabIndex = 2;
        this.Cancelar.Text = "Cancelar";
            this.Cancelar.Click += new System.EventHandler(Cancelar_Click);
        this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
        this.BackColor = System.Drawing.SystemColors.Control;
        this.ClientSize = new System.Drawing.Size(546, 151);
        this.Controls.Add(this.Marco);
        this.Controls.Add(this.Aceptar);
        this.Controls.Add(this.Cancelar);
        this.Cursor = System.Windows.Forms.Cursors.Default;
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.Location = new System.Drawing.Point(3, 22);
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "Form_Tipo_Iva";
        this.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.ShowInTaskbar = false;
        this.Text = "Tipo de IVA";
        this.Marco.ResumeLayout(false);
        this.ResumeLayout(false);
            this.Load += new System.EventHandler(Form_Tipo_Iva_Load);

    }
#endregion
        // Requerido por el Diseñador de Windows Forms

        private System.Windows.Forms.ComboBox cTipoIVA;
        private System.Windows.Forms.Label Label_IVA;
        private System.Windows.Forms.GroupBox Marco;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button Cancelar;
}