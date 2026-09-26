using System.Windows.Forms;
using Facturas_CSharp;
using System.Collections;
using System.Collections.Generic;
partial class Form_Descuento : System.Windows.Forms.Form {

    private bool Preguntar = false;
    private List<ComboBox> cDescuento = new List<ComboBox>();

    public Form_Descuento() {
        // El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent();
        this.cDescuento.Insert(0, this._cDescuento_0);
        this.cDescuento.Insert(1, this._cDescuento_1);
    }

    //private List<Label> Label = new List<Label>();

    private void Aceptar_Click(object eventSender, System.EventArgs eventArgs) {
        if ((cDescuento[0].Text != "")) {
            if ((cDescuento[1].Text != "")) {
                Global.RegFacturaVentas.TipoDescuento = 
                    (double.Parse((cDescuento[0].Text + cDescuento[1].Text)) / 10000);
                Global.HayDescuento = true;
                Form_Concepto_Descuento frmConceptoDescuento = new Form_Concepto_Descuento();
                frmConceptoDescuento.Show();
                this.Close();
            }
            else {
                MessageBox.Show("Debe seleccionar un tipo de descuento", "Facturas");
            }
        }
        else {
            MessageBox.Show("Debe seleccionar un tipo de descuento","Facturas");
        }
    }
    
    private void Cancelar_Click(object eventSender, System.EventArgs eventArgs) {
        Preguntar = true;
        this.Close();
    }
    
    private void Form_Descuento_Load(object eventSender, System.EventArgs eventArgs) {
        short i;
        short j;
        for (j = 0; (j <= 1); j++) {
            for (i = 0; (i <= 99); i++) {
                this.cDescuento[j].Items.Add(i.ToString().PadLeft(2,'0'));
            }
        }
        this.cDescuento[0].SelectedIndex = 1;
        this.cDescuento[1].SelectedIndex = 84;
    }
    
    private void Form_Descuento_Closing(object eventSender, System.ComponentModel.CancelEventArgs eventArgs) {
        DialogResult OK;
        if (Preguntar) {
            if ((Global.HayDescuento == false))
            {
                OK = MessageBox.Show("¿Quiere hacer la factura sin descuento?", "Facturas",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if ((OK == DialogResult.Yes))
                {
                    Global.RegFacturaVentas.TipoDescuento = ((double)(0));
                    Form_Concepto_Descuento frmConceptoDescuento = new Form_Concepto_Descuento();
                    frmConceptoDescuento.Show();
                }
                else
                {
                    OK = MessageBox.Show("¿Desea cancelar el proceso?", "Facturas");
                    eventArgs.Cancel = true;
                }
            }
        }
    }
}