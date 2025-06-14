using Microsoft.EntityFrameworkCore;
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
using Tekstile.BLL.Services;
using Tekstile.Context;

namespace Tekstile.Data
{
    public partial class FRMBoyaStogu : Form
    {
        MyDbContext _db = new MyDbContext();
        BoyaStoguService _stokService = new BoyaStoguService();
        public FRMBoyaStogu()
        {

            InitializeComponent();
        }

       

        private void BoyaStoğu_Load(object sender, EventArgs e)
        {
            dgvBoyaStok.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvBoyaStok.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvBoyaStok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            listele();
            cmbİslemler.Items.AddRange(new[] { "Gelen", "Açılan", "Biten", "Hepsi" });

        }

        private void listele()
        {
            dgvBoyaStok.DataSource = _stokService.StokListele().ToList();

            dgvBoyaStok.Columns[0].Visible = false;


        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            var Baslangictarihi = dtpBaslangic.Value;
            var Bitistarihi = dtpBitis.Value;
            var filtreli = _db.StokHareket
                .Where(x => x.IslemTarihi >= Baslangictarihi.AddDays(-1) && x.IslemTarihi <= Bitistarihi).Include(x =>x.Boya).ToList();

            if (cmbİslemler.SelectedItem != null && cmbİslemler.SelectedItem.ToString() != "Hepsi")
            {
                filtreli = filtreli
                    .Where(s => s.IslemTuru == cmbİslemler.SelectedItem.ToString())
                    .ToList(); 
            }
            else if (cmbİslemler.SelectedItem == "Hepsi")
            {
                listele();
                return;
            }

            dgvBoyaStok.DataSource = filtreli;
        }
    }
}
