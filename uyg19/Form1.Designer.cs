namespace uyg19
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
            panel1 = new Panel();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnEkle = new Button();
            txtMail = new TextBox();
            label4 = new Label();
            txtAdsoyad = new TextBox();
            label3 = new Label();
            txtOgrNo = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            dgKayitlar = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgKayitlar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSil);
            panel1.Controls.Add(btnGuncelle);
            panel1.Controls.Add(btnEkle);
            panel1.Controls.Add(txtMail);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtAdsoyad);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtOgrNo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(906, 216);
            panel1.TabIndex = 0;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(465, 119);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(223, 45);
            btnSil.TabIndex = 2;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(465, 68);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(223, 45);
            btnGuncelle.TabIndex = 2;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(465, 17);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(223, 45);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(170, 128);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(186, 30);
            txtMail.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 136);
            label4.Name = "label4";
            label4.Size = new Size(74, 22);
            label4.TabIndex = 0;
            label4.Text = "E-Posta";
            // 
            // txtAdsoyad
            // 
            txtAdsoyad.Location = new Point(170, 92);
            txtAdsoyad.Name = "txtAdsoyad";
            txtAdsoyad.Size = new Size(186, 30);
            txtAdsoyad.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 100);
            label3.Name = "label3";
            label3.Size = new Size(103, 22);
            label3.TabIndex = 0;
            label3.Text = "Adı Soyadı";
            // 
            // txtOgrNo
            // 
            txtOgrNo.Location = new Point(170, 56);
            txtOgrNo.Name = "txtOgrNo";
            txtOgrNo.Size = new Size(186, 30);
            txtOgrNo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 64);
            label2.Name = "label2";
            label2.Size = new Size(117, 22);
            label2.TabIndex = 0;
            label2.Text = "Öğrenci  No";
            // 
            // txtId
            // 
            txtId.Location = new Point(170, 20);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(109, 30);
            txtId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 28);
            label1.Name = "label1";
            label1.Size = new Size(74, 22);
            label1.TabIndex = 0;
            label1.Text = "Kayıt Id";
            // 
            // dgKayitlar
            // 
            dgKayitlar.AllowUserToAddRows = false;
            dgKayitlar.AllowUserToDeleteRows = false;
            dgKayitlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgKayitlar.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgKayitlar.Dock = DockStyle.Fill;
            dgKayitlar.Location = new Point(0, 216);
            dgKayitlar.Name = "dgKayitlar";
            dgKayitlar.ReadOnly = true;
            dgKayitlar.RowHeadersWidth = 62;
            dgKayitlar.RowTemplate.Height = 33;
            dgKayitlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgKayitlar.Size = new Size(906, 405);
            dgKayitlar.TabIndex = 1;
            dgKayitlar.CellClick += dgKayitlar_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Öğr. No";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Adı Soyadı";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "E-Posta";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 300;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 621);
            Controls.Add(dgKayitlar);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgKayitlar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtMail;
        private Label label4;
        private TextBox txtAdsoyad;
        private Label label3;
        private TextBox txtOgrNo;
        private Label label2;
        private TextBox txtId;
        private Label label1;
        private DataGridView dgKayitlar;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnEkle;
    }
}