using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Logging;
using System.Data;
using Tekstile.BLL.Services;
using Tekstile.BLL.Services.Interfaces;
using Tekstile.Context;
using Tekstile.Data;
using Tekstile.Entities.Data;
using Tekstile.Helpers;

namespace Tekstile
{
    public partial class FRMBoya : Form
    {
        IBoyaService _db;
        IStokService _stokService;
        IServiceProvider _serviceProvider;
        IGiderService _giderService;

        public FRMBoya(IBoyaService db, IStokService stokService, IServiceProvider serviceProvider, IGiderService giderService)
        {
            InitializeComponent(); // her zaman en başta çağır
            _db = db;
            _stokService = stokService;
            _serviceProvider = serviceProvider;


            _giderService = giderService;
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
        private void button1_Click(object sender, EventArgs e)
        {
            var boyaStoguForm = _serviceProvider.GetRequiredService<FRMBoyaStogu>();
            boyaStoguForm.ShowDialog();
        }

        private void ListeleEklenenBoyalar()
        {
            var boyalar = _db.HepsiniGetir()
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
            dgvBoyalar.Columns["ToplamFiyat"].DefaultCellStyle.Format = "C2";
            dgvBoyalar.Columns["BoyaFiyat"].DefaultCellStyle.Format = "C2";
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
            if ( _db.HepsiniGetir().Any(b=>b.BoyaKodu==txtBoyaKod.Text)) {
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
            _db.Ekle(boya);

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

            var gider = new Giderler
            {
                GiderTuru = boya.RenkAdi+" Boya Alımı",
                Tutar = (decimal)boya.ToplamFiyat,
                Tarih = DateTime.Now,
                Aciklama = txtAciklama.Text


            };
            _giderService.Ekle(gider);


            MessageBox.Show("Boya başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LogKayit.LogEkle("admin", "BoyaEkle", $"Boya eklendi: {boya.BoyaKodu}");


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
       

            int id = Convert.ToInt32(dgvBoyalar.CurrentRow.Cells["Id"].Value);
            var boya = _db.GetById(id);

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
                _db.Sil(id);
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
            var filtreli = _db.HepsiniGetir().Where(x => x.RenkAdi.Contains(arama) || x.BoyaKodu.Contains(arama)).ToList();
            dgvBoyalar.DataSource = filtreli;
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
            txtBoyaAdi.Text = CmbRenkler.SelectedItem?.ToString() ?? string.Empty;
        }
    }
}
