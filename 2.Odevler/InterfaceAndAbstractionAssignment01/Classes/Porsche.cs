using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAndAbstractionAssignment.Interfaces;

namespace InterfaceAndAbstractionAssignment.Classes
{
    internal class Porsche : Car, IHavadaUc
    {
        public void havadaUc()
        {
            Console.WriteLine("Havada uçar");
        }
    }
}
