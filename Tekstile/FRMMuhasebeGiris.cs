using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tekstile.UI
{
    public partial class FRMMuhasebeGiris : Form
    {
        public FRMMuhasebeGiris()
        {
            InitializeComponent();
        }
         public void FormGetir(Form form)
        {
            pnlYonetim.Controls.Clear();

            form.TopLevel = false; // ÖNEMLİ: Form'un top-level olmadığını belirtiyoruz
            form.FormBorderStyle = FormBorderStyle.None;

            pnlYonetim.Controls.Add(form);
            pnlYonetim.Tag = form; // Form referansını sakla

            form.Show();
        }


        private void btnCikis_Click(object sender, EventArgs e)
        {
            AnaGiris anaGiris = new AnaGiris();
            anaGiris.Show();
            this.Hide(); // Mevcut formu gizle
        }

        private void btnGelirGider_Click(object sender, EventArgs e)
        {
            FRMGelirGiderTakibi gelirGiderForm = new FRMGelirGiderTakibi();
            FormGetir(gelirGiderForm);
        }

        private void btnRaporlama_Click(object sender, EventArgs e)
        {
            FRMRaporlama fRMRaporlama=new FRMRaporlama();
            FormGetir(fRMRaporlama);
            
        }
    }
}
