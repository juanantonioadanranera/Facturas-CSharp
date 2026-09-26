using System;
using Microsoft.Reporting.WinForms;

public partial class Form_Listado_Albaranes : System.Windows.Forms.Form {
    public Form_Listado_Albaranes(DateTime dtFechaInicio, DateTime dtFechaFin)
    {
        InitializeComponent();

        this.AlbaranesViewer.ServerReport.ReportServerUrl = new Uri("http://localhost/reportserver");
        this.AlbaranesViewer.ServerReport.ReportPath = "/Borradores/Borradores";
        ReportParameter pFechaInicio = new ReportParameter("FechaInicio", dtFechaInicio.ToString());
        ReportParameter pFechaFin = new ReportParameter("FechaFin", dtFechaFin.ToString());

        // Set the report parameters for the report
        ReportParameter[] parameters = new ReportParameter[2];

        parameters[0] = pFechaInicio;
        parameters[1] = pFechaFin;

        this.AlbaranesViewer.ServerReport.SetParameters(parameters);
    }

    public Form_Listado_Albaranes(long NumFactura)
    {
        InitializeComponent();

        this.AlbaranesViewer.ServerReport.ReportServerUrl = new Uri("http://localhost/reportserver");
        this.AlbaranesViewer.ServerReport.ReportPath = "/Borradores/Borradores por Numero Factura";
        ReportParameter pNumFactura = new ReportParameter("NumFactura", NumFactura.ToString());

        // Set the report parameters for the report
        ReportParameter[] parameters = new ReportParameter[1];
        parameters.SetValue(pNumFactura, 0);
        this.AlbaranesViewer.ServerReport.SetParameters(parameters);
    }

    private void Form_Listado_Albaranes_Load(object sender, System.EventArgs e) {
       this.AlbaranesViewer.RefreshReport();
    }
}