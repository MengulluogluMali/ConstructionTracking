
namespace Giris
{
    partial class Çalışan_Listesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Çalışan_Listesi));
            this.Çalışan_dtgrd = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.çalısan_ekle = new System.Windows.Forms.Button();
            this.çalışan_sil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Çalışan_dtgrd)).BeginInit();
            this.SuspendLayout();
            // 
            // Çalışan_dtgrd
            // 
            this.Çalışan_dtgrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Çalışan_dtgrd.Location = new System.Drawing.Point(0, 79);
            this.Çalışan_dtgrd.Name = "Çalışan_dtgrd";
            this.Çalışan_dtgrd.RowHeadersWidth = 62;
            this.Çalışan_dtgrd.RowTemplate.Height = 28;
            this.Çalışan_dtgrd.Size = new System.Drawing.Size(1139, 547);
            this.Çalışan_dtgrd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Not: Buradan yalnızca çalışanları görebilirsiniz.";
            // 
            // çalısan_ekle
            // 
            this.çalısan_ekle.Location = new System.Drawing.Point(412, 12);
            this.çalısan_ekle.Name = "çalısan_ekle";
            this.çalısan_ekle.Size = new System.Drawing.Size(247, 49);
            this.çalısan_ekle.TabIndex = 2;
            this.çalısan_ekle.Text = "Çalışan eklemek için tıkla";
            this.çalısan_ekle.UseVisualStyleBackColor = true;
            this.çalısan_ekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // çalışan_sil
            // 
            this.çalışan_sil.Location = new System.Drawing.Point(720, 12);
            this.çalışan_sil.Name = "çalışan_sil";
            this.çalışan_sil.Size = new System.Drawing.Size(247, 49);
            this.çalışan_sil.TabIndex = 3;
            this.çalışan_sil.Text = "Çalışan silmek için tıkla";
            this.çalışan_sil.UseVisualStyleBackColor = true;
            this.çalışan_sil.Click += new System.EventHandler(this.çalışan_sil_Click);
            // 
            // Çalışan_Listesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 629);
            this.Controls.Add(this.çalışan_sil);
            this.Controls.Add(this.çalısan_ekle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Çalışan_dtgrd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Çalışan_Listesi";
            this.Text = "Çalışan_Listesi";
            this.Load += new System.EventHandler(this.Çalışan_Listesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Çalışan_dtgrd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Çalışan_dtgrd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button çalısan_ekle;
        private System.Windows.Forms.Button çalışan_sil;
    }
}