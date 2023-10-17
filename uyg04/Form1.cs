namespace uyg04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtDeger.Text == "")
            {
                MessageBox.Show("Bir Deðer Giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < lbListe.Items.Count; i++)
            {
                if (lbListe.Items[i].ToString() == txtDeger.Text)
                {
                    MessageBox.Show("Girilen Deðer Listede Mevcuttur!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            lbListe.Items.Add(txtDeger.Text);
            txtDeger.Text = "";
            lbSonuc.Text = "Kayýt Sayýsý : " + lbListe.Items.Count.ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lbListe.Items.Clear();
            lbSonuc.Text = "Kayýt Sayýsý : " + lbListe.Items.Count.ToString();
        }
    }
}