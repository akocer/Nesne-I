namespace uyg10b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(btnKaydet, "Kaydet");
            tt.SetToolTip(btnDuzenle, "D�zenle");
            tt.SetToolTip(btnSil, "Sil");
            tt.SetToolTip(btnListe, "Liste");
            tt.SetToolTip(btnCikis, "��k��");
        }

        private void yenA�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Men� T�kland�");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tslSaat.Text = DateTime.Now.ToString();
        }
    }
}