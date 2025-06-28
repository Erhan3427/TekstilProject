namespace Tekstile
{
    partial class FRMMusteri
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
            txtFirmaAdi = new TextBox();
            txtFirmaYetkili = new TextBox();
            txtIsAdresi = new TextBox();
            dgvMüsteriler = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            btnSil = new Button();
            btnGuncell = new Button();
            mtbTelefon = new MaskedTextBox();
            txtMusteriKod = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMüsteriler).BeginInit();
            SuspendLayout();
            // 
            // txtFirmaAdi
            // 
            txtFirmaAdi.Location = new Point(159, 30);
            txtFirmaAdi.Name = "txtFirmaAdi";
            txtFirmaAdi.Size = new Size(166, 27);
            txtFirmaAdi.TabIndex = 0;
            // 
            // txtFirmaYetkili
            // 
            txtFirmaYetkili.Location = new Point(159, 63);
            txtFirmaYetkili.Name = "txtFirmaYetkili";
            txtFirmaYetkili.Size = new Size(166, 27);
            txtFirmaYetkili.TabIndex = 0;
            // 
            // txtIsAdresi
            // 
            txtIsAdresi.Location = new Point(159, 129);
            txtIsAdresi.Multiline = true;
            txtIsAdresi.Name = "txtIsAdresi";
            txtIsAdresi.Size = new Size(202, 72);
            txtIsAdresi.TabIndex = 0;
            // 
            // dgvMüsteriler
            // 
            dgvMüsteriler.AllowUserToAddRows = false;
            dgvMüsteriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMüsteriler.Location = new Point(20, 259);
            dgvMüsteriler.Name = "dgvMüsteriler";
            dgvMüsteriler.ReadOnly = true;
            dgvMüsteriler.RowHeadersWidth = 51;
            dgvMüsteriler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMüsteriler.Size = new Size(1295, 188);
            dgvMüsteriler.TabIndex = 2;
            dgvMüsteriler.CellClick += dgvMüsteriler_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 37);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 3;
            label1.Text = "Firma Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 70);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 3;
            label2.Text = "Firma yetkilisi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 103);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 3;
            label3.Text = "Telefon ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 136);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 3;
            label4.Text = "İş Adresi";
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(515, 203);
            button1.Name = "button1";
            button1.Size = new Size(153, 50);
            button1.TabIndex = 1;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.IndianRed;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.ForeColor = SystemColors.Window;
            btnSil.Location = new Point(831, 203);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(143, 50);
            btnSil.TabIndex = 4;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncell
            // 
            btnGuncell.BackColor = Color.SteelBlue;
            btnGuncell.FlatStyle = FlatStyle.Flat;
            btnGuncell.ForeColor = SystemColors.Window;
            btnGuncell.Location = new Point(674, 203);
            btnGuncell.Name = "btnGuncell";
            btnGuncell.Size = new Size(151, 50);
            btnGuncell.TabIndex = 4;
            btnGuncell.Text = "Güncelle";
            btnGuncell.UseVisualStyleBackColor = false;
            btnGuncell.Click += btnGuncell_Click;
            // 
            // mtbTelefon
            // 
            mtbTelefon.Location = new Point(159, 100);
            mtbTelefon.Mask = "(999) 000-0000";
            mtbTelefon.Name = "mtbTelefon";
            mtbTelefon.Size = new Size(166, 27);
            mtbTelefon.TabIndex = 5;
            // 
            // txtMusteriKod
            // 
            txtMusteriKod.Location = new Point(572, 34);
            txtMusteriKod.Name = "txtMusteriKod";
            txtMusteriKod.Size = new Size(125, 27);
            txtMusteriKod.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(469, 41);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 3;
            label5.Text = "Müşteri Kodu";
            // 
            // FRMMusteri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = UI.Properties.Resources._20250627_2211_Soyut_Renkler_remix_01jyscpdczesgsfaqrdnwr42j4;
            ClientSize = new Size(1512, 516);
            Controls.Add(txtMusteriKod);
            Controls.Add(mtbTelefon);
            Controls.Add(btnGuncell);
            Controls.Add(btnSil);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(dgvMüsteriler);
            Controls.Add(button1);
            Controls.Add(txtIsAdresi);
            Controls.Add(txtFirmaYetkili);
            Controls.Add(txtFirmaAdi);
            Name = "FRMMusteri";
            Text = "FormMusteri";
            Load += FormMusteri_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMüsteriler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirmaAdi;
        private TextBox txtFirmaYetkili;
        private TextBox txtIsAdresi;
        private DataGridView dgvMüsteriler;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button btnSil;
        private Button btnGuncell;
        private MaskedTextBox mtbTelefon;
        private TextBox txtMusteriKod;
        private Label label5;
    }
}