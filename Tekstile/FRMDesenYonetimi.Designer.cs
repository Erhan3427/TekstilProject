namespace Tekstile
{
    partial class FRMDesenYonetimi
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
            cmbBoyalar = new ComboBox();
            cmbMusteri = new ComboBox();
            nudGram = new NumericUpDown();
            btnKaydet = new Button();
            txtDesenAdi = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pbDesen = new PictureBox();
            txtAciklama = new TextBox();
            label7 = new Label();
            nudBoyaSayisi = new NumericUpDown();
            label6 = new Label();
            dgvDesenler = new DataGridView();
            btnDesenEkle = new Button();
            btnBoyaEkle = new Button();
            colorDialog1 = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)nudGram).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDesen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBoyaSayisi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDesenler).BeginInit();
            SuspendLayout();
            // 
            // cmbBoyalar
            // 
            cmbBoyalar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoyalar.Enabled = false;
            cmbBoyalar.FormattingEnabled = true;
            cmbBoyalar.Location = new Point(1014, 72);
            cmbBoyalar.Name = "cmbBoyalar";
            cmbBoyalar.Size = new Size(151, 28);
            cmbBoyalar.TabIndex = 0;
            // 
            // cmbMusteri
            // 
            cmbMusteri.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMusteri.FormattingEnabled = true;
            cmbMusteri.Location = new Point(555, 83);
            cmbMusteri.Name = "cmbMusteri";
            cmbMusteri.Size = new Size(151, 28);
            cmbMusteri.TabIndex = 0;
            cmbMusteri.SelectedIndexChanged += cmbMusteri_SelectedIndexChanged;
            // 
            // nudGram
            // 
            nudGram.DecimalPlaces = 2;
            nudGram.Enabled = false;
            nudGram.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nudGram.Location = new Point(1015, 121);
            nudGram.Name = "nudGram";
            nudGram.Size = new Size(150, 27);
            nudGram.TabIndex = 1;
            // 
            // btnKaydet
            // 
            btnKaydet.Enabled = false;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Location = new Point(728, 95);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(126, 49);
            btnKaydet.TabIndex = 2;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtDesenAdi
            // 
            txtDesenAdi.Location = new Point(96, 39);
            txtDesenAdi.Name = "txtDesenAdi";
            txtDesenAdi.Size = new Size(210, 27);
            txtDesenAdi.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 46);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 4;
            label1.Text = "Desen Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 84);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 4;
            label2.Text = "Desen ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(923, 80);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 4;
            label3.Text = "Boyalar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(465, 91);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 4;
            label4.Text = "Musteri";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 283);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 4;
            label5.Text = "Açıklama";
            // 
            // pbDesen
            // 
            pbDesen.BackColor = SystemColors.ButtonHighlight;
            pbDesen.Location = new Point(96, 84);
            pbDesen.Name = "pbDesen";
            pbDesen.Size = new Size(257, 193);
            pbDesen.TabIndex = 5;
            pbDesen.TabStop = false;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(96, 283);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(257, 145);
            txtAciklama.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(937, 124);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 4;
            label7.Text = "Gram";
            // 
            // nudBoyaSayisi
            // 
            nudBoyaSayisi.Location = new Point(555, 117);
            nudBoyaSayisi.Name = "nudBoyaSayisi";
            nudBoyaSayisi.Size = new Size(150, 27);
            nudBoyaSayisi.TabIndex = 1;
            nudBoyaSayisi.ValueChanged += nudBoyaSayisi_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(465, 124);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 4;
            label6.Text = "Boya Sayısı";
            // 
            // dgvDesenler
            // 
            dgvDesenler.AllowUserToAddRows = false;
            dgvDesenler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDesenler.Location = new Point(452, 228);
            dgvDesenler.Name = "dgvDesenler";
            dgvDesenler.ReadOnly = true;
            dgvDesenler.RowHeadersWidth = 51;
            dgvDesenler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDesenler.Size = new Size(863, 210);
            dgvDesenler.TabIndex = 7;
            // 
            // btnDesenEkle
            // 
            btnDesenEkle.FlatStyle = FlatStyle.Flat;
            btnDesenEkle.Location = new Point(359, 220);
            btnDesenEkle.Name = "btnDesenEkle";
            btnDesenEkle.Size = new Size(87, 57);
            btnDesenEkle.TabIndex = 8;
            btnDesenEkle.Text = "Desen Ekle";
            btnDesenEkle.UseVisualStyleBackColor = true;
            btnDesenEkle.Click += btnDesenEkle_Click;
            // 
            // btnBoyaEkle
            // 
            btnBoyaEkle.FlatStyle = FlatStyle.Flat;
            btnBoyaEkle.Location = new Point(1191, 94);
            btnBoyaEkle.Name = "btnBoyaEkle";
            btnBoyaEkle.Size = new Size(94, 54);
            btnBoyaEkle.TabIndex = 9;
            btnBoyaEkle.Text = "Boya Ekle";
            btnBoyaEkle.UseVisualStyleBackColor = true;
            btnBoyaEkle.Click += btnBoyaEkle_Click;
            // 
            // FRMDesenYonetimi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = UI.Properties.Resources._20250627_2214_Daha_Fazla_Renk_remix_01jyscvh8hf6frkn3zz6kwgf9e;
            ClientSize = new Size(1382, 516);
            Controls.Add(btnBoyaEkle);
            Controls.Add(btnDesenEkle);
            Controls.Add(dgvDesenler);
            Controls.Add(txtAciklama);
            Controls.Add(pbDesen);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDesenAdi);
            Controls.Add(btnKaydet);
            Controls.Add(nudBoyaSayisi);
            Controls.Add(nudGram);
            Controls.Add(cmbMusteri);
            Controls.Add(cmbBoyalar);
            Name = "FRMDesenYonetimi";
            Text = "DesenYonetim";
            Load += FRMDesenYonetimi_Load;
            ((System.ComponentModel.ISupportInitialize)nudGram).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDesen).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudBoyaSayisi).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDesenler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbBoyalar;
        private ComboBox cmbMusteri;
        private NumericUpDown nudGram;
        private Button btnKaydet;
        private TextBox txtDesenAdi;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pbDesen;
        private TextBox txtAciklama;
        private Label label7;
        private NumericUpDown nudBoyaSayisi;
        private Label label6;
        private DataGridView dgvDesenler;
        private Button btnDesenEkle;
        private Button btnBoyaEkle;
        private ColorDialog colorDialog1;
    }
}