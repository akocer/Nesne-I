namespace uyg02
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
            lb1 = new ListBox();
            lb2 = new ListBox();
            lb3 = new ListBox();
            lb4 = new ListBox();
            SuspendLayout();
            // 
            // lbListe
            // 
            lbListe.FormattingEnabled = true;
            lbListe.ItemHeight = 15;
            lbListe.Items.AddRange(new object[] { "Ali", "Veli", "Sealmi", "Ayşe", "Fatma", "Hayriye" });
            lbListe.Location = new Point(17, 13);
            lbListe.Margin = new Padding(2, 2, 2, 2);
            lbListe.Name = "lbListe";
            lbListe.Size = new Size(133, 139);
            lbListe.TabIndex = 0;
            // 
            // lb1
            // 
            lb1.FormattingEnabled = true;
            lb1.ItemHeight = 15;
            lb1.Location = new Point(184, 13);
            lb1.Name = "lb1";
            lb1.Size = new Size(111, 139);
            lb1.TabIndex = 1;
            // 
            // lb2
            // 
            lb2.FormattingEnabled = true;
            lb2.ItemHeight = 15;
            lb2.Location = new Point(301, 13);
            lb2.Name = "lb2";
            lb2.Size = new Size(111, 139);
            lb2.TabIndex = 1;
            // 
            // lb3
            // 
            lb3.FormattingEnabled = true;
            lb3.ItemHeight = 15;
            lb3.Location = new Point(418, 13);
            lb3.Name = "lb3";
            lb3.Size = new Size(111, 139);
            lb3.TabIndex = 1;
            // 
            // lb4
            // 
            lb4.FormattingEnabled = true;
            lb4.ItemHeight = 15;
            lb4.Location = new Point(535, 12);
            lb4.Name = "lb4";
            lb4.Size = new Size(111, 139);
            lb4.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 229);
            Controls.Add(lb4);
            Controls.Add(lb3);
            Controls.Add(lb2);
            Controls.Add(lb1);
            Controls.Add(lbListe);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbListe;
        private ListBox lb1;
        private ListBox lb2;
        private ListBox lb3;
        private ListBox lb4;
    }
}