partial class Form_Prompt_Fecha : System.Windows.Forms.Form {
   
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
            this.Cancelar = new System.Windows.Forms.Button();
            this.Aceptar = new System.Windows.Forms.Button();
            this.Frame1 = new System.Windows.Forms.GroupBox();
            this.cAnio = new System.Windows.Forms.ComboBox();
            this.cMes = new System.Windows.Forms.ComboBox();
            this.cDia = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Label();
            this.Frame1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.SystemColors.Control;
            this.Cancelar.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Cancelar.Location = new System.Drawing.Point(578, 64);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Cancelar.Size = new System.Drawing.Size(89, 25);
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
            this.Aceptar.Location = new System.Drawing.Point(578, 25);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Aceptar.Size = new System.Drawing.Size(89, 25);
            this.Aceptar.TabIndex = 2;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = false;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // Frame1
            // 
            this.Frame1.BackColor = System.Drawing.SystemColors.Control;
            this.Frame1.Controls.Add(this.cAnio);
            this.Frame1.Controls.Add(this.cMes);
            this.Frame1.Controls.Add(this.cDia);
            this.Frame1.Controls.Add(this.Label2);
            this.Frame1.Controls.Add(this.Label1);
            this.Frame1.Controls.Add(this.Fecha);
            this.Frame1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame1.Location = new System.Drawing.Point(16, 16);
            this.Frame1.Name = "Frame1";
            this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame1.Size = new System.Drawing.Size(545, 121);
            this.Frame1.TabIndex = 0;
            this.Frame1.TabStop = false;
            this.Frame1.Text = "Fecha";
            // 
            // cAnio
            // 
            this.cAnio.BackColor = System.Drawing.SystemColors.Window;
            this.cAnio.Cursor = System.Windows.Forms.Cursors.Default;
            this.cAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cAnio.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cAnio.Location = new System.Drawing.Point(464, 40);
            this.cAnio.Name = "cAnio";
            this.cAnio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cAnio.Size = new System.Drawing.Size(65, 28);
            this.cAnio.TabIndex = 8;
            this.cAnio.SelectedIndexChanged += new System.EventHandler(this.cAnio_SelectedIndexChanged);
            // 
            // cMes
            // 
            this.cMes.BackColor = System.Drawing.SystemColors.Window;
            this.cMes.Cursor = System.Windows.Forms.Cursors.Default;
            this.cMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cMes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cMes.Location = new System.Drawing.Point(384, 40);
            this.cMes.Name = "cMes";
            this.cMes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cMes.Size = new System.Drawing.Size(49, 28);
            this.cMes.TabIndex = 7;
            this.cMes.SelectedIndexChanged += new System.EventHandler(this.cMes_SelectedIndexChanged);
            // 
            // cDia
            // 
            this.cDia.BackColor = System.Drawing.SystemColors.Window;
            this.cDia.Cursor = System.Windows.Forms.Cursors.Default;
            this.cDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cDia.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cDia.Location = new System.Drawing.Point(296, 40);
            this.cDia.Name = "cDia";
            this.cDia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cDia.Size = new System.Drawing.Size(49, 28);
            this.cDia.TabIndex = 6;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.SystemColors.Control;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(439, 40);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(18, 25);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "/";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(351, 40);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(27, 25);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "/";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Fecha
            // 
            this.Fecha.BackColor = System.Drawing.SystemColors.Control;
            this.Fecha.Cursor = System.Windows.Forms.Cursors.Default;
            this.Fecha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Fecha.Location = new System.Drawing.Point(16, 48);
            this.Fecha.Name = "Fecha";
            this.Fecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Fecha.Size = new System.Drawing.Size(297, 25);
            this.Fecha.TabIndex = 1;
            this.Fecha.Text = "Introduzca la fecha de la factura:";
            // 
            // Form_Prompt_Fecha
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(679, 152);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.Frame1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(140, 255);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Prompt_Fecha";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Fecha de Factura";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_Prompt_Fecha_Closing);
            this.Frame1.ResumeLayout(false);
            this.ResumeLayout(false);

    }
#endregion
        // Requerido por el Diseñador de Windows Forms

        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.ComboBox cAnio;
        private System.Windows.Forms.ComboBox cMes;
        private System.Windows.Forms.ComboBox cDia;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.GroupBox Frame1;
}