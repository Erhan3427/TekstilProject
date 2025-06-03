using Tekstile.Context;
using Tekstile.UI;

namespace Tekstile
{
    public partial class FRMGiris : Form
    {
        MyDbContext _context;
        FRMMusteri musteriForm;
        FRMBoya boyaForm;
        FRMDesenYonetimi desenYonetimiForm;


        public FRMGiris()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void FormGetir(Form form)
        {
            pnlYonetim.Controls.Clear();

            form.TopLevel = false; // ÖNEMLÝ: Form'un top-level olmadýðýný belirtiyoruz
            form.FormBorderStyle = FormBorderStyle.None;

            pnlYonetim.Controls.Add(form);
            pnlYonetim.Tag = form; // Form referansýný sakla

            form.Show();
            pnlYonetim.Dock = DockStyle.Fill;
        }

        private void btnMüsteriYonetim_Click(object sender, EventArgs e)
        {
            FRMMusteri musteriForm = new();
            FormGetir(musteriForm);

        }

        private void btnBoyaYonetim_Click(object sender, EventArgs e)
        {
            FRMBoya boyaForm = new FRMBoya();
            FormGetir(boyaForm);

        }

        private void btnDesenYonetimi_Click(object sender, EventArgs e)
        {
            FRMDesenYonetimi desenYonetimiForm = new FRMDesenYonetimi();
            FormGetir(desenYonetimiForm);
        }

        private void btnMakineYonetim_Click(object sender, EventArgs e)
        {
          FRMMakineYonetimi fRMMakineYonetim = new();
            FormGetir(fRMMakineYonetim);

        }

        private void btnSiparisYonetim_Click(object sender, EventArgs e)
        {
            FRMSiparisYonetimi fRMSiparisYonetimi = new ();
            FormGetir(fRMSiparisYonetimi);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çýkmak istediðinize emin misiniz?", "Uyarý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit(); //Uygulamadan çýkýþ yapar.

            }
        }
    }
}
