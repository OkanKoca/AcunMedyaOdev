using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeAndCarAgeCalculationHomework
{
    class Yas
    {
        public string yasHesapla(int dogumYili)
        {
            int yas = DateTime.Now.Year - dogumYili;

            if (yas >= 0 && yas < 18)
                return("Küçüksünüz");
            else if (yas >= 18 && yas < 35)
                return("Gençsiniz");
            else if (yas >= 35 && yas < 55)
                return("Yetişkinsiniz");
            else if (yas >= 55 && yas < 75)
                return("Yaşlısınız");
            else if (yas >= 75 && yas < 99)
                return ("çok yaşlısınız");
            else
                return ("ya hiç doğmadınız ya da çoktan öldünüz");
        }

        public string arabaYasHesapla(int uretimYili)
        {
            int arabaYasi = DateTime.Now.Year - uretimYili;
            if (arabaYasi >= 0 && arabaYasi <10)
                return ("Arabanız yeni");
            else if (arabaYasi >= 10 && arabaYasi < 20)
                return ("Servise götürmeniz gerekebilir");
            else if (arabaYasi >= 20 && arabaYasi < 30)
                return ("Arabanız hurdaya çıkabilir");
            else
                return ("Ya hiç üretilmedi ya da trafikten men edilmiştir.");
        }
    }
}
