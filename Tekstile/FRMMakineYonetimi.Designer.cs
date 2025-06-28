namespace Tekstile
{
    partial class FRMMakineYonetimi
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
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            dgvMakineler = new DataGridView();
            groupBox2 = new GroupBox();
            btnMakineSil = new Button();
            btnMakineGuncelle = new Button();
            btnMakineEkle = new Button();
            txtMakineAciklama = new TextBox();
            txtMakineAdi = new TextBox();
            label4 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            dgvKumaslar = new DataGridView();
            groupBox4 = new GroupBox();
            btnKumasSil = new Button();
            btnKumasGuncelle = new Button();
            btnKumasEkle = new Button();
            nudGramaj = new NumericUpDown();
            txtiplikTipi = new TextBox();
            txtKumasAdi = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMakineler).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKumaslar).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudGramaj).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = Color.Transparent;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            splitContainer1.Panel1.Controls.Add(groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox3);
            splitContainer1.Panel2.Controls.Add(groupBox4);
            splitContainer1.Size = new Size(1352, 516);
            splitContainer1.SplitterDistance = 675;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(dgvMakineler);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(675, 333);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Makine Listesi";
            // 
            // dgvMakineler
            // 
            dgvMakineler.AllowUserToAddRows = false;
            dgvMakineler.AllowUserToDeleteRows = false;
            dgvMakineler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMakineler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMakineler.Dock = DockStyle.Fill;
            dgvMakineler.Location = new Point(3, 24);
            dgvMakineler.Margin = new Padding(3, 4, 3, 4);
            dgvMakineler.Name = "dgvMakineler";
            dgvMakineler.ReadOnly = true;
            dgvMakineler.RowHeadersWidth = 51;
            dgvMakineler.RowTemplate.Height = 25;
            dgvMakineler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMakineler.Size = new Size(669, 305);
            dgvMakineler.TabIndex = 0;
            dgvMakineler.CellClick += dgvMakineler_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(btnMakineSil);
            groupBox2.Controls.Add(btnMakineGuncelle);
            groupBox2.Controls.Add(btnMakineEkle);
            groupBox2.Controls.Add(txtMakineAciklama);
            groupBox2.Controls.Add(txtMakineAdi);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label1);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 333);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(675, 183);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Makine İşlemleri";
            // 
            // btnMakineSil
            // 
            btnMakineSil.BackColor = Color.IndianRed;
            btnMakineSil.FlatStyle = FlatStyle.Flat;
            btnMakineSil.ForeColor = SystemColors.Window;
            btnMakineSil.Location = new Point(441, 79);
            btnMakineSil.Margin = new Padding(3, 4, 3, 4);
            btnMakineSil.Name = "btnMakineSil";
            btnMakineSil.Size = new Size(230, 40);
            btnMakineSil.TabIndex = 4;
            btnMakineSil.Text = "Sil";
            btnMakineSil.UseVisualStyleBackColor = false;
            btnMakineSil.Click += btnMakineSil_Click;
            // 
            // btnMakineGuncelle
            // 
            btnMakineGuncelle.BackColor = Color.SteelBlue;
            btnMakineGuncelle.FlatStyle = FlatStyle.Flat;
            btnMakineGuncelle.ForeColor = SystemColors.Window;
            btnMakineGuncelle.Location = new Point(441, 31);
            btnMakineGuncelle.Margin = new Padding(3, 4, 3, 4);
            btnMakineGuncelle.Name = "btnMakineGuncelle";
            btnMakineGuncelle.Size = new Size(230, 40);
            btnMakineGuncelle.TabIndex = 3;
            btnMakineGuncelle.Text = "Güncelle";
            btnMakineGuncelle.UseVisualStyleBackColor = false;
            btnMakineGuncelle.Click += btnMakineGuncelle_Click;
            // 
            // btnMakineEkle
            // 
            btnMakineEkle.BackColor = Color.MediumSeaGreen;
            btnMakineEkle.FlatStyle = FlatStyle.Flat;
            btnMakineEkle.ForeColor = SystemColors.Window;
            btnMakineEkle.Location = new Point(137, 111);
            btnMakineEkle.Margin = new Padding(3, 4, 3, 4);
            btnMakineEkle.Name = "btnMakineEkle";
            btnMakineEkle.Size = new Size(229, 40);
            btnMakineEkle.TabIndex = 2;
            btnMakineEkle.Text = "Ekle";
            btnMakineEkle.UseVisualStyleBackColor = false;
            btnMakineEkle.Click += btnMakineEkle_Click;
            // 
            // txtMakineAciklama
            // 
            txtMakineAciklama.Location = new Point(137, 61);
            txtMakineAciklama.Margin = new Padding(3, 4, 3, 4);
            txtMakineAciklama.Multiline = true;
            txtMakineAciklama.Name = "txtMakineAciklama";
            txtMakineAciklama.Size = new Size(229, 42);
            txtMakineAciklama.TabIndex = 1;
            // 
            // txtMakineAdi
            // 
            txtMakineAdi.Location = new Point(137, 27);
            txtMakineAdi.Margin = new Padding(3, 4, 3, 4);
            txtMakineAdi.Name = "txtMakineAdi";
            txtMakineAdi.Size = new Size(228, 27);
            txtMakineAdi.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(23, 61);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 0;
            label4.Text = "Açıklama:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(23, 31);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "Makine Adı:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(dgvKumaslar);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(672, 333);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kumaş Listesi";
            // 
            // dgvKumaslar
            // 
            dgvKumaslar.AllowUserToAddRows = false;
            dgvKumaslar.AllowUserToDeleteRows = false;
            dgvKumaslar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKumaslar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKumaslar.Dock = DockStyle.Fill;
            dgvKumaslar.Location = new Point(3, 24);
            dgvKumaslar.Margin = new Padding(3, 4, 3, 4);
            dgvKumaslar.Name = "dgvKumaslar";
            dgvKumaslar.ReadOnly = true;
            dgvKumaslar.RowHeadersWidth = 51;
            dgvKumaslar.RowTemplate.Height = 25;
            dgvKumaslar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKumaslar.Size = new Size(666, 305);
            dgvKumaslar.TabIndex = 0;
            dgvKumaslar.CellClick += dgvKumaslar_CellClick;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.Transparent;
            groupBox4.Controls.Add(btnKumasSil);
            groupBox4.Controls.Add(btnKumasGuncelle);
            groupBox4.Controls.Add(btnKumasEkle);
            groupBox4.Controls.Add(nudGramaj);
            groupBox4.Controls.Add(txtiplikTipi);
            groupBox4.Controls.Add(txtKumasAdi);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(label2);
            groupBox4.Dock = DockStyle.Bottom;
            groupBox4.Location = new Point(0, 333);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(672, 183);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Kumaş İşlemleri";
            // 
            // btnKumasSil
            // 
            btnKumasSil.BackColor = Color.IndianRed;
            btnKumasSil.FlatStyle = FlatStyle.Flat;
            btnKumasSil.ForeColor = SystemColors.Window;
            btnKumasSil.Location = new Point(436, 75);
            btnKumasSil.Margin = new Padding(3, 4, 3, 4);
            btnKumasSil.Name = "btnKumasSil";
            btnKumasSil.Size = new Size(230, 40);
            btnKumasSil.TabIndex = 6;
            btnKumasSil.Text = "Sil";
            btnKumasSil.UseVisualStyleBackColor = false;
            btnKumasSil.Click += btnKumasSil_Click;
            // 
            // btnKumasGuncelle
            // 
            btnKumasGuncelle.BackColor = Color.SteelBlue;
            btnKumasGuncelle.FlatStyle = FlatStyle.Flat;
            btnKumasGuncelle.ForeColor = SystemColors.Window;
            btnKumasGuncelle.Location = new Point(436, 27);
            btnKumasGuncelle.Margin = new Padding(3, 4, 3, 4);
            btnKumasGuncelle.Name = "btnKumasGuncelle";
            btnKumasGuncelle.Size = new Size(230, 40);
            btnKumasGuncelle.TabIndex = 5;
            btnKumasGuncelle.Text = "Güncelle";
            btnKumasGuncelle.UseVisualStyleBackColor = false;
            btnKumasGuncelle.Click += btnKumasGuncelle_Click;
            // 
            // btnKumasEkle
            // 
            btnKumasEkle.BackColor = Color.MediumSeaGreen;
            btnKumasEkle.FlatStyle = FlatStyle.Flat;
            btnKumasEkle.ForeColor = SystemColors.Window;
            btnKumasEkle.Location = new Point(136, 125);
            btnKumasEkle.Margin = new Padding(3, 4, 3, 4);
            btnKumasEkle.Name = "btnKumasEkle";
            btnKumasEkle.Size = new Size(229, 40);
            btnKumasEkle.TabIndex = 4;
            btnKumasEkle.Text = "Ekle";
            btnKumasEkle.UseVisualStyleBackColor = false;
            btnKumasEkle.Click += btnKumasEkle_Click;
            // 
            // nudGramaj
            // 
            nudGramaj.DecimalPlaces = 2;
            nudGramaj.Location = new Point(136, 62);
            nudGramaj.Margin = new Padding(3, 4, 3, 4);
            nudGramaj.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudGramaj.Name = "nudGramaj";
            nudGramaj.Size = new Size(228, 27);
            nudGramaj.TabIndex = 3;
            // 
            // txtiplikTipi
            // 
            txtiplikTipi.Location = new Point(136, 92);
            txtiplikTipi.Margin = new Padding(3, 4, 3, 4);
            txtiplikTipi.Name = "txtiplikTipi";
            txtiplikTipi.Size = new Size(228, 27);
            txtiplikTipi.TabIndex = 2;
            // 
            // txtKumasAdi
            // 
            txtKumasAdi.Location = new Point(137, 27);
            txtKumasAdi.Margin = new Padding(3, 4, 3, 4);
            txtKumasAdi.Name = "txtKumasAdi";
            txtKumasAdi.Size = new Size(228, 27);
            txtKumasAdi.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(23, 99);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 1;
            label5.Text = "İplik Tipi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(23, 69);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 1;
            label3.Text = "Gramaj:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(23, 31);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 0;
            label2.Text = "Kumaş Adı:";
            // 
            // FRMMakineYonetimi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = UI.Properties.Resources._20250627_2214_Daha_Fazla_Renk_remix_01jyscvh8hf6frkn3zz6kwgf9e;
            ClientSize = new Size(1352, 516);
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FRMMakineYonetimi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Makine ve Kumaş Yönetimi";
            Load += FRMMakineYonetimi_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMakineler).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKumaslar).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudGramaj).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvMakineler;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMakineSil;
        private System.Windows.Forms.Button btnMakineGuncelle;
        private System.Windows.Forms.Button btnMakineEkle;
        private System.Windows.Forms.TextBox txtMakineAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvKumaslar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnKumasSil;
        private System.Windows.Forms.Button btnKumasGuncelle;
        private System.Windows.Forms.Button btnKumasEkle;
        private System.Windows.Forms.NumericUpDown nudGramaj;
        private System.Windows.Forms.TextBox txtKumasAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private TextBox txtMakineAciklama;
        private Label label4;
        private TextBox txtiplikTipi;
        private Label label5;
    }
} 