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
            btnSiparisYonetim = new Button();
            btnRaporlama = new Button();
            btnMakineYonetim = new Button();
            btnCalisanlar = new Button();
            btnGelirGider = new Button();
            SuspendLayout();
            // 
            // pnlYonetim
            // 
            pnlYonetim.Location = new Point(150, 4);
            pnlYonetim.Name = "pnlYonetim";
            pnlYonetim.Size = new Size(1350, 500);
            pnlYonetim.TabIndex = 9;
            // 
            // btnCikis
            // 
            btnCikis.Location = new Point(10, 419);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(134, 63);
            btnCikis.TabIndex = 3;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // btnSiparisYonetim
            // 
            btnSiparisYonetim.Location = new Point(10, 328);
            btnSiparisYonetim.Name = "btnSiparisYonetim";
            btnSiparisYonetim.Size = new Size(134, 63);
            btnSiparisYonetim.TabIndex = 4;
            btnSiparisYonetim.Text = "Sipariş Yönetimi";
            btnSiparisYonetim.UseVisualStyleBackColor = true;
            // 
            // btnRaporlama
            // 
            btnRaporlama.Location = new Point(10, 121);
            btnRaporlama.Name = "btnRaporlama";
            btnRaporlama.Size = new Size(134, 63);
            btnRaporlama.TabIndex = 5;
            btnRaporlama.Text = "Raporlama";
            btnRaporlama.UseVisualStyleBackColor = true;
            btnRaporlama.Click += btnRaporlama_Click;
            // 
            // btnMakineYonetim
            // 
            btnMakineYonetim.Location = new Point(10, 259);
            btnMakineYonetim.Name = "btnMakineYonetim";
            btnMakineYonetim.Size = new Size(134, 63);
            btnMakineYonetim.TabIndex = 6;
            btnMakineYonetim.Text = "Makine Yönetimi";
            btnMakineYonetim.UseVisualStyleBackColor = true;
            // 
            // btnCalisanlar
            // 
            btnCalisanlar.Location = new Point(10, 190);
            btnCalisanlar.Name = "btnCalisanlar";
            btnCalisanlar.Size = new Size(134, 63);
            btnCalisanlar.TabIndex = 7;
            btnCalisanlar.Text = "Çalışanlar";
            btnCalisanlar.UseVisualStyleBackColor = true;
            // 
            // btnGelirGider
            // 
            btnGelirGider.Location = new Point(10, 52);
            btnGelirGider.Name = "btnGelirGider";
            btnGelirGider.Size = new Size(134, 63);
            btnGelirGider.TabIndex = 8;
            btnGelirGider.Text = "GelirGider";
            btnGelirGider.UseVisualStyleBackColor = true;
            btnGelirGider.Click += btnGelirGider_Click;
            // 
            // FRMMuhasebeGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1512, 516);
            Controls.Add(pnlYonetim);
            Controls.Add(btnCikis);
            Controls.Add(btnSiparisYonetim);
            Controls.Add(btnRaporlama);
            Controls.Add(btnMakineYonetim);
            Controls.Add(btnCalisanlar);
            Controls.Add(btnGelirGider);
            Name = "FRMMuhasebeGiris";
            Text = "FRMMuhasebeGiris";
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlYonetim;
        private Button btnCikis;
        private Button btnSiparisYonetim;
        private Button btnRaporlama;
        private Button btnMakineYonetim;
        private Button btnCalisanlar;
        private Button btnGelirGider;
    }
}