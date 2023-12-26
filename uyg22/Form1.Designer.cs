namespace uyg22
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            btnArka = new Button();
            btnRenk = new Button();
            btnFont = new Button();
            colorDialog1 = new ColorDialog();
            fontDialog1 = new FontDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(57, 147);
            label1.Name = "label1";
            label1.Size = new Size(840, 234);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // btnArka
            // 
            btnArka.FlatStyle = FlatStyle.Flat;
            btnArka.Location = new Point(66, 54);
            btnArka.Name = "btnArka";
            btnArka.Size = new Size(246, 51);
            btnArka.TabIndex = 1;
            btnArka.Text = "Arka Plan Rengi Değiştir";
            btnArka.UseVisualStyleBackColor = true;
            btnArka.Click += btnArka_Click;
            // 
            // btnRenk
            // 
            btnRenk.FlatStyle = FlatStyle.Flat;
            btnRenk.Location = new Point(318, 54);
            btnRenk.Name = "btnRenk";
            btnRenk.Size = new Size(246, 51);
            btnRenk.TabIndex = 1;
            btnRenk.Text = "Yazı Rengi Değiştir";
            btnRenk.UseVisualStyleBackColor = true;
            btnRenk.Click += btnRenk_Click;
            // 
            // btnFont
            // 
            btnFont.FlatStyle = FlatStyle.Flat;
            btnFont.Location = new Point(570, 54);
            btnFont.Name = "btnFont";
            btnFont.Size = new Size(246, 51);
            btnFont.TabIndex = 1;
            btnFont.Text = "Yazı Fontu Değiştir";
            btnFont.UseVisualStyleBackColor = true;
            btnFont.Click += btnFont_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 589);
            Controls.Add(btnFont);
            Controls.Add(btnRenk);
            Controls.Add(btnArka);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnArka;
        private Button btnRenk;
        private Button btnFont;
        private ColorDialog colorDialog1;
        private FontDialog fontDialog1;
    }
}