using Facturas_CSharp;
using System.Windows.Forms;
partial class Form_Importe_Factura : System.Windows.Forms.Form {
    
    public Form_Importe_Factura() {
        if ((m_vb6FormDefInstance == null)) {
            if (m_InitializingDefInstance) {
                m_vb6FormDefInstance = this;
            }
            else {
                try {
                    // Para el formulario de inicio, la primera instancia creada es la instancia predeterminada.
                    //if ((System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType == this.GetType)) {
                        m_vb6FormDefInstance = this;
                    //}
                }
                catch (System.Exception End) {
                    System.Windows.Forms.MessageBox.Show("Error " + End.Message);

                }
                // El Diseñador de Windows Forms requiere esta llamada.
                InitializeComponent();
            }
        }
    }
    
    private static Form_Importe_Factura m_vb6FormDefInstance;
    
    private static bool m_InitializingDefInstance;
    
    public static Form_Importe_Factura DefInstance {
        get {
            if (((m_vb6FormDefInstance == null) 
                        || m_vb6FormDefInstance.IsDisposed)) {
                m_InitializingDefInstance = true;
                m_vb6FormDefInstance = new Form_Importe_Factura();
                m_InitializingDefInstance = false;
            }
            return m_vb6FormDefInstance;
        }
        set {
            m_vb6FormDefInstance = value;
        }
    }
    
    private bool Preguntar;
    
    private void Aceptar_Click(object eventSender, System.EventArgs eventArgs) {
        Preguntar = true;
        double num = 0;

        if ((this.Text_Cantidad.Text != "")) {
            try
            {
                num = double.Parse(this.Text_Cantidad.Text);
            }
            catch (System.Exception)
            {
                System.Windows.Forms.MessageBox.Show("La cantidad debe ser numérica", "Error");
            }
            if (num == 0)
            {
                System.Windows.Forms.MessageBox.Show("La cantidad no puede ser cero", "Error");
            }
            else {
                Global.RegFacturaCompras.Total = 
                    float.Parse(Text_Cantidad.Text);
                this.Text_Cantidad.Text = "";
                if (Global.EsModificacionCompras) {
                    LibreriaFacturasCompras.ModificacionFacturaCompras(ref Global.RegFacturaCompras);
                    System.Windows.Forms.MessageBox.Show("Modificación realizada con éxito", "Facturas");
                    Global.EsModificacionCompras = false;
                }
                else {
                    LibreriaFacturasCompras.AltaFacturaCompras(Global.RegFacturaCompras);
                    System.Windows.Forms.MessageBox.Show("Apunte realizado con éxito", "Facturas");
                    Global.EsFacturaCompras = false;
                }
                this.Close();
            }
        }
        else {
            MessageBox.Show("La cantidad no puede ser nula", "Error");
        }
    }
    
    private void Cancelar_Click(object eventSender, System.EventArgs eventArgs) {
        Preguntar = true;
        this.Close();
    }
    
    private void Form_Importe_Factura_Closing(object eventSender, System.ComponentModel.CancelEventArgs eventArgs) {
        DialogResult OK;
        if (Preguntar) {
            OK = MessageBox.Show("¿Desea cancelar el proceso?", "Facturas");
            if ((OK == DialogResult.Yes)) {
                Global.EsFacturaCompras = false;
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