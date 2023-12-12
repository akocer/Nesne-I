namespace uyg16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //  lbTarih.Text = DateTime.Now.ToString();
            lbTarih.Text = DateTime.Now.ToShortDateString();
            //lbTarih.Text = DateTime.Now.ToLongDateString();
            // lbTarih.Text = DateTime.Now.ToLongTimeString();
            //lbTarih.Text = DateTime.Now.ToShortTimeString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            DateTime t, y;
            t = Convert.ToDateTime(lbTarih.Text);
            y = t;

            if (rbGun.Checked)
            {
                y = t.AddDays(Convert.ToDouble(txtSayi.Text));
            }
            if (rbAy.Checked)
            {
                y = t.AddMonths(Convert.ToInt32(txtSayi.Text));
            }
            if (rbYil.Checked)
            {
                y = t.AddYears(Convert.ToInt32(txtSayi.Text));
            }
            txtSonuc.Text = y.ToShortDateString();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}