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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaGiris));
            btnSiparisYonetim = new Button();
            btnMuhasebe = new Button();
            pbAnaGiris = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbAnaGiris).BeginInit();
            SuspendLayout();
            // 
            // btnSiparisYonetim
            // 
            btnSiparisYonetim.BackColor = Color.MidnightBlue;
            btnSiparisYonetim.FlatStyle = FlatStyle.Flat;
            btnSiparisYonetim.ForeColor = SystemColors.ButtonHighlight;
            btnSiparisYonetim.Location = new Point(2, 324);
            btnSiparisYonetim.Name = "btnSiparisYonetim";
            btnSiparisYonetim.Size = new Size(395, 130);
            btnSiparisYonetim.TabIndex = 0;
            btnSiparisYonetim.Text = "Sipariş Yönetim";
            btnSiparisYonetim.UseVisualStyleBackColor = false;
            btnSiparisYonetim.Click += btnSiparisYonetim_Click;
            // 
            // btnMuhasebe
            // 
            btnMuhasebe.BackColor = Color.Crimson;
            btnMuhasebe.FlatStyle = FlatStyle.Flat;
            btnMuhasebe.ForeColor = SystemColors.ControlLightLight;
            btnMuhasebe.Location = new Point(402, 324);
            btnMuhasebe.Name = "btnMuhasebe";
            btnMuhasebe.Size = new Size(395, 130);
            btnMuhasebe.TabIndex = 0;
            btnMuhasebe.Text = "Muhasebe";
            btnMuhasebe.UseVisualStyleBackColor = false;
            btnMuhasebe.Click += btnMuhasebe_Click;
            // 
            // pbAnaGiris
            // 
            pbAnaGiris.BackColor = Color.Transparent;
            pbAnaGiris.Image = (Image)resources.GetObject("pbAnaGiris.Image");
            pbAnaGiris.Location = new Point(1, -11);
            pbAnaGiris.Name = "pbAnaGiris";
            pbAnaGiris.Size = new Size(805, 345);
            pbAnaGiris.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAnaGiris.TabIndex = 1;
            pbAnaGiris.TabStop = false;
            // 
            // AnaGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMuhasebe);
            Controls.Add(btnSiparisYonetim);
            Controls.Add(pbAnaGiris);
            Name = "AnaGiris";
            Text = "AnaGiris";
            ((System.ComponentModel.ISupportInitialize)pbAnaGiris).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSiparisYonetim;
        private Button btnMuhasebe;
        private PictureBox pbAnaGiris;
    }
}