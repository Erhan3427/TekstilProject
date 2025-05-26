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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            label7 = new Label();
            nudBoyaSayisi = new NumericUpDown();
            label6 = new Label();
            dgvDesenler = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nudGram).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBoyaSayisi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDesenler).BeginInit();
            SuspendLayout();
            // 
            // cmbBoyalar
            // 
            cmbBoyalar.FormattingEnabled = true;
            cmbBoyalar.Location = new Point(542, 38);
            cmbBoyalar.Name = "cmbBoyalar";
            cmbBoyalar.Size = new Size(151, 28);
            cmbBoyalar.TabIndex = 0;
            // 
            // cmbMusteri
            // 
            cmbMusteri.FormattingEnabled = true;
            cmbMusteri.Location = new Point(542, 72);
            cmbMusteri.Name = "cmbMusteri";
            cmbMusteri.Size = new Size(151, 28);
            cmbMusteri.TabIndex = 0;
            // 
            // nudGram
            // 
            nudGram.Location = new Point(543, 106);
            nudGram.Name = "nudGram";
            nudGram.Size = new Size(150, 27);
            nudGram.TabIndex = 1;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(747, 127);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(126, 49);
            btnKaydet.TabIndex = 2;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(96, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 27);
            textBox1.TabIndex = 3;
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
            label3.Location = new Point(452, 46);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 4;
            label3.Text = "Boyalar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(453, 84);
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
            // pictureBox1
            // 
            pictureBox1.Location = new Point(96, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(257, 193);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(96, 283);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(257, 145);
            textBox2.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(453, 117);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 4;
            label7.Text = "Gram";
            // 
            // nudBoyaSayisi
            // 
            nudBoyaSayisi.Location = new Point(543, 139);
            nudBoyaSayisi.Name = "nudBoyaSayisi";
            nudBoyaSayisi.Size = new Size(150, 27);
            nudBoyaSayisi.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(453, 146);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 4;
            label6.Text = "Boya Sayısı";
            // 
            // dgvDesenler
            // 
            dgvDesenler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDesenler.Location = new Point(452, 272);
            dgvDesenler.Name = "dgvDesenler";
            dgvDesenler.RowHeadersWidth = 51;
            dgvDesenler.Size = new Size(643, 166);
            dgvDesenler.TabIndex = 7;
            // 
            // FRMDesenYonetimi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 450);
            Controls.Add(dgvDesenler);
            Controls.Add(textBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(btnKaydet);
            Controls.Add(nudBoyaSayisi);
            Controls.Add(nudGram);
            Controls.Add(cmbMusteri);
            Controls.Add(cmbBoyalar);
            Name = "FRMDesenYonetimi";
            Text = "DesenYonetim";
            Load += FRMDesenYonetimi_Load;
            ((System.ComponentModel.ISupportInitialize)nudGram).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private Label label7;
        private NumericUpDown nudBoyaSayisi;
        private Label label6;
        private DataGridView dgvDesenler;
    }
}