using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYP_proje
{
    public class Urun_Tanimi
    {
        public int UrunKodu { get; set; }
        public string UrunAdi { get; set; }
        public decimal BirimFiyat { get; set; }
        
        public SatisKalemi satiskalemi { get; set; }
        public Urun_Tanimi()
        {
            this.satiskalemi = new SatisKalemi();
        }
        
    }
}
