using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Facturas_CSharp;
public static class LibreriaFacturasCompras {
    
    public static short ValidarNumeroFacturaCompras(string Numero, long Codigo) {
        Global.Sentencia = ("SELECT * FROM FacturasCompras WHERE " + ("NUM_FACTURA =\'" 
                    + (Numero + ("\' AND COD_PRO=" + Codigo))));
        try
        {
            Global.Conexion.Open(Global.strConn, Global.dbUser, Global.dbPass, 0); ;
            Global.Recordset.Open(Global.Sentencia, Global.Conexion, ADODB.CursorTypeEnum.adOpenStatic,
                ADODB.LockTypeEnum.adLockBatchOptimistic, (int)ADODB.CommandTypeEnum.adCmdText);

            Global.Recordset.MoveLast();
            if (Global.EsFacturaCompras)
            {
                if ((Global.Recordset.RecordCount > 0))
                {
                    return 1025;
                }
                else
                {
                    return 0;
                }
            }
            else return 0;
        }
        catch (System.Exception ex)
        {
            MessageBox.Show("Error " + ex.Message, "Facturas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return -1;
        }
        finally
        {
            Global.Recordset.Close();
            Global.Conexion.Close();		
        }
    }
    
    public static DialogResult CompruebaErrorFacturaCompras(short Error_Code) {
        DialogResult OK;
        if ((Error_Code == 1024)) {
            OK = MessageBox.Show("El número de Factura no puede ser cero", "Facturas", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
        else if ((Error_Code == 1025)) {
            OK = MessageBox.Show("Ya existe una Factura con ese número\r\n" + "¿Desea actualizarla?", 
                "Facturas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        else {
            OK = DialogResult.Abort;
        }
        return OK;
    }
    
    public static void AltaFacturaCompras(Tipos.tFacturaCompras RegFactura) {
        SqlCommand cmdAltaFacturaCompras = new SqlCommand("ALTA_FACTURA_COMPRAS", Global.DBConnection);
        try
        {
            cmdAltaFacturaCompras.Parameters.Add("@TipoIva", SqlDbType.Decimal);
            cmdAltaFacturaCompras.Parameters["@NIF"].Value = RegFactura.TipoIva;
            cmdAltaFacturaCompras.Parameters.Add("@Fecha", SqlDbType.DateTime);
            cmdAltaFacturaCompras.Parameters["@Fecha"].Value = RegFactura.Fecha;
            cmdAltaFacturaCompras.Parameters.Add("@Base", SqlDbType.NVarChar);
            cmdAltaFacturaCompras.Parameters["@Base"].Value = RegFactura.Total;
            cmdAltaFacturaCompras.Parameters.Add("@TotalIva", SqlDbType.Decimal);
            cmdAltaFacturaCompras.Parameters["@TotalIva"].Value = RegFactura.Iva;
            cmdAltaFacturaCompras.Parameters.Add("@TotalFactura", SqlDbType.Decimal);
            cmdAltaFacturaCompras.Parameters["@TotalFactura"].Value = RegFactura.TotalConIva;
            cmdAltaFacturaCompras.Parameters.Add("@NumFactura", SqlDbType.NVarChar);
            cmdAltaFacturaCompras.Parameters["@NumFactura"].Value = RegFactura.Numero;
            cmdAltaFacturaCompras.Parameters.Add("@CodCli", SqlDbType.Int);
            cmdAltaFacturaCompras.Parameters["@CodPro"].Value = RegFactura.Cod_Pro;
            cmdAltaFacturaCompras.ExecuteNonQuery();
            MessageBox.Show("Alta realizada con éxito", "Facturas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (System.Exception ex)
        {
            MessageBox.Show("Error al insertar cliente: " + ex.Message, "Facturas",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            cmdAltaFacturaCompras.Dispose();
            cmdAltaFacturaCompras = null;
        }
    }

    public static void ModificacionFacturaCompras(ref Tipos.tFacturaCompras RegFactura)
    {
        SqlCommand cmdUpdFacturaCompras = new SqlCommand("MODIFICACION_FACTURA_COMPRAS", Global.DBConnection);
        try
        {
            cmdUpdFacturaCompras.Parameters.Add("@CodPro", SqlDbType.BigInt);
            cmdUpdFacturaCompras.Parameters["@CodPro"].Value = RegFactura.Cod_Pro;
            cmdUpdFacturaCompras.Parameters.Add("@Fecha", SqlDbType.Date);
            cmdUpdFacturaCompras.Parameters["@Fecha"].Value = RegFactura.Fecha;
            cmdUpdFacturaCompras.Parameters.Add("@TotalIva", SqlDbType.Decimal);
            cmdUpdFacturaCompras.Parameters["@TotalIva"].Value = RegFactura.Iva;
            cmdUpdFacturaCompras.Parameters.Add("@TipoIva", SqlDbType.Decimal);
            cmdUpdFacturaCompras.Parameters["@TipoIva"].Value = RegFactura.TipoIva;
            cmdUpdFacturaCompras.Parameters.Add("@Base", SqlDbType.Decimal);
            cmdUpdFacturaCompras.Parameters["@Base"].Value = RegFactura.Total;
            cmdUpdFacturaCompras.Parameters.Add("@TotalFactura", SqlDbType.Decimal);
            cmdUpdFacturaCompras.Parameters["@TotalFactura"].Value = RegFactura.TotalConIva;
            cmdUpdFacturaCompras.Parameters.Add("@NumFactura", SqlDbType.NVarChar);
            cmdUpdFacturaCompras.Parameters["@NumFactura"].Value = RegFactura.Numero;
            cmdUpdFacturaCompras.ExecuteNonQuery();
            MessageBox.Show("Modificacion realizada con éxito", "Facturas", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        catch (System.Exception ex)
        {
            MessageBox.Show("Error al modificar factura: " + ex.Message, "Facturas", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        finally
        {
            cmdUpdFacturaCompras.Dispose();
            cmdUpdFacturaCompras = null;
        }
    }
}