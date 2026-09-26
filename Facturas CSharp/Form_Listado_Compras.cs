using System.Data;
using System.Data.SqlClient;
using Facturas_CSharp;
partial class Form_Listado_Compras : System.Windows.Forms.Form {

    private System.DateTime FechaFin;

    private System.DateTime FechaInicio;
    
    private System.Data.SqlClient.SqlDataAdapter daFacturasCompras;
    
    private System.Data.DataSet dsFacturasCompras;
    
    public Form_Listado_Compras(System.DateTime FechaInicio, System.DateTime FechaFin) {
        // El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent();
        // Agregar cualquier inicialización después de la llamada a InitializeComponent()
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        this.FechaInicio = FechaInicio;
        this.FechaFin = FechaFin;
        this.Cargar_Datos(((CrystalDecisions.CrystalReports.Engine.ReportDocument)(new ListadoComprasEmpresa())));
    }
    
    public void Cargar_Datos(CrystalDecisions.CrystalReports.Engine.ReportDocument Informe)
    {
        daFacturasCompras = new SqlDataAdapter();
        dsFacturasCompras = new DataSet();
        daFacturasCompras.SelectCommand = new SqlCommand("LISTADO_COMPRAS", Global.DBConnection);
        try {
            daFacturasCompras.SelectCommand.CommandType = CommandType.StoredProcedure;
            daFacturasCompras.SelectCommand.Parameters.AddWithValue ("@FechaFin",this.FechaFin);
            daFacturasCompras.SelectCommand.Parameters.AddWithValue("@FechaInicio",this.FechaInicio);
            daFacturasCompras.SelectCommand.ExecuteNonQuery();
            daFacturasCompras.Fill(dsFacturasCompras, "FacturasCompras");
            Informe.SetDataSource(dsFacturasCompras.Tables[0]);
            this.CrystalReportViewer1.ReportSource = Informe;
        }
        catch (System.Exception ex) {
            System.Windows.Forms.MessageBox.Show("Error en Listado Facturas Compras: " + ex.Message);
        }
        finally {
            daFacturasCompras.Dispose();
            dsFacturasCompras.Dispose();
            daFacturasCompras = null;
            dsFacturasCompras = null;
        }
    }
}