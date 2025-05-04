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

namespace Tekstile
{
    public partial class FRMMusteri : Form
    {
        private MyDbContext _dbContext = new MyDbContext();
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
            var musteriler = _dbContext.Musteriler.ToList();
            dgvMüsteriler.DataSource = musteriler;
            dgvMüsteriler.Columns[0].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Musteriler musteri = new Musteriler()
            {
                FirmaAdi = txtFirmaAdi.Text,
                YetkiliAdSoyad = txtFirmaYetkili.Text,
                Telefon = mtbTelefon.Text,
                Adres = txtIsAdresi.Text

            };
            _dbContext.Musteriler.Add(musteri);
            _dbContext.SaveChanges();
            Listele();
            MessageBox.Show("Müşteri Eklendi"); 
        }
    }
}
