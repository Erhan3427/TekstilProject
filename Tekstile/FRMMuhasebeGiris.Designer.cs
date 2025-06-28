namespace Tekstile.UI
{
    partial class FRMMuhasebeGiris
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
            pnlYonetim = new Panel();
            btnCikis = new Button();
            btnGider = new Button();
            btnRaporlama = new Button();
            btnKasaDurum = new Button();
            btnCalisanlar = new Button();
            btnGelir = new Button();
            SuspendLayout();
            // 
            // pnlYonetim
            // 
            pnlYonetim.BackColor = Color.Transparent;
            pnlYonetim.Location = new Point(150, 4);
            pnlYonetim.Name = "pnlYonetim";
            pnlYonetim.Size = new Size(1350, 500);
            pnlYonetim.TabIndex = 9;
            // 
            // btnCikis
            // 
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.Location = new Point(10, 419);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(134, 63);
            btnCikis.TabIndex = 3;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // btnGider
            // 
            btnGider.FlatStyle = FlatStyle.Flat;
            btnGider.Location = new Point(10, 121);
            btnGider.Name = "btnGider";
            btnGider.Size = new Size(134, 63);
            btnGider.TabIndex = 4;
            btnGider.Text = "Gider";
            btnGider.UseVisualStyleBackColor = true;
            btnGider.Click += btnGider_Click;
            // 
            // btnRaporlama
            // 
            btnRaporlama.FlatStyle = FlatStyle.Flat;
            btnRaporlama.Location = new Point(10, 328);
            btnRaporlama.Name = "btnRaporlama";
            btnRaporlama.Size = new Size(134, 63);
            btnRaporlama.TabIndex = 5;
            btnRaporlama.Text = "Raporlama";
            btnRaporlama.UseVisualStyleBackColor = true;
            btnRaporlama.Click += btnRaporlama_Click;
            // 
            // btnKasaDurum
            // 
            btnKasaDurum.FlatStyle = FlatStyle.Flat;
            btnKasaDurum.Location = new Point(10, 259);
            btnKasaDurum.Name = "btnKasaDurum";
            btnKasaDurum.Size = new Size(134, 63);
            btnKasaDurum.TabIndex = 6;
            btnKasaDurum.Text = "Kasa Durumu";
            btnKasaDurum.UseVisualStyleBackColor = true;
            btnKasaDurum.Click += btnKasaDurum_Click;
            // 
            // btnCalisanlar
            // 
            btnCalisanlar.FlatStyle = FlatStyle.Flat;
            btnCalisanlar.Location = new Point(10, 190);
            btnCalisanlar.Name = "btnCalisanlar";
            btnCalisanlar.Size = new Size(134, 63);
            btnCalisanlar.TabIndex = 7;
            btnCalisanlar.Text = "Çalışanlar";
            btnCalisanlar.UseVisualStyleBackColor = true;
            btnCalisanlar.Click += btnCalisanlar_Click;
            // 
            // btnGelir
            // 
            btnGelir.FlatStyle = FlatStyle.Flat;
            btnGelir.Location = new Point(10, 52);
            btnGelir.Name = "btnGelir";
            btnGelir.Size = new Size(134, 63);
            btnGelir.TabIndex = 8;
            btnGelir.Text = "Gelir";
            btnGelir.UseVisualStyleBackColor = true;
            btnGelir.Click += btnGelir_Click;
            // 
            // FRMMuhasebeGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._20250627_2211_Soyut_Renkler_remix_01jyscpdczesgsfaqrdnwr42j4;
            ClientSize = new Size(1512, 516);
            Controls.Add(pnlYonetim);
            Controls.Add(btnCikis);
            Controls.Add(btnGider);
            Controls.Add(btnRaporlama);
            Controls.Add(btnKasaDurum);
            Controls.Add(btnCalisanlar);
            Controls.Add(btnGelir);
            Name = "FRMMuhasebeGiris";
            Text = "FRMMuhasebeGiris";
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlYonetim;
        private Button btnCikis;
        private Button btnGider;
        private Button btnRaporlama;
        private Button btnKasaDurum;
        private Button btnCalisanlar;
        private Button btnGelir;
    }
}