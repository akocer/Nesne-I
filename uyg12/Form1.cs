namespace uyg12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (rbBuyuk.Checked)
            {
                txtSonuc.Text = txtYazi.Text.ToUpper();
            }
            if (rbKucuk.Checked)
            {
                txtSonuc.Text = txtYazi.Text.ToLower();
            }
            if (rbBosluk.Checked)
            {
                txtSonuc.Text = txtYazi.Text.Trim();
            }
            if (rbUzunluk.Checked)
            {
                txtSonuc.Text = txtYazi.Text.Length.ToString();
            }
            if (rbHarf.Checked)
            {
                txtSonuc.Text = txtYazi.Text.Substring(0, 3);
            }
        }
    }
}