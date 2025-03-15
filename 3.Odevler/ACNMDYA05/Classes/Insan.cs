using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACNMDYA05.Classes
{
    class Insan
    {
        public Kafa kafa;
        public string isim;
        public string soyisim;

        public Insan(Kafa kafa, string isim, string soyisim)
        {
            this.kafa = kafa;
            this.isim = isim;
            this.soyisim = soyisim;
        }
        
        public void randeuvuyuKaydet()
        {
            Console.WriteLine("randevu alan kişi : "+
                "kulak tipi : " + kafa.kulak.sekil + " "
                + "göz rengi: " + kafa.goz.renk 
                 + " " + "burun tipi: " + kafa.burun.tip);
        }
    }
}
