namespace Tekstile
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnMüsteriYonetim = new Button();
            btnDesenYonetimi = new Button();
            btnSiparisYonetim = new Button();
            btnBoyaYonetim = new Button();
            btnCikis = new Button();
            btnMakineYonetim = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnMüsteriYonetim
            // 
            btnMüsteriYonetim.Location = new Point(161, 163);
            btnMüsteriYonetim.Name = "btnMüsteriYonetim";
            btnMüsteriYonetim.Size = new Size(134, 63);
            btnMüsteriYonetim.TabIndex = 0;
            btnMüsteriYonetim.Text = "Müşteri Yönetimi";
            btnMüsteriYonetim.UseVisualStyleBackColor = true;
            btnMüsteriYonetim.Click += btnMüsteriYonetim_Click;
            // 
            // btnDesenYonetimi
            // 
            btnDesenYonetimi.Location = new Point(161, 232);
            btnDesenYonetimi.Name = "btnDesenYonetimi";
            btnDesenYonetimi.Size = new Size(134, 63);
            btnDesenYonetimi.TabIndex = 0;
            btnDesenYonetimi.Text = "Desen Yönetimi";
            btnDesenYonetimi.UseVisualStyleBackColor = true;
            // 
            // btnSiparisYonetim
            // 
            btnSiparisYonetim.Location = new Point(161, 301);
            btnSiparisYonetim.Name = "btnSiparisYonetim";
            btnSiparisYonetim.Size = new Size(134, 63);
            btnSiparisYonetim.TabIndex = 0;
            btnSiparisYonetim.Text = "Sipariş Yönetimi";
            btnSiparisYonetim.UseVisualStyleBackColor = true;
            // 
            // btnBoyaYonetim
            // 
            btnBoyaYonetim.Location = new Point(390, 163);
            btnBoyaYonetim.Name = "btnBoyaYonetim";
            btnBoyaYonetim.Size = new Size(134, 63);
            btnBoyaYonetim.TabIndex = 0;
            btnBoyaYonetim.Text = "Boya yönetimi";
            btnBoyaYonetim.UseVisualStyleBackColor = true;
            btnBoyaYonetim.Click += btnBoyaYonetim_Click;
            // 
            // btnCikis
            // 
            btnCikis.Location = new Point(390, 301);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(134, 63);
            btnCikis.TabIndex = 0;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = true;
            // 
            // btnMakineYonetim
            // 
            btnMakineYonetim.Location = new Point(390, 232);
            btnMakineYonetim.Name = "btnMakineYonetim";
            btnMakineYonetim.Size = new Size(134, 63);
            btnMakineYonetim.TabIndex = 0;
            btnMakineYonetim.Text = "Makine Yönetimi";
            btnMakineYonetim.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F);
            label1.Location = new Point(216, 59);
            label1.Name = "label1";
            label1.Size = new Size(266, 40);
            label1.TabIndex = 1;
            label1.Text = "Tekstil Takip Sistemi";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 459);
            Controls.Add(label1);
            Controls.Add(btnCikis);
            Controls.Add(btnSiparisYonetim);
            Controls.Add(btnBoyaYonetim);
            Controls.Add(btnMakineYonetim);
            Controls.Add(btnDesenYonetimi);
            Controls.Add(btnMüsteriYonetim);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMüsteriYonetim;
        private Button btnDesenYonetimi;
        private Button btnSiparisYonetim;
        private Button btnBoyaYonetim;
        private Button btnCikis;
        private Button btnMakineYonetim;
        private Label label1;
    }
}
