namespace Tekstile
{
    partial class FRMGider
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            txtAciklama = new TextBox();
            txtTutar = new TextBox();
            dtpTarih = new DateTimePicker();
            btnEkle = new Button();
            btnSil = new Button();
            btnTemizle = new Button();
            dgvGiderler = new DataGridView();
            lblAciklama = new Label();
            lblTutar = new Label();
            lblTarih = new Label();
            txtGiderTuru = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvGiderler).BeginInit();
            SuspendLayout();
            // 
            // txtAciklama
            // 
            txtAciklama.BorderStyle = BorderStyle.FixedSingle;
            txtAciklama.Font = new Font("Segoe UI", 11F);
            txtAciklama.Location = new Point(140, 30);
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(300, 32);
            txtAciklama.TabIndex = 0;
            // 
            // txtTutar
            // 
            txtTutar.BorderStyle = BorderStyle.FixedSingle;
            txtTutar.Font = new Font("Segoe UI", 11F);
            txtTutar.Location = new Point(140, 75);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(300, 32);
            txtTutar.TabIndex = 1;
            // 
            // dtpTarih
            // 
            dtpTarih.Font = new Font("Segoe UI", 11F);
            dtpTarih.Location = new Point(140, 120);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(300, 32);
            dtpTarih.TabIndex = 2;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.MediumSeaGreen;
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.ForeColor = Color.White;
            btnEkle.Location = new Point(616, 120);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(100, 35);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.IndianRed;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(722, 120);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(100, 35);
            btnSil.TabIndex = 4;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.SteelBlue;
            btnTemizle.FlatStyle = FlatStyle.Flat;
            btnTemizle.ForeColor = Color.White;
            btnTemizle.Location = new Point(828, 120);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(100, 35);
            btnTemizle.TabIndex = 5;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = false;
            // 
            // dgvGiderler
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvGiderler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvGiderler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGiderler.Font = new Font("Segoe UI", 10F);
            dgvGiderler.Location = new Point(12, 241);
            dgvGiderler.Name = "dgvGiderler";
            dgvGiderler.RowHeadersWidth = 51;
            dgvGiderler.RowTemplate.Height = 28;
            dgvGiderler.Size = new Size(1303, 200);
            dgvGiderler.TabIndex = 6;
            // 
            // lblAciklama
            // 
            lblAciklama.AutoSize = true;
            lblAciklama.Font = new Font("Segoe UI", 11F);
            lblAciklama.Location = new Point(40, 35);
            lblAciklama.Name = "lblAciklama";
            lblAciklama.Size = new Size(92, 25);
            lblAciklama.TabIndex = 7;
            lblAciklama.Text = "Açıklama:";
            // 
            // lblTutar
            // 
            lblTutar.AutoSize = true;
            lblTutar.Font = new Font("Segoe UI", 11F);
            lblTutar.Location = new Point(40, 80);
            lblTutar.Name = "lblTutar";
            lblTutar.Size = new Size(60, 25);
            lblTutar.TabIndex = 8;
            lblTutar.Text = "Tutar:";
            // 
            // lblTarih
            // 
            lblTarih.AutoSize = true;
            lblTarih.Font = new Font("Segoe UI", 11F);
            lblTarih.Location = new Point(40, 125);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(57, 25);
            lblTarih.TabIndex = 9;
            lblTarih.Text = "Tarih:";
            // 
            // txtGiderTuru
            // 
            txtGiderTuru.BorderStyle = BorderStyle.FixedSingle;
            txtGiderTuru.Font = new Font("Segoe UI", 11F);
            txtGiderTuru.Location = new Point(669, 35);
            txtGiderTuru.Name = "txtGiderTuru";
            txtGiderTuru.Size = new Size(300, 32);
            txtGiderTuru.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(518, 37);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 7;
            label1.Text = "Gider Türü";
            // 
            // FRMGider
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = UI.Properties.Resources._20250627_2211_Soyut_Renkler_remix_01jyscpdczesgsfaqrdnwr42j4;
            ClientSize = new Size(1327, 453);
            Controls.Add(lblTarih);
            Controls.Add(lblTutar);
            Controls.Add(label1);
            Controls.Add(lblAciklama);
            Controls.Add(dgvGiderler);
            Controls.Add(btnTemizle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(dtpTarih);
            Controls.Add(txtTutar);
            Controls.Add(txtGiderTuru);
            Controls.Add(txtAciklama);
            Name = "FRMGider";
            Text = "Gider Yönetimi";
            Load += FRMGider_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGiderler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.DataGridView dgvGiderler;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label lblTarih;
        private TextBox txtGiderTuru;
        private Label label1;
    }
} 