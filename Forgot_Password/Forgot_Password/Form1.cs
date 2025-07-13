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



namespace Forgot_Password
{
   
    public partial class Forgotpsswrd : Form
    {
        OleDbConnection connect = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Workers_be.accdb");
        public Forgotpsswrd()
        {
            InitializeComponent();
        }

        protected void Mail_TextChanged(object sender, EventArgs e)
        {
            

        }

        protected void K_adi_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void Telefon_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tel = Telefon.Text;
            string Kadi = K_adi.Text;
            string yenisifre = Newpassword.Text;
            string yenisifre2 = Newpassword2.Text;

            int affectedRows = 0;

            using (OleDbConnection connect = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Workers_be.accdb"))
            {
                connect.Open();

                using (OleDbCommand updateCommand = new OleDbCommand("UPDATE Workers SET Parola = @Sifre WHERE KullanıcıAdı = @Kadi AND Cep = @Tel", connect))
                {
                    updateCommand.Parameters.AddWithValue("@Sifre", yenisifre2);
                    updateCommand.Parameters.AddWithValue("@Kadi", Kadi);
                    updateCommand.Parameters.AddWithValue("@Tel", tel);

                    using (OleDbCommand cmd = new OleDbCommand("SELECT * FROM Workers WHERE KullanıcıAdı = @Kadi AND Cep = @Tel", connect))
                    {
                        cmd.Parameters.AddWithValue("@Kadi", Kadi);
                        cmd.Parameters.AddWithValue("@Tel", tel);

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (yenisifre == yenisifre2)
                                {
                                    // UPDATE işlemi gerçekleştirilir
                                    affectedRows = updateCommand.ExecuteNonQuery();
                                    if (affectedRows > 0)
                                    {
                                        MessageBox.Show("Parolanız başarıyla değişti", "Parola değiştirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Şifre güncellenirken bir hata oluştu", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Parolalarınız uyuşmuyor","Hata!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Kullanıcı adını hatalı girdiniz veya kayıtlı değilsiniz.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }

            // affectedRows değerini kontrol edebilirsiniz
         

            #region
            #region
            //string tel = Telefon.Text;
            //string Kadi = K_adi.Text;
            //string mail = Mail.Text;
            //string yenisifre = Newpassword.Text;
            //string yenisifre2 = Newpassword2.Text;

            //SqlCommand updateCommand = new SqlCommand("UPDATE Users_Table SET Sifre = @Sifre WHERE K_adi = @Kadi AND Telefon_no = @Tel", connect);
            //updateCommand.Parameters.AddWithValue("@Sifre", yenisifre2);
            //updateCommand.Parameters.AddWithValue("@Kadi", Kadi);
            //updateCommand.Parameters.AddWithValue("@Tel", tel);

            //connect.Open();
            //SqlCommand cmd = new SqlCommand("SELECT * FROM Users_Table", connect);
            //SqlDataReader reader = cmd.ExecuteReader();
            //bool found = false;

            //while (reader.Read())
            //{
            //    if (Kadi == reader["K_adi"].ToString())
            //    {
            //        if (tel == reader["Telefon_no"].ToString())
            //        {
            //            if (mail == reader["Mail_adresi"].ToString())
            //            {
            //                if (yenisifre == yenisifre2)
            //                {
            //                    found = true;
            //                    break;
            //                }
            //                else
            //                {
            //                    MessageBox.Show("Parolalarınız uyuşmuyor");
            //                    connect.Close();
            //                    return;
            //                }
            //            }
            //            else
            //            {
            //                MessageBox.Show("Mail adresiniz hatalı");
            //                connect.Close();
            //                return;
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Telefon numaranız hatalı");
            //            connect.Close();
            //            return;
            //        }
            //    }
            //}

            //connect.Close();
            #endregion
            //string tel = Telefon.Text;
            //string Kadi = K_adi.Text;

            //string yenisifre = Newpassword.Text;
            //string yenisifre2 = Newpassword2.Text;
            //OleDbCommand updateCommand = new OleDbCommand("UPDATE Workers SET Parola = @Sifre WHERE KullanıcıAdı = @Kadi AND Cep = @Tel", connect);
            //updateCommand.Parameters.AddWithValue("@Parola", Newpassword.Text);
            //updateCommand.Parameters.AddWithValue("@KullanıcıAdı", Newpassword2.Text);
            //updateCommand.Parameters.AddWithValue("@Cep", Telefon.Text);

            //connect.Open();

            //OleDbCommand cmd = new OleDbCommand("SELECT * FROM Workers", connect);
            //OleDbDataReader reader = cmd.ExecuteReader();
            //bool found = false;

            //while (reader.Read())
            //{
            //    if (Kadi == reader["KullanıcıAdı"].ToString())
            //    {
            //        if (tel == reader["Cep"].ToString())
            //        {


            //           if (yenisifre == yenisifre2)
            //           {
            //              found = true;
            //              break;
            //              }
            //              else
            //              {
            //               MessageBox.Show("Parolalarınız uyuşmuyor");
            //               connect.Close();
            //               return;
            //              }



            //        }
            //        else
            //        {
            //            MessageBox.Show("Telefon numaranız hatalı");
            //            connect.Close();
            //            return;
            //        }
            //    }
            //}

            //connect.Close();
            //if (found)
            //{
            //    using (OleDbConnection updateConnect = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Workers_be.accdb"))
            //    {
            //        updateConnect.Open();

            //        int affectedRows;


            //        affectedRows = updateCommand.ExecuteNonQuery();

            //        if (affectedRows > 0)
            //        {
            //            MessageBox.Show("Parolanız başarıyla değişti");
            //            this.Close();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Şifre güncellenirken bir hata oluştu");
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Kullanıcı adını hatalı girdiniz veya kayıtlı değilsiniz.");
            //}


            #region
            //if (found)
            //    {
            //        connect.Open();
            //        int affectedRows = updateCommand.ExecuteNonQuery();
            //        connect.Close();

            //        if (affectedRows > 0)
            //        {
            //            MessageBox.Show("Parolanız başarıyla değişti");
            //            this.Close();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Şifre güncellenirken bir hata oluştu");
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Kullanıcı adını hatalı girdiniz veya kayıtlı değilsiniz.");
            //    }
            #endregion

            /*    String tel = Telefon.Text;
                String Kadi = K_adi.Text;
                String mail = Mail.Text;
                String yenisifre = Newpassword.Text;
                String yenisifre2 = Newpassword2.Text;

                SqlCommand updateCommand = new SqlCommand("UPDATE Users_Table SET Sifre = @Sifre  WHERE K_adi = @Kadi AND Telefon_no = @tel", connect);
                connect.Open();
                SqlCommand cmd = new SqlCommand("Select * from Users_Table", connect);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (Kadi == reader["K_adi"].ToString())
                    { 
                        if (tel == reader["Telefon_no"].ToString())
                        {
                            if (mail == reader["Mail_adresi"].ToString())
                            {
                                if (yenisifre == yenisifre2)
                                {
                                    updateCommand.Parameters.AddWithValue("@Sifre", yenisifre2);

                                    /* int affectedRows = updateCommand.ExecuteNonQuery();
                                     if (affectedRows > 0)
                                     {
                                         MessageBox.Show("Şifre güncellendi");
                                     }
                                    MessageBox.Show("Parolanız başarıyla değişti");
                                    Application.Exit();


                                }
                                else
                                {
                                    MessageBox.Show("Parolalarınız uyuşmuyor");
                                }
                            }
                            else
                            {
                               MessageBox.Show("Mail adresiniz hatalı");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Telefon numaranız hatalı");
                        }
                    }
                    else
                    {
                       // kullanıcı adı hatalı
                       MessageBox.Show(" Kullanıcı adını hatalı girdiniz veya kayıtlı değilsiniz.");
                    }
                }
                connect.Close();*/
            #endregion

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
