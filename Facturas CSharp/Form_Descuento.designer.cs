partial class Form_Descuento : System.Windows.Forms.Form {
   
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

        this.Cancelar = new System.Windows.Forms.Button();
        this.Aceptar = new System.Windows.Forms.Button();
        this.Frame1 = new System.Windows.Forms.GroupBox();
        this._cDescuento_1 = new System.Windows.Forms.ComboBox();
        this._cDescuento_0 = new System.Windows.Forms.ComboBox();
        this._Label_1 = new System.Windows.Forms.Label();
        this._Label_0 = new System.Windows.Forms.Label();
        this.Label_Cantidad = new System.Windows.Forms.Label();
        //this.Label = new Microsoft.VisualBasic.Compatibility.VB6.LabelArray(this.components);
        //this.cDescuento = new Microsoft.VisualBasic.Compatibility.VB6.ComboBoxArray(this.components);
        this.Frame1.SuspendLayout();
        //((System.ComponentModel.ISupportInitialize)(this.Label)).BeginInit();
        //((System.ComponentModel.ISupportInitialize)(this.cDescuento)).BeginInit();
        this.SuspendLayout();
        // 
        // Cancelar
        // 
        this.Cancelar.BackColor = System.Drawing.SystemColors.Control;
        this.Cancelar.Cursor = System.Windows.Forms.Cursors.Default;
        this.Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.Cancelar.ForeColor = System.Drawing.SystemColors.ControlText;
        this.Cancelar.Location = new System.Drawing.Point(536, 72);
        this.Cancelar.Name = "Cancelar";
        this.Cancelar.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.Cancelar.Size = new System.Drawing.Size(89, 25);
        this.Cancelar.TabIndex = 3;
        this.Cancelar.Text = "Cancelar";
            this.Cancelar.Click += new System.EventHandler(Cancelar_Click);
        this.Aceptar.BackColor = System.Drawing.SystemColors.Control;
        this.Aceptar.Cursor = System.Windows.Forms.Cursors.Default;
        this.Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.Aceptar.ForeColor = System.Drawing.SystemColors.ControlText;
        this.Aceptar.Location = new System.Drawing.Point(536, 32);
        this.Aceptar.Name = "Aceptar";
        this.Aceptar.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.Aceptar.Size = new System.Drawing.Size(89, 25);
        this.Aceptar.TabIndex = 2;
        this.Aceptar.Text = "Aceptar";
            this.Aceptar.Click += new System.EventHandler(Aceptar_Click);
        this.Frame1.BackColor = System.Drawing.SystemColors.Control;
        this.Frame1.Controls.Add(this._cDescuento_1);
        this.Frame1.Controls.Add(this._cDescuento_0);
        this.Frame1.Controls.Add(this._Label_1);
        this.Frame1.Controls.Add(this._Label_0);
        this.Frame1.Controls.Add(this.Label_Cantidad);
        this.Frame1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
        this.Frame1.Location = new System.Drawing.Point(16, 16);
        this.Frame1.Name = "Frame1";
        this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.Frame1.Size = new System.Drawing.Size(505, 121);
        this.Frame1.TabIndex = 4;
        this.Frame1.TabStop = false;
        this.Frame1.Text = "Tipo de Descuento";
        this._cDescuento_1.BackColor = System.Drawing.SystemColors.Window;
        this._cDescuento_1.Cursor = System.Windows.Forms.Cursors.Default;
        this._cDescuento_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this._cDescuento_1.ForeColor = System.Drawing.SystemColors.WindowText;
        //this.cDescuento.SetIndex(this._cDescuento_1, ((short)(1)));
        this._cDescuento_1.Location = new System.Drawing.Point(400, 48);
        this._cDescuento_1.Name = "_cDescuento_1";
        this._cDescuento_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this._cDescuento_1.Size = new System.Drawing.Size(57, 28);
        this._cDescuento_1.Sorted = true;
        this._cDescuento_1.TabIndex = 0;
        // 
        // _cDescuento_0
        // 
        this._cDescuento_0.BackColor = System.Drawing.SystemColors.Window;
        this._cDescuento_0.Cursor = System.Windows.Forms.Cursors.Default;
        this._cDescuento_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this._cDescuento_0.ForeColor = System.Drawing.SystemColors.WindowText;
        //this.cDescuento.SetIndex(this._cDescuento_0, ((short)(0)));
        this._cDescuento_0.Location = new System.Drawing.Point(312, 48);
        this._cDescuento_0.Name = "_cDescuento_0";
        this._cDescuento_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this._cDescuento_0.Size = new System.Drawing.Size(57, 28);
        this._cDescuento_0.Sorted = true;
        this._cDescuento_0.TabIndex = 1;
        // 
        // _Label_1
        // 
        this._Label_1.BackColor = System.Drawing.SystemColors.Control;
        this._Label_1.Cursor = System.Windows.Forms.Cursors.Default;
        this._Label_1.ForeColor = System.Drawing.SystemColors.ControlText;
        //this.Label.Insert(1, this._Label_1);
        //this.Label.SetIndex(this._Label_1, ((short)(1)));

        this._Label_1.Location = new System.Drawing.Point(376, 48);
        this._Label_1.Name = "_Label_1";
        this._Label_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this._Label_1.Size = new System.Drawing.Size(25, 57);
        this._Label_1.TabIndex = 7;
        this._Label_1.Text = ",";
        this._Label_0.BackColor = System.Drawing.SystemColors.Control;
        this._Label_0.Cursor = System.Windows.Forms.Cursors.Default;
        this._Label_0.ForeColor = System.Drawing.SystemColors.ControlText;
        //this.Label.Insert(1, this._Label_1);
        //this.Label.SetIndex(this._Label_0, ((short)(0)));
        this._Label_0.Location = new System.Drawing.Point(464, 48);
        this._Label_0.Name = "_Label_0";
        this._Label_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this._Label_0.Size = new System.Drawing.Size(33, 33);
        this._Label_0.TabIndex = 6;
        this._Label_0.Text = "%";
        this.Label_Cantidad.BackColor = System.Drawing.SystemColors.Control;
        this.Label_Cantidad.Cursor = System.Windows.Forms.Cursors.Default;
        this.Label_Cantidad.ForeColor = System.Drawing.SystemColors.ControlText;
        this.Label_Cantidad.Location = new System.Drawing.Point(16, 56);
        this.Label_Cantidad.Name = "Label_Cantidad";
        this.Label_Cantidad.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.Label_Cantidad.Size = new System.Drawing.Size(289, 25);
        this.Label_Cantidad.TabIndex = 5;
        this.Label_Cantidad.Text = "Seleccione el descuento aplicable";
        this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
        this.BackColor = System.Drawing.SystemColors.Control;
        this.ClientSize = new System.Drawing.Size(638, 151);
        this.Controls.Add(this.Cancelar);
        this.Controls.Add(this.Aceptar);
        this.Controls.Add(this.Frame1);
        this.Cursor = System.Windows.Forms.Cursors.Default;
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.Location = new System.Drawing.Point(117, 348);
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "Form_Descuento";
        this.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.ShowInTaskbar = false;
        this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
        this.Text = "Descuento";
        this.Frame1.ResumeLayout(false);
        //((System.ComponentModel.ISupportInitialize)(this.Label)).EndInit();
        //((System.ComponentModel.ISupportInitialize)(this.cDescuento)).EndInit();
        this.ResumeLayout(false);
            this.Load += new System.EventHandler(Form_Descuento_Load);
	}
#endregion
        // Requerido por el Diseñador de Windows Forms

        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.ComboBox _cDescuento_1;
        private System.Windows.Forms.ComboBox _cDescuento_0;
        private System.Windows.Forms.Label _Label_1;
        private System.Windows.Forms.Label _Label_0;
        private System.Windows.Forms.Label Label_Cantidad;
        private System.Windows.Forms.GroupBox Frame1;
        //private Microsoft.VisualBasic.Compatibility.VB6.LabelArray Label;
        //private Microsoft.VisualBasic.Compatibility.VB6.ComboBoxArray cDescuento;
}