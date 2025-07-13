
namespace Giris
{
    partial class Hakediş_Güncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hakediş_Güncelle));
            this.Hakedis_grid = new System.Windows.Forms.DataGridView();
            this.Gizli_hkds_btn = new System.Windows.Forms.Button();
            this.hkds_ansr_cmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gizli_btn_2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Hakedis_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Hakedis_grid
            // 
            this.Hakedis_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Hakedis_grid.Location = new System.Drawing.Point(-21, 0);
            this.Hakedis_grid.Name = "Hakedis_grid";
            this.Hakedis_grid.RowHeadersWidth = 62;
            this.Hakedis_grid.RowTemplate.Height = 28;
            this.Hakedis_grid.Size = new System.Drawing.Size(639, 452);
            this.Hakedis_grid.TabIndex = 0;
            this.Hakedis_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Hakedis_grid_CellClick);
            this.Hakedis_grid.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.Hakedis_grid_CellContentClick);
            this.Hakedis_grid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Hakedis_grid_CellContentClick);
            this.Hakedis_grid.CurrentCellChanged += new System.EventHandler(this.Gizli_hkds_btn_Click);
            this.Hakedis_grid.MouseLeave += new System.EventHandler(this.Hakedis_grid_MouseLeave);
            // 
            // Gizli_hkds_btn
            // 
            this.Gizli_hkds_btn.Location = new System.Drawing.Point(729, 0);
            this.Gizli_hkds_btn.Name = "Gizli_hkds_btn";
            this.Gizli_hkds_btn.Size = new System.Drawing.Size(75, 23);
            this.Gizli_hkds_btn.TabIndex = 1;
            this.Gizli_hkds_btn.UseVisualStyleBackColor = true;
            this.Gizli_hkds_btn.Visible = false;
            this.Gizli_hkds_btn.Click += new System.EventHandler(this.Gizli_hkds_btn_Click);
            // 
            // hkds_ansr_cmb
            // 
            this.hkds_ansr_cmb.FormattingEnabled = true;
            this.hkds_ansr_cmb.Location = new System.Drawing.Point(644, 73);
            this.hkds_ansr_cmb.Name = "hkds_ansr_cmb";
            this.hkds_ansr_cmb.Size = new System.Drawing.Size(121, 28);
            this.hkds_ansr_cmb.TabIndex = 2;
            this.hkds_ansr_cmb.SelectedIndexChanged += new System.EventHandler(this.hkds_ansr_cmb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(640, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Asansör No";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(644, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 56);
            this.button1.TabIndex = 4;
            this.button1.Text = "save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gizli_btn_2
            // 
            this.gizli_btn_2.Location = new System.Drawing.Point(644, 0);
            this.gizli_btn_2.Name = "gizli_btn_2";
            this.gizli_btn_2.Size = new System.Drawing.Size(75, 23);
            this.gizli_btn_2.TabIndex = 5;
            this.gizli_btn_2.Text = "button2";
            this.gizli_btn_2.UseVisualStyleBackColor = true;
            this.gizli_btn_2.Visible = false;
            this.gizli_btn_2.Click += new System.EventHandler(this.gizli_btn_2_Click);
            // 
            // Hakediş_Güncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gizli_btn_2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hkds_ansr_cmb);
            this.Controls.Add(this.Gizli_hkds_btn);
            this.Controls.Add(this.Hakedis_grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hakediş_Güncelle";
            this.Text = "Hakediş Güncelle";
            this.Load += new System.EventHandler(this.Hakediş_Güncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Hakedis_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Hakedis_grid;
        private System.Windows.Forms.Button Gizli_hkds_btn;
        private System.Windows.Forms.ComboBox hkds_ansr_cmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button gizli_btn_2;
    }
}