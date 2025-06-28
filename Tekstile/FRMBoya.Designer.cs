namespace Tekstile
{
    partial class FRMBoya
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
            txtBoyaAdi = new TextBox();
            txtBoyaKod = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            dgvBoyalar = new DataGridView();
            btnSil = new Button();
            cmbBoyaTipi = new ComboBox();
            label5 = new Label();
            label8 = new Label();
            label3 = new Label();
            btnGuncelle = new Button();
            btnKaydet = new Button();
            cmbKovaDurum = new ComboBox();
            nudFiyat = new NumericUpDown();
            nudKovaAdet = new NumericUpDown();
            Ara = new Label();
            txtFiltrele = new TextBox();
            button1 = new Button();
            txtAciklama = new TextBox();
            label6 = new Label();
            CmbRenkler = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvBoyalar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFiyat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudKovaAdet).BeginInit();
            SuspendLayout();
            // 
            // txtBoyaAdi
            // 
            txtBoyaAdi.Location = new Point(253, 77);
            txtBoyaAdi.Name = "txtBoyaAdi";
            txtBoyaAdi.Size = new Size(132, 27);
            txtBoyaAdi.TabIndex = 1;
            // 
            // txtBoyaKod
            // 
            txtBoyaKod.Location = new Point(253, 34);
            txtBoyaKod.Name = "txtBoyaKod";
            txtBoyaKod.Size = new Size(132, 27);
            txtBoyaKod.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(159, 80);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 2;
            label1.Text = "Boya Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 37);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 2;
            label2.Text = "Boya Kodu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(439, 74);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 2;
            label4.Text = "Kova Adedi";
            // 
            // dgvBoyalar
            // 
            dgvBoyalar.AllowUserToAddRows = false;
            dgvBoyalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBoyalar.Location = new Point(3, 262);
            dgvBoyalar.Name = "dgvBoyalar";
            dgvBoyalar.ReadOnly = true;
            dgvBoyalar.RowHeadersWidth = 51;
            dgvBoyalar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBoyalar.Size = new Size(1311, 185);
            dgvBoyalar.TabIndex = 4;
            dgvBoyalar.CellClick += dgvBoyalar_CellClick;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.IndianRed;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.ForeColor = Color.Snow;
            btnSil.Location = new Point(687, 207);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(136, 49);
            btnSil.TabIndex = 5;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // cmbBoyaTipi
            // 
            cmbBoyaTipi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoyaTipi.FormattingEnabled = true;
            cmbBoyaTipi.Location = new Point(253, 124);
            cmbBoyaTipi.Name = "cmbBoyaTipi";
            cmbBoyaTipi.Size = new Size(132, 28);
            cmbBoyaTipi.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(159, 128);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 2;
            label5.Text = "Boya Tipi";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(426, 126);
            label8.Name = "label8";
            label8.Size = new Size(99, 20);
            label8.TabIndex = 2;
            label8.Text = "Kova Durumu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(475, 34);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 9;
            label3.Text = "Fiyat";
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.SteelBlue;
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.ForeColor = SystemColors.Window;
            btnGuncelle.Location = new Point(545, 207);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(136, 49);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "Guncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.MediumSeaGreen;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.ForeColor = SystemColors.Window;
            btnKaydet.Location = new Point(403, 207);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(136, 49);
            btnKaydet.TabIndex = 5;
            btnKaydet.Text = "Ekle";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // cmbKovaDurum
            // 
            cmbKovaDurum.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKovaDurum.FormattingEnabled = true;
            cmbKovaDurum.Location = new Point(531, 123);
            cmbKovaDurum.Name = "cmbKovaDurum";
            cmbKovaDurum.Size = new Size(150, 28);
            cmbKovaDurum.TabIndex = 7;
            // 
            // nudFiyat
            // 
            nudFiyat.Location = new Point(531, 37);
            nudFiyat.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudFiyat.Name = "nudFiyat";
            nudFiyat.Size = new Size(150, 27);
            nudFiyat.TabIndex = 10;
            // 
            // nudKovaAdet
            // 
            nudKovaAdet.Location = new Point(531, 77);
            nudKovaAdet.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudKovaAdet.Name = "nudKovaAdet";
            nudKovaAdet.Size = new Size(150, 27);
            nudKovaAdet.TabIndex = 10;
            // 
            // Ara
            // 
            Ara.AutoSize = true;
            Ara.Location = new Point(1125, 19);
            Ara.Name = "Ara";
            Ara.Size = new Size(58, 20);
            Ara.TabIndex = 11;
            Ara.Text = " Filtrele";
            // 
            // txtFiltrele
            // 
            txtFiltrele.Location = new Point(1189, 15);
            txtFiltrele.Name = "txtFiltrele";
            txtFiltrele.Size = new Size(125, 27);
            txtFiltrele.TabIndex = 12;
            txtFiltrele.TextChanged += txtFiltrele_TextChanged;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1189, 114);
            button1.Name = "button1";
            button1.Size = new Size(125, 44);
            button1.TabIndex = 13;
            button1.Text = "Stok Durum";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(788, 37);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(167, 70);
            txtAciklama.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(712, 44);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 2;
            label6.Text = "Açıklama";
            // 
            // CmbRenkler
            // 
            CmbRenkler.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbRenkler.FormattingEnabled = true;
            CmbRenkler.Location = new Point(391, 77);
            CmbRenkler.Name = "CmbRenkler";
            CmbRenkler.Size = new Size(20, 28);
            CmbRenkler.TabIndex = 15;
            CmbRenkler.DropDown += CmbRenkler_DropDown;
            CmbRenkler.DropDownClosed += CmbRenkler_DropDownClosed;
            // 
            // FRMBoya
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = UI.Properties.Resources._20250627_2214_Daha_Fazla_Renk_remix_01jyscvh8hf6frkn3zz6kwgf9e;
            ClientSize = new Size(1512, 516);
            Controls.Add(CmbRenkler);
            Controls.Add(txtAciklama);
            Controls.Add(button1);
            Controls.Add(txtFiltrele);
            Controls.Add(Ara);
            Controls.Add(nudKovaAdet);
            Controls.Add(nudFiyat);
            Controls.Add(label3);
            Controls.Add(cmbKovaDurum);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(cmbBoyaTipi);
            Controls.Add(btnKaydet);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(dgvBoyalar);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBoyaKod);
            Controls.Add(txtBoyaAdi);
            Name = "FRMBoya";
            Text = "Boya";
            Load += FormBoya_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBoyalar).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFiyat).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudKovaAdet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtBoyaAdi;
        private TextBox txtBoyaKod;
        private Label label1;
        private Label label2;
        private Label label4;
        private DataGridView dgvBoyalar;
        private Button btnSil;
        private ComboBox cmbBoyaTipi;
        private Label label5;
        private Label label8;
        private Label label3;
        private Button btnGuncelle;
        private Button btnKaydet;
        private ComboBox cmbKovaDurum;
        private NumericUpDown nudFiyat;
        private NumericUpDown nudKovaAdet;
        private Label Ara;
        private TextBox txtFiltrele;
        private Button button1;
        private TextBox txtAciklama;
        private Label label6;
        private ComboBox CmbRenkler;
    }
}