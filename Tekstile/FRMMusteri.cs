using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tekstile.BLL.Interfaces;
using Tekstile.BLL.MusteriService;
using Tekstile.Context;
using Tekstile.Entities.Data;
using Tekstile.Helpers;

namespace Tekstile
{
    public partial class FRMMusteri : Form
    {
        MyDbContext _db;
        MusteriService _musteriService = new MusteriService();
        public FRMMusteri()
        {
            _db = new MyDbContext();

            InitializeComponent();
            Listele();
        }

        private void FormMusteri_Load(object sender, EventArgs e)
        {
            dgvMüsteriler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMüsteriler.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvMüsteriler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        public bool KontrolEt()
        {
            if (string.IsNullOrEmpty(txtFirmaAdi.Text) || string.IsNullOrEmpty(txtFirmaYetkili.Text) || string.IsNullOrEmpty(mtbTelefon.Text) || string.IsNullOrEmpty(txtIsAdresi.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return false;
            }
            if(_db.Musteriler.Any(m=>m.Kod == txtMusteriKod.Text)) { 
                MessageBox.Show("Bu kod zaten var. Lütfen farklı bir kod giriniz.");
                return false;
            }
            return true;
        }
        private void Listele()
        {

            dgvMüsteriler.DataSource = _db.Musteriler.ToList();
            dgvMüsteriler.Columns[0].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!KontrolEt())
            {
                return;
            }
            Musteriler musteri = new Musteriler()
            {
                FirmaAdi = txtFirmaAdi.Text,
                YetkiliAdSoyad = txtFirmaYetkili.Text,
                Telefon = mtbTelefon.Text,
                Adres = txtIsAdresi.Text,
                Kod = txtMusteriKod.Text

            };
            _musteriService.MusteriEkle(musteri);
            LogKayit.LogEkle("Admin", "Müşteri Ekleme", $"Müşteri Eklendi: {musteri.FirmaAdi}");

            MessageBox.Show("Müşteri Eklendi");
            Listele();
        }

        private void btnGuncell_Click(object sender, EventArgs e)
        {
            if (!KontrolEt())
                return;

            int id = Convert.ToInt32(dgvMüsteriler.CurrentRow.Cells[0].Value);
            var musteriler = _db.Musteriler.Find(id);

            musteriler.FirmaAdi = txtFirmaAdi.Text;
            musteriler.YetkiliAdSoyad = txtFirmaYetkili.Text;
            musteriler.Telefon = mtbTelefon.Text;
            musteriler.Adres = txtIsAdresi.Text;
            musteriler.Kod = txtMusteriKod.Text;
            _db.SaveChanges();
            LogKayit.LogEkle("Admin", "Müşteri Güncelleme", $"Müşteri Güncellendi: {musteriler.FirmaAdi}");
            MessageBox.Show("Güncellendi");
            Listele();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(dgvMüsteriler.CurrentRow.Cells[0].Value);
            if (id == null)
            {
                MessageBox.Show("Müşteri yok");
                return;
            }
            _musteriService.MusteriSil(id);
            LogKayit.LogEkle("Admin", "Müşteri Silme", $"Müşteri Silindi: {txtFirmaAdi.Text}");
            MessageBox.Show("Silindi");
            Listele();

        }

        private void dgvMüsteriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMüsteriler.CurrentRow != null)
            {
                txtFirmaAdi.Text = dgvMüsteriler.CurrentRow.Cells["FirmaAdi"].Value.ToString();
                txtFirmaYetkili.Text = dgvMüsteriler.CurrentRow.Cells["YetkiliAdSoyad"].Value.ToString();
                mtbTelefon.Text = dgvMüsteriler.CurrentRow.Cells["Telefon"].Value.ToString();
                txtIsAdresi.Text = dgvMüsteriler.CurrentRow.Cells["Adres"].Value.ToString();
                txtMusteriKod.Text = dgvMüsteriler.CurrentRow.Cells["Kod"].Value.ToString();


            }
        }
    }
}
