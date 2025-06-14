using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tekstile.UI
{
    public partial class AnaGiris : Form
    {
        public AnaGiris()
        {
            InitializeComponent();
        }

        private void btnSiparisYonetim_Click(object sender, EventArgs e)
        {
            FRMGiris frmGiris = new FRMGiris();
            frmGiris.Show();
        }

        private void btnMuhasebe_Click(object sender, EventArgs e)
        {
            FRMMuhasebeGiris fRMMuhasebeGiris = new();
            fRMMuhasebeGiris.Show();
            this.Hide();
        }
    }
}
