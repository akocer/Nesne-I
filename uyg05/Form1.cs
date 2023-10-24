namespace uyg05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTumSec_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbListe.Items.Count; i++)
            {
                clbListe.SetItemCheckState(i, CheckState.Checked);
            }
        }

        private void btnTumBirak_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbListe.Items.Count; i++)
            {
                clbListe.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            lbListe.Items.Clear();
            for (int i = 0; i < clbListe.Items.Count; i++)
            {
                if (clbListe.GetItemCheckState(i) == CheckState.Checked)
                {
                    lbListe.Items.Add(clbListe.Items[i].ToString());
                }
            }

        }
    }
}