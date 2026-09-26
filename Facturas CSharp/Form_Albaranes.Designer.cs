partial class Form_Albaranes : System.Windows.Forms.Form
{
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
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        this.cmdAniadir = new System.Windows.Forms.Button();
        this.cmdBorrar = new System.Windows.Forms.Button();
        this.cmdAceptar = new System.Windows.Forms.Button();
        this.cmdCancelar = new System.Windows.Forms.Button();
        this.Marco = new System.Windows.Forms.GroupBox();
        this.dcDestino = new System.Windows.Forms.ComboBox();
        this.dcClientes = new System.Windows.Forms.ComboBox();
        this.chkFacturado = new System.Windows.Forms.CheckBox();
        this.txtDestino = new System.Windows.Forms.TextBox();
        this.cmbDia = new System.Windows.Forms.ComboBox();
        this.cmbMes = new System.Windows.Forms.ComboBox();
        this.cmbAnio = new System.Windows.Forms.ComboBox();
        this.txtNumero = new System.Windows.Forms.TextBox();
        this.lblCliente = new System.Windows.Forms.Label();
        this.lblDestino = new System.Windows.Forms.Label();
        this.lblSeparador1 = new System.Windows.Forms.Label();
        this.lblSeparador2 = new System.Windows.Forms.Label();
        this.lblFecha = new System.Windows.Forms.Label();
        this.Label_Numero = new System.Windows.Forms.Label();
        this.dgMateriales = new System.Windows.Forms.DataGridView();
        ((System.ComponentModel.ISupportInitialize)(this.dgMateriales)).BeginInit();
        this.SuspendLayout();
        // 
        // cmdAniadir
        // 
        this.cmdAniadir.BackColor = System.Drawing.SystemColors.Control;
        this.cmdAniadir.Cursor = System.Windows.Forms.Cursors.Default;
        this.cmdAniadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.cmdAniadir.ForeColor = System.Drawing.SystemColors.ControlText;
        this.cmdAniadir.Location = new System.Drawing.Point(475, 329);
        this.cmdAniadir.Name = "cmdAniadir";
        this.cmdAniadir.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.cmdAniadir.Size = new System.Drawing.Size(89, 25);
        this.cmdAniadir.TabIndex = 11;
        this.cmdAniadir.Text = "Añadir";
        this.cmdAniadir.UseVisualStyleBackColor = false;
        this.cmdAniadir.Visible = false;
        this.cmdAniadir.Click += new System.EventHandler(this.cmdAniadir_Click);
        // 
        // cmdBorrar
        // 
        this.cmdBorrar.BackColor = System.Drawing.SystemColors.Control;
        this.cmdBorrar.Cursor = System.Windows.Forms.Cursors.Default;
        this.cmdBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.cmdBorrar.ForeColor = System.Drawing.SystemColors.ControlText;
        this.cmdBorrar.Location = new System.Drawing.Point(475, 279);
        this.cmdBorrar.Name = "cmdBorrar";
        this.cmdBorrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.cmdBorrar.Size = new System.Drawing.Size(89, 25);
        this.cmdBorrar.TabIndex = 10;
        this.cmdBorrar.Text = "Borrar";
        this.cmdBorrar.UseVisualStyleBackColor = false;
        this.cmdBorrar.Visible = false;
        this.cmdBorrar.Click += new System.EventHandler(this.cmdBorrar_Click);
        // 
        // cmdAceptar
        // 
        this.cmdAceptar.BackColor = System.Drawing.SystemColors.Control;
        this.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default;
        this.cmdAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText;
        this.cmdAceptar.Location = new System.Drawing.Point(475, 25);
        this.cmdAceptar.Name = "cmdAceptar";
        this.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.cmdAceptar.Size = new System.Drawing.Size(89, 25);
        this.cmdAceptar.TabIndex = 7;
        this.cmdAceptar.Text = "Aceptar";
        this.cmdAceptar.UseVisualStyleBackColor = false;
        this.cmdAceptar.Click += new System.EventHandler(this.cmdAceptar_Click);
        // 
        // cmdCancelar
        // 
        this.cmdCancelar.BackColor = System.Drawing.SystemColors.Control;
        this.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Default;
        this.cmdCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
        this.cmdCancelar.Location = new System.Drawing.Point(475, 69);
        this.cmdCancelar.Name = "cmdCancelar";
        this.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.cmdCancelar.Size = new System.Drawing.Size(89, 25);
        this.cmdCancelar.TabIndex = 9;
        this.cmdCancelar.Text = "Cancelar";
        this.cmdCancelar.UseVisualStyleBackColor = false;
        this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
        // 
        // Marco
        // 
        this.Marco.BackColor = System.Drawing.SystemColors.Control;
        this.Marco.Dock = System.Windows.Forms.DockStyle.Fill;
        this.Marco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.Marco.ForeColor = System.Drawing.SystemColors.ControlText;
        this.Marco.Location = new System.Drawing.Point(10, 10);
        this.Marco.Name = "Marco";
        this.Marco.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.Marco.Size = new System.Drawing.Size(580, 445);
        this.Marco.TabIndex = 0;
        this.Marco.TabStop = false;
        this.Marco.Text = "Albaranes";
        // 
        // dcDestino
        // 
        this.dcDestino.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
        this.dcDestino.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
        this.dcDestino.DisplayMember = "DESTINO";
        this.dcDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.dcDestino.Location = new System.Drawing.Point(136, 136);
        this.dcDestino.Name = "dcDestino";
        this.dcDestino.Size = new System.Drawing.Size(288, 28);
        this.dcDestino.TabIndex = 3;
        // 
        // dcClientes
        // 
        this.dcClientes.DisplayMember = "NOMBRE";
        this.dcClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.dcClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.dcClientes.Location = new System.Drawing.Point(136, 87);
        this.dcClientes.Name = "dcClientes";
        this.dcClientes.Size = new System.Drawing.Size(288, 28);
        this.dcClientes.TabIndex = 2;
        // 
        // chkFacturado
        // 
        this.chkFacturado.BackColor = System.Drawing.SystemColors.Control;
        this.chkFacturado.Cursor = System.Windows.Forms.Cursors.Default;
        this.chkFacturado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.chkFacturado.ForeColor = System.Drawing.SystemColors.ControlText;
        this.chkFacturado.Location = new System.Drawing.Point(20, 240);
        this.chkFacturado.Name = "chkFacturado";
        this.chkFacturado.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.chkFacturado.Size = new System.Drawing.Size(113, 33);
        this.chkFacturado.TabIndex = 7;
        this.chkFacturado.Text = "Facturado";
        this.chkFacturado.UseVisualStyleBackColor = false;
        // 
        // txtDestino
        // 
        this.txtDestino.AcceptsReturn = true;
        this.txtDestino.BackColor = System.Drawing.SystemColors.Window;
        this.txtDestino.Cursor = System.Windows.Forms.Cursors.IBeam;
        this.txtDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.txtDestino.ForeColor = System.Drawing.SystemColors.WindowText;
        this.txtDestino.Location = new System.Drawing.Point(136, 136);
        this.txtDestino.MaxLength = 0;
        this.txtDestino.Name = "txtDestino";
        this.txtDestino.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.txtDestino.Size = new System.Drawing.Size(289, 26);
        this.txtDestino.TabIndex = 19;
        this.txtDestino.Visible = false;
        // 
        // cmbDia
        // 
        this.cmbDia.BackColor = System.Drawing.SystemColors.Window;
        this.cmbDia.Cursor = System.Windows.Forms.Cursors.Default;
        this.cmbDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.cmbDia.ForeColor = System.Drawing.SystemColors.WindowText;
        this.cmbDia.Location = new System.Drawing.Point(136, 192);
        this.cmbDia.Name = "cmbDia";
        this.cmbDia.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.cmbDia.Size = new System.Drawing.Size(49, 28);
        this.cmbDia.TabIndex = 6;
        // 
        // cmbMes
        // 
        this.cmbMes.BackColor = System.Drawing.SystemColors.Window;
        this.cmbMes.Cursor = System.Windows.Forms.Cursors.Default;
        this.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.cmbMes.ForeColor = System.Drawing.SystemColors.WindowText;
        this.cmbMes.Location = new System.Drawing.Point(224, 192);
        this.cmbMes.Name = "cmbMes";
        this.cmbMes.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.cmbMes.Size = new System.Drawing.Size(49, 28);
        this.cmbMes.TabIndex = 5;
        this.cmbMes.SelectedIndexChanged += new System.EventHandler(this.cmbMes_SelectedIndexChanged);
        // 
        // cmbAnio
        // 
        this.cmbAnio.BackColor = System.Drawing.SystemColors.Window;
        this.cmbAnio.Cursor = System.Windows.Forms.Cursors.Default;
        this.cmbAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.cmbAnio.ForeColor = System.Drawing.SystemColors.WindowText;
        this.cmbAnio.Location = new System.Drawing.Point(304, 192);
        this.cmbAnio.Name = "cmbAnio";
        this.cmbAnio.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.cmbAnio.Size = new System.Drawing.Size(65, 28);
        this.cmbAnio.TabIndex = 4;
        this.cmbAnio.SelectedIndexChanged += new System.EventHandler(this.cmbAnio_SelectedIndexChanged);
        // 
        // txtNumero
        // 
        this.txtNumero.AcceptsReturn = true;
        this.txtNumero.BackColor = System.Drawing.SystemColors.Window;
        this.txtNumero.Cursor = System.Windows.Forms.Cursors.IBeam;
        this.txtNumero.Enabled = false;
        this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.txtNumero.ForeColor = System.Drawing.SystemColors.WindowText;
        this.txtNumero.Location = new System.Drawing.Point(136, 37);
        this.txtNumero.MaxLength = 0;
        this.txtNumero.Name = "txtNumero";
        this.txtNumero.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.txtNumero.Size = new System.Drawing.Size(57, 26);
        this.txtNumero.TabIndex = 1;
        // 
        // lblCliente
        // 
        this.lblCliente.BackColor = System.Drawing.SystemColors.Control;
        this.lblCliente.Cursor = System.Windows.Forms.Cursors.Default;
        this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lblCliente.ForeColor = System.Drawing.SystemColors.ControlText;
        this.lblCliente.Location = new System.Drawing.Point(16, 87);
        this.lblCliente.Name = "lblCliente";
        this.lblCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.lblCliente.Size = new System.Drawing.Size(89, 25);
        this.lblCliente.TabIndex = 17;
        this.lblCliente.Text = "Cliente";
        // 
        // lblDestino
        // 
        this.lblDestino.BackColor = System.Drawing.SystemColors.Control;
        this.lblDestino.Cursor = System.Windows.Forms.Cursors.Default;
        this.lblDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lblDestino.ForeColor = System.Drawing.SystemColors.ControlText;
        this.lblDestino.Location = new System.Drawing.Point(16, 144);
        this.lblDestino.Name = "lblDestino";
        this.lblDestino.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.lblDestino.Size = new System.Drawing.Size(89, 25);
        this.lblDestino.TabIndex = 16;
        this.lblDestino.Text = "Destino";
        // 
        // lblSeparador1
        // 
        this.lblSeparador1.BackColor = System.Drawing.SystemColors.Control;
        this.lblSeparador1.Cursor = System.Windows.Forms.Cursors.Default;
        this.lblSeparador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lblSeparador1.ForeColor = System.Drawing.SystemColors.ControlText;
        this.lblSeparador1.Location = new System.Drawing.Point(191, 192);
        this.lblSeparador1.Margin = new System.Windows.Forms.Padding(0);
        this.lblSeparador1.Name = "lblSeparador1";
        this.lblSeparador1.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.lblSeparador1.Size = new System.Drawing.Size(18, 28);
        this.lblSeparador1.TabIndex = 15;
        this.lblSeparador1.Text = "/";
        this.lblSeparador1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
        // 
        // lblSeparador2
        // 
        this.lblSeparador2.BackColor = System.Drawing.SystemColors.Control;
        this.lblSeparador2.Cursor = System.Windows.Forms.Cursors.Default;
        this.lblSeparador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lblSeparador2.ForeColor = System.Drawing.SystemColors.ControlText;
        this.lblSeparador2.Location = new System.Drawing.Point(279, 192);
        this.lblSeparador2.Margin = new System.Windows.Forms.Padding(0);
        this.lblSeparador2.Name = "lblSeparador2";
        this.lblSeparador2.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.lblSeparador2.Size = new System.Drawing.Size(18, 28);
        this.lblSeparador2.TabIndex = 14;
        this.lblSeparador2.Text = "/";
        this.lblSeparador2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
        // 
        // lblFecha
        // 
        this.lblFecha.BackColor = System.Drawing.SystemColors.Control;
        this.lblFecha.Cursor = System.Windows.Forms.Cursors.Default;
        this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lblFecha.ForeColor = System.Drawing.SystemColors.ControlText;
        this.lblFecha.Location = new System.Drawing.Point(16, 195);
        this.lblFecha.Name = "lblFecha";
        this.lblFecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.lblFecha.Size = new System.Drawing.Size(89, 25);
        this.lblFecha.TabIndex = 13;
        this.lblFecha.Text = "Fecha";
        // 
        // Label_Numero
        // 
        this.Label_Numero.AutoSize = true;
        this.Label_Numero.BackColor = System.Drawing.SystemColors.Control;
        this.Label_Numero.Cursor = System.Windows.Forms.Cursors.Default;
        this.Label_Numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.Label_Numero.ForeColor = System.Drawing.SystemColors.ControlText;
        this.Label_Numero.Location = new System.Drawing.Point(16, 40);
        this.Label_Numero.Name = "Label_Numero";
        this.Label_Numero.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.Label_Numero.Size = new System.Drawing.Size(71, 20);
        this.Label_Numero.TabIndex = 12;
        this.Label_Numero.Text = "Número";
        // 
        // dgMateriales
        // 
        this.dgMateriales.AllowUserToAddRows = false;
        this.dgMateriales.AllowUserToDeleteRows = false;
        this.dgMateriales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
        this.dgMateriales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
        this.dgMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        this.dgMateriales.DefaultCellStyle = dataGridViewCellStyle2;
        this.dgMateriales.Location = new System.Drawing.Point(20, 279);
        this.dgMateriales.Name = "dgMateriales";
        this.dgMateriales.ReadOnly = true;
        this.dgMateriales.Size = new System.Drawing.Size(439, 150);
        this.dgMateriales.TabIndex = 21;
        // 
        // Form_Albaranes
        // 
        this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
        this.BackColor = System.Drawing.SystemColors.Control;
        this.ClientSize = new System.Drawing.Size(600, 465);
        this.Controls.Add(this.cmdAniadir);
        this.Controls.Add(this.cmdBorrar);
        this.Controls.Add(this.cmdAceptar);
        this.Controls.Add(this.cmdCancelar);
        this.Controls.Add(this.chkFacturado);
        this.Controls.Add(this.txtDestino);
        this.Controls.Add(this.cmbDia);
        this.Controls.Add(this.cmbMes);
        this.Controls.Add(this.cmbAnio);
        this.Controls.Add(this.txtNumero);
        this.Controls.Add(this.lblCliente);
        this.Controls.Add(this.lblDestino);
        this.Controls.Add(this.lblSeparador1);
        this.Controls.Add(this.lblSeparador2);
        this.Controls.Add(this.lblFecha);
        this.Controls.Add(this.Label_Numero);
        this.Controls.Add(this.dcClientes);
        this.Controls.Add(this.dcDestino);
        this.Controls.Add(this.dgMateriales);
        this.Controls.Add(this.Marco);
        this.Cursor = System.Windows.Forms.Cursors.Default;
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.Location = new System.Drawing.Point(3, 22);
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "Form_Albaranes";
        this.Padding = new System.Windows.Forms.Padding(10);
        this.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.ShowInTaskbar = false;
        this.Text = "Albaranes";
        ((System.ComponentModel.ISupportInitialize)(this.dgMateriales)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion


    private System.Windows.Forms.Button cmdAniadir;
    private System.Windows.Forms.Button cmdBorrar;
    private System.Windows.Forms.Button cmdAceptar;
    private System.Windows.Forms.Button cmdCancelar;
    private System.Windows.Forms.CheckBox chkFacturado;
    private System.Windows.Forms.TextBox txtDestino;
    private System.Windows.Forms.ComboBox cmbDia;
    private System.Windows.Forms.ComboBox cmbMes;
    private System.Windows.Forms.ComboBox cmbAnio;
    private System.Windows.Forms.TextBox txtNumero;
    private System.Windows.Forms.Label lblCliente;
    private System.Windows.Forms.Label lblDestino;
    private System.Windows.Forms.Label lblSeparador1;
    private System.Windows.Forms.Label lblSeparador2;
    private System.Windows.Forms.Label lblFecha;
    private System.Windows.Forms.Label Label_Numero;
    private System.Windows.Forms.GroupBox Marco;
    private System.Windows.Forms.ComboBox dcClientes;
    private System.Windows.Forms.ComboBox dcDestino;
    private System.Windows.Forms.DataGridView dgMateriales;
}