namespace uyg14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int r, g, b;
        private void hsR_Scroll(object sender, ScrollEventArgs e)
        {
            Islem();
        }

        private void hsG_Scroll(object sender, ScrollEventArgs e)
        {
            Islem();
        }

        private void hsB_Scroll(object sender, ScrollEventArgs e)
        {
            Islem();
        }


        public void Islem()
        {
            r = hsR.Value;
            g = hsG.Value;
            b = hsB.Value;
            txtR.Text = r.ToString();
            txtG.Text = g.ToString();
            txtB.Text = b.ToString();
            pnRenk.BackColor = Color.FromArgb(r, g, b);
            txtRGB.Text = "RGB(" + r.ToString() + "," + g.ToString() + "," + b.ToString() + ")";

            txtHexa.Text = "#" + HexaCevir(r) + HexaCevir(g) + HexaCevir(b);
        }

        private void btnRasgele_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            r = rastgele.Next(256);
            g = rastgele.Next(256);
            b = rastgele.Next(256);
            hsR.Value = r;
            hsG.Value = g;
            hsB.Value = b;
            txtR.Text = r.ToString();
            txtG.Text = g.ToString();
            txtB.Text = b.ToString();
            pnRenk.BackColor = Color.FromArgb(r, g, b);
            txtRGB.Text = "RGB(" + r.ToString() + "," + g.ToString() + "," + b.ToString() + ")";
            txtHexa.Text = "#" + HexaCevir(r) + HexaCevir(g) + HexaCevir(b);
        }

        public static string HexaCevir(int renk)
        {
            string h = "";

            string[] renkler = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
            int s1, s2;
            s1 = (int)renk / 16;
            s2 = renk - (s1 * 16);
            h = renkler[s1] + renkler[s2];
            return h;
        }
    }
}