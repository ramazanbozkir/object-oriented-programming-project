using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYP_proje
{
    public class SatisKalemi 
    {
        public int Miktar { get; set; }

        public List<Urun> urunler { get; set; }

        public SatisKalemi()
        {
            this.urunler = new List<Urun>();
        }


        public void UrunEkle(Urun u)
        {
            this.urunler.Add(u);
        }
        public void UrunSil(Urun u)
        {
            this.urunler.Remove(u);
        }

        string temp = "";
        public string Urunlistele()
        {
            
            foreach (Urun u in this.urunler)
            {
                temp += "Urun adı: " + u.uruntanimi.UrunAdi;
            }
            return temp;
        }
    }
}
