namespace uyg04
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
            txtDeger = new TextBox();
            btnEkle = new Button();
            lbListe = new ListBox();
            lbSonuc = new Label();
            btnTemizle = new Button();
            SuspendLayout();
            // 
            // txtDeger
            // 
            txtDeger.Location = new Point(95, 40);
            txtDeger.Name = "txtDeger";
            txtDeger.Size = new Size(404, 31);
            txtDeger.TabIndex = 0;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(95, 99);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(165, 54);
            btnEkle.TabIndex = 1;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // lbListe
            // 
            lbListe.FormattingEnabled = true;
            lbListe.ItemHeight = 25;
            lbListe.Location = new Point(95, 175);
            lbListe.Name = "lbListe";
            lbListe.Size = new Size(404, 354);
            lbListe.TabIndex = 2;
            // 
            // lbSonuc
            // 
            lbSonuc.AutoSize = true;
            lbSonuc.Location = new Point(148, 553);
            lbSonuc.Name = "lbSonuc";
            lbSonuc.Size = new Size(63, 25);
            lbSonuc.TabIndex = 3;
            lbSonuc.Text = "label1";
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(282, 99);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(217, 54);
            btnTemizle.TabIndex = 4;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 629);
            Controls.Add(btnTemizle);
            Controls.Add(lbSonuc);
            Controls.Add(lbListe);
            Controls.Add(btnEkle);
            Controls.Add(txtDeger);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDeger;
        private Button btnEkle;
        private ListBox lbListe;
        private Label lbSonuc;
        private Button btnTemizle;
    }
}