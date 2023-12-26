namespace uyg23
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
            pbResim = new PictureBox();
            pbSonuc = new PictureBox();
            btnAc = new Button();
            btnYatay = new Button();
            btnDikey = new Button();
            btnGri = new Button();
            btnNegatif = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbResim).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSonuc).BeginInit();
            SuspendLayout();
            // 
            // pbResim
            // 
            pbResim.Location = new Point(12, 96);
            pbResim.Name = "pbResim";
            pbResim.Size = new Size(552, 318);
            pbResim.SizeMode = PictureBoxSizeMode.StretchImage;
            pbResim.TabIndex = 0;
            pbResim.TabStop = false;
            // 
            // pbSonuc
            // 
            pbSonuc.Location = new Point(773, 96);
            pbSonuc.Name = "pbSonuc";
            pbSonuc.Size = new Size(552, 318);
            pbSonuc.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSonuc.TabIndex = 0;
            pbSonuc.TabStop = false;
            // 
            // btnAc
            // 
            btnAc.Location = new Point(12, 47);
            btnAc.Name = "btnAc";
            btnAc.Size = new Size(112, 34);
            btnAc.TabIndex = 1;
            btnAc.Text = "Resim Aç";
            btnAc.UseVisualStyleBackColor = true;
            btnAc.Click += btnAc_Click;
            // 
            // btnYatay
            // 
            btnYatay.Location = new Point(589, 117);
            btnYatay.Name = "btnYatay";
            btnYatay.Size = new Size(166, 34);
            btnYatay.TabIndex = 1;
            btnYatay.Text = "Yatay Aynala";
            btnYatay.UseVisualStyleBackColor = true;
            btnYatay.Click += btnYatay_Click;
            // 
            // btnDikey
            // 
            btnDikey.Location = new Point(589, 157);
            btnDikey.Name = "btnDikey";
            btnDikey.Size = new Size(166, 34);
            btnDikey.TabIndex = 1;
            btnDikey.Text = "Dikey Aynala";
            btnDikey.UseVisualStyleBackColor = true;
            btnDikey.Click += btnDikey_Click;
            // 
            // btnGri
            // 
            btnGri.Location = new Point(589, 197);
            btnGri.Name = "btnGri";
            btnGri.Size = new Size(166, 34);
            btnGri.TabIndex = 1;
            btnGri.Text = "Gri Fon";
            btnGri.UseVisualStyleBackColor = true;
            btnGri.Click += btnGri_Click;
            // 
            // btnNegatif
            // 
            btnNegatif.Location = new Point(589, 237);
            btnNegatif.Name = "btnNegatif";
            btnNegatif.Size = new Size(166, 34);
            btnNegatif.TabIndex = 1;
            btnNegatif.Text = "Negatif";
            btnNegatif.UseVisualStyleBackColor = true;
            btnNegatif.Click += btnNegatif_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 616);
            Controls.Add(btnNegatif);
            Controls.Add(btnGri);
            Controls.Add(btnDikey);
            Controls.Add(btnYatay);
            Controls.Add(btnAc);
            Controls.Add(pbSonuc);
            Controls.Add(pbResim);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbResim).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSonuc).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbResim;
        private PictureBox pbSonuc;
        private Button btnAc;
        private Button btnYatay;
        private Button btnDikey;
        private Button btnGri;
        private Button btnNegatif;
        private OpenFileDialog openFileDialog1;
    }
}