using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYP_proje
{
    public class Satis : SatisKalemi
    {
        public DateTime Tarih { get; set; }

        public decimal Tutar { get; set; }

        public Musteri musteri { get; set; }

        public Odeme odeme { get; set; }

        public Satis()
        {
            this.musteri = new Musteri();
            this.odeme = new Odeme();
        }

        
    }
}
