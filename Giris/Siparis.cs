using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  System.Data.OleDb;
using Workers;

namespace Giris
{
    public partial class Siparis : Form
    {
        string yazmaQuery = "INSERT INTO Sipariş_Al ([Sipariş Veren],Ürün,Miktar,[Sipariş Tarihi],Açıklama) VALUES(@Sahip, @ürün, @miktar, @tarih, @açıklama)";
        bool check = false;
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = Database1.accdb");
        
        

        public void GridYukle(string sehir,string tablo)
        {

            string baglantı = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = Database1.accdb";
            OleDbConnection connection = new OleDbConnection(baglantı);
            
            string query = "SELECT * FROM Sipariş_Seçme";
            
            OleDbDataReader reader = null;
            
            OleDbCommand veri = new OleDbCommand(query, connection);                       
            try
            {
                connection.Open();
                reader = veri.ExecuteReader();
                while (reader.Read()) {

                    siparisDataGrid.Rows.Add(
                        reader["Kod"].ToString(),
                        reader["Ürün"].ToString());
                        
                
                }
              connection.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show("Hata!");
            }

            finally {
                //reader.Close();
                //connection.Close();
            }





        }


        public Siparis()
        {
            InitializeComponent();
            panel1.Visible = false;

        }

        private void Siparis_Load(object sender, EventArgs e)
        {
            siparisDataGrid.Columns.Add("Column_Kod","Kod");
            siparisDataGrid.Columns.Add("Column_Ürün","Ürün");
           
           


            GridYukle("Workers","Asansör Takip");
            
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void siparisDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Siparis_Load_1(object sender, EventArgs e)
        {
            siparisDataGrid.Columns.Add("Column_Kod", "Kod");
            siparisDataGrid.Columns.Add("Column_Ürün", "Ürün");
            siparisDataGrid.AutoResizeColumns();




            GridYukle("Workers", "Asansör Takip");
        }

        private void Siparis_btn_Click(object sender, EventArgs e)
        {
            baglan.Open();
            OleDbCommand inkomut = new OleDbCommand(yazmaQuery,baglan);
            
            int rowIndex = 0;
            foreach (DataGridViewCell cell in siparisDataGrid.SelectedCells)
            {
                // Hücrenin satır  indeksini al
                rowIndex = cell.RowIndex;

            }
            string ID = siparisDataGrid.Rows[rowIndex].Cells[0].Value.ToString();

          //  string yazmaQuery = "INSERT INTO Sipariş_Al ([Sipariş Veren],Ürün,Miktar,[Sipariş Tarihi],Açıklama),VALUES(@Sahip, @ürün, @miktar, @tarih, @açıklama)";
            inkomut.Parameters.AddWithValue("@ürün", siparisDataGrid.Rows[rowIndex].Cells[1].Value.ToString());
            inkomut.Parameters.AddWithValue("@Sahip", SiparişVeren.Text);
            inkomut.Parameters.AddWithValue("@miktar", mktr.Text);
            inkomut.Parameters.AddWithValue("tarih", DateTime.Now);
            inkomut.Parameters.AddWithValue("@açıklama", not_txtbox.Text);
            inkomut.ExecuteNonQuery();
            baglan.Close();
            



        }

        private void Not_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            check = Not_checkbox.Checked;
            if (check == false)
                panel1.Visible = false;
            else
                panel1.Visible = true;
        }
            private void Not_txtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
