using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Facturas_CSharp;
partial class Form_Destino : System.Windows.Forms.Form {
    
    public Form_Destino() {
        // El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent();
    }
    
    private bool Preguntar = false;

    private Form_Factura frmFactura;
    
    private void Aceptar_Click(object eventSender, System.EventArgs eventArgs) {
        long NumAbono = 0;
        int NumError = 0;
        bool ExisteAbono = false;

        try
        {
            if ((this.dcDestinos.Text != ""))
            {
                frmFactura = new Form_Factura(Global.RegFacturaVentas.Numero);
                Global.RegFacturaVentas.Destino = this.dcDestinos.Text;
                if (Global.EsModificacionVentas)
                {
                    NumError = frmFactura.BajaFactura(Global.RegFacturaVentas.Numero);
                    if ((NumError == 0))
                    {
                        frmFactura.BajaHistorico(Global.RegFacturaVentas.Numero);
                        frmFactura.AltaHistorico(Global.RegFacturaVentas);
                    }
                }
                
                frmFactura.AltaFactura(ref Global.RegFacturaVentas);
                frmFactura.ActualizaAlbaranes(ref Global.RegFacturaVentas);
                
                frmFactura = new Form_Factura(Global.RegFacturaVentas.Numero);
                
                if ((frmFactura.Visible == false))
                {
                    frmFactura.Show();
                }
                
                if (Global.HayDescuento) {
                    NumAbono = LibreriaAbonos.PideNumAbono(Global.RegFacturaVentas.Numero, ref ExisteAbono);
                    if (ExisteAbono) {
                        LibreriaAbonos.BajaAbono(Global.RegFacturaVentas.Numero);
                    }
                    LibreriaAbonos.AltaAbono(Global.RegFacturaVentas.Numero);
                    Global.HayDescuento = false;
                }
                
                Global.EsFacturaVentas = false;
                Global.EsModificacionVentas = false;
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un destino", "Facturas");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error " + ex.Message);
        }
    }
    private void Cancelar_Click(object eventSender, System.EventArgs eventArgs) {
        Preguntar = true;
        this.Close();
    }
    
    private void Form_Destino_Closing(object eventSender, System.ComponentModel.CancelEventArgs eventArgs) {
        DialogResult OK;
        if (Preguntar) {
            OK = MessageBox.Show("¿Desea cancelar el proceso?", "Facturas",MessageBoxButtons.YesNo,
                MessageBoxIcon.Question); 
            if ((OK == DialogResult.Yes)) {
                if (Global.EsFacturaVentas) {
                    Global.EsFacturaVentas = false;
                }
                if (Global.EsModificacionVentas) {
                    Global.EsModificacionVentas = false;
                }
                if (Global.HayDescuento) {
                    Global.HayDescuento = false;
                }
            }
            else {
                eventArgs.Cancel = true;
            }
        }
    }
    
    void Form_Destino_Load(object sender, System.EventArgs e) {
        SqlDataAdapter daDestinos = new SqlDataAdapter();
        DataSet dsDestinos = new DataSet();
        try {
            daDestinos.SelectCommand = new SqlCommand("CONSULTA_DESTINO", Global.DBConnection);
            daDestinos.SelectCommand.CommandType = CommandType.StoredProcedure;
            daDestinos.SelectCommand.Parameters.Add("@CodCli", SqlDbType.Int);
            daDestinos.SelectCommand.Parameters["@CodCli"].Value = Global.RegFacturaVentas.Cod_Cli;
            daDestinos.Fill(dsDestinos);
            this.dcDestinos.DataSource = dsDestinos.Tables[0];
        }
        catch (Exception ex) {
            MessageBox.Show("Error al cargar Obras: " + ex.Message);
        }
        finally {
            daDestinos.Dispose();
            dsDestinos.Dispose();
        }
    }
}