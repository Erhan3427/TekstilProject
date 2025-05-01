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

namespace Tekstile.Data
{
    public partial class BoyaStoğu : Form
    {
        MyDbContext _db = new MyDbContext();
        public BoyaStoğu()
        {
            InitializeComponent();
        }

        private void BoyaStoğu_Load(object sender, EventArgs e)
        {
           dgvBoyaStok.DataSource = _db.StokHareket.ToList();
        }
    }
}
