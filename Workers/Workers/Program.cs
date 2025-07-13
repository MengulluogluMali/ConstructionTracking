using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;


namespace Workers
{
     
    public class Methods
    {

        
      public static void Connect()
        {
            try
            {
                string baglantı = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\Monster\\Documents\\Workers.accdb"; 
                OleDbConnection connection = new OleDbConnection(baglantı);
                connection.Open();
                return;
            }
            catch(Exception e) {

                MessageBox.Show("Veritabanına bağlanırken bir hata oluştu!", "Hata!" , MessageBoxButtons.OK,MessageBoxIcon.Error);
                
            }
            
        }
        
       
      public static void Disconnect() 
        {
            string baglantı = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\Monster\\Documents\\Workers.accdb";
            OleDbConnection connection = new OleDbConnection(baglantı);
            connection.Close();
            return;
        }
        
    }
}
