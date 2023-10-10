namespace uyg02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbListe.Items.Clear();
            lbListe.Items.Add("Ahmet");
            lbListe.Items.Add("Mehmet");


            for (int i = 0; i <= 10; i++)
            {
                lb1.Items.Add(i.ToString());
            }
            for (int i = 10; i > 0; i--)
            {
                lb2.Items.Add(i.ToString());
            }

            for (int i = 0; i < 100; i = i + 5)
            {
                lb3.Items.Add(i.ToString());
            }
            for (int i = 100; i > 0; i = i - 5)
            {
                lb4.Items.Add(i.ToString());
            }
        }
    }
}