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
    public partial class Ana_Sayfa : Form
    {
        private string[] santiyelere= { "İstanbul", "Ankara", "İzmir", "Bursa", "Adana","Elazığ", "Hatay","Adıyaman"};
        
        public Ana_Sayfa()
        {
            InitializeComponent();
            
        }

        private void Ana_Sayfa_Load(object sender, EventArgs e)
        {
            label4.Text = Giris.Up_isim;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
          
        }

        private void Calisan_listesi_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Santiye_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cikis_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void Calisan_ekle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Calisanekle_Click(object sender, EventArgs e)
        {
            Calisan_ekle nesne = new Calisan_ekle();
            nesne.ShowDialog();
         //   Ana_Sayfa.ActiveForm.Close();
        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void Siparis_Ver_Click(object sender, EventArgs e)
        {
            Siparis nesne = new Siparis();
            nesne.Show();
        }

        private void Santiye_Durumu_Click(object sender, EventArgs e)
        {
            Şantiye nesnesii = new Şantiye();
            nesnesii.Show();
            
        }

        private void is_Guncelle_Click(object sender, EventArgs e)
        {
            Güncelle nesne = new Güncelle();
            nesne.Show();
        }

        private void Calisan_Liste_Click(object sender, EventArgs e)
        {
            Çalışan_Listesi nsnn = new Çalışan_Listesi();
            nsnn.Show();
        }

        private void Hakeds_Click(object sender, EventArgs e)
        {
            Hakediş_Güncelle hakediş_Güncellensn = new Hakediş_Güncelle();
            hakediş_Güncellensn.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}

