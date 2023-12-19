namespace uyg19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                dgKayitlar.Rows.Add(i, "Kiþi " + i, "kisi@mail.com");
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAdsoyad.Text == "" || txtOgrNo.Text == "" || txtMail.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanlarý Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dgKayitlar.Rows.Add(txtOgrNo.Text, txtAdsoyad.Text, txtMail.Text);
            MessageBox.Show("Kayýt Eklendi", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgKayitlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgKayitlar.CurrentRow.Index.ToString();
            txtOgrNo.Text = dgKayitlar.CurrentRow.Cells[0].Value.ToString();
            txtAdsoyad.Text = dgKayitlar.CurrentRow.Cells[1].Value.ToString();
            txtMail.Text = dgKayitlar.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Lütfen Kayýt Seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int kayitId = Convert.ToInt32(txtId.Text);
            dgKayitlar.Rows[kayitId].Cells[0].Value = txtOgrNo.Text;
            dgKayitlar.Rows[kayitId].Cells[1].Value = txtAdsoyad.Text;
            dgKayitlar.Rows[kayitId].Cells[2].Value = txtMail.Text;

            MessageBox.Show("Kayýt Güncellendi", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Lütfen Kayýt Seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int kayitId = Convert.ToInt32(txtId.Text);
            dgKayitlar.Rows.RemoveAt(kayitId);

            MessageBox.Show("Kayýt Silindi", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
