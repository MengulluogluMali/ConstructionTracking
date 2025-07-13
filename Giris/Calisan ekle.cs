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
    public partial class Calisan_ekle : Form
    {
        bool panel = false;
        private string[] santiyelere = { "İstanbul", "Ankara", "İzmir", "Bursa", "Adana", "Elazığ", "Hatay", "Adıyaman" };
        public Calisan_ekle()
        {
            InitializeComponent();
            santiyeler.DataSource = santiyelere;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Erişim Checkbox'ı
            panel = erisim.Checked;
            if (panel == false)
                panel1.Visible = false;
            else
                panel1.Visible = true;
        }

        private void santiyeler_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void calisanekle_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"{Adi.Text} Adlı çalışanı eklemek istediğine emin misin?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string ad = Adi.Text;
                    string soyadi = soyad.Text;
                    string egitimi = egitim.Text;
                    string tcs = tc.Text;
                    string tlf = cep.Text;
                    string alani = alan.Text;
                    string dt = dogumt.Text;
                    string kuladi = kadi.Text;
                    string parola = parol.Text;


                    string secim = santiyeler.SelectedValue.ToString();
                    string insertQuery = "INSERT INTO Workers_deneme(İsim,Soyisim,Egitim,Alan,Tc,Cep,[Doğum Tarihi],KullanıcıAdı,Parola) VALUES (@İsim,@Soyisim,@Egitim,@Alan,@Tc,@Cep,@Doğum,@KullaniciAdi,@Parola)";
                    using (OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = Database1.accdb"))
                    {
                        using (OleDbCommand kommut = new OleDbCommand(insertQuery, baglanti))
                        {
                            baglanti.Open();
                            // Add parameters with actual values
                            kommut.Parameters.AddWithValue("@Isim", ad);
                            kommut.Parameters.AddWithValue("@Soyisim", soyadi);
                            kommut.Parameters.AddWithValue("@Egitim", egitimi);
                            kommut.Parameters.AddWithValue("@Alan", alani);
                            kommut.Parameters.AddWithValue("@Tc", tcs);
                            kommut.Parameters.AddWithValue("@Cep", tlf);
                            kommut.Parameters.AddWithValue("@Doğum", dt);
                            kommut.Parameters.AddWithValue("@KullaniciAdi", kuladi);
                            kommut.Parameters.AddWithValue("@Parola", parola);


                            kommut.ExecuteNonQuery();
                            baglanti.Close();
                            MessageBox.Show("Aramız Hoşgeldin " + ad, "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Calisan_ekle.ActiveForm.Close();
                        }
                    }
                }
                catch (Exception b)
                {
                    MessageBox.Show("Bir Sorun oluştu " + b);
                }
            }

            if (result == DialogResult.Cancel)
            {
                MessageBox.Show("İşlem iptal edildi", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (result == DialogResult.No)
            {
                MessageBox.Show("İşlem iptal edildi", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

