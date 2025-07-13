
namespace Giris
{
    partial class Şantiye
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
            this.components = new System.ComponentModel.Container();
            this.AsnsorDurum_grid = new System.Windows.Forms.DataGridView();
            this.Asansör_cmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gelisim_pBar = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.AsnsorDurum_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // AsnsorDurum_grid
            // 
            this.AsnsorDurum_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AsnsorDurum_grid.Location = new System.Drawing.Point(0, 0);
            this.AsnsorDurum_grid.Name = "AsnsorDurum_grid";
            this.AsnsorDurum_grid.RowHeadersWidth = 62;
            this.AsnsorDurum_grid.RowTemplate.Height = 28;
            this.AsnsorDurum_grid.Size = new System.Drawing.Size(853, 487);
            this.AsnsorDurum_grid.TabIndex = 0;
            // 
            // Asansör_cmb
            // 
            this.Asansör_cmb.FormattingEnabled = true;
            this.Asansör_cmb.Location = new System.Drawing.Point(863, 43);
            this.Asansör_cmb.Name = "Asansör_cmb";
            this.Asansör_cmb.Size = new System.Drawing.Size(157, 28);
            this.Asansör_cmb.TabIndex = 1;
            this.Asansör_cmb.SelectedIndexChanged += new System.EventHandler(this.Asansör_cmb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(859, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Asanör No";
            // 
            // gelisim_pBar
            // 
            this.gelisim_pBar.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.gelisim_pBar.Location = new System.Drawing.Point(127, 542);
            this.gelisim_pBar.Maximum = 88;
            this.gelisim_pBar.Name = "gelisim_pBar";
            this.gelisim_pBar.Size = new System.Drawing.Size(726, 34);
            this.gelisim_pBar.Step = 1;
            this.gelisim_pBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.gelisim_pBar.TabIndex = 3;
            this.gelisim_pBar.Click += new System.EventHandler(this.gelisim_pBar_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(7, 542);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "İlerleme  ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Şantiye_Load);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Şantiye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Giris.Properties.Resources.asansörr;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1094, 631);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gelisim_pBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Asansör_cmb);
            this.Controls.Add(this.AsnsorDurum_grid);
            this.Name = "Şantiye";
            this.Text = "Şantiye";
            this.Load += new System.EventHandler(this.Şantiye_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AsnsorDurum_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AsnsorDurum_grid;
        private System.Windows.Forms.ComboBox Asansör_cmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar gelisim_pBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}