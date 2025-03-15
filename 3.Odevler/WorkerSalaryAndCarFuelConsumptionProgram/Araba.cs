using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerSalaryAndCarFuelConsumptionProgram
{
    class Araba
    {
        public Araba(string marka, int fuelConsumption)
        {
            this.marka = marka;
            this.fuelConsumption = fuelConsumption;
        }

        string marka;
        int fuelConsumption;

        public int calculateFuelConsumption(int distance)
        {
            return distance * fuelConsumption;
        }
    }
}
