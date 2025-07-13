
namespace Forgot_Password
{
    partial class Forgotpsswrd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Telefon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.K_adi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Newpassword = new System.Windows.Forms.TextBox();
            this.Newpassword2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(302, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(583, 116);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şifrenizi Yenileyin";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(305, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 45);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefon numaranız :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Telefon
            // 
            this.Telefon.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Telefon.Location = new System.Drawing.Point(488, 287);
            this.Telefon.Name = "Telefon";
            this.Telefon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Telefon.Size = new System.Drawing.Size(288, 26);
            this.Telefon.TabIndex = 4;
            this.Telefon.Text = "0";
            this.Telefon.TextChanged += new System.EventHandler(this.Telefon_TextChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(305, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 45);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kullanıcı adınız :";
            // 
            // K_adi
            // 
            this.K_adi.Location = new System.Drawing.Point(488, 348);
            this.K_adi.Name = "K_adi";
            this.K_adi.Size = new System.Drawing.Size(288, 26);
            this.K_adi.TabIndex = 6;
            this.K_adi.TextChanged += new System.EventHandler(this.K_adi_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MintCream;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(478, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(298, 132);
            this.button1.TabIndex = 7;
            this.button1.Text = "Şifremi Yenile";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(297, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Yeni Şifre:";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(297, 448);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 36);
            this.label6.TabIndex = 9;
            this.label6.Text = "Yeni Şifre Tekrar:";
            // 
            // Newpassword
            // 
            this.Newpassword.Location = new System.Drawing.Point(488, 405);
            this.Newpassword.Multiline = true;
            this.Newpassword.Name = "Newpassword";
            this.Newpassword.Size = new System.Drawing.Size(288, 32);
            this.Newpassword.TabIndex = 10;
            // 
            // Newpassword2
            // 
            this.Newpassword2.Location = new System.Drawing.Point(488, 448);
            this.Newpassword2.Multiline = true;
            this.Newpassword2.Name = "Newpassword2";
            this.Newpassword2.Size = new System.Drawing.Size(288, 36);
            this.Newpassword2.TabIndex = 11;
            this.Newpassword2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Forgotpsswrd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Giris.Properties.Resources.Forgot_password;
            this.ClientSize = new System.Drawing.Size(1058, 883);
            this.Controls.Add(this.Newpassword2);
            this.Controls.Add(this.Newpassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.K_adi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Telefon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Forgotpsswrd";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parola Yenileme";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Telefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox K_adi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Newpassword;
        private System.Windows.Forms.TextBox Newpassword2;
    }
}

