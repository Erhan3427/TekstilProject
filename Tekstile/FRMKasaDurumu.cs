using System;
using System.Windows.Forms;
using Tekstile.BLL.Services.Interfaces;
using System.Linq;

namespace Tekstile
{
    public partial class FRMKasaDurumu : Form
    {
        private readonly IRaporService _raporService;
        public FRMKasaDurumu(IRaporService raporService)
        {
            _raporService = raporService;
            InitializeComponent();
            cmbRaporTuru.SelectedIndex = 0; // Varsayılan: Günlük
            RaporlariYukle();
        }

        private void RaporlariYukle()
        {
            txtToplamGelir.Text = _raporService.ToplamGelir().ToString("C2");
            txtToplamGider.Text = _raporService.ToplamGider().ToString("C2");
            txtBakiye.Text = _raporService.Bakiye().ToString("C2");
            RaporTablosunuGuncelle();
        }

        private void btnRaporla_Click(object sender, EventArgs e)
        {
            RaporTablosunuGuncelle();
        }

        private void RaporTablosunuGuncelle()
        {
            string raporTuru = cmbRaporTuru.SelectedItem?.ToString();
            DateTime seciliTarih = dtpRaporTarih.Value.Date;
            DateTime baslangic, bitis;
            if (raporTuru == "Günlük")
            {
                baslangic = seciliTarih;
                bitis = seciliTarih.AddDays(1).AddSeconds(-1);
            }
            else if (raporTuru == "Aylık")
            {
                baslangic = new DateTime(seciliTarih.Year, seciliTarih.Month, 1);
                bitis = baslangic.AddMonths(1).AddSeconds(-1);
            }
            else // Yıllık
            {
                baslangic = new DateTime(seciliTarih.Year, 1, 1);
                bitis = baslangic.AddYears(1).AddSeconds(-1);
            }
            var rapor = _raporService.RaporGetir(null, baslangic, bitis)
                .Select(x => new { x.Tarih, x.GiderTuru, x.Aciklama, x.Tutar })
                .OrderByDescending(x => x.Tarih)
                .ToList();
            dgvKasaRaporu.DataSource = rapor;
            txtToplamGelir.Text = _raporService.ToplamGelir(baslangic, bitis).ToString("C2");
            txtToplamGider.Text = _raporService.ToplamGider(baslangic, bitis).ToString("C2");
            txtBakiye.Text = _raporService.Bakiye(baslangic, bitis).ToString("C2");
            dgvKasaRaporu.Columns["Tutar"].DefaultCellStyle.Format = "C2";
            dgvKasaRaporu.Columns["Tutar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void FRMKasaDurumu_Load(object sender, EventArgs e)
        {
            dgvKasaRaporu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvKasaRaporu.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvKasaRaporu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
} 