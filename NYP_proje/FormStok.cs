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
    public partial class FormStok : Form
    {
        public FormStok()
        {
            InitializeComponent();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listvwStok.CheckedItems)
            {
                listvwStok.Items.Remove(item);
            }
        }
        void Temizle()
        {
            txtUrunKodu.Text = txtUrunAdi.Text = txtUrunMiktari.Text = txtBirimFiyat.Text = "";
        }
        
        SatisKalemi satiskalemi = new SatisKalemi();
        Urun_Katalogu katalog = new Urun_Katalogu();

        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Urun_Tanimi uruntanimlari = new Urun_Tanimi();
            Urun urun = new Urun();
            int sira = listvwStok.Items.Count;
            uruntanimlari = urun.uruntanimi;
            urun.uruntanimi.UrunKodu=Convert.ToInt32( txtUrunKodu.Text);
            urun.uruntanimi.UrunAdi=txtUrunAdi.Text.ToString();
            urun.uruntanimi.satiskalemi.Miktar = Convert.ToInt32(txtUrunMiktari.Text);
            urun.uruntanimi.BirimFiyat = Convert.ToDecimal(txtBirimFiyat.Text);

            listvwStok.Items.Add(urun.uruntanimi.UrunKodu.ToString());
            listvwStok.Items[sira].SubItems.Add(urun.uruntanimi.UrunAdi);
            listvwStok.Items[sira].SubItems.Add(urun.uruntanimi.satiskalemi.Miktar.ToString());
            listvwStok.Items[sira].SubItems.Add(urun.uruntanimi.BirimFiyat.ToString());

            satiskalemi.UrunEkle(urun);
            katalog.KatalogUrunEkle(uruntanimlari);
            Temizle();
            
        }
       
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string temp = "";
            for(int i=0; i<listvwStok.Items.Count; i++)
            {
                temp +="Urun Kodu: "+ listvwStok.Items[i].SubItems[0].Text+Environment.NewLine+
                        "Urun Adı:" + listvwStok.Items[i].SubItems[1].Text + Environment.NewLine +
                        "Miktar: "+ listvwStok.Items[i].SubItems[2].Text + Environment.NewLine +
                        "Birim Fiyat: "+ listvwStok.Items[i].SubItems[3].Text + Environment.NewLine +
                        "--------------------------------------------------------------------------"+Environment.NewLine;
               
            }
            

        }

        private void btnKatalog_Click(object sender, EventArgs e)
        {
            MessageBox.Show(katalog.KatalogUrunListele());
        }
    }
}
