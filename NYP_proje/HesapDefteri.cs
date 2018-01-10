using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYP_proje
{
    public class HesapDefteri :Dukkan
    {
        public List<Satis> BitenSatislar { get; set; }

        public HesapDefteri()
        {
            BitenSatislar = new List<Satis>();
        }

        public void BitenSatisEkle(Satis satis)
        {
            this.BitenSatislar.Add(satis);
        }

        public void BitenSatisSil(Satis satis)
        {
            this.BitenSatislar.Remove(satis);
        }
        string rapor = "Z Rapor" + Environment.NewLine;
        public string BitenSatislariListele()
        {
           
            foreach (Satis bitensatis in BitenSatislar)
            {
                rapor +="-----------------------------------------------"+Environment.NewLine+
                        "Tutar: " + bitensatis.Tutar + Environment.NewLine +
                        "Tarih: " + bitensatis.Tarih + Environment.NewLine;
            }
            return rapor;
        }
    }
}
