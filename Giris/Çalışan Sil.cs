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
    public partial class Çalışan_Sil : Form
    {
        string connecstring = "Provider=Microsoft.Ace.OLEDB.12.0; Data Source = Database1.accdb";
        public Çalışan_Sil()
        {
            InitializeComponent();
        }

        private void Sil_btn_Click(object sender, EventArgs e)
        {
            OleDbConnection connect = new OleDbConnection(connecstring);
            string id = Sil_ID_txtbx.Text;

            string sorgu = "DELETE * FROM Workers_deneme WHERE ID = " + id;
            OleDbCommand sil = new OleDbCommand(sorgu,connect);
            DialogResult result = MessageBox.Show("Silmek istediğinize emin misiniz","Emin misin", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                try
                {
                    connect.Open();
                    int rowsaffected = sil.ExecuteNonQuery();
                    connect.Close();
                    if (rowsaffected != 0)
                    {
                        MessageBox.Show("Başarılı");
                        Çalışan_Sil.ActiveForm.Close();
                        
                    }
                    else
                        MessageBox.Show("Hata");
                }
                catch(Exception ece)
                {
                    MessageBox.Show("Hata" + ece);

                }

            }
            
        }

        private void Çalışan_Sil_Load(object sender, EventArgs e)
        {

        }
    }
}
