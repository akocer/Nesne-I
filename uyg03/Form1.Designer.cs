namespace uyg03
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbListe1 = new ListBox();
            btnEkle = new Button();
            btnCikar = new Button();
            btnTumunuEkle = new Button();
            btnKapat = new Button();
            btnTumunuCikar = new Button();
            lbListe2 = new ListBox();
            SuspendLayout();
            // 
            // lbListe1
            // 
            lbListe1.FormattingEnabled = true;
            lbListe1.ItemHeight = 25;
            lbListe1.Items.AddRange(new object[] { "Nesne", "Arazi", "Çizim", "Harita", "Grafik" });
            lbListe1.Location = new Point(83, 30);
            lbListe1.Name = "lbListe1";
            lbListe1.Size = new Size(254, 304);
            lbListe1.TabIndex = 0;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(370, 30);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(191, 57);
            btnEkle.TabIndex = 1;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnCikar
            // 
            btnCikar.Location = new Point(370, 93);
            btnCikar.Name = "btnCikar";
            btnCikar.Size = new Size(191, 57);
            btnCikar.TabIndex = 1;
            btnCikar.Text = "Çıkar";
            btnCikar.UseVisualStyleBackColor = true;
            btnCikar.Click += btnCikar_Click;
            // 
            // btnTumunuEkle
            // 
            btnTumunuEkle.Location = new Point(370, 156);
            btnTumunuEkle.Name = "btnTumunuEkle";
            btnTumunuEkle.Size = new Size(191, 57);
            btnTumunuEkle.TabIndex = 1;
            btnTumunuEkle.Text = "Tümünü Ekle";
            btnTumunuEkle.UseVisualStyleBackColor = true;
            btnTumunuEkle.Click += btnTumunuEkle_Click;
            // 
            // btnKapat
            // 
            btnKapat.Location = new Point(370, 282);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(191, 57);
            btnKapat.TabIndex = 2;
            btnKapat.Text = "Kapat";
            btnKapat.UseVisualStyleBackColor = true;
            btnKapat.Click += btnKapat_Click;
            // 
            // btnTumunuCikar
            // 
            btnTumunuCikar.Location = new Point(370, 219);
            btnTumunuCikar.Name = "btnTumunuCikar";
            btnTumunuCikar.Size = new Size(191, 57);
            btnTumunuCikar.TabIndex = 3;
            btnTumunuCikar.Text = "Tümünü Çıkar";
            btnTumunuCikar.UseVisualStyleBackColor = true;
            btnTumunuCikar.Click += btnTumunuCikar_Click;
            // 
            // lbListe2
            // 
            lbListe2.FormattingEnabled = true;
            lbListe2.ItemHeight = 25;
            lbListe2.Location = new Point(601, 35);
            lbListe2.Name = "lbListe2";
            lbListe2.Size = new Size(254, 304);
            lbListe2.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 435);
            Controls.Add(btnKapat);
            Controls.Add(btnTumunuCikar);
            Controls.Add(btnTumunuEkle);
            Controls.Add(btnCikar);
            Controls.Add(btnEkle);
            Controls.Add(lbListe2);
            Controls.Add(lbListe1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbListe1;
        private Button btnEkle;
        private Button btnCikar;
        private Button btnTumunuEkle;
        private Button btnKapat;
        private Button btnTumunuCikar;
        private ListBox lbListe2;
    }
}