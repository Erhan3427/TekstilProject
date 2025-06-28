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
    public partial class FRMMakineYonetimi : Form
    {
        IMakineService _db;
        IKumasService _kumasService;
        private int seciliMakineId = 0;
        private int seciliKumasId = 0;

      

        public FRMMakineYonetimi(IMakineService db, IKumasService kumasService)
        {
            InitializeComponent();
            _db = db;
            _kumasService = kumasService;
        }

        private void FRMMakineYonetimi_Load(object sender, EventArgs e)
        {
            // DataGridView ayarları
            dgvMakineler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMakineler.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvMakineler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvKumaslar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvKumaslar.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvKumaslar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            MakineleriListele();
            KumaslariListele();
        }

        private void MakineleriListele()
        {
            dgvMakineler.DataSource = _db.HepsiniGetir().Select(m => new
            {
                m.Id,
                m.MakineAdi,
                m.Aciklama

            }).ToList();
            dgvMakineler.Columns["Id"].Visible = false; // Id sütununu gizle
        }

        private void KumaslariListele()
        {
            dgvKumaslar.DataSource = _kumasService.HepsiniGetir().Select(k => new
            {
                k.Id,
                k.KumasAdi,
                k.Gramaj,
                k.IplikTipi
            }).ToList();
            dgvKumaslar.Columns["Id"].Visible = false; // Id sütununu gizle

        }

        private void btnMakineEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMakineAdi.Text))
            {
                MessageBox.Show("Lütfen makine adı giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var makine = new Makineler
            {
                MakineAdi = txtMakineAdi.Text,
                Aciklama = txtMakineAciklama.Text

            };

            _db.Ekle(makine);
            LogKayit.LogEkle("Admin", "Makine Ekleme", $"Makine Eklendi: {makine.MakineAdi}");
            MessageBox.Show("Makine başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MakineleriListele();
            MakineFormuTemizle();
        }

        private void btnKumasEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKumasAdi.Text))
            {
                MessageBox.Show("Lütfen kumaş adı giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nudGramaj.Value <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir gramaj değeri giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var kumas = new Kumascinsleri
            {
                KumasAdi = txtKumasAdi.Text,
                Gramaj = (double)nudGramaj.Value,
                IplikTipi = txtiplikTipi.Text 

            };

            _kumasService.Ekle(kumas);
            LogKayit.LogEkle("Admin", "Kumas Ekleme ",$"Kumaş Eklendi: {kumas.KumasAdi}");
            MessageBox.Show("Kumaş başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            KumaslariListele();
            KumasFormuTemizle();
        }

        private void btnMakineGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliMakineId == 0)
            {
                MessageBox.Show("Lütfen güncellenecek makineyi seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var makine = _db.GetById(seciliMakineId);
            if (makine != null)
            {
                makine.MakineAdi = txtMakineAdi.Text;
                makine.Aciklama = txtMakineAciklama.Text;
                _db.Guncelle(makine);
                LogKayit.LogEkle("Admin","Makine Güncelleme",$"Makine Güncellendi: {makine.MakineAdi}");
                MessageBox.Show("Makine başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MakineleriListele();
                MakineFormuTemizle();
            }
        }

        private void btnKumasGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliKumasId == 0)
            {
                MessageBox.Show("Lütfen güncellenecek kumaşı seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var kumas = _kumasService.GetById(seciliKumasId);
            if (kumas != null)
            {
                kumas.KumasAdi = txtKumasAdi.Text;
                kumas.Gramaj = (double)nudGramaj.Value;
                kumas.IplikTipi = txtiplikTipi.Text;

                _kumasService.Guncelle(kumas);
                LogKayit.LogEkle("Admin", "Kumaş Güncelle", $"Kumaş Güncellendi: {kumas.KumasAdi}");
                MessageBox.Show("Kumaş başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KumaslariListele();
                KumasFormuTemizle();
            }
        }

        private void btnMakineSil_Click(object sender, EventArgs e)
        {
            if (seciliMakineId == 0)
            {
                MessageBox.Show("Lütfen silinecek makineyi seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Seçili makineyi silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var makine = _db.GetById(seciliMakineId);
                if (makine != null)
                {
                    _db.Sil(seciliMakineId); // Use the 'Sil' method from IMakineService to delete the machine  
                    LogKayit.LogEkle("Admin", "Makine Silme", $"Makine Silindi: {makine.MakineAdi}");
                    MessageBox.Show("Makine başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MakineleriListele();
                    MakineFormuTemizle();
                }
            }
        }

        private void btnKumasSil_Click(object sender, EventArgs e)
        {
            if (seciliKumasId == 0)
            {
                MessageBox.Show("Lütfen silinecek kumaşı seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Seçili kumaşı silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var kumas = _kumasService.GetById(seciliKumasId);
                if (kumas != null)
                {
                    _kumasService.Sil(seciliKumasId);
                    LogKayit.LogEkle("Admin", "Kumaş Silme", $"Kumaş Silindi: {kumas.KumasAdi}");
                    MessageBox.Show("Kumaş başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    KumaslariListele();
                    KumasFormuTemizle();
                }
            }
        }

       
        private void MakineFormuTemizle()
        {
            txtMakineAdi.Clear();
            txtMakineAciklama.Clear();
            seciliMakineId = 0;
        }

        private void KumasFormuTemizle()
        {
            txtKumasAdi.Clear();
            txtiplikTipi.Clear();
            nudGramaj.Value = 0;
            seciliKumasId = 0;
        }

        private void dgvMakineler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvMakineler.Rows[e.RowIndex];
                seciliMakineId = Convert.ToInt32(row.Cells["Id"].Value);
                txtMakineAdi.Text = row.Cells["MakineAdi"].Value.ToString();
                txtMakineAciklama.Text = row.Cells["Aciklama"].Value.ToString();

            }
        }

        private void dgvKumaslar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvKumaslar.Rows[e.RowIndex];
                seciliKumasId = Convert.ToInt32(row.Cells["Id"].Value);
                txtKumasAdi.Text = row.Cells["KumasAdi"].Value.ToString();
                nudGramaj.Value = Convert.ToDecimal(row.Cells["Gramaj"].Value);
                txtiplikTipi.Text = row.Cells["IplikTipi"].Value.ToString();
            }
        }
    }
} 