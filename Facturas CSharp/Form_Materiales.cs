using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Facturas_CSharp;
using System;
partial class Form_Materiales : System.Windows.Forms.Form {
    private long codigo;
    private string descripcion;
    private float precio;
    private bool activar = false;

    public long Cod_Mat
    {
        get { return codigo; }
        set { codigo = value; }
    }
    public string Descripcion
    {
        get { return descripcion; }
        set { descripcion = value; }
    }
    public float Precio_Venta 
    {
        get { return precio; }
        set { precio = value; }
    }
    public bool Activar
    {
        get { return activar; }
        set { activar = value; }
    }
    
    public Form_Materiales() {
        InitializeComponent();
    }

    public Form_Materiales(string Descripcion)
    {
        {
            if (!Global.Consulta_Material)
            {
                this.Activar = true;
            }
            InitializeComponent();
            ConsultaMaterial(Descripcion);
            ActivarEdicion();
        }
    }
    
    private bool Preguntar = true;
    
    private void Aceptar_Click(object eventSender, System.EventArgs eventArgs) {
        short Error_Code;
        if (Global.Alta_Material) {
            Error_Code = ValidarCampos();
            if ((Error_Code == 0)) {
                AsignarCampos();
                AltaMaterial();
                Global.Alta_Material = false;
                this.Close();
                this.Dispose();
            }
            else {
                LibreriaMateriales.CompruebaError(ref Error_Code);
            }
        }
        else if (Global.Baja_Material) {
            AsignarCampos();
            BajaMaterial();
            Global.Baja_Material = false;
            this.Close();
            this.Dispose();
        }
        else if (Global.Modificacion_Material) {
            Error_Code = ValidarCampos();
            if ((Error_Code == 0)) {
                AsignarCampos();
                ModificacionMaterial();
                Global.Modificacion_Material = false;
                this.Close();
                this.Dispose();
            }
            else {
                LibreriaMateriales.CompruebaError(ref Error_Code);
            }
        }
        else if (Global.Consulta_Material) {
            Global.Consulta_Material = false;
            this.Close();
            this.Dispose();
        }
    }
    
    private void Cancelar_Click(object eventSender, System.EventArgs eventArgs) {
        Preguntar=true;
        this.Close();
    }
    
    private void Form_Materiales_Closing(object eventSender, System.ComponentModel.CancelEventArgs eventArgs) {
        DialogResult OK;
        if (Preguntar) {
            OK = System.Windows.Forms.MessageBox.Show("¿Desea cancelar el proceso?","Facturas",
                System.Windows.Forms.MessageBoxButtons.YesNo );
            if ((OK ==  System.Windows.Forms.DialogResult.Yes )) {
                if (Global.Alta_Material) {
                    Global.Alta_Material = false;
                }
                if (Global.Baja_Material) {
                    Global.Baja_Material = false;
                }
                if (Global.Modificacion_Material) {
                    Global.Modificacion_Material = false;
                }
                this.Dispose();
            }
            else {
                eventArgs.Cancel = true;
            }
        }
    }
    
    public void ActivarEdicion() {
        this.Text_Descripcion.Enabled = this.Activar;
        this.Text_Precio.Enabled = this.Activar;
    }
    
    public void Asignar() {
        this.Cod_Mat = long.Parse(this.Text_Codigo.Text);
        this.Descripcion = this.Text_Descripcion.Text;
        this.Precio_Venta = float.Parse (this.Text_Precio.Text);
    }
    
    public short ValidarCampos() {
        if ((this.Text_Descripcion.Text == "")) {
            return 1001;
        }
        else if ((this.Text_Precio.Text == "")) {
            return 1002;
        }
        try 
	    {
            double.Parse(this.Text_Precio.Text);
        }
	    catch (System.Exception)
	    {
		    return 1003;
	    }
        return 0;
    }
    
    public void AsignarCampos() {
        this.Cod_Mat = long.Parse(this.Text_Codigo.Text);
        this.Descripcion = this.Text_Descripcion.Text;
        this.Precio_Venta = float.Parse(this.Text_Precio.Text.Replace(Global.Punto,Global.Coma));
    }
    
    public void LimpiarCamposMaterial() {
        this.Text_Descripcion.Text = "";
        this.Text_Precio.Text = "";
    }
    
    private void Form_Materiales_Load(object sender, System.EventArgs e) {
        if (Global.Alta_Material) {
            SqlDataAdapter daMateriales = new SqlDataAdapter();
            DataSet dsMateriales = new DataSet();
            daMateriales.SelectCommand = new SqlCommand ("SELECT MAX(COD_MAT) FROM MATERIALES;", 
                Global.DBConnection);
            daMateriales.SelectCommand.CommandType = CommandType.Text;
            daMateriales.Fill(dsMateriales, "MATERIALES");

            try {
                if ((dsMateriales.Tables[0].Rows.Count == 0)) {
                    this.Text_Codigo.Text = "1";
                }
                else {
                    this.Text_Codigo.Text = (1 + (long)dsMateriales.Tables[0].Rows[0][0]).ToString();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(("Error: " + ex.Message), "Facturas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                daMateriales.Dispose();
                dsMateriales.Dispose();
                daMateriales = null;
                dsMateriales = null;
            }
        }
        else {
            this.Text_Codigo.Text = this.Cod_Mat.ToString();
            this.Text_Descripcion.Text = this.Descripcion;
            this.Text_Precio.Text = this.Precio_Venta.ToString();
            this.ActivarEdicion();
        }
    }

    public void ConsultaMaterial(string Descripcion)
    {
        SqlDataAdapter daMateriales = new SqlDataAdapter();
        DataSet dsMateriales = new DataSet();
        try
        {
            daMateriales.SelectCommand = new SqlCommand("CONSULTA_MATERIAL",Global.DBConnection);
            daMateriales.SelectCommand.CommandType = CommandType.StoredProcedure;
            daMateriales.SelectCommand.Parameters.Add("@Descripcion", SqlDbType.VarChar);
            daMateriales.SelectCommand.Parameters["@Descripcion"].Value = Descripcion;
            daMateriales.SelectCommand.ExecuteNonQuery();
            daMateriales.Fill(dsMateriales, "MATERIAL");

            this.Cod_Mat = long.Parse(dsMateriales.Tables[0].Rows[0]["COD_MAT"].ToString());
            this.Descripcion = dsMateriales.Tables[0].Rows[0]["DESCRIPCION"].ToString();
            this.Precio_Venta = float.Parse(dsMateriales.Tables[0].Rows[0]["PRECIO_VENTA"].ToString());
        }
        catch (Exception ex)
        {
            MessageBox.Show(("Error: " + ex.Message), "Facturas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            daMateriales.Dispose();
            dsMateriales.Dispose();
            daMateriales = null;
            dsMateriales = null;
        }
    }
    public void AltaMaterial()
    {
        SqlCommand cmdInsMateriales = new SqlCommand("ALTA_MATERIAL", Global.DBConnection);
        try
        {
            cmdInsMateriales.Parameters.Add("@PrecioVenta", SqlDbType.Decimal);
            cmdInsMateriales.Parameters["@PrecioVenta"].Value = this.Precio_Venta;
            cmdInsMateriales.Parameters.Add("@Descripcion", SqlDbType.NVarChar);
            cmdInsMateriales.Parameters["@Descripcion"].Value = this.Descripcion;
            cmdInsMateriales.Parameters.Add("@CodMat", SqlDbType.Int);
            cmdInsMateriales.Parameters["@CodMat"].Value = this.Cod_Mat;
            cmdInsMateriales.ExecuteNonQuery();
            MessageBox.Show("Alta realizada con éxito", "Facturas",MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        catch (System.Exception ex)
        {
            MessageBox.Show("Error al insertar Material: " + ex.Message, "Facturas", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        finally
        {
            cmdInsMateriales.Dispose();
            cmdInsMateriales = null;
        }
    }

    public void BajaMaterial()
    {
        SqlCommand cmdDelMateriales = new SqlCommand("BAJA_MATERIAL", Global.DBConnection);
        try
        {
            cmdDelMateriales.Parameters.Add("@CodMat", SqlDbType.BigInt);
            cmdDelMateriales.Parameters["@CodMat"].Value = this.Cod_Mat;
            cmdDelMateriales.ExecuteNonQuery();
            MessageBox.Show("Baja realizada con éxito", "Facturas", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        catch (System.Exception ex)
        {
            MessageBox.Show("Error al eliminar Material: " + ex.Message, "Facturas", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        finally
        {
            cmdDelMateriales.Dispose();
            cmdDelMateriales = null;
        }
    }

    public void ModificacionMaterial()
    {
        SqlCommand cmdUpdMateriales = new SqlCommand("MODIFICACION_MATERIAL", Global.DBConnection);
        try
        {
            cmdUpdMateriales.CommandType = CommandType.StoredProcedure;
            cmdUpdMateriales.Parameters.Add("@PrecioVenta", SqlDbType.Float);
            cmdUpdMateriales.Parameters["@PrecioVenta"].Value = this.Precio_Venta;
            cmdUpdMateriales.Parameters.Add("@Descripcion", SqlDbType.NVarChar);
            cmdUpdMateriales.Parameters["@Descripcion"].Value = this.Descripcion;
            cmdUpdMateriales.Parameters.Add("@CodMat", SqlDbType.BigInt);
            cmdUpdMateriales.Parameters["@CodMat"].Value = this.Cod_Mat;
            cmdUpdMateriales.ExecuteNonQuery();
            MessageBox.Show("Modificación realizada con éxito", "Facturas", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        catch (System.Exception ex)
        {
            MessageBox.Show("Error al modificar Material: " + ex.Message, "Facturas", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        finally
        {
            cmdUpdMateriales.Dispose();
            cmdUpdMateriales = null;
        }
    }

}