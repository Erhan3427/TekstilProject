namespace Tekstile.Data
{
    partial class BoyaStoğu
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
            ((System.ComponentModel.ISupportInitialize)dgvBoyaStok).BeginInit();
            SuspendLayout();
            // 
            // dgvBoyaStok
            // 
            dgvBoyaStok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBoyaStok.Location = new Point(12, 12);
            dgvBoyaStok.Name = "dgvBoyaStok";
            dgvBoyaStok.RowHeadersWidth = 51;
            dgvBoyaStok.Size = new Size(776, 426);
            dgvBoyaStok.TabIndex = 0;
            // 
            // BoyaStoğu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvBoyaStok);
            Name = "BoyaStoğu";
            Text = "BoyaStoğu";
            Load += BoyaStoğu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBoyaStok).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBoyaStok;
    }
}