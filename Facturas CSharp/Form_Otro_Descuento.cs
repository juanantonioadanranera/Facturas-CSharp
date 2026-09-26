using System.Windows.Forms;
using Facturas_CSharp;
partial class Form_Otro_Descuento : System.Windows.Forms.Form {
    
    public Form_Otro_Descuento() {
        // El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent();
    }
    
    private bool Preguntar = false;
    
    private void Aceptar_Click(object eventSender, System.EventArgs eventArgs) {
        Global.RegFacturaVentas.ConceptoDescuento = this.Text_Concepto.Text;
        Form_Prompt_Clientes frmPromptClientes = new Form_Prompt_Clientes();
        frmPromptClientes.Show();
        this.Close();
    }
    
    private void Cancelar_Click(object eventSender, System.EventArgs eventArgs) {
        Preguntar = true;
        this.Close();
    }
    
    private void Form_Otro_Descuento_Closing(object eventSender, System.ComponentModel.CancelEventArgs eventArgs) {
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
                else {
                    eventArgs.Cancel = true;
                }
            }
        }
    }
}