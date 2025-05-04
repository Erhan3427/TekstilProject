namespace Tekstile
{
    public partial class FRMGiris : Form
    {
        public FRMGiris()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMüsteriYonetim_Click(object sender, EventArgs e)
        {
            FRMMusteri musteriForm = new FRMMusteri();
            musteriForm.ShowDialog();
            this.Hide();
        }

        private void btnBoyaYonetim_Click(object sender, EventArgs e)
        {
            FRMBoya boyaForm = new FRMBoya();
            boyaForm.ShowDialog();
            this.Hide();

        }

        private void btnDesenYonetimi_Click(object sender, EventArgs e)
        {
            FRMDesenYonetimi desenYonetimiForm = new();
            desenYonetimiForm.ShowDialog();
            this.Hide();
        }
    }
}
