namespace Tekstile.Data
{
    partial class FRMBoyaStogu
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
            dgvBoyaStok = new DataGridView();
            cmbİslemler = new ComboBox();
            btnFiltrele = new Button();
            dtpBaslangic = new DateTimePicker();
            dtpBitis = new DateTimePicker();
            txtFiltreleStok = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBoyaStok).BeginInit();
            SuspendLayout();
            // 
            // dgvBoyaStok
            // 
            dgvBoyaStok.AllowUserToAddRows = false;
            dgvBoyaStok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBoyaStok.Location = new Point(12, 87);
            dgvBoyaStok.Name = "dgvBoyaStok";
            dgvBoyaStok.ReadOnly = true;
            dgvBoyaStok.RowHeadersWidth = 51;
            dgvBoyaStok.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBoyaStok.Size = new Size(776, 351);
            dgvBoyaStok.TabIndex = 0;
            // 
            // cmbİslemler
            // 
            cmbİslemler.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbİslemler.FormattingEnabled = true;
            cmbİslemler.Location = new Point(285, 14);
            cmbİslemler.Name = "cmbİslemler";
            cmbİslemler.Size = new Size(151, 28);
            cmbİslemler.TabIndex = 1;
            // 
            // btnFiltrele
            // 
            btnFiltrele.Location = new Point(512, 45);
            btnFiltrele.Name = "btnFiltrele";
            btnFiltrele.Size = new Size(135, 36);
            btnFiltrele.TabIndex = 2;
            btnFiltrele.Text = "Filtrele";
            btnFiltrele.UseVisualStyleBackColor = true;
            btnFiltrele.Click += btnFiltrele_Click;
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.Location = new Point(12, 12);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.Size = new Size(250, 27);
            dtpBaslangic.TabIndex = 3;
            // 
            // dtpBitis
            // 
            dtpBitis.Location = new Point(12, 45);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(250, 27);
            dtpBitis.TabIndex = 3;
            // 
            // txtFiltreleStok
            // 
            txtFiltreleStok.Location = new Point(657, 12);
            txtFiltreleStok.Name = "txtFiltreleStok";
            txtFiltreleStok.Size = new Size(131, 27);
            txtFiltreleStok.TabIndex = 4;
            txtFiltreleStok.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(588, 14);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 5;
            label1.Text = "Filtrele:";
            // 
            // FRMBoyaStogu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtFiltreleStok);
            Controls.Add(dtpBitis);
            Controls.Add(dtpBaslangic);
            Controls.Add(btnFiltrele);
            Controls.Add(cmbİslemler);
            Controls.Add(dgvBoyaStok);
            Name = "FRMBoyaStogu";
            Text = "BoyaStoğu";
            Load += BoyaStoğu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBoyaStok).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBoyaStok;
        private ComboBox cmbİslemler;
        private Button btnFiltrele;
        private DateTimePicker dtpBaslangic;
        private DateTimePicker dtpBitis;
        private TextBox txtFiltreleStok;
        private Label label1;
    }
}