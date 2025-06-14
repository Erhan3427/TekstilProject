using System;
using System.Linq;
using System.Windows.Forms;
using Tekstile.Context;
using Tekstile.Entities.Data;

namespace Tekstile
{
    public partial class FRMLogKayitlari : Form
    {
        private readonly MyDbContext _db = new MyDbContext();

        public FRMLogKayitlari()
        {
            InitializeComponent();
        }

        private void FRMLogKayitlari_Load(object sender, EventArgs e)
        {
            // DataGridView ayarları
            dgvLoglar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvLoglar.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvLoglar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            LoglariListele();
        }

        private void LoglariListele()
        {
           
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            LoglariListele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            dtpBaslangic.Value = DateTime.Now.AddDays(-30);
            dtpBitis.Value = DateTime.Now;
            cmbKullanici.SelectedIndex = 0;
            cmbIslemTuru.SelectedIndex = 0;
            LoglariListele();
        }
    }
} 