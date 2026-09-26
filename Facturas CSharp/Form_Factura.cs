using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Facturas_CSharp;
using CrystalDecisions.CrystalReports.Engine;
public class Form_Factura : System.Windows.Forms.Form {
    
    private long NumeroFactura;
    
    public Form_Factura(long NumFactura) {
        // El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent();
        // Agregar cualquier inicialización después de la llamada a InitializeComponent()
        this.NumeroFactura = NumFactura;
        this.Load += new EventHandler(Form_Factura_Load);
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
    private System.ComponentModel.IContainer components = null;
    
    // NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    // Puede modificarse utilizando el Diseñador de Windows Forms. 
    // No lo modifique con el editor de código.
    
    internal CrystalDecisions.Windows.Forms.CrystalReportViewer FacturasViewer;
    
    [System.Diagnostics.DebuggerStepThrough()]
    private void InitializeComponent() {
        this.FacturasViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
        this.SuspendLayout();
        // 
        // FacturasViewer
        // 
        this.FacturasViewer.ActiveViewIndex = -1;
        this.FacturasViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.FacturasViewer.CausesValidation = false;
        this.FacturasViewer.DisplayGroupTree = false;
        this.FacturasViewer.Dock = System.Windows.Forms.DockStyle.Fill;
        this.FacturasViewer.Location = new System.Drawing.Point(0, 0);
        this.FacturasViewer.Name = "FacturasViewer";
        this.FacturasViewer.SelectionFormula = "";
        this.FacturasViewer.Size = new System.Drawing.Size(640, 373);
        this.FacturasViewer.TabIndex = 0;
        this.FacturasViewer.ViewTimeSelectionFormula = "";
        this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
        this.ClientSize = new System.Drawing.Size(640, 373);
        this.Controls.Add(this.FacturasViewer);
        this.Name = "Form_Factura";
        this.Text = "Facturas";
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        this.ResumeLayout(false);
    }
    
    private void Cargar_Datos() {
        Factura Informe = new Factura();
        SqlDataAdapter daFacturasVentas = new SqlDataAdapter();
        DataSet dsFacturasVentas = new DataSet();
        daFacturasVentas.SelectCommand = new SqlCommand("CONSULTA_FACTURA_VENTAS", Global.DBConnection);
        try {
            daFacturasVentas.SelectCommand.CommandType = CommandType.StoredProcedure;
            daFacturasVentas.SelectCommand.Parameters.Add("@NumFactura", SqlDbType.BigInt);
            daFacturasVentas.SelectCommand.Parameters["@NumFactura"].Value = this.NumeroFactura;
            daFacturasVentas.SelectCommand.ExecuteNonQuery();
            daFacturasVentas.Fill(dsFacturasVentas, "FacturasVentas");
            Informe.SetDataSource(dsFacturasVentas.Tables[0]);
            this.FacturasViewer.ReportSource = Informe;
            Informe.SetParameterValue("@NumFactura", this.NumeroFactura);
            Informe.Refresh();
            this.FacturasViewer.RefreshReport();
        }
        catch (Exception ex) {
            MessageBox.Show("Error en Factura Ventas:" + ex.Message,"Facturas",MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        finally {
            daFacturasVentas.Dispose();
            dsFacturasVentas.Dispose();
        }
    }
    
    private void Form_Factura_Load(object sender, System.EventArgs e) {
        this.Cargar_Datos();
    }
    
    public int BajaFactura(long NumFactura) {
        SqlCommand cmdBajaFacturaVentas = new SqlCommand("BAJA_FACTURA_VENTAS", Global.DBConnection);
        try {
            cmdBajaFacturaVentas.CommandType = CommandType.StoredProcedure;
            cmdBajaFacturaVentas.Parameters.Add("",SqlDbType.BigInt);
            cmdBajaFacturaVentas.Parameters["@NumFactura"].Value = NumFactura;
            cmdBajaFacturaVentas.ExecuteNonQuery();
            return 0;
        }
        catch (Exception ex) {
            MessageBox.Show("Error al eliminar Factura: " + ex.Message,"Facturas",MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return -1;
        }
        finally {
            cmdBajaFacturaVentas.Dispose();
            cmdBajaFacturaVentas = null;
        }
    }
    
    public void AltaFactura(ref Tipos.tFacturaVentas RegFactura) {
        SqlCommand cmdAltaFacturaVentas = new SqlCommand("ALTA_FACTURA_VENTAS", Global.DBConnection);
        try {
            cmdAltaFacturaVentas.CommandType = CommandType.StoredProcedure;
            cmdAltaFacturaVentas.Parameters.Add("@NumFactura", SqlDbType.BigInt);
            cmdAltaFacturaVentas.Parameters["@NumFactura"].Value = RegFactura.Numero;
            cmdAltaFacturaVentas.Parameters.Add("@TipoDescuento", SqlDbType.Decimal);
            cmdAltaFacturaVentas.Parameters["@TipoDescuento"].Value = RegFactura.TipoDescuento;
            cmdAltaFacturaVentas.Parameters.Add("@TipoIva", SqlDbType.Decimal);
            cmdAltaFacturaVentas.Parameters["@TipoIva"].Value = RegFactura.TipoIva;
            cmdAltaFacturaVentas.ExecuteNonQuery();
        }
        catch (Exception ex) {
            MessageBox.Show("Error al crear factura: " + ex.Message, "Facturas", MessageBoxButtons.OK, 
                MessageBoxIcon.Error);
        }
        finally {
            cmdAltaFacturaVentas.Dispose();
            cmdAltaFacturaVentas = null;
        }
    }
    
    public void BajaHistorico(long NumFactura) {
        SqlCommand cmdBajaHistorico = new SqlCommand("BAJA_HISTORICO", Global.DBConnection);
        try {
            cmdBajaHistorico.CommandType = CommandType.StoredProcedure;
            cmdBajaHistorico.Parameters.Add("@NumFactura", SqlDbType.BigInt);
            cmdBajaHistorico.Parameters["@NumFactura"].Value = NumFactura;
            cmdBajaHistorico.ExecuteNonQuery();
        }
        catch (Exception ex) {
            MessageBox.Show(("Error al eliminar histórico: " + ex.Message), "Facturas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally {
            cmdBajaHistorico.Dispose();
            cmdBajaHistorico = null;
        }
    }
    
    public void AltaHistorico(Tipos.tFacturaVentas RegFactura) {
        SqlCommand cmdAltaHistorico = new SqlCommand("ALTA_HISTORICO", Global.DBConnection);
        try {
            cmdAltaHistorico.CommandType = CommandType.StoredProcedure;
            cmdAltaHistorico.Parameters.Add("@FechaFactura", SqlDbType.DateTime);
            cmdAltaHistorico.Parameters["@FechaFactura"].Value = RegFactura.Fecha;
            cmdAltaHistorico.Parameters.Add("@Destino", SqlDbType.NVarChar);
            cmdAltaHistorico.Parameters["@Destino"].Value = RegFactura.Destino;
            cmdAltaHistorico.Parameters.Add("@NumFactura", SqlDbType.BigInt);
            cmdAltaHistorico.Parameters["@NumFactura"].Value = RegFactura.Numero;
            cmdAltaHistorico.Parameters.Add("@CodCli", SqlDbType.Int);
            cmdAltaHistorico.Parameters["@CodCli"].Value = RegFactura.Cod_Cli;
            cmdAltaHistorico.ExecuteNonQuery();
        }
        catch (Exception ex) {
            MessageBox.Show(("Error al crear histórico: " + ex.Message), "Facturas", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally {
            cmdAltaHistorico.Dispose();
            cmdAltaHistorico = null;
        }
    }
    
    public void ActualizaAlbaranes(ref Tipos.tFacturaVentas RegFactura) {
        SqlCommand cmdUpdAlbaranes = new SqlCommand("ACTUALIZA_ALBARANES_FACTURADO", Global.DBConnection);
        try {
            cmdUpdAlbaranes.CommandType = CommandType.StoredProcedure;
            cmdUpdAlbaranes.Parameters.Add("@CodCli", SqlDbType.BigInt);
            cmdUpdAlbaranes.Parameters["@CodCli"].Value = RegFactura.Cod_Cli;
            cmdUpdAlbaranes.Parameters.Add("@FechaFactura", SqlDbType.DateTime);
            cmdUpdAlbaranes.Parameters["@FechaFactura"].Value = RegFactura.Fecha;
            cmdUpdAlbaranes.Parameters.Add("@NumFactura", SqlDbType.BigInt);
            cmdUpdAlbaranes.Parameters["@NumFactura"].Value = RegFactura.Numero;
            cmdUpdAlbaranes.Parameters.Add("@Destino", SqlDbType.NVarChar);
            cmdUpdAlbaranes.Parameters["@Destino"].Value = RegFactura.Destino;
            cmdUpdAlbaranes.ExecuteNonQuery();
        }
        catch (Exception ex) {
            MessageBox.Show(("Error: " + ex.Message), "Facturas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally {
            cmdUpdAlbaranes.Dispose();
            cmdUpdAlbaranes = null;
        }
    }
}