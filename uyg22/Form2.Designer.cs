namespace uyg22
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtKadi = new TextBox();
            txtParola = new TextBox();
            label2 = new Label();
            btnTamam = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 60);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı";
            // 
            // txtKadi
            // 
            txtKadi.Location = new Point(199, 54);
            txtKadi.Name = "txtKadi";
            txtKadi.Size = new Size(150, 31);
            txtKadi.TabIndex = 1;
            // 
            // txtParola
            // 
            txtParola.Location = new Point(199, 91);
            txtParola.Name = "txtParola";
            txtParola.PasswordChar = '*';
            txtParola.Size = new Size(150, 31);
            txtParola.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 97);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 2;
            label2.Text = "Parola";
            // 
            // btnTamam
            // 
            btnTamam.FlatStyle = FlatStyle.Flat;
            btnTamam.Location = new Point(197, 142);
            btnTamam.Name = "btnTamam";
            btnTamam.Size = new Size(152, 34);
            btnTamam.TabIndex = 4;
            btnTamam.Text = "Tamam";
            btnTamam.UseVisualStyleBackColor = true;
            btnTamam.Click += btnTamam_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 295);
            Controls.Add(btnTamam);
            Controls.Add(txtParola);
            Controls.Add(label2);
            Controls.Add(txtKadi);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtKadi;
        private TextBox txtParola;
        private Label label2;
        private Button btnTamam;
    }
}