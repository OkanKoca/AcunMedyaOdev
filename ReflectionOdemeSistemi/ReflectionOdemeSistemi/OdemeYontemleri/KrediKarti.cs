using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReflectionOdemeSistemi.Interfaces;

namespace ReflectionOdemeSistemi.OdemeYontemleri
{
    public class KrediKarti : IOdemeYontemi
    {
        public string Ode(decimal tutar)
        {
            return $"{tutar} TL kredi kartı ile ödendi.";
        }
    }
}
