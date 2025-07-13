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
using System.Threading;

namespace Giris
{
    public partial class Şantiye : Form
    {
        int i = 0;
        int j = 0;
        static string baglantı = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = Database1.accdb";
        OleDbConnection connection = new OleDbConnection(baglantı);


        public void parla()
        {
            while (j<10000)
            {
                gelisim_pBar.Value++;
                gelisim_pBar.Value--;
                j++;
                Thread.Sleep(1000);
                

            }
        }
        public void adımla()
        {
            try
            {
                connection.Open();
                string pbquery = "SELECT [Muhendis Onay] FROM [" + Asansör_cmb.SelectedItem.ToString() + "]";
                OleDbCommand onaycmd = new OleDbCommand(pbquery, connection);
                OleDbDataReader onayoku = onaycmd.ExecuteReader();
                while (onayoku.Read())
                {
                    string check = onayoku["Muhendis Onay"].ToString();
                    if (check.Equals("onay"))
                    {
                        gelisim_pBar.PerformStep();
                    }


                }
                connection.Close();


            }
            catch (Exception eeee)
            {
                MessageBox.Show("Hata:  " + eeee);
            }

        }

        public void GridYukl(string tablo)
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

                    AsnsorDurum_grid.Rows.Add(
                        reader["Kod"].ToString(),
                        reader["İslem Adi"].ToString(),
                        reader["Muhendis Onay"].ToString(),
                        reader["Hakedis No"].ToString(),
                        reader["Hakedis Yuzde"].ToString(),
                        reader["Hakedis Tutar"].ToString());


                }

                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata!" + e.Message);
            }

        }
        private string[] asnsor = { "Asansör_1", "Asansör_2", "Asansör_3", "Asansör_4", "Asansör_5", "Asansör_6", "Asansör_7", "Asansör_8" };
        public Şantiye()
        {
            InitializeComponent();
            Asansör_cmb.DataSource = asnsor;
        }

        private void Şantiye_Load(object sender, EventArgs e)
        {
          




            AsnsorDurum_grid.Columns.Add("Column_Kod", "Kod");
            AsnsorDurum_grid.Columns.Add("Column_İslem Adi", "İşlem adı");
            AsnsorDurum_grid.Columns.Add("Column_Muhendis Onay", "Mühendis Onay");
            AsnsorDurum_grid.Columns.Add("Column_Hakedis No", "Hakediş No");
            AsnsorDurum_grid.Columns.Add("Column_Hakedis Yuzde", "Hakediş Yüzde");
            AsnsorDurum_grid.Columns.Add("Column_Hakedis Tutar", "Hakediş tutar");
            GridYukl(Asansör_cmb.SelectedItem.ToString());
            AsnsorDurum_grid.ReadOnly = true;
            adımla();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Asansör_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (i > 0)
            {
                AsnsorDurum_grid.Rows.Clear();
                GridYukl(Asansör_cmb.SelectedItem.ToString());   
                gelisim_pBar.Value = 0;
                adımla();
            }
            i++;
        }

        private void gelisim_pBar_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            parla();
        }
    }
}
