
partial class Form_Report_Factura : System.Windows.Forms.Form {
    public Form_Report_Factura()
    {
                InitializeComponent();
    }
    private void Form_Report_Factura_Load(object sender, System.EventArgs e) {
        this.ReportViewer1.RefreshReport();
    }
}