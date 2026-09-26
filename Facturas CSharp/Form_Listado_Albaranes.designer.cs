//<(Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated() > Partial);
partial class Form_Listado_Albaranes : System.Windows.Forms.Form {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    // Form overrides dispose to clean up the component list.
    [System.Diagnostics.DebuggerNonUserCode()]
    protected override void Dispose(bool disposing) {
        if ((disposing && (components != null))) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }
    
    // NOTE: The following procedure is required by the Windows Form Designer
    // It can be modified using the Windows Form Designer.  
    // Do not modify it using the code editor.
    [System.Diagnostics.DebuggerStepThrough()]
    private void InitializeComponent() {
        this.AlbaranesViewer = new Microsoft.Reporting.WinForms.ReportViewer();
        this.SuspendLayout();
        // 
        // AlbaranesViewer
        // 
        this.AlbaranesViewer.Dock = System.Windows.Forms.DockStyle.Fill;
        this.AlbaranesViewer.Location = new System.Drawing.Point(0, 0);
        this.AlbaranesViewer.Name = "AlbaranesViewer";
        this.AlbaranesViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
        this.AlbaranesViewer.ServerReport.ReportPath = "/Borradores/Borradores";
        this.AlbaranesViewer.Size = new System.Drawing.Size(292, 273);
        this.AlbaranesViewer.TabIndex = 0;
        // 
        // Form_Listado_Albaranes
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6,13);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(292, 273);
        this.Controls.Add(this.AlbaranesViewer);
        this.Name = "Form_Listado_Albaranes";
        this.Text = "Informe Albaranes";
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        this.ResumeLayout(false);
        this.Load += new System.EventHandler(Form_Listado_Albaranes_Load);
    }
    
    public Microsoft.Reporting.WinForms.ReportViewer AlbaranesViewer;
}
