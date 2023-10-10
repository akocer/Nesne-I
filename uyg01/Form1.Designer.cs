namespace uyg01
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
            label1 = new Label();
            label2 = new Label();
            txtDeger = new TextBox();
            btnHesapla = new Button();
            lbSonuc = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(242, 75);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(251, 38);
            label1.TabIndex = 0;
            label1.Text = "Daire Alan Hesabı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 172);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(168, 27);
            label2.TabIndex = 1;
            label2.Text = "Yarı Çap Giriniz";
            // 
            // txtDeger
            // 
            txtDeger.Location = new Point(351, 165);
            txtDeger.Margin = new Padding(4, 3, 4, 3);
            txtDeger.Name = "txtDeger";
            txtDeger.Size = new Size(109, 35);
            txtDeger.TabIndex = 2;
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(487, 162);
            btnHesapla.Margin = new Padding(4, 3, 4, 3);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(163, 37);
            btnHesapla.TabIndex = 3;
            btnHesapla.Text = "Hesapla";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // lbSonuc
            // 
            lbSonuc.AutoSize = true;
            lbSonuc.Location = new Point(177, 272);
            lbSonuc.Margin = new Padding(4, 0, 4, 0);
            lbSonuc.Name = "lbSonuc";
            lbSonuc.Size = new Size(71, 27);
            lbSonuc.TabIndex = 1;
            lbSonuc.Text = "Sonuç";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 382);
            Controls.Add(btnHesapla);
            Controls.Add(txtDeger);
            Controls.Add(lbSonuc);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtDeger;
        private Button btnHesapla;
        private Label lbSonuc;
    }
}