namespace uyg01
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

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            const double pi = 3.14;
            double r = Convert.ToDouble(txtDeger.Text);
            double alan = pi * r * r;
            lbSonuc.Text = "Yarý Çapý " + r.ToString() + " olan Dairenin Alaný :" + alan.ToString();
        }
    }
}