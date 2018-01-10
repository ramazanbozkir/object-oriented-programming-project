using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYP_proje
{
    public class Urun_Katalogu : Dukkan
    {
        public List<Urun_Tanimi> uruntanimlari { get; set; }

        public Urun_Katalogu()
        {
            this.uruntanimlari = new List<Urun_Tanimi>();
        }

        public void KatalogUrunEkle(Urun_Tanimi uruntanimi)
        {
            this.uruntanimlari.Add(uruntanimi);
        }

        public void KatalogUrunSil(Urun_Tanimi uruntanimi)
        {
            this.uruntanimlari.Remove(uruntanimi);
        }
        
        public string KatalogUrunListele()
        {
            string urunler = "";
            foreach (Urun_Tanimi uruntanimi in uruntanimlari)
            {
                urunler += "Urun Kodu: " + uruntanimi.UrunKodu + Environment.NewLine +
                          "Urun Adi:" + uruntanimi.UrunAdi + Environment.NewLine +
                          "Urun Fiyat: " + uruntanimi.BirimFiyat+Environment.NewLine+
                          "------------------------------------------------------" + Environment.NewLine;
            }
            return urunler;
            
        }
    }
}
