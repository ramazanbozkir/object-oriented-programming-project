using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYP_proje
{
    public class Terminal
    {
        public int SeriNo { get; set; }
        public KasaGorevlisi personel { get; set; }
        public Satis satis { get; set; }

        public Terminal(ulong TcNo)
        {
            this.personel = new KasaGorevlisi();
            this.satis = new Satis();
            Random r = new Random();
            SeriNo = r.Next(1, 100000);
        }


    }
}
