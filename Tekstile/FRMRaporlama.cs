using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tekstile.BLL.Services.CRUD;
using Tekstile.BLL.Services.Interfaces;
using Tekstile.Context;
using Tekstile.Entities.Data;

namespace Tekstile
{
    public partial class FRMRaporlama : Form
    {
        ISiparisYonetimiService _db;
        IKumasService _kumasService;
        IMusteriService _musteriService;

        public FRMRaporlama(ISiparisYonetimiService db, IKumasService kumasService, IMusteriService musteriService)
        {
            InitializeComponent();
            _db = db;
            _kumasService = kumasService;
            _musteriService = musteriService;
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

            // Müşteri listesini yükle0
            cmbMusteri.DataSource = _musteriService.HepsiniGetir()
                                .Select(m => new
                                {
                                    m.Id,
                                    Musteri = m.FirmaAdi + " - " + m.YetkiliAdSoyad
                                }).ToList();
            cmbMusteri.DisplayMember = "Musteri";
            cmbMusteri.ValueMember = "Id";

            cmbKumas.DataSource = _kumasService.HepsiniGetir()
                                .Select(k => new
                                {
                                    k.Id,
                                    Kumas = k.KumasAdi + " - " + k.IplikTipi
                                }).ToList();
            cmbKumas.DisplayMember = "Kumas";
            cmbKumas.ValueMember = "Id";
            

        }

        private void btnTarihRaporu_Click(object sender, EventArgs e)
        {
            var baslangicTarihi = dtpBaslangic.Value.Date;
            var bitisTarihi = dtpBitis.Value.Date.AddDays(1).AddSeconds(-1);

            var siparisler = _db.HepsiniListele()
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
            dgvRapor.Columns["ToplamFiyat"].DefaultCellStyle.Format = "C2";
        }

        private void btnMusteriRaporu_Click(object sender, EventArgs e)
        {
            if(cmbMusteri.SelectedValue == null)
            {
                MessageBox.Show("Lütfen bir müşteri seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var musteriId = (int)cmbMusteri.SelectedValue;

            var siparisler = _db.HepsiniListele().Where(s => musteriId == s.MusteriId).Select(s => new
            {
                s.Id,
                s.Musteri.FirmaAdi,
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
            dgvRapor.Columns["ToplamFiyat"].DefaultCellStyle.Format = "C2";

        }

        private void btnCiroRaporu_Click(object sender, EventArgs e)
        {
            var baslangicTarihi = dtpBaslangic.Value.Date;
            var bitisTarihi = dtpBitis.Value.Date.AddDays(1).AddSeconds(-1);

            var siparisler = _db.HepsiniListele()
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

            var kumasRaporu = _db.HepsiniListele()
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

            var toplamSiparis = kumasRaporu.Sum(k => k.BaskıAdedi);
            var toplamTutar = kumasRaporu.Sum(k => k.ToplamFiyat);

            lblToplamSiparis.Text = $"Toplam Adet: {toplamSiparis:N2}";
            lblToplamTutar.Text = $"Toplam Tutar: {toplamTutar:C2}";
            dgvRapor.Columns["ToplamFiyat"].DefaultCellStyle.Format = "C2";
        }

        private void btnMakineRaporu_Click(object sender, EventArgs e)
        {
            var baslangicTarihi = dtpBaslangic.Value.Date;
            var bitisTarihi = dtpBitis.Value.Date.AddDays(1).AddSeconds(-1);

            var makineRaporu = _db.HepsiniListele()
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
            dgvRapor.Columns["ToplamFiyat"].DefaultCellStyle.Format = "C2";
        }
    }
} 