using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsFuelConsumption_InterfaceAndAbstraction.Interfaces
{
    internal interface ICalculateFuelConsumption
    {
        double CalculateFuelConsumption(int howManyHours);
    }
}
