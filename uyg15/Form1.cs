
using System.Diagnostics;

namespace uyg15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (txtLink.Text.Substring(0, 7) == "http://")
            {
                lnkSonuc.Text = txtLink.Text;
            }
            else
            {
                lnkSonuc.Text = "http://" + txtLink.Text;
            }
        }

        private void lnkSonuc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = lnkSonuc.Text;
            p.StartInfo.UseShellExecute = true;
            p.Start();
        }
    }
}