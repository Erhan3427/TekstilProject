namespace Tekstile
{
    partial class FRMCalisan
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
            txtAdSoyad = new TextBox();
            txtPozisyon = new TextBox();
            txtMaas = new TextBox();
            dtpBaslamaTarihi = new DateTimePicker();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnTemizle = new Button();
            dgvCalisanlar = new DataGridView();
            lblAdSoyad = new Label();
            lblPozisyon = new Label();
            lblMaas = new Label();
            lblBaslamaTarihi = new Label();
            cbCalisiyorMu = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvCalisanlar).BeginInit();
            SuspendLayout();
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(169, 38);
            txtAdSoyad.Margin = new Padding(3, 4, 3, 4);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(250, 27);
            txtAdSoyad.TabIndex = 0;
            // 
            // txtPozisyon
            // 
            txtPozisyon.Location = new Point(169, 88);
            txtPozisyon.Margin = new Padding(3, 4, 3, 4);
            txtPozisyon.Name = "txtPozisyon";
            txtPozisyon.Size = new Size(250, 27);
            txtPozisyon.TabIndex = 1;
            // 
            // txtMaas
            // 
            txtMaas.Location = new Point(169, 138);
            txtMaas.Margin = new Padding(3, 4, 3, 4);
            txtMaas.Name = "txtMaas";
            txtMaas.Size = new Size(250, 27);
            txtMaas.TabIndex = 2;
            // 
            // dtpBaslamaTarihi
            // 
            dtpBaslamaTarihi.Location = new Point(169, 188);
            dtpBaslamaTarihi.Margin = new Padding(3, 4, 3, 4);
            dtpBaslamaTarihi.Name = "dtpBaslamaTarihi";
            dtpBaslamaTarihi.Size = new Size(250, 27);
            dtpBaslamaTarihi.TabIndex = 3;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.MediumSeaGreen;
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.ForeColor = SystemColors.Window;
            btnEkle.Location = new Point(531, 191);
            btnEkle.Margin = new Padding(3, 4, 3, 4);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(120, 44);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.SteelBlue;
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.ForeColor = SystemColors.Window;
            btnGuncelle.Location = new Point(657, 191);
            btnGuncelle.Margin = new Padding(3, 4, 3, 4);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(120, 44);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.IndianRed;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.ForeColor = SystemColors.Window;
            btnSil.Location = new Point(783, 191);
            btnSil.Margin = new Padding(3, 4, 3, 4);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(120, 44);
            btnSil.TabIndex = 6;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            // 
            // btnTemizle
            // 
            btnTemizle.FlatStyle = FlatStyle.Flat;
            btnTemizle.Location = new Point(1100, 191);
            btnTemizle.Margin = new Padding(3, 4, 3, 4);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(120, 44);
            btnTemizle.TabIndex = 7;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            // 
            // dgvCalisanlar
            // 
            dgvCalisanlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCalisanlar.Location = new Point(20, 275);
            dgvCalisanlar.Margin = new Padding(3, 4, 3, 4);
            dgvCalisanlar.Name = "dgvCalisanlar";
            dgvCalisanlar.RowHeadersWidth = 51;
            dgvCalisanlar.RowTemplate.Height = 24;
            dgvCalisanlar.Size = new Size(1300, 312);
            dgvCalisanlar.TabIndex = 8;
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Location = new Point(30, 41);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(132, 20);
            lblAdSoyad.TabIndex = 9;
            lblAdSoyad.Text = "Çalışan Adı Soyadı";
            // 
            // lblPozisyon
            // 
            lblPozisyon.AutoSize = true;
            lblPozisyon.Location = new Point(30, 91);
            lblPozisyon.Name = "lblPozisyon";
            lblPozisyon.Size = new Size(66, 20);
            lblPozisyon.TabIndex = 10;
            lblPozisyon.Text = "Pozisyon";
            // 
            // lblMaas
            // 
            lblMaas.AutoSize = true;
            lblMaas.Location = new Point(30, 141);
            lblMaas.Name = "lblMaas";
            lblMaas.Size = new Size(44, 20);
            lblMaas.TabIndex = 11;
            lblMaas.Text = "Maaş";
            // 
            // lblBaslamaTarihi
            // 
            lblBaslamaTarihi.AutoSize = true;
            lblBaslamaTarihi.Location = new Point(30, 191);
            lblBaslamaTarihi.Name = "lblBaslamaTarihi";
            lblBaslamaTarihi.Size = new Size(104, 20);
            lblBaslamaTarihi.TabIndex = 12;
            lblBaslamaTarihi.Text = "Başlama Tarihi";
            // 
            // cbCalisiyorMu
            // 
            cbCalisiyorMu.AutoSize = true;
            cbCalisiyorMu.Location = new Point(467, 41);
            cbCalisiyorMu.Name = "cbCalisiyorMu";
            cbCalisiyorMu.Size = new Size(116, 24);
            cbCalisiyorMu.TabIndex = 13;
            cbCalisiyorMu.Text = "Çalışıyor mu ";
            cbCalisiyorMu.UseVisualStyleBackColor = true;
            // 
            // FRMCalisan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = UI.Properties.Resources._20250627_2214_Daha_Fazla_Renk_remix_01jyscvh8hf6frkn3zz6kwgf9e;
            ClientSize = new Size(1345, 625);
            Controls.Add(cbCalisiyorMu);
            Controls.Add(lblBaslamaTarihi);
            Controls.Add(lblMaas);
            Controls.Add(lblPozisyon);
            Controls.Add(lblAdSoyad);
            Controls.Add(dgvCalisanlar);
            Controls.Add(btnTemizle);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(dtpBaslamaTarihi);
            Controls.Add(txtMaas);
            Controls.Add(txtPozisyon);
            Controls.Add(txtAdSoyad);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FRMCalisan";
            Text = "Çalışan Yönetimi";
            Load += FRMCalisan_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCalisanlar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtPozisyon;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.DateTimePicker dtpBaslamaTarihi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.DataGridView dgvCalisanlar;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblPozisyon;
        private System.Windows.Forms.Label lblMaas;
        private System.Windows.Forms.Label lblBaslamaTarihi;
        private CheckBox cbCalisiyorMu;
    }
} 