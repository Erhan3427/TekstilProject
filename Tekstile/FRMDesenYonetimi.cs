using System.Data;
using Tekstile.Context;
using Tekstile.Entities.Data;
using Tekstile.Helpers;

namespace Tekstile
{
    public partial class FRMDesenYonetimi : Form
    {
        private MyDbContext _db = new MyDbContext();
        private List<DesenBoyalar> boyaListesi = new List<DesenBoyalar>();
        private int hedefBoyaSayisi = 0;
        private int eklenenBoyaSayisi = 0; // Yeni: Kaç boya eklendiğini takip etmek için
        private bool boyaEklemeModu = false;

        public FRMDesenYonetimi()
        {
            InitializeComponent();
        }

        private void FRMDesenYonetimi_Load(object sender, EventArgs e)
        {
            dgvDesenler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDesenler.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvDesenler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            cmbBoyalar.DataSource = _db.Boyalar.ToList();
            cmbBoyalar.DisplayMember = "RenkAdi";
            cmbBoyalar.ValueMember = "Id";

            cmbMusteri.DataSource = _db.Musteriler.ToList();
            cmbMusteri.DisplayMember = "FirmaAdi";
            cmbMusteri.ValueMember = "Id";

            // Form ilk yüklendiğinde boya ekleme kontrolleri pasif olmalı
            BoyaEklemeModunuAyarla(false);
            DesenleriListele();
        }

        private void DesenleriListele()
        {
            dgvDesenler.DataSource = _db.DesenBoyalari
                .Select(s => new
                {
                    s.Id,
                    s.Desen.DesenAdi,
                    s.Musteri.FirmaAdi,
                    s.Boya.RenkAdi,
                    s.BoyaSayisi, // Burada "BoyaSayisi" yerine "BoyaAdedi" gibi bir şey daha mantıklı olabilir
                    s.Gram
                })
                .ToList();
            dgvDesenler.Columns["Id"].Visible = false; // Id sütununu gizle
        }

        private void nudBoyaSayisi_ValueChanged(object sender, EventArgs e)
        {
            // Hedef boya sayısını güncelle
            int yeniHedefBoyaSayisi = (int)nudBoyaSayisi.Value;

            // Eğer mevcut hedef boya sayımızdan daha az bir sayıya düşürülmeye çalışılıyorsa
            if (yeniHedefBoyaSayisi < eklenenBoyaSayisi)
            {
                MessageBox.Show($"Zaten {eklenenBoyaSayisi} adet boya eklediniz. Hedef boya sayısını azaltamazsınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudBoyaSayisi.Value = hedefBoyaSayisi; // Eski değeri geri yükle
                return;
            }

            // Eğer mevcut boya ekleme modundayken (yani henüz hedefe ulaşmadıysak)
            // ve kullanıcı hedefi artırıyorsa, bu kabul edilebilir.
            // Ancak bu noktada `boyaEklemeModu` sadece "ekleme işleminin tamamlanıp tamamlanmadığını" değil,
            // "boya ekleme kontrollerinin aktif olup olmadığını" belirtmelidir.

            hedefBoyaSayisi = yeniHedefBoyaSayisi;

            if (hedefBoyaSayisi > 0)
            {
                // Eğer hedef boya sayısı sıfırdan büyükse, boya ekleme modunu aktif et
                BoyaEklemeModunuAyarla(true);
            }
            else
            {
                // Eğer hedef boya sayısı sıfırsa, moddan çık ve listeyi temizle
                boyaListesi.Clear();
                eklenenBoyaSayisi = 0;
                BoyaEklemeModunuAyarla(false);
                // Kaydet butonu da bu durumda pasif olmalı
                btnKaydet.Enabled = false;
            }
        }

        private void BoyaEklemeModunuAyarla(bool aktif)
        {
            // boyaEklemeModu değişkeni, asıl olarak boya ekleme kontrollerinin durumunu yönetmeli
            boyaEklemeModu = aktif; // Bu değişkeni genel mod olarak kullanabiliriz

            cmbBoyalar.Enabled = aktif && (eklenenBoyaSayisi < hedefBoyaSayisi); // Sadece hedefe ulaşmadıysak aktif olsun
            nudGram.Enabled = aktif && (eklenenBoyaSayisi < hedefBoyaSayisi);    // Sadece hedefe ulaşmadıysak aktif olsun
            btnBoyaEkle.Enabled = aktif && (eklenenBoyaSayisi < hedefBoyaSayisi); // Sadece hedefe ulaşmadıysak aktif olsun

            // Kaydet butonu, hedef sıfırdan büyükse VE eklenen boya sayısı hedefe ulaştıysa aktif olsun
            btnKaydet.Enabled = (hedefBoyaSayisi > 0 && eklenenBoyaSayisi == hedefBoyaSayisi);
        }

        private void btnBoyaEkle_Click(object sender, EventArgs e)
        {
            // Hedefe ulaşıldıysa daha fazla eklemeyi engelle
            if (eklenenBoyaSayisi >= hedefBoyaSayisi)
            {
                MessageBox.Show("Belirtilen tüm boyalar zaten eklendi. Hedef boya sayısını artırın veya kaydetme işlemine geçin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Ek kontrolleri devre dışı bırak
                BoyaEklemeModunuAyarla(false); // Modu pasife çek
                btnKaydet.Enabled = true; // Kaydet butonunu aktif et
                return;
            }

            if (cmbBoyalar.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir boya seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nudGram.Value <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir gram değeri giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var boya = new DesenBoyalar
            {
                BoyaId = (int)cmbBoyalar.SelectedValue,
                Gram = (double)nudGram.Value,
                // DesenId, MusteriId ve BoyaSayisi bu aşamada belli değil, kaydetme sırasında atanacaklar.
                // Sadece listeye eklediğimiz boyanın kendi değerleri burada.
                // Eğer BoyaSayisi alanının amacı eklenen toplam boya sayısı ise, bu kısmı sonra güncelleyeceğiz.
                // Şimdilik 0 veya varsayılan değerde kalsın.
                BoyaSayisi = 0 // Bu alanın kullanım amacını netleştirmek gerekiyor
            };

            boyaListesi.Add(boya);
            eklenenBoyaSayisi++; // Her boya eklendiğinde sayacı artır

            MessageBox.Show($"Boya eklendi. Kalan boya adedi: {hedefBoyaSayisi - eklenenBoyaSayisi}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Ekledikten sonra kontrolleri temizle
            cmbBoyalar.SelectedIndex = -1;
            nudGram.Value = 0;

            // Modu tekrar ayarla ki butonların ve combo box'ların durumu güncellensin
            BoyaEklemeModunuAyarla(true); // Ekleme modunu aktif tut, ancak altındaki kontroller kapanabilir
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDesenAdi.Text))
            {
                MessageBox.Show("Lütfen desen adını giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbMusteri.SelectedItem == null)
            {
                MessageBox.Show("Lütfen müşteri seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Boya listesi sayısı, hedef boya sayısıyla eşit olmalı.
            // Eğer eşit değilse ve kayıt işlemi tetiklenirse uyarı verelim.
            if (boyaListesi.Count < hedefBoyaSayisi)
            {
                MessageBox.Show($"Lütfen belirtilen {hedefBoyaSayisi} boyanın hepsini ekleyiniz. Eklenen boya sayısı: {boyaListesi.Count}", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (boyaListesi.Count == 0)
            {
                MessageBox.Show("Lütfen en az bir boya ekleyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var desen = new Desenler
            {
                DesenAdi = txtDesenAdi.Text,
                // FotoYolu'nu byte[] olarak kaydetmek daha iyi bir pratik olabilir
                // Bu kısımda bir hata var: Convert.ToString(ResmiByteArrayaCevir(pbDesen.Image))
                // byte[]'ı string'e çevirmek yerine direkt byte[] olarak kaydetmelisiniz.
                // Eğer veritabanında FotoYolu string ise, Base64 encode/decode yapmanız gerekir.
                // Basitlik için şimdilik null bırakıyorum veya varsa Base64 string'e çeviriyorum.
                FotoYolu = pbDesen.Image != null ? Convert.ToBase64String(ResmiByteArrayaCevir(pbDesen.Image)) : null,
                Aciklama = txtAciklama.Text
            };

            _db.Desenler.Add(desen);
            _db.SaveChanges(); // Desen kaydedildikten sonra Id'si oluşur

            foreach (var boya in boyaListesi)
            {
                boya.DesenId = desen.Id;
                boya.MusteriId = (int)cmbMusteri.SelectedValue;
                boya.BoyaSayisi = hedefBoyaSayisi; // Her bir DesenBoyalar kaydına toplam hedef boya sayısını atayabiliriz
                _db.DesenBoyalari.Add(boya);
            }

            _db.SaveChanges();
            LogKayit.LogEkle("admin", "DesenEkle", $"Desen eklendi: {desen.DesenAdi}");
            MessageBox.Show("Desen ve boyalar başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FormuTemizle();
            DesenleriListele();
        }

        private void FormuTemizle()
        {
            txtDesenAdi.Clear();
            txtAciklama.Clear();
            pbDesen.Image = null;
            cmbMusteri.SelectedIndex = -1;
            nudBoyaSayisi.Value = 0; 
            boyaListesi.Clear();
            hedefBoyaSayisi = 0;
            eklenenBoyaSayisi = 0; // Temizleme sırasında eklenen boya sayacını da sıfırla
            BoyaEklemeModunuAyarla(false);
        }

        private byte[] ResmiByteArrayaCevir(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, img.RawFormat);
                return ms.ToArray();
            }
        }

        private void btnDesenEkle_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Bir resim seçin";
                openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pbDesen.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
                    pbDesen.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void cmbMusteri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMusteri.SelectedItem != null)
            {
                var seciliMusteri = cmbMusteri.SelectedItem as Musteriler;
                dgvDesenler.DataSource = _db.DesenBoyalari
                    .Where(s => s.MusteriId == seciliMusteri.Id)
                    .Select(s => new
                    {
                        s.Id,
                        s.Musteri.FirmaAdi,
                        s.Desen.DesenAdi,
                        s.Boya.RenkAdi,
                        s.Gram
                    })
                    .ToList();
            }
            else
            {
                DesenleriListele(); // Eğer müşteri seçimi kaldırılırsa tüm desenleri göster
            }
        }
    }
}
