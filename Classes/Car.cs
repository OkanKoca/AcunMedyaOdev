using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACNMDY03.Classes
{
    public class Car
    {
        public string brand;
        public bool gear; // 1 otomatik, 0 düz vites

        public void vitesYazdir(string brand, bool gear)
        {
            if (gear) {
                Console.WriteLine(brand + " " + " otomatik viteslidir." );
            }
            else {
                Console.WriteLine(brand + " " + " düz viteslidir.");
            }   
        }

        public void vitesYazdir()
        {
            if (gear)
            {
                Console.WriteLine(brand + " " + " otomatik viteslidir.");
            }
            else
            {
                Console.WriteLine(brand + " " + " düz viteslidir.");
            }
        }
    }
}
