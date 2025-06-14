namespace Tekstile
{
    partial class FRMLogKayitlari
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
            btnTemizle = new Button();
            btnFiltrele = new Button();
            cmbIslemTuru = new ComboBox();
            label4 = new Label();
            cmbKullanici = new ComboBox();
            label3 = new Label();
            dtpBitis = new DateTimePicker();
            label2 = new Label();
            dtpBaslangic = new DateTimePicker();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgvLoglar = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoglar).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTemizle);
            groupBox1.Controls.Add(btnFiltrele);
            groupBox1.Controls.Add(cmbIslemTuru);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cmbKullanici);
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
            groupBox1.Size = new Size(1353, 192);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtreler";
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(1086, 133);
            btnTemizle.Margin = new Padding(3, 4, 3, 4);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(229, 40);
            btnTemizle.TabIndex = 9;
            btnTemizle.Text = "Filtreleri Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnFiltrele
            // 
            btnFiltrele.Location = new Point(1086, 80);
            btnFiltrele.Margin = new Padding(3, 4, 3, 4);
            btnFiltrele.Name = "btnFiltrele";
            btnFiltrele.Size = new Size(229, 40);
            btnFiltrele.TabIndex = 8;
            btnFiltrele.Text = "Filtrele";
            btnFiltrele.UseVisualStyleBackColor = true;
            btnFiltrele.Click += btnFiltrele_Click;
            // 
            // cmbIslemTuru
            // 
            cmbIslemTuru.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIslemTuru.FormattingEnabled = true;
            cmbIslemTuru.Location = new Point(137, 133);
            cmbIslemTuru.Margin = new Padding(3, 4, 3, 4);
            cmbIslemTuru.Name = "cmbIslemTuru";
            cmbIslemTuru.Size = new Size(228, 28);
            cmbIslemTuru.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 137);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 6;
            label4.Text = "İşlem Türü:";
            // 
            // cmbKullanici
            // 
            cmbKullanici.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKullanici.FormattingEnabled = true;
            cmbKullanici.Location = new Point(137, 80);
            cmbKullanici.Margin = new Padding(3, 4, 3, 4);
            cmbKullanici.Name = "cmbKullanici";
            cmbKullanici.Size = new Size(228, 28);
            cmbKullanici.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 84);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 4;
            label3.Text = "Kullanıcı:";
            // 
            // dtpBitis
            // 
            dtpBitis.Format = DateTimePickerFormat.Short;
            dtpBitis.Location = new Point(457, 27);
            dtpBitis.Margin = new Padding(3, 4, 3, 4);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(228, 27);
            dtpBitis.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(389, 31);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 2;
            label2.Text = "Bitiş Tarihi:";
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.Format = DateTimePickerFormat.Short;
            dtpBaslangic.Location = new Point(137, 27);
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
            groupBox2.Controls.Add(dgvLoglar);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 192);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(1353, 321);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Log Kayıtları";
            // 
            // dgvLoglar
            // 
            dgvLoglar.AllowUserToAddRows = false;
            dgvLoglar.AllowUserToDeleteRows = false;
            dgvLoglar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoglar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoglar.Dock = DockStyle.Fill;
            dgvLoglar.Location = new Point(3, 24);
            dgvLoglar.Margin = new Padding(3, 4, 3, 4);
            dgvLoglar.Name = "dgvLoglar";
            dgvLoglar.ReadOnly = true;
            dgvLoglar.RowHeadersWidth = 51;
            dgvLoglar.RowTemplate.Height = 25;
            dgvLoglar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLoglar.Size = new Size(1347, 293);
            dgvLoglar.TabIndex = 0;
            // 
            // FRMLogKayitlari
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1353, 513);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FRMLogKayitlari";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log Kayıtları";
            Load += FRMLogKayitlari_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLoglar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnTemizle;
        private Button btnFiltrele;
        private ComboBox cmbIslemTuru;
        private Label label4;
        private ComboBox cmbKullanici;
        private Label label3;
        private DateTimePicker dtpBitis;
        private Label label2;
        private DateTimePicker dtpBaslangic;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dgvLoglar;
    }
} 