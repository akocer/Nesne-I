namespace uyg18
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
            dgKayitlar = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btnKapat = new Button();
            btnKaydet = new Button();
            btnHesapla = new Button();
            btnAc = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)dgKayitlar).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgKayitlar
            // 
            dgKayitlar.AllowUserToAddRows = false;
            dgKayitlar.AllowUserToDeleteRows = false;
            dgKayitlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgKayitlar.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dgKayitlar.Dock = DockStyle.Fill;
            dgKayitlar.Location = new Point(0, 102);
            dgKayitlar.Name = "dgKayitlar";
            dgKayitlar.ReadOnly = true;
            dgKayitlar.RowHeadersWidth = 62;
            dgKayitlar.RowTemplate.Height = 33;
            dgKayitlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgKayitlar.Size = new Size(1289, 551);
            dgKayitlar.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "SN";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Öğrenci No";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Adı Soyadı";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Vize";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 150;
            // 
            // Column5
            // 
            Column5.HeaderText = "Final";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 150;
            // 
            // Column6
            // 
            Column6.HeaderText = "Ort";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 150;
            // 
            // Column7
            // 
            Column7.HeaderText = "Sonuç";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 150;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnKapat);
            panel1.Controls.Add(btnKaydet);
            panel1.Controls.Add(btnHesapla);
            panel1.Controls.Add(btnAc);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1289, 102);
            panel1.TabIndex = 0;
            // 
            // btnKapat
            // 
            btnKapat.Location = new Point(631, 30);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(195, 52);
            btnKapat.TabIndex = 0;
            btnKapat.Text = "Kapat";
            btnKapat.UseVisualStyleBackColor = true;
            btnKapat.Click += btnKapat_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(430, 30);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(195, 52);
            btnKaydet.TabIndex = 0;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(229, 30);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(195, 52);
            btnHesapla.TabIndex = 0;
            btnHesapla.Text = "Hesapla";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // btnAc
            // 
            btnAc.Location = new Point(28, 30);
            btnAc.Name = "btnAc";
            btnAc.Size = new Size(195, 52);
            btnAc.TabIndex = 0;
            btnAc.Text = "Dosya Aç";
            btnAc.UseVisualStyleBackColor = true;
            btnAc.Click += btnAc_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1289, 653);
            Controls.Add(dgKayitlar);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgKayitlar).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgKayitlar;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Panel panel1;
        private Button btnKapat;
        private Button btnKaydet;
        private Button btnHesapla;
        private Button btnAc;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}