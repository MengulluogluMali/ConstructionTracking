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
    public partial class Çalışan_Listesi : Form
    {
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = Database1.accdb");
        public void GridYuk(string tablo)
        {
            string query = "SELECT * FROM Workers_deneme";
            OleDbDataReader reader = null;

            OleDbCommand veri = new OleDbCommand(query, connection);
            try
            {
                connection.Open();
                reader = veri.ExecuteReader();
                while (reader.Read())
                {

                    Çalışan_dtgrd.Rows.Add(
                        reader["ID"].ToString(),
                        reader["İsim"].ToString(),
                        reader["Soyisim"].ToString(),
                        reader["Egitim"].ToString(),
                        reader["Alan"].ToString(),
                        reader["Tc"].ToString(),
                        reader["Cep"].ToString(),
                        reader["Doğum Tarihi"].ToString(),
                        reader["KullanıcıAdı"].ToString());



                }

                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata!" + e.Message);
            }

        }

        public Çalışan_Listesi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ÇALIŞAN EKLEME EKRANINA YÖNLENDİRİR ÇALIŞAN EKLE BUTONU
            Calisan_ekle nsn = new Calisan_ekle();

            Çalışan_Listesi.ActiveForm.Close();
            nsn.Show();

        }

        private void Çalışan_Listesi_Load(object sender, EventArgs e)
        {
            Çalışan_dtgrd.Columns.Add("Column_ID", "ID");
            Çalışan_dtgrd.Columns.Add("Column_İsim", "İsim");
            Çalışan_dtgrd.Columns.Add("Column_Egitim", "Egitim");
            Çalışan_dtgrd.Columns.Add("Column_Alan", "Alan");
            Çalışan_dtgrd.Columns.Add("Column_Tc", "Tc");
            Çalışan_dtgrd.Columns.Add("Column_Cep", "Cep");
            Çalışan_dtgrd.Columns.Add("Column_Doğum Tarihi", "Doğum Tarihi");
            Çalışan_dtgrd.Columns.Add("Column_KullanıcıAdı", "KullanıcıAdı");
            
            GridYuk("Worker_deneme");

            Çalışan_dtgrd.ReadOnly = true;
        }

        private void çalışan_sil_Click(object sender, EventArgs e)
        {
            Çalışan_Sil silnsn = new Çalışan_Sil();
            silnsn.Show();
        }
    }
}
