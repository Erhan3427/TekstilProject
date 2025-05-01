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
    public partial class FormMusteri : Form
    {
        private MyDbContext _dbContext = new MyDbContext();
        public FormMusteri()
        {
            InitializeComponent();
            Listele();
        }

        private void FormMusteri_Load(object sender, EventArgs e)
        {

        }
        private void Listele()
        {
            var musteriler = _dbContext.Musteriler.ToList();
            dgvMüsteriler.DataSource = musteriler;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Musteriler musteri = new Musteriler()
            {
                FirmaAdi = txtFirmaAdi.Text,
                YetkiliAdSoyad = txtFirmaYetkili.Text,
                Telefon = txtTelefon.Text,
                Adres = txtIsAdresi.Text

            };
            _dbContext.Musteriler.Add(musteri);
            _dbContext.SaveChanges();
            Listele();
            MessageBox.Show("Müşteri Eklendi"); 
        }
    }
}
