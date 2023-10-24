namespace uyg06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int t = Convert.ToInt32(lbSayi.Text);
            t++;
            lbSayi.Text = t.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbSayi.Text = "0";
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        private void lbSayi_Click(object sender, EventArgs e)
        {

        }
    }
}