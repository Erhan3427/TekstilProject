namespace Tekstile
{
    partial class FRMGelirGiderTakibi
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
            groupBox1 = new GroupBox();
            lblBakiye = new Label();
            lblToplamGider = new Label();
            lblToplamGelir = new Label();
            btnTemizle = new Button();
            btnFiltrele = new Button();
            dtpBitis = new DateTimePicker();
            label2 = new Label();
            dtpBaslangic = new DateTimePicker();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgvGelirGider = new DataGridView();
            groupBox3 = new GroupBox();
            btnGiderEkle = new Button();
            nudTutar = new NumericUpDown();
            label5 = new Label();
            dtpGiderTarihi = new DateTimePicker();
            label4 = new Label();
            cmbGiderTuru = new ComboBox();
            label3 = new Label();
            txtAciklama = new TextBox();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGelirGider).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTutar).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblBakiye);
            groupBox1.Controls.Add(lblToplamGider);
            groupBox1.Controls.Add(lblToplamGelir);
            groupBox1.Controls.Add(btnTemizle);
            groupBox1.Controls.Add(btnFiltrele);
            groupBox1.Controls.Add(dtpBitis);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dtpBaslangic);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1182, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtreler";
            // 
            // lblBakiye
            // 
            lblBakiye.AutoSize = true;
            lblBakiye.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBakiye.Location = new Point(800, 60);
            lblBakiye.Name = "lblBakiye";
            lblBakiye.Size = new Size(107, 20);
            lblBakiye.TabIndex = 8;
            lblBakiye.Text = "Bakiye: 0,00 ₺";
            // 
            // lblToplamGider
            // 
            lblToplamGider.AutoSize = true;
            lblToplamGider.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblToplamGider.Location = new Point(800, 40);
            lblToplamGider.Name = "lblToplamGider";
            lblToplamGider.Size = new Size(134, 20);
            lblToplamGider.TabIndex = 7;
            lblToplamGider.Text = "Toplam Gider: 0 ₺";
            // 
            // lblToplamGelir
            // 
            lblToplamGelir.AutoSize = true;
            lblToplamGelir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblToplamGelir.Location = new Point(800, 20);
            lblToplamGelir.Name = "lblToplamGelir";
            lblToplamGelir.Size = new Size(129, 20);
            lblToplamGelir.TabIndex = 6;
            lblToplamGelir.Text = "Toplam Gelir: 0 ₺";
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(600, 60);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(150, 30);
            btnTemizle.TabIndex = 5;
            btnTemizle.Text = "Filtreleri Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnFiltrele
            // 
            btnFiltrele.Location = new Point(600, 20);
            btnFiltrele.Name = "btnFiltrele";
            btnFiltrele.Size = new Size(150, 30);
            btnFiltrele.TabIndex = 4;
            btnFiltrele.Text = "Filtrele";
            btnFiltrele.UseVisualStyleBackColor = true;
            btnFiltrele.Click += btnFiltrele_Click;
            // 
            // dtpBitis
            // 
            dtpBitis.Format = DateTimePickerFormat.Short;
            dtpBitis.Location = new Point(400, 20);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(150, 27);
            dtpBitis.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(340, 23);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 2;
            label2.Text = "Bitiş Tarihi:";
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.Format = DateTimePickerFormat.Short;
            dtpBaslangic.Location = new Point(120, 20);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.Size = new Size(150, 27);
            dtpBaslangic.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 23);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 0;
            label1.Text = "Başlangıç Tarihi:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvGelirGider);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 100);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1182, 432);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Gelir/Gider Listesi";
            // 
            // dgvGelirGider
            // 
            dgvGelirGider.AllowUserToAddRows = false;
            dgvGelirGider.AllowUserToDeleteRows = false;
            dgvGelirGider.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGelirGider.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGelirGider.Dock = DockStyle.Fill;
            dgvGelirGider.Location = new Point(3, 23);
            dgvGelirGider.Name = "dgvGelirGider";
            dgvGelirGider.ReadOnly = true;
            dgvGelirGider.RowHeadersWidth = 51;
            dgvGelirGider.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGelirGider.Size = new Size(1176, 406);
            dgvGelirGider.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnGiderEkle);
            groupBox3.Controls.Add(nudTutar);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(dtpGiderTarihi);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(cmbGiderTuru);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(txtAciklama);
            groupBox3.Controls.Add(label6);
            groupBox3.Dock = DockStyle.Bottom;
            groupBox3.Location = new Point(0, 532);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1182, 121);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Yeni Gider Ekle";
            // 
            // btnGiderEkle
            // 
            btnGiderEkle.Location = new Point(1000, 80);
            btnGiderEkle.Name = "btnGiderEkle";
            btnGiderEkle.Size = new Size(150, 30);
            btnGiderEkle.TabIndex = 8;
            btnGiderEkle.Text = "Gider Ekle";
            btnGiderEkle.UseVisualStyleBackColor = true;
            btnGiderEkle.Click += btnGiderEkle_Click;
            // 
            // nudTutar
            // 
            nudTutar.DecimalPlaces = 2;
            nudTutar.Location = new Point(800, 80);
            nudTutar.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudTutar.Name = "nudTutar";
            nudTutar.Size = new Size(150, 27);
            nudTutar.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(750, 83);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 6;
            label5.Text = "Tutar:";
            // 
            // dtpGiderTarihi
            // 
            dtpGiderTarihi.Format = DateTimePickerFormat.Short;
            dtpGiderTarihi.Location = new Point(800, 30);
            dtpGiderTarihi.Name = "dtpGiderTarihi";
            dtpGiderTarihi.Size = new Size(150, 27);
            dtpGiderTarihi.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(750, 33);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 4;
            label4.Text = "Tarih:";
            // 
            // cmbGiderTuru
            // 
            cmbGiderTuru.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGiderTuru.FormattingEnabled = true;
            cmbGiderTuru.Location = new Point(120, 80);
            cmbGiderTuru.Name = "cmbGiderTuru";
            cmbGiderTuru.Size = new Size(200, 28);
            cmbGiderTuru.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 83);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 2;
            label3.Text = "Gider Türü:";
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(120, 30);
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(600, 27);
            txtAciklama.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 33);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 0;
            label6.Text = "Açıklama:";
            // 
            // FRMGelirGiderTakibi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            MaximumSize = new Size(1200, 700);
            MinimumSize = new Size(1200, 700);
            Name = "FRMGelirGiderTakibi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gelir/Gider Takibi";
            Load += FRMGelirGiderTakibi_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGelirGider).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTutar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblBakiye;
        private Label lblToplamGider;
        private Label lblToplamGelir;
        private Button btnTemizle;
        private Button btnFiltrele;
        private DateTimePicker dtpBitis;
        private Label label2;
        private DateTimePicker dtpBaslangic;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dgvGelirGider;
        private GroupBox groupBox3;
        private Button btnGiderEkle;
        private NumericUpDown nudTutar;
        private Label label5;
        private DateTimePicker dtpGiderTarihi;
        private Label label4;
        private ComboBox cmbGiderTuru;
        private Label label3;
        private TextBox txtAciklama;
        private Label label6;
    }
} 