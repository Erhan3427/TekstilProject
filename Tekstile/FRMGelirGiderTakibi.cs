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
    public partial class FRMGelirGiderTakibi : Form
    {
        private MyDbContext _db = new MyDbContext();
        private decimal toplamGelir = 0;
        private decimal toplamGider = 0;

        public FRMGelirGiderTakibi()
        {
            InitializeComponent();
        }

        private void FRMGelirGiderTakibi_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde yapılacak işlemler
            dgvGelirGider.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGelirGider.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvGelirGider.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // ComboBox'ları doldur
            cmbGiderTuru.Items.AddRange(new string[] { "Boya Alımı", "Kumaş Alımı", "Bakım Masrafı", "Maaş Ödemesi", "Diğer" });
            cmbGiderTuru.SelectedIndex = 0;

            // Tarih aralığını ayarla
            dtpBaslangic.Value = DateTime.Now.AddMonths(-1);
            dtpBitis.Value = DateTime.Now;

            GelirGiderListele();
        }

        private void GelirGiderListele()
        {
            var baslangicTarihi = dtpBaslangic.Value.Date;
            var bitisTarihi = dtpBitis.Value.Date.AddDays(1).AddSeconds(-1);

          

            //// Toplamları göster
            //lblToplamGelir.Text = $"Toplam Gelir: {toplamGelir:C2}";
            //lblToplamGider.Text = $"Toplam Gider: {toplamGider:C2}";
            //lblBakiye.Text = $"Bakiye: {(toplamGelir - toplamGider):C2}";
        }

        private void btnGiderEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAciklama.Text) || nudTutar.Value <= 0)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun ve geçerli bir tutar girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var yeniGider = new Giderler
            {
                Tarih = dtpGiderTarihi.Value,
                GiderTuru = cmbGiderTuru.SelectedItem.ToString(),
                Aciklama = txtAciklama.Text,
                Tutar = nudTutar.Value
            };

            //_db.Giderler.Add(yeniGider);
            _db.SaveChanges();
            LogKayit.LogEkle("admin", "GiderEkle", $"Gider eklendi: {yeniGider.GiderTuru} - {yeniGider.Tutar:C2} - {yeniGider.Aciklama}");

            MessageBox.Show("Gider başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GelirGiderListele();
            Temizle();
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            GelirGiderListele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            dtpBaslangic.Value = DateTime.Now.AddMonths(-1);
            dtpBitis.Value = DateTime.Now;
            GelirGiderListele();
        }

        private void Temizle()
        {
            txtAciklama.Clear();
            nudTutar.Value = 0;
            dtpGiderTarihi.Value = DateTime.Now;
            cmbGiderTuru.SelectedIndex = 0;
        }
    }
} 