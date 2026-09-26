using Facturas_CSharp;
using System.Windows.Forms;
using System;
partial class Form_Prompt_Fecha : System.Windows.Forms.Form {
    private bool Preguntar = false;

    public Form_Prompt_Fecha(string Text) {
        InitializeComponent();
        this.Text = Text;
        // Llamada a método para colocar la fecha de hoy
        PresentaFecha();
    }
    
    private void Aceptar_Click(object eventSender, System.EventArgs eventArgs) {
        string FechaFactura;

        FechaFactura = cDia.Text;
        FechaFactura = (FechaFactura + "/");
        FechaFactura = (FechaFactura + cMes.Text);
        FechaFactura = (FechaFactura + "/");
        FechaFactura = (FechaFactura + cAnio.Text);

        if (Global.EsFacturaVentas) {
            Global.RegFacturaVentas.Fecha = DateTime.Parse(FechaFactura);
            Global.RegDetalle.Fecha = DateTime.Parse(FechaFactura);
        }
        else if (Global.EsFacturaCompras) {
            Global.RegFacturaCompras.Fecha = DateTime.Parse(FechaFactura);
        }
        Form_Prompt_Numero frmNumFactura = new Form_Prompt_Numero();

        frmNumFactura.Show();
        this.Close();
    }
    
    private void Cancelar_Click(object eventSender, System.EventArgs eventArgs) {
        Preguntar = true;
        this.Close();
    }
    
    private void PresentaFecha() {
        // Rellena la lista de los dias de la fecha con valores adecuados
        short LimDias, i;
        bool EsBisiesto = false;

        for (i = 1999; (i <= 2099); i++)
        {
            cAnio.Items.Add(i.ToString());
        }
        for (i = 1; (i <= 12); i++)
        {
            cMes.Items.Add(i.ToString().PadLeft(2, '0'));
        }

        DateTime Hoy = DateTime.Now;

        //Pone el día de la fecha de hoy
        if (cAnio.Text == "")
        {
            this.cAnio.SelectedIndex = Hoy.Year - 1999;
            this.cMes.SelectedIndex = Hoy.Month - 1;
        }
        
        if (((((short.Parse(cAnio.Text) % 4) 
                    == 0) 
                    && ((short.Parse(cAnio.Text) % 100) 
                    != 0)) 
                    || ((short.Parse(cAnio.Text) % 400) 
                    == 0))) {
            EsBisiesto = true;
        }
        switch (cMes.Text) {
            case "11":
            case "04":
            case "06":
            case "09":
                LimDias = 30;
                break;
            case "02":
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
        cDia.Items.Clear();
        
        for (i = 1; (i <= LimDias); i++) {
            cDia.Items.Add(i.ToString().PadLeft(2,'0'));
        }

        //
        // Esto es para poner el último día del mes si el día de hoy es mayor que 
        // el último día del mes que se ha seleccionado
        //
        if ((Hoy.Day - 1) 
                    < this.cDia.Items.Count) {
            this.cDia.SelectedIndex = (Hoy.Day - 1);
        }
        else {
            this.cDia.SelectedIndex = (this.cDia.Items.Count - 1);
        }
    }
    
    private void Form_Prompt_Fecha_Closing(object eventSender, System.ComponentModel.CancelEventArgs eventArgs) {
        DialogResult OK;
        if (Preguntar) {
            if (Global.EsFacturaVentas)
            {
                OK = MessageBox.Show("¿Desea cancelar la facturación?", "Facturas",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);    
            }
            else
            {
                OK = MessageBox.Show("¿Desea cancelar el apunte?", "Facturas",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);                        
            }
            if ((OK == DialogResult.Yes)) {
                if (Global.EsFacturaVentas) {
                    Global.EsFacturaVentas = false;
                }
                if (Global.EsModificacionVentas) {
                    Global.EsModificacionVentas = false;
                }
                if (Global.EsFacturaCompras) {
                    Global.EsFacturaCompras = false;
                }
                if (Global.EsModificacionCompras) {
                    Global.EsModificacionCompras = false;
                }
            }
            else
            {
                eventArgs.Cancel = true;
            }
        }
    }

    private void cAnio_SelectedIndexChanged(object sender, System.EventArgs e)
    {
        PresentaFecha();
    }

    private void cMes_SelectedIndexChanged(object sender, System.EventArgs e)
    {
        PresentaFecha();
    }

}