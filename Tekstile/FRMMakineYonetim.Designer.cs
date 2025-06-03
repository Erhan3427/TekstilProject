namespace Tekstile.UI
{
    partial class FRMMakineYonetim
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
            dgvMakineler = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            btnEkle = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            txtMakineAdi = new TextBox();
            txtAciklama = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMakineler).BeginInit();
            SuspendLayout();
            // 
            // dgvMakineler
            // 
            dgvMakineler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMakineler.Location = new Point(12, 248);
            dgvMakineler.Name = "dgvMakineler";
            dgvMakineler.RowHeadersWidth = 51;
            dgvMakineler.Size = new Size(710, 198);
            dgvMakineler.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 20);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 3;
            label3.Text = "label1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 20);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 3;
            label4.Text = "Makine";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(184, 171);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(107, 41);
            btnEkle.TabIndex = 5;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(297, 171);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(107, 41);
            btnSil.TabIndex = 5;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(410, 171);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(107, 41);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "Guncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // txtMakineAdi
            // 
            txtMakineAdi.Location = new Point(96, 20);
            txtMakineAdi.Name = "txtMakineAdi";
            txtMakineAdi.Size = new Size(163, 27);
            txtMakineAdi.TabIndex = 6;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(96, 62);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(255, 73);
            txtAciklama.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 62);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 3;
            label1.Text = "Açıklama";
            // 
            // FRMMakineYonetim
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1286, 450);
            Controls.Add(txtAciklama);
            Controls.Add(txtMakineAdi);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dgvMakineler);
            Name = "FRMMakineYonetim";
            Text = "FRMMakineYonetim";
            Load += FRMMakineYonetim_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMakineler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvMakineler;
        private Label label3;
        private Label label4;
        private Button btnEkle;
        private Button btnSil;
        private Button btnGuncelle;
        private TextBox txtMakineAdi;
        private TextBox txtAciklama;
        private Label label1;
    }
}