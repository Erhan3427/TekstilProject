using Microsoft.Extensions.DependencyInjection;
using Tekstile.Context;
using Tekstile.UI;

namespace Tekstile
{
    public partial class FRMGiris : Form
    {

        IServiceProvider _serviceProvider;

        public FRMGiris(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;

        }
        
        public void FormGetir(Form form)
        {
            pnlYonetim.Controls.Clear();

            form.TopLevel = false; // ÖNEMLÝ: Form'un top-level olmadýðýný belirtiyoruz
            form.FormBorderStyle = FormBorderStyle.None;

            pnlYonetim.Controls.Add(form);
            pnlYonetim.Tag = form; // Form referansýný sakla

            form.Show();
        }

        private void btnMüsteriYonetim_Click(object sender, EventArgs e)
        {

            var musteriForm = _serviceProvider.GetRequiredService<FRMMusteri>();
            FormGetir(musteriForm);
        }

        private void btnBoyaYonetim_Click(object sender, EventArgs e)
        {
            var boyaForm = _serviceProvider.GetRequiredService<FRMBoya>();
            FormGetir(boyaForm);

        }

        private void btnDesenYonetimi_Click(object sender, EventArgs e)
        {
            var desenYonetimiForm = _serviceProvider.GetRequiredService<FRMDesenYonetimi>();
            FormGetir(desenYonetimiForm);
        }

        private void btnMakineYonetim_Click(object sender, EventArgs e)
        {
            var fRMMakineYonetim = _serviceProvider.GetRequiredService<FRMMakineYonetimi>();
            FormGetir(fRMMakineYonetim);

        }

        private void btnSiparisYonetim_Click(object sender, EventArgs e)
        {
            var fRMSiparisYonetimi = _serviceProvider.GetRequiredService<FRMSiparisYonetimi>();
            FormGetir(fRMSiparisYonetimi);
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            FRMLogKayitlari fRMLogKayitlari = new FRMLogKayitlari();
           FormGetir(fRMLogKayitlari);
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çýkmak istediðinize emin misiniz?", "Uyarý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var anaGiris = _serviceProvider.GetRequiredService<AnaGiris>();
                anaGiris.Show(); //Ana giriþ formunu gösterir.
                this.Hide(); //Mevcut formu gizler.



            }
        }
    }
}
