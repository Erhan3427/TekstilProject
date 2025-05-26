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
    public partial class FRMDesenYonetimi : Form
    {
        MyDbContext _db = new MyDbContext();
        public FRMDesenYonetimi()
        {
            InitializeComponent();
        }

        private void FRMDesenYonetimi_Load(object sender, EventArgs e)
        {
            cmbBoyalar.DataSource = _db.Boyalar.ToList();
            cmbBoyalar.DisplayMember = "RenkAdi";
            cmbBoyalar.ValueMember = "Id";
            cmbMusteri.DataSource = _db.Musteriler.Select(x => x.FirmaAdi).ToList();


        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            DesenBoyalar desenBoyalar = new DesenBoyalar()
            {
                BoyaId = (cmbBoyalar.SelectedValue as DesenBoyalar).BoyaId,
                MusteriId=((DesenBoyalar)(cmbMusteri.SelectedValue)).MusteriId,
                



            };


        }
    }
}
