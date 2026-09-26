using System.Data.SqlClient;
using System.Data;
using System;
using Facturas_CSharp;
using System.Windows.Forms;
using System.Collections.Generic;
partial class Form_Intervalo : System.Windows.Forms.Form {
    private bool Preguntar = false;
    private SqlCommand cmdNumVentas;
    private SqlCommand cmdNumCompras;
    private SqlCommand cmdNumAlbaranes;

    private List<ComboBox> cAnio = new List<ComboBox>();
    private List<ComboBox> cDia = new List<ComboBox>();
    private List<ComboBox> cMes = new List<ComboBox>();

    public Form_Intervalo() {
        // El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent();

        //
        //Agregamos los controles combo a la colección
        //
        this.cDia.Insert(0, this._cDia_0);
        this.cDia.Insert(1, this._cDia_1);
        this.cMes.Insert(0, this._cMes_0);
        this.cMes.Insert(1, this._cMes_1);
        this.cAnio.Insert(0, this._cAnio_0);
        this.cAnio.Insert(1, this._cAnio_1);
    }

    
    private void Aceptar_Click(object eventSender, System.EventArgs eventArgs) {
        try {
            string FechaInicio = cDia[0].Text + "-" + cMes[0].Text + "-" + cAnio[0].Text;
            string FechaFin = cDia[1].Text + "-" + cMes[1].Text + "-" + cAnio[1].Text;

            System.DateTime dtFechaInicio = DateTime.Parse(FechaInicio);
            System.DateTime dtFechaFin = DateTime.Parse(FechaFin);

            if (Global.EsListadoVentas) {
                cmdNumVentas = 
                    new SqlCommand("SELECT [Facturas].[dbo].[NumVentasPorFecha](@FechaInicio,@FechaFin)", 
                    Global.DBConnection);
                cmdNumVentas.CommandType = CommandType.Text;
                cmdNumVentas.Parameters.Add(new SqlParameter("@FechaInicio", SqlDbType.DateTime));
                cmdNumVentas.Parameters["@FechaInicio"].Value = dtFechaInicio;
                cmdNumVentas.Parameters.Add(new SqlParameter("@FechaFin", SqlDbType.DateTime));
                cmdNumVentas.Parameters["@FechaFin"].Value = dtFechaFin;
                long NumFacturas = long.Parse(this.cmdNumVentas.ExecuteScalar().ToString());
                if (NumFacturas == 0)
                {
                    MessageBox.Show("No hay facturas de ventas en ese intervalo de fechas","Facturas",MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else {
                    Form_Listado_Ventas frmListadoVentas = new Form_Listado_Ventas(dtFechaInicio, dtFechaFin);
                    if ((frmListadoVentas.Visible == false)) {
                        frmListadoVentas.Show();
                    }
                    Global.EsListadoVentas = false;
                }
            }
            if (Global.EsListadoCompras) {
                cmdNumCompras = new SqlCommand("SELECT [Facturas].[dbo].[NumComprasPorFecha](@FechaInicio,@FechaFin)", 
                    Global.DBConnection);
                cmdNumCompras.CommandType = CommandType.Text;
                cmdNumCompras.Parameters.Add(new SqlParameter("@FechaInicio", SqlDbType.DateTime));
                cmdNumCompras.Parameters["@FechaInicio"].Value = dtFechaInicio;
                cmdNumCompras.Parameters.Add(new SqlParameter("@FechaFin", SqlDbType.DateTime));
                cmdNumCompras.Parameters["@FechaFin"].Value = dtFechaFin;
                long NumCompras = long.Parse(this.cmdNumCompras.ExecuteScalar().ToString());
                if (NumCompras == 0) {
                    MessageBox.Show("No hay facturas de compras en ese intervalo de fechas","Facturas",MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else {
                    Form_Listado_Compras frmListadoCompras = new Form_Listado_Compras(dtFechaInicio, dtFechaFin);
                    if ((frmListadoCompras.Visible == false)) {
                        frmListadoCompras.Show();
                    }
                    Global.EsListadoCompras = false;
                }
            }
            if (Global.EsListadoAlbaranes)
            {
                cmdNumAlbaranes = new SqlCommand("SELECT [Facturas].[dbo].[NumAlbaranesPorFecha](@FechaInicio,@FechaFin)", 
                    Global.DBConnection);
                cmdNumAlbaranes.CommandType = CommandType.Text;
                cmdNumAlbaranes.Parameters.Add(new SqlParameter("@FechaInicio", SqlDbType.DateTime));
                cmdNumAlbaranes.Parameters["@FechaInicio"].Value = dtFechaInicio;
                cmdNumAlbaranes.Parameters.Add(new SqlParameter("@FechaFin", SqlDbType.DateTime));
                cmdNumAlbaranes.Parameters["@FechaFin"].Value = dtFechaFin;
                long NumAlbaranes = long.Parse(this.cmdNumAlbaranes.ExecuteScalar().ToString());
                if (NumAlbaranes == 0)
                {
                    MessageBox.Show("No hay Albaranes en ese intervalo de fechas", "Facturas", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    Form_Listado_Albaranes frmListadoAlbaranes = new Form_Listado_Albaranes(dtFechaInicio, dtFechaFin);
                    frmListadoAlbaranes.Show();
                }
            }
        }
        catch (Exception ex) {
            MessageBox.Show("Error " + "\r\n" + ex.Message,"Facturas",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        finally {
            if (Global.EsListadoCompras)
            {
                this.cmdNumCompras.Dispose();
                this.cmdNumCompras = null;
            }
            else if (Global.EsListadoVentas)
            {
                this.cmdNumVentas.Dispose();
                this.cmdNumVentas = null;   
            }
            else if (Global.EsListadoAlbaranes)
            {
                this.cmdNumAlbaranes.Dispose();
                this.cmdNumAlbaranes = null;
            }
        }
        this.Close();
    }
    
    private void Cancelar_Click(object eventSender, System.EventArgs eventArgs) {
        Preguntar = true;
        this.Close();
    }
    
    private void cAnio_SelectedIndexChanged(object eventSender, System.EventArgs eventArgs) {
        short Index = (short)cAnio.IndexOf((System.Windows.Forms.ComboBox)eventSender);
        PresentaFecha(ref Index);
    }
    
    private void cMes_SelectedIndexChanged(object eventSender, System.EventArgs eventArgs) {
        short Index = (short)cMes.IndexOf((System.Windows.Forms.ComboBox)eventSender);
        PresentaFecha(ref Index);
    }
    
    private void Form_Intervalo_Load(object eventSender, System.EventArgs eventArgs) {
        short i;
        short j;
        for (j = 0; (j <= 1); j++) {
            for (i = 1999; (i <= 2099); i++) {
                cAnio[j].Items.Add(i.ToString().PadLeft(2,'0'));
            }
            for (i = 1; (i <= 12); i++) {
                cMes[j].Items.Add(i.ToString().PadLeft(2,'0'));
            }
            this.cAnio[j].SelectedIndex = DateTime.Now.Year - 1999;
            this.cMes[j].SelectedIndex = DateTime.Now.Month - 1;
            PresentaFecha(ref j);
        }
    }
    
    private void PresentaFecha(ref short Index) {
        // Rellena la lista de los dias de la fecha con valores adecuados
        short LimDias, i;
        bool EsBisiesto = false;
        
        if (((((short.Parse(cAnio[Index].Text) % 4) 
                    == 0) 
                    && ((short.Parse(cAnio[Index].Text) % 100) 
                    != 0)) 
                    || ((short.Parse(cAnio[Index].Text) % 400) 
                    == 0))) {
            EsBisiesto = true;
        }
        switch (cMes[Index].Text) {
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
        cDia[Index].Items.Clear();
        for (i = 1; (i <= LimDias); i++) {
            cDia[Index].Items.Add(i.ToString().PadLeft(2,'0'));
        }

        //Si el día de hoy es mayor que el ultimo del mes que se acaba de seleccionar
        ///selecciona el ultimo dia del mes
        if ((DateTime.Now.Day - 1) 
                    < this.cDia[Index].Items.Count) {
            this.cDia[Index].SelectedIndex = (DateTime.Now.Day - 1);
        }
        else {
            this.cDia[Index].SelectedIndex = (this.cDia[Index].Items.Count - 1);
        }
    }
    
    private void Form_Intervalo_Closing(object eventSender, System.ComponentModel.CancelEventArgs eventArgs) {
        DialogResult OK;
        if (Preguntar) {
            OK = MessageBox.Show("¿Desea cancelar el proceso?", "Facturas",
                System.Windows.Forms.MessageBoxButtons.YesNo ,System.Windows.Forms.MessageBoxIcon.Question); 
            if ((OK == DialogResult.Yes)) {
                if (Global.EsListadoCompras) {
                    Global.EsListadoCompras = false;
                }
                if (Global.EsListadoVentas) {
                    Global.EsListadoVentas = false;
                }
                this.Close();
            }
            else {
                eventArgs.Cancel = true;
            }
        }
    }
}