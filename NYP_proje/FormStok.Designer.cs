namespace NYP_proje
{
    partial class FormStok
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
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblBirimFiyat = new System.Windows.Forms.Label();
            this.txtBirimFiyat = new System.Windows.Forms.TextBox();
            this.lblUrunMiktari = new System.Windows.Forms.Label();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.lblUrunKodu = new System.Windows.Forms.Label();
            this.txtUrunMiktari = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtUrunKodu = new System.Windows.Forms.TextBox();
            this.listvwStok = new System.Windows.Forms.ListView();
            this.UrunKodu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UrunAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.miktar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BirimFiyati = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnKatalog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(521, 211);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 21;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(605, 211);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 20;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblBirimFiyat
            // 
            this.lblBirimFiyat.AutoSize = true;
            this.lblBirimFiyat.Location = new System.Drawing.Point(518, 164);
            this.lblBirimFiyat.Name = "lblBirimFiyat";
            this.lblBirimFiyat.Size = new System.Drawing.Size(56, 13);
            this.lblBirimFiyat.TabIndex = 19;
            this.lblBirimFiyat.Text = "Birim Fiyatı";
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Location = new System.Drawing.Point(580, 161);
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtBirimFiyat.TabIndex = 18;
            // 
            // lblUrunMiktari
            // 
            this.lblUrunMiktari.AutoSize = true;
            this.lblUrunMiktari.Location = new System.Drawing.Point(518, 127);
            this.lblUrunMiktari.Name = "lblUrunMiktari";
            this.lblUrunMiktari.Size = new System.Drawing.Size(36, 13);
            this.lblUrunMiktari.TabIndex = 17;
            this.lblUrunMiktari.Text = "Miktar";
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(518, 88);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(48, 13);
            this.lblUrunAdi.TabIndex = 16;
            this.lblUrunAdi.Text = "Urun Adı";
            // 
            // lblUrunKodu
            // 
            this.lblUrunKodu.AutoSize = true;
            this.lblUrunKodu.Location = new System.Drawing.Point(518, 43);
            this.lblUrunKodu.Name = "lblUrunKodu";
            this.lblUrunKodu.Size = new System.Drawing.Size(58, 13);
            this.lblUrunKodu.TabIndex = 15;
            this.lblUrunKodu.Text = "Urun Kodu";
            // 
            // txtUrunMiktari
            // 
            this.txtUrunMiktari.Location = new System.Drawing.Point(580, 124);
            this.txtUrunMiktari.Name = "txtUrunMiktari";
            this.txtUrunMiktari.Size = new System.Drawing.Size(100, 20);
            this.txtUrunMiktari.TabIndex = 14;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(580, 85);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(100, 20);
            this.txtUrunAdi.TabIndex = 13;
            // 
            // txtUrunKodu
            // 
            this.txtUrunKodu.Location = new System.Drawing.Point(580, 40);
            this.txtUrunKodu.Name = "txtUrunKodu";
            this.txtUrunKodu.Size = new System.Drawing.Size(100, 20);
            this.txtUrunKodu.TabIndex = 12;
            // 
            // listvwStok
            // 
            this.listvwStok.CheckBoxes = true;
            this.listvwStok.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UrunKodu,
            this.UrunAdi,
            this.miktar,
            this.BirimFiyati});
            this.listvwStok.FullRowSelect = true;
            this.listvwStok.Location = new System.Drawing.Point(12, 38);
            this.listvwStok.Name = "listvwStok";
            this.listvwStok.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listvwStok.Size = new System.Drawing.Size(452, 313);
            this.listvwStok.TabIndex = 11;
            this.listvwStok.UseCompatibleStateImageBehavior = false;
            this.listvwStok.View = System.Windows.Forms.View.Details;
            // 
            // UrunKodu
            // 
            this.UrunKodu.Text = "Urun Kodu";
            this.UrunKodu.Width = 90;
            // 
            // UrunAdi
            // 
            this.UrunAdi.Text = "Urun Adı";
            this.UrunAdi.Width = 155;
            // 
            // miktar
            // 
            this.miktar.Text = "Miktar";
            this.miktar.Width = 101;
            // 
            // BirimFiyati
            // 
            this.BirimFiyati.Text = "Birim Fiyatı";
            this.BirimFiyati.Width = 101;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(521, 256);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(159, 38);
            this.btnKaydet.TabIndex = 22;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnKatalog
            // 
            this.btnKatalog.Location = new System.Drawing.Point(521, 314);
            this.btnKatalog.Name = "btnKatalog";
            this.btnKatalog.Size = new System.Drawing.Size(159, 37);
            this.btnKatalog.TabIndex = 23;
            this.btnKatalog.Text = "Urun Katalogu";
            this.btnKatalog.UseVisualStyleBackColor = true;
            this.btnKatalog.Click += new System.EventHandler(this.btnKatalog_Click);
            // 
            // FormStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 376);
            this.Controls.Add(this.btnKatalog);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblBirimFiyat);
            this.Controls.Add(this.txtBirimFiyat);
            this.Controls.Add(this.lblUrunMiktari);
            this.Controls.Add(this.lblUrunAdi);
            this.Controls.Add(this.lblUrunKodu);
            this.Controls.Add(this.txtUrunMiktari);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.txtUrunKodu);
            this.Controls.Add(this.listvwStok);
            this.Name = "FormStok";
            this.Text = "FormStok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblBirimFiyat;
        private System.Windows.Forms.TextBox txtBirimFiyat;
        private System.Windows.Forms.Label lblUrunMiktari;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.Label lblUrunKodu;
        private System.Windows.Forms.TextBox txtUrunMiktari;
        private System.Windows.Forms.TextBox txtUrunKodu;
        private System.Windows.Forms.ColumnHeader UrunKodu;
        private System.Windows.Forms.ColumnHeader UrunAdi;
        private System.Windows.Forms.ColumnHeader miktar;
        private System.Windows.Forms.ColumnHeader BirimFiyati;
        private System.Windows.Forms.Button btnKaydet;
        public System.Windows.Forms.TextBox txtUrunAdi;
        public System.Windows.Forms.ListView listvwStok;
        private System.Windows.Forms.Button btnKatalog;
    }
}