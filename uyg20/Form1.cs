namespace uyg20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Point nokta = new Point();
        int x, y;
        double t;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                nokta = Control.MousePosition;
                nokta.X = nokta.X - x;
                nokta.Y = nokta.Y - y;
                this.Location = nokta;
            }
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x = Control.MousePosition.X - this.Location.X;
            y = Control.MousePosition.Y - this.Location.Y;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            double s = trackBar1.Value;
            this.Opacity = s / 10;
        }



        private void btnKapat_Click(object sender, EventArgs e)
        {
            t = 10;
            timer1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            t--;
            this.Opacity = t / 10;
            if (t <= 0)
            {
                Application.Exit();
            }
        }
    }
}