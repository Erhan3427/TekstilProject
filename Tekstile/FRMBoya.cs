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
using Tekstile.Data;
using Tekstile.UI.Helpers;

namespace Tekstile
{
    public partial class FRMBoya : Form
    {
        MyDbContext _db = new MyDbContext();
        public FRMBoya()
        {
            InitializeComponent();
        }


        private void FormBoya_Load(object sender, EventArgs e)
        {
            dgvBoyalar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvBoyalar.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvBoyalar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            cmbKovaDurum.Items.AddRange(new[] { "Gelen", "Açılan", "Biten" });
            cmbBoyaTipi.Items.AddRange(new string[] { "Normal", "Şeffaf", "Tiner", "Yapışkan" });
            BoyaListeHelper.Listele(dgvBoyalar, _db);
        }
       
      
       

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!BoyaValidator.BoyaVerisiGecerliMi(txtBoyaKod.Text, txtBoyaAdi.Text, nudKovaAdet.Text, nudFiyat.Text, cmbBoyaTipi.SelectedItem, cmbKovaDurum.SelectedItem))
                return;


            var Boyalar = new Boyalar
            {
                BoyaKodu = txtBoyaKod.Text,
                RenkAdi = txtBoyaAdi.Text,
                BoyaTipi = cmbBoyaTipi.SelectedItem.ToString(),
                BoyaFiyat = Convert.ToDecimal(nudFiyat.Text),
                
            };

            // Önce Boyalar nesnesini kaydet
            _db.Boyalar.Add(Boyalar);
            _db.SaveChanges();

            // Stok hareketi oluştur
            StokHareket stokHareket = new StokHareket
            {
                BoyaId = Boyalar.Id,
                IslemTarihi = DateTime.Now,
                IslemTuru = cmbKovaDurum.SelectedItem.ToString(),
                Adet = Convert.ToInt32(nudKovaAdet.Text),
                Aciklama = txtAciklama.Text
            };

            // Stok durumunu güncelle
            int adet = Convert.ToInt32(nudKovaAdet.Text);
            if (cmbKovaDurum.SelectedItem.ToString() == "Gelen")
            {
                Boyalar.GelenAdet = adet;
                Boyalar.KovaAdedi = adet;
            }
            else if (cmbKovaDurum.SelectedItem.ToString() == "Biten")
            {
                if (Boyalar.KovaAdedi < adet)
                {
                    MessageBox.Show("Yeterli stok yok!");
                    _db.Boyalar.Remove(Boyalar);
                    _db.SaveChanges();
                    return;
                }
                Boyalar.BitenAdet = adet;
                Boyalar.KovaAdedi -= adet;
            }
            else if (cmbKovaDurum.SelectedItem.ToString() == "Açılan")
            {
                if (Boyalar.KovaAdedi < adet)
                {
                    MessageBox.Show("Yeterli stok yok!");
                    _db.Boyalar.Remove(Boyalar);
                    _db.SaveChanges();
                    return;
                }
                Boyalar.AcilanAdet = adet;
                Boyalar.KovaAdedi -= adet;
            }

            Boyalar.ToplamFiyat = Boyalar.BoyaFiyat * Boyalar.KovaAdedi;

            // Stok hareketini kaydet
            _db.StokHareket.Add(stokHareket);
            _db.SaveChanges();

            MessageBox.Show("Boyanız eklenmiştir");
            BoyaListeHelper.Listele(dgvBoyalar, _db);
            FormTemizleyici.Temizle(txtBoyaKod, txtBoyaAdi, nudKovaAdet, nudFiyat, cmbBoyaTipi, cmbKovaDurum);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvBoyalar.CurrentRow.Cells[0].Value);
            var boyalar = _db.Boyalar.Find(id);
            if (boyalar == null)
            {
                MessageBox.Show("Güncellenecek kayıt bulunamadı.");
                return;
            }
            if (!BoyaValidator.BoyaVerisiGecerliMi(txtBoyaKod.Text, txtBoyaAdi.Text, nudKovaAdet.Text, nudFiyat.Text, cmbBoyaTipi.SelectedItem, cmbKovaDurum.SelectedItem))
                return;


            // Eski değerleri sakla
            var eskiKovaAdedi = boyalar.KovaAdedi;
            string eskiDurum = boyalar.StokDurum;

            // Yeni değerleri ata
            boyalar.BoyaKodu = txtBoyaKod.Text;
            boyalar.RenkAdi = txtBoyaAdi.Text;
            boyalar.BoyaTipi = cmbBoyaTipi.SelectedItem.ToString();
            boyalar.BoyaFiyat = Convert.ToDecimal(nudFiyat.Text);
            boyalar.StokDurum = cmbKovaDurum.SelectedItem.ToString();

            // Stok hareketi oluştur
            int yeniAdet = Convert.ToInt32(nudKovaAdet.Text);
            if (eskiDurum != cmbKovaDurum.SelectedItem.ToString() || eskiKovaAdedi != yeniAdet)
            {
                StokHareket stokHareket = new StokHareket
                {
                    BoyaId = boyalar.Id,
                    IslemTarihi = DateTime.Now,
                    IslemTuru = cmbKovaDurum.SelectedItem.ToString(),
                    Adet = yeniAdet,
                };

                // Stok durumunu güncelle
                if (cmbKovaDurum.SelectedItem.ToString() == "Gelen")
                {
                    boyalar.GelenAdet = yeniAdet;
                    boyalar.KovaAdedi = yeniAdet;
                }
                else if (cmbKovaDurum.SelectedItem.ToString() == "Biten")
                {
                    if (boyalar.KovaAdedi < yeniAdet)
                    {
                        MessageBox.Show("Yeterli stok yok!");
                        return;
                    }
                    boyalar.BitenAdet = yeniAdet;
                    boyalar.KovaAdedi -= yeniAdet;
                }
                else if (cmbKovaDurum.SelectedItem.ToString() == "Açılan")
                {
                    if (boyalar.KovaAdedi < yeniAdet)
                    {
                        MessageBox.Show("Yeterli stok yok!");
                        return;
                    }
                    boyalar.AcilanAdet = yeniAdet;
                    boyalar.KovaAdedi -= yeniAdet;
                }

                _db.StokHareket.Add(stokHareket);
            }

            boyalar.ToplamFiyat = boyalar.BoyaFiyat * boyalar.KovaAdedi;

            _db.SaveChanges();
            MessageBox.Show("Güncellendi");
            BoyaListeHelper.Listele(dgvBoyalar, _db);
            FormTemizleyici.Temizle(txtBoyaKod, txtBoyaAdi, nudKovaAdet, nudFiyat, cmbBoyaTipi, cmbKovaDurum);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvBoyalar.CurrentRow.Cells[0].Value);
            var boyalar = _db.Boyalar.Find(id);
            if (boyalar != null)
            {
                _db.Boyalar.Remove(boyalar);
                _db.SaveChanges();
                MessageBox.Show("Silindi");
                BoyaListeHelper.Listele(dgvBoyalar, _db);
                FormTemizleyici.Temizle(txtBoyaKod, txtBoyaAdi, nudKovaAdet, nudFiyat, cmbBoyaTipi, cmbKovaDurum);
            }
            else
            {
                MessageBox.Show("Silinecek kayıt bulunamadı.");
            }

        }

        private void dgvBoyalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBoyalar.CurrentRow != null)
            {
                txtBoyaKod.Text = dgvBoyalar.CurrentRow.Cells[1].Value.ToString();
                txtBoyaAdi.Text = dgvBoyalar.CurrentRow.Cells[2].Value.ToString();
                cmbBoyaTipi.SelectedItem = dgvBoyalar.CurrentRow.Cells[3].Value.ToString();
                nudKovaAdet.Text = dgvBoyalar.CurrentRow.Cells[4].Value.ToString();
                nudFiyat.Text = dgvBoyalar.CurrentRow.Cells[5].Value.ToString();
                cmbKovaDurum.SelectedItem = dgvBoyalar.CurrentRow.Cells[6].Value.ToString();
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
            FRMBoyaStogu boya = new FRMBoyaStogu();
            boya.Show();

        }

    }
}
