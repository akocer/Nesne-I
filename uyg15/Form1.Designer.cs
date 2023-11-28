namespace uyg15
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
            txtLink = new TextBox();
            btnTamam = new Button();
            lnkSonuc = new LinkLabel();
            SuspendLayout();
            // 
            // txtLink
            // 
            txtLink.Location = new Point(86, 106);
            txtLink.Name = "txtLink";
            txtLink.Size = new Size(394, 31);
            txtLink.TabIndex = 0;
            // 
            // btnTamam
            // 
            btnTamam.Location = new Point(524, 103);
            btnTamam.Name = "btnTamam";
            btnTamam.Size = new Size(189, 34);
            btnTamam.TabIndex = 1;
            btnTamam.Text = "Tamam";
            btnTamam.UseVisualStyleBackColor = true;
            btnTamam.Click += btnTamam_Click;
            // 
            // lnkSonuc
            // 
            lnkSonuc.AutoSize = true;
            lnkSonuc.Location = new Point(242, 224);
            lnkSonuc.Name = "lnkSonuc";
            lnkSonuc.Size = new Size(98, 25);
            lnkSonuc.TabIndex = 2;
            lnkSonuc.TabStop = true;
            lnkSonuc.Text = "linkLabel1";
            lnkSonuc.LinkClicked += lnkSonuc_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 450);
            Controls.Add(lnkSonuc);
            Controls.Add(btnTamam);
            Controls.Add(txtLink);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLink;
        private Button btnTamam;
        private LinkLabel lnkSonuc;
    }
}