using Facturas_CSharp;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
partial class Form_Prompt_Materiales : System.Windows.Forms.Form {
    private Form_Materiales frmMaterial = new Form_Materiales();
    private bool Preguntar = false;
    private string Material;    
    public Form_Prompt_Materiales() {
        InitializeComponent();
        CargarMateriales();
    }
    
    private void Aceptar_Click(object eventSender, System.EventArgs eventArgs) {
        string Descripcion;
        try {
            Preguntar = true;
            if ((dcMateriales.Text != "")) {
                Descripcion = dcMateriales.Text;
                Form_Materiales frmMaterial = new Form_Materiales(Descripcion);
                frmMaterial.Show();
                this.Close();
            }
            else {
                MessageBox.Show("Debe escoger un material", "Error",System.Windows.Forms.MessageBoxButtons.OK);
                this.dcMateriales.Focus();
            }
        }
        catch (System.Exception ex) {
            MessageBox.Show("Error al cargar Material: " + ex.Message);
        }
    }
    
    private void Cancelar_Click(object eventSender, System.EventArgs eventArgs) {
        if (!Global.Consulta_Material)
        {
            Preguntar = true;            
        }
        else
        {
            Global.Consulta_Material = false;
        }

        this.Close();
    }
    
    private void Form_Prompt_Materiales_Closing(object eventSender, System.ComponentModel.CancelEventArgs eventArgs) {
        DialogResult OK;
        if (Preguntar) {
            OK = MessageBox.Show("¿Desea cancelar el proceso?", "Facturas"); 
            if ((OK == DialogResult.Yes)) {
                if (Global.Alta_Material)
                {
                    Global.Alta_Material = false;
                }
                if (Global.Baja_Material)
                {
                    Global.Baja_Material = false;
                }
                if (Global.Modificacion_Material)
                {
                    Global.Modificacion_Material = false;
                }
                this.Dispose();
            }
            else {
                eventArgs.Cancel = true;
            }
        }
    }
    
    private void CargarMateriales() {
        DataSet dsMateriales = new DataSet();
        SqlDataAdapter daMateriales = new SqlDataAdapter();
        try
        {
            daMateriales.SelectCommand = new SqlCommand("CONSULTA_MATERIALES", Global.DBConnection);
            daMateriales.SelectCommand.CommandType = CommandType.StoredProcedure;
            daMateriales.Fill(dsMateriales, "MATERIALES");
            this.dcMateriales.DataSource = dsMateriales.Tables[0];
            this.dcMateriales.DisplayMember = "DESCRIPCION";
        }
        catch (System.Exception ex)
        {
            MessageBox.Show("Error al cargar materiales: " + ex.Message);
        }
        finally
        {
            daMateriales.Dispose();
            dsMateriales.Dispose();
            daMateriales = null;
            dsMateriales = null;
        }

    }

    private void dcMateriales_SelectedIndexChanged(object sender, System.EventArgs e)
    {
        this.Material = dcMateriales.Text;
    }
}