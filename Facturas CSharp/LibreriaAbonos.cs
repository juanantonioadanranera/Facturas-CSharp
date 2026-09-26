using Facturas_CSharp;
using System;
using System.Windows.Forms;
public class LibreriaAbonos {
    
    public static void AltaAbono(long Numero) {
        object numRecords = null;
        Global.Sentencia = ("INSERT INTO Abonos ( COD_CLI, NUM_FACTURA, TOTAL_FACTURA, NUM_ABONO, " +
            ("TOTAL_ABONO, IVA, TOTALCONIVA, CONCEPTO ) " + ("SELECT FacturasVentas.COD_CLI, " +
            ("FacturasVentas.NUM_FACTURA,FacturasVentas.TOTAL, NULL, TOTAL*TIPODESCUENTO AS TOTAL_ABONO, " +
            ("FacturasVentas.TOTAL*TIPOIVA*TIPODESCUENTO AS IVA, " +
            ("(TOTAL*TIPODESCUENTO)+(TOTAL*TIPOIVA*TIPODESCUENTO) AS TOTALCONIVA, \'"
            + (Global.RegFacturaVentas.ConceptoDescuento + ("\' AS CONCEPTO " + ("From FacturasVentas " +
            ("WHERE (((FacturasVentas.NUM_FACTURA) = " + (Global.RegFacturaVentas.Numero + (")) " +
            ("GROUP BY FacturasVentas.COD_CLI, FacturasVentas.NUM_FACTURA, " + ("FacturasVentas.TOTAL, " +
            ("FacturasVentas.TOTAL*TIPODESCUENTO, " + ("FacturasVentas.TOTAL*TIPOIVA*TIPODESCUENTO, " +
            "(TOTAL*TIPODESCUENTO)+(TOTAL*TIPOIVA*TIPODESCUENTO);"))))))))))))))));
        try
        {
            Global.Conexion.Open(Global.strConn,Global.dbUser,Global.dbPass,0);
            Global.Conexion.Execute(Global.Sentencia,out numRecords,0);
        }
        catch (Exception)
        {
            MessageBox.Show("Error:" + "\r\n","Facturas",MessageBoxButtons.OK,MessageBoxIcon.Error);
            throw;
        }
        finally
        {
            Global.Conexion.Close();
        }
    }
    
    public static long PideNumAbono(long NumFactura, ref bool Existe) {
        long MaxAbono = 0;
        long MaxFactura = 0;

        Global.Sentencia = ("SELECT * FROM ABONOS WHERE NUM_FACTURA=" + (NumFactura + ";"));
        try
        {
            Global.Conexion.Open(Global.strConn, Global.dbUser, Global.dbPass, 0);
            Global.Recordset.Open(Global.Sentencia, Global.Conexion, ADODB.CursorTypeEnum.adOpenStatic,
                ADODB.LockTypeEnum.adLockBatchOptimistic, (int)ADODB.CommandTypeEnum.adCmdText);
            if (!(Global.Recordset.RecordCount > 0))
            {
                Existe = false;
            }
            else
            {
                Existe = true;
            }
            Global.Recordset.Close();
            Global.Sentencia = "SELECT MAX(NUM_ABONO) FROM ABONOS;";
            Global.Recordset.Open(Global.Sentencia, Global.Conexion, ADODB.CursorTypeEnum.adOpenStatic,
                ADODB.LockTypeEnum.adLockPessimistic, (int)ADODB.CommandTypeEnum.adCmdText);
            MaxAbono = long.Parse(Global.Recordset.Fields[0].Value.ToString());
            Global.Recordset.Close();
            Global.Sentencia = "SELECT MAX(NUM_FACTURA) FROM FACTURASVENTAS;";
            Global.Recordset.Open(Global.Sentencia, Global.Conexion, ADODB.CursorTypeEnum.adOpenStatic,
                ADODB.LockTypeEnum.adLockPessimistic, (int)ADODB.CommandTypeEnum.adCmdText);
            MaxFactura = long.Parse(Global.Recordset.Fields[0].Value.ToString());

            Global.Recordset.Close();
            Global.Conexion.Close();

            if ((MaxAbono > MaxFactura))
            {
                return (MaxAbono + 1);
            }
            else
            {
                return MaxFactura + 1;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error:" + "\r\n" + ex.Message,"Facturas",MessageBoxButtons.OK,MessageBoxIcon.Error);
            throw;
        }
    }
    
    public static void BajaAbono(long Numero) {
        object numRecords = null;
        Global.Sentencia = ("DELETE FROM ABONOS WHERE NUM_FACTURA=" 
            + (Numero + ";"));
        try 
        {	        
            Global.Conexion.Open(Global.strConn,Global.dbUser,Global.dbPass,0);
            Global.Conexion.Execute(Global.Sentencia, out numRecords, 0);
            Global.Conexion.Close();        	
        }
        catch (System.Exception)
        {
        MessageBox.Show("Error: " + "\r\n","Facturas",MessageBoxButtons.OK,MessageBoxIcon.Error);        	
	        throw;
        }
    }
    
    static void ModificacionAbono(ref Tipos.tFacturaVentas RegFactura) {
        object numRecords = null;
        float TotalAbono = 0;
        float IvaAbono = 0;
        float TotalConIva = 0;

        try
        {
            TotalAbono = (RegFactura.Total * float.Parse(RegFactura.TipoDescuento.ToString()));
            IvaAbono = (TotalAbono * float.Parse(RegFactura.TipoIva.ToString()));
            TotalConIva = (TotalAbono + IvaAbono);
            Global.Sentencia =
            ("UPDATE Abonos SET COD_CLI =\'"
                        + RegFactura.Cod_Cli + ("\'," + (" TOTAL_FACTURA="
                        + RegFactura.Total + ("," + (" TOTAL_ABONO="
                        + TotalAbono + ("," + (" IVA="
                        + IvaAbono + ("," + (" TOTALCONIVA="
                        + TotalConIva + (" WHERE (NUM_FACTURA="
                        + RegFactura.Numero + ")"))))))))));
            Global.Conexion.Open(Global.strConn, Global.dbUser, Global.dbPass,0);
            Global.Conexion.Execute(Global.Sentencia,out numRecords,0);
        }
        catch (Exception)
        {
            MessageBox.Show("Error: \r\n", "Facturas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            throw;
        }
        finally
        {
            Global.Conexion.Close();
        }
    }
}