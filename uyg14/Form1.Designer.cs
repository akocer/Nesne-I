namespace uyg14
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
            hsR = new HScrollBar();
            pnRenk = new Panel();
            hsG = new HScrollBar();
            hsB = new HScrollBar();
            txtR = new TextBox();
            txtG = new TextBox();
            txtB = new TextBox();
            txtRGB = new TextBox();
            txtHexa = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnRasgele = new Button();
            SuspendLayout();
            // 
            // hsR
            // 
            hsR.LargeChange = 1;
            hsR.Location = new Point(143, 89);
            hsR.Maximum = 255;
            hsR.Name = "hsR";
            hsR.Size = new Size(492, 39);
            hsR.TabIndex = 0;
            hsR.Scroll += hsR_Scroll;
            // 
            // pnRenk
            // 
            pnRenk.Location = new Point(674, 89);
            pnRenk.Name = "pnRenk";
            pnRenk.Size = new Size(271, 255);
            pnRenk.TabIndex = 1;
            // 
            // hsG
            // 
            hsG.LargeChange = 1;
            hsG.Location = new Point(143, 145);
            hsG.Maximum = 255;
            hsG.Name = "hsG";
            hsG.Size = new Size(492, 39);
            hsG.TabIndex = 0;
            hsG.Scroll += hsG_Scroll;
            // 
            // hsB
            // 
            hsB.LargeChange = 1;
            hsB.Location = new Point(143, 199);
            hsB.Maximum = 255;
            hsB.Name = "hsB";
            hsB.Size = new Size(492, 39);
            hsB.TabIndex = 0;
            hsB.Scroll += hsB_Scroll;
            // 
            // txtR
            // 
            txtR.BackColor = Color.Red;
            txtR.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtR.ForeColor = Color.White;
            txtR.Location = new Point(33, 89);
            txtR.Name = "txtR";
            txtR.Size = new Size(94, 45);
            txtR.TabIndex = 2;
            txtR.TextAlign = HorizontalAlignment.Center;
            // 
            // txtG
            // 
            txtG.BackColor = Color.Green;
            txtG.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtG.ForeColor = Color.White;
            txtG.Location = new Point(33, 145);
            txtG.Name = "txtG";
            txtG.Size = new Size(94, 45);
            txtG.TabIndex = 2;
            txtG.TextAlign = HorizontalAlignment.Center;
            // 
            // txtB
            // 
            txtB.BackColor = Color.Blue;
            txtB.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtB.ForeColor = Color.White;
            txtB.Location = new Point(33, 199);
            txtB.Name = "txtB";
            txtB.Size = new Size(94, 45);
            txtB.TabIndex = 2;
            txtB.TextAlign = HorizontalAlignment.Center;
            // 
            // txtRGB
            // 
            txtRGB.Location = new Point(143, 288);
            txtRGB.Name = "txtRGB";
            txtRGB.Size = new Size(241, 31);
            txtRGB.TabIndex = 2;
            // 
            // txtHexa
            // 
            txtHexa.Location = new Point(143, 342);
            txtHexa.Name = "txtHexa";
            txtHexa.Size = new Size(241, 31);
            txtHexa.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 348);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 3;
            label1.Text = "Hexa Kodu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 294);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 3;
            label2.Text = "RGB Kodu";
            // 
            // btnRasgele
            // 
            btnRasgele.Location = new Point(480, 285);
            btnRasgele.Name = "btnRasgele";
            btnRasgele.Size = new Size(155, 34);
            btnRasgele.TabIndex = 4;
            btnRasgele.Text = "Rasgele";
            btnRasgele.UseVisualStyleBackColor = true;
            btnRasgele.Click += btnRasgele_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 444);
            Controls.Add(btnRasgele);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtHexa);
            Controls.Add(txtB);
            Controls.Add(txtRGB);
            Controls.Add(txtG);
            Controls.Add(txtR);
            Controls.Add(pnRenk);
            Controls.Add(hsB);
            Controls.Add(hsG);
            Controls.Add(hsR);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private HScrollBar hsR;
        private Panel pnRenk;
        private HScrollBar hsG;
        private HScrollBar hsB;
        private TextBox txtR;
        private TextBox txtG;
        private TextBox txtB;
        private TextBox txtRGB;
        private TextBox txtHexa;
        private Label label1;
        private Label label2;
        private Button btnRasgele;
    }
}