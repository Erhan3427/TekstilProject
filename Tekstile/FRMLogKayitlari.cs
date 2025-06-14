using System;
using System.Linq;
using System.Windows.Forms;
using Tekstile.Context;
using Tekstile.Entities.Data;

namespace Tekstile
{
    public partial class FRMLogKayitlari : Form
    {
        private readonly MyDbContext _db = new MyDbContext();

        public FRMLogKayitlari()
        {
            InitializeComponent();
        }

        private void FRMLogKayitlari_Load(object sender, EventArgs e)
        {
            // DataGridView ayarları
            dgvLoglar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvLoglar.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvLoglar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // İşlem Türü Combobox'ı
            var islemTurleri = _db.LogKayitlari.Select(l => l.IslemTuru).Distinct().ToList();
            islemTurleri.Insert(0, "Tümü");
            cmbIslemTuru.DataSource = islemTurleri;

            var kullanicilar = _db.LogKayitlari.Select(l => l.KullaniciAdi).Distinct().ToList();
            kullanicilar.Insert(0, "Tümü");
            cmbKullanici.DataSource = kullanicilar;






            LoglariListele();
        }

        private void LoglariListele()
        {
            var baslangicTarihi = dtpBaslangic.Value.Date;
            var bitisTarihi = dtpBitis.Value.Date.AddDays(1).AddSeconds(-1);
            var kullaniciAdi = cmbKullanici.SelectedItem as string;
            var islemTuru = cmbIslemTuru.SelectedItem as string;

            var loglar = _db.LogKayitlari
                .Where(l => l.IslemTarihi >= baslangicTarihi && l.IslemTarihi <= bitisTarihi)
                .Where(l => kullaniciAdi == "Tümü" || l.KullaniciAdi == kullaniciAdi)
                .Where(l => islemTuru == "Tümü" || l.IslemTuru == islemTuru)
                .Select(l => new
                {
                    l.Id,
                    l.KullaniciAdi,
                    l.IslemTuru,
                    l.IslemTarihi,
                    l.IslemDetayi
                })
                .ToList();
            dgvLoglar.DataSource = loglar;


        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            LoglariListele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            dtpBaslangic.Value = DateTime.Now.AddDays(-30);
            dtpBitis.Value = DateTime.Now;
            cmbKullanici.SelectedIndex = 0;
            cmbIslemTuru.SelectedIndex = 0;
            LoglariListele();
        }

       
    }
} 