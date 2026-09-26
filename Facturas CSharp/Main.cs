using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace Facturas_CSharp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            if ((m_vb6FormDefInstance == null))
            {
                if (m_InitializingDefInstance)
                {
                    m_vb6FormDefInstance = this;
                }
                else
                {
                    try
                    {
                        // Para el formulario de inicio, la primera instancia creada es la instancia predeterminada.
                        //if ((System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType == this.GetType))
                        //{
                        m_vb6FormDefInstance = this;
                        //}
                    }
                    catch (System.Exception End)
                    {
                        MessageBox.Show("Error " + End.Message);
                    }
                    // El Diseñador de Windows Forms requiere esta llamada.
                    InitializeComponent();
                }
            }

            InitializeComponent();
            ResizeRedraw = true;
        }

        private static frmMain m_vb6FormDefInstance;

        private static bool m_InitializingDefInstance;

        public static frmMain DefInstance
        {
            get
            {
                if (((m_vb6FormDefInstance == null)
                            || m_vb6FormDefInstance.IsDisposed))
                {
                    m_InitializingDefInstance = true;
                    m_vb6FormDefInstance = new frmMain();
                    m_InitializingDefInstance = false;
                }
                return m_vb6FormDefInstance;
            }
            set
            {
                m_vb6FormDefInstance = value;
            }
        }

        public void Consulta_Factura_Ventas_Popup(object eventSender, System.EventArgs eventArgs)
        {
            Consulta_Factura_Ventas_Click(eventSender, eventArgs);
        }

        public void Consulta_Factura_Ventas_Click(object eventSender, System.EventArgs eventArgs)
        {
            object num = null;
            Global.Sentencia = "DELETE FROM DETALLES;";
            Global.Conexion.Open(Global.strConn, Global.dbUser, Global.dbPass, 0);
            Global.Conexion.Execute(Global.Sentencia, out num, 0);
            Global.Conexion.Close();
            Global.EsConsultaVentas = true;
            Form_Prompt_Numero frmNumFactura = new Form_Prompt_Numero();
            frmNumFactura.Show();
        }

        public void Modificacion_Proveedores_Popup(object eventSender, System.EventArgs eventArgs)
        {
            Modificacion_Proveedores_Click(eventSender, eventArgs);
        }

        public void Modificacion_Proveedores_Click(object eventSender, System.EventArgs eventArgs)
        {
            Global.Modificacion_Proveedor = true;
            Form_Prompt_Proveedores frmPrmptProveedores = new Form_Prompt_Proveedores();
            frmPrmptProveedores.Text = "Modificación de Proveedores";
            frmPrmptProveedores.Show();
        }

        public void Alta_Factura_Compras_Popup(object eventSender, System.EventArgs eventArgs)
        {
            Alta_Factura_Compras_Click(eventSender, eventArgs);
        }

        public void Alta_Factura_Compras_Click(object eventSender, System.EventArgs eventArgs)
        {
            Form_Prompt_Fecha frmPrmptFecha = new Form_Prompt_Fecha("Factura de Compras");
            frmPrmptFecha.Show();
            Global.EsFacturaCompras = true;
        }

        public void Alta_Factura_Ventas_Popup(object eventSender, System.EventArgs eventArgs)
        {
            Alta_Factura_Ventas_Click(eventSender, eventArgs);
        }

        public void Alta_Factura_Ventas_Click(object eventSender, System.EventArgs eventArgs)
        {
            object numRecords = null;
            Global.Sentencia = "DELETE FROM DETALLES;";
            Global.Conexion.Open(Global.strConn, Global.dbUser, Global.dbPass, 0);
            Global.Conexion.BeginTrans();
            Global.Conexion.Execute(Global.Sentencia, out numRecords, 0);
            Global.Conexion.CommitTrans();
            Global.Conexion.Close();
            Form_Prompt_Fecha frmPrmptFecha = new Form_Prompt_Fecha("Factura de Ventas");
            frmPrmptFecha.Show();
            Global.EsFacturaVentas = true;
        }

        public void Alta_Materiales_Popup(object eventSender, System.EventArgs eventArgs)
        {
            Alta_Materiales_Click(eventSender, eventArgs);
        }

        public void Alta_Materiales_Click(object eventSender, System.EventArgs eventArgs)
        {
            // Sentencia = "SELECT MAX(COD_MAT) FROM MATERIALES;"
            // Conexion.Open("Provider=SQLOLEDB;Data Source=(local);Initial Catalog=Facturas;Persist Security Info=True;User ID=sysdba;Password=CHANGE_ME", _
            // "sysdba", "CHANGE_ME")
            // Recordset.Open(Sentencia, Conexion, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic, ADODB.CommandTypeEnum.adCmdText)
            // UPGRADE_WARNING: Se detect el uso de Null o IsNull(). Haga clic aqu para obtener ms informacin: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1049"'
            // If Not IsDBNull(Recordset.Fields(0).Value) Then
            //         Form_Materiales.DefInstance.Text_Codigo.Text = Recordset.Fields(0).Value + 1
            // Else
            // Form_Materiales.DefInstance.Text_Codigo.Text = "1"
            // End If
            // UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Alta_Material. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            Global.Alta_Material = true;
            Form_Materiales frmMaterial = new Form_Materiales();
            frmMaterial.Text = "Alta de Materiales";
            frmMaterial.Show();
            // Recordset.Close()
            // Conexion.Close()
        }

        public void Alta_Proveedores_Popup(object eventSender, System.EventArgs eventArgs)
        {
            Alta_Proveedores_Click(eventSender, eventArgs);
        }

        public void Alta_Proveedores_Click(object eventSender, System.EventArgs eventArgs)
        {
            /*
            Global.Sentencia = "SELECT MAX(COD_PRO) FROM PROVEEDORES;";
            Global.Conexion.Open("Provider=SQLOLEDB;Data Source=(local);Initial Catalog=Facturas;Persist Security Info=True;User ID=sys" +
                "dba;Password=CHANGE_ME", "sysdba", "CHANGE_ME");
            Global.Recordset.Open(Sentencia, Conexion, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic, ADODB.CommandTypeEnum.adCmdText);
            // UPGRADE_WARNING: Se detecto el uso de Null o IsNull(). Haga clic aqui para obtener mas informacion: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1049"'
            if (!Global.Recordset.Fields(0).Value = Nothing))
            {
                Form_Proveedores.DefInstance.Text_Codigo.Text = (Global.Recordset.Fields(0).Value + 1);
            }
            else
            {
                Form_Proveedores.DefInstance.Text_Codigo.Text = "1";
            }
            // UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Alta_Proveedor. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            Global.Recordset.Close();
            Global.Conexion.Close();
             */
            Global.Alta_Proveedor = true;
            Form_Proveedores frmProveedor = new Form_Proveedores();
            frmProveedor.Text = "Alta de Proveedores";
            frmProveedor.Show();
        }

        public void Alta_Albaranes_Popup(object eventSender, System.EventArgs eventArgs)
        {
            Alta_Albaranes_Click(eventSender, eventArgs);
        }

        public void Alta_Albaranes_Click(object eventSender, System.EventArgs eventArgs)
        {
            // UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Alta_Albaran. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            Global.Alta_Albaran = true;
            Form_Albaranes frmAlbaran = new Form_Albaranes();
            //DataSet dsAlbaranes = new DataSet();
            frmAlbaran.AsignarCampos(null);
            frmAlbaran.LimpiarCampos();
            frmAlbaran.Text = "Alta de Albaranes";
            frmAlbaran.Show();
        }

        public void Baja_Albaranes_Popup(object eventSender, System.EventArgs eventArgs)
        {
            Baja_Albaranes_Click(eventSender, eventArgs);
        }

        public void Baja_Albaranes_Click(object eventSender, System.EventArgs eventArgs)
        {
            Global.Baja_Albaran = true;
            Form_Numero_Albaran frmPromptAlbaran = new Form_Numero_Albaran();
            frmPromptAlbaran.Text = "Baja de Albaranes";
            frmPromptAlbaran.Show();
        }

        public void Baja_Materiales_Popup(object eventSender, System.EventArgs eventArgs)
        {
            Baja_Materiales_Click(eventSender, eventArgs);
        }

        public void Baja_Materiales_Click(object eventSender, System.EventArgs eventArgs)
        {
            Global.Baja_Material = true;
            Form_Prompt_Materiales frmPrmptMateriales = new Form_Prompt_Materiales();
            frmPrmptMateriales.Text = "Baja de Materiales";
            frmPrmptMateriales.Show();
        }

        public void Baja_Proveedores_Popup(object eventSender, System.EventArgs eventArgs)
        {
            Baja_Proveedores_Click(eventSender, eventArgs);
        }

        public void Baja_Proveedores_Click(object eventSender, System.EventArgs eventArgs)
        {
            Global.Baja_Proveedor = true;
            Form_Prompt_Proveedores frm_Prmpt_Proveedores = new Form_Prompt_Proveedores();
            frm_Prmpt_Proveedores.Text = "Baja de Proveedores";
            frm_Prmpt_Proveedores.Show();
        }

        private void cmdListadoGastos_Click(object eventSender, System.EventArgs eventArgs)
        {
            Listado_Gastos_Click(Listado_Gastos, new System.EventArgs());
        }

        public void Consulta_Albaranes_Popup(object eventSender, System.EventArgs eventArgs)
        {
            Consulta_Albaranes_Click(eventSender, eventArgs);
        }

        public void Consulta_Albaranes_Click(object eventSender, System.EventArgs eventArgs)
        {
            Global.Consulta_Albaran = true;
            Form_Numero_Albaran frmNumAlbaran = new Form_Numero_Albaran();
            frmNumAlbaran.Text = "Consulta de Albaranes";
            frmNumAlbaran.Show();
        }

        public void Consulta_Materiales_Popup(object eventSender, System.EventArgs eventArgs)
        {
            Consulta_Materiales_Click(eventSender, eventArgs);
        }

        public void Consulta_Materiales_Click(object eventSender, System.EventArgs eventArgs)
        {
            Global.Consulta_Material = true;
            Form_Prompt_Materiales frmPrmptMateriales = new Form_Prompt_Materiales();
            frmPrmptMateriales.Text = "Consulta de Materiales";
            frmPrmptMateriales.Show();
        }

        public void Consulta_Proveedores_Popup(object eventSender, System.EventArgs eventArgs)
        {
            Consulta_Proveedores_Click(eventSender, eventArgs);
        }

        public void Consulta_Proveedores_Click(object eventSender, System.EventArgs eventArgs)
        {
            Global.Consulta_Proveedor = true;
            Form_Prompt_Proveedores frmPromptProveedores = new Form_Prompt_Proveedores();
            frmPromptProveedores.Text = "Consulta de Proveedores";
            frmPromptProveedores.Show();
        }

        public void Listado_Gastos_Popup(object eventSender, System.EventArgs eventArgs)
        {
            Listado_Gastos_Click(eventSender, eventArgs);
        }

        public void Listado_Gastos_Click(object eventSender, System.EventArgs eventArgs)
        {
            Global.EsListadoCompras = true;
            Form_Intervalo frmIntervalo = new Form_Intervalo();
            frmIntervalo.Text = "Listado de Gastos";
            frmIntervalo.Show();
        }

        public void Listado_Ingresos_Popup(object eventSender, System.EventArgs eventArgs)
        {
            cmdListadoIngresos_Click(eventSender, eventArgs);
        }

        public void cmdListadoIngresos_Click(object eventSender, System.EventArgs eventArgs)
        {
            Global.EsListadoVentas = true;
            Form_Intervalo frmIntervalo = new Form_Intervalo();
            frmIntervalo.Text = "Listado de Ingresos";
            frmIntervalo.Show();
        }

        private void frmMain_Load(object eventSender, System.EventArgs eventArgs)
        {
            Global.Alta_Cliente = false;
            Global.Baja_Cliente = false;
            Global.Modificacion_Cliente = false;
            Global.Consulta_Cliente = false;
            Global.EsFacturaVentas = false;
            Global.EsFacturaCompras = false;
            Global.EsModificacionVentas = false;
            Global.EsModificacionCompras = false;
            Global.EsListadoVentas = false;
            Global.EsListadoCompras = false;
            Global.Alta_Material = false;
            Global.Baja_Material = false;
            Global.Modificacion_Material = false;
            Global.Consulta_Material = false;
            Global.Alta_Proveedor = false;
            Global.Baja_Proveedor = false;
            Global.Modificacion_Proveedor = false;
            Global.Consulta_Proveedor = false;
            Global.EsConsultaVentas = false;
            Global.Coma = ",";
            Global.Punto = ".";
            Global.DBConnection =
                new System.Data.SqlClient.SqlConnection("Data Source=calisto;Initial Catalog=Facturas;Persist " +
                "Security Info=True;User ID=sa;Password=CHANGE_ME");
            Global.DBConnection.Open();
            Global.Conexion = new ADODB.Connection();
            Global.Command_Renamed = new ADODB.Command();
            Global.Recordset = new ADODB.Recordset();
            Global.Conexion.ConnectionString =
                "Provider=SQLOLEDB;Data Source=calisto;Initial Catalog=Facturas;Persist Security Info=True;User ID=sa" +
            ";Password=CHANGE_ME";
        }

        private void Main_Closing(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            DialogResult OK;
            OK = MessageBox.Show("¿Realmente desea salir?", "Facturas", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
            if ((OK == DialogResult.Yes))
            {
                Global.Conexion.Close();
                Global.Recordset.Close();
                // UPGRADE_NOTE: El objeto Conexion no se puede destruir hasta que no se realice la recolecci�n de los elementos no utilizados. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
                Global.Conexion = null;
                Global.Command_Renamed = null;
                Global.Recordset = null;
                Global.DBConnection.Close();
                Global.DBConnection.Dispose();
                Global.DBConnection = null;
            }
            eventArgs.Cancel = true;
        }

        public void Modificacion_Albaranes_Popup(object eventSender, System.EventArgs eventArgs)
        {
            Modificacion_Albaranes_Click(eventSender, eventArgs);
        }

        public void Modificacion_Albaranes_Click(object eventSender, System.EventArgs eventArgs)
        {
            Global.Modificacion_Albaran = true;
            Form_Numero_Albaran frmNumAlbaran = new Form_Numero_Albaran();
            frmNumAlbaran.Text = "Modificación de Albaranes";
            frmNumAlbaran.Show();
            //Form_Albaranes.DefInstance.cmdAniadir.Visible = true;
            //Form_Albaranes.DefInstance.cmdBorrar.Visible = true;
            //Form_Albaranes.DefInstance.dcDestino.Visible = true;
            //Form_Albaranes.DefInstance.txtDestino.Visible = false;
        }

        public void Modificacion_Materiales_Popup(object eventSender, System.EventArgs eventArgs)
        {
            Modificacion_Materiales_Click(eventSender, eventArgs);
        }

        public void Modificacion_Materiales_Click(object eventSender, System.EventArgs eventArgs)
        {
            Global.Modificacion_Material = true;
            Form_Prompt_Materiales frmMateriales = new Form_Prompt_Materiales();
            frmMateriales.Text = "Modificación de Materiales";
            frmMateriales.Show();
            //Form_Materiales.DefInstance.Hide();
            //Form_Prompt_Materiales.DefInstance.Show();
        }

        public void Salir_Popup(object eventSender, System.EventArgs eventArgs)
        {
            Salir_Click(eventSender, eventArgs);
        }

        public void Salir_Click(object eventSender, System.EventArgs eventArgs)
        {
            this.Close();
        }

        public void Alta_Clientes_Popup(object eventSender, System.EventArgs eventArgs)
        {
            Alta_Clientes_Click(eventSender, eventArgs);
        }

        public void Alta_Clientes_Click(object eventSender, System.EventArgs eventArgs)
        {
            Global.Alta_Cliente = true;
            Form_Clientes frmCliente = new Form_Clientes();
            frmCliente.Text = "Alta de Clientes";
            frmCliente.Show();
            // Sentencia = "SELECT MAX(COD_CLI) FROM Clientes"
            // Conexion.Open("Provider=SQLOLEDB;Data Source=GANIMEDES;Initial Catalog=Facturas;Persist Security Info=True;User ID=sysdba;Password=CHANGE_ME", _
            // "sysdba", "CHANGE_ME")
            // Recordset.Open(Sentencia, Conexion, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic, ADODB.CommandTypeEnum.adCmdText)
            // Form_Clientes.DefInstance.Text_Codigo.Text = Recordset.Fields(0).Value + 1
            // Recordset.Close()
            // Conexion.Close()
        }

        public void Baja_Clientes_Popup(object eventSender, System.EventArgs eventArgs)
        {
            Baja_Clientes_Click(eventSender, eventArgs);
        }

        public void Baja_Clientes_Click(object eventSender, System.EventArgs eventArgs)
        {
            Global.Baja_Cliente = true;
            Form_Prompt_Clientes frmPromptClientes = new Form_Prompt_Clientes();
            //Form_Clientes.DefInstance.Hide();
            frmPromptClientes.Text = "Baja de Clientes";
            frmPromptClientes.Show();
        }

        public void Consulta_Clientes_Popup(object eventSender, System.EventArgs eventArgs)
        {
            Consulta_Clientes_Click(eventSender, eventArgs);
        }

        public void Consulta_Clientes_Click(object eventSender, System.EventArgs eventArgs)
        {
            Global.Consulta_Cliente = true;
            Form_Prompt_Clientes frmPromptClientes = new Form_Prompt_Clientes();
            frmPromptClientes.Text = "Consulta de Clientes";
            //Form_Clientes.DefInstance.Hide();
            frmPromptClientes.Show();
        }

        public void Modificacion_Clientes_Popup(object eventSender, System.EventArgs eventArgs)
        {
            Modificacion_Clientes_Click(eventSender, eventArgs);
        }

        public void Modificacion_Clientes_Click(object eventSender, System.EventArgs eventArgs)
        {
            Global.Modificacion_Cliente = true;
            Form_Prompt_Clientes frmPromptClientes = new Form_Prompt_Clientes();
            frmPromptClientes.Show();
            frmPromptClientes.Text = "Modificación de Clientes";
        }

        private void Consulta_Factura_Compras_Click(object sender, System.EventArgs e)
        {
            Form_Report_Factura Form_Factura = new Form_Report_Factura();
            Form_Factura.Show();
        }

        private void cmdModificacionFacturaVentas_Click(object sender, System.EventArgs e)
        {
            Global.Modificacion_Factura = true;
            Form_Prompt_Numero frmPromptNumFactura = new Form_Prompt_Numero();
            frmPromptNumFactura.Show();
        }

        private void cmdListadoAlbaranes_Click(object sender, System.EventArgs e)
        {
            Listado_Albaranes_Click();
        }

        private void Listado_Albaranes_Click()
        {
            Global.EsListadoAlbaranes = true;
            Form_Intervalo frmIntervalo = new Form_Intervalo();
            //Form_Listado_Albaranes frmListadoAlbaranes = new Form_Listado_Albaranes();
            frmIntervalo.Show();
        }

        private void Listado_Albaranes_Click(object sender, System.EventArgs e)
        {
            Listado_Albaranes_Click();
        }

        private void cmdAltaProveedor_Click(object sender, System.EventArgs e)
        {
            Alta_Proveedores_Click(sender, e);
        }

        private void cmdBajaProveedor_Click(object sender, System.EventArgs e)
        {
            Baja_Proveedores_Click(sender, e);
        }

        private void cmdConsultaProveedor_Click(object sender, System.EventArgs e)
        {
            Consulta_Proveedores_Click(sender, e);
        }

        private void cmdModificacionProveedor_Click(object sender, System.EventArgs e)
        {
            Modificacion_Proveedores_Click(sender, e);
        }

        private void cmdAltaCliente_Click(object sender, System.EventArgs e)
        {
            Alta_Clientes_Click(sender, e);
        }

        private void cmdBajaCliente_Click(object sender, System.EventArgs e)
        {
            Baja_Clientes_Click(sender, e);
        }

        private void cmdModificacionCliente_Click(object sender, System.EventArgs e)
        {
            Modificacion_Clientes_Click(sender, e);
        }

        private void cmdConsultaCliente_Click(object sender, System.EventArgs e)
        {
            Consulta_Clientes_Click(sender, e);
        }

        private void cmdAltaMaterial_Click(object sender, System.EventArgs e)
        {
            Alta_Materiales_Click(sender, e);
        }

        private void cmdBajaMaterial_Click(object sender, System.EventArgs e)
        {
            Baja_Materiales_Click(sender, e);
        }

        private void cmdModificacionMaterial_Click(object sender, System.EventArgs e)
        {
            Modificacion_Materiales_Click(sender, e);
        }

        private void cmdConsultaMaterial_Click(object sender, System.EventArgs e)
        {
            Consulta_Materiales_Click(sender, e);
        }

        private void cmdAltaAlbaran_Click(object sender, System.EventArgs e)
        {
            Alta_Albaranes_Click(sender, e);
        }

        private void cmdBajaAlbaran_Click(object sender, System.EventArgs e)
        {
            Baja_Albaranes_Click(sender, e);
        }

        private void cmdModificacionAlbaran_Click(object sender, System.EventArgs e)
        {
            Modificacion_Albaranes_Click(sender, e);
        }

        private void cmdConsultaAlbaran_Click(object sender, System.EventArgs e)
        {
            Consulta_Albaranes_Click(sender, e);
        }

        private void cmdAltaFacturaVentas_Click(object sender, System.EventArgs e)
        {
            Alta_Factura_Ventas_Click(sender, e);
        }

        private void cmdConsultaFacturaVentas_Click(object sender, System.EventArgs e)
        {
            Consulta_Factura_Ventas_Click(sender, e);
        }

        private void cmdAltaFacturaCompras_Click(object sender, System.EventArgs e)
        {
            Alta_Factura_Compras_Click(sender, e);
        }

        private void cmdConsultaFacturaCompras_Click(object sender, System.EventArgs e)
        {
            Consulta_Factura_Compras_Click(sender, e);
        }

        private void Pintar_Botones()
        {
            foreach (Control marcos in this.Controls)
            {
                foreach (TabControl tabCtl in marcos.Controls)
                {
                    // Centrar los botones dentro del marco en altura y anchura
                    foreach (TabPage page in tabCtl.TabPages)
                    {
                        //this.TabControl.SelectedTab = page;
                        tabCtl.SelectedTab = page;
                        foreach (GroupBox marco in page.Controls)
                        {
                            int count = marco.Controls.Count;
                            int gap = (marco.Width
                                        - (count * marco.Controls[0].Width)) / (count + 1);
                            foreach (Button btn in marco.Controls)
                            {
                                int MyTop = ((marco.Top + marco.Height) / 2) - (btn.Height / 2);
                                int MyLeft = (marco.Left + (gap + (marco.Controls.IndexOf(btn) * (btn.Width + gap))));
                                btn.Location = new System.Drawing.Point(MyLeft, MyTop);
                            }
                        }
                    }

                }
            }
        }

        private void frmMain_SizeChanged(object sender, System.EventArgs e)
        {
            int selectedTab = this.tabCtrl.SelectedIndex;
            this.Pintar_Botones();
            this.tabCtrl.SelectedIndex = selectedTab;
        }

        private void frmMain_ResizeEnd(object sender, System.EventArgs e){
            int selectedTab = this.tabCtrl.SelectedIndex;
            this.Pintar_Botones();
            this.tabCtrl.SelectedIndex = selectedTab;
        }

    }
}
