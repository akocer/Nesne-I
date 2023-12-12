using System.Text;

namespace uyg18
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
        private void btnAc_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "CSV Dosyalarý|*.csv";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
            sr = new StreamReader(fs);
            dgKayitlar.Rows.Clear();
            int i = 1;
            while ((satir = sr.ReadLine()) != null)
            {
                string[] parcala = satir.Split(';');

                dgKayitlar.Rows.Add(i, parcala[0], parcala[1], parcala[2], parcala[3]);
                i++;
            }

            sr.Close();
            fs.Close();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgKayitlar.RowCount; i++)
            {
                double v = Convert.ToDouble(dgKayitlar.Rows[i].Cells[3].Value.ToString());
                double f = Convert.ToDouble(dgKayitlar.Rows[i].Cells[4].Value.ToString());
                double ort = (v * 0.4) + (f * 0.6);
                dgKayitlar.Rows[i].Cells[5].Value = ort;
                if (ort < 60)
                {
                    dgKayitlar.Rows[i].Cells[6].Value = "Kaldý";
                    dgKayitlar.Rows[i].Cells[6].Style.BackColor = Color.Red;
                }
                else
                {
                    dgKayitlar.Rows[i].Cells[6].Value = "Geçti";
                    dgKayitlar.Rows[i].Cells[6].Style.BackColor = Color.Green;
                }
            }
        }



        private void btnKaydet_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "liste_sonhali.csv";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            fs = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write);
            sw = new StreamWriter(fs);
            for (int i = 0; i < dgKayitlar.RowCount; i++)
            {
                satir = "";
                for (int j = 1; j < dgKayitlar.ColumnCount; j++)
                {
                    satir += dgKayitlar.Rows[i].Cells[j].Value.ToString() + ";";
                }
                satir = satir.Substring(0, satir.Length - 1);
                sw.WriteLine(satir);
            }
            sw.Close();
            fs.Close();
            if (MessageBox.Show("Dosya Kaydedildi Açýlsýn mý?", "Ýþlem Tamam", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
            {
                return;
            }
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = saveFileDialog1.FileName;
            p.StartInfo.UseShellExecute = true;
            p.Start();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}