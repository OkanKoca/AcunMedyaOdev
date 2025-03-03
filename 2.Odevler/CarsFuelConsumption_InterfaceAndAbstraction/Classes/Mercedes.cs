using CarsFuelConsumption_InterfaceAndAbstraction.Interfaces;
using CarsFuelConsumption_InterfaceAndAbstraction.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsFuelConsumption_InterfaceAndAbstraction.Classes
{
    internal class Mercedes : Car, ICalculateFuelConsumption
    {
        public Mercedes()
        {
            brand = "Mercedes";
            fuelConsumptionPerHour = 70.0;
        }
        public double CalculateFuelConsumption(int howManyHours)
        {
            return fuelConsumptionPerHour * howManyHours;
        }
    }
}
