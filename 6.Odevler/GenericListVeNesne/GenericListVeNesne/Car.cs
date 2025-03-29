using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListVeNesne
{
    class Car
    {
        public string Marka;
        public string Model;
        public double fuelConsumptionPerHundredKm;
        public double totalDistance;

        public double CalculateTotalFuelConsumption()
        {
            return (totalDistance / 100 ) * fuelConsumptionPerHundredKm;
        }
    }
}
