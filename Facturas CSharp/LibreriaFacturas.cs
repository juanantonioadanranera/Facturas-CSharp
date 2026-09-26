using System.Windows.Forms;
using Facturas_CSharp;
class LibreriaFacturas {
/*    
    public static void AltaDetalleHistorico() {
        short i = 1;
        // TODO: On Error GoTo Warning!!!: The statement is not translatable 
        ADODB.Recordset RS = new ADODB.Recordset();
        ADODB.Connection CONN = new ADODB.Connection();
        CONN.ConnectionString = "Provider=SQLOLEDB;Data Source=GANIMEDES;Initial Catalog=Facturas;Persist Security Info=True;User ID=s" +
        "ysdba;Password=CHANGE_ME";
        CONN.Open();
        RS.let_ActiveConnection(CONN);
        RS.Open("SELECT * FROM DETALLES", CONN, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdText);
        RS.MoveFirst();
        while (!RS.EOF) {
            // With...
            RS.Fields("Num_Factura").Value.Precio = RS.Fields("Unidades").Value;
            RS.Fields("Nombre").Value.Numero = RS.Fields("Unidades").Value;
            RS.Fields("NIF").Value.Nombre = RS.Fields("Unidades").Value;
            RS.Fields("Localidad").Value.NIF = RS.Fields("Unidades").Value;
            RS.Fields("FECHA_FACTURA").Value.Localidad = RS.Fields("Unidades").Value;
            RS.Fields("Direccion").Value.Fecha = RS.Fields("Unidades").Value;
            RS.Fields("Destino").Value.Direccion = RS.Fields("Unidades").Value;
            RS.Fields("Descripcion").Value.Destino = RS.Fields("Unidades").Value;
            RS.Fields("CodPostal").Value.Descripcion = RS.Fields("Unidades").Value;
            RegDetalle.CodPostal = RS.Fields("Unidades").Value;
            if (EsModificacionVentas) {
                if (Existe(RegDetalle)) {
                    ModificacionHistorico(RegDetalle);
                }
                else {
                    AltaHistorico(RegDetalle);
                }
            }
            else {
                AltaHistorico(RegDetalle);
            }
            i = (i + 1);
            if (!RS.EOF) {
                RS.MoveNext();
            }
            else {
                RS.Close();
                return;
            }
        }
        RS.Close();
        CONN.Close();
        return;
    HayError:
        MsgBox(("Error N�mero " 
                        + (Err.Number + ("\r\n" + Err.Description))), MsgBoxStyle.OKOnly, "Error");
        Err.Clear();
        if ((RS.State != ADODB.ObjectStateEnum.adStateClosed)) {
            RS.Close();
        }
        if ((CONN.State != ADODB.ObjectStateEnum.adStateClosed)) {
            CONN.Close();
        }
    }
	*/
	    
    /*
    public static short ValidarNumeroFacturaVentas(string Numero) {
        if (!IsNumeric(Numero)) {
            ValidarNumeroFacturaVentas = 1021;
        }
        else {
            if ((double.Parse(Numero) == 0)) {
                ValidarNumeroFacturaVentas = 1020;
            }
            else {
                Sentencia = ("SELECT * FROM FacturasVentas WHERE " + ("NUM_FACTURA = " 
                            + (double.Parse(Numero) + ";")));
                Conexion.Open();
                Recordset.Open(Sentencia, Conexion, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdText);
                if (!Recordset.EOF) {
                    Recordset.MoveLast();
                }
                if ((Recordset.RecordCount > 0)) {
                    if (EsFacturaVentas) {
                        ValidarNumeroFacturaVentas = 1022;
                    }
                    else {
                        if ((Recordset.RecordCount < 1)) {
                            if (EsConsultaVentas) {
                                ValidarNumeroFacturaVentas = 1023;
                            }
                            else {
                                return 0;
                            }
                        }
                        Global.Recordset.Close();
                        Global.Conexion.Close();
                    }
                }
            }

        }
    }
    */
    /*
    static void ModificacionFacturaVentas(ref tFacturaVentas RegFactura) {
        float ACobrar;
        // TODO: On Error GoTo Warning!!!: The statement is not translatable 
        // With...
        TipoDescuento;
        Descuento;
        (Total + (", IVA=" + Replace(ToString().Iva)));
        Coma;
        Punto;
        (", TOTALCONIVA=" + Replace(ToString().TotalConIva));
        Coma;
        Punto;
        (Destino + ("\', DESCUENTO=" + Replace(ToString().Descuento)));
        Coma;
        Punto;
        Numero;
        Conexion.Open();
        Conexion.Execute(Sentencia);
        Conexion.Close();
        return;
    HayError:
        MsgBox(("Error N�mero " 
                        + (Err.Number + ("\r\n" + Err.Description))), MsgBoxStyle.OKOnly, "Error");
        Err.Clear();
        if ((Conexion.State == ADODB.ObjectStateEnum.adStateOpen)) {
            Conexion.RollbackTrans();
        }
    }
    
    static void AltaDetalle(ref tDetalle RegDetalle) {
        float Importe;
        // TODO: On Error GoTo Warning!!!: The statement is not translatable 
        // With...
        Importe = (RegDetalle.Precio * RegDetalle.Unidades);
        Sentencia = ("INSERT INTO Detalles (COD_CLI,CODPOSTAL,DIRECCION," + ("LOCALIDAD,NIF,NOMBRE,DESTINO,UNIDADES,DESCRIPCION,PRECIO_VENTA," + ("SUBTOTAL,FECHA_FACTURA,NUM_FACTURA) VALUES (\'" 
                    + (RegDetalle.Cod_Cli + ("\',\'" 
                    + (RegDetalle.CodPostal + ("\',\'" 
                    + (RegDetalle.Direccion + ("\',\'" 
                    + (RegDetalle.Localidad + ("\',\'" 
                    + (RegDetalle.NIF + ("\',\'" 
                    + (RegDetalle.Nombre + ("\',\'" 
                    + (RegDetalle.Destino + ("\'," 
                    + (RegDetalle.Unidades.ToString().Replace(Coma, Punto) + (",\'" 
                    + (RegDetalle.Descripcion + ("\'," 
                    + (RegDetalle.Precio.ToString().Replace(Coma, Punto) + ("," 
                    + (Importe.ToString().Replace(Coma, Punto) + (",\'" 
                    + (RegDetalle.Fecha + ("\'," 
                    + (RegDetalle.Numero + ")"))))))))))))))))))))))))))));
        Conexion.Open();
        Conexion.Execute(Sentencia);
        Conexion.Close();
        RegFacturaVentas.Total = (RegFacturaVentas.Total + Importe);
        return;
    HayError:
        MsgBox(("Error N�mero " 
                        + (Err.Number + ("\r\n" + Err.Description))), MsgBoxStyle.OKOnly, "Error");
        Err.Clear();
        if ((Conexion.State == ADODB.ObjectStateEnum.adStateOpen)) {
            Conexion.RollbackTrans();
        }
    }
    
    static void ModificacionHistorico(ref tDetalle RegDetalle) {
        float Importe;
        // TODO: On Error GoTo Warning!!!: The statement is not translatable 
        // With...
        Importe = (RegDetalle.Precio * RegDetalle.Unidades);
        Sentencia = ("UPDATE Historico SET COD_CLI=" 
                    + (RegDetalle.Cod_Cli + ("," + ("DESTINO=\'" 
                    + (RegDetalle.Destino + ("\', " + ("UNIDADES=" 
                    + (RegDetalle.Unidades.ToString().Replace(Coma, Punto) + (", " + ("DESCRIPCION=\'" 
                    + (RegDetalle.Descripcion + ("\', " + ("PRECIO_VENTA=" 
                    + (RegDetalle.Precio.ToString().Replace(Coma, Punto) + (", " + ("FECHA_FACTURA=\'" 
                    + (RegDetalle.Fecha + ("\', " + ("NUM_FACTURA=" 
                    + (RegDetalle.Numero + (", SUBTOTAL=" 
                    + (Importe.ToString().Replace(Coma, Punto) + (" WHERE (NUM_FACTURA=" 
                    + (RegDetalle.Numero + (" AND DESCRIPCION =\'" 
                    + (RegDetalle.Descripcion + "\')"))))))))))))))))))))))))));
        Conexion.Open();
        Conexion.Execute(Sentencia);
        Conexion.Close();
        return;
    HayError:
        MsgBox(("Error N�mero " 
                        + (Err.Number + ("\r\n" + Err.Description))), ,, "Error");
        Err.Clear();
        if ((Conexion.State == ADODB.ObjectStateEnum.adStateOpen)) {
            Conexion.RollbackTrans();
        }
    }
    
    static void AltaHistorico(ref tDetalle RegDetalle) {
        float Importe;
        // TODO: On Error GoTo Warning!!!: The statement is not translatable 
        Sentencia = ("SELECT COD_MAT FROM MATERIALES WHERE DESCRIPCION=\'" 
                    + (RegDetalle.Descripcion + "\'"));
        if ((Recordset.State != ADODB.ObjectStateEnum.adStateClosed)) {
            Recordset.Close();
        }
        Conexion.Open();
        Recordset.Open(Sentencia, Conexion, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic, ADODB.CommandTypeEnum.adCmdText);
        // With...
        Unidades;
        (Destino + ("\'," + Replace(ToString().Unidades)));
        Coma;
        Punto;
        (Descripcion + ("\'," + Replace(ToString().Precio)));
        Coma;
        Punto;
        (Cod_Mat + ")");
        Conexion.Execute(Sentencia);
        Recordset.Close();
        Conexion.Close();
        return;
    HayError:
        MsgBox(("Error N�mero " 
                        + (Err.Number + ("\r\n" + Err.Description))), MsgBoxStyle.OkOnly, "Error");
        Err.Clear();
        Recordset.Close();
        if ((Conexion.State == ADODB.ObjectStateEnum.adStateOpen)) {
            Conexion.Close();
        }
    }
    */

    /*
    static void AsignarDetalleMaterial(ref tDetalle RegDetalle) {
        // With...
        double.Parse(Form_Cantidad.DefInstance.Text_Cantidad.Text).Descripcion = double.Parse(Form_Materiales.DefInstance.Text_Precio.Text);
        RegDetalle.Unidades = double.Parse(Form_Materiales.DefInstance.Text_Precio.Text);
    }
     */ 
    
    /*
    public static void AsignarDetalleCliente(ref tDetalle RegDetalle) {
        // With...
        Form_Clientes.DefInstance.Text_Localidad.Text.NIF = Form_Clientes.DefInstance.Text_Nombre.Text;
        Form_Clientes.DefInstance.Text_Direccion.Text.Localidad = Form_Clientes.DefInstance.Text_Nombre.Text;
        Form_Clientes.DefInstance.Text_CodPostal.Text.Direccion = Form_Clientes.DefInstance.Text_Nombre.Text;
        int.Parse(Form_Clientes.DefInstance.Text_Codigo.Text).CodPostal = Form_Clientes.DefInstance.Text_Nombre.Text;
        RegDetalle.Cod_Cli = Form_Clientes.DefInstance.Text_Nombre.Text;
    }
     */ 
    
    /*
    public static void AsignarFacturaVentas(ref tFacturaVentas RegFactura, ref Tipos.tDetalle RegDetalle) {
        RegFactura.Cod_Cli = RegDetalle.Cod_Cli;
        RegFactura.Fecha = RegDetalle.Fecha;
        RegFactura.Numero = RegDetalle.Numero;
    }
     */
 
    
    /*
    public static bool Existe(ref Tipos.tDetalle RegDetalle) {
        // TODO: On Error GoTo Warning!!!: The statement is not translatable 
        string Consulta;
        // With...
        Consulta = ("SELECT * FROM HISTORICO WHERE NUM_FACTURA=" 
                    + (RegDetalle.Numero + (" AND DESCRIPCION=\'" 
                    + (RegDetalle.Descripcion + "\'"))));
        Global.Conexion.Open();
        Global.Recordset.Open(Global.Consulta, Global.Conexion, ADODB.CursorTypeEnum.adOpenStatic, 
            ADODB.LockTypeEnum.adLockBatchOptimistic, ADODB.CommandTypeEnum.adCmdText);
        if ((Gloabl.Recordset.RecordCount > 0)) {
            Existe = true;
        }
        else {
            Existe = false;
        }
        Gloabl.Recordset.Close();
        Global.Conexion.Close();
        // TODO: Exit Function: Warning!!! Need to return the value
        /*return;
    HayError:
        MsgBox(("Error N�mero " 
                        + (Err.Number + ("\r\n" + Err.Description))));
        Err.Clear();
    }
    /*
    /*
    public static void AltaDetalleFactura() {
        // TODO: On Error GoTo Warning!!!: The statement is not translatable 
        Sentencia = ("INSERT INTO Detalles ( NOMBRE, DIRECCION, LOCALIDAD, CODPOSTAL, NIF, DESTINO, UNIDADES, DESCRIPCION, " +
        "PRECIO_VENTA, NUM_FACTURA, FECHA_FACTURA, SUBTOTAL ) " + ("SELECT Clientes.NOMBRE, Clientes.DIRECCION, Clientes.LOCALIDAD, Clientes.CODPOSTAL, Clientes.NIF, Alb" +
        "aranes.DESTINO, Sum(Albaranes.CANTIDAD) AS UNIDADES, " + ("Materiales.DESCRIPCION, Materiales.PRECIO_VENTA," 
                    + (int.Parse(RegFacturaVentas.Numero) + (" AS NUM_FACTURA,\'" 
                    + (RegFacturaVentas.Fecha + ("\'AS FECHA_FACTURA, " + ("Sum(PRECIO_VENTA*Albaranes.CANTIDAD) AS SUBTOTAL FROM (Albaranes INNER JOIN Clientes ON Albaranes.COD" +
                    "_CLI = Clientes.COD_CLI) INNER JOIN Materiales " + ("ON Albaranes.COD_MAT = " + ("Materiales.Cod_Mat " + ("WHERE Albaranes.FACTURADO=0 AND Albaranes.DESTINO=\'" 
                    + (RegFacturaVentas.Destino + ("\' AND Clientes.NOMBRE=\'" 
                    + (RegFacturaVentas.Nombre + ("\' GROUP BY Clientes.NOMBRE, Clientes.DIRECCION, Clientes.LOCALIDAD, Clientes.CODPOSTAL, Clientes.NIF," +
                    " Albaranes.DESTINO, " + "Materiales.DESCRIPCION, Materiales.PRECIO_VENTA")))))))))))))));
        Conexion.Open();
        Conexion.Execute(Sentencia);
        Conexion.Close();
        return;
    HayError:
        MsgBox(("Error N�mero " 
                        + (Err.Number + ("\r\n" + Err.Description))), MsgBoxStyle.OkOnly, "Error");
        Err.Clear();
        if ((Conexion.State == ADODB.ObjectStateEnum.adStateOpen)) {
            Conexion.RollbackTrans();
        }
    }
    
    static float ActualizarImporteFactura() {
        // TODO: On Error GoTo Warning!!!: The statement is not translatable 
        Sentencia = ("UPDATE FacturasVentas SET FacturasVentas.IVA = FACTURASVENTAS.TOTAL*" + ("FACTURASVENTAS.TIPOIVA / 100 , FacturasVentas.TOTALCONIVA = " + ("FACTURASVENTAS.TOTAL+FACTURASVENTAS.IVA, FacturasVentas.DESCUENTO" + (" = FACTURASVENTAS.TOTALCONIVA*FACTURASVENTAS.TIPODESCUENTO/100, " + ("FacturasVentas.ACOBRAR = FACTURASVENTAS.TOTALCONIVA-FACTURASVENTAS.[DESCUENTO]" + ("WHERE (((FacturasVentas.IVA)=0) AND ((FacturasVentas.TOTALCONIVA)=0) " + "AND ((FacturasVentas.DESCUENTO)=0) AND ((FacturasVentas.ACOBRAR)=0));"))))));
        Conexion.Open();
        Conexion.Execute(Sentencia);
        Conexion.Close();
        return ((float)(0));
        
    HayError:
        ActualizarImporteFactura = float.Parse(Err.Number);
        MsgBox(("Error N�mero " 
                        + (Err.Number + ("\r\n" + Err.Description))), MsgBoxStyle.OkOnly, "Error");
        Err.Clear();
        if ((Conexion.State == ADODB.ObjectStateEnum.adStateOpen)) {
            Conexion.RollbackTrans();
        }
    }
    
    static void MuestraError() {
        MsgBox(("Error N�mero " 
                        + (Err.Number + ("\r\n" + Err.Description))), ,, "Error");
        Err.Clear();
    }
    
    public static void ConsultaFacturaVentas(ref int Numero) {
        // TODO: On Error GoTo Warning!!!: The statement is not translatable 
        Sentencia = ("INSERT INTO Detalles ( NOMBRE, DIRECCION, LOCALIDAD, CODPOSTAL, " + ("NIF, DESTINO, UNIDADES, DESCRIPCION, PRECIO_VENTA, NUM_FACTURA, FECHA_FACTURA, SUBTOTAL ) " + ("SELECT C.NOMBRE, C.DIRECCION, C.LOCALIDAD, C.CODPOSTAL, C.NIF, H.DESTINO, H.UNIDADES, " + ("H.DESCRIPCION, H.PRECIO_VENTA, H.NUM_FACTURA, H.FECHA_FACTURA, H.SUBTOTAL " + ("From Historico H, Clientes C " + ("WHERE ((H.NUM_FACTURA=" 
                    + (Numero + (") AND " + "(H.COD_CLI=C.COD_CLI));"))))))));
        Conexion.Open();
        Conexion.Execute(Sentencia);
        Conexion.Close();
        return;
    HayError:
        MsgBox(("Error n�mero " 
                        + (Err.Number + ("\r\n" + Err.Description))), MsgBoxStyle.OkOnly);
        Err.Clear();
        if ((Conexion.State == ADODB.ObjectStateEnum.adStateOpen)) {
            Conexion.RollbackTrans();
        }
    }
    
     */
 
    /*
    static bool ExisteFactura(ref int Numero, ref tFacturaVentas RegFacturaVentas) {
        bool Existe;
        Global.Sentencia = ("SELECT * FROM FACTURASVENTAS F, CLIENTES C WHERE F.COD_CLI=C.COD_CLI AND NUM_FACTURA = " + Numero);
        Global.Conexion.Open();
        Global.Recordset = Conexion.Execute(Global.Sentencia);
        Global.Recordset.MoveFirst();
        if (Global.Recordset.EOF) {
            Existe = false;
        }
        else {
            // With...
            GlobalRecordset.Fields("DESTINO").Value.Nombre = bool.Parse(Recordset.Fields("COBRADA").Value);
            DateTime.Parse(Recordset.Fields("FECHA_FACTURA").Value).Destino = bool.Parse(Recordset.Fields("COBRADA").Value);
            RegFacturaVentas.Fecha = bool.Parse(Recordset.Fields("COBRADA").Value);
            Existe = true;
        }
        Recordset.Close();
        Conexion.Close();
        return Existe;
    }
     */
 
}
