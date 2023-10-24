namespace uyg05
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
            clbListe = new CheckedListBox();
            lbListe = new ListBox();
            btnTumSec = new Button();
            btnTumBirak = new Button();
            btnEkle = new Button();
            SuspendLayout();
            // 
            // clbListe
            // 
            clbListe.FormattingEnabled = true;
            clbListe.Items.AddRange(new object[] { "Nesne", "Harita", "Çizim", "Grafik", "Arazi", "Fizik" });
            clbListe.Location = new Point(44, 24);
            clbListe.Name = "clbListe";
            clbListe.Size = new Size(234, 200);
            clbListe.TabIndex = 0;
            // 
            // lbListe
            // 
            lbListe.FormattingEnabled = true;
            lbListe.ItemHeight = 25;
            lbListe.Location = new Point(311, 20);
            lbListe.Name = "lbListe";
            lbListe.Size = new Size(234, 204);
            lbListe.TabIndex = 1;
            // 
            // btnTumSec
            // 
            btnTumSec.Location = new Point(44, 240);
            btnTumSec.Name = "btnTumSec";
            btnTumSec.Size = new Size(234, 49);
            btnTumSec.TabIndex = 2;
            btnTumSec.Text = "Tümünü Seç";
            btnTumSec.UseVisualStyleBackColor = true;
            btnTumSec.Click += btnTumSec_Click;
            // 
            // btnTumBirak
            // 
            btnTumBirak.Location = new Point(44, 295);
            btnTumBirak.Name = "btnTumBirak";
            btnTumBirak.Size = new Size(234, 49);
            btnTumBirak.TabIndex = 2;
            btnTumBirak.Text = "Tümünü Bırak";
            btnTumBirak.UseVisualStyleBackColor = true;
            btnTumBirak.Click += btnTumBirak_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(311, 240);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(234, 104);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "Seçili Olanları Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 378);
            Controls.Add(btnEkle);
            Controls.Add(btnTumBirak);
            Controls.Add(btnTumSec);
            Controls.Add(lbListe);
            Controls.Add(clbListe);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox clbListe;
        private ListBox lbListe;
        private Button btnTumSec;
        private Button btnTumBirak;
        private Button btnEkle;
    }
}