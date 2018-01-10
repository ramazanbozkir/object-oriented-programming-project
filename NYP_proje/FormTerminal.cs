using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NYP_proje
{
    public partial class FrmTerminal : Form
    {
        public FrmTerminal()
        {
            InitializeComponent();
        }
        FormStok frmStok = new FormStok();
        Satis satis = new Satis();
        private void FrmTerminal_Load(object sender, EventArgs e)
        {
            timer.Start();
           
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblZaman.Text = "Tarih/Saat: " + DateTime.Now.ToLocalTime();
        }
        
        private void btnStok_Click(object sender, EventArgs e)
        {
            frmStok.ShowDialog();
            for (int i = 0; i < frmStok.listvwStok.Items.Count; i++)
            {
                cmbUrunAdi.Items.Add(frmStok.listvwStok.Items[i].SubItems[1].Text);
            }
        }

        

        
        int kod_aktar=0;
        private void cmbUrunAdi_SelectedIndexChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < frmStok.listvwStok.Items.Count; i++)
            {
                if (cmbUrunAdi.Text == frmStok.listvwStok.Items[i].SubItems[1].Text)
                {
                    kod_aktar=Convert.ToInt32(frmStok.listvwStok.Items[i].SubItems[0].Text);

                }
                txtBirimFiyat.Text = frmStok.listvwStok.Items[i].SubItems[3].Text;
            }
        }
        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            int sira = listvwSatis.Items.Count;
            listvwSatis.Items.Add(kod_aktar.ToString());
            listvwSatis.Items[sira].SubItems.Add(cmbUrunAdi.Text);
            listvwSatis.Items[sira].SubItems.Add(txtMiktar.Text);
            listvwSatis.Items[sira].SubItems.Add(txtBirimFiyat.Text);
            listvwSatis.Items[sira].SubItems.Add(txtTutar.Text);
            TutarHesapla();
            
        }
        
        public void TutarHesapla()
        {
            decimal total = 0;
            for (int i = 0; i < listvwSatis.Items.Count; i++)
            {
                total +=Convert.ToDecimal(listvwSatis.Items[i].SubItems[4].Text);
            }
            lblToplam.Text= "TOPLAM: " + total.ToString();
            satis.odeme.OdemeMiktari= total;
        }
        private void txtMiktar_TextChanged(object sender, EventArgs e)
        {
            int miktar;
            decimal birimfiyat;
            miktar = Convert.ToInt32(txtMiktar.Text);
            birimfiyat= Convert.ToDecimal(txtBirimFiyat.Text);
            txtTutar.Text = (miktar * birimfiyat).ToString();
        }
        private void btnIptal_Click(object sender, EventArgs e)
        {
              foreach (ListViewItem item in listvwSatis.CheckedItems)
              {
                 listvwSatis.Items.Remove(item);
              }
        }
        private void lblToplam_Click(object sender, EventArgs e)
        {
            TutarHesapla();
        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            string temp = "Fiş"+Environment.NewLine+
                        "---------------------------------------------------------------------------"+Environment.NewLine;
            for (int i = 0; i < listvwSatis.Items.Count; i++)
            {
                temp += "Urun Kodu: " + listvwSatis.Items[i].SubItems[0].Text + Environment.NewLine +
                        "Urun Adı:" + listvwSatis.Items[i].SubItems[1].Text + Environment.NewLine +
                        "Miktar: " + listvwSatis.Items[i].SubItems[2].Text + Environment.NewLine +
                        "Birim Fiyat: " + listvwSatis.Items[i].SubItems[3].Text + Environment.NewLine +
                        "Tutar: " + listvwSatis.Items[i].SubItems[4].Text + Environment.NewLine +
                        "--------------------------------------------------------------------------" + Environment.NewLine;

            }
            satis.Tarih = DateTime.Now.ToLocalTime();
            temp += "Toplam Tutar: " + satis.odeme.OdemeMiktari+Environment.NewLine+
                    "tarih: " +satis.Tarih;
            satis.Tutar = satis.odeme.OdemeMiktari;
            MessageBox.Show(temp);
            hd.BitenSatisEkle(satis);
        }

        
        HesapDefteri hd = new HesapDefteri();
        private void btnHesapDefteri_Click(object sender, EventArgs e)
        {
            MessageBox.Show(hd.BitenSatislariListele());
        }
    }
}
