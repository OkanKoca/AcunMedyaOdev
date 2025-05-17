using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hastane_randevu_sistemi.Entities
{
    public class Brans
    {
        public int Id { get; set; }
        public string BransAdi { get; set; }

        public override string ToString()
        {
            return BransAdi;
        }


    }

}
