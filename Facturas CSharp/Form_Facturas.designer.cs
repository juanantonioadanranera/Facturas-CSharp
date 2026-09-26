partial class Form_Facturas : System.Windows.Forms.Form {
   
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
            this.Text_Cliente = new System.Windows.Forms.TextBox();
            this.chkCobrada = new System.Windows.Forms.CheckBox();
            this.Text_Numero = new System.Windows.Forms.TextBox();
            this.cAnio = new System.Windows.Forms.ComboBox();
            this.cMes = new System.Windows.Forms.ComboBox();
            this.cDia = new System.Windows.Forms.ComboBox();
            this.Text_Destino = new System.Windows.Forms.TextBox();
            this.Label_Numero = new System.Windows.Forms.Label();
            this.Label_Fecha = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label_Destino = new System.Windows.Forms.Label();
            this.Label_Cliente = new System.Windows.Forms.Label();
            this.dgFacturas = new System.Windows.Forms.DataGrid();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Aceptar = new System.Windows.Forms.Button();
            this.VerAlbaranes = new System.Windows.Forms.Button();
            this.Marco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // Marco
            // 
            this.Marco.BackColor = System.Drawing.SystemColors.Control;
            this.Marco.Controls.Add(this.Text_Cliente);
            this.Marco.Controls.Add(this.chkCobrada);
            this.Marco.Controls.Add(this.Text_Numero);
            this.Marco.Controls.Add(this.cAnio);
            this.Marco.Controls.Add(this.cMes);
            this.Marco.Controls.Add(this.cDia);
            this.Marco.Controls.Add(this.Text_Destino);
            this.Marco.Controls.Add(this.Label_Numero);
            this.Marco.Controls.Add(this.Label_Fecha);
            this.Marco.Controls.Add(this.Label2);
            this.Marco.Controls.Add(this.Label1);
            this.Marco.Controls.Add(this.Label_Destino);
            this.Marco.Controls.Add(this.Label_Cliente);
            this.Marco.Controls.Add(this.dgFacturas);
            this.Marco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Marco.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Marco.Location = new System.Drawing.Point(24, 8);
            this.Marco.Name = "Marco";
            this.Marco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Marco.Size = new System.Drawing.Size(465, 487);
            this.Marco.TabIndex = 4;
            this.Marco.TabStop = false;
            this.Marco.Text = "Facturas";
            // 
            // Text_Cliente
            // 
            this.Text_Cliente.AcceptsReturn = true;
            this.Text_Cliente.BackColor = System.Drawing.SystemColors.Window;
            this.Text_Cliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_Cliente.Enabled = false;
            this.Text_Cliente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Text_Cliente.Location = new System.Drawing.Point(136, 93);
            this.Text_Cliente.MaxLength = 0;
            this.Text_Cliente.Name = "Text_Cliente";
            this.Text_Cliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text_Cliente.Size = new System.Drawing.Size(289, 26);
            this.Text_Cliente.TabIndex = 21;
            // 
            // chkCobrada
            // 
            this.chkCobrada.AutoSize = true;
            this.chkCobrada.Location = new System.Drawing.Point(20, 234);
            this.chkCobrada.Name = "chkCobrada";
            this.chkCobrada.Size = new System.Drawing.Size(96, 24);
            this.chkCobrada.TabIndex = 20;
            this.chkCobrada.Text = "Cobrada";
            this.chkCobrada.UseVisualStyleBackColor = true;
            // 
            // Text_Numero
            // 
            this.Text_Numero.AcceptsReturn = true;
            this.Text_Numero.BackColor = System.Drawing.SystemColors.Window;
            this.Text_Numero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_Numero.Enabled = false;
            this.Text_Numero.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Text_Numero.Location = new System.Drawing.Point(136, 37);
            this.Text_Numero.MaxLength = 0;
            this.Text_Numero.Name = "Text_Numero";
            this.Text_Numero.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text_Numero.Size = new System.Drawing.Size(57, 26);
            this.Text_Numero.TabIndex = 9;
            // 
            // cAnio
            // 
            this.cAnio.BackColor = System.Drawing.SystemColors.Window;
            this.cAnio.Cursor = System.Windows.Forms.Cursors.Default;
            this.cAnio.Enabled = false;
            this.cAnio.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cAnio.Location = new System.Drawing.Point(304, 192);
            this.cAnio.Name = "cAnio";
            this.cAnio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cAnio.Size = new System.Drawing.Size(65, 28);
            this.cAnio.TabIndex = 8;
            // 
            // cMes
            // 
            this.cMes.BackColor = System.Drawing.SystemColors.Window;
            this.cMes.Cursor = System.Windows.Forms.Cursors.Default;
            this.cMes.Enabled = false;
            this.cMes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cMes.Location = new System.Drawing.Point(224, 192);
            this.cMes.Name = "cMes";
            this.cMes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cMes.Size = new System.Drawing.Size(49, 28);
            this.cMes.TabIndex = 7;
            // 
            // cDia
            // 
            this.cDia.BackColor = System.Drawing.SystemColors.Window;
            this.cDia.Cursor = System.Windows.Forms.Cursors.Default;
            this.cDia.Enabled = false;
            this.cDia.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cDia.Location = new System.Drawing.Point(136, 192);
            this.cDia.Name = "cDia";
            this.cDia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cDia.Size = new System.Drawing.Size(49, 28);
            this.cDia.TabIndex = 6;
            // 
            // Text_Destino
            // 
            this.Text_Destino.AcceptsReturn = true;
            this.Text_Destino.BackColor = System.Drawing.SystemColors.Window;
            this.Text_Destino.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_Destino.Enabled = false;
            this.Text_Destino.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Text_Destino.Location = new System.Drawing.Point(136, 141);
            this.Text_Destino.MaxLength = 0;
            this.Text_Destino.Name = "Text_Destino";
            this.Text_Destino.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text_Destino.Size = new System.Drawing.Size(289, 26);
            this.Text_Destino.TabIndex = 5;
            // 
            // Label_Numero
            // 
            this.Label_Numero.AutoSize = true;
            this.Label_Numero.BackColor = System.Drawing.SystemColors.Control;
            this.Label_Numero.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_Numero.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label_Numero.Location = new System.Drawing.Point(16, 40);
            this.Label_Numero.Name = "Label_Numero";
            this.Label_Numero.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label_Numero.Size = new System.Drawing.Size(71, 20);
            this.Label_Numero.TabIndex = 17;
            this.Label_Numero.Text = "Número";
            // 
            // Label_Fecha
            // 
            this.Label_Fecha.BackColor = System.Drawing.SystemColors.Control;
            this.Label_Fecha.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_Fecha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label_Fecha.Location = new System.Drawing.Point(16, 192);
            this.Label_Fecha.Name = "Label_Fecha";
            this.Label_Fecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label_Fecha.Size = new System.Drawing.Size(89, 25);
            this.Label_Fecha.TabIndex = 16;
            this.Label_Fecha.Text = "Fecha";
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.SystemColors.Control;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(288, 192);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(9, 25);
            this.Label2.TabIndex = 15;
            this.Label2.Text = "/";
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(200, 192);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(9, 25);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "/";
            // 
            // Label_Destino
            // 
            this.Label_Destino.BackColor = System.Drawing.SystemColors.Control;
            this.Label_Destino.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_Destino.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label_Destino.Location = new System.Drawing.Point(16, 144);
            this.Label_Destino.Name = "Label_Destino";
            this.Label_Destino.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label_Destino.Size = new System.Drawing.Size(89, 25);
            this.Label_Destino.TabIndex = 13;
            this.Label_Destino.Text = "Destino";
            // 
            // Label_Cliente
            // 
            this.Label_Cliente.BackColor = System.Drawing.SystemColors.Control;
            this.Label_Cliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_Cliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label_Cliente.Location = new System.Drawing.Point(16, 96);
            this.Label_Cliente.Name = "Label_Cliente";
            this.Label_Cliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label_Cliente.Size = new System.Drawing.Size(89, 25);
            this.Label_Cliente.TabIndex = 12;
            this.Label_Cliente.Text = "Cliente";
            // 
            // dgFacturas
            // 
            this.dgFacturas.DataMember = "";
            this.dgFacturas.Enabled = false;
            this.dgFacturas.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgFacturas.Location = new System.Drawing.Point(20, 267);
            this.dgFacturas.Name = "dgFacturas";
            this.dgFacturas.PreferredColumnWidth = 250;
            this.dgFacturas.ReadOnly = true;
            this.dgFacturas.Size = new System.Drawing.Size(429, 203);
            this.dgFacturas.TabIndex = 6;
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.SystemColors.Control;
            this.Cancelar.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Cancelar.Location = new System.Drawing.Point(568, 72);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Cancelar.Size = new System.Drawing.Size(89, 29);
            this.Cancelar.TabIndex = 3;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Aceptar
            // 
            this.Aceptar.BackColor = System.Drawing.SystemColors.Control;
            this.Aceptar.Cursor = System.Windows.Forms.Cursors.Default;
            this.Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Aceptar.Location = new System.Drawing.Point(568, 27);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Aceptar.Size = new System.Drawing.Size(89, 30);
            this.Aceptar.TabIndex = 2;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = false;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // VerAlbaranes
            // 
            this.VerAlbaranes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerAlbaranes.Location = new System.Drawing.Point(523, 118);
            this.VerAlbaranes.Name = "VerAlbaranes";
            this.VerAlbaranes.Size = new System.Drawing.Size(134, 32);
            this.VerAlbaranes.TabIndex = 6;
            this.VerAlbaranes.Text = "Ver Albaranes";
            this.VerAlbaranes.UseVisualStyleBackColor = true;
            this.VerAlbaranes.Click += new System.EventHandler(this.VerAlbaranes_Click);
            // 
            // Form_Facturas
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(680, 507);
            this.Controls.Add(this.VerAlbaranes);
            this.Controls.Add(this.Marco);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Aceptar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(3, 22);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Facturas";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.Text = "Facturas";
            this.Marco.ResumeLayout(false);
            this.Marco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFacturas)).EndInit();
            this.ResumeLayout(false);

	}
#endregion
        // Requerido por el Diseñador de Windows Forms
		
         
    private System.Windows.Forms.TextBox Text_Numero ;
    private System.Windows.Forms.ComboBox cAnio;
    private System.Windows.Forms.ComboBox cMes;
    private System.Windows.Forms.ComboBox cDia;
    private System.Windows.Forms.TextBox Text_Destino;
    private System.Windows.Forms.Label Label_Numero;
    private System.Windows.Forms.Label Label_Fecha;
    private System.Windows.Forms.Label Label2;
    private System.Windows.Forms.Label Label1;
    private System.Windows.Forms.Label Label_Destino;
    private System.Windows.Forms.Label Label_Cliente;
    private System.Windows.Forms.GroupBox Marco;
    private System.Windows.Forms.Button Cancelar;
    private System.Windows.Forms.Button Aceptar;
    private System.Windows.Forms.DataGrid dgFacturas;
    private System.Windows.Forms.CheckBox chkCobrada;
    private System.Windows.Forms.TextBox Text_Cliente;
    private System.Windows.Forms.Button VerAlbaranes;
}