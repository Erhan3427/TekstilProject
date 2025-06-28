using System;
using System.Windows.Forms;

namespace Tekstile
{
    public partial class FRMGelir : Form
    {
        public FRMGelir()
        {
            InitializeComponent();
        }

        private void FRMGelir_Load(object sender, EventArgs e)
        {
            dgvGelirler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvGelirler.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvGelirler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
} 