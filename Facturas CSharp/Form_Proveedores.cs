using System.Data;
using System.Data.SqlClient;
using Facturas_CSharp;
using System.Windows.Forms;

partial class Form_Proveedores : System.Windows.Forms.Form {
    private long codigo;
    private string nombre;
    private string nif;
    private string direccion;
    private string localidad;
    private string codpostal;
    private string telefono;
    private bool activar = false;
    private bool alta_proveedor;

    public long Cod_Pro
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
    public bool Alta_Proveedor
    {
        get { return alta_proveedor; }
        set { alta_proveedor = value; }
    }
	public bool Activar
	{
		get { return activar;}
		set { activar = value;}
	}
	
    public Form_Proveedores()
    {
        // El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent();
        this.ActivarEdicion();
    }

    public Form_Proveedores(string Nombre)
    {
        if (!Global.Consulta_Proveedor)
        {
            this.Activar = true;
        }
        InitializeComponent();
        this.Nombre = Nombre;
        ConsultaProveedor();
    }

    private bool Preguntar = false;
    
    private void Aceptar_Click(object eventSender, System.EventArgs eventArgs) {
        short Error_Code;
        DialogResult OK;
        if (Global.Alta_Proveedor) {
            Error_Code = ValidarCampos();
            if ((Error_Code == 0)) {
                AsignarProveedor();
                AltaProveedor();
                Global.Alta_Proveedor = false;
                this.Close();
            }
            else {
                MostrarError(Error_Code);
            }
        }
        else if (Global.Baja_Proveedor)
        {
            BajaProveedor();
            Global.Baja_Proveedor = false;
            this.Close();
        }
        else if (Global.Modificacion_Proveedor)
        {
            Error_Code = ValidarCampos();
            if ((Error_Code == 0)) {
                AsignarProveedor();
                ModificacionProveedor();
                Global.Modificacion_Proveedor = false;
                this.Close();
            }
            else {
                MostrarError(Error_Code);
            }
        }
        else if (Global.Consulta_Proveedor)
        {
            Global.Consulta_Proveedor = false;
            this.Close();
        }
        else if (Global.EsFacturaCompras)
        {
            Form_Tipo_Iva frmTipoIva = new Form_Tipo_Iva();
            Error_Code = LibreriaFacturasCompras.ValidarNumeroFacturaCompras(Global.RegFacturaCompras.Numero, 
                this.Cod_Pro);
            if ((Error_Code != 0)) {
                OK = LibreriaFacturasCompras.CompruebaErrorFacturaCompras(Error_Code);
                if ((OK == 0)) {
                    Global.EsModificacionCompras = true;
                    frmTipoIva.Show();
                }
            }
            else {

                frmTipoIva.Show();
            }
            this.Close();
        }
    }
    
    private void Cancelar_Click(object eventSender, System.EventArgs eventArgs) {
        Preguntar = true;
        if (Global.Consulta_Proveedor)
            Global.Consulta_Proveedor = false;
        this.Close();
    }
    
    private void Form_Proveedores_Closing(object eventSender, System.ComponentModel.CancelEventArgs eventArgs) {
        DialogResult OK;
        if (Preguntar) {
            if (Global.EsFacturaCompras)
            {
                OK = MessageBox.Show("¿Desea cancelar el apunte?", "Facturas", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (OK != DialogResult.No)
                {
                    Global.EsFacturaCompras = false;
                }
                else
                {
                    eventArgs.Cancel = true;
                }
            }
            else if (!Global.Consulta_Proveedor)
            {
                OK = MessageBox.Show("¿Desea cancelar el proceso?", "Facturas", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                if ((OK == DialogResult.Yes))
                {
                    if (Global.Alta_Proveedor)
                    {
                        Global.Alta_Proveedor = false;
                    }
                    if (Global.Baja_Proveedor)
                    {
                        Global.Baja_Proveedor = false;
                    }
                    if (Global.Modificacion_Proveedor)
                    {
                        Global.Modificacion_Proveedor = false;
                    }
                }
                else
                {
                    eventArgs.Cancel = true;
                }
            }
        }
    }

    public void ActivarEdicion() {
        this.Text_Nombre.Enabled = this.Activar;
        this.Text_NIF.Enabled = this.Activar;
        this.Text_Localidad.Enabled = this.Activar;
        this.Text_Direccion.Enabled = this.Activar;
        this.Text_CodPostal.Enabled = this.Activar;
    }
    
    public void AsignarProveedor() {
        this.Cod_Pro = long.Parse(this.Text_Codigo.Text);
        this.CodPostal = this.Text_CodPostal.Text;
        this.Direccion = this.Text_Direccion.Text;
        this.Localidad = this.Text_Localidad.Text;
        this.NIF = this.Text_NIF.Text;
        this.Nombre = this.Text_Nombre.Text;
        this.Telefono = this.Text_Telefono.Text;
    }
    
    public short ValidarCampos() {
        if ((this.Text_CodPostal.Text.Length != 5)) {
            return  1012;
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
    
    private void Form_Proveedores_Load(object sender, System.EventArgs e) {
        int Max_Cod_Pro;
        SqlCommand cmdMaxCodPro = 
            new SqlCommand("SELECT [Facturas].[dbo].[MAX_COD_PROVEEDOR] ()", Global.DBConnection);
        if (Global.Alta_Proveedor) {
            try {
                Max_Cod_Pro = (int)cmdMaxCodPro.ExecuteScalar();
                Max_Cod_Pro = 0;
                this.Text_Codigo.Text = "1";
                this.Text_Codigo.Text = (1 + Max_Cod_Pro).ToString();
            }
            catch (System.Exception ex) {
                System.Windows.Forms.MessageBox.Show(("Error: " + ex.Message), "Facturas",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally {
                cmdMaxCodPro.Dispose();
                cmdMaxCodPro = null;
            }
        }
        else {
            this.Text_Codigo.Text = this.Cod_Pro.ToString();
            this.Text_CodPostal.Text = this.CodPostal;
            this.Text_Direccion.Text = this.Direccion;
            this.Text_Localidad.Text = this.Localidad;
            this.Text_NIF.Text = this.NIF;
            this.Text_Nombre.Text = this.Nombre;
            this.Text_Telefono.Text = this.Telefono;
            this.ActivarEdicion();
        }
    }
    public void AltaProveedor()
    {
        SqlCommand cmdAltaProveedor = new SqlCommand("ALTA_PROVEEDOR", Global.DBConnection);
        try
        {
            cmdAltaProveedor.Parameters.Add("@NIF", SqlDbType.NVarChar);
            cmdAltaProveedor.Parameters["@NIF"].Value = this.NIF;
            cmdAltaProveedor.Parameters.Add("@Telefono", SqlDbType.NVarChar);
            cmdAltaProveedor.Parameters["@Telefono"].Value = this.Telefono;
            cmdAltaProveedor.Parameters.Add("@CodPostal", SqlDbType.NVarChar);
            cmdAltaProveedor.Parameters["@CodPostal"].Value = this.CodPostal;
            cmdAltaProveedor.Parameters.Add("@Localidad", SqlDbType.NVarChar);
            cmdAltaProveedor.Parameters["@Localidad"].Value = this.Localidad;
            cmdAltaProveedor.Parameters.Add("@Direccion", SqlDbType.NVarChar);
            cmdAltaProveedor.Parameters["@Direccion"].Value = this.Direccion;
            cmdAltaProveedor.Parameters.Add("@Nombre", SqlDbType.NVarChar);
            cmdAltaProveedor.Parameters["@Nombre"].Value = this.Nombre;
            cmdAltaProveedor.Parameters.Add("@CodPro", SqlDbType.Int);
            cmdAltaProveedor.Parameters["@CodPro"].Value = this.Cod_Pro;
            cmdAltaProveedor.ExecuteNonQuery();
            MessageBox.Show("Alta realizada con éxito","Facturas",MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        catch (System.Exception ex)
        {
            MessageBox.Show("Error al insertar cliente: " + ex.Message,"Facturas",
                MessageBoxButtons.OK,MessageBoxIcon.Error);
            throw;
        }
        finally
        {
            cmdAltaProveedor.Dispose();
            cmdAltaProveedor = null;
        }
    }
    
    public void ModificacionProveedor()
    {
        SqlCommand cmdUpdProveedor = new SqlCommand("MODIFICACION_PROVEEDOR", Global.DBConnection);
        try
        {
            cmdUpdProveedor.Parameters.Add("@NIF", SqlDbType.NVarChar);
            cmdUpdProveedor.Parameters["@NIF"].Value = this.NIF;
            cmdUpdProveedor.Parameters.Add("@Telefono", SqlDbType.NVarChar);
            cmdUpdProveedor.Parameters["@Telefono"].Value = this.Telefono;
            cmdUpdProveedor.Parameters.Add("@CodPostal", SqlDbType.NVarChar);
            cmdUpdProveedor.Parameters["@CodPostal"].Value = this.CodPostal;
            cmdUpdProveedor.Parameters.Add("@Localidad", SqlDbType.NVarChar);
            cmdUpdProveedor.Parameters["@Localidad"].Value = this.Localidad;
            cmdUpdProveedor.Parameters.Add("@Direccion", SqlDbType.NVarChar);
            cmdUpdProveedor.Parameters["@Direccion"].Value = this.Direccion;
            cmdUpdProveedor.Parameters.Add("@Nombre", SqlDbType.NVarChar);
            cmdUpdProveedor.Parameters["@Nombre"].Value = this.Nombre;
            cmdUpdProveedor.Parameters.Add("@CodPro", SqlDbType.BigInt);
            cmdUpdProveedor.Parameters["@CodPro"].Value = this.Cod_Pro;
            cmdUpdProveedor.ExecuteNonQuery();
            MessageBox.Show("Modificacion realizada con éxito", "Facturas", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        catch (System.Exception ex)
        {
            MessageBox.Show("Error al modificar proveedor: " + ex.Message,"Facturas",MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            throw ex;
        }
        finally
        {
            cmdUpdProveedor.Dispose();
            cmdUpdProveedor = null;
        }
    }

    public void BajaProveedor()
    {
        SqlCommand cmdBajaProveedor = new SqlCommand("BAJA_PROVEEDOR", Global.DBConnection);
        try
        {
            cmdBajaProveedor.Parameters.Add("@CodPro", SqlDbType.BigInt);
            cmdBajaProveedor.Parameters["@CodPro"].Value = this.Cod_Pro;
            cmdBajaProveedor.ExecuteNonQuery();
            MessageBox.Show("Baja realizada con éxito", "Facturas", MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }
        catch (System.Exception ex)
        {
            MessageBox.Show("Error al eliminar proveedor: " + ex.Message, "Facturas", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        finally
        {
            cmdBajaProveedor.Dispose();
            cmdBajaProveedor = null;
        }
    }

    public void ConsultaProveedor()
    {
        SqlDataAdapter daProveedores = new SqlDataAdapter();
        DataSet dsProveedorNombre = new DataSet();
        try
        {
            daProveedores.SelectCommand = new SqlCommand("CONSULTA_PROVEEDOR",Global.DBConnection);
            daProveedores.SelectCommand.CommandType = CommandType.StoredProcedure;
            daProveedores.SelectCommand.Parameters.Add("@Nombre", SqlDbType.NVarChar);
            daProveedores.SelectCommand.Parameters["@Nombre"].Value = this.Nombre;
            daProveedores.SelectCommand.ExecuteNonQuery();
            daProveedores.Fill(dsProveedorNombre, "PROVEEDORES");
            this.Cod_Pro = (long)dsProveedorNombre.Tables["PROVEEDORES"].Rows[0]["COD_PRO"];
            this.CodPostal = dsProveedorNombre.Tables["PROVEEDORES"].Rows[0]["CODPOSTAL"].ToString();
            this.Direccion = dsProveedorNombre.Tables["PROVEEDORES"].Rows[0]["DIRECCION"].ToString();
            this.Localidad = dsProveedorNombre.Tables["PROVEEDORES"].Rows[0]["LOCALIDAD"].ToString();
            this.NIF = dsProveedorNombre.Tables["PROVEEDORES"].Rows[0]["NIF"].ToString();
            this.Nombre = dsProveedorNombre.Tables["PROVEEDORES"].Rows[0]["NOMBRE"].ToString();
            this.Telefono = dsProveedorNombre.Tables["PROVEEDORES"].Rows[0]["TELEFONO"].ToString();
        }
        catch (System.Exception ex)
        {
            MessageBox.Show(("Error: " + ex.Message), "Facturas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            daProveedores.Dispose();
            dsProveedorNombre.Dispose();
            daProveedores = null;
            dsProveedorNombre = null;
        }
    }

    public void MostrarError(short Error_Code)
    {
        string strErrMsg = "";
        if ((Error_Code == 1011))
        {
            strErrMsg = "Este cliente ya existe en la base de datos";
        }
        else if ((Error_Code == 1012))
        {
            strErrMsg = "La longitud del código postal debe ser cinco";
        }
        else if ((Error_Code == 1013))
        {
            strErrMsg = "El código postal debe ser numérico";
        }
        else if ((Error_Code == 1014))
        {
            strErrMsg = "La dirección no puede estar en blanco";
        }
        else if ((Error_Code == 1015))
        {
            strErrMsg = "La localidad no puede estar en blanco";
        }
        else if ((Error_Code == 1016))
        {
            strErrMsg = "El NIF no puede estar en blanco";
        }
        else if ((Error_Code == 1017))
        {
            strErrMsg = "El nombre no puede estar en blanco";
        }
        else if ((Error_Code == 1018))
        {
            strErrMsg = "El teléfono debe ser numérico";
        }
        MessageBox.Show(strErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}