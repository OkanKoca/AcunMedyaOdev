using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndAbstractionAssignment.Classes
{
    public class Car
    {
        public string marka;
        public string model;
        public void yazdir()
        {
            Console.WriteLine("Arabanın markası: " + marka + " " + "Arabanın modeli: " + model);
        }
    }
}
