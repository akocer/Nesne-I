namespace uyg11
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
            btnYaz = new Button();
            txtTers = new TextBox();
            SuspendLayout();
            // 
            // txtYazi
            // 
            txtYazi.Location = new Point(63, 44);
            txtYazi.Name = "txtYazi";
            txtYazi.Size = new Size(323, 31);
            txtYazi.TabIndex = 0;
            // 
            // btnYaz
            // 
            btnYaz.Location = new Point(125, 96);
            btnYaz.Name = "btnYaz";
            btnYaz.Size = new Size(197, 34);
            btnYaz.TabIndex = 1;
            btnYaz.Text = "Tersten Yaz";
            btnYaz.UseVisualStyleBackColor = true;
            btnYaz.Click += btnYaz_Click;
            // 
            // txtTers
            // 
            txtTers.Location = new Point(63, 158);
            txtTers.Name = "txtTers";
            txtTers.Size = new Size(323, 31);
            txtTers.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 302);
            Controls.Add(txtTers);
            Controls.Add(btnYaz);
            Controls.Add(txtYazi);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtYazi;
        private Button btnYaz;
        private TextBox txtTers;
    }
}