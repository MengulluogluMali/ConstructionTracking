
namespace Giris
{
    partial class Güncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Güncelle));
            this.Asansör_grid = new System.Windows.Forms.DataGridView();
            this.Asansor_cmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Save_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Save_con_btn = new System.Windows.Forms.Button();
            this.Gizli_btn = new System.Windows.Forms.Button();
            this.kaydetmeden_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Asansör_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Asansör_grid
            // 
            this.Asansör_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Asansör_grid.Location = new System.Drawing.Point(-75, -1);
            this.Asansör_grid.Name = "Asansör_grid";
            this.Asansör_grid.RowHeadersWidth = 62;
            this.Asansör_grid.RowTemplate.Height = 28;
            this.Asansör_grid.Size = new System.Drawing.Size(1007, 614);
            this.Asansör_grid.TabIndex = 0;
            this.Asansör_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Asansör_grid_CellContentClick);
            this.Asansör_grid.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.Asansör_grid_CellContentClick);
            this.Asansör_grid.DoubleClick += new System.EventHandler(this.Gizli_btn_Click);
            // 
            // Asansor_cmb
            // 
            this.Asansor_cmb.FormattingEnabled = true;
            this.Asansor_cmb.Location = new System.Drawing.Point(975, 148);
            this.Asansor_cmb.Name = "Asansor_cmb";
            this.Asansor_cmb.Size = new System.Drawing.Size(176, 28);
            this.Asansor_cmb.TabIndex = 1;
            this.Asansor_cmb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(975, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Asansör No";
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(963, 331);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(217, 123);
            this.Save_btn.TabIndex = 3;
            this.Save_btn.Text = "Kaydet ve Çık";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Giris.Properties.Resources.workers;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(938, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 614);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Save_con_btn
            // 
            this.Save_con_btn.Location = new System.Drawing.Point(963, 202);
            this.Save_con_btn.Name = "Save_con_btn";
            this.Save_con_btn.Size = new System.Drawing.Size(217, 123);
            this.Save_con_btn.TabIndex = 5;
            this.Save_con_btn.Text = "Kaydet ve Devam et ";
            this.Save_con_btn.UseVisualStyleBackColor = true;
            this.Save_con_btn.Click += new System.EventHandler(this.Save_con_btn_Click);
            // 
            // Gizli_btn
            // 
            this.Gizli_btn.Location = new System.Drawing.Point(1076, 215);
            this.Gizli_btn.Name = "Gizli_btn";
            this.Gizli_btn.Size = new System.Drawing.Size(75, 23);
            this.Gizli_btn.TabIndex = 6;
            this.Gizli_btn.UseVisualStyleBackColor = true;
            this.Gizli_btn.Visible = false;
            this.Gizli_btn.Click += new System.EventHandler(this.Gizli_btn_Click);
            // 
            // kaydetmeden_btn
            // 
            this.kaydetmeden_btn.Location = new System.Drawing.Point(963, 460);
            this.kaydetmeden_btn.Name = "kaydetmeden_btn";
            this.kaydetmeden_btn.Size = new System.Drawing.Size(217, 123);
            this.kaydetmeden_btn.TabIndex = 7;
            this.kaydetmeden_btn.Text = "Kaydetmeden  Çık";
            this.kaydetmeden_btn.UseVisualStyleBackColor = true;
            // 
            // Güncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 614);
            this.Controls.Add(this.kaydetmeden_btn);
            this.Controls.Add(this.Gizli_btn);
            this.Controls.Add(this.Save_con_btn);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Asansör_grid);
            this.Controls.Add(this.Asansor_cmb);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Güncelle";
            this.Text = "Güncelle";
            this.Load += new System.EventHandler(this.Güncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Asansör_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Asansör_grid;
        private System.Windows.Forms.ComboBox Asansor_cmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Save_con_btn;
        private System.Windows.Forms.Button Gizli_btn;
        private System.Windows.Forms.Button kaydetmeden_btn;
    }
}