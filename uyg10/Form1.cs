namespace uyg10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int s = 10;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            lbSure.Text = "10";

            foreach (var c in this.Controls)
            {
                if (c is CheckBox)
                {
                    (c as CheckBox).Enabled = false;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s--;
            lbSure.Text = s.ToString();
            int d = 0;
            if (s <= 0)
            {
                timer1.Enabled = false;
                foreach (var c in this.Controls)
                {
                    if (c is CheckBox)
                    {
                        (c as CheckBox).Enabled = false;
                        if ((c as CheckBox).Checked)
                        {
                            d++;
                        }
                    }
                }
                lbSonuc.Text = d.ToString() + " Adet Ýþaretlendi...";
            }
            if (s <= 3)
            {
                lbSure.ForeColor = Color.Red;
            }
            else
            {
                lbSure.ForeColor = Color.Black;
            }
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            foreach (var c in this.Controls)
            {
                if (c is CheckBox)
                {
                    (c as CheckBox).Enabled = true;
                    (c as CheckBox).Checked = false;
                }
            }
            lbSure.Text = "10";
            lbSure.ForeColor = Color.Black;
            timer1.Enabled = true;
            s = 10;
        }
    }
}
