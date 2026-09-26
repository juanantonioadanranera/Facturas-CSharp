using System.Windows.Forms;
using Facturas_CSharp;
partial class Form_Concepto_Descuento : System.Windows.Forms.Form {
    
    public Form_Concepto_Descuento() {
        // El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent();
    }
    
    private bool Preguntar = false;
    
    private void Aceptar_Click(object eventSender, System.EventArgs eventArgs) {
        Global.RegFacturaVentas.ConceptoDescuento = this.cConcepto.Text;
        Form_Prompt_Clientes frmPromptClientes = new Form_Prompt_Clientes();
        frmPromptClientes.Show();
        this.Close();
    }
    
    private void Cancelar_Click(object eventSender, System.EventArgs eventArgs) {
        Preguntar = true;
        this.Close();
    }
    
    private void Form_Concepto_Descuento_Closing(object eventSender, System.ComponentModel.CancelEventArgs eventArgs) {
        DialogResult OK;
        if (Preguntar) {
            OK = MessageBox.Show("¿Desea cancelar el proceso?", "Facturas",MessageBoxButtons.YesNo,
                MessageBoxIcon.Question); 
            if ((OK == DialogResult.Yes)) {
                if (Global.EsFacturaVentas) {
                    Global.EsFacturaVentas = false;
                }
                if (Global.EsModificacionVentas)
                {
                    Global.EsModificacionVentas = false;
                }
                else {
                    eventArgs.Cancel = true;
                }
            }

        }
    }
    
    void Form_Concepto_Descuento_Load(object eventSender, System.EventArgs eventArgs) {
        this.cConcepto.Items.Add("cantidad");
        this.cConcepto.Items.Add("pronto pago");
        this.cConcepto.SelectedIndex = (this.cConcepto.Items.Count - 1);
    }
    
    private void Otro_Click(object eventSender, System.EventArgs eventArgs) {
        Form_Otro_Descuento frmOtroDescuento = new Form_Otro_Descuento();
        frmOtroDescuento.Show();
        this.Close();
    }
}