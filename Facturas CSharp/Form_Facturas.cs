using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;
using Facturas_CSharp;
partial class Form_Facturas : System.Windows.Forms.Form {
    
    private DataSet dsDetalle, dsFacturas;
    
    private SqlDataAdapter daDetalle, daFacturas;
    
    private long NumFactura;
    
    public Form_Facturas(long NumFactura) {
        InitializeComponent();
        this.NumFactura = NumFactura;
        CargarDatos();
    }
    
    private void Aceptar_Click(object sender, System.EventArgs e) {
        SqlCommand cmdUpdateFactura = new SqlCommand("MODIFICACION_FACTURA", Global.DBConnection);

        try {
            cmdUpdateFactura.CommandType = CommandType.StoredProcedure;
            cmdUpdateFactura.Parameters.Add("@NumFactura", SqlDbType.BigInt);
            cmdUpdateFactura.Parameters["@NumFactura"].Value = this.NumFactura;
            cmdUpdateFactura.Parameters.Add("@Cobrada", SqlDbType.Bit);
            cmdUpdateFactura.Parameters["@Cobrada"].Value = this.chkCobrada.Checked;
            cmdUpdateFactura.ExecuteNonQuery();
            MessageBox.Show("Modificacion realizada con éxito", "Facturas", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        catch (Exception ex) {
            MessageBox.Show("Error al modificar factura: " + ex.Message,"Facturas",MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        finally {
            cmdUpdateFactura.Dispose();
            cmdUpdateFactura = null;
        }
        this.Close();
    }
    
    public void PresentaFecha() {
        int i, LimDias;
        bool EsBisiesto = false;
        CargaFecha();

        if (((((int.Parse(cAnio.Text) % 4) 
                    == 0) 
                    && ((int.Parse(cAnio.Text) % 100) 
                    != 0)) 
                    || ((int.Parse(cAnio.Text) % 400) 
                    == 0))) {
            EsBisiesto = true;
        }
        switch (cMes.SelectedIndex) {
            case 10:
            case 3:
            case 5:
            case 8:
                LimDias = 30;
                break;
            case 1:
                if (EsBisiesto) {
                    LimDias = 29;
                }
                else {
                    LimDias = 28;
                }
                break;
            default:
                LimDias = 31;
                break;
        }
        // cDia.Clear()
        for (i = 1; (i <= LimDias); i++) {
            cDia.Items.Insert((i - 1), i.ToString());
        }
        if (DateTime.Now.Day - 1 
                    < this.cDia.Items.Count) {
            this.cDia.SelectedIndex = (System.DateTime.Now.Day - 1);
        }
        else {
            this.cDia.SelectedIndex = (this.cDia.Items.Count - 1);
        }
    }
    
    private void CargaFecha() {
        int i;
        for (i = 1999; (i <= 2099); i++) {
            cAnio.Items.Insert((i - 1999), i.ToString());
        }
        for (i = 1; (i <= 12); i++) {
            cMes.Items.Insert((i - 1), i.ToString());
        }
        this.cAnio.SelectedIndex = System.DateTime.Now.Year - 1999;
        this.cMes.SelectedIndex = System.DateTime.Now.Month - 1;
        // Call PresentaFecha()
    }
    
    private void CargarDatos() {
        try {
            dsFacturas = new DataSet();
            daFacturas = new SqlDataAdapter();
            daFacturas.SelectCommand = new SqlCommand("CONSULTA_FACTURA_VENTAS", Global.DBConnection);
            daFacturas.SelectCommand.CommandType = CommandType.StoredProcedure;
            daFacturas.SelectCommand.Parameters.Add("@NumFactura", SqlDbType.BigInt);
            daFacturas.SelectCommand.Parameters["@NumFactura"].Value = this.NumFactura;
            daFacturas.Fill(dsFacturas, "FacturasVentas");
            this.Text_Numero.Text = this.NumFactura.ToString();
            this.Text_Destino.Text = dsFacturas.Tables[0].Rows[0]["DESTINO"].ToString();
            this.Text_Cliente.Text = dsFacturas.Tables[0].Rows[0]["NOMBRE"].ToString();
            this.PresentaFecha();
            DateTime dtFechaFactura = 
                DateTime.Parse(dsFacturas.Tables[0].Rows[0]["FECHA_FACTURA"].ToString());
            this.cAnio.SelectedIndex = dtFechaFactura.Year - 1999;
            this.cMes.SelectedIndex = dtFechaFactura.Month - 1;
            this.cDia.SelectedIndex = dtFechaFactura.Day - 1;
            if (bool.Parse(dsFacturas.Tables[0].Rows[0]["COBRADA"].ToString()) == true) {
                this.chkCobrada.Checked = true;
            }
            else {
                this.chkCobrada.Checked = false;
            }
            dsDetalle = new DataSet();
            daDetalle = new SqlDataAdapter();
            daDetalle.SelectCommand = new SqlCommand("CONSULTA_DETALLE_FACTURA", Global.DBConnection);
            daDetalle.SelectCommand.CommandType = CommandType.StoredProcedure;
            daDetalle.SelectCommand.Parameters.Add("@NumFactura", SqlDbType.BigInt);
            daDetalle.SelectCommand.Parameters["@NumFactura"].Value = this.NumFactura;
            daDetalle.Fill(dsDetalle, "HISTORICO");
            this.dgFacturas.DataSource = this.dsDetalle.Tables[0];
        }
        catch (Exception ex) {
            MessageBox.Show("Error al cargar Factura: " + ex.Message);
        }
        finally {
            dsFacturas.Dispose();
            daFacturas.Dispose();
            dsDetalle.Dispose();
            daDetalle.Dispose();
            dsFacturas = null;
            daFacturas = null;
            dsDetalle = null;
            daDetalle = null;
        }
    }
    
    private void Cancelar_Click(object sender, System.EventArgs e) {
        this.Close();
    }
    
    private void VerAlbaranes_Click(object sender, System.EventArgs e) {
        Form_Listado_Albaranes frmListadoAlbaranes = new Form_Listado_Albaranes(this.NumFactura);
        frmListadoAlbaranes.Show();
        this.Close();
    }

    private void cmdBorrar_Click(object sender, EventArgs e)
    {

    }

    private void cmdAniadir_Click(object sender, EventArgs e)
    {

    }
}