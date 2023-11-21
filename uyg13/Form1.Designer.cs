namespace uyg13
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
            lbListe = new ListBox();
            lbSonuc = new Label();
            SuspendLayout();
            // 
            // lbListe
            // 
            lbListe.FormattingEnabled = true;
            lbListe.ItemHeight = 25;
            lbListe.Location = new Point(187, 30);
            lbListe.Name = "lbListe";
            lbListe.Size = new Size(267, 304);
            lbListe.TabIndex = 0;
            // 
            // lbSonuc
            // 
            lbSonuc.AutoSize = true;
            lbSonuc.Location = new Point(187, 381);
            lbSonuc.Name = "lbSonuc";
            lbSonuc.Size = new Size(63, 25);
            lbSonuc.TabIndex = 1;
            lbSonuc.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 477);
            Controls.Add(lbSonuc);
            Controls.Add(lbListe);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbListe;
        private Label lbSonuc;
    }
}