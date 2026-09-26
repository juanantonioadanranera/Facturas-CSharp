using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Facturas_CSharp;
using System;
partial class Form_Clientes : System.Windows.Forms.Form {
    private long codigo;
    private string nombre;
    private string nif;
    private string direccion;
    private string localidad;
    private string codpostal;
    private string telefono;
    private bool activar = false;


    public long Cod_Cli
    {
        get { return codigo; }
        set { codigo = value; }
    }
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
    public string NIF
    {
        get { return nif; }
        set { nif = value; }
    }
    public string Direccion
    {
        get { return direccion; }
        set { direccion = value; }
    }
    public string Localidad
    {
        get { return localidad; }
        set { localidad = value; }
    }
    public string CodPostal
    {
        get { return codpostal; }
        set { codpostal = value; }
    }
    public string Telefono
    {
        get { return telefono; }
        set { telefono = value; }
    }
    public bool Activar
    {
        get { return activar; }
        set { activar = value; }
    }

    public Form_Clientes() {
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

        InitializeComponent();
        if (Global.Alta_Cliente)
        {
            long Max_Cod_Cliente = 0;
            SqlCommand cmdMaxCodCliente;

            cmdMaxCodCliente = new SqlCommand("SELECT [dbo].[MAX_COD_CLIENTE]()", Global.DBConnection);
            try
            {
                Max_Cod_Cliente = long.Parse(cmdMaxCodCliente.ExecuteScalar().ToString());
                this.Text_Codigo.Text = (1 + Max_Cod_Cliente).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(("Error: " + ex.Message), "Facturas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmdMaxCodCliente.Dispose();
                cmdMaxCodCliente = null;
            }
        }
    }
        
    public Form_Clientes(string Nombre)
    {
        if (!Global.Consulta_Cliente && !Global.Baja_Cliente)
        {
            this.Activar = true;
        }
        InitializeComponent();
        ConsultaCliente(Nombre);
        AsignarCampos();
        ActivarEdicion();
    }
    
    private static Form_Clientes m_vb6FormDefInstance;
    
    private static bool m_InitializingDefInstance;
    
    public static Form_Clientes DefInstance {
        get {
            if (((m_vb6FormDefInstance == null) 
                        || m_vb6FormDefInstance.IsDisposed)) {
                m_InitializingDefInstance = true;
                m_vb6FormDefInstance = new Form_Clientes();
                m_InitializingDefInstance = false;
            }
            return m_vb6FormDefInstance;
        }
        set {
            m_vb6FormDefInstance = value;
        }
    }
    
    private bool Preguntar = true;
    
    private void Aceptar_Click(object eventSender, System.EventArgs eventArgs) {
        short Error_Code;
        if (Global.Alta_Cliente) {
            Error_Code = ValidarCamposCliente();
            if ((Error_Code == 0)) {
                AsignarCliente();
                AltaCliente();
                Global.Alta_Cliente = false;
                this.Close();
            }
            else {
                LibreriaClientes.MostrarError(ref Error_Code);
            }
        }
        else if (Global.Baja_Cliente) {
            BajaCliente();
            Global.Baja_Cliente = false;
            this.Close();
        }
        else if (Global.Modificacion_Cliente) {
            Error_Code = ValidarCamposCliente();
            if ((Error_Code == 0)) {
                ModificacionCliente();
                Global.Modificacion_Cliente = false;
                this.Close();
            }
            else {
                LibreriaClientes.MostrarError(ref Error_Code);
            }
        }
        else if (Global.Consulta_Cliente) {
            Global.Consulta_Cliente = false;
            this.Close();
        }
    }
    
    private void Cancelar_Click(object eventSender, System.EventArgs eventArgs) {
        if (!Global.Consulta_Cliente) {
            Preguntar = true;
        }
        Global.Consulta_Cliente = false;
        this.Close();
    }
    
    private void Form_Clientes_Closing(object eventSender, System.ComponentModel.CancelEventArgs eventArgs) {
        DialogResult OK;
        if (Preguntar) {
            OK = System.Windows.Forms.MessageBox.Show("¿Desea cancelar el proceso?", "Facturas",
                System.Windows.Forms.MessageBoxButtons.YesNo );
            if ((OK == System.Windows.Forms.DialogResult.Yes))
            {
                if (Global.Alta_Cliente)
                {
                    Global.Alta_Cliente = false;
                }
                if (Global.Baja_Cliente)
                {
                    Global.Baja_Cliente = false;
                }
                if (Global.Modificacion_Cliente)
                {
                    Global.Modificacion_Cliente = false;
                }
            }
            else
            {
                eventArgs.Cancel = true;
            }
        }
    }

    void AsignarCliente()
    {
        try
        {
            this.Cod_Cli = int.Parse(this.Text_Codigo.Text);
            this.CodPostal = this.Text_CodPostal.Text;
            this.Direccion = this.Text_Direccion.Text;
            this.Localidad = this.Text_Localidad.Text;
            this.NIF = this.Text_NIF.Text;
            this.Nombre = this.Text_Nombre.Text;
            this.Telefono = this.Text_Telefono.Text;
        }
        catch (System.Exception ex)
        {
            System.Windows.Forms.MessageBox.Show("Error " + ex.Message);
            throw;
        }
    }
    
    public short ValidarCamposCliente() {
        if ((this.Text_CodPostal.Text.Length != 5)) {
            return 1012;
        }
        else if ((this.Text_Direccion.Text == "")) {
            return 1014;
        }
        else if ((this.Text_Localidad.Text == "")) {
            return 1015;
        }
        else if ((this.Text_NIF.Text == "")) {
            return 1016;
        }
        else if ((this.Text_Nombre.Text == "")) {
            return 1017;
        }
        else {
            try
            {
                double.Parse(this.Text_CodPostal.Text);
            }
            catch (System.Exception)
            {
                return 1013;
            }
            try
            {
                double.Parse(this.Text_Telefono.Text);
            }
            catch (System.Exception)
            {
                return 1018;
            } 
            return 0;
        }
    }
    
    public void AsignarCampos() {
        try
        {
            this.Text_Codigo.Text = this.Cod_Cli.ToString();
            this.Text_CodPostal.Text = this.CodPostal;
            this.Text_Direccion.Text = this.Direccion;
            this.Text_Localidad.Text = this.Localidad;
            this.Text_NIF.Text = this.NIF;
            this.Text_Nombre.Text = this.Nombre;
            this.Text_Telefono.Text = this.Telefono;
        }
        catch (System.Exception ex)
        {
            System.Windows.Forms.MessageBox.Show("Error "+ex.Message );
            throw;
        }
    }
    
    public void LimpiarCampos() {
        this.Text_Codigo.Text = "";
        this.Text_CodPostal.Text = "";
        this.Text_Direccion.Text = "";
        this.Text_Localidad.Text = "";
        this.Text_NIF.Text = "";
        this.Text_Nombre.Text = "";
        this.Text_Telefono.Text = "";
    }
    
    public void ActivarEdicion() {
        this.Text_CodPostal.Enabled = this.Activar;
        this.Text_Direccion.Enabled = this.Activar;
        this.Text_Localidad.Enabled = this.Activar;
        this.Text_NIF.Enabled = this.Activar;
        this.Text_Nombre.Enabled = this.Activar;
        this.Text_Telefono.Enabled = this.Activar;
    }
    
    private void Form_Clientes_Load(object sender, System.EventArgs e) {

    }
    
    public void AltaCliente()
    {
        SqlCommand cmdAltaCliente = new SqlCommand("ALTA_CLIENTE", Global.DBConnection);
        try
        {
            cmdAltaCliente.CommandType = CommandType.StoredProcedure;
            cmdAltaCliente.Parameters.Add("@NIF", SqlDbType.NVarChar);
            cmdAltaCliente.Parameters["@NIF"].Value = this.NIF;
            cmdAltaCliente.Parameters.Add("@Telefono", SqlDbType.NVarChar);
            cmdAltaCliente.Parameters["@Telefono"].Value = this.Telefono;
            cmdAltaCliente.Parameters.Add("@CodPostal", SqlDbType.NVarChar);
            cmdAltaCliente.Parameters["@CodPostal"].Value = this.CodPostal;
            cmdAltaCliente.Parameters.Add("@Localidad", SqlDbType.NVarChar);
            cmdAltaCliente.Parameters["@Localidad"].Value = this.Localidad;
            cmdAltaCliente.Parameters.Add("@Direccion", SqlDbType.NVarChar);
            cmdAltaCliente.Parameters["@Direccion"].Value = this.Direccion;
            cmdAltaCliente.Parameters.Add("@Nombre", SqlDbType.NVarChar);
            cmdAltaCliente.Parameters["@Nombre"].Value = this.Nombre;
            cmdAltaCliente.Parameters.Add("@CodCli", SqlDbType.Int);
            cmdAltaCliente.Parameters["@CodCli"].Value = this.Cod_Cli;
            cmdAltaCliente.ExecuteNonQuery();
            MessageBox.Show("Alta realizada con éxito", "Facturas",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al insertar cliente: " + ex.Message,"Facturas",
                MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        finally
        {
            cmdAltaCliente.Dispose();
            cmdAltaCliente = null;
        }
    }

    public void ModificacionCliente()
    {
        SqlCommand cmdUpdCliente = new SqlCommand("MODIFICACION_CLIENTE", Global.DBConnection);
        try
        {
            cmdUpdCliente.Parameters.Add("@NIF", SqlDbType.NVarChar);
            cmdUpdCliente.Parameters["@NIF"].Value = this.NIF;
            cmdUpdCliente.Parameters.Add("@Telefono", SqlDbType.NVarChar);
            cmdUpdCliente.Parameters["@Telefono"].Value = this.Telefono;
            cmdUpdCliente.Parameters.Add("@CodPostal", SqlDbType.NVarChar);
            cmdUpdCliente.Parameters["@CodPostal"].Value = this.CodPostal;
            cmdUpdCliente.Parameters.Add("@Localidad", SqlDbType.NVarChar);
            cmdUpdCliente.Parameters["@Localidad"].Value = this.Localidad;
            cmdUpdCliente.Parameters.Add("@Direccion", SqlDbType.NVarChar);
            cmdUpdCliente.Parameters["@Direccion"].Value = this.Direccion;
            cmdUpdCliente.Parameters.Add("@Nombre", SqlDbType.NVarChar);
            cmdUpdCliente.Parameters["@Nombre"].Value = this.Nombre;
            cmdUpdCliente.Parameters.Add("@CodCli", SqlDbType.Int);
            cmdUpdCliente.Parameters["@CodCli"].Value = this.Cod_Cli;
            cmdUpdCliente.ExecuteNonQuery();
            MessageBox.Show("Modificacion realizada con éxito", "Facturas", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        catch (System.Exception ex)
        {
            MessageBox.Show("Error al modificar cliente: " + ex.Message,"Facturas",MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        finally
        {
            cmdUpdCliente.Dispose();
            cmdUpdCliente = null;
        }
    }

    public void BajaCliente()
    {
        SqlCommand cmdBajaCliente = new SqlCommand("BAJA_CLIENTE", Global.DBConnection);
        try
        {
            cmdBajaCliente.CommandType = CommandType.StoredProcedure;
            cmdBajaCliente.Parameters.Add("@CodCli",SqlDbType.BigInt);
            cmdBajaCliente.Parameters["@CodCli"].Value=this.Cod_Cli;
            cmdBajaCliente.ExecuteNonQuery();
             MessageBox.Show("Baja realizada con éxito", "Facturas", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        catch (System.Exception ex)
        {
            MessageBox.Show("Error al eliminar cliente: " + ex.Message,"Facturas",MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        finally
        {
            cmdBajaCliente.Dispose();
            cmdBajaCliente = null;
        }
    }

    public void ConsultaCliente(string Nombre)
    {
        SqlDataAdapter daClientes = new SqlDataAdapter();
        DataSet dsClientes = new DataSet();
        dsClientes = new DataSet();
        try
        {
            daClientes.SelectCommand = new SqlCommand("CONSULTA_CLIENTE",Global.DBConnection);
            daClientes.SelectCommand.CommandType = CommandType.StoredProcedure;
            daClientes.SelectCommand.Parameters.Add("@Nombre", SqlDbType.VarChar);
            daClientes.SelectCommand.Parameters["@Nombre"].Value = Nombre;
            daClientes.SelectCommand.ExecuteNonQuery();
            daClientes.Fill(dsClientes);
            
            this.Cod_Cli = long.Parse (dsClientes.Tables[0].Rows[0]["COD_CLI"].ToString());
            this.CodPostal = dsClientes.Tables[0].Rows[0]["CODPOSTAL"].ToString();
            this.Direccion = dsClientes.Tables[0].Rows[0]["DIRECCION"].ToString();
            this.Localidad = dsClientes.Tables[0].Rows[0]["LOCALIDAD"].ToString();
            this.NIF = dsClientes.Tables[0].Rows[0]["NIF"].ToString();
            this.Nombre = dsClientes.Tables[0].Rows[0]["NOMBRE"].ToString();
            this.Telefono = dsClientes.Tables[0].Rows[0]["TELEFONO"].ToString();
        }
        catch (System.Exception ex)
        {
            MessageBox.Show("Error al consultar cliente: " + ex.Message,"Facturas",MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        finally
        {
            daClientes.Dispose();
            dsClientes.Dispose();
            daClientes = null;
            dsClientes = null;
        }
    }
}