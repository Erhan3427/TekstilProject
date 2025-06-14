namespace Tekstile.UI
{
    partial class AnaGiris
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
            btnSiparisYonetim = new Button();
            btnMuhasebe = new Button();
            SuspendLayout();
            // 
            // btnSiparisYonetim
            // 
            btnSiparisYonetim.Location = new Point(71, 97);
            btnSiparisYonetim.Name = "btnSiparisYonetim";
            btnSiparisYonetim.Size = new Size(308, 250);
            btnSiparisYonetim.TabIndex = 0;
            btnSiparisYonetim.Text = "Sipariş Yönetim";
            btnSiparisYonetim.UseVisualStyleBackColor = true;
            btnSiparisYonetim.Click += btnSiparisYonetim_Click;
            // 
            // btnMuhasebe
            // 
            btnMuhasebe.Location = new Point(385, 97);
            btnMuhasebe.Name = "btnMuhasebe";
            btnMuhasebe.Size = new Size(308, 250);
            btnMuhasebe.TabIndex = 0;
            btnMuhasebe.Text = "Muhasebe";
            btnMuhasebe.UseVisualStyleBackColor = true;
            btnMuhasebe.Click += btnMuhasebe_Click;
            // 
            // AnaGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMuhasebe);
            Controls.Add(btnSiparisYonetim);
            Name = "AnaGiris";
            Text = "AnaGiris";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSiparisYonetim;
        private Button btnMuhasebe;
    }
}