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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.BackColor = Ayarlar.Default.ArkaPlanRengi;
            this.ForeColor = Ayarlar.Default.YaziRengi;
            this.Font = Ayarlar.Default.YaziFontu;
        }

        int t = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            t += 5;
            progressBar1.Value = t;
            lbYukle.Text = " Y Ü K L E N İ Y O R  %" + t.ToString();
            if (t >= 100)
            {
                timer1.Enabled = false;
                this.Hide();
                Form1 f1 = new Form1();
                f1.Show();
            }
        }
    }
}
