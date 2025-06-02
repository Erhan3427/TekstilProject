using Tekstile.Context;

namespace Tekstile
{
    public partial class FRMGiris : Form
    {
        MyDbContext _context;
        FRMMusteri musteriForm;
        FRMBoya boyaForm;
        FRMDesenYonetimi desenYonetimiForm;

        public FRMGiris(FRMMusteri frmMusteri,FRMBoya frmBoya,FRMDesenYonetimi frmDesen)
        {
            InitializeComponent();
            musteriForm = frmMusteri;
            boyaForm = frmBoya;
            desenYonetimiForm = frmDesen;
        }
        public FRMGiris()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMüsteriYonetim_Click(object sender, EventArgs e)
        {
            musteriForm.ShowDialog();
            this.Hide();
        }

        private void btnBoyaYonetim_Click(object sender, EventArgs e)
        {
            boyaForm.ShowDialog();
            this.Hide();

        }

        private void btnDesenYonetimi_Click(object sender, EventArgs e)
        {
            desenYonetimiForm.ShowDialog();
            this.Hide();
        }
    }
}
