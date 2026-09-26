using System.Data;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using Facturas_CSharp;
public class Form_Listado_Ventas : System.Windows.Forms.Form {
    
    private System.DateTime FechaFin;
    private System.DateTime FechaInicio;

    private SqlDataAdapter daFacturasVentas;
    
    private DataSet dsFacturasVentas;
    
    private System.ComponentModel.IContainer components = null;

    public Form_Listado_Ventas(System.DateTime FechaInicio, System.DateTime FechaFin)
    {
        // El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent();
        // Agregar cualquier inicialización después de la llamada a InitializeComponent()
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        this.FechaInicio = FechaInicio;
        this.FechaFin = FechaFin;
        Cargar_Datos(((ReportDocument)(new ListadoVentasEmpresa())));
    }
    
    protected override void Dispose(bool disposing) {
        if (disposing) {
            if (!(components == null)) {
                components.Dispose();
            }
        }
        base.Dispose(disposing);
    }
    
    // Requerido por el Diseñador de Windows Forms

    
    internal CrystalDecisions.Windows.Forms.CrystalReportViewer CrystalReportViewer1;
    
    [System.Diagnostics.DebuggerStepThrough()]
    private void InitializeComponent() {
        this.CrystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
        this.SuspendLayout();
        // 
        // CrystalReportViewer1
        // 
        this.CrystalReportViewer1.ActiveViewIndex = -1;
        this.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.CrystalReportViewer1.DisplayGroupTree = false;
        this.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.CrystalReportViewer1.Location = new System.Drawing.Point(0, 0);
        this.CrystalReportViewer1.Name = "CrystalReportViewer1";
        this.CrystalReportViewer1.Size = new System.Drawing.Size(742, 397);
        this.CrystalReportViewer1.TabIndex = 0;
        // 
        // Form_Listado_Ventas
        // 
        this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
        this.ClientSize = new System.Drawing.Size(742, 397);
        this.Controls.Add(this.CrystalReportViewer1);
        this.Name = "Form_Listado_Ventas";
        this.Text = "Listado Ventas";
        this.ResumeLayout(false);

    }
    
    public void Cargar_Datos(ReportDocument Informe) {
        daFacturasVentas = new SqlDataAdapter();
        dsFacturasVentas = new DataSet();
        daFacturasVentas.SelectCommand = new SqlCommand("LISTADO_VENTAS", Global.DBConnection);
        try {
            daFacturasVentas.SelectCommand.CommandType = CommandType.StoredProcedure;
            daFacturasVentas.SelectCommand.Parameters.AddWithValue("@FechaFin", this.FechaFin);
            daFacturasVentas.SelectCommand.Parameters.AddWithValue("@FechaInicio",this.FechaInicio);
            daFacturasVentas.Fill(dsFacturasVentas, "FacturasVentas");
            Informe.SetDataSource(dsFacturasVentas.Tables[0]);
            this.CrystalReportViewer1.ReportSource = Informe;
        }
        catch (System.Exception ex) {
            System.Windows.Forms.MessageBox.Show("Error en Listado Facturas Ventas: " + ex.Message);
        }
        finally {
            daFacturasVentas.Dispose();
            dsFacturasVentas.Dispose();
            daFacturasVentas = null;
            dsFacturasVentas = null;
        }
    }
    
    public void SetFechaInicio(System.DateTime Fecha) {
        FechaInicio = Fecha;
    }
    
    public void SetFechaFin(System.DateTime Fecha) {
        FechaFin = Fecha;
    }
    
    private void Form_Listado_Load(object sender, System.EventArgs e) {

    }
}