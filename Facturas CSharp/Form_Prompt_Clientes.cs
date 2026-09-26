using Facturas_CSharp;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System;
partial class Form_Prompt_Clientes : System.Windows.Forms.Form {
    
    public Form_Prompt_Clientes() {
        // El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent();

        CargarDatos();
    }
    
    private bool Preguntar = false;
    
    private void Aceptar_Click(object eventSender, System.EventArgs eventArgs) {
        string Nombre;
        try {
            if ((this.dcClientes.Text != "")) {
                Nombre = this.dcClientes.Text;
                Form_Clientes frmCliente = new Form_Clientes(Nombre);
                Global.RegFacturaVentas.Cod_Cli = frmCliente.Cod_Cli;

                if (!Global.EsFacturaVentas) {
                    frmCliente.Show();
                    this.Close();
                }
                else {
                    Form_Destino frmDestino;
                    frmDestino = new Form_Destino();
                    frmDestino.Show();
                    this.Close();
                }
            }
            else {
                MessageBox.Show("Debe escoger un cliente", "Error");
                this.dcClientes.Focus();
            }
        }
        catch (Exception ex) {
            MessageBox.Show("Error al cargar clientes: " + ex.Message);
        }
    }
    
    private void Cancelar_Click(object eventSender, System.EventArgs eventArgs) {
        if (!Global.Consulta_Cliente)
        {
            Preguntar = true;
        }
        else
        {
            Global.Consulta_Cliente = false;
        }
        this.Close();
    }
    
    private void Form_Prompt_Clientes_Closing(object eventSender, System.ComponentModel.CancelEventArgs eventArgs) {
        DialogResult OK;
        if (Preguntar) {
            OK = MessageBox.Show("¿Desea cancelar el proceso?", "Facturas", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);
            if ((OK == DialogResult.Yes)) {
                if (Global.EsFacturaVentas) {
                    Global.EsFacturaVentas = false;
                }
                if (Global.EsModificacionVentas) {
                    Global.EsModificacionVentas = false;
                }
                if (Global.Alta_Cliente) {
                    Global.Alta_Cliente = false;
                }
                if (Global.Baja_Cliente) {
                    Global.Baja_Cliente = false;
                }
                if (Global.Modificacion_Cliente)
                {
                    Global.Modificacion_Cliente = false;
                }
                else {
                    eventArgs.Cancel = true;
                }
            }
        }
    }
    
    void Form_Prompt_Clientes_Load(object sender, System.EventArgs e) {
    }

    private void CargarDatos()
    {
        SqlDataAdapter daClientes = new SqlDataAdapter();;
        DataSet dsClienteNombre = new DataSet();
        try
        {
            daClientes.SelectCommand = new SqlCommand("CONSULTA_CLIENTES", Global.DBConnection);
            daClientes.SelectCommand.CommandType = CommandType.StoredProcedure;
            daClientes.Fill(dsClienteNombre);
            this.dcClientes.DataSource = dsClienteNombre.Tables[0];
            this.dcClientes.DisplayMember = "NOMBRE";
            this.dcClientes.Update();
            // Dim ws As New Aplicacion.ListaClientes.
            // Dim ds1 As DataSet = New DataSet()
            // Me.DataSet21.ReadXml("c:\clientes.xml")
            // Me.DataSet21 = New DataSet(Me.DataSet21)
            // ds1 = ws.CallListaClientes()
            // Me.DataSet21.ReadXml("c:\clientes.xml", XmlReadMode.ReadSchema)
            // ds1.ReadXml("c:\clientes.xml")
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al cargar clientes: " + ex.Message);
        }
        finally
        {
            daClientes.Dispose();
            dsClienteNombre.Dispose();
            daClientes = null;
            dsClienteNombre = null;
            this.Refresh();
        }
    }
}