using System;
using System.Windows.Forms;
using Tekstile.BLL.Services.Interfaces;
using Tekstile.Entities.Data;
using Tekstile.Helpers;

namespace Tekstile
{
    public partial class FRMGider : Form
    {
        IGiderService _giderService;

        public FRMGider(IGiderService giderService)
        {
            InitializeComponent();
            _giderService = giderService;
        }

        private void FRMGider_Load(object sender, EventArgs e)
        {
            dgvGiderler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvGiderler.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvGiderler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGiderTuru.Text) || string.IsNullOrEmpty(txtAciklama.Text) || string.IsNullOrEmpty(txtTutar.Text))
            {
                MessageBox.Show("Lütfen tüm alanlarý doldurunuz.");
                return;
            }
            try
            {
                var gider = new Giderler
                {
                    GiderTuru = txtGiderTuru.Text,
                    Aciklama = txtAciklama.Text,
                    Tutar = decimal.Parse(txtTutar.Text),
                    Tarih = dtpTarih.Value
                };
                _giderService.Ekle(gider);
                MessageBox.Show("Gider baþarýyla eklendi.");
                LogKayit.LogEkle("Admin", "Gider Ekleme", $"Gider Eklendi: {gider.GiderTuru} - {gider.Tutar}");
                Listele();

            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen geçerli bir tutar giriniz.");
            }


        }

        private void Listele()
        {
            dgvGiderler.DataSource = _giderService.HepsiniGetir();
            dgvGiderler.Columns["Id"].Visible = false; // Id sütununu gizle
            dgvGiderler.Columns["Tutar"].DefaultCellStyle.Format = "C2"; // Tutar sütununu para birimi formatýnda göster
        }
    }
} 