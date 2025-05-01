namespace Tekstile
{
    partial class FormBoya
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
            ((System.ComponentModel.ISupportInitialize)dgvBoyalar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFiyat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudKovaAdet).BeginInit();
            SuspendLayout();
            // 
            // txtBoyaAdi
            // 
            txtBoyaAdi.Location = new Point(116, 78);
            txtBoyaAdi.Name = "txtBoyaAdi";
            txtBoyaAdi.Size = new Size(132, 27);
            txtBoyaAdi.TabIndex = 1;
            // 
            // txtBoyaKod
            // 
            txtBoyaKod.Location = new Point(116, 35);
            txtBoyaKod.Name = "txtBoyaKod";
            txtBoyaKod.Size = new Size(132, 27);
            txtBoyaKod.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 81);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 2;
            label1.Text = "Boya Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 38);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 2;
            label2.Text = "Boya Kodu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(302, 75);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 2;
            label4.Text = "Kova Adedi";
            // 
            // dgvBoyalar
            // 
            dgvBoyalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBoyalar.Location = new Point(10, 262);
            dgvBoyalar.Name = "dgvBoyalar";
            dgvBoyalar.RowHeadersWidth = 51;
            dgvBoyalar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBoyalar.Size = new Size(810, 176);
            dgvBoyalar.TabIndex = 4;
            dgvBoyalar.CellClick += dgvBoyalar_CellClick;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(581, 207);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(136, 49);
            btnSil.TabIndex = 5;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // cmbBoyaTipi
            // 
            cmbBoyaTipi.FormattingEnabled = true;
            cmbBoyaTipi.Location = new Point(116, 125);
            cmbBoyaTipi.Name = "cmbBoyaTipi";
            cmbBoyaTipi.Size = new Size(132, 28);
            cmbBoyaTipi.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 129);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 2;
            label5.Text = "Boya Tipi";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(289, 127);
            label8.Name = "label8";
            label8.Size = new Size(99, 20);
            label8.TabIndex = 2;
            label8.Text = "Kova Durumu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(338, 35);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 9;
            label3.Text = "Fiyat";
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(439, 207);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(136, 49);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "Guncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(297, 207);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(136, 49);
            btnKaydet.TabIndex = 5;
            btnKaydet.Text = "Ekle";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // cmbKovaDurum
            // 
            cmbKovaDurum.FormattingEnabled = true;
            cmbKovaDurum.Location = new Point(394, 124);
            cmbKovaDurum.Name = "cmbKovaDurum";
            cmbKovaDurum.Size = new Size(150, 28);
            cmbKovaDurum.TabIndex = 7;
            // 
            // nudFiyat
            // 
            nudFiyat.Location = new Point(394, 38);
            nudFiyat.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudFiyat.Name = "nudFiyat";
            nudFiyat.Size = new Size(150, 27);
            nudFiyat.TabIndex = 10;
            // 
            // nudKovaAdet
            // 
            nudKovaAdet.Location = new Point(394, 78);
            nudKovaAdet.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudKovaAdet.Name = "nudKovaAdet";
            nudKovaAdet.Size = new Size(150, 27);
            nudKovaAdet.TabIndex = 10;
            // 
            // Ara
            // 
            Ara.AutoSize = true;
            Ara.Location = new Point(637, 32);
            Ara.Name = "Ara";
            Ara.Size = new Size(32, 20);
            Ara.TabIndex = 11;
            Ara.Text = "Ara";
            // 
            // txtFiltrele
            // 
            txtFiltrele.Location = new Point(675, 28);
            txtFiltrele.Name = "txtFiltrele";
            txtFiltrele.Size = new Size(125, 27);
            txtFiltrele.TabIndex = 12;
            txtFiltrele.TextChanged += txtFiltrele_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(675, 81);
            button1.Name = "button1";
            button1.Size = new Size(125, 44);
            button1.TabIndex = 13;
            button1.Text = "Stok Durum";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormBoya
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 453);
            Controls.Add(button1);
            Controls.Add(txtFiltrele);
            Controls.Add(Ara);
            Controls.Add(nudKovaAdet);
            Controls.Add(nudFiyat);
            Controls.Add(label3);
            Controls.Add(cmbKovaDurum);
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
            Name = "FormBoya";
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
    }
}