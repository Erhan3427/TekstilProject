namespace Tekstile.UI
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
            cmbDesen = new ComboBox();
            btnEkle = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            dgvMakine = new DataGridView();
            cmbMusteri = new ComboBox();
            cmbMakine = new ComboBox();
            lblMakine = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMakine).BeginInit();
            SuspendLayout();
            // 
            // cmbDesen
            // 
            cmbDesen.FormattingEnabled = true;
            cmbDesen.Location = new Point(189, 70);
            cmbDesen.Name = "cmbDesen";
            cmbDesen.Size = new Size(151, 28);
            cmbDesen.TabIndex = 0;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(391, 175);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(106, 47);
            btnEkle.TabIndex = 1;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(503, 175);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(106, 47);
            btnSil.TabIndex = 1;
            btnSil.Text = "Sil ";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(615, 175);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(106, 47);
            btnGuncelle.TabIndex = 1;
            btnGuncelle.Text = "Guncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // dgvMakine
            // 
            dgvMakine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMakine.Location = new Point(12, 241);
            dgvMakine.Name = "dgvMakine";
            dgvMakine.RowHeadersWidth = 51;
            dgvMakine.Size = new Size(776, 197);
            dgvMakine.TabIndex = 2;
            // 
            // cmbMusteri
            // 
            cmbMusteri.FormattingEnabled = true;
            cmbMusteri.Location = new Point(189, 104);
            cmbMusteri.Name = "cmbMusteri";
            cmbMusteri.Size = new Size(151, 28);
            cmbMusteri.TabIndex = 0;
            // 
            // cmbMakine
            // 
            cmbMakine.FormattingEnabled = true;
            cmbMakine.Location = new Point(189, 36);
            cmbMakine.Name = "cmbMakine";
            cmbMakine.Size = new Size(151, 28);
            cmbMakine.TabIndex = 3;
            // 
            // lblMakine
            // 
            lblMakine.AutoSize = true;
            lblMakine.Location = new Point(74, 44);
            lblMakine.Name = "lblMakine";
            lblMakine.Size = new Size(57, 20);
            lblMakine.TabIndex = 4;
            lblMakine.Text = "Makine";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 78);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 4;
            label2.Text = "Desen";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 112);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 4;
            label3.Text = "Musteri";
            // 
            // FRMMakineYonetimi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblMakine);
            Controls.Add(cmbMakine);
            Controls.Add(dgvMakine);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(cmbMusteri);
            Controls.Add(cmbDesen);
            Name = "FRMMakineYonetimi";
            Text = "FRMMakineYonetimi";
            ((System.ComponentModel.ISupportInitialize)dgvMakine).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbDesen;
        private Button btnEkle;
        private Button btnSil;
        private Button btnGuncelle;
        private DataGridView dgvMakine;
        private ComboBox cmbMusteri;
        private ComboBox cmbMakine;
        private Label lblMakine;
        private Label label2;
        private Label label3;
    }
}