
namespace Giris
{
    partial class Siparis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Siparis));
            this.siparisDataGrid = new System.Windows.Forms.DataGridView();
            this.Siparis_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.not_txtbox = new System.Windows.Forms.TextBox();
            this.Not_checkbox = new System.Windows.Forms.CheckBox();
            this.SiparişVeren = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mktr = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.siparisDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siparisDataGrid
            // 
            this.siparisDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siparisDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.siparisDataGrid.Location = new System.Drawing.Point(1, -2);
            this.siparisDataGrid.Name = "siparisDataGrid";
            this.siparisDataGrid.RowHeadersWidth = 62;
            this.siparisDataGrid.RowTemplate.Height = 28;
            this.siparisDataGrid.Size = new System.Drawing.Size(424, 708);
            this.siparisDataGrid.TabIndex = 0;
            this.siparisDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.siparisDataGrid_CellContentClick);
            // 
            // Siparis_btn
            // 
            this.Siparis_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.Siparis_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Siparis_btn.Location = new System.Drawing.Point(679, 529);
            this.Siparis_btn.Name = "Siparis_btn";
            this.Siparis_btn.Size = new System.Drawing.Size(248, 105);
            this.Siparis_btn.TabIndex = 1;
            this.Siparis_btn.Text = "Sipariş Oluştur";
            this.Siparis_btn.UseVisualStyleBackColor = true;
            this.Siparis_btn.Click += new System.EventHandler(this.Siparis_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.not_txtbox);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(578, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 169);
            this.panel1.TabIndex = 2;
            // 
            // not_txtbox
            // 
            this.not_txtbox.Location = new System.Drawing.Point(6, 3);
            this.not_txtbox.Multiline = true;
            this.not_txtbox.Name = "not_txtbox";
            this.not_txtbox.Size = new System.Drawing.Size(381, 163);
            this.not_txtbox.TabIndex = 0;
            this.not_txtbox.TextChanged += new System.EventHandler(this.Not_txtbox_TextChanged);
            // 
            // Not_checkbox
            // 
            this.Not_checkbox.AutoSize = true;
            this.Not_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Not_checkbox.Location = new System.Drawing.Point(578, 57);
            this.Not_checkbox.Name = "Not_checkbox";
            this.Not_checkbox.Size = new System.Drawing.Size(129, 33);
            this.Not_checkbox.TabIndex = 0;
            this.Not_checkbox.Text = "Not ekle";
            this.Not_checkbox.UseVisualStyleBackColor = true;
            this.Not_checkbox.CheckedChanged += new System.EventHandler(this.Not_checkbox_CheckedChanged);
            // 
            // SiparişVeren
            // 
            this.SiparişVeren.Location = new System.Drawing.Point(578, 299);
            this.SiparişVeren.Multiline = true;
            this.SiparişVeren.Name = "SiparişVeren";
            this.SiparişVeren.Size = new System.Drawing.Size(381, 32);
            this.SiparişVeren.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(574, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sipariş Veren";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(574, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Miktar";
            // 
            // mktr
            // 
            this.mktr.Location = new System.Drawing.Point(578, 371);
            this.mktr.Multiline = true;
            this.mktr.Name = "mktr";
            this.mktr.Size = new System.Drawing.Size(381, 32);
            this.mktr.TabIndex = 5;
            // 
            // Siparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Giris.Properties.Resources._66841;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(998, 711);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mktr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SiparişVeren);
            this.Controls.Add(this.Not_checkbox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Siparis_btn);
            this.Controls.Add(this.siparisDataGrid);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Siparis";
            this.Text = "Siparis";
            this.Load += new System.EventHandler(this.Siparis_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.siparisDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView siparisDataGrid;
        private System.Windows.Forms.Button Siparis_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox not_txtbox;
        private System.Windows.Forms.CheckBox Not_checkbox;
        private System.Windows.Forms.TextBox SiparişVeren;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mktr;
    }
}