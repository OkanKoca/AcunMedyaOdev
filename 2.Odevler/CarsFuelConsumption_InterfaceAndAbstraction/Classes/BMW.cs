using CarsFuelConsumption_InterfaceAndAbstraction.Abstracts;
using CarsFuelConsumption_InterfaceAndAbstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsFuelConsumption_InterfaceAndAbstraction.Classes
{
    internal class BMW : Car, ICalculateFuelConsumption
    {
        public BMW() {
            brand = "BMW";
            fuelConsumptionPerHour = 80.0;
        }

        public double CalculateFuelConsumption(int howManyHours)
        {
            return fuelConsumptionPerHour * howManyHours;
        }
    }
}
