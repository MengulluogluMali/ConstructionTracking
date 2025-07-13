using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giris
{
    public partial class Sipariş_onay : Form
    {
       


        //public void GridYukle(string sehir, string tablo)
        //{

        //    string baglantı = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = Database1.accdb";
        //    OleDbConnection connection = new OleDbConnection(baglantı);

        //    string query = "SELECT * FROM Asansör_Takip_Kopyası";
        //    OleDbDataReader reader = null;

        //    OleDbCommand veri = new OleDbCommand(query, connection);
        //    try
        //    {
        //        connection.Open();
        //        reader = veri.ExecuteReader();
        //        while (reader.Read())
        //        {

        //            siparisDataGrid.Rows.Add(
        //                reader["Kod"].ToString(),
        //                reader["İslem Adi"].ToString(),
        //                reader["Muhendis Onay"].ToString(),
        //                reader["Hakedis No"].ToString(),
        //                reader["Hakedis Yuzde"].ToString(),
        //                reader["Hakedis Tutar"].ToString());

        //        }
        //        connection.Close();
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show("Hata!");
        //    }

        //    finally
        //    {
        //        //reader.Close();
        //        //connection.Close();
        //    }}





        


        //siparisDataGrid.Columns.Add("Column_Kod", "Kod");
        //    siparisDataGrid.Columns.Add("Column_İslem Adi", "İşlem adı");
        //    siparisDataGrid.Columns.Add("Column_Muhendis Onay", "Mühendis Onay");
        //    siparisDataGrid.Columns.Add("Column_Hakedis No", "Hakediş No");
        //    siparisDataGrid.Columns.Add("Column_Hakedis Yuzde", "Hakediş Yüzde");
        //    siparisDataGrid.Columns.Add("Column_Hakedis Tutar", "Hakediş tutar");


        //    GridYukle("Workers", "Asansör Takip");




        public Sipariş_onay()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Sipariş_onay_Load(object sender, EventArgs e)
        {

        }
    }
}
