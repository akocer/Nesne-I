using System.Text.RegularExpressions;

namespace uyg22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Ayarlar.Default.ArkaPlanRengi;
            this.ForeColor = Ayarlar.Default.YaziRengi;
            this.Font = Ayarlar.Default.YaziFontu;
        }

        private void btnArka_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            this.BackColor = colorDialog1.Color;
            Ayarlar.Default.ArkaPlanRengi = colorDialog1.Color;
            Ayarlar.Default.Save();
        }

        private void btnRenk_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            this.ForeColor = colorDialog1.Color;
            Ayarlar.Default.YaziRengi = colorDialog1.Color;
            Ayarlar.Default.Save();
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            this.Font = fontDialog1.Font;
            Ayarlar.Default.YaziFontu = fontDialog1.Font;
            Ayarlar.Default.Save();
        }
    }
}