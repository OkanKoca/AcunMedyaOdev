using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerSalaryAndCarFuelConsumptionProgram
{
    class Calisan
    {
        public Calisan(string ad, string soyad, string meslek, int maas, string departman)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.meslek = meslek;
            this.maas = maas;
            this.departman = departman;
        }

        private string ad;
        private string soyad;
        private string meslek;
        public int maas;
        private string departman;

    }
}
