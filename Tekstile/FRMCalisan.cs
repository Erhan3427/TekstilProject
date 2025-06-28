using System;
using System.Windows.Forms;
using Tekstile.BLL.Services.Interfaces;
using Tekstile.Entities.Data;

namespace Tekstile
{
    public partial class FRMCalisan : Form
    {
        private readonly ICalisanService _calisanService;
        private int seciliId = 0;

        public FRMCalisan(ICalisanService calisanService)
        {
            InitializeComponent();
            _calisanService = calisanService;
        }

        private void FRMCalisanlar_Load(object sender, EventArgs e)
        {
            Listele();
            dgvCalisanlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Listele()
        {
            dgvCalisanlar.DataSource = _calisanService.HepsiniGetir().Select(x => new
            {
                x.Id,
                x.AdSoyad,
                x.Departman,
                x.Maas,
                cbCalisiyorMu = x.AktifMi ? "Çalýþýyor" : "Çalýþmýyor"

            }).ToList();
            dgvCalisanlar.Columns["Id"].Visible = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var calisan = new Calisan
            {
                AdSoyad = txtAdSoyad.Text,
                Departman = txtPozisyon.Text,
                Maas = decimal.Parse(txtMaas.Text),
                AktifMi = cbCalisiyorMu.Checked,
            };

            _calisanService.Ekle(calisan);
            MessageBox.Show("Çalýþan eklendi.");
            Listele();
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliId == 0) return;

            var calisan = _calisanService.IdyeGoreGetir(seciliId);
            if (calisan != null)
            {
                calisan.AdSoyad = txtAdSoyad.Text;
                calisan.Departman = txtPozisyon.Text;
                calisan.Maas = decimal.Parse(txtMaas.Text);
                calisan.AktifMi = cbCalisiyorMu.Checked;

                _calisanService.Guncelle(calisan);
                MessageBox.Show("Güncellendi.");
                Listele();
                Temizle();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (seciliId == 0) return;

            _calisanService.Sil(seciliId);
            MessageBox.Show("Silindi.");
            Listele();
            Temizle();
        }

        private void dgvCalisanlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                seciliId = Convert.ToInt32(dgvCalisanlar.Rows[e.RowIndex].Cells["Id"].Value);
                txtAdSoyad.Text = dgvCalisanlar.Rows[e.RowIndex].Cells["AdSoyad"].Value.ToString();
                txtPozisyon.Text = dgvCalisanlar.Rows[e.RowIndex].Cells["Pozisyon"].Value.ToString();
                txtMaas.Text = dgvCalisanlar.Rows[e.RowIndex].Cells["Maas"].Value.ToString();
                cbCalisiyorMu.Checked = Convert.ToBoolean(dgvCalisanlar.Rows[e.RowIndex].Cells["AktifMi"].Value);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            seciliId = 0;
            txtAdSoyad.Clear();
            txtPozisyon.Clear();
            txtMaas.Clear();
            cbCalisiyorMu.Checked = false;
        }

        private void FRMCalisan_Load(object sender, EventArgs e)
        {
            dgvCalisanlar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCalisanlar.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvCalisanlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
} 