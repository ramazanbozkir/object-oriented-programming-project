using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYP_proje
{
    public class Urun  :Dukkan 
    {
        public Urun_Tanimi uruntanimi { get; set; }

        public Urun()
        {
            this.uruntanimi = new Urun_Tanimi();
        }

       

    }
}
