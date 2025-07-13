
namespace Giris
{
    partial class Çalışan_Sil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Çalışan_Sil));
            this.label1 = new System.Windows.Forms.Label();
            this.Sil_btn = new System.Windows.Forms.Button();
            this.Sil_ID_txtbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(23, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Silmek istediğiniz çalışanın ID bilgisini giriniz:";
            // 
            // Sil_btn
            // 
            this.Sil_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Sil_btn.Location = new System.Drawing.Point(524, 171);
            this.Sil_btn.Name = "Sil_btn";
            this.Sil_btn.Size = new System.Drawing.Size(197, 81);
            this.Sil_btn.TabIndex = 1;
            this.Sil_btn.Text = "Sil";
            this.Sil_btn.UseVisualStyleBackColor = true;
            this.Sil_btn.Click += new System.EventHandler(this.Sil_btn_Click);
            // 
            // Sil_ID_txtbx
            // 
            this.Sil_ID_txtbx.Location = new System.Drawing.Point(524, 121);
            this.Sil_ID_txtbx.Name = "Sil_ID_txtbx";
            this.Sil_ID_txtbx.Size = new System.Drawing.Size(197, 26);
            this.Sil_ID_txtbx.TabIndex = 2;
            // 
            // Çalışan_Sil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Sil_ID_txtbx);
            this.Controls.Add(this.Sil_btn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Çalışan_Sil";
            this.Text = "Çalışan Sil";
            this.Load += new System.EventHandler(this.Çalışan_Sil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Sil_btn;
        private System.Windows.Forms.TextBox Sil_ID_txtbx;
    }
}