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
            cmbMusteri.DataSource = _db.Musteriler.Select(x =>    x.FirmaAdi ).ToList();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            Desenler desenler = new Desenler()
            {
                DesenAdi = textBox1.Text,
                FotoYolu = pictureBox1.ImageLocation,
                Boyasayisi = (int)nudBoyaSayisi.Value ,
                Aciklama = textBox2.Text,
                

            };
            DesenBoyalar desenBoyalar = new DesenBoyalar() 
            {

                GramMiktari = nudGram.Value
            };


        }
    }
}
