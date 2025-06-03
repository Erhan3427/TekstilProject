using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tekstile.BLL.Services;
using Tekstile.Context;
using Tekstile.Entities.Data;

namespace Tekstile.UI
{
    public partial class FRMMakineYonetim : Form
    {
        MyDbContext _db = new MyDbContext();
        MakineService makineService = new MakineService();
        public FRMMakineYonetim()
        {
            InitializeComponent();
        }

        private void FRMMakineYonetim_Load(object sender, EventArgs e)
        {

            dgvMakineler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMakineler.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvMakineler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Listele();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Makineler makineler = new Makineler()
            {
                MakineAdi = txtMakineAdi.Text,
                Aciklama = txtAciklama.Text,
            };
            makineService.Ekle(makineler);
            MessageBox.Show("Makine Eklendi");

        }
        public void Listele()
        {
            dgvMakineler.DataSource = makineService.MakineleriListele();
            dgvMakineler.Columns["Id"].Visible = false; // Id sütununu gizle
            dgvMakineler.Columns["MakineAdi"].HeaderText = "Makine Adı"; // Sütun başlıklarını düzenle
            dgvMakineler.Columns["Aciklama"].HeaderText = "Açıklama"; // Sütun başlıklarını düzenle

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var secilen = dgvMakineler.SelectedRows[0].DataBoundItem as Makineler;

            if (secilen == null)
            {
                MessageBox.Show("Lütfen silinecek makineyi seçin.");
                return;
            }
            makineService.sil(secilen.Id);
            MessageBox.Show("Makine Silindi");
            dgvMakineler.DataSource = makineService.MakineleriListele();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var secilen = dgvMakineler.SelectedRows[0].DataBoundItem as Makineler;
            secilen.MakineAdi = txtMakineAdi.Text;
            secilen.Aciklama = txtAciklama.Text;
            _db.SaveChanges();
            MessageBox.Show("Makine Güncellendi");
            dgvMakineler.DataSource = makineService.MakineleriListele();




        }
    }
}
