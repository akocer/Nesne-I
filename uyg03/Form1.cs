namespace uyg03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {


            if (lbListe1.SelectedIndex == -1)
            {
                MessageBox.Show("Bir Ders Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lbListe2.Items.Add(lbListe1.SelectedItem);
            lbListe1.Items.RemoveAt(lbListe1.SelectedIndex);
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            if (lbListe2.SelectedIndex == -1)
            {
                MessageBox.Show("Ders Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lbListe1.Items.Add(lbListe2.SelectedItem);
            lbListe2.Items.RemoveAt(lbListe2.SelectedIndex);
        }

        private void btnTumunuEkle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbListe1.Items.Count; i++)
            {
                lbListe2.Items.Add(lbListe1.Items[i].ToString());
            }
            lbListe1.Items.Clear();
        }

        private void btnTumunuCikar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbListe2.Items.Count; i++)
            {
                lbListe1.Items.Add(lbListe2.Items[i].ToString());
            }
            lbListe2.Items.Clear();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}