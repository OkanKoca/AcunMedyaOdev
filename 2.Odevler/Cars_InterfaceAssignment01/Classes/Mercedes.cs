using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAndAbstractionAssignment.Interfaces;

namespace InterfaceAndAbstractionAssignment.Classes
{
    internal class Mercedes : Car, IDenizdeYuz, IHavadaUc
    {
        public void denizdeYuz()
        {
            Console.WriteLine("Denizde yüzer");
        }
        public void havadaUc()
        {
            Console.WriteLine("Havada uçar");
        }
    }
}
