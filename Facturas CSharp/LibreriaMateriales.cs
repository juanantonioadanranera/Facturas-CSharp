using Facturas_CSharp;
using System.Windows.Forms;
using VB = Microsoft.VisualBasic;
using System.Data.SqlClient;
using System.Data;
public static class LibreriaMateriales {


    public static void CompruebaError(ref short Error_Code)
    {
        if ((Error_Code == 1001))
        {
            MessageBox.Show("La descripción no puede estar en blanco", "Facturas", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
        else if ((Error_Code == 1002))
        {
            MessageBox.Show("El precio no puede estar en blanco", "Facturas", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
        else if ((Error_Code == 1003))
        {
            MessageBox.Show("El precio debe de ser numérico", "Facturas", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
    }

    

}