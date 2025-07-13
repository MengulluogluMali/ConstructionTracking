using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.ComponentModel;
using Giris;


namespace Workers
{

    public class Methods
    {
      
        string baglantı = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = Database1.accdb";
        public void Connect()
        {
            try
            {
                string baglantı = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = Database1.accdb";
                OleDbConnection connection = new OleDbConnection(baglantı);
                connection.Open();
                return;
            }
            catch (Exception e)
            {

                MessageBox.Show("Veritabanına bağlanırken bir hata oluştu!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }


        public void Disconnect()
        {
            string baglantı = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = Database1.accdb";
            OleDbConnection connection = new OleDbConnection(baglantı);
            connection.Close();
            return;
        }

        public bool Query(string sorgu, string kadi, string pswrd)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(baglantı))
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(sorgu, connection))
                    {
                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            try
                            {
                                while (reader.Read())
                                {
                                    string dbKadi = reader["KullanıcıAdı"].ToString();
                                    string dbPswrd = reader["Parola"].ToString();

                                    if (kadi == dbKadi && pswrd == dbPswrd)
                                    {
                                        return true;
                                    }
                                }

                                return false; // Kullanıcı bulunamadı
                            }
                            catch (Exception e)
                            {
                                // Hata ele alma
                                Console.WriteLine("Hata: " + e.Message);
                                return false;
                            }
                        }
                    }
                }
            }
            catch (Exception e) {
                return false;
            }
            
        }

        public string Name(string kullaniciAdi, string sifre)
        {
           
            string query = $"SELECT İsim FROM Workers_deneme WHERE KullanıcıAdı = '{kullaniciAdi}' AND Parola = '{sifre}'";

            using (OleDbConnection connection = new OleDbConnection(baglantı))
            {
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    connection.Open();

                    // İsim değerini al.
                    object result = command.ExecuteScalar();

                    try {
                        if (result != null)
                        {                                                    
                           return result.ToString().ToUpper();
                            connection.Close();
                        }
                        else
                            return "Kullanıcı Bulunamadı";
                    }
                    catch(Exception e) { return "Kullanıcı Bulunamadı"; }
                    

                   
                }
            }
        }

        private DataGridView dg1;

        public void  GridYukle(String sehir, string tablo, DataGrid grid)
        {
            
            string baglantı =$"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = {sehir}.accdb";
            OleDbConnection connection = new OleDbConnection(baglantı);
            string query = $"SELECT * FROM {tablo}";
           

            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            grid.DataSource = dataSet;
             





        }


       public int OnayGuncelle(string asansör,string kod,string onay, string hakedisno,string hakedistutar)
        {
            string qry = "Update " + asansör + "SET [Muhendis Onay]="+ onay +" WHERE Kod ="+ kod;
            try
            {
                string baglantı = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = Database1.accdb";
                OleDbConnection connection = new OleDbConnection(baglantı);
                connection.Open();
                OleDbCommand hakedis = new OleDbCommand(qry,connection);
                OleDbDataReader hkdsoku = hakedis.ExecuteReader();
                
              
            }
            catch (Exception e)
            {

                MessageBox.Show("Veritabanına bağlanırken bir hata oluştu!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return 1;
            
        }



    }

            }

