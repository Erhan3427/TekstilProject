namespace Tekstile
{
    partial class FRMSiparisYonetimi
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
            cmbMusteri = new ComboBox();
            cmbDesen = new ComboBox();
            cmbKumas = new ComboBox();
            cmbMakine = new ComboBox();
            nudAdet = new NumericUpDown();
            txtBaskiFiyat = new TextBox();
            dtpTarih = new DateTimePicker();
            btnSiparisKaydet = new Button();
            dgvSiparisler = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)nudAdet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSiparisler).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // cmbMusteri
            // 
            cmbMusteri.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMusteri.FormattingEnabled = true;
            cmbMusteri.Location = new Point(137, 40);
            cmbMusteri.Margin = new Padding(3, 4, 3, 4);
            cmbMusteri.Name = "cmbMusteri";
            cmbMusteri.Size = new Size(228, 28);
            cmbMusteri.TabIndex = 0;
            // 
            // cmbDesen
            // 
            cmbDesen.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDesen.FormattingEnabled = true;
            cmbDesen.Location = new Point(137, 93);
            cmbDesen.Margin = new Padding(3, 4, 3, 4);
            cmbDesen.Name = "cmbDesen";
            cmbDesen.Size = new Size(228, 28);
            cmbDesen.TabIndex = 1;
            // 
            // cmbKumas
            // 
            cmbKumas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKumas.FormattingEnabled = true;
            cmbKumas.Location = new Point(137, 147);
            cmbKumas.Margin = new Padding(3, 4, 3, 4);
            cmbKumas.Name = "cmbKumas";
            cmbKumas.Size = new Size(228, 28);
            cmbKumas.TabIndex = 2;
            // 
            // cmbMakine
            // 
            cmbMakine.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMakine.FormattingEnabled = true;
            cmbMakine.Location = new Point(137, 200);
            cmbMakine.Margin = new Padding(3, 4, 3, 4);
            cmbMakine.Name = "cmbMakine";
            cmbMakine.Size = new Size(228, 28);
            cmbMakine.TabIndex = 3;
            // 
            // nudAdet
            // 
            nudAdet.Location = new Point(137, 253);
            nudAdet.Margin = new Padding(3, 4, 3, 4);
            nudAdet.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudAdet.Name = "nudAdet";
            nudAdet.Size = new Size(229, 27);
            nudAdet.TabIndex = 4;
            // 
            // txtBaskiFiyat
            // 
            txtBaskiFiyat.Location = new Point(137, 307);
            txtBaskiFiyat.Margin = new Padding(3, 4, 3, 4);
            txtBaskiFiyat.Name = "txtBaskiFiyat";
            txtBaskiFiyat.Size = new Size(228, 27);
            txtBaskiFiyat.TabIndex = 5;
            txtBaskiFiyat.KeyPress += txtBaskiFiyat_KeyPress;
            // 
            // dtpTarih
            // 
            dtpTarih.Format = DateTimePickerFormat.Short;
            dtpTarih.Location = new Point(137, 360);
            dtpTarih.Margin = new Padding(3, 4, 3, 4);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(228, 27);
            dtpTarih.TabIndex = 6;
            // 
            // btnSiparisKaydet
            // 
            btnSiparisKaydet.Location = new Point(137, 413);
            btnSiparisKaydet.Margin = new Padding(3, 4, 3, 4);
            btnSiparisKaydet.Name = "btnSiparisKaydet";
            btnSiparisKaydet.Size = new Size(229, 40);
            btnSiparisKaydet.TabIndex = 7;
            btnSiparisKaydet.Text = "Sipariş Kaydet";
            btnSiparisKaydet.UseVisualStyleBackColor = true;
            btnSiparisKaydet.Click += btnSiparisKaydet_Click;
            // 
            // dgvSiparisler
            // 
            dgvSiparisler.AllowUserToAddRows = false;
            dgvSiparisler.AllowUserToDeleteRows = false;
            dgvSiparisler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSiparisler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSiparisler.Dock = DockStyle.Fill;
            dgvSiparisler.Location = new Point(3, 24);
            dgvSiparisler.Margin = new Padding(3, 4, 3, 4);
            dgvSiparisler.Name = "dgvSiparisler";
            dgvSiparisler.ReadOnly = true;
            dgvSiparisler.RowHeadersWidth = 51;
            dgvSiparisler.RowTemplate.Height = 25;
            dgvSiparisler.Size = new Size(908, 439);
            dgvSiparisler.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 44);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 9;
            label1.Text = "Müşteri:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 97);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 10;
            label2.Text = "Desen:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 151);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 11;
            label3.Text = "Kumaş:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 204);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 12;
            label4.Text = "Makine:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 257);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 13;
            label5.Text = "Adet:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 311);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 14;
            label6.Text = "Baskı Fiyatı:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 364);
            label7.Name = "label7";
            label7.Size = new Size(43, 20);
            label7.TabIndex = 15;
            label7.Text = "Tarih:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cmbMusteri);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cmbDesen);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cmbKumas);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cmbMakine);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(nudAdet);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtBaskiFiyat);
            groupBox1.Controls.Add(dtpTarih);
            groupBox1.Controls.Add(btnSiparisKaydet);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(400, 467);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sipariş Bilgileri";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvSiparisler);
            groupBox2.Location = new Point(421, 16);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(914, 467);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sipariş Listesi";
            // 
            // FRMSiparisYonetimi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1352, 493);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FRMSiparisYonetimi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sipariş Yönetimi";
            Load += FRMSiparisYonetimi_Load;
            ((System.ComponentModel.ISupportInitialize)nudAdet).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSiparisler).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.ComboBox cmbDesen;
        private System.Windows.Forms.ComboBox cmbKumas;
        private System.Windows.Forms.ComboBox cmbMakine;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.TextBox txtBaskiFiyat;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Button btnSiparisKaydet;
        private System.Windows.Forms.DataGridView dgvSiparisler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
} 