//<(Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated() > Partial);
partial class Form_Report_Factura : System.Windows.Forms.Form
{

    // Form reemplaza a Dispose para limpiar la lista de componentes.
    [System.Diagnostics.DebuggerNonUserCode()]
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    // Requerido por el Diseñador de Windows Forms
    private System.ComponentModel.IContainer components = null;

    // NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    // Se puede modificar usando el Diseñador de Windows Forms.  
    // No lo modifique con el editor de código.
    //[System.Diagnostics.DebuggerStepThrough()]
    private void InitializeComponent()
    {
        this.ReportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
        this.SuspendLayout();
        // 
        // ReportViewer1
        // 
        this.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.ReportViewer1.Location = new System.Drawing.Point(0, 0);
        this.ReportViewer1.Name = "ReportViewer1";
        //        this.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
        this.ReportViewer1.ServerReport.ReportPath = "/Facturas de Compras/Facturas de Compras";
        this.ReportViewer1.Size = new System.Drawing.Size(292, 273);
        this.ReportViewer1.TabIndex = 0;
        // 
        // Form_Report_Factura
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(292, 273);
        this.Controls.Add(this.ReportViewer1);
        this.Name = "Form_Report_Factura";
        this.Text = "Form_Report_Factura";
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        this.ResumeLayout(false);
    }

    private Microsoft.Reporting.WinForms.ReportViewer ReportViewer1;
}
