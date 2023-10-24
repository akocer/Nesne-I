namespace uyg07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbSayi.Text = "0";
            timer1.Interval = 100;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            int s = r.Next(10, 20);
            lbSayi.Text = s.ToString();
        }
    }
}