namespace uyg23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            pbResim.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void btnYatay_Click(object sender, EventArgs e)
        {
            if (pbResim.Image == null)
            {
                MessageBox.Show("Resim Seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Bitmap bm = new Bitmap(pbResim.Image);
            Bitmap ybm = new Bitmap(pbResim.Image);
            Color renk;
            for (int X = 0; X < bm.Width; X++)
            {
                for (int Y = 0; Y < bm.Height; Y++)
                {
                    renk = bm.GetPixel(X, Y);
                    ybm.SetPixel(X, bm.Height - 1 - Y, renk);
                }
            }


            pbSonuc.Image = ybm;
        }

        private void btnDikey_Click(object sender, EventArgs e)
        {
            if (pbResim.Image == null)
            {
                MessageBox.Show("Resim Seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Bitmap bm = new Bitmap(pbResim.Image);
            Bitmap ybm = new Bitmap(pbResim.Image);
            Color renk;
            for (int X = 0; X < bm.Width; X++)
            {
                for (int Y = 0; Y < bm.Height; Y++)
                {
                    renk = bm.GetPixel(X, Y);
                    ybm.SetPixel(bm.Width - X - 1, Y, renk);
                }
            }


            pbSonuc.Image = ybm;
        }

        private void btnGri_Click(object sender, EventArgs e)
        {
            if (pbResim.Image == null)
            {
                MessageBox.Show("Resim Seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Bitmap bm = new Bitmap(pbResim.Image);
            Bitmap ybm = new Bitmap(pbResim.Image);
            Color renk;
            for (int X = 0; X < bm.Width; X++)
            {
                for (int Y = 0; Y < bm.Height; Y++)
                {
                    renk = bm.GetPixel(X, Y);
                    int gri = (renk.R + renk.G + renk.B) / 3;
                    ybm.SetPixel(X, Y, Color.FromArgb(gri, gri, gri));
                }
            }


            pbSonuc.Image = ybm;
        }

        private void btnNegatif_Click(object sender, EventArgs e)
        {
            if (pbResim.Image == null)
            {
                MessageBox.Show("Resim Seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Bitmap bm = new Bitmap(pbResim.Image);
            Bitmap ybm = new Bitmap(pbResim.Image);
            Color renk;
            for (int X = 0; X < bm.Width; X++)
            {
                for (int Y = 0; Y < bm.Height; Y++)
                {
                    renk = bm.GetPixel(X, Y);
                    Color yRenk = Color.FromArgb(255 - renk.R, 255 - renk.G, 255 - renk.B);
                    ybm.SetPixel(X, Y, yRenk);
                }
            }


            pbSonuc.Image = ybm;
        }
    }
}