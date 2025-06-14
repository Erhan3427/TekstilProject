using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tekstile.Context;
using Tekstile.Entities.Data;

namespace Tekstile
{
    public partial class FRMRaporlama : Form
    {
        private MyDbContext _db = new MyDbContext();

        public FRMRaporlama()
        {
            InitializeComponent();
        }

        private void FRMRaporlama_Load(object sender, EventArgs e)
        {
            // DataGridView ayarları
            dgvRapor.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvRapor.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvRapor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Tarih aralığını varsayılan olarak son 30 gün olarak ayarla
            dtpBaslangic.Value = DateTime.Now.AddDays(-30);
            dtpBitis.Value = DateTime.Now;

            // Müşteri listesini yükle
            cmbMusteri.DataSource = _db.Musteriler.ToList();
            cmbMusteri.DisplayMember = "FirmaAdi";
            cmbMusteri.ValueMember = "Id";
        }

        private void btnTarihRaporu_Click(object sender, EventArgs e)
        {
            var baslangicTarihi = dtpBaslangic.Value.Date;
            var bitisTarihi = dtpBitis.Value.Date.AddDays(1).AddSeconds(-1);

            var siparisler = _db.Siparisler
                .Where(s => s.SiparisTarihi >= baslangicTarihi && s.SiparisTarihi <= bitisTarihi)
                .Select(s => new
                {
                    s.Id,
                    s.Musteri.FirmaAdi,
                    s.SiparisTarihi,
                    s.ToplamFiyat,
                    s.Durum
                })
                .ToList();

            dgvRapor.DataSource = siparisler;
            dgvRapor.Columns["Id"].Visible = false;

            // Toplam sipariş sayısı ve tutarı hesapla
            var toplamSiparis = siparisler.Count;
            var toplamTutar = siparisler.Sum(s => s.ToplamFiyat);

            lblToplamSiparis.Text = $"Toplam Sipariş: {toplamSiparis}";
            lblToplamTutar.Text = $"Toplam Tutar: {toplamTutar:C2}";
        }

        private void btnMusteriRaporu_Click(object sender, EventArgs e)
        {
            if(cmbMusteri.SelectedValue == null)
            {
                MessageBox.Show("Lütfen bir müşteri seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var musteriId = (int)cmbMusteri.SelectedValue;

            var siparisler = _db.Siparisler.Where(s => musteriId == s.MusteriId).Select(s => new
            {
                s.Id,
                s.Desen.DesenAdi,
                s.SiparisTarihi,
                s.ToplamFiyat,
                s.Durum
            }).ToList();
            dgvRapor.DataSource=siparisler;
            dgvRapor.Columns["Id"].Visible=false;

            var toplamSiparis = siparisler.Count();
            var toplamTutar = siparisler.Sum(s=>s.ToplamFiyat);

            lblToplamSiparis.Text= $"Toplam Sipariş: {toplamSiparis}";
            lblToplamTutar.Text = $"Toplam Tutar: {toplamTutar:C2}";

        }

        private void btnCiroRaporu_Click(object sender, EventArgs e)
        {
            var baslangicTarihi = dtpBaslangic.Value.Date;
            var bitisTarihi = dtpBitis.Value.Date.AddDays(1).AddSeconds(-1);

            var siparisler = _db.Siparisler
                .Where(s => s.SiparisTarihi >= baslangicTarihi && s.SiparisTarihi <= bitisTarihi)
                .GroupBy(s => s.SiparisTarihi.Value.Date)
                .Select(g => new
                {
                    Tarih = g.Key,
                    SiparisSayisi = g.Count(),
                    ToplamTutar = g.Sum(s => s.ToplamFiyat)
                })
                .OrderBy(x => x.Tarih)
                .ToList();

            dgvRapor.DataSource = siparisler;

            var toplamSiparis = siparisler.Sum(s => s.SiparisSayisi);
            var toplamTutar = siparisler.Sum(s => s.ToplamTutar);

            lblToplamSiparis.Text = $"Toplam Sipariş: {toplamSiparis}";
            lblToplamTutar.Text = $"Toplam Ciro: {toplamTutar:C2}";
        }

        private void btnKumasRaporu_Click(object sender, EventArgs e)
        {
            if(cmbKumas.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir Kumaş seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var seciliKumas = (int)cmbKumas.SelectedValue;


            var baslangicTarihi = dtpBaslangic.Value.Date;
            var bitisTarihi = dtpBitis.Value.Date.AddDays(1).AddSeconds(-1);

            var kumasRaporu = _db.Siparisler
                .Where(s =>s.KumasId==seciliKumas && s.SiparisTarihi >= baslangicTarihi && s.SiparisTarihi <= bitisTarihi)
                .GroupBy(sd => sd.Kumas.KumasAdi)
                .Select(g => new
                {
                    KumasAdi = g.Key,
                    SiparisSayisi = g.Count(),
                    BaskıAdedi = g.Sum(s => s.Adet),
                    ToplamFiyat = g.Sum(s => s.ToplamFiyat)

                })
                .ToList();

            dgvRapor.DataSource = kumasRaporu;

            var toplamSiparis = kumasRaporu.Sum(k => k.SiparisSayisi);
            var toplamTutar = kumasRaporu.Sum(k => k.ToplamFiyat);

            lblToplamSiparis.Text = $"Toplam Metre: {toplamSiparis:N2}";
            lblToplamTutar.Text = $"Toplam Tutar: {toplamTutar:C2}";
        }

        private void btnMakineRaporu_Click(object sender, EventArgs e)
        {
            var baslangicTarihi = dtpBaslangic.Value.Date;
            var bitisTarihi = dtpBitis.Value.Date.AddDays(1).AddSeconds(-1);

            var makineRaporu = _db.Siparisler
                .Where(s => s.SiparisTarihi >= baslangicTarihi && s.SiparisTarihi <= bitisTarihi)
                .GroupBy(sd => sd.Makine.MakineAdi)
                .Select(g => new
                {
                    MakineAdi = g.Key,
                    SiparisSayisi = g.Count(),
                    BaskıAdedi = g.Sum(s => s.Adet),
                    ToplamFiyat = g.Sum(s=>s.ToplamFiyat)
                })
                .OrderByDescending(x => x.SiparisSayisi)
                .ToList();

            dgvRapor.DataSource = makineRaporu;

            var toplamSiparis = makineRaporu.Sum(m => m.SiparisSayisi);
            var toplamTutar = makineRaporu.Sum(m => m.ToplamFiyat);

            lblToplamSiparis.Text = $"Toplam Sipariş: {toplamSiparis}";
            lblToplamTutar.Text = $"Toplam Tutar: {toplamTutar:C2}";
        }
    }
} 