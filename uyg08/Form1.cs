namespace uyg08
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
            Random rasgele = new Random();
            int r = rasgele.Next(256);
            int g = rasgele.Next(256);
            int b = rasgele.Next(256);

            this.BackColor = Color.FromArgb(r, g, b);
            lbSayi.Text = "R:" + r.ToString() + " G:" + g.ToString() + " B:" + b.ToString();
        }
    }
}