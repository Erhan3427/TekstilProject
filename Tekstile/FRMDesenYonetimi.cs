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
using Tekstile.UI.Helpers.FRMDesenYonetim;

namespace Tekstile
{
    public partial class FRMDesenYonetimi : Form
    {
        MyDbContext _db = new MyDbContext();

        private List<DesenBoyalar> boyaListesi = new List<DesenBoyalar>();
        private int Boyasayisi = 0;

        public FRMDesenYonetimi()
        {
            InitializeComponent();
        }

        private void FRMDesenYonetimi_Load(object sender, EventArgs e)
        {
            cmbBoyalar.DataSource = _db.Boyalar.ToList();
            cmbBoyalar.DisplayMember = "RenkAdi";
            cmbBoyalar.ValueMember = "Id";

            cmbMusteri.DataSource = _db.Musteriler.ToList();
            cmbMusteri.DisplayMember = "FirmaAdi";
            cmbMusteri.ValueMember = "Id";
            DesenYonetimListele.Listele(dgvDesenler, _db);



        }

        private void nudBoyaSayisi_ValueChanged(object sender, EventArgs e)
        {

            if (nudBoyaSayisi.Value > 0)
            {
                cmbBoyalar.Enabled = true;
                nudGram.Enabled = true;
                btnKaydet.Enabled = false;
            }
            else
            {
                cmbBoyalar.Enabled = false;
                nudGram.Enabled = false;
            }
        }

        private void btnBoyaEkle_Click(object sender, EventArgs e)
        {
            if (DesenYonetimValidator.BoyaKontrol(cmbBoyalar.SelectedItem, (double)nudGram.Value) == false)
                return;

            var boya = new DesenBoyalar
            {
                BoyaId = (int)cmbBoyalar.SelectedValue,
                Gram = (double)nudGram.Value
            };
            boyaListesi.Add(boya);
            Boyasayisi++;
            MessageBox.Show("Eklendi");
            if (Boyasayisi == nudBoyaSayisi.Value)
            {
                MessageBox.Show("Tüm Boyalar Eklendi");
                btnKaydet.Enabled = true;
                cmbBoyalar.Enabled = false;
                nudGram.Enabled = false;
                Boyasayisi = 0;
            }





        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            if (DesenYonetimValidator.DesenKontrol(txtDesenAdi.Text, txtAciklama.Text, cmbMusteri.SelectedItem, (int)nudBoyaSayisi.Value) == false)
                return;

            var desen = new Desenler
            {
                DesenAdi = txtDesenAdi.Text,
                FotoYolu = Convert.ToString(ResmiByteArrayaCevir(pbDesen.Image)),
                Aciklama = txtAciklama.Text
            };

            _db.Desenler.Add(desen);
            _db.SaveChanges();

            foreach (var boya in boyaListesi)
            {
                boya.DesenId = desen.Id;
                boya.MusteriId = (int)cmbMusteri.SelectedValue;
                boya.BoyaSayisi = (int)nudBoyaSayisi.Value;
                _db.DesenBoyalari.Add(boya);
            }

            _db.SaveChanges();
            MessageBox.Show("Desen ve boyalar başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DesenYonetimListele.Listele(dgvDesenler, _db);
            DesenYonetimTemizleyici.Temizle(txtDesenAdi, txtAciklama, nudBoyaSayisi, nudGram, cmbMusteri, cmbBoyalar);


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
            var secili = cmbMusteri.SelectedItem as Musteriler;
            dgvDesenler.DataSource = _db.DesenBoyalari.Where( s=>  s.MusteriId == secili.Id ).Select(s=> new {
            
                s.Id,
                s.Musteri.FirmaAdi,
                s.Desen.DesenAdi,
                s.Boya.RenkAdi,
                s.Gram,

            }
            ).ToList();
        }

        private void btnRenkSec_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
            }
        }
    }
}
