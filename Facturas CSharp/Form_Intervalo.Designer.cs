partial class Form_Intervalo : System.Windows.Forms.Form {
   
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
            this.Marco_Intervalo = new System.Windows.Forms.GroupBox();
            this._cAnio_1 = new System.Windows.Forms.ComboBox();
            this._cMes_1 = new System.Windows.Forms.ComboBox();
            this._cDia_1 = new System.Windows.Forms.ComboBox();
            this._cAnio_0 = new System.Windows.Forms.ComboBox();
            this._cMes_0 = new System.Windows.Forms.ComboBox();
            this._cDia_0 = new System.Windows.Forms.ComboBox();
            this._Label2_1 = new System.Windows.Forms.Label();
            this._Label1_1 = new System.Windows.Forms.Label();
            this._Fecha_1 = new System.Windows.Forms.Label();
            this._Label2_0 = new System.Windows.Forms.Label();
            this._Label1_0 = new System.Windows.Forms.Label();
            this._Fecha_0 = new System.Windows.Forms.Label();
            this.Aceptar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Marco_Intervalo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Marco_Intervalo
            // 
            this.Marco_Intervalo.BackColor = System.Drawing.SystemColors.Control;
            this.Marco_Intervalo.Controls.Add(this._cAnio_1);
            this.Marco_Intervalo.Controls.Add(this._cMes_1);
            this.Marco_Intervalo.Controls.Add(this._cDia_1);
            this.Marco_Intervalo.Controls.Add(this._cAnio_0);
            this.Marco_Intervalo.Controls.Add(this._cMes_0);
            this.Marco_Intervalo.Controls.Add(this._cDia_0);
            this.Marco_Intervalo.Controls.Add(this._Label2_1);
            this.Marco_Intervalo.Controls.Add(this._Label1_1);
            this.Marco_Intervalo.Controls.Add(this._Fecha_1);
            this.Marco_Intervalo.Controls.Add(this._Label2_0);
            this.Marco_Intervalo.Controls.Add(this._Label1_0);
            this.Marco_Intervalo.Controls.Add(this._Fecha_0);
            this.Marco_Intervalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Marco_Intervalo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Marco_Intervalo.Location = new System.Drawing.Point(16, 16);
            this.Marco_Intervalo.Name = "Marco_Intervalo";
            this.Marco_Intervalo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Marco_Intervalo.Size = new System.Drawing.Size(513, 161);
            this.Marco_Intervalo.TabIndex = 2;
            this.Marco_Intervalo.TabStop = false;
            this.Marco_Intervalo.Text = "Intervalo de Fechas";
            // 
            // _cAnio_1
            // 
            this._cAnio_1.BackColor = System.Drawing.SystemColors.Window;
            this._cAnio_1.Cursor = System.Windows.Forms.Cursors.Default;
            this._cAnio_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cAnio_1.ForeColor = System.Drawing.SystemColors.WindowText;
            this._cAnio_1.Location = new System.Drawing.Point(424, 104);
            this._cAnio_1.Name = "_cAnio_1";
            this._cAnio_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cAnio_1.Size = new System.Drawing.Size(65, 28);
            this._cAnio_1.TabIndex = 11;
            // 
            // _cMes_1
            // 
            this._cMes_1.BackColor = System.Drawing.SystemColors.Window;
            this._cMes_1.Cursor = System.Windows.Forms.Cursors.Default;
            this._cMes_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cMes_1.ForeColor = System.Drawing.SystemColors.WindowText;
            this._cMes_1.Location = new System.Drawing.Point(344, 104);
            this._cMes_1.Name = "_cMes_1";
            this._cMes_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cMes_1.Size = new System.Drawing.Size(49, 28);
            this._cMes_1.TabIndex = 10;
            // 
            // _cDia_1
            // 
            this._cDia_1.BackColor = System.Drawing.SystemColors.Window;
            this._cDia_1.Cursor = System.Windows.Forms.Cursors.Default;
            this._cDia_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cDia_1.ForeColor = System.Drawing.SystemColors.WindowText;
            this._cDia_1.Location = new System.Drawing.Point(264, 104);
            this._cDia_1.Name = "_cDia_1";
            this._cDia_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cDia_1.Size = new System.Drawing.Size(49, 28);
            this._cDia_1.TabIndex = 9;
            // 
            // _cAnio_0
            // 
            this._cAnio_0.BackColor = System.Drawing.SystemColors.Window;
            this._cAnio_0.Cursor = System.Windows.Forms.Cursors.Default;
            this._cAnio_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cAnio_0.ForeColor = System.Drawing.SystemColors.WindowText;
            this._cAnio_0.Location = new System.Drawing.Point(424, 40);
            this._cAnio_0.Name = "_cAnio_0";
            this._cAnio_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cAnio_0.Size = new System.Drawing.Size(65, 28);
            this._cAnio_0.TabIndex = 5;
            // 
            // _cMes_0
            // 
            this._cMes_0.BackColor = System.Drawing.SystemColors.Window;
            this._cMes_0.Cursor = System.Windows.Forms.Cursors.Default;
            this._cMes_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cMes_0.ForeColor = System.Drawing.SystemColors.WindowText;
            this._cMes_0.Location = new System.Drawing.Point(344, 40);
            this._cMes_0.Name = "_cMes_0";
            this._cMes_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cMes_0.Size = new System.Drawing.Size(49, 28);
            this._cMes_0.TabIndex = 4;
            // 
            // _cDia_0
            // 
            this._cDia_0.BackColor = System.Drawing.SystemColors.Window;
            this._cDia_0.Cursor = System.Windows.Forms.Cursors.Default;
            this._cDia_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cDia_0.ForeColor = System.Drawing.SystemColors.WindowText;
            this._cDia_0.Location = new System.Drawing.Point(264, 40);
            this._cDia_0.Name = "_cDia_0";
            this._cDia_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cDia_0.Size = new System.Drawing.Size(49, 28);
            this._cDia_0.TabIndex = 3;
            // 
            // _Label2_1
            // 
            this._Label2_1.BackColor = System.Drawing.SystemColors.Control;
            this._Label2_1.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label2_1.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Label2_1.Location = new System.Drawing.Point(399, 104);
            this._Label2_1.Name = "_Label2_1";
            this._Label2_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label2_1.Size = new System.Drawing.Size(18, 25);
            this._Label2_1.TabIndex = 14;
            this._Label2_1.Text = "/";
            this._Label2_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // _Label1_1
            // 
            this._Label1_1.BackColor = System.Drawing.SystemColors.Control;
            this._Label1_1.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label1_1.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Label1_1.Location = new System.Drawing.Point(319, 104);
            this._Label1_1.Name = "_Label1_1";
            this._Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_1.Size = new System.Drawing.Size(18, 25);
            this._Label1_1.TabIndex = 13;
            this._Label1_1.Text = "/";
            this._Label1_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // _Fecha_1
            // 
            this._Fecha_1.BackColor = System.Drawing.SystemColors.Control;
            this._Fecha_1.Cursor = System.Windows.Forms.Cursors.Default;
            this._Fecha_1.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Fecha_1.Location = new System.Drawing.Point(16, 112);
            this._Fecha_1.Name = "_Fecha_1";
            this._Fecha_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Fecha_1.Size = new System.Drawing.Size(233, 25);
            this._Fecha_1.TabIndex = 12;
            this._Fecha_1.Text = "Introduzca la fecha de fin:";
            // 
            // _Label2_0
            // 
            this._Label2_0.BackColor = System.Drawing.SystemColors.Control;
            this._Label2_0.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label2_0.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Label2_0.Location = new System.Drawing.Point(399, 40);
            this._Label2_0.Name = "_Label2_0";
            this._Label2_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label2_0.Size = new System.Drawing.Size(18, 25);
            this._Label2_0.TabIndex = 8;
            this._Label2_0.Text = "/";
            this._Label2_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // _Label1_0
            // 
            this._Label1_0.BackColor = System.Drawing.SystemColors.Control;
            this._Label1_0.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label1_0.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Label1_0.Location = new System.Drawing.Point(319, 40);
            this._Label1_0.Name = "_Label1_0";
            this._Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_0.Size = new System.Drawing.Size(18, 25);
            this._Label1_0.TabIndex = 7;
            this._Label1_0.Text = "/";
            this._Label1_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // _Fecha_0
            // 
            this._Fecha_0.BackColor = System.Drawing.SystemColors.Control;
            this._Fecha_0.Cursor = System.Windows.Forms.Cursors.Default;
            this._Fecha_0.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Fecha_0.Location = new System.Drawing.Point(16, 48);
            this._Fecha_0.Name = "_Fecha_0";
            this._Fecha_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Fecha_0.Size = new System.Drawing.Size(233, 25);
            this._Fecha_0.TabIndex = 6;
            this._Fecha_0.Text = "Introduzca la fecha de inicio:";
            // 
            // Aceptar
            // 
            this.Aceptar.BackColor = System.Drawing.SystemColors.Control;
            this.Aceptar.Cursor = System.Windows.Forms.Cursors.Default;
            this.Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Aceptar.Location = new System.Drawing.Point(544, 40);
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
            this.Cancelar.Location = new System.Drawing.Point(544, 80);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Cancelar.Size = new System.Drawing.Size(89, 25);
            this.Cancelar.TabIndex = 0;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(Cancelar_Click);
            // 
            // Form_Intervalo
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(647, 192);
            this.Controls.Add(this.Marco_Intervalo);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.Cancelar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(3, 22);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Intervalo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.Text = "Fecha";
            this.Load += new System.EventHandler(this.Form_Intervalo_Load);
            this.Marco_Intervalo.ResumeLayout(false);
            this.ResumeLayout(false);
            this._cAnio_0.SelectedIndexChanged += new System.EventHandler(cAnio_SelectedIndexChanged);
            this._cAnio_1.SelectedIndexChanged += new System.EventHandler(cAnio_SelectedIndexChanged);
            this._cMes_0.SelectedIndexChanged += new System.EventHandler(cMes_SelectedIndexChanged);
            this._cMes_1.SelectedIndexChanged += new System.EventHandler(cMes_SelectedIndexChanged);
    }
    
        #endregion

    // Requerido por el Diseñador de Windows Forms
        private System.Windows.Forms.ComboBox _cAnio_1;
        private System.Windows.Forms.ComboBox _cMes_1;
        private System.Windows.Forms.ComboBox _cDia_1;
        private System.Windows.Forms.ComboBox _cAnio_0;
        private System.Windows.Forms.ComboBox _cMes_0;
        private System.Windows.Forms.ComboBox _cDia_0;
        private System.Windows.Forms.Label _Label2_1;
        private System.Windows.Forms.Label _Label1_1;
        private System.Windows.Forms.Label _Fecha_1;
        private System.Windows.Forms.Label _Label2_0;
        private System.Windows.Forms.Label _Label1_0;
        private System.Windows.Forms.Label _Fecha_0;
        private System.Windows.Forms.GroupBox Marco_Intervalo;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button Cancelar;
}