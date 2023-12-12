namespace uyg16
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
            lbTarih = new Label();
            txtSayi = new TextBox();
            txtSonuc = new TextBox();
            btnEkle = new Button();
            rbGun = new RadioButton();
            rbAy = new RadioButton();
            rbYil = new RadioButton();
            btnKapat = new Button();
            SuspendLayout();
            // 
            // lbTarih
            // 
            lbTarih.AutoSize = true;
            lbTarih.ForeColor = Color.White;
            lbTarih.Location = new Point(102, 29);
            lbTarih.Name = "lbTarih";
            lbTarih.Size = new Size(63, 25);
            lbTarih.TabIndex = 0;
            lbTarih.Text = "label1";
            // 
            // txtSayi
            // 
            txtSayi.BorderStyle = BorderStyle.FixedSingle;
            txtSayi.Location = new Point(102, 100);
            txtSayi.Name = "txtSayi";
            txtSayi.Size = new Size(150, 31);
            txtSayi.TabIndex = 1;
            // 
            // txtSonuc
            // 
            txtSonuc.Location = new Point(102, 343);
            txtSonuc.Name = "txtSonuc";
            txtSonuc.Size = new Size(150, 31);
            txtSonuc.TabIndex = 1;
            // 
            // btnEkle
            // 
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.ForeColor = Color.White;
            btnEkle.Location = new Point(284, 97);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(112, 34);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // rbGun
            // 
            rbGun.AutoSize = true;
            rbGun.ForeColor = Color.White;
            rbGun.Location = new Point(102, 157);
            rbGun.Name = "rbGun";
            rbGun.Size = new Size(72, 29);
            rbGun.TabIndex = 3;
            rbGun.TabStop = true;
            rbGun.Text = "Gün";
            rbGun.UseVisualStyleBackColor = true;
            // 
            // rbAy
            // 
            rbAy.AutoSize = true;
            rbAy.ForeColor = Color.White;
            rbAy.Location = new Point(102, 205);
            rbAy.Name = "rbAy";
            rbAy.Size = new Size(60, 29);
            rbAy.TabIndex = 3;
            rbAy.TabStop = true;
            rbAy.Text = "Ay";
            rbAy.UseVisualStyleBackColor = true;
            // 
            // rbYil
            // 
            rbYil.AutoSize = true;
            rbYil.ForeColor = Color.White;
            rbYil.Location = new Point(102, 259);
            rbYil.Name = "rbYil";
            rbYil.Size = new Size(58, 29);
            rbYil.TabIndex = 3;
            rbYil.TabStop = true;
            rbYil.Text = "Yıl";
            rbYil.UseVisualStyleBackColor = true;
            // 
            // btnKapat
            // 
            btnKapat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnKapat.FlatStyle = FlatStyle.Flat;
            btnKapat.ForeColor = Color.White;
            btnKapat.Location = new Point(559, 440);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(112, 34);
            btnKapat.TabIndex = 4;
            btnKapat.Text = "Kapat";
            btnKapat.UseVisualStyleBackColor = true;
            btnKapat.Click += btnKapat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(721, 513);
            Controls.Add(btnKapat);
            Controls.Add(rbYil);
            Controls.Add(rbAy);
            Controls.Add(rbGun);
            Controls.Add(btnEkle);
            Controls.Add(txtSonuc);
            Controls.Add(txtSayi);
            Controls.Add(lbTarih);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTarih;
        private TextBox txtSayi;
        private TextBox txtSonuc;
        private Button btnEkle;
        private RadioButton rbGun;
        private RadioButton rbAy;
        private RadioButton rbYil;
        private Button btnKapat;
    }
}