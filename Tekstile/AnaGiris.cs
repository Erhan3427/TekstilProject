using Microsoft.Extensions.DependencyInjection;
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
        private readonly IServiceProvider _serviceProvider;

        public AnaGiris(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }


        private void btnSiparisYonetim_Click(object sender, EventArgs e)
        {
            var frmGiris = _serviceProvider.GetRequiredService<FRMGiris>();
            frmGiris.ShowDialog();
        }

        private void btnMuhasebe_Click(object sender, EventArgs e)
        {
            var fRMMuhasebeGiris = _serviceProvider.GetRequiredService<FRMMuhasebeGiris>();
            fRMMuhasebeGiris.Show();
            this.Hide();
        }
    }
}
