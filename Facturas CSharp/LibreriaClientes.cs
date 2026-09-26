using Facturas_CSharp;
using System.Windows.Forms;
public static class LibreriaClientes {
    
    static short ValidarNombreCliente(ref string Nombre) {
        Global.Sentencia = ("SELECT * FROM Clientes WHERE NOMBRE =\'" 
                    + (Nombre + "\'"));
        Global.Conexion.Open(Global.strConn,Global.dbUser,Global.dbPass,0);
        Global.Recordset.Open(Global.Sentencia, Global.Conexion, ADODB.CursorTypeEnum.adOpenStatic, 
            ADODB.LockTypeEnum.adLockOptimistic, (int)ADODB.CommandTypeEnum.adCmdText);
        Global.Recordset.MoveLast();
        if (Global.Alta_Cliente) {
            if ((Global.Recordset.RecordCount > 0)) {
                Global.Recordset.Close();
                Global.Conexion.Close();
                return 1010;
            }
            else
            {
                Global.Recordset.Close();
                Global.Conexion.Close();
                return 0;
            }
        }
        else if ((Global.Recordset.RecordCount == 0)) {
            Global.Recordset.Close();
            Global.Conexion.Close();
            return 1011;
        }
        else {
            Global.Recordset.Close();
            Global.Conexion.Close();
            return 0;
        }
    }
    
    public static void MostrarError(ref short Error_Code) {
        if ((Error_Code == 1011)) {
            MessageBox.Show("La longitud del código postal debe ser cinco","Facturas",MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
        else if ((Error_Code == 1013)) {
            MessageBox.Show("El código postal debe ser numérico", "Facturas", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
        else if ((Error_Code == 1014)) {
            MessageBox.Show("La dirección no puede estar en blanco", "Facturas", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
        else if ((Error_Code == 1015)) {
            MessageBox.Show("La localidad no puede estar en blanco", "Facturas", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
        else if ((Error_Code == 1016)) {
            MessageBox.Show("El NIF no puede estar en blanco", "Facturas", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
        else if ((Error_Code == 1017)) {
            MessageBox.Show("El nombre no puede estar en blanco", "Facturas", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
        else if ((Error_Code == 1018)) {
            MessageBox.Show("El teléfono debe ser numérico", "Facturas", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
    }
    
    
    
    
}