
namespace Giris
{
    partial class Calisan_ekle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calisan_ekle));
            this.Adi = new System.Windows.Forms.TextBox();
            this.soyad = new System.Windows.Forms.TextBox();
            this.santiyeler = new System.Windows.Forms.ComboBox();
            this.calsn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.alan = new System.Windows.Forms.TextBox();
            this.egitim = new System.Windows.Forms.TextBox();
            this.cep = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.erisim = new System.Windows.Forms.CheckBox();
            this.dogumt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.parol = new System.Windows.Forms.TextBox();
            this.kadi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.calisanekle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Adi
            // 
            this.Adi.Location = new System.Drawing.Point(118, 226);
            this.Adi.Name = "Adi";
            this.Adi.Size = new System.Drawing.Size(196, 26);
            this.Adi.TabIndex = 0;
            // 
            // soyad
            // 
            this.soyad.Location = new System.Drawing.Point(118, 280);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(196, 26);
            this.soyad.TabIndex = 1;
            this.soyad.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // santiyeler
            // 
            this.santiyeler.BackColor = System.Drawing.SystemColors.InfoText;
            this.santiyeler.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.santiyeler.FormattingEnabled = true;
            this.santiyeler.Location = new System.Drawing.Point(688, 186);
            this.santiyeler.Name = "santiyeler";
            this.santiyeler.Size = new System.Drawing.Size(196, 28);
            this.santiyeler.TabIndex = 17;
            this.santiyeler.Text = "Şantiye seç";
            this.santiyeler.SelectedIndexChanged += new System.EventHandler(this.santiyeler_SelectedIndexChanged);
            // 
            // calsn
            // 
            this.calsn.BackColor = System.Drawing.Color.Linen;
            this.calsn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calsn.Location = new System.Drawing.Point(323, 32);
            this.calsn.Name = "calsn";
            this.calsn.Size = new System.Drawing.Size(389, 91);
            this.calsn.TabIndex = 18;
            this.calsn.Text = "Çalışan Bilgileri";
            this.calsn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SeaShell;
            this.label1.Location = new System.Drawing.Point(123, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SeaShell;
            this.label2.Location = new System.Drawing.Point(123, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Soyad";
            // 
            // alan
            // 
            this.alan.Location = new System.Drawing.Point(118, 402);
            this.alan.Name = "alan";
            this.alan.Size = new System.Drawing.Size(196, 26);
            this.alan.TabIndex = 21;
            // 
            // egitim
            // 
            this.egitim.Location = new System.Drawing.Point(388, 395);
            this.egitim.Name = "egitim";
            this.egitim.Size = new System.Drawing.Size(196, 26);
            this.egitim.TabIndex = 22;
            this.egitim.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // cep
            // 
            this.cep.Location = new System.Drawing.Point(118, 337);
            this.cep.Name = "cep";
            this.cep.Size = new System.Drawing.Size(196, 26);
            this.cep.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SeaShell;
            this.label3.Location = new System.Drawing.Point(123, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Cep";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SeaShell;
            this.label4.Location = new System.Drawing.Point(393, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Eğitim";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SeaShell;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(123, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Alan";
            // 
            // tc
            // 
            this.tc.Location = new System.Drawing.Point(388, 242);
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(196, 26);
            this.tc.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.SeaShell;
            this.label6.Location = new System.Drawing.Point(393, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "TC";
            // 
            // erisim
            // 
            this.erisim.BackColor = System.Drawing.Color.White;
            this.erisim.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.erisim.Location = new System.Drawing.Point(688, 226);
            this.erisim.Name = "erisim";
            this.erisim.Size = new System.Drawing.Size(130, 42);
            this.erisim.TabIndex = 31;
            this.erisim.Text = "Erişim";
            this.erisim.UseVisualStyleBackColor = false;
            this.erisim.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dogumt
            // 
            this.dogumt.Location = new System.Drawing.Point(388, 319);
            this.dogumt.Name = "dogumt";
            this.dogumt.Size = new System.Drawing.Size(196, 26);
            this.dogumt.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.SeaShell;
            this.label8.Location = new System.Drawing.Point(393, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Doğum tarihi";
            // 
            // parol
            // 
            this.parol.Location = new System.Drawing.Point(7, 74);
            this.parol.Name = "parol";
            this.parol.Size = new System.Drawing.Size(196, 26);
            this.parol.TabIndex = 34;
            // 
            // kadi
            // 
            this.kadi.Location = new System.Drawing.Point(7, 22);
            this.kadi.Name = "kadi";
            this.kadi.Size = new System.Drawing.Size(196, 26);
            this.kadi.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.SeaShell;
            this.label9.Location = new System.Drawing.Point(3, -1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "Kullanıcı Adı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.SeaShell;
            this.label10.Location = new System.Drawing.Point(3, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 20);
            this.label10.TabIndex = 37;
            this.label10.Text = "Parola";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.parol);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.kadi);
            this.panel1.Location = new System.Drawing.Point(684, 289);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 38;
            this.panel1.Visible = false;
            // 
            // calisanekle
            // 
            this.calisanekle.BackColor = System.Drawing.Color.Black;
            this.calisanekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.calisanekle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.calisanekle.Location = new System.Drawing.Point(674, 424);
            this.calisanekle.Name = "calisanekle";
            this.calisanekle.Size = new System.Drawing.Size(317, 95);
            this.calisanekle.TabIndex = 39;
            this.calisanekle.Text = "Çalışan Ekle";
            this.calisanekle.UseVisualStyleBackColor = false;
            this.calisanekle.Click += new System.EventHandler(this.calisanekle_Click);
            // 
            // Calisan_ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.BackgroundImage = global::Giris.Properties.Resources.calisanekle;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1128, 669);
            this.Controls.Add(this.calisanekle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dogumt);
            this.Controls.Add(this.erisim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cep);
            this.Controls.Add(this.egitim);
            this.Controls.Add(this.alan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calsn);
            this.Controls.Add(this.santiyeler);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.Adi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calisan_ekle";
            this.Text = "Calisan ekle";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Adi;
        private System.Windows.Forms.TextBox soyad;
        private System.Windows.Forms.ComboBox santiyeler;
        private System.Windows.Forms.Label calsn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox alan;
        private System.Windows.Forms.TextBox egitim;
        private System.Windows.Forms.TextBox cep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox erisim;
        private System.Windows.Forms.TextBox dogumt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox parol;
        private System.Windows.Forms.TextBox kadi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button calisanekle;
    }
}