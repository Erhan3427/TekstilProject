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
    public partial class FRMMuhasebeGiris : Form
    {
        private readonly IServiceProvider _serviceProvider;
        public FRMMuhasebeGiris(IServiceProvider service)
        {
            InitializeComponent();
            _serviceProvider = service;
        }
        public void FormGetir(Form form)
        {
            pnlYonetim.Controls.Clear();

            form.TopLevel = false; // ÖNEMLİ: Form'un top-level olmadığını belirtiyoruz
            form.FormBorderStyle = FormBorderStyle.None;

            pnlYonetim.Controls.Add(form);
            pnlYonetim.Tag = form; // Form referansını sakla

            form.Show();
        }


        private void btnCikis_Click(object sender, EventArgs e)
        {
            var anaGiris = _serviceProvider.GetRequiredService<AnaGiris>();
            anaGiris.Show();
            this.Hide(); // Mevcut formu gizle
        }



        private void btnRaporlama_Click(object sender, EventArgs e)
        {
            var fRMRaporlama = _serviceProvider.GetRequiredService<FRMRaporlama>();
            FormGetir(fRMRaporlama);

        }

        private void btnCalisanlar_Click(object sender, EventArgs e)
        {
            var frmCalisan = _serviceProvider.GetRequiredService<FRMCalisan>();
            FormGetir(frmCalisan);

        }

        private void btnKasaDurum_Click(object sender, EventArgs e)
        {
            var frmKasa = _serviceProvider.GetRequiredService<FRMKasaDurumu>();
            FormGetir(frmKasa);
        }

        private void btnGelir_Click(object sender, EventArgs e)
        {
            var frmKasa = _serviceProvider.GetRequiredService<FRMGelir>();
            FormGetir(frmKasa);
        }

        private void btnGider_Click(object sender, EventArgs e)
        {
            var frmKasa = _serviceProvider.GetRequiredService<FRMGider>();
            FormGetir(frmKasa);
        }
    }
}
