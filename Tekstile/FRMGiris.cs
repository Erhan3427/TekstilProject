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
            form.MdiParent = this; //this form(içinde bulunduðumuz form), ana formdur. parametreden aldýðýmýz form, ana formun alt formudur.
            form.FormBorderStyle = FormBorderStyle.None; //hareket etmesini engelledik
            pnlYonetim.Controls.Add(form);  //Çaðýrdýðýmýz formu pnlIcerik adýndaki panele ekledik.
            form.Show(); //Çaðýrdýðýmýz formu göster dedik.
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
          FRMMakineYonetim fRMMakineYonetim = new FRMMakineYonetim();
            FormGetir(fRMMakineYonetim);

        }

        private void btnSiparisYonetim_Click(object sender, EventArgs e)
        {

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
