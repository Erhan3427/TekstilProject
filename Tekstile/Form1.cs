namespace Tekstile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMüsteriYonetim_Click(object sender, EventArgs e)
        {
            FormMusteri musteriForm = new FormMusteri();
            musteriForm.ShowDialog();
            this.Hide();
        }

        private void btnBoyaYonetim_Click(object sender, EventArgs e)
        {
            FormBoya boyaForm = new FormBoya();
            boyaForm.ShowDialog();
            this.Hide();

        }
    }
}
