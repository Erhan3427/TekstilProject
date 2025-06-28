using System.Data;
using Tekstile.BLL.Services.Interfaces;


namespace Tekstile.Data
{
    public partial class FRMBoyaStogu : Form
    {
        IStokService _db;

        public FRMBoyaStogu(IStokService db)
        {
            InitializeComponent();
            _db = db;
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
            dgvBoyaStok.DataSource = _db.HepsiniGetir().Select(s => new
            {
                s.Id,
                s.Boya.RenkAdi,
                KovaAdedi = s.Adet,
                s.IslemTuru,
                s.IslemTarihi,
                s.Aciklama
            }).ToList();

            dgvBoyaStok.Columns["ID"].Visible = false;


        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            var Baslangictarihi = dtpBaslangic.Value;
            var Bitistarihi = dtpBitis.Value;
            var filtreli = _db.HepsiniGetir()
                .Where(x => x.IslemTarihi >= Baslangictarihi.AddDays(-1) && x.IslemTarihi <= Bitistarihi)
                .Select(s => new
                {
                    s.Id,
                    s.Boya.RenkAdi,
                    KovaAdedi = s.Adet,
                    s.IslemTuru,
                    s.IslemTarihi,
                    s.Aciklama
                }).ToList();

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
            dgvBoyaStok.Columns["ID"].Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var Baslangictarihi = dtpBaslangic.Value;
            var Bitistarihi = dtpBitis.Value;
            string arama = txtFiltreleStok.Text.ToLower();
            var filtreli = _db.HepsiniGetir()
                .Where(x => x.IslemTarihi >= Baslangictarihi.AddDays(-1) && x.IslemTarihi <= Bitistarihi)
                .Where(x => x.Boya.RenkAdi.ToLower().Contains(arama))
                .Select(s => new
                {
                    s.Id,
                    s.Boya.RenkAdi,
                    KovaAdedi = s.Adet,
                    s.IslemTuru,
                    s.IslemTarihi,
                    s.Aciklama
                }).ToList();
            dgvBoyaStok.DataSource = filtreli;
        }
    }
}
