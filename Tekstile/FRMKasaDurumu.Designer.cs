namespace Tekstile
{
    partial class FRMKasaDurumu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblToplamGelir = new Label();
            lblToplamGider = new Label();
            lblBakiye = new Label();
            txtToplamGelir = new TextBox();
            txtToplamGider = new TextBox();
            txtBakiye = new TextBox();
            cmbRaporTuru = new ComboBox();
            dtpRaporTarih = new DateTimePicker();
            btnRaporla = new Button();
            dgvKasaRaporu = new DataGridView();
            lblRaporTuru = new Label();
            lblRaporTarih = new Label();
            gbKasaDurum = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvKasaRaporu).BeginInit();
            SuspendLayout();
            // 
            // lblToplamGelir
            // 
            lblToplamGelir.AutoSize = true;
            lblToplamGelir.Location = new Point(30, 38);
            lblToplamGelir.Name = "lblToplamGelir";
            lblToplamGelir.Size = new Size(94, 20);
            lblToplamGelir.TabIndex = 0;
            lblToplamGelir.Text = "Toplam Gelir";
            // 
            // lblToplamGider
            // 
            lblToplamGider.AutoSize = true;
            lblToplamGider.Location = new Point(30, 88);
            lblToplamGider.Name = "lblToplamGider";
            lblToplamGider.Size = new Size(99, 20);
            lblToplamGider.TabIndex = 1;
            lblToplamGider.Text = "Toplam Gider";
            // 
            // lblBakiye
            // 
            lblBakiye.AutoSize = true;
            lblBakiye.Location = new Point(30, 138);
            lblBakiye.Name = "lblBakiye";
            lblBakiye.Size = new Size(52, 20);
            lblBakiye.TabIndex = 2;
            lblBakiye.Text = "Bakiye";
            // 
            // txtToplamGelir
            // 
            txtToplamGelir.Location = new Point(140, 34);
            txtToplamGelir.Margin = new Padding(3, 4, 3, 4);
            txtToplamGelir.Name = "txtToplamGelir";
            txtToplamGelir.ReadOnly = true;
            txtToplamGelir.Size = new Size(180, 27);
            txtToplamGelir.TabIndex = 3;
            // 
            // txtToplamGider
            // 
            txtToplamGider.Location = new Point(140, 84);
            txtToplamGider.Margin = new Padding(3, 4, 3, 4);
            txtToplamGider.Name = "txtToplamGider";
            txtToplamGider.ReadOnly = true;
            txtToplamGider.Size = new Size(180, 27);
            txtToplamGider.TabIndex = 4;
            // 
            // txtBakiye
            // 
            txtBakiye.Location = new Point(140, 134);
            txtBakiye.Margin = new Padding(3, 4, 3, 4);
            txtBakiye.Name = "txtBakiye";
            txtBakiye.ReadOnly = true;
            txtBakiye.Size = new Size(180, 27);
            txtBakiye.TabIndex = 5;
            // 
            // cmbRaporTuru
            // 
            cmbRaporTuru.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRaporTuru.FormattingEnabled = true;
            cmbRaporTuru.Items.AddRange(new object[] { "Günlük", "Aylık", "Yıllık" });
            cmbRaporTuru.Location = new Point(500, 34);
            cmbRaporTuru.Margin = new Padding(3, 4, 3, 4);
            cmbRaporTuru.Name = "cmbRaporTuru";
            cmbRaporTuru.Size = new Size(150, 28);
            cmbRaporTuru.TabIndex = 6;
            // 
            // dtpRaporTarih
            // 
            dtpRaporTarih.Location = new Point(500, 84);
            dtpRaporTarih.Margin = new Padding(3, 4, 3, 4);
            dtpRaporTarih.Name = "dtpRaporTarih";
            dtpRaporTarih.Size = new Size(200, 27);
            dtpRaporTarih.TabIndex = 7;
            // 
            // btnRaporla
            // 
            btnRaporla.FlatStyle = FlatStyle.Flat;
            btnRaporla.Location = new Point(740, 34);
            btnRaporla.Margin = new Padding(3, 4, 3, 4);
            btnRaporla.Name = "btnRaporla";
            btnRaporla.Size = new Size(121, 44);
            btnRaporla.TabIndex = 8;
            btnRaporla.Text = "Raporla";
            btnRaporla.UseVisualStyleBackColor = true;
            // 
            // dgvKasaRaporu
            // 
            dgvKasaRaporu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKasaRaporu.Location = new Point(12, 251);
            dgvKasaRaporu.Margin = new Padding(3, 4, 3, 4);
            dgvKasaRaporu.Name = "dgvKasaRaporu";
            dgvKasaRaporu.RowHeadersWidth = 51;
            dgvKasaRaporu.RowTemplate.Height = 24;
            dgvKasaRaporu.Size = new Size(1329, 249);
            dgvKasaRaporu.TabIndex = 9;
            // 
            // lblRaporTuru
            // 
            lblRaporTuru.AutoSize = true;
            lblRaporTuru.Location = new Point(400, 38);
            lblRaporTuru.Name = "lblRaporTuru";
            lblRaporTuru.Size = new Size(82, 20);
            lblRaporTuru.TabIndex = 10;
            lblRaporTuru.Text = "Rapor Türü";
            // 
            // lblRaporTarih
            // 
            lblRaporTarih.AutoSize = true;
            lblRaporTarih.Location = new Point(400, 88);
            lblRaporTarih.Name = "lblRaporTarih";
            lblRaporTarih.Size = new Size(88, 20);
            lblRaporTarih.TabIndex = 11;
            lblRaporTarih.Text = "Rapor Tarihi";
            // 
            // gbKasaDurum
            // 
            gbKasaDurum.BackColor = Color.Transparent;
            gbKasaDurum.Location = new Point(20, 12);
            gbKasaDurum.Name = "gbKasaDurum";
            gbKasaDurum.Size = new Size(1321, 181);
            gbKasaDurum.TabIndex = 12;
            gbKasaDurum.TabStop = false;
            gbKasaDurum.Text = "Kasa Durumu";
            // 
            // FRMKasaDurumu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = UI.Properties.Resources._20250627_2211_Soyut_Renkler_remix_01jyscpdczesgsfaqrdnwr42j4;
            ClientSize = new Size(1353, 513);
            Controls.Add(lblRaporTarih);
            Controls.Add(lblRaporTuru);
            Controls.Add(dgvKasaRaporu);
            Controls.Add(btnRaporla);
            Controls.Add(dtpRaporTarih);
            Controls.Add(cmbRaporTuru);
            Controls.Add(txtBakiye);
            Controls.Add(txtToplamGider);
            Controls.Add(txtToplamGelir);
            Controls.Add(lblBakiye);
            Controls.Add(lblToplamGider);
            Controls.Add(lblToplamGelir);
            Controls.Add(gbKasaDurum);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FRMKasaDurumu";
            Text = "Kasa Durumu / Bakiye Takibi";
            Load += FRMKasaDurumu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKasaRaporu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblToplamGelir;
        private System.Windows.Forms.Label lblToplamGider;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.TextBox txtToplamGelir;
        private System.Windows.Forms.TextBox txtToplamGider;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.ComboBox cmbRaporTuru;
        private System.Windows.Forms.DateTimePicker dtpRaporTarih;
        private System.Windows.Forms.Button btnRaporla;
        private System.Windows.Forms.DataGridView dgvKasaRaporu;
        private System.Windows.Forms.Label lblRaporTuru;
        private System.Windows.Forms.Label lblRaporTarih;
        private GroupBox gbKasaDurum;
    }
} 