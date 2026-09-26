using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Facturas_CSharp;
using System;
partial class Form_Prompt_Numero : System.Windows.Forms.Form {
    
    public Form_Prompt_Numero() {
        InitializeComponent();
    }
    
    private bool Preguntar = false;
    private long NumFactura = 0;    
    private void Aceptar_Click(object eventSender, System.EventArgs eventArgs) {
        short Error_Code;
        DialogResult OK;
        if (Global.EsFacturaVentas)
        {
            if ((Text_Numero.Text != ""))
            {
                Error_Code = ValidarNumeroFacturaVentas(this.Text_Numero.Text);
                OK = CompruebaErrorFacturaVentas(Error_Code);
                if ((OK != DialogResult.OK))
                {
                    if ((OK == DialogResult.Yes))
                    {
                        Global.EsModificacionVentas = true;
                    }
                    else
                    {
                        if ((OK == DialogResult.No))
                        {
                            return;
                        }
                    }

                    Global.RegFacturaVentas.Numero = long.Parse(this.Text_Numero.Text);
                    this.Text_Numero.Text = "";
                    Form_Tipo_Iva frmTipoIva = new Form_Tipo_Iva();
                    frmTipoIva.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("El número no puede ser nulo", "Error");
                this.Text_Numero.Focus();
            }
        }
        else
        {
            if (Global.EsFacturaCompras)
            {
                if (this.Text_Numero.Text != "") {
                    Global.RegFacturaCompras.Numero = this.Text_Numero.Text;
                    Form_Prompt_Proveedores frmPromptProveedores = new Form_Prompt_Proveedores();
                    frmPromptProveedores.Show();
                    this.Close();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("El número no puede ser nulo", "Error");
                    this.Text_Numero.Focus();
                }
            }
            else if (Global.EsConsultaVentas)
            {
                Error_Code = ValidarNumeroFacturaVentas(this.dcFacturasVentas.Text);
                OK = CompruebaErrorFacturaVentas(Error_Code);
                if ((OK != DialogResult.OK))
                {
                    //ConsultaFacturaVentas(long.Parse(this.dcFacturasVentas.Text));
                    Form_Factura frmFactura = new Form_Factura(this.NumFactura);
                    frmFactura.Show();
                    Global.EsConsultaVentas = false;
                    this.Close();
                }
            }
            else if (Global.Modificacion_Factura)
            {
                Form_Facturas Factura = new Form_Facturas(long.Parse(this.dcFacturasVentas.Text.ToString()));
                //Factura.setNumFactura();
                Factura.Show();
                Global.Modificacion_Factura = false;
                this.Close();
                this.Dispose();
            }
        }
    }
    
    void Cancelar_Click(object eventSender, System.EventArgs eventArgs) {
        Preguntar = true;
        this.Close();
    }
    
    private void Form_Prompt_Numero_Load(object eventSender, System.EventArgs eventArgs) {
        SqlDataAdapter daFacturasVentas = new SqlDataAdapter();
        DataSet dsFacturasVentas = new DataSet();

        try {
            this.dcFacturasVentas.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.dcFacturasVentas.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.dcFacturasVentas.DropDownStyle = ComboBoxStyle.DropDownList;
            
            daFacturasVentas.SelectCommand = new SqlCommand("CONSULTA_FACTURAS_VENTAS", Global.DBConnection);
            daFacturasVentas.SelectCommand.CommandType = CommandType.StoredProcedure;
            daFacturasVentas.SelectCommand.ExecuteNonQuery();
            daFacturasVentas.Fill(dsFacturasVentas, "FacturasVentas");
            this.dcFacturasVentas.DataSource = dsFacturasVentas.Tables["FacturasVentas"];
            this.dcFacturasVentas.DisplayMember = "NUM_FACTURA";
            
            if (Global.EsFacturaVentas) {
                this.Text_Numero.Visible = true;
                this.dcFacturasVentas.Visible = false;
                dcFacturasVentas.SelectedIndex = (dcFacturasVentas.Items.Count - 1);
                Text_Numero.Text = ((long.Parse(dcFacturasVentas.Text) + 1)).ToString();
            }
            else if (Global.EsConsultaVentas) {
                this.dcFacturasVentas.Visible = true;
                this.Text_Numero.Visible = false;
                dcFacturasVentas.SelectedIndex = (dcFacturasVentas.Items.Count - 1);
            }
            else {
                this.Text_Numero.Visible = true;
                this.dcFacturasVentas.Visible = false;
                dcFacturasVentas.SelectedIndex = (dcFacturasVentas.Items.Count - 1);
                Text_Numero.Text = "0001";
            }
        }
        catch (Exception ex) {
            MessageBox.Show("Error al cargar Facturas: " + ex.Message);
        }
        finally {
            daFacturasVentas.Dispose();
            dsFacturasVentas.Dispose();
        }
    }
    
    private void Form_Prompt_Numero_Closing(object eventSender, System.ComponentModel.CancelEventArgs eventArgs) {
        DialogResult OK;
        if (Preguntar) {
            OK = MessageBox.Show("¿Desea cancelar el proceso?", "Facturas",MessageBoxButtons.YesNo,MessageBoxIcon.Question); 
            if ((OK == DialogResult.Yes )) {
                if (Global.EsFacturaVentas) {
                    Global.EsFacturaVentas = false;
                }
                if (Global.EsModificacionVentas)
                {
                    Global.EsModificacionVentas = false;
                }
                if (Global.EsFacturaCompras) {
                    Global.EsFacturaCompras = false;
                }
                if (Global.EsModificacionCompras)
                {
                    Global.EsModificacionCompras = false;
                }
            }
            else {
                eventArgs.Cancel = true;
            }
        }
    }
    public static short ValidarNumeroFacturaVentas(string Numero)
    {
        double tmp = 0.0;
        try
        {
            tmp = double.Parse(Numero);
        }
        catch (System.Exception)
        {
            return 1021;            
        }
        if (tmp == 0)
        {
            return 1020;
        }
        else
        {
            Global.Sentencia = ("SELECT * FROM FacturasVentas WHERE " + ("NUM_FACTURA = "
                        + (long.Parse(Numero) + ";")));
            Global.Conexion.Open(Global.strConn,Global.dbUser,Global.dbPass,0);
            Global.Recordset.Open(Global.Sentencia, Global.Conexion, ADODB.CursorTypeEnum.adOpenStatic, 
                ADODB.LockTypeEnum.adLockOptimistic, (int)ADODB.CommandTypeEnum.adCmdText);
            if ((Global.Recordset.RecordCount > 0) && Global.EsFacturaVentas)
            {
                Global.Recordset.Close();
                Global.Conexion.Close();
                return 1022;
            }
            else
            {
                if ((Global.Recordset.RecordCount < 1) && Global.EsConsultaVentas)
                {
                    Global.Recordset.Close();
                    Global.Conexion.Close();
                    return 1023;
                }
                else
                {
                    Global.Recordset.Close();
                    Global.Conexion.Close();
                    return 0;
                }
            }
        }
    }

    private DialogResult CompruebaErrorFacturaVentas(short Error_Code)
    {
        if ((Error_Code == 1020))
        {
            return MessageBox.Show("El número de Factura no puede ser cero", "Error");
        }
        else if ((Error_Code == 1021))
        {
            return MessageBox.Show("El número de Factura debe ser numérico", "Error");
        }
        else if ((Error_Code == 1022))
        {
            return MessageBox.Show("Ya existe una Factura con ese número" +
                "\r\n" + "¿Desea actualizarla?", "Factura Existente",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        }
        else if ((Error_Code == 1023))
        {
            return MessageBox.Show("No existe en la base de datos una factura con ese número", "Error");
        }
        else
        {
            return DialogResult.Abort;
        }
    }

    private void dcFacturasVentas_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (dcFacturasVentas.SelectedIndex != 0)
            this.NumFactura = long.Parse(this.dcFacturasVentas.Text);
    }
}