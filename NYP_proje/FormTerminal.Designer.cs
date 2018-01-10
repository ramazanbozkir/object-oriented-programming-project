namespace NYP_proje
{
    partial class FrmTerminal
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
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblZaman = new System.Windows.Forms.Label();
            this.btnHesapDefteri = new System.Windows.Forms.Button();
            this.btnStok = new System.Windows.Forms.Button();
            this.lblToplam = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.lblTutar = new System.Windows.Forms.Label();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtBirimFiyat = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.lblBirimFiyat4 = new System.Windows.Forms.Label();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.cmbUrunAdi = new System.Windows.Forms.ComboBox();
            this.listvwSatis = new System.Windows.Forms.ListView();
            this.CHUrunKodu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHUrunAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHmiktar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHBirimFiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHTutar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.btnOdeme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblZaman
            // 
            this.lblZaman.AutoSize = true;
            this.lblZaman.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZaman.Location = new System.Drawing.Point(423, 9);
            this.lblZaman.Name = "lblZaman";
            this.lblZaman.Size = new System.Drawing.Size(86, 18);
            this.lblZaman.TabIndex = 0;
            this.lblZaman.Text = "Tarih/Saat: ";
            // 
            // btnHesapDefteri
            // 
            this.btnHesapDefteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnHesapDefteri.Location = new System.Drawing.Point(17, 18);
            this.btnHesapDefteri.Name = "btnHesapDefteri";
            this.btnHesapDefteri.Size = new System.Drawing.Size(138, 41);
            this.btnHesapDefteri.TabIndex = 31;
            this.btnHesapDefteri.Text = "Hesap Defteri";
            this.btnHesapDefteri.UseVisualStyleBackColor = true;
            this.btnHesapDefteri.Click += new System.EventHandler(this.btnHesapDefteri_Click);
            // 
            // btnStok
            // 
            this.btnStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnStok.Location = new System.Drawing.Point(161, 18);
            this.btnStok.Name = "btnStok";
            this.btnStok.Size = new System.Drawing.Size(102, 41);
            this.btnStok.TabIndex = 30;
            this.btnStok.Text = "Stok";
            this.btnStok.UseVisualStyleBackColor = true;
            this.btnStok.Click += new System.EventHandler(this.btnStok_Click);
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblToplam.Location = new System.Drawing.Point(294, 409);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(107, 25);
            this.lblToplam.TabIndex = 29;
            this.lblToplam.Text = "TOPLAM: ";
            this.lblToplam.Click += new System.EventHandler(this.lblToplam_Click);
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(610, 218);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(121, 20);
            this.txtTutar.TabIndex = 28;
            this.txtTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(550, 221);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(32, 13);
            this.lblTutar.TabIndex = 27;
            this.lblTutar.Text = "Tutar";
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(656, 309);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(75, 36);
            this.btnIptal.TabIndex = 26;
            this.btnIptal.Text = "İptal Et";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(656, 261);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 33);
            this.btnEkle.TabIndex = 25;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Location = new System.Drawing.Point(610, 180);
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.Size = new System.Drawing.Size(121, 20);
            this.txtBirimFiyat.TabIndex = 24;
            this.txtBirimFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(610, 134);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(121, 20);
            this.txtMiktar.TabIndex = 23;
            this.txtMiktar.TextChanged += new System.EventHandler(this.txtMiktar_TextChanged);
            // 
            // lblBirimFiyat4
            // 
            this.lblBirimFiyat4.AutoSize = true;
            this.lblBirimFiyat4.Location = new System.Drawing.Point(550, 183);
            this.lblBirimFiyat4.Name = "lblBirimFiyat4";
            this.lblBirimFiyat4.Size = new System.Drawing.Size(54, 13);
            this.lblBirimFiyat4.TabIndex = 22;
            this.lblBirimFiyat4.Text = "Birim Fiyat";
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Location = new System.Drawing.Point(550, 137);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(38, 13);
            this.lblMiktar.TabIndex = 21;
            this.lblMiktar.Text = "Miktarı";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(548, 101);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(48, 13);
            this.lblAd.TabIndex = 20;
            this.lblAd.Text = "Urun Adı";
            // 
            // cmbUrunAdi
            // 
            this.cmbUrunAdi.FormattingEnabled = true;
            this.cmbUrunAdi.Location = new System.Drawing.Point(610, 93);
            this.cmbUrunAdi.Name = "cmbUrunAdi";
            this.cmbUrunAdi.Size = new System.Drawing.Size(121, 21);
            this.cmbUrunAdi.TabIndex = 19;
            this.cmbUrunAdi.SelectedIndexChanged += new System.EventHandler(this.cmbUrunAdi_SelectedIndexChanged);
            // 
            // listvwSatis
            // 
            this.listvwSatis.CheckBoxes = true;
            this.listvwSatis.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CHUrunKodu,
            this.CHUrunAdi,
            this.CHmiktar,
            this.CHBirimFiyat,
            this.CHTutar});
            this.listvwSatis.Location = new System.Drawing.Point(12, 91);
            this.listvwSatis.Name = "listvwSatis";
            this.listvwSatis.Size = new System.Drawing.Size(497, 313);
            this.listvwSatis.TabIndex = 18;
            this.listvwSatis.UseCompatibleStateImageBehavior = false;
            this.listvwSatis.View = System.Windows.Forms.View.Details;
            // 
            // CHUrunKodu
            // 
            this.CHUrunKodu.Text = "Urun Kodu";
            this.CHUrunKodu.Width = 89;
            // 
            // CHUrunAdi
            // 
            this.CHUrunAdi.Text = "Urun Adı";
            this.CHUrunAdi.Width = 129;
            // 
            // CHmiktar
            // 
            this.CHmiktar.Text = "Miktar";
            this.CHmiktar.Width = 68;
            // 
            // CHBirimFiyat
            // 
            this.CHBirimFiyat.Text = "BirimFiyat";
            this.CHBirimFiyat.Width = 98;
            // 
            // CHTutar
            // 
            this.CHTutar.Text = "Tutar";
            this.CHTutar.Width = 108;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label6.Location = new System.Drawing.Point(12, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(719, 26);
            this.label6.TabIndex = 35;
            this.label6.Text = "----------------------------------------------SATIŞ------------------------------" +
    "----------------";
            // 
            // btnOdeme
            // 
            this.btnOdeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnOdeme.Location = new System.Drawing.Point(610, 360);
            this.btnOdeme.Name = "btnOdeme";
            this.btnOdeme.Size = new System.Drawing.Size(118, 33);
            this.btnOdeme.TabIndex = 36;
            this.btnOdeme.Text = "Ödeme";
            this.btnOdeme.UseVisualStyleBackColor = true;
            this.btnOdeme.Click += new System.EventHandler(this.btnOdeme_Click);
            // 
            // FrmTerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 444);
            this.Controls.Add(this.btnOdeme);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnHesapDefteri);
            this.Controls.Add(this.btnStok);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtBirimFiyat);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.lblBirimFiyat4);
            this.Controls.Add(this.lblMiktar);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.cmbUrunAdi);
            this.Controls.Add(this.listvwSatis);
            this.Controls.Add(this.lblZaman);
            this.Name = "FrmTerminal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TERMINAL";
            this.Load += new System.EventHandler(this.FrmTerminal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblZaman;
        private System.Windows.Forms.Button btnHesapDefteri;
        private System.Windows.Forms.Button btnStok;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtBirimFiyat;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label lblBirimFiyat4;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOdeme;
        public System.Windows.Forms.ComboBox cmbUrunAdi;
        public System.Windows.Forms.ListView listvwSatis;
        public System.Windows.Forms.ColumnHeader CHUrunKodu;
        public System.Windows.Forms.ColumnHeader CHUrunAdi;
        public System.Windows.Forms.ColumnHeader CHmiktar;
        public System.Windows.Forms.ColumnHeader CHBirimFiyat;
        public System.Windows.Forms.ColumnHeader CHTutar;
    }
}