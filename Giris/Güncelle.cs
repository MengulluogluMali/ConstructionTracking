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
    public partial class Güncelle : Form
    {
        int i = 0;
        static string baglantı = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = Database1.accdb";
        OleDbConnection connection = new OleDbConnection(baglantı);

        public void GridYukle(string tablo)
        {
            string query = "SELECT * FROM [" + tablo + "]";
            OleDbDataReader reader = null;

            OleDbCommand veri = new OleDbCommand(query, connection);
            try
            {
                connection.Open();
                reader = veri.ExecuteReader();
                while (reader.Read())
                {

                    Asansör_grid.Rows.Add(
                        reader["Kod"].ToString(),
                        reader["İslem Adi"].ToString(),
                        reader["Muhendis Onay"].ToString(),
                        reader["Hakedis No"].ToString(),
                        reader["Hakedis Yuzde"].ToString(),
                        reader["Hakedis Tutar"].ToString());


                }

                connection.Close();
                Asansör_grid.Columns[2].ReadOnly = true;
                Asansör_grid.Columns[0].ReadOnly = true;
                Asansör_grid.Columns[1].ReadOnly = true;
             
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata!" + e.Message);
            }

        }

        private string[] asnsor = { "Asansör_1", "Asansör_2", "Asansör_3", "Asansör_4", "Asansör_5", "Asansör_6", "Asansör_7", "Asansör_8" };
        public Güncelle()
        {
            InitializeComponent();
            Asansor_cmb.DataSource = asnsor;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (i > 0)
            {
                Asansör_grid.Rows.Clear();
                GridYukle(Asansor_cmb.SelectedItem.ToString());
               
            }
            i++;


        }

        private void Asansör_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            


        }

        private void Güncelle_Load(object sender, EventArgs e)
        {

            Asansör_grid.Columns.Add("Column_Kod", "Kod");
            Asansör_grid.Columns.Add("Column_İslem Adi", "İşlem adı");
            Asansör_grid.Columns.Add("Column_Muhendis Onay", "Mühendis Onay");
            Asansör_grid.Columns.Add("Column_Hakedis No", "Hakediş No");
            Asansör_grid.Columns.Add("Column_Hakedis Yuzde", "Hakediş Yüzde");
            Asansör_grid.Columns.Add("Column_Hakedis Tutar", "Hakediş tutar");
            GridYukle(Asansor_cmb.SelectedItem.ToString());

        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
      //      int selectedRowIndex = Asansör_grid.SelectedRows[0].Index;


    //        string kod = Asansör_grid.Rows[selectedRowIndex].Cells["Column_Kod"].Value.ToString();           
     //       UpdateVeritabani(Asansor_cmb.SelectedItem.ToString(), kod);
            ActiveForm.Hide();



        }
        private void UpdateOnay(string tablo,string onay, string kod)
        {
            try
            {
                connection.Open();
                string qry = "Update " + tablo + " SET [Muhendis Onay]=" + onay + " WHERE Kod =" + kod;
                using (OleDbCommand command = new OleDbCommand(qry, connection))
                {
                    command.Parameters.AddWithValue("@[Muhendis Onay]",onay);
                    command.Parameters.AddWithValue("@tablo", tablo);
                    command.Parameters.AddWithValue("@Kod", kod);
                    command.ExecuteNonQuery();
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        private void UpdateHno(string tablo, string hno, string kod)
        {
            try
            {
                connection.Open();
                string qry = "Update " + tablo + " SET [Hakedis No]=" + hno + " WHERE Kod =" + kod;
                using (OleDbCommand command = new OleDbCommand(qry, connection))
                {
                    command.Parameters.AddWithValue("@[Hakedis No]", hno);
                    command.Parameters.AddWithValue("@tablo", tablo);
                    command.Parameters.AddWithValue("@Kod", kod);
                    command.ExecuteNonQuery();
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }



        private void Save_con_btn_Click(object sender, EventArgs e)
        {
            int rowIndex = 0;
            foreach (DataGridViewCell cell in Asansör_grid.SelectedCells)
            {
                // Hücrenin satır  indeksini al
                rowIndex = cell.RowIndex;
                
            }
            UpdateHno(Asansor_cmb.SelectedItem.ToString(),Asansör_grid.Rows[rowIndex].Cells[3].Value.ToString(), Asansör_grid.Rows[rowIndex].Cells[0].Value.ToString());

            //int selectedCell ;


            //string kod = Asansör_grid.Rows[selectedCell].Cells["Column_Kod"].Value.ToString();

            //Asansör_grid.Rows[selectedCell].Cells["Column_Muhendis Onay"].Value = true;
            //UpdateVeritabani(Asansor_cmb.SelectedItem.ToString(),kod);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Gizli_btn_Click(object sender, EventArgs e)
        {
            int rowIndex = 0;
            int columnIndex = 2;
            foreach (DataGridViewCell cell in Asansör_grid.SelectedCells)
            {
                // Hücrenin satır  indeksini al
                rowIndex = cell.RowIndex;

            }

            if (Asansör_grid.Rows[rowIndex].Cells[columnIndex].Value.Equals("red"))
            {
                Asansör_grid.Rows[rowIndex].Cells[columnIndex].Value = "onay";
                UpdateOnay(Asansor_cmb.SelectedItem.ToString(), "onay", Asansör_grid.Rows[rowIndex].Cells[0].Value.ToString());

            }
            else
            {
                Asansör_grid.Rows[rowIndex].Cells[columnIndex].Value = "red";
                UpdateOnay(Asansor_cmb.SelectedItem.ToString(), "red", Asansör_grid.Rows[rowIndex].Cells[0].Value.ToString());
                // UpdateVeritabani(Asansor_cmb.SelectedItem.ToString(), "red", Asansör_grid.Rows[rowIndex].Cells[5].Value.ToString());
                
            }
        }
    }
}
