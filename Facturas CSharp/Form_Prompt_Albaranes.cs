// TODO: Option Strict Option ... Warning!!! not translated
// TODO: Option Explicit On ... Warning!!! not translated
partial class Form_Prompt_Albaranes : System.Windows.Forms.Form {
    
    public Form_Prompt_Albaranes() {
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
                        System.Windows.Forms.MessageBox.Show("Error "+End.Message);
                }
                // El Diseñador de Windows Forms requiere esta llamada.
                InitializeComponent();
            }
        }
    }
    
    private static Form_Prompt_Albaranes m_vb6FormDefInstance;
    
    private static bool m_InitializingDefInstance;
    
    public static Form_Prompt_Albaranes DefInstance {
        get {
            if (((m_vb6FormDefInstance == null) 
                        || m_vb6FormDefInstance.IsDisposed)) {
                m_InitializingDefInstance = true;
                m_vb6FormDefInstance = new Form_Prompt_Albaranes();
                m_InitializingDefInstance = false;
            }
            return m_vb6FormDefInstance;
        }
        set {
            m_vb6FormDefInstance = value;
        }
    }
    
    private void Form_Prompt_Albaranes_Load(object sender, System.EventArgs e) {
        // Me.SqlDataAdapter1.Fill(Me.DataSet71)
    }
    
    private void Aceptar_Click(object sender, System.EventArgs e) {
    }

}