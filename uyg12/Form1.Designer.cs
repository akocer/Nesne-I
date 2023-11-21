namespace uyg12
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
            txtYazi = new TextBox();
            rbBuyuk = new RadioButton();
            rbKucuk = new RadioButton();
            rbUzunluk = new RadioButton();
            rbBosluk = new RadioButton();
            rbHarf = new RadioButton();
            btnTamam = new Button();
            txtSonuc = new TextBox();
            SuspendLayout();
            // 
            // txtYazi
            // 
            txtYazi.Location = new Point(98, 38);
            txtYazi.Name = "txtYazi";
            txtYazi.Size = new Size(355, 31);
            txtYazi.TabIndex = 1;
            // 
            // rbBuyuk
            // 
            rbBuyuk.AutoSize = true;
            rbBuyuk.Location = new Point(141, 87);
            rbBuyuk.Name = "rbBuyuk";
            rbBuyuk.Size = new Size(134, 29);
            rbBuyuk.TabIndex = 2;
            rbBuyuk.TabStop = true;
            rbBuyuk.Text = "Büyük Harf";
            rbBuyuk.UseVisualStyleBackColor = true;
            // 
            // rbKucuk
            // 
            rbKucuk.AutoSize = true;
            rbKucuk.Location = new Point(141, 122);
            rbKucuk.Name = "rbKucuk";
            rbKucuk.Size = new Size(133, 29);
            rbKucuk.TabIndex = 2;
            rbKucuk.TabStop = true;
            rbKucuk.Text = "Küçük Harf";
            rbKucuk.UseVisualStyleBackColor = true;
            // 
            // rbUzunluk
            // 
            rbUzunluk.AutoSize = true;
            rbUzunluk.Location = new Point(141, 192);
            rbUzunluk.Name = "rbUzunluk";
            rbUzunluk.Size = new Size(107, 29);
            rbUzunluk.TabIndex = 3;
            rbUzunluk.TabStop = true;
            rbUzunluk.Text = "Uzunluk";
            rbUzunluk.UseVisualStyleBackColor = true;
            // 
            // rbBosluk
            // 
            rbBosluk.AutoSize = true;
            rbBosluk.Location = new Point(141, 157);
            rbBosluk.Name = "rbBosluk";
            rbBosluk.Size = new Size(184, 29);
            rbBosluk.TabIndex = 4;
            rbBosluk.TabStop = true;
            rbBosluk.Text = "Sağ Sol Boşluk Al";
            rbBosluk.UseVisualStyleBackColor = true;
            // 
            // rbHarf
            // 
            rbHarf.AutoSize = true;
            rbHarf.Location = new Point(141, 227);
            rbHarf.Name = "rbHarf";
            rbHarf.Size = new Size(168, 29);
            rbHarf.TabIndex = 3;
            rbHarf.TabStop = true;
            rbHarf.Text = "İlk Üç Karakteri";
            rbHarf.UseVisualStyleBackColor = true;
            // 
            // btnTamam
            // 
            btnTamam.Location = new Point(141, 274);
            btnTamam.Name = "btnTamam";
            btnTamam.Size = new Size(193, 34);
            btnTamam.TabIndex = 5;
            btnTamam.Text = "Tamam";
            btnTamam.UseVisualStyleBackColor = true;
            btnTamam.Click += btnTamam_Click;
            // 
            // txtSonuc
            // 
            txtSonuc.Location = new Point(98, 331);
            txtSonuc.Name = "txtSonuc";
            txtSonuc.Size = new Size(355, 31);
            txtSonuc.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 397);
            Controls.Add(txtSonuc);
            Controls.Add(btnTamam);
            Controls.Add(rbHarf);
            Controls.Add(rbUzunluk);
            Controls.Add(rbBosluk);
            Controls.Add(rbKucuk);
            Controls.Add(rbBuyuk);
            Controls.Add(txtYazi);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtYazi;
        private RadioButton rbBuyuk;
        private RadioButton rbKucuk;
        private RadioButton rbUzunluk;
        private RadioButton rbBosluk;
        private RadioButton rbHarf;
        private Button btnTamam;
        private TextBox txtSonuc;
    }
}