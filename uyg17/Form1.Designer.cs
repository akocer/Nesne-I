namespace uyg17
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
            btnOku = new Button();
            btnYaz = new Button();
            txtYazi = new TextBox();
            SuspendLayout();
            // 
            // btnOku
            // 
            btnOku.Location = new Point(13, 12);
            btnOku.Name = "btnOku";
            btnOku.Size = new Size(392, 78);
            btnOku.TabIndex = 0;
            btnOku.Text = "Texten Oku";
            btnOku.UseVisualStyleBackColor = true;
            btnOku.Click += btnOku_Click;
            // 
            // btnYaz
            // 
            btnYaz.Location = new Point(411, 12);
            btnYaz.Name = "btnYaz";
            btnYaz.Size = new Size(392, 78);
            btnYaz.TabIndex = 0;
            btnYaz.Text = "Texte Yaz";
            btnYaz.UseVisualStyleBackColor = true;
            btnYaz.Click += btnYaz_Click;
            // 
            // txtYazi
            // 
            txtYazi.Location = new Point(13, 102);
            txtYazi.Multiline = true;
            txtYazi.Name = "txtYazi";
            txtYazi.ScrollBars = ScrollBars.Vertical;
            txtYazi.Size = new Size(789, 389);
            txtYazi.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 511);
            Controls.Add(txtYazi);
            Controls.Add(btnYaz);
            Controls.Add(btnOku);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOku;
        private Button btnYaz;
        private TextBox txtYazi;
    }
}