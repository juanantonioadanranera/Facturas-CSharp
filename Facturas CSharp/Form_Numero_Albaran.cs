using Facturas_CSharp;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Windows.Forms;
partial class Form_Numero_Albaran : System.Windows.Forms.Form {

    private bool Preguntar = false;

    private DataSet dsAlbaranes;

    private SqlDataAdapter daAlbaranes;

    public Form_Numero_Albaran() {

        InitializeComponent();

        try
        {
            this.dcAlbaranes.DropDownStyle = ComboBoxStyle.DropDown;
            this.dcAlbaranes.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.dcAlbaranes.AutoCompleteMode = AutoCompleteMode.Append;
           
            dsAlbaranes = new DataSet();
            daAlbaranes = new SqlDataAdapter();
            daAlbaranes.SelectCommand = new SqlCommand("CONSULTA_ALBARANES", Global.DBConnection);
            daAlbaranes.SelectCommand.CommandType = CommandType.StoredProcedure;
            daAlbaranes.Fill(dsAlbaranes, "Albaranes_Numero");
            this.dcAlbaranes.DataSource = dsAlbaranes.Tables[0];
            this.dcAlbaranes.Refresh();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al cargar Albaranes: " + ex.Message);
        }
        finally
        {
            dsAlbaranes = null;
            daAlbaranes = null;
        }
    }

    private void Aceptar_Click(object eventSender, System.EventArgs eventArgs) {
        Form_Albaranes frmAlbaran = new Form_Albaranes();

        if ((this.dcAlbaranes.Text == ""))
        {
            MessageBox.Show("El número no puede estar en blanco", "Error");
        }
        else
        {
            long NumAlbaran = long.Parse(this.dcAlbaranes.Text);
            if (!frmAlbaran.ExisteAlbaran(NumAlbaran))
            {
                MessageBox.Show("Este albarán no existe", "Error");
            }
            else
            {
                try
                {
                    frmAlbaran.Dispose();
                    frmAlbaran = null;
                    frmAlbaran = new Form_Albaranes(NumAlbaran);
                    frmAlbaran.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error");
                }
            }
        }
    }
    
    private void Cancelar_Click(object eventSender, System.EventArgs eventArgs) {
        Preguntar = true;
        this.Close();
    }
    
    private void Form_Numero_Albaran_Closing(object eventSender, System.ComponentModel.CancelEventArgs eventArgs) {
        DialogResult OK;
        if (Preguntar) {
            OK = MessageBox.Show("¿Desea cancelar el proceso?", "Facturas"); 
            if ((OK == DialogResult.Yes)) {
                eventArgs.Cancel = true;
            }
            else {
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
            }
        }
    }
}