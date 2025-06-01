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
    public partial class FRMDesenYonetimi : Form
    {
        MyDbContext _db = new MyDbContext();
        public FRMDesenYonetimi()
        {
            InitializeComponent();
        }

        private void FRMDesenYonetimi_Load(object sender, EventArgs e)
        {
            cmbBoyalar.DataSource = _db.Boyalar.ToList();
            cmbBoyalar.DisplayMember = "RenkAdi";
            cmbBoyalar.ValueMember = "Id";
            cmbMusteri.DataSource = _db.Musteriler.Select(x => x.FirmaAdi).ToList();


        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            DesenBoyalar desenBoyalar = new DesenBoyalar()
            {
                BoyaId = (cmbBoyalar.SelectedValue as DesenBoyalar).BoyaId,
                MusteriId = ((DesenBoyalar)(cmbMusteri.SelectedValue)).MusteriId,
                GramMiktari = (double)nudGram.Value,
                BoyaSayisi =(int) nudBoyaSayisi.Value,
                Desen = new Desenler()
                {
                    DesenAdi = txtDesenAdi.Text,
                    FotoYolu = Convert.ToBase64String(ResmiByteArrayaCevir(pbDesen.Image)), 
                    Aciklama = txtAciklama.Text,
                },
            };

            _db.DesenBoyalari.Add(desenBoyalar);
            _db.SaveChanges();
            MessageBox.Show("Desen başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    pbDesen.SizeMode = PictureBoxSizeMode.StretchImage; // Resmi PictureBox'a sığdır
                }
            }
        }
    }
}
