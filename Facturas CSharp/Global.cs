namespace Facturas_CSharp
{
    using System.Data.SqlClient;
    public static class Global
    {
        public static string strConn =
            "Provider=SQLOLEDB;Data Source=calisto;Initial Catalog=Facturas;Persist Security Info=True;" +
            "User ID=sa;Password=CHANGE_ME";

        public static string dbUser = "sa";

        public static string dbPass = "CHANGE_ME";

        public static ADODB.Connection Conexion = new ADODB.Connection();

        public static ADODB.Command Command_Renamed;

        public static ADODB.Recordset Recordset;

        public static System.Data.SqlClient.SqlConnection DBConnection;

        public static string Sentencia;

        public static bool Modificacion_Factura;

        public static bool EsConsultaVentas;

        public static bool EsFacturaCompras, EsListadoCompras, Consulta_Proveedor, Baja_Proveedor, EsModificacionCompras,
        Consulta_Cliente, Baja_Cliente, Consulta_Albaran, Baja_Albaran, Consulta_Material, Baja_Material,
        Alta_Material, Modificacion_Material, Alta_Albaran, Modificacion_Albaran, Alta_Cliente, Modificacion_Cliente,
        EsModificacionVentas, Alta_Proveedor, Modificacion_Proveedor, EsListadoVentas, EsFacturaVentas, HayDescuento,
        EsListadoAlbaranes;

        public static string Punto;
        public static string Coma;

        public static Tipos.tDetalle RegDetalle = new Tipos.tDetalle();

        public static Tipos.tMaterial RegMaterial = new Tipos.tMaterial();

        public static Tipos.tFacturaVentas RegFacturaVentas = new Tipos.tFacturaVentas();

        public static Tipos.tCliente RegCliente = new Tipos.tCliente();

        public static Tipos.tProveedor RegProveedor = new Tipos.tProveedor();

        public static Tipos.tFacturaCompras RegFacturaCompras = new Tipos.tFacturaCompras();

        public static Tipos.tAlbaran RegAlbaran = new Tipos.tAlbaran();
    }
}
