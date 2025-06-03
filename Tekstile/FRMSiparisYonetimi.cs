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
    public partial class FRMSiparisYonetimi : Form
    {
        private MyDbContext _db = new MyDbContext();

        public FRMSiparisYonetimi()
        {
            InitializeComponent();
        }

        private void FRMSiparisYonetimi_Load(object sender, EventArgs e)
        {
            // DataGridView ayarları
            dgvSiparisler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSiparisler.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvSiparisler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // ComboBox veri kaynakları
            cmbMusteri.DataSource = _db.Musteriler.ToList();
            cmbMusteri.DisplayMember = "FirmaAdi";
            cmbMusteri.ValueMember = "Id";

            cmbDesen.DataSource = _db.Desenler.ToList();
            cmbDesen.DisplayMember = "DesenAdi";
            cmbDesen.ValueMember = "Id";

            cmbKumas.DataSource = _db.Kumascinsleri.ToList();
            cmbKumas.DisplayMember = "KumasAdi";
            cmbKumas.ValueMember = "Id";

            cmbMakine.DataSource = _db.Makineler.ToList();
            cmbMakine.DisplayMember = "MakineAdi";
            cmbMakine.ValueMember = "Id";

            // Tarih varsayılan değeri
            dtpTarih.Value = DateTime.Now;

            // Siparişleri listele
            SiparisleriListele();
        }

        private void SiparisleriListele()
        {
            dgvSiparisler.DataSource = _db.Siparisler
                .Select(s => new
                {
                    s.Id,
                    s.Musteri.FirmaAdi,
                    s.Desen.DesenAdi,
                    s.Kumas.KumasAdi,
                    s.Makine.MakineAdi,
                    s.Adet,
                    s.BaskiFiyat,
                    s.ToplamFiyat,
                    s.SiparisTarihi,
                    s.Durum
                }).ToList();
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

            _db.Siparisler.Add(siparis);
            _db.SaveChanges();

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