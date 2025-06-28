using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tekstile.BLL.Services.Interfaces;
using Tekstile.Context;
using Tekstile.Entities.Data;
using Tekstile.Helpers;

namespace Tekstile
{
    public partial class FRMSiparisYonetimi : Form
    {
        ISiparisYonetimiService _db;
        IMusteriService _musteriService;
        IDesenService _desenService;
        IKumasService _kumasService;    
        IMakineService _makineService;

     
        public FRMSiparisYonetimi(ISiparisYonetimiService db, IMusteriService musteriService, IDesenService desenService, IKumasService kumasService, IMakineService makineService)
        {
            InitializeComponent();
            _db = db;
            _musteriService = musteriService;
            _desenService = desenService;
            _kumasService = kumasService;
            _makineService = makineService;
            SiparisleriListele();
        }

        private void FRMSiparisYonetimi_Load(object sender, EventArgs e)
        {
            // DataGridView ayarları
            dgvSiparisler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSiparisler.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvSiparisler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // ComboBox veri kaynakları
            cmbMusteri.DataSource = _musteriService.HepsiniGetir();
            cmbMusteri.DisplayMember = "FirmaAdi";
            cmbMusteri.ValueMember = "Id";

            cmbDesen.DataSource = _desenService.HepsiniGetir();
            cmbDesen.DisplayMember = "DesenAdi";
            cmbDesen.ValueMember = "Id";

            cmbKumas.DataSource = _kumasService.HepsiniGetir()
                                 .Select(k => new
                                 {
                                     k.Id,
                                     Kumas = k.KumasAdi + " - " + k.IplikTipi
                                 }).ToList();
            cmbKumas.DisplayMember = "Kumas";
            cmbKumas.ValueMember = "Id";

            cmbMakine.DataSource = _makineService.HepsiniGetir();
            cmbMakine.DisplayMember = "MakineAdi";
            cmbMakine.ValueMember = "Id";

            // Tarih varsayılan değeri
            dtpTarih.Value = DateTime.Now;

            // Siparişleri listele
            SiparisleriListele();
        }

        private void SiparisleriListele()
        {
            dgvSiparisler.DataSource = _db.HepsiniListele()
                .Select(s => new
                {
                    s.Id,
                    s.Musteri.FirmaAdi,
                    s.Desen.DesenAdi,
                    Kumas = s.Kumas.KumasAdi + " " + s.Kumas.IplikTipi,
                    s.Makine.MakineAdi,
                    s.Adet,
                    s.BaskiFiyat,
                    s.ToplamFiyat,
                    s.SiparisTarihi,
                    s.Durum
                }).ToList();
            dgvSiparisler.Columns["Id"].Visible = false;
            dgvSiparisler.Columns["ToplamFiyat"].DefaultCellStyle.Format = "C2";
            dgvSiparisler.Columns["BaskiFiyat"].DefaultCellStyle.Format = "C2";

        }

        private void btnSiparisKaydet_Click(object sender, EventArgs e)
        {
            if (SiparisKontrol() == false)
                return;

            var siparis = new Siparisler
            {
                MusteriId = (int)cmbMusteri.SelectedValue,
                DesenId = (int)cmbDesen.SelectedValue,
                KumasId = (int)cmbKumas.SelectedValue,
                MakineId = (int)cmbMakine.SelectedValue,
                Adet = (int)nudAdet.Value,
                BaskiFiyat = decimal.Parse(txtBaskiFiyat.Text),
                ToplamFiyat = (int)nudAdet.Value * decimal.Parse(txtBaskiFiyat.Text),
                SiparisTarihi = dtpTarih.Value,
                Durum = "Beklemede"
            };

           _db.Ekle(siparis);
            LogKayit.LogEkle("Admin", "Sipariş Ekleme", $"Sipariş Eklendi: {siparis.Musteri.FirmaAdi} - {siparis.Desen.DesenAdi}");

            MessageBox.Show("Sipariş başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SiparisleriListele();
            FormuTemizle();
        }

        private bool SiparisKontrol()
        {
            if (cmbMusteri.SelectedItem == null)
            {
                MessageBox.Show("Lütfen müşteri seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbDesen.SelectedItem == null)
            {
                MessageBox.Show("Lütfen desen seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbKumas.SelectedItem == null)
            {
                MessageBox.Show("Lütfen kumaş seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbMakine.SelectedItem == null)
            {
                MessageBox.Show("Lütfen makine seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (nudAdet.Value <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir adet giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtBaskiFiyat.Text) || !decimal.TryParse(txtBaskiFiyat.Text, out _))
            {
                MessageBox.Show("Lütfen geçerli bir baskı fiyatı giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void FormuTemizle()
        {
            cmbMusteri.SelectedIndex = -1;
            cmbDesen.SelectedIndex = -1;
            cmbKumas.SelectedIndex = -1;
            cmbMakine.SelectedIndex = -1;
            nudAdet.Value = 0;
            txtBaskiFiyat.Clear();
            dtpTarih.Value = DateTime.Now;
        }

        private void txtBaskiFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }
    }
} 