using Microsoft.IdentityModel.Logging;
using System.Data;
using Tekstile.BLL.Services;
using Tekstile.Context;
using Tekstile.Data;
using Tekstile.Entities.Data;
using Tekstile.Helpers;

namespace Tekstile
{
    public partial class FRMBoya : Form
    {
        private MyDbContext _db;
        private BoyaService _boyaService;
        private BoyaStoguService _stokService;
        private FRMBoyaStogu _boyaStogu;
        
        public FRMBoya()
        {
            InitializeComponent();
            _db = new MyDbContext();
            _boyaService = new BoyaService();
            _stokService = new BoyaStoguService();
        }

        private void FormBoya_Load(object sender, EventArgs e)
        {
            // DataGridView ayarları
            dgvBoyalar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvBoyalar.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvBoyalar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Renk listesi
            CmbRenkler.Items.AddRange(new[] { "Kırmızı", "Mavi", "Yeşil", "Sarı", "Turuncu", "Mor", "Pembe", "Lacivert", "Kahverengi", "Siyah", "Beyaz", "Gri", "Füme", "Bej", "Altın", "Gümüş", "Açık Mavi", "Koyu Yeşil", "Açık Pembe", "Bordo", "Haki", "Krem", "Hardal", "Mint", "Lila" });
            
            // Boya tipi listesi
            cmbBoyaTipi.Items.AddRange(new string[] { "Normal", "Şeffaf", "Tiner", "Yapışkan" });

            // Sadece eklenen boyaları listele
            ListeleEklenenBoyalar();
        }

        private void ListeleEklenenBoyalar()
        {
            var boyalar = _db.Boyalar
                .Where(b => b.KovaAdedi > 0)
                .Select(b => new
                {
                    b.Id,
                    b.BoyaKodu,
                    b.RenkAdi,
                    b.BoyaTipi,
                    b.KovaAdedi,
                    b.BoyaFiyat,
                    b.ToplamFiyat,
                    b.StokDurum
                })
                .ToList();

            dgvBoyalar.DataSource = boyalar;
            dgvBoyalar.Columns["Id"].Visible = false;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoyaKod.Text) || string.IsNullOrEmpty(txtBoyaAdi.Text))
            {
                MessageBox.Show("Lütfen boya kodu ve adını giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nudKovaAdet.Value <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir kova adedi giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if ( _db.Boyalar.Any(b=>b.BoyaKodu==txtBoyaKod.Text)) {
                MessageBox.Show("Bu boyakodu daha önce tanımlanmış");
                return;

            }

            var boya = new Boyalar
            {
                BoyaKodu = txtBoyaKod.Text,
                RenkAdi = txtBoyaAdi.Text,
                BoyaTipi = cmbBoyaTipi.SelectedItem?.ToString(),
                BoyaFiyat = nudFiyat.Value,
                KovaAdedi = (int)nudKovaAdet.Value,
                StokDurum = "Gelen", // Otomatik olarak Gelen olarak ayarla
                GelenAdet = (int)nudKovaAdet.Value,
                ToplamFiyat = nudFiyat.Value * nudKovaAdet.Value
            };

            // Boya kaydını ekle
            _boyaService.Ekle(boya);

            // Stok hareketi oluştur
            var stokHareket = new StokHareket
            {
                BoyaId = boya.Id,
                IslemTarihi = DateTime.Now,
                IslemTuru = "Gelen",
                Adet = (int)nudKovaAdet.Value,
                Aciklama = txtAciklama.Text
            };

            // Stok hareketini kaydet
            _stokService.Ekle(stokHareket);
            LogKayit.LogEkle("admin", "BoyaEkle", $"Boya eklendi: {boya.BoyaKodu}");
            MessageBox.Show("Boya başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListeleEklenenBoyalar();
            FormTemizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvBoyalar.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellenecek bir boya seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_db.Boyalar.Any(b => b.BoyaKodu == txtBoyaKod.Text))
            {
                MessageBox.Show("Bu boyakodu daha önce tanımlanmış");
                return;

            }

            int id = Convert.ToInt32(dgvBoyalar.CurrentRow.Cells["Id"].Value);
            var boya = _db.Boyalar.Find(id);

            if (boya == null)
            {
                MessageBox.Show("Güncellenecek boya bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Eski değerleri sakla
            var eskiKovaAdedi = boya.KovaAdedi;
            var yeniKovaAdedi = (int)nudKovaAdet.Value;

            // Boya bilgilerini güncelle
            boya.BoyaKodu = txtBoyaKod.Text;
            boya.RenkAdi = txtBoyaAdi.Text;
            boya.BoyaTipi = cmbBoyaTipi.SelectedItem?.ToString();
            boya.BoyaFiyat = nudFiyat.Value;
            boya.KovaAdedi = yeniKovaAdedi;
            boya.ToplamFiyat = nudFiyat.Value * yeniKovaAdedi;

            // Stok hareketi oluştur
            if (eskiKovaAdedi != yeniKovaAdedi)
            {
                var stokHareket = new StokHareket
                {
                    BoyaId = boya.Id,
                    IslemTarihi = DateTime.Now,
                    IslemTuru = yeniKovaAdedi > eskiKovaAdedi ? "Gelen" : "Açılan",
                    Adet = Math.Abs((int)(yeniKovaAdedi - eskiKovaAdedi)),
                    Aciklama = txtAciklama.Text
                };

                _stokService.Ekle(stokHareket);
            }

        
            _db.SaveChanges();
            LogKayit.LogEkle("admin", "BoyaGuncelle", $"Boya güncellendi: {boya.BoyaKodu}");
            MessageBox.Show("Boya başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListeleEklenenBoyalar();
            FormTemizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvBoyalar.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silinecek bir boya seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Seçili boyayı silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvBoyalar.CurrentRow.Cells["Id"].Value);
                _boyaService.Sil(id);
                LogKayit.LogEkle("admin", "BoyaSil", $"Boya silindi: {id}");
                MessageBox.Show("Boya başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListeleEklenenBoyalar();
                FormTemizle();
            }
        }

        private void FormTemizle()
        {
            txtBoyaKod.Clear();
            txtBoyaAdi.Clear();
            txtAciklama.Clear();
            nudKovaAdet.Value = 0;
            nudFiyat.Value = 0;
            cmbBoyaTipi.SelectedIndex = -1;
            CmbRenkler.SelectedIndex = -1;
        }

        private void dgvBoyalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvBoyalar.Rows[e.RowIndex];
                txtBoyaKod.Text = row.Cells["BoyaKodu"].Value.ToString();
                txtBoyaAdi.Text = row.Cells["RenkAdi"].Value.ToString();
                cmbBoyaTipi.SelectedItem = row.Cells["BoyaTipi"].Value.ToString();
                nudKovaAdet.Value = Convert.ToDecimal(row.Cells["KovaAdedi"].Value);
                nudFiyat.Value = Convert.ToDecimal(row.Cells["BoyaFiyat"].Value);
            }
        }

        private void txtFiltrele_TextChanged(object sender, EventArgs e)
        {
            string arama = txtFiltrele.Text.ToLower();
            var filtreli = _db.Boyalar.Where(x => x.RenkAdi.Contains(arama) || x.BoyaKodu.Contains(arama)).ToList();
            dgvBoyalar.DataSource = filtreli;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRMBoyaStogu _boyaStogu = new FRMBoyaStogu();
            _boyaStogu.Show();
        }

        private void CmbRenkler_DropDown(object sender, EventArgs e)
        {
            int newHeight = Math.Min(20 + (CmbRenkler.Items.Count * 20), 200);
            CmbRenkler.Height = newHeight;
            CmbRenkler.Width = 100;
        }

        private void CmbRenkler_DropDownClosed(object sender, EventArgs e)
        {
            CmbRenkler.Width = 20;
            txtBoyaAdi.Text = CmbRenkler.SelectedItem.ToString();
        }
    }
}
