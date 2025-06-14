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
using Tekstile.Helpers;

namespace Tekstile
{
    public partial class FRMMakineYonetimi : Form
    {
        private MyDbContext _db = new MyDbContext();
        private int seciliMakineId = 0;
        private int seciliKumasId = 0;

        public FRMMakineYonetimi()
        {
            InitializeComponent();
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
            dgvMakineler.DataSource = _db.Makineler.Select(m => new
            {
                m.Id,
                m.MakineAdi,
                m.Aciklama

            }).ToList();
            dgvMakineler.Columns["Id"].Visible = false; // Id sütununu gizle
        }

        private void KumaslariListele()
        {
            dgvKumaslar.DataSource = _db.Kumascinsleri.Select(k => new
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

            _db.Makineler.Add(makine);
            _db.SaveChanges();
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

            _db.Kumascinsleri.Add(kumas);
            _db.SaveChanges();
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

            var makine = _db.Makineler.Find(seciliMakineId);
            if (makine != null)
            {
                makine.MakineAdi = txtMakineAdi.Text;
                _db.SaveChanges();
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

            var kumas = _db.Kumascinsleri.Find(seciliKumasId);
            if (kumas != null)
            {
                kumas.KumasAdi = txtKumasAdi.Text;
                kumas.Gramaj = (double)nudGramaj.Value;
                _db.SaveChanges();
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
                var makine = _db.Makineler.Find(seciliMakineId);
                if (makine != null)
                {
                    _db.Makineler.Remove(makine);
                    _db.SaveChanges();
                    LogKayit.LogEkle("Admin","Makine Silme", $"Makine Silindi: {makine.MakineAdi}");
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
                var kumas = _db.Kumascinsleri.Find(seciliKumasId);
                if (kumas != null)
                {
                    _db.Kumascinsleri.Remove(kumas);
                    _db.SaveChanges();
                    LogKayit.LogEkle("Admin","Kumaş Silme", $"Kumaş Silindi: {kumas.KumasAdi}");
                    MessageBox.Show("Kumaş başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    KumaslariListele();
                    KumasFormuTemizle();
                }
            }
        }

       
        private void MakineFormuTemizle()
        {
            txtMakineAdi.Clear();
            seciliMakineId = 0;
        }

        private void KumasFormuTemizle()
        {
            txtKumasAdi.Clear();
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