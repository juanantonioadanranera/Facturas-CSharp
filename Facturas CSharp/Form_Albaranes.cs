using System.Windows.Forms;
using VB = Microsoft.VisualBasic;
using System.Data;
using System.Data.SqlClient;
using System;
using Facturas_CSharp;
public partial class Form_Albaranes : System.Windows.Forms.Form {
    private int cod_cli;
    private int cod_mat;
    private System.DateTime fecha;
    private int numero;
    private string descripcion;
    private float cantidad;
    private bool facturado;
    private string destino;
    private string cliente;
    private bool activar;

    public int Cod_Cli
    {
        get { return cod_cli; }
        set { cod_cli = value; }
    }
    public int Cod_Mat
    {
        get { return cod_mat; }
        set { cod_mat = value; }
    }
    public System.DateTime Fecha
    {
        get { return fecha; }
        set { fecha = value; }
    }
    public int Numero
    {
        get { return numero; }
        set { numero = value; }
    }
    public string Descripcion
    {
        get { return descripcion; }
        set { descripcion= value; }
    }
    public float Cantidad
    {
        get { return cantidad; }
        set { cantidad = value; }
    }
    public bool Facturado
    {
        get { return facturado; }
        set { facturado = value; }
    }
    public string Destino
    {
        get { return destino; }
        set { destino = value; }
    }
    public string Cliente
    {
        get { return cliente; }
        set { cliente = value; }
    }


    public bool Activar
    {
        get { return activar; }
        set { activar = value; }
    }
	

    public Form_Albaranes() {
        InitializeComponent();
        //TODO: MIRAR ESTO A VER COMO AGRANDO el FORMULARIO
        //VB6.TwipsToPixelsY(5055).dcDestino.Visible = false;
        //VB6.TwipsToPixelsY(4215).Height = false;
        //this.Marco.Height = false;
        this.txtNumero.Enabled = true;
        //this.dgMateriales.Visible = false;
    }

    private Form_Cantidad frmCantidad;
    
    public Form_Albaranes(long NumAlbaran)
    {
        if (Global.Consulta_Albaran || Global.Baja_Albaran)
        {
            this.Activar = false;
        }
        else
        {
            this.Activar = true;
        }
        InitializeComponent();
        DataSet ds = ConsultaAlbaran(NumAlbaran);
        AsignarCampos(ds);
        AsignarAlbaran(null,false);
        ActivarEdicion();
    }
    
    private bool Preguntar = false;
    
    private void cmdAceptar_Click(object eventSender, System.EventArgs eventArgs) {
        short Error_Code;
        if (Global.Alta_Albaran) {
            Error_Code = ValidarCampos();
            if ((Error_Code == 0)) {
                if (!ExisteAlbaran(long.Parse(this.txtNumero.Text))) {
                    frmCantidad = new Form_Cantidad();
                    frmCantidad.Owner = this;
                    frmCantidad.Show();
                }
                else {
                    MessageBox.Show("Este número de albarán ya existe", "Facturas", MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                }
            }
            else {
                CompruebaError(Error_Code);
            }
        }
        else if (Global.Baja_Albaran) {
            BajaAlbaran(long.Parse(this.txtNumero.Text));
            Global.Baja_Albaran = false;
            this.Close();
        }
        else if (Global.Modificacion_Albaran) {
            AsignarAlbaran(((Form_Cantidad)(null)), false);
            ModificacionAlbaran(ref Global.RegAlbaran);
            Global.Modificacion_Albaran = false;
            this.Close();
        }
        else if (Global.Consulta_Albaran) {
            Global.Consulta_Albaran = false;
            this.Close();
        }
    }
    
    private void cmdCancelar_Click(object eventSender, System.EventArgs eventArgs) {
        if (!Global.Consulta_Albaran) {
            Preguntar = true;
        }
        else
        {
            Global.Consulta_Albaran = false;
        }
        this.Close();
    }
    
    private void cmdAniadir_Click(object eventSender, System.EventArgs eventArgs) {
        frmCantidad = new Form_Cantidad();
        frmCantidad.Owner = this;
        frmCantidad.Show();
    }
    
    private void cmdBorrar_Click(object eventSender, System.EventArgs eventArgs) {
        short Error_Code;
        Error_Code = ValidarCampos();
        if ((Error_Code == 0)) {
            try {
                if (ExisteAlbaran(int.Parse(this.txtNumero.Text))) {
                    string Descripcion;
                    Descripcion = this.dgMateriales[1, this.dgMateriales.CurrentRow.Index].Value.ToString();
                    BorrarLineaAlbaran(int.Parse(this.txtNumero.Text), Descripcion);
                    this.AsignarCampos(ConsultaAlbaran(int.Parse(this.txtNumero.Text)));
                }
                else {
                    MessageBox.Show("Este número de albarán no existe", "Facturas");
                }
            }
            catch (System.Exception ex) {
                MessageBox.Show("Error " + ("\r\n"+ex.Message + ("\r\n" + this.Name)));
            }
        }
        else {
            CompruebaError(Error_Code);
        }
    }

    private void cMes_SelectedIndexChanged(object eventSender, System.EventArgs eventArgs) {
        PresentaFecha();
    }
    
    private void PresentaFecha() {
        short LimDias;
        short i;
        bool EsBisiesto=false;
        // Solo llenamos los combo si es la primera vez y no estamos actualizando con la fecha del albaran
        if ((this.cmbAnio.Items.Count == 0)) {
            cmbAnio.Items.Clear();
            for (i = 1999; (i <= 2099); i++) {
                cmbAnio.Items.Add(i.ToString().PadLeft(2,'0'));
            }
            this.cmbAnio.SelectedIndex = (DateTime.Now.Year - 1999);
        }

        if (((((short.Parse(cmbAnio.Text) % 4) 
                    == 0) 
                    && ((short.Parse(cmbAnio.Text) % 100) 
                    != 0)) 
                    || ((short.Parse(cmbAnio.Text) % 400) 
                    == 0))) {
            EsBisiesto = true;
        }

        if ((cmbMes.Items.Count == 0)) {
            cmbMes.Items.Clear();
            for (i = 1; (i <= 12); i++) {
                cmbMes.Items.Add(i.ToString().PadLeft(2,'0'));
            }
            this.cmbMes.SelectedIndex = (DateTime.Now.Month - 1);
        }


        switch (short.Parse(cmbMes.Text)) {
            case 11:
            case 4:
            case 6:
            case 9:
                LimDias = 30;
                break;
            case 1:
                if (EsBisiesto) {
                    LimDias = 29;
                }
                else {
                    LimDias = 28;
                }
                break;
            default:
                LimDias = 31;
                break;
        }

        cmbDia.Items.Clear();
        for (i = 1; (i <= LimDias); i++)
        {
            cmbDia.Items.Add(i.ToString().PadLeft(2,'0'));
        }

        // Si el día de hoy es mayor que el ultimo del mes, ponemos el ultimo del mes
        if ((DateTime.Now.Day - 1) 
                    < this.cmbDia.Items.Count) {
            this.cmbDia.SelectedIndex = (DateTime.Now.Day - 1);
        }
        else {
            this.cmbDia.SelectedIndex = (this.cmbDia.Items.Count - 1);
        }
    }
    
    private void Form_Albaranes_Closing(object eventSender, System.ComponentModel.CancelEventArgs eventArgs) {
        DialogResult OK;
        if (Preguntar) {
            OK = MessageBox.Show("¿Desea cancelar el proceso?", "Facturas"); 
            if ((OK == DialogResult.Yes)) {
                if (Global.Alta_Albaran) {
                    Global.Alta_Albaran = false;
                    this.dgMateriales.Visible = true;
                    this.dgMateriales.Visible = true;
                    // With...
                    this.txtNumero.Enabled = false;
                    //this.Marco.Height = VB6.TwipsToPixelsY(6255);
                    //this.Height = VB6.TwipsToPixelsY(7110);
                }
            }
            else {
                eventArgs.Cancel = true;
            }
        }
        if (Global.Alta_Albaran) {
            Global.Alta_Albaran = false;
        }
        if (Global.Baja_Albaran) {
            Global.Baja_Albaran = false;
        }
        if (Global.Modificacion_Albaran) {
            Global.Modificacion_Albaran = false;
        }
        if (Global.Consulta_Albaran) {
            Global.Consulta_Albaran = false;
        }
        this.frmCantidad.Close();
    }
    
    public void LimpiarCampos() {
        this.txtNumero.Text = "";
        //this.Facturado. = false;
        this.dcDestino.Text = "";
        this.txtDestino.Text = "";
    }
    
    public void AsignarCampos(DataSet dsAlbaran) {
        DataSet dsClientes = new DataSet();
        DataSet dsAlbaranes = new DataSet();
        DataSet dsDestinos = new DataSet();
        SqlDataAdapter daClientes = new SqlDataAdapter();
        SqlDataAdapter daAlbaranes = new SqlDataAdapter();
        SqlDataAdapter daDestinos = new SqlDataAdapter();
        
        PresentaFecha();
        
        try {
            daClientes.SelectCommand = new SqlCommand("CONSULTA_CLIENTES", Global.DBConnection);
            daClientes.SelectCommand.CommandType = CommandType.StoredProcedure;
            daClientes.Fill(dsClientes, "Clientes");
            this.dcClientes.DataSource = dsClientes.Tables[0];
            daDestinos.SelectCommand = new SqlCommand("CONSULTA_DESTINOS", Global.DBConnection);
            daDestinos.SelectCommand.CommandType = CommandType.StoredProcedure;
            daDestinos.Fill(dsDestinos, "Obras");
            this.dcDestino.DataSource = dsDestinos.Tables[0];
            if (!(dsAlbaran == null)) {
                daAlbaranes.SelectCommand = new SqlCommand("CONSULTA_DESCRIPCION", Global.DBConnection);
                daAlbaranes.SelectCommand.CommandType = CommandType.StoredProcedure;
                daAlbaranes.SelectCommand.Parameters.Add("@NumAlbaran", SqlDbType.BigInt);
                daAlbaranes.SelectCommand.Parameters["@NumAlbaran"].Value = 
                    dsAlbaran.Tables[0].Rows[0]["Numero"];
                daAlbaranes.Fill(dsAlbaranes, "Albaranes");
                this.dgMateriales.DataSource = dsAlbaranes.Tables[0];
                this.dgMateriales.AutoResizeColumns();
                this.dgMateriales.Refresh();
                // With...
                this.dcClientes.SelectedIndex = 
                    this.dcClientes.FindString(dsAlbaran.Tables[0].Rows[0]["NOMBRE"].ToString());
                this.txtNumero.Text = dsAlbaran.Tables[0].Rows[0]["Numero"].ToString();
                this.txtDestino.Visible = true;
                this.dcDestino.Visible = false;
                this.txtDestino.Text = dsAlbaran.Tables[0].Rows[0]["Destino"].ToString();
                System.DateTime dtFechaAlbaran = Convert.ToDateTime(dsAlbaran.Tables[0].Rows[0]["Fecha_Albaran"]);
                int Anio = dtFechaAlbaran.Year;
                Anio -= 1999;
                int Mes = dtFechaAlbaran.Month;
                int Dia = dtFechaAlbaran.Day;
                this.cmbAnio.SelectedIndex = Anio;
                this.cmbMes.SelectedIndex = Mes - 1;
                this.cmbDia.SelectedIndex = Dia - 1;
                if ((bool)dsAlbaran.Tables[0].Rows[0]["Facturado"]){
                    this.chkFacturado.CheckState = CheckState.Checked;
                }
                else {
                    this.chkFacturado.CheckState = CheckState.Unchecked;
                }
            }
        }
        catch (Exception ex) {
            System.Windows.Forms.MessageBox.Show("Error al cargar Albaranes: " + ex.Message);
        }
        finally {
            dsClientes.Dispose();
            daClientes.Dispose();
            dsAlbaranes.Dispose();
            daAlbaranes.Dispose();
            dsClientes = null;
            daClientes = null;
            dsAlbaranes = null;
            daAlbaranes = null;
       }
    }
    
    public short ValidarCampos() {
        if ((this.dcDestino.Text == "") && (this.txtDestino.Text == "")) {
            return 1004;
        }
        else if ((this.dcClientes.Text == "")) {
            return 1005;
        }
        else if ((this.txtNumero.Text == "")) {
            return 1006;
        }
        try 
	    {
            long.Parse(this.txtNumero.Text);
	    }
	    catch (Exception)
	    {
            return 1007;
	    }
        return 0;
    }
    
    public void ActivarEdicion() {
        dgMateriales.Enabled = this.Activar;
        txtDestino.Enabled = this.Activar;
        dcClientes.Enabled = this.Activar;
        txtNumero.Enabled = this.Activar;
        cmbMes.Enabled = this.Activar;
        cmbDia.Enabled = this.Activar;
        cmbAnio.Enabled = this.Activar;
        chkFacturado.Enabled = this.Activar;
        if (Global.Modificacion_Albaran) {
            cmdBorrar.Visible = Activar;
            cmdAniadir.Visible = Activar;
        }
    }
    
    public void CompruebaError(short Error_Code)
    {
        if ((Error_Code == 1004))
        {
            MessageBox.Show("El destino no puede estar en blanco", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
        else if ((Error_Code == 1005))
        {
            MessageBox.Show("El cliente no puede estar en blanco", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
        else if ((Error_Code == 1006))
        {
            MessageBox.Show("El número de albarán no puede estar en blanco", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
        else if ((Error_Code == 1007))
        {
            MessageBox.Show("El número de albarán debe ser un número", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
    }
    
    public void AltaAlbaran() {
        SqlCommand cmdAltaAlbaran = new SqlCommand("ALTA_ALBARAN", Global.DBConnection);
        try {
            cmdAltaAlbaran.CommandType = CommandType.StoredProcedure;
            cmdAltaAlbaran.Parameters.Add("@FECHA_ALBARAN", SqlDbType.DateTime);
            cmdAltaAlbaran.Parameters["@FECHA_ALBARAN"].Value = this.Fecha;
            cmdAltaAlbaran.Parameters.Add("@DESTINO", SqlDbType.NVarChar);
            cmdAltaAlbaran.Parameters["@DESTINO"].Value = this.Destino;
            cmdAltaAlbaran.Parameters.Add("@CANTIDAD", SqlDbType.Float);
            cmdAltaAlbaran.Parameters["@CANTIDAD"].Value = this.Cantidad;
            cmdAltaAlbaran.Parameters.Add("@COD_MAT", SqlDbType.Int);
            cmdAltaAlbaran.Parameters["@COD_MAT"].Value = this.Cod_Mat;
            cmdAltaAlbaran.Parameters.Add("@NUMERO", SqlDbType.Int);
            cmdAltaAlbaran.Parameters["@NUMERO"].Value = this.Numero;
            cmdAltaAlbaran.Parameters.Add("@COD_CLI", SqlDbType.Int);
            cmdAltaAlbaran.Parameters["@COD_CLI"].Value = this.Cod_Cli;
            cmdAltaAlbaran.ExecuteNonQuery();
            MessageBox.Show("Alta realizada con éxito", "Facturas", MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }
        catch (Exception ex) {
            MessageBox.Show(("Error al crear albaran: " + ex.Message), "Facturas", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally {
            cmdAltaAlbaran.Dispose();
            cmdAltaAlbaran = null;
        }
    }
    
    public void BorrarLineaAlbaran(int NumAlbaran, string Descripcion)
    {
        SqlCommand cmdBajaAlbaranes = new SqlCommand("BORRAR_ALBARAN", Global.DBConnection);
        try
        {
            cmdBajaAlbaranes.CommandType = CommandType.StoredProcedure;
            cmdBajaAlbaranes.Parameters.Add("@Descripcion", SqlDbType.NVarChar);
            cmdBajaAlbaranes.Parameters["@Descripcion"].Value = Descripcion;
            cmdBajaAlbaranes.Parameters.Add("@NumAlbaran", SqlDbType.BigInt);
            cmdBajaAlbaranes.Parameters["@NumAlbaran"].Value = this.Numero;
            cmdBajaAlbaranes.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            MessageBox.Show(("Error: " + ex.Message), "Facturas", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        finally
        {
            cmdBajaAlbaranes.Dispose();
            cmdBajaAlbaranes = null;
        }
    }
        
    public void BajaAlbaran(long Numero) {
        SqlCommand cmdBajaAlbaran = new SqlCommand("BAJA_ALBARAN", Global.DBConnection);
        try {
            cmdBajaAlbaran.CommandType = CommandType.StoredProcedure;
            cmdBajaAlbaran.Parameters.AddWithValue("@NumAlbaran",this.Numero);
            cmdBajaAlbaran.ExecuteNonQuery();
            MessageBox.Show("Baja realizada con éxito","Facturas",MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
        catch (Exception ex) {
            MessageBox.Show("Error al eliminar albarán: " + ex.Message,"Facturas",MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
        finally {
            cmdBajaAlbaran.Dispose();
            cmdBajaAlbaran = null;
        }
    }

    public bool ExisteAlbaran(long Numero)
    {
        SqlCommand cmdAlbaran = new SqlCommand("CONSULTA_ALBARAN", Global.DBConnection);
        SqlDataAdapter daAlbaran = new SqlDataAdapter(cmdAlbaran);
        DataSet dsAlbaran = new DataSet();
        try
        {
            daAlbaran.SelectCommand.CommandType = CommandType.StoredProcedure;
            daAlbaran.SelectCommand.Parameters.AddWithValue("@NumAlbaran",Numero);
            daAlbaran.Fill(dsAlbaran, "Albaranes");
            if ((dsAlbaran.Tables["Albaranes"].Rows.Count < 1))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message, "Facturas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        finally
        {
            cmdAlbaran.Dispose();
            daAlbaran.Dispose();
            dsAlbaran.Dispose();
            cmdAlbaran = null;
            daAlbaran = null;
            dsAlbaran = null;
        }
    }

    public void AsignarAlbaran(Form_Cantidad frmCantidad, bool Nuevo) {
        string Fecha;
        if ((this.chkFacturado.CheckState == CheckState.Checked)) {
            this.Facturado = true;
        }
        else {
            this.Facturado = false;
        }
        
        Fecha = this.cmbAnio.Text;
        Fecha += "/";
        Fecha += this.cmbMes.Text;
        Fecha += "/";
        Fecha += this.cmbDia.Text;
        
        this.Fecha = DateTime.Parse(Fecha);

        if ((this.dcDestino.Text != "")) {
            this.Destino = this.dcDestino.Text;
        }
        else {
            this.Destino = this.txtDestino.Text;
        }

        this.Numero = int.Parse(this.txtNumero.Text);
        this.Cliente = this.dcClientes.Text;

        Global.Sentencia = ("SELECT COD_CLI FROM CLIENTES WHERE NOMBRE =\'" 
            + (this.Cliente + "\'"));
        try 
	    {	        
            Global.Conexion.Open(Global.strConn,Global.dbUser,Global.dbPass,0);
            Global.Recordset.Open(Global.Sentencia, Global.Conexion, ADODB.CursorTypeEnum.adOpenStatic,
                ADODB.LockTypeEnum.adLockPessimistic, (int)ADODB.CommandTypeEnum.adCmdText);
                this.Cod_Cli =  int.Parse(Global.Recordset.Fields["Cod_Cli"].Value.ToString());
            Global.Recordset.Close();
            Global.Conexion.Close();		
	    }
	    catch (Exception ex)
	    {
            MessageBox.Show(this,"Error \r\n"+ex.Message,"Facturas",MessageBoxButtons.OK,MessageBoxIcon.Error);    		
		    throw;
	    }

        if (Nuevo) {
            this.Descripcion = frmCantidad.dcMateriales.Text;
            this.Cantidad = float.Parse(frmCantidad.Text_Cantidad.Text.Replace(Global.Punto,Global.Coma));
            
            Global.Sentencia = ("SELECT COD_MAT FROM MATERIALES WHERE DESCRIPCION=\'" 
                        + (this.Descripcion + "\'"));
            try
            {
                Global.Conexion.Open(Global.strConn,Global.dbUser,Global.dbPass,0);
                Global.Recordset.Open(Global.Sentencia, Global.Conexion, ADODB.CursorTypeEnum.adOpenStatic,
                    ADODB.LockTypeEnum.adLockPessimistic, (int)ADODB.CommandTypeEnum.adCmdText);
                this.Cod_Mat = int.Parse(Global.Recordset.Fields["Cod_Mat"].Value.ToString());
                Global.Recordset.Close();
                Global.Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error"+ex.Message,"Facturas",MessageBoxButtons.OK,MessageBoxIcon.Error);
                throw;
            }
        }
    }


    public void ModificacionAlbaran(ref Tipos.tAlbaran RegAlbaran)
    {
        byte Aux;
        if ((this.Facturado == true))
        {
            Aux = 1;
        }
        else
        {
            Aux = 0;
        }
        Global.Sentencia = ("UPDATE Albaranes SET FECHA_ALBARAN = \'"
                    + (this.Fecha + ("\'," + ("FACTURADO = "
                    + (Aux + ("," + ("COD_CLI="
                    + (this.Cod_Cli + (",DESTINO=\'"
                    + (this.Destino + ("\',NUMERO="
                    + (this.Numero + (" WHERE NUMERO =" + this.Numero)))))))))))));
        try
        {
            object num = null;
            Global.Conexion.Open(Global.strConn, Global.dbUser, Global.dbPass, 0);
            Global.Conexion.Execute(Global.Sentencia,out num,0);
            Global.Conexion.Close();
            MessageBox.Show("Modificación realizada con éxito", "Facturas", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error " + ex.Message);
            throw;
        }
    }

        
    public DataSet ConsultaAlbaran(long Numero)
    {
        SqlDataAdapter daAlbaranes = new SqlDataAdapter();
        DataSet dsAlbaranes = new DataSet();
        try
        {
            daAlbaranes.SelectCommand = new SqlCommand("CONSULTA_ALBARAN", Global.DBConnection);
            daAlbaranes.SelectCommand.CommandType = CommandType.StoredProcedure;
            daAlbaranes.SelectCommand.Parameters.Add("@NumAlbaran", SqlDbType.BigInt);
            daAlbaranes.SelectCommand.Parameters["@NumAlbaran"].Value = Numero;
            daAlbaranes.SelectCommand.ExecuteNonQuery();
            daAlbaranes.Fill(dsAlbaranes, "Albaranes");
            daAlbaranes.Dispose();
            daAlbaranes = null;
            return dsAlbaranes;
        }
        catch (Exception ex)
        {
            MessageBox.Show( "Error: " + ex.Message, "Facturas", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            daAlbaranes.Dispose();
            daAlbaranes = null;
            return null;
        }
    }

    private void cmbAnio_SelectedIndexChanged(object sender, EventArgs e)
    {
        PresentaFecha();
    }

    private void cmbMes_SelectedIndexChanged(object sender, EventArgs e)
    {
        PresentaFecha();
    }

}