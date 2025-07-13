
namespace Giris
{
    partial class Sipariş_onay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sipariş_onay));
            this.siparişOnay_grid = new System.Windows.Forms.DataGridView();
            this.siparişOnay_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.siparişOnay_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // siparişOnay_grid
            // 
            this.siparişOnay_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.siparişOnay_grid.Location = new System.Drawing.Point(-1, 1);
            this.siparişOnay_grid.Name = "siparişOnay_grid";
            this.siparişOnay_grid.RowHeadersWidth = 62;
            this.siparişOnay_grid.RowTemplate.Height = 28;
            this.siparişOnay_grid.Size = new System.Drawing.Size(799, 208);
            this.siparişOnay_grid.TabIndex = 0;
            this.siparişOnay_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // siparişOnay_btn
            // 
            this.siparişOnay_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siparişOnay_btn.BackgroundImage = global::Giris.Properties.Resources.onay;
            this.siparişOnay_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.siparişOnay_btn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.siparişOnay_btn.Location = new System.Drawing.Point(700, 325);
            this.siparişOnay_btn.Name = "siparişOnay_btn";
            this.siparişOnay_btn.Size = new System.Drawing.Size(147, 47);
            this.siparişOnay_btn.TabIndex = 1;
            this.siparişOnay_btn.Text = "Onay";
            this.siparişOnay_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.siparişOnay_btn.UseVisualStyleBackColor = false;
            // 
            // Sipariş_onay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.siparişOnay_btn);
            this.Controls.Add(this.siparişOnay_grid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sipariş_onay";
            this.Text = "Sipariş Onay";
            this.Load += new System.EventHandler(this.Sipariş_onay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.siparişOnay_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView siparişOnay_grid;
        private System.Windows.Forms.Button siparişOnay_btn;
    }
}