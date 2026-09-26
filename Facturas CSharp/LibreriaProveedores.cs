using Facturas_CSharp;
using System.Data.SqlClient;
class LibreriaProveedores {

    /*
    private short ValidarCodigoProveedor(ref int Codigo)
    {
        if ((Codigo == double.Parse("")))
        {
            return 1007;
        }
        else if (!IsNumeric(Codigo))
        {
            return 1008;
        }
        else if ((Codigo.Length != 2))
        {
            return 1009;
        }
        else
        {
            Global.Sentencia = ("SELECT * FROM Proveedores WHERE COD_CLI =" + Codigo);
            Global.Conexion.Open();
            Global.Recordset.Open(Sentencia, Conexion, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockBatchOptimistic, ADODB.CommandTypeEnum.adCmdText);
            if (!Global.Recordset.EOF)
            {
                Global.Recordset.MoveLast();
            }
            if (Alta_Proveedor)
            {
                if ((Recordset.RecordCount > 0))
                {
                    ValidarCodigoProveedor = 1010;
                }
            }
            else if ((Recordset.RecordCount == 0))
            {
                ValidarCodigoProveedor = 1011;
            }
            else
            {
                ValidarCodigoProveedor = 0;
            }
            Recordset.Close();
            Conexion.Close();
        }
    }
    */   
    
    

}