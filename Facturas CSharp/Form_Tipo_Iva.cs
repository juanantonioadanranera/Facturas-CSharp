using System.Windows.Forms;
using Facturas_CSharp;
partial class Form_Tipo_Iva : System.Windows.Forms.Form {
    private bool Preguntar = false;
    
    public Form_Tipo_Iva() {
        // El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent();
    }
    
    private void Aceptar_Click(object eventSender, System.EventArgs eventArgs) {
        DialogResult OK;
        Preguntar = true;
        if ((this.cTipoIVA.SelectedIndex != -1)) {
            if (Global.EsFacturaVentas) {
                Global.RegFacturaVentas.TipoIva = (double.Parse(cTipoIVA.Text.Substring(0, 2)) / 100);
                OK = MessageBox.Show("Desea establecer un descuento para esta factura?", "Facturas",
                    MessageBoxButtons.YesNo,MessageBoxIcon.Question); 
                if ((OK == System.Windows.Forms.DialogResult.Yes)) {
                    Form_Descuento frmDescuento = new Form_Descuento();
                    frmDescuento.Show();
                    this.Close();
                }
                else {
                    Form_Prompt_Clientes frmPromptClientes = new Form_Prompt_Clientes();
                    frmPromptClientes.Show();
                    this.Close();
                }
            }
            else {
                if (Global.EsFacturaCompras) {
                    Global.RegFacturaCompras.TipoIva = byte.Parse(cTipoIVA.Text.Substring(0, 2));
                    Form_Importe_Factura frmImporteFactura = new Form_Importe_Factura();
                    frmImporteFactura.Show();
                    this.Close();
                }
            }
        }
        else {
            MessageBox.Show("Debe seleccionar un Tipo de IVA", "Facturas");
        }
    }
    
    private void Cancelar_Click(object eventSender, System.EventArgs eventArgs) {
        Preguntar = true;
        this.Close();
    }
    
    private void Form_Tipo_Iva_Load(object eventSender, System.EventArgs eventArgs) {
        string strTipo;
        strTipo = "00 %";
        this.cTipoIVA.Items.Add(strTipo);
        strTipo = "04 %";
        this.cTipoIVA.Items.Add(strTipo);
        strTipo = "08 %";
        this.cTipoIVA.Items.Add(strTipo);
        strTipo = "10 %";
        this.cTipoIVA.Items.Add(strTipo);
        strTipo = "16 %";
        this.cTipoIVA.Items.Add(strTipo);
        strTipo = "18 %";
        this.cTipoIVA.Items.Add(strTipo);
        strTipo = "21 %";
        this.cTipoIVA.Items.Add(strTipo);
        this.cTipoIVA.SelectedIndex = (this.cTipoIVA.Items.Count - 1);
    }
    
    private void Form_Tipo_Iva_Closing(object eventSender, System.ComponentModel.CancelEventArgs eventArgs) {
        DialogResult OK;
        if (Preguntar) {
            OK = MessageBox.Show("¿Desea cancelar el proceso?", "Facturas",
                MessageBoxButtons.YesNo); 
            if ((OK == DialogResult.Yes )) {
                if (Global.EsFacturaCompras) {
                    Global.EsFacturaCompras = false;
                }
                if (Global.EsModificacionCompras) {
                    Global.EsModificacionCompras = false;
                }
                else {
                    eventArgs.Cancel = true;
                }
            }
        }
    }
}