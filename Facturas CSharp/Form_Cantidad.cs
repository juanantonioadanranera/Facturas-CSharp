using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Facturas_CSharp;
public partial class Form_Cantidad : System.Windows.Forms.Form {

    public Form_Cantidad()
    {
        InitializeComponent();
    }
    
    private DataSet dsMateriales;
    
    private SqlDataAdapter daMateriales;
    
    private bool Preguntar = false;
    
    private void Aceptar_Click(object eventSender, System.EventArgs eventArgs) {
        DialogResult OK;
        short Error_Code;
        this.Text_Cantidad.Focus();
        Error_Code = ComprobarCampos();
        if ((Error_Code == 0)) {
            ((Form_Albaranes)this.Owner).AsignarAlbaran(this, true);
            ((Form_Albaranes)this.Owner).AltaAlbaran();
            DataSet dsAlbaranes = ((Form_Albaranes)this.Owner).ConsultaAlbaran(((Form_Albaranes)(this.Owner)).Numero);
            ((Form_Albaranes)(this.Owner)).AsignarCampos(dsAlbaranes);
            ((Form_Albaranes)this.Owner).Refresh();
            OK = MessageBox.Show("¿Desea añadir algún artículo más?", "Facturas", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);
            if ((OK != System.Windows.Forms.DialogResult.Yes )) {
                Preguntar = false;
                if (!Global.Alta_Albaran)
                {
                    ((Form_Albaranes)this.Owner).Focus();
                }
                else {
                    ((Form_Albaranes)this.Owner).Close();
                }
                this.Close();
            }
            else {
                this.Text_Cantidad.Text = "";
                this.dcMateriales.SelectedIndex = 0;
                this.Text_Cantidad.Focus();
            }
        }
        else {
            MostrarErrorAlbaran(Error_Code);
        }
    }
    
    private void Cancelar_Click(object eventSender, System.EventArgs eventArgs)
    {
        Preguntar = true;
        this.Close();
    }
    
    private void Form_Cantidad_Closing(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
    {
        DialogResult OK;
        if (Preguntar) {
            OK = MessageBox.Show("¿Desea cancelar el proceso?", "Facturas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if ((OK != System.Windows.Forms.DialogResult.Yes )) {
                eventArgs.Cancel = true;
            }
        }
    }
    
    private void Form_Cantidad_Load(object sender, System.EventArgs e)
    {
        try {
            dsMateriales = new DataSet();
            daMateriales = new SqlDataAdapter();
            daMateriales.SelectCommand = new SqlCommand("CONSULTA_MATERIALES", Global.DBConnection);
            daMateriales.SelectCommand.CommandType = CommandType.StoredProcedure;
            daMateriales.Fill(dsMateriales, "Materiales");
            this.dcMateriales.DataSource = dsMateriales.Tables[0];
        }
        catch (System.Exception ex) {
            System.Windows.Forms.MessageBox.Show("Error al cargar Materiales: " + ex.Message);
        }
        finally {
            daMateriales.Dispose();
            dsMateriales.Dispose();
            daMateriales = null;
            dsMateriales = null;
        }
    }

    
    void Form_Cantidad_Shown(object sender, System.EventArgs e) {
        this.Text_Cantidad.Focus();
    }
    
    private void Form_Cantidad_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e) {
        if (Global.Alta_Albaran) {
            //frmMain.Focus();
        }
    }
    
    short ComprobarCampos() {
        if ((this.Text_Cantidad.Text == "")) {
            return 1030;
        }
        else if ((this.dcMateriales.Text == "")) {
            return 1033;
        }
        else {
            try
            {
                double.Parse(this.Text_Cantidad.Text);
            }
            catch (System.Exception)
            {
                return 1031;
            }
            if ((double.Parse(this.Text_Cantidad.Text) == 0))
            {
                return 1032;
            }
        }
        return 0;
    }
    
    public void MostrarErrorAlbaran(short Error_Code) {
        if ((Error_Code == 1030)) {
            System.Windows.Forms.MessageBox.Show("La cantidad no puede ser nula","Error",
                System.Windows.Forms.MessageBoxButtons.OK );
        }
        else if ((Error_Code == 1031)) {
            System.Windows.Forms.MessageBox.Show("La cantidad debe ser numérica","Error",
                System.Windows.Forms.MessageBoxButtons.OK );
        }
        else if ((Error_Code == 1032)) {
            System.Windows.Forms.MessageBox.Show("La cantidad no puede ser cero","Error",
                System.Windows.Forms.MessageBoxButtons.OK );
        }
        else if ((Error_Code == 1033)) {
            System.Windows.Forms.MessageBox.Show("Debe seleccionar un artículo","Error",
                System.Windows.Forms.MessageBoxButtons.OK );
        }
    }
}