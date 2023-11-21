namespace uyg13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] gunler1 = new string[7];
            gunler1[0] = "Pazartesi";
            gunler1[1] = "Salý";
            gunler1[2] = "Çarþamba";
            gunler1[3] = "Perþembe";
            gunler1[4] = "Cuma";
            gunler1[5] = "Cumartesi";
            gunler1[6] = "Pazar";
            //  MessageBox.Show(gunler1[3]);


            string[] gunler2 = new string[] { "Pazartesi", "Salý", "Çarþamba", "Perþembe", "Cuma", "Cumartesi", "Pazar" };

            // MessageBox.Show(gunler2[3]);

            int[] sayilar1 = new int[] { 11, 17, 5, 46, 7, 68, 34 };
            // MessageBox.Show(sayilar1[3].ToString());

            double[] sayilar2 = new double[] { 1.1, 1.7, 7, 3.5, 4.6, 7, 68, 34 };
            //MessageBox.Show(sayilar2[3].ToString());


            for (int i = 0; i < sayilar2.Length; i++)
            {
                lbListe.Items.Add(sayilar2[i].ToString());
            }
            lbSonuc.Text = "Listedeki Eleman Sayýsý : " + sayilar2.Length.ToString();

            foreach (var sayi in sayilar2)
            {
                lbListe.Items.Add(sayi.ToString());
            }
        }
    }
}