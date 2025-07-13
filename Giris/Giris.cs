using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Workers;
using Forgot_Password;
using Giris.Properties;
using System.Data.OleDb;

namespace Giris
{
        

    public partial class Giris : Form
    {
        string baglantı_cümlesi = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = Database1.accdb";
        string  isim;
       public static string Up_isim;
        bool check = false;
        

        public Giris()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //giriş butonu
            OleDbConnection connection = new OleDbConnection(baglantı_cümlesi);

            try
                {

                    connection.Open();
                  
                }
                catch (Exception ee)
                {

                    MessageBox.Show("Veritabanına bağlanırken bir hata oluştu!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                 Methods metot = new Methods();
                 string kAdi = kullaniciAdi.Text;
                 string parol = parola.Text;
          //       isim = metot.Name(kAdi,parol);
           //      Up_isim  = isim.ToUpper();
            string usern = "SELECT * FROM Workers_deneme";
          //  string psswd = "SELECT Parola FROM Workers WHERE Parola = '{parol}'";

          
          if(metot.Query(usern, kAdi, parol))
            {
                MessageBox.Show("Hoşgeldiniz Sn.  " + isim,"Hoşgeldiniz");
                Giris.ActiveForm.Hide();
                Ana_Sayfa nesne = new Ana_Sayfa();
                connection.Close();
              
                
                
                nesne.Show();
                    

                

                
            }

            else
            {
                MessageBox.Show("Parola veya şifreniz yanlış. Lütfen tekrar deneyiniz.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }

            

            
            
           
            
            
        }

        private void Şifreyi_göster_CheckedChanged(object sender, EventArgs e)
        {
            Şifreyi_göster.BackgroundImage = Resources.pngwing_com_1;
            Şifreyi_göster.BackgroundImageLayout = ImageLayout.Stretch;
            check = Şifreyi_göster.Checked;
            if (check == false)
            {
                Şifreyi_göster.BackgroundImage = Resources.pngwing_com;
                Şifreyi_göster.BackgroundImageLayout = ImageLayout.Stretch;

                parola.UseSystemPasswordChar = check;
                
            }
            else
            {
                Şifreyi_göster.BackgroundImage = Resources.pngwing_com_1;
                Şifreyi_göster.BackgroundImageLayout = ImageLayout.Stretch;
                parola.UseSystemPasswordChar = check;
                
            }
        }
        

        private void Unuttum_Click(object sender, EventArgs e)
        {
            Forgotpsswrd nesne = new Forgotpsswrd();
            ActiveForm.Hide();
            nesne.Show();
        }
    }
}
