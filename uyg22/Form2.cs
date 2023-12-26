using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uyg22
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.BackColor = Ayarlar.Default.ArkaPlanRengi;
            this.ForeColor = Ayarlar.Default.YaziRengi;
            this.Font = Ayarlar.Default.YaziFontu;
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (txtKadi.Text == "akd" && txtParola.Text == "123")
            {
                Form3 f3 = new Form3();
                f3.Show();
                this.Hide();
            }
        }
    }
}
