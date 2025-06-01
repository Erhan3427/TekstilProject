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
    public partial class FRMMusteri : Form
    {
        private MyDbContext _db = new MyDbContext();
        public FRMMusteri()
        {
            InitializeComponent();
            Listele();
        }

        private void FormMusteri_Load(object sender, EventArgs e)
        {

        }
        public bool KontrolEt()
        {
            if (string.IsNullOrEmpty(txtFirmaAdi.Text) || string.IsNullOrEmpty(txtFirmaYetkili.Text) || string.IsNullOrEmpty(mtbTelefon.Text) || string.IsNullOrEmpty(txtIsAdresi.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return false;
            }
            return true;
        }
        private void Listele()
        {
            var musteriler = _db.Musteriler.ToList();
            dgvMüsteriler.DataSource = musteriler;
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
                Adres = txtIsAdresi.Text

            };
            _db.Musteriler.Add(musteri);
            _db.SaveChanges();
            Listele();
            MessageBox.Show("Müşteri Eklendi");
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
            _db.SaveChanges();
            MessageBox.Show("Güncellendi");
            Listele();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(dgvMüsteriler.CurrentRow.Cells[0].Value);
            var musteriler = _db.Musteriler.Find(id);
            if (musteriler == null)
            {
                MessageBox.Show("Müşteri yok");
                return;
            }
            _db.Remove(musteriler);
            _db.SaveChanges();
            MessageBox.Show("Silindi");
            Listele();

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            FRMGiris fRMGiris = new FRMGiris();
            fRMGiris.Show();
            this.Close();
        }
    }
}
