using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Giris
{
    public partial class Hakediş_Güncelle : Form
    {
        int rowIndex = 0;
        int i = 0;
        int colmnIndex;
        private string[] asnsor = { "Asansör_1", "Asansör_2", "Asansör_3", "Asansör_4", "Asansör_5", "Asansör_6", "Asansör_7", "Asansör_8" };
        static string baglantı = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = Database1.accdb";
        OleDbConnection connection = new OleDbConnection(baglantı);
       

        public void Grid_hkds(string tablo)
        {
            string query = "SELECT * FROM [" + tablo + "]";
            OleDbDataReader reader = null;

            OleDbCommand veri = new OleDbCommand(query, connection);
            try
            {
                
                reader = veri.ExecuteReader();
                while (reader.Read())
                {

                    Hakedis_grid.Rows.Add(
                        reader["Kod"].ToString(),
                        reader["İslem Adi"].ToString(),
                        reader["Muhendis Onay"].ToString(),
                        reader["Hakedis No"].ToString(),
                        reader["Hakedis Yuzde"].ToString(),
                        reader["Hakedis Tutar"].ToString());
                    

                }
         

                Hakedis_grid.Columns[2].ReadOnly = true;
               Hakedis_grid.Columns[0].ReadOnly = true;
               Hakedis_grid.Columns[1].ReadOnly = true;
               Hakedis_grid.Columns[4].ReadOnly = true;
                
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata!" + e.Message);
            }

        }
      private void UpdateHno(string tablo, string hno, string kod)
        {
            try
            {

                
                string qry = "Update " + tablo + " SET [Hakedis No] =" + hno + " WHERE Kod =" + kod;
                using (OleDbCommand command = new OleDbCommand(qry, connection))
                {
                    command.Parameters.AddWithValue("@[Hakedis No]", hno);
                    command.Parameters.AddWithValue("@tablo", tablo);
                    command.Parameters.AddWithValue("@Kod", kod);
                    command.ExecuteNonQuery();
                 
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
            }
            
        }
       private void UpdateHttr(string tablo, string httr, string kod)
        {
            try
            {
               
                string qry = "UPDATE " + tablo + " SET [Hakedis Tutar] = @httr WHERE Kod = "+kod;

                using (OleDbCommand command= new OleDbCommand(qry, connection))
                {
                    command.Parameters.AddWithValue("@[Hakedis Tutar]", httr);
                    command.Parameters.AddWithValue("@tablo", tablo);
                    command.Parameters.AddWithValue("@Kod", kod);
                    command.ExecuteNonQuery();
                  
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
            }
        }



        public Hakediş_Güncelle()
        {
            InitializeComponent();
            hkds_ansr_cmb.DataSource = asnsor;
        }

        private void Hakedis_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Gizli_hkds_btn.PerformClick();
        }

        private void Gizli_hkds_btn_Click(object sender, EventArgs e)
        {
            
            
            if (colmnIndex >4)
            {
                UpdateHttr(hkds_ansr_cmb.SelectedItem.ToString(), Hakedis_grid.Rows[rowIndex].Cells[5].Value.ToString(), Hakedis_grid.Rows[rowIndex].Cells[0].Value.ToString());
            }
            else
            {
                UpdateHno(hkds_ansr_cmb.SelectedItem.ToString(), Hakedis_grid.Rows[rowIndex].Cells[3].Value.ToString(), Hakedis_grid.Rows[rowIndex].Cells[0].Value.ToString());
            }
        }

        private void Hakediş_Güncelle_Load(object sender, EventArgs e)
        {
            connection.Open();
            Hakedis_grid.Columns.Add("Column_Kod", "Kod");         
            Hakedis_grid.Columns.Add("Column_İslem Adi", "İşlem adı");
            Hakedis_grid.Columns.Add("Column_Muhendis Onay", "Mühendis Onay");
            Hakedis_grid.Columns.Add("Column_Hakedis No", "Hakediş No");
            Hakedis_grid.Columns.Add("Column_Hakedis Yuzde", "Hakediş Yüzde");
            Hakedis_grid.Columns.Add("Column_Hakedis Tutar", "Hakediş tutar");
            Grid_hkds(hkds_ansr_cmb.SelectedItem.ToString());
        }

        private void hkds_ansr_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (i > 0)
            {
                Hakedis_grid.Rows.Clear();
                Grid_hkds(hkds_ansr_cmb.SelectedItem.ToString());

            }
            i++;
        }

        private void Hakedis_grid_MouseLeave(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Close();
            Hakediş_Güncelle.ActiveForm.Close();
        }

        private void gizli_btn_2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in Hakedis_grid.SelectedCells)
            {
                // Hücrenin satır  indeksini al
                rowIndex = cell.RowIndex;
                // Sütun indeksini al
                colmnIndex = cell.ColumnIndex;
            }
        }

        private void Hakedis_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gizli_btn_2.PerformClick();
        }
    }
}
