namespace uyg09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).Text = "Akdeniz";
                }
                if (c is Button)
                {
                    (c as Button).Text = "Temizle";
                }
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).Text = "";
                }
            }
        }
    }
}