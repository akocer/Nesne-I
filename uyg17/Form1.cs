using System.IO;
using System.Text;

namespace uyg17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FileStream fs;
        StreamReader sr;
        StreamWriter sw;
        string satir;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnYaz_Click(object sender, EventArgs e)
        {
            if (txtYazi.Text == "")
            {
                MessageBox.Show("Bir Deðer Giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            fs = new FileStream(Application.StartupPath + "/veri.txt", FileMode.Create, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(txtYazi.Text);

            sw.Close();
            fs.Close();

            MessageBox.Show("Text Dosya Veri Yazýldý...", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnOku_Click(object sender, EventArgs e)
        {
            fs = new FileStream(Application.StartupPath + "/veri.txt", FileMode.Open, FileAccess.Read);
            sr = new StreamReader(fs);
            txtYazi.Text = "";
            while ((satir = sr.ReadLine()) != null)
            {
                txtYazi.Text += satir + Environment.NewLine;
            }

            sr.Close();
            fs.Close();
        }
    }
}