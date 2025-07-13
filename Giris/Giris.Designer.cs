
namespace Giris
{
    partial class Giris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.textbox = new System.Windows.Forms.Label();
            this.kullaniciAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.parola = new System.Windows.Forms.TextBox();
            this.GirisBtn = new System.Windows.Forms.Button();
            this.Şifreyi_göster = new System.Windows.Forms.CheckBox();
            this.Unuttum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textbox
            // 
            this.textbox.BackColor = System.Drawing.Color.Transparent;
            this.textbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.textbox.Enabled = false;
            this.textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textbox.ForeColor = System.Drawing.Color.White;
            this.textbox.Location = new System.Drawing.Point(309, 340);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(156, 46);
            this.textbox.TabIndex = 0;
            this.textbox.Text = "Kullanıcı Adı";
            this.textbox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.textbox.Click += new System.EventHandler(this.label1_Click);
            // 
            // kullaniciAdi
            // 
            this.kullaniciAdi.AcceptsTab = true;
            this.kullaniciAdi.BackColor = System.Drawing.Color.Black;
            this.kullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kullaniciAdi.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.kullaniciAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.kullaniciAdi.ForeColor = System.Drawing.Color.White;
            this.kullaniciAdi.HideSelection = false;
            this.kullaniciAdi.Location = new System.Drawing.Point(463, 352);
            this.kullaniciAdi.Name = "kullaniciAdi";
            this.kullaniciAdi.Size = new System.Drawing.Size(216, 19);
            this.kullaniciAdi.TabIndex = 1;
            this.kullaniciAdi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(314, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Parola";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // parola
            // 
            this.parola.AcceptsTab = true;
            this.parola.BackColor = System.Drawing.Color.Black;
            this.parola.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.parola.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.parola.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.parola.ForeColor = System.Drawing.Color.White;
            this.parola.HideSelection = false;
            this.parola.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.parola.Location = new System.Drawing.Point(463, 394);
            this.parola.Name = "parola";
            this.parola.Size = new System.Drawing.Size(216, 19);
            this.parola.TabIndex = 3;
            this.parola.UseSystemPasswordChar = true;
            // 
            // GirisBtn
            // 
            this.GirisBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GirisBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.GirisBtn.FlatAppearance.BorderSize = 0;
            this.GirisBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GirisBtn.Location = new System.Drawing.Point(521, 458);
            this.GirisBtn.Name = "GirisBtn";
            this.GirisBtn.Size = new System.Drawing.Size(158, 65);
            this.GirisBtn.TabIndex = 4;
            this.GirisBtn.Text = "Giriş";
            this.GirisBtn.UseVisualStyleBackColor = false;
            this.GirisBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Şifreyi_göster
            // 
            this.Şifreyi_göster.Appearance = System.Windows.Forms.Appearance.Button;
            this.Şifreyi_göster.BackColor = System.Drawing.Color.Transparent;
            this.Şifreyi_göster.BackgroundImage = global::Giris.Properties.Resources.pngwing_com_1;
            this.Şifreyi_göster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Şifreyi_göster.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Şifreyi_göster.Cursor = System.Windows.Forms.Cursors.Default;
            this.Şifreyi_göster.ForeColor = System.Drawing.Color.Transparent;
            this.Şifreyi_göster.Image = global::Giris.Properties.Resources.pngwing_com;
            this.Şifreyi_göster.Location = new System.Drawing.Point(713, 386);
            this.Şifreyi_göster.Name = "Şifreyi_göster";
            this.Şifreyi_göster.Size = new System.Drawing.Size(54, 44);
            this.Şifreyi_göster.TabIndex = 5;
            this.Şifreyi_göster.UseVisualStyleBackColor = false;
            this.Şifreyi_göster.CheckedChanged += new System.EventHandler(this.Şifreyi_göster_CheckedChanged);
            this.Şifreyi_göster.Click += new System.EventHandler(this.Şifreyi_göster_CheckedChanged);
            // 
            // Unuttum
            // 
            this.Unuttum.BackColor = System.Drawing.Color.LightYellow;
            this.Unuttum.Location = new System.Drawing.Point(521, 619);
            this.Unuttum.Name = "Unuttum";
            this.Unuttum.Size = new System.Drawing.Size(218, 33);
            this.Unuttum.TabIndex = 6;
            this.Unuttum.Text = "Parolanızı mı unuttunuz?";
            this.Unuttum.UseVisualStyleBackColor = false;
            this.Unuttum.Click += new System.EventHandler(this.Unuttum_Click);
            // 
            // Giris
            // 
            this.AcceptButton = this.GirisBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Giris.Properties.Resources.akilli_asansor__yapay_zekali_asansorler_bsb_asansor_44280_7167358333;
            this.ClientSize = new System.Drawing.Size(1228, 894);
            this.Controls.Add(this.Unuttum);
            this.Controls.Add(this.Şifreyi_göster);
            this.Controls.Add(this.GirisBtn);
            this.Controls.Add(this.parola);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kullaniciAdi);
            this.Controls.Add(this.textbox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mengullu_Lift";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox parola;
        private System.Windows.Forms.Button GirisBtn;
        public System.Windows.Forms.TextBox kullaniciAdi;
        private System.Windows.Forms.CheckBox Şifreyi_göster;
        public System.Windows.Forms.Button Unuttum;
    }
}

