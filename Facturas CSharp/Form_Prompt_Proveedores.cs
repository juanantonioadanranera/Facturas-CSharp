using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Facturas_CSharp;

partial class Form_Prompt_Proveedores : System.Windows.Forms.Form {
    
    public Form_Prompt_Proveedores() {
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
                    System.Windows.Forms.MessageBox.Show("Error "+End.Message );
                }
                // El Diseñador de Windows Forms requiere esta llamada.
                InitializeComponent();
            }
        }
    }
    
    private static Form_Prompt_Proveedores m_vb6FormDefInstance;
    
    private static bool m_InitializingDefInstance;
    
    public static Form_Prompt_Proveedores DefInstance {
        get {
            if (((m_vb6FormDefInstance == null) 
                        || m_vb6FormDefInstance.IsDisposed)) {
                m_InitializingDefInstance = true;
                m_vb6FormDefInstance = new Form_Prompt_Proveedores();
                m_InitializingDefInstance = false;
            }
            return m_vb6FormDefInstance;
        }
        set {
            m_vb6FormDefInstance = value;
        }
    }
    
    private bool Preguntar = false;
    
    private void Aceptar_Click(object eventSender, System.EventArgs eventArgs) {
        string Nombre;
        if ((this.dcProveedores.Text != "")) {
            Nombre = dcProveedores.Text;
            Form_Proveedores frmProveedor = new Form_Proveedores(Nombre);
            if (Global.EsFacturaCompras)
            {
                Global.RegFacturaCompras.Cod_Pro = frmProveedor.Cod_Pro.ToString();
            }
            frmProveedor.Show();
            this.Close();
        }
        else {
            MessageBox.Show("Debe escoger un Proveedor", "Error", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            this.dcProveedores.Focus();
        }
    }
    
    private void Cancelar_Click(object eventSender, System.EventArgs eventArgs) {
        Preguntar = true;
        this.Close();
    }
    
    private void Form_Prompt_Proveedores_Closing(object eventSender, System.ComponentModel.CancelEventArgs eventArgs) {
        short OK;
        if (Preguntar) {
            OK = (short)System.Windows.Forms.MessageBox.Show("¿Desea cancelar el proceso?", "Facturas",
                System.Windows.Forms.MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if ((OK == (short)System.Windows.Forms.DialogResult.Yes)) {
                if (Global.EsFacturaCompras) {
                    Global.EsFacturaCompras = false;
                }
                if (Global.EsModificacionCompras) {
                    Global.EsModificacionCompras = false;
                }
                Preguntar = false;
            }
            else {
                eventArgs.Cancel = true;
            }
        }
    }
    
    private void Form_Prompt_Proveedores_Load(object sender, System.EventArgs e) {
        this.dcProveedores.AutoCompleteSource = AutoCompleteSource.ListItems;
        this.dcProveedores.DropDownStyle = ComboBoxStyle.DropDown;
        this.dcProveedores.AutoCompleteMode=AutoCompleteMode.Append;
        // Dim ws As New Aplicacion.ListaClientes.
        DataSet dsProveedorNombre = new DataSet();
        SqlDataAdapter daProveedores = new SqlDataAdapter();
        try {
            daProveedores.SelectCommand = new SqlCommand("CONSULTA_PROVEEDORES", Global.DBConnection);
            daProveedores.SelectCommand.CommandType = CommandType.StoredProcedure;
            daProveedores.Fill(dsProveedorNombre, "PROVEEDORES");
            this.dcProveedores.DataSource = dsProveedorNombre.Tables["PROVEEDORES"];
            // Me.DataSet21.ReadXml("c:\clientes.xml")
            // Me.DataSet21 = New DataSet(Me.DataSet21)
            // ds1 = ws.
            // Me.DataSet21.ReadXml("c:\clientes.xml", XmlReadMode.ReadSchema)
            // ds1.ReadXml("c:\clientes.xml")
            // Dim dr1 As DataTableReader
            // dr1 = ds1.CreateDataReader()
            // Me.dcProveedores.DataSource = ds1.Tables("Proveedores")
            // If dr1.HasRows Then
            // MsgBox("Columnas: " & dr1.FieldCount)
            // Me.SqlDataAdapter1.Fill(Me.DataSet21)
            // End If
        }
        catch (System.Exception ex) {
            MessageBox.Show("Error al cargar proveedores: " + ex.Message);
        }
        finally {
            // ws = Nothing
            dsProveedorNombre.Dispose();
            daProveedores.Dispose();
            dsProveedorNombre = null;
            daProveedores = null;
        }
    }
}