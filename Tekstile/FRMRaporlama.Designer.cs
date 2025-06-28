namespace Tekstile
{
    partial class FRMRaporlama
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
            btnMakineRaporu = new Button();
            btnKumasRaporu = new Button();
            btnCiroRaporu = new Button();
            btnMusteriRaporu = new Button();
            btnTarihRaporu = new Button();
            cmbKumas = new ComboBox();
            Kumaş = new Label();
            cmbMusteri = new ComboBox();
            label3 = new Label();
            dtpBitis = new DateTimePicker();
            label2 = new Label();
            dtpBaslangic = new DateTimePicker();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgvRapor = new DataGridView();
            groupBox3 = new GroupBox();
            lblToplamTutar = new Label();
            lblToplamSiparis = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRapor).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(lblToplamTutar);
            groupBox1.Controls.Add(btnMakineRaporu);
            groupBox1.Controls.Add(lblToplamSiparis);
            groupBox1.Controls.Add(btnKumasRaporu);
            groupBox1.Controls.Add(btnCiroRaporu);
            groupBox1.Controls.Add(btnMusteriRaporu);
            groupBox1.Controls.Add(btnTarihRaporu);
            groupBox1.Controls.Add(cmbKumas);
            groupBox1.Controls.Add(Kumaş);
            groupBox1.Controls.Add(cmbMusteri);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dtpBitis);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dtpBaslangic);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1353, 200);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rapor Filtreleri";
            // 
            // btnMakineRaporu
            // 
            btnMakineRaporu.BackColor = SystemColors.ButtonHighlight;
            btnMakineRaporu.FlatStyle = FlatStyle.Flat;
            btnMakineRaporu.Location = new Point(1086, 133);
            btnMakineRaporu.Margin = new Padding(3, 4, 3, 4);
            btnMakineRaporu.Name = "btnMakineRaporu";
            btnMakineRaporu.Size = new Size(229, 40);
            btnMakineRaporu.TabIndex = 10;
            btnMakineRaporu.Text = "Makine Raporu";
            btnMakineRaporu.UseVisualStyleBackColor = false;
            btnMakineRaporu.Click += btnMakineRaporu_Click;
            // 
            // btnKumasRaporu
            // 
            btnKumasRaporu.BackColor = SystemColors.ButtonHighlight;
            btnKumasRaporu.FlatStyle = FlatStyle.Flat;
            btnKumasRaporu.Location = new Point(1086, 80);
            btnKumasRaporu.Margin = new Padding(3, 4, 3, 4);
            btnKumasRaporu.Name = "btnKumasRaporu";
            btnKumasRaporu.Size = new Size(229, 40);
            btnKumasRaporu.TabIndex = 9;
            btnKumasRaporu.Text = "Kumaş Raporu";
            btnKumasRaporu.UseVisualStyleBackColor = false;
            btnKumasRaporu.Click += btnKumasRaporu_Click;
            // 
            // btnCiroRaporu
            // 
            btnCiroRaporu.BackColor = SystemColors.ButtonHighlight;
            btnCiroRaporu.FlatStyle = FlatStyle.Flat;
            btnCiroRaporu.Location = new Point(1086, 27);
            btnCiroRaporu.Margin = new Padding(3, 4, 3, 4);
            btnCiroRaporu.Name = "btnCiroRaporu";
            btnCiroRaporu.Size = new Size(229, 40);
            btnCiroRaporu.TabIndex = 8;
            btnCiroRaporu.Text = "Ciro Raporu";
            btnCiroRaporu.UseVisualStyleBackColor = false;
            btnCiroRaporu.Click += btnCiroRaporu_Click;
            // 
            // btnMusteriRaporu
            // 
            btnMusteriRaporu.BackColor = SystemColors.ButtonHighlight;
            btnMusteriRaporu.FlatStyle = FlatStyle.Flat;
            btnMusteriRaporu.Location = new Point(822, 133);
            btnMusteriRaporu.Margin = new Padding(3, 4, 3, 4);
            btnMusteriRaporu.Name = "btnMusteriRaporu";
            btnMusteriRaporu.Size = new Size(229, 40);
            btnMusteriRaporu.TabIndex = 7;
            btnMusteriRaporu.Text = "Müşteri Raporu";
            btnMusteriRaporu.UseVisualStyleBackColor = false;
            btnMusteriRaporu.Click += btnMusteriRaporu_Click;
            // 
            // btnTarihRaporu
            // 
            btnTarihRaporu.BackColor = SystemColors.ButtonHighlight;
            btnTarihRaporu.FlatStyle = FlatStyle.Flat;
            btnTarihRaporu.Location = new Point(822, 80);
            btnTarihRaporu.Margin = new Padding(3, 4, 3, 4);
            btnTarihRaporu.Name = "btnTarihRaporu";
            btnTarihRaporu.Size = new Size(229, 40);
            btnTarihRaporu.TabIndex = 6;
            btnTarihRaporu.Text = "Tarih Raporu";
            btnTarihRaporu.UseVisualStyleBackColor = false;
            btnTarihRaporu.Click += btnTarihRaporu_Click;
            // 
            // cmbKumas
            // 
            cmbKumas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKumas.FormattingEnabled = true;
            cmbKumas.Location = new Point(499, 28);
            cmbKumas.Margin = new Padding(3, 4, 3, 4);
            cmbKumas.Name = "cmbKumas";
            cmbKumas.Size = new Size(228, 28);
            cmbKumas.TabIndex = 5;
            // 
            // Kumaş
            // 
            Kumaş.AutoSize = true;
            Kumaş.Location = new Point(414, 31);
            Kumaş.Name = "Kumaş";
            Kumaş.Size = new Size(56, 20);
            Kumaş.TabIndex = 4;
            Kumaş.Text = "Kumaş:";
            // 
            // cmbMusteri
            // 
            cmbMusteri.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMusteri.FormattingEnabled = true;
            cmbMusteri.Location = new Point(152, 133);
            cmbMusteri.Margin = new Padding(3, 4, 3, 4);
            cmbMusteri.Name = "cmbMusteri";
            cmbMusteri.Size = new Size(228, 28);
            cmbMusteri.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 137);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 4;
            label3.Text = "Müşteri:";
            // 
            // dtpBitis
            // 
            dtpBitis.Format = DateTimePickerFormat.Short;
            dtpBitis.Location = new Point(152, 80);
            dtpBitis.Margin = new Padding(3, 4, 3, 4);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(228, 27);
            dtpBitis.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 84);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 2;
            label2.Text = "Bitiş Tarihi:";
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.Format = DateTimePickerFormat.Short;
            dtpBaslangic.Location = new Point(152, 27);
            dtpBaslangic.Margin = new Padding(3, 4, 3, 4);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.Size = new Size(228, 27);
            dtpBaslangic.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 31);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 0;
            label1.Text = "Başlangıç Tarihi:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(dgvRapor);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 200);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(1353, 548);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Rapor Sonuçları";
            // 
            // dgvRapor
            // 
            dgvRapor.AllowUserToAddRows = false;
            dgvRapor.AllowUserToDeleteRows = false;
            dgvRapor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRapor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRapor.Dock = DockStyle.Fill;
            dgvRapor.Location = new Point(3, 24);
            dgvRapor.Margin = new Padding(3, 4, 3, 4);
            dgvRapor.Name = "dgvRapor";
            dgvRapor.ReadOnly = true;
            dgvRapor.RowHeadersWidth = 51;
            dgvRapor.RowTemplate.Height = 25;
            dgvRapor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRapor.Size = new Size(1347, 520);
            dgvRapor.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Dock = DockStyle.Bottom;
            groupBox3.Location = new Point(0, 748);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(1353, 80);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Özet Bilgiler";
            // 
            // lblToplamTutar
            // 
            lblToplamTutar.AutoSize = true;
            lblToplamTutar.BackColor = Color.Transparent;
            lblToplamTutar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblToplamTutar.ForeColor = Color.Navy;
            lblToplamTutar.Location = new Point(418, 135);
            lblToplamTutar.Name = "lblToplamTutar";
            lblToplamTutar.Size = new Size(143, 28);
            lblToplamTutar.TabIndex = 1;
            lblToplamTutar.Text = "Toplam Tutar:";
            // 
            // lblToplamSiparis
            // 
            lblToplamSiparis.AutoSize = true;
            lblToplamSiparis.BackColor = Color.Transparent;
            lblToplamSiparis.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblToplamSiparis.ForeColor = Color.Navy;
            lblToplamSiparis.Location = new Point(418, 89);
            lblToplamSiparis.Name = "lblToplamSiparis";
            lblToplamSiparis.Size = new Size(155, 28);
            lblToplamSiparis.TabIndex = 0;
            lblToplamSiparis.Text = "Toplam Sipariş:";
            // 
            // FRMRaporlama
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = UI.Properties.Resources._20250627_2214_Daha_Fazla_Renk_remix_01jyscvh8hf6frkn3zz6kwgf9e;
            ClientSize = new Size(1353, 828);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FRMRaporlama";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Raporlama";
            Load += FRMRaporlama_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRapor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnMakineRaporu;
        private Button btnCiroRaporu;
        private Button btnMusteriRaporu;
        private Button btnTarihRaporu;
        private ComboBox cmbMusteri;
        private Label label3;
        private DateTimePicker dtpBitis;
        private Label label2;
        private DateTimePicker dtpBaslangic;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dgvRapor;
        private GroupBox groupBox3;
        private Label lblToplamTutar;
        private Label lblToplamSiparis;
        private Button btnKumasRaporu;
        private ComboBox cmbKumas;
        private Label Kumaş;
    }
} 