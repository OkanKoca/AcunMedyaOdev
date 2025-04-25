using ReflectionOdemeSistemi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionOdemeSistemi.OdemeYontemleri
{
    public class Havale : IOdemeYontemi
    {
        public string Ode(decimal tutar)
        {
            return $"{tutar} TL havale ile ödendi.";
        }
    }
}
