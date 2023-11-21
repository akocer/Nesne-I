namespace uyg11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYaz_Click(object sender, EventArgs e)
        {
            if (txtYazi.Text == "")
            {
                MessageBox.Show("Bir Deðer Giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string yazi = txtYazi.Text;
            string ters = "";

            for (int i = yazi.Length - 1; i >= 0; i--)
            {
                ters += yazi.Substring(i, 1);
            }


            txtTers.Text = ters;
        }
    }
}