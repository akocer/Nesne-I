namespace uyg10b
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ımageList1 = new ImageList(components);
            button1 = new Button();
            btnListe = new Button();
            ımageList2 = new ImageList(components);
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            btnKaydet = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            kaydetToolStripMenuItem1 = new ToolStripMenuItem();
            farklıKaydetToolStripMenuItem = new ToolStripMenuItem();
            btnDuzenle = new Button();
            btnSil = new Button();
            btnCikis = new Button();
            menuStrip1 = new MenuStrip();
            dosyaToolStripMenuItem = new ToolStripMenuItem();
            kaydetToolStripMenuItem = new ToolStripMenuItem();
            açToolStripMenuItem = new ToolStripMenuItem();
            yenAçToolStripMenuItem = new ToolStripMenuItem();
            eskiAçToolStripMenuItem = new ToolStripMenuItem();
            çokEskiToolStripMenuItem = new ToolStripMenuItem();
            düzenToolStripMenuItem = new ToolStripMenuItem();
            hakkındaToolStripMenuItem = new ToolStripMenuItem();
            çıkışToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripLabel1 = new ToolStripLabel();
            toolStripComboBox1 = new ToolStripComboBox();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripButton2 = new ToolStripButton();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            liste1ToolStripMenuItem = new ToolStripMenuItem();
            liste2ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton3 = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            tslSaat = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            kesToolStripMenuItem = new ToolStripMenuItem();
            kopyalaToolStripMenuItem = new ToolStripMenuItem();
            yapıştırToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            contextMenuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth8Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "cikis.png");
            ımageList1.Images.SetKeyName(1, "duzenle.png");
            ımageList1.Images.SetKeyName(2, "kaydet.png");
            ımageList1.Images.SetKeyName(3, "liste.png");
            ımageList1.Images.SetKeyName(4, "sil.png");
            // 
            // button1
            // 
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.ImageKey = "kaydet.png";
            button1.ImageList = ımageList1;
            button1.Location = new Point(190, 107);
            button1.Name = "button1";
            button1.Size = new Size(113, 57);
            button1.TabIndex = 0;
            button1.Text = "Kaydet";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            // 
            // btnListe
            // 
            btnListe.ImageKey = "liste.png";
            btnListe.ImageList = ımageList2;
            btnListe.Location = new Point(95, 236);
            btnListe.Name = "btnListe";
            btnListe.Size = new Size(98, 87);
            btnListe.TabIndex = 1;
            btnListe.UseVisualStyleBackColor = true;
            // 
            // ımageList2
            // 
            ımageList2.ColorDepth = ColorDepth.Depth8Bit;
            ımageList2.ImageStream = (ImageListStreamer)resources.GetObject("ımageList2.ImageStream");
            ımageList2.TransparentColor = Color.Transparent;
            ımageList2.Images.SetKeyName(0, "cikis.png");
            ımageList2.Images.SetKeyName(1, "duzenle.png");
            ımageList2.Images.SetKeyName(2, "kaydet.png");
            ımageList2.Images.SetKeyName(3, "liste.png");
            ımageList2.Images.SetKeyName(4, "sil.png");
            // 
            // button3
            // 
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.ImageKey = "duzenle.png";
            button3.ImageList = ımageList1;
            button3.Location = new Point(309, 107);
            button3.Name = "button3";
            button3.Size = new Size(113, 57);
            button3.TabIndex = 0;
            button3.Text = "Düzenle";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.ImageKey = "sil.png";
            button4.ImageList = ımageList1;
            button4.Location = new Point(428, 107);
            button4.Name = "button4";
            button4.Size = new Size(113, 57);
            button4.TabIndex = 0;
            button4.Text = "Sil";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.ImageKey = "cikis.png";
            button5.ImageList = ımageList1;
            button5.Location = new Point(547, 107);
            button5.Name = "button5";
            button5.Size = new Size(113, 57);
            button5.TabIndex = 0;
            button5.Text = "Çıkış";
            button5.TextAlign = ContentAlignment.MiddleRight;
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.ImageKey = "liste.png";
            button6.ImageList = ımageList1;
            button6.Location = new Point(71, 107);
            button6.Name = "button6";
            button6.Size = new Size(113, 57);
            button6.TabIndex = 0;
            button6.Text = "Liste";
            button6.TextAlign = ContentAlignment.MiddleRight;
            button6.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            btnKaydet.ContextMenuStrip = contextMenuStrip1;
            btnKaydet.ImageKey = "kaydet.png";
            btnKaydet.ImageList = ımageList2;
            btnKaydet.Location = new Point(199, 236);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(98, 87);
            btnKaydet.TabIndex = 2;
            btnKaydet.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { kaydetToolStripMenuItem1, farklıKaydetToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(184, 68);
            // 
            // kaydetToolStripMenuItem1
            // 
            kaydetToolStripMenuItem1.Name = "kaydetToolStripMenuItem1";
            kaydetToolStripMenuItem1.Size = new Size(183, 32);
            kaydetToolStripMenuItem1.Text = "Kaydet";
            // 
            // farklıKaydetToolStripMenuItem
            // 
            farklıKaydetToolStripMenuItem.Name = "farklıKaydetToolStripMenuItem";
            farklıKaydetToolStripMenuItem.Size = new Size(183, 32);
            farklıKaydetToolStripMenuItem.Text = "Farklı Kaydet";
            // 
            // btnDuzenle
            // 
            btnDuzenle.ImageKey = "duzenle.png";
            btnDuzenle.ImageList = ımageList2;
            btnDuzenle.Location = new Point(303, 236);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(98, 87);
            btnDuzenle.TabIndex = 3;
            btnDuzenle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            btnSil.ImageKey = "sil.png";
            btnSil.ImageList = ımageList2;
            btnSil.Location = new Point(407, 236);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(98, 87);
            btnSil.TabIndex = 4;
            btnSil.UseVisualStyleBackColor = true;
            // 
            // btnCikis
            // 
            btnCikis.ImageKey = "cikis.png";
            btnCikis.ImageList = ımageList2;
            btnCikis.Location = new Point(511, 236);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(98, 87);
            btnCikis.TabIndex = 5;
            btnCikis.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dosyaToolStripMenuItem, düzenToolStripMenuItem, hakkındaToolStripMenuItem, çıkışToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(850, 33);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            dosyaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kaydetToolStripMenuItem, açToolStripMenuItem });
            dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            dosyaToolStripMenuItem.Size = new Size(78, 29);
            dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // kaydetToolStripMenuItem
            // 
            kaydetToolStripMenuItem.Image = (Image)resources.GetObject("kaydetToolStripMenuItem.Image");
            kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            kaydetToolStripMenuItem.Size = new Size(168, 34);
            kaydetToolStripMenuItem.Text = "Kaydet";
            // 
            // açToolStripMenuItem
            // 
            açToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { yenAçToolStripMenuItem, eskiAçToolStripMenuItem });
            açToolStripMenuItem.Name = "açToolStripMenuItem";
            açToolStripMenuItem.Size = new Size(168, 34);
            açToolStripMenuItem.Text = "Aç";
            // 
            // yenAçToolStripMenuItem
            // 
            yenAçToolStripMenuItem.Name = "yenAçToolStripMenuItem";
            yenAçToolStripMenuItem.Size = new Size(169, 34);
            yenAçToolStripMenuItem.Text = "Yen Aç";
            yenAçToolStripMenuItem.Click += yenAçToolStripMenuItem_Click;
            // 
            // eskiAçToolStripMenuItem
            // 
            eskiAçToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { çokEskiToolStripMenuItem });
            eskiAçToolStripMenuItem.Name = "eskiAçToolStripMenuItem";
            eskiAçToolStripMenuItem.Size = new Size(169, 34);
            eskiAçToolStripMenuItem.Text = "Eski Aç";
            // 
            // çokEskiToolStripMenuItem
            // 
            çokEskiToolStripMenuItem.Name = "çokEskiToolStripMenuItem";
            çokEskiToolStripMenuItem.Size = new Size(180, 34);
            çokEskiToolStripMenuItem.Text = "Çok eski";
            // 
            // düzenToolStripMenuItem
            // 
            düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            düzenToolStripMenuItem.Size = new Size(78, 29);
            düzenToolStripMenuItem.Text = "Düzen";
            // 
            // hakkındaToolStripMenuItem
            // 
            hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            hakkındaToolStripMenuItem.Size = new Size(102, 29);
            hakkındaToolStripMenuItem.Text = "Hakkında";
            // 
            // çıkışToolStripMenuItem
            // 
            çıkışToolStripMenuItem.Image = (Image)resources.GetObject("çıkışToolStripMenuItem.Image");
            çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            çıkışToolStripMenuItem.Size = new Size(88, 29);
            çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripLabel1, toolStripComboBox1, toolStripTextBox1, toolStripButton2, toolStripDropDownButton1, toolStripSeparator1, toolStripButton3 });
            toolStrip1.Location = new Point(0, 33);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(850, 33);
            toolStrip1.TabIndex = 7;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(34, 28);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(66, 28);
            toolStripLabel1.Text = "Kaydet";
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 33);
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 33);
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(34, 28);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { liste1ToolStripMenuItem, liste2ToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(42, 28);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // liste1ToolStripMenuItem
            // 
            liste1ToolStripMenuItem.Name = "liste1ToolStripMenuItem";
            liste1ToolStripMenuItem.Size = new Size(164, 34);
            liste1ToolStripMenuItem.Text = "Liste 1";
            // 
            // liste2ToolStripMenuItem
            // 
            liste2ToolStripMenuItem.Name = "liste2ToolStripMenuItem";
            liste2ToolStripMenuItem.Size = new Size(164, 34);
            liste2ToolStripMenuItem.Text = "Liste 2";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 33);
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(34, 28);
            toolStripButton3.Text = "toolStripButton3";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tslSaat });
            statusStrip1.Location = new Point(0, 539);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(850, 32);
            statusStrip1.TabIndex = 8;
            statusStrip1.Text = "statusStrip1";
            // 
            // tslSaat
            // 
            tslSaat.Name = "tslSaat";
            tslSaat.Size = new Size(46, 25);
            tslSaat.Text = "Saat";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(24, 24);
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { kesToolStripMenuItem, kopyalaToolStripMenuItem, yapıştırToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(148, 100);
            // 
            // kesToolStripMenuItem
            // 
            kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            kesToolStripMenuItem.Size = new Size(147, 32);
            kesToolStripMenuItem.Text = "Kes";
            // 
            // kopyalaToolStripMenuItem
            // 
            kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            kopyalaToolStripMenuItem.Size = new Size(147, 32);
            kopyalaToolStripMenuItem.Text = "Kopyala";
            // 
            // yapıştırToolStripMenuItem
            // 
            yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            yapıştırToolStripMenuItem.Size = new Size(147, 32);
            yapıştırToolStripMenuItem.Text = "Yapıştır";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 571);
            ContextMenuStrip = contextMenuStrip2;
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(btnCikis);
            Controls.Add(btnSil);
            Controls.Add(btnDuzenle);
            Controls.Add(btnKaydet);
            Controls.Add(btnListe);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button6);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            contextMenuStrip2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ImageList ımageList1;
        private Button button1;
        private Button btnListe;
        private ImageList ımageList2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button btnKaydet;
        private Button btnDuzenle;
        private Button btnSil;
        private Button btnCikis;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dosyaToolStripMenuItem;
        private ToolStripMenuItem kaydetToolStripMenuItem;
        private ToolStripMenuItem açToolStripMenuItem;
        private ToolStripMenuItem yenAçToolStripMenuItem;
        private ToolStripMenuItem eskiAçToolStripMenuItem;
        private ToolStripMenuItem çokEskiToolStripMenuItem;
        private ToolStripMenuItem düzenToolStripMenuItem;
        private ToolStripMenuItem hakkındaToolStripMenuItem;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripButton toolStripButton2;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem liste1ToolStripMenuItem;
        private ToolStripMenuItem liste2ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton3;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tslSaat;
        private System.Windows.Forms.Timer timer1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem kaydetToolStripMenuItem1;
        private ToolStripMenuItem farklıKaydetToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem kesToolStripMenuItem;
        private ToolStripMenuItem kopyalaToolStripMenuItem;
        private ToolStripMenuItem yapıştırToolStripMenuItem;
    }
}