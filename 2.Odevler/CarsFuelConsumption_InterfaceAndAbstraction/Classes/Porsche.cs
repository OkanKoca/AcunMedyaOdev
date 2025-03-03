using CarsFuelConsumption_InterfaceAndAbstraction.Interfaces;
using CarsFuelConsumption_InterfaceAndAbstraction.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsFuelConsumption_InterfaceAndAbstraction.Classes
{
    internal class Porsche : Car, ICalculateFuelConsumption
    {
        public Porsche()
        {
            brand = "Porsche";
            fuelConsumptionPerHour = 60.0;
        }
        public double CalculateFuelConsumption(int howManyHours)
        {
            return fuelConsumptionPerHour * howManyHours;
        }
    }
}
