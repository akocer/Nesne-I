using Microsoft.VisualBasic;
namespace uyg21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Rectangle rect;
        bool tusbasili;
        Color seciliRenk = Color.FromArgb(100, Color.Red);
        int kalinlik = 2;
        Bitmap rsm;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.Text = "O:Open  C:Crop  S:Setting";
            rect = new Rectangle(0, 0, 200, 200);

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(seciliRenk), rect);
            e.Graphics.DrawRectangle(new Pen(new SolidBrush(seciliRenk), kalinlik), rect);
            e.Graphics.DrawString(rect.Width + " X " + rect.Height, new Font("Arial", 20, FontStyle.Regular), new SolidBrush(seciliRenk), rect.Location);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            tusbasili = true;
            rect = new Rectangle(e.Location, rect.Size);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            tusbasili = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (tusbasili)
            {
                rect = new Rectangle(e.Location, rect.Size);
                this.Invalidate();
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 'o' || e.KeyChar == 'O')
            {
                openFileDialog1.Filter = "Resim Dosyalarý|*.jpg";
                if (openFileDialog1.ShowDialog() ==
DialogResult.Cancel)
                {
                    return;
                }
                this.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
            }
            if (e.KeyChar == 'c' || e.KeyChar == 'C')
            {
                if (this.BackgroundImage == null)
                {
                    MessageBox.Show("Önce Resim açýnýz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Random r = new Random();
                saveFileDialog1.FileName = r.Next(999).ToString() + ".jpg";
                rsm = new Bitmap(this.BackgroundImage);
                Bitmap crop = rsm.Clone(rect, rsm.PixelFormat);
                crop.Save(saveFileDialog1.FileName);
                if (MessageBox.Show("Resim Croplandý Açýlsýn mý?", "Ýþlem Onayý", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                System.Diagnostics.Process p = new System.Diagnostics.Process();
                p.StartInfo.FileName = saveFileDialog1.FileName;
                p.StartInfo.UseShellExecute = true;
                p.Start();
            }
            if (e.KeyChar == 's' || e.KeyChar == 'S')
            {
                string gelen = Interaction.InputBox("Diktörtgen Boyutlarýn 100;100 þeklinde giriniz", "Ayarlar", "100;100");
                if (gelen.IndexOf(';') == -1)
                {
                    MessageBox.Show("Geçersiz Giriþ Tekrar Deneyiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string[] parcala = gelen.Split(';');
                rect = new Rectangle(MousePosition.X, MousePosition.Y, Convert.ToInt32(parcala[0]), Convert.ToInt32(parcala[1]));
            }

        }
    }
}