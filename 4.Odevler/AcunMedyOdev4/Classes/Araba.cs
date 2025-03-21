using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunMedyOdev4.Classes
{
    class Araba
    {
        public Kapi kapi;
        public Pencere pencere;
        public Kasa kasa;
        public Marka marka;

        public Araba()
        {
            kapi = new Kapi();
            pencere = new Pencere();
            kasa = new Kasa();
            marka = new Marka();
        }

        public void yazdir()
        {
            Console.WriteLine("Arabanın markası " + marka.marka + " " + " modeli "
                + marka.model + " " + "kapı sayısı " + kapi.kapiSayisi + " "
                + "pencere sayısı " + pencere.pencereSayisi + " "
                + "kasası " + kasa.kasaTipi + " " + "fiyatı " + marka.fiyat);
        }
    }
}
