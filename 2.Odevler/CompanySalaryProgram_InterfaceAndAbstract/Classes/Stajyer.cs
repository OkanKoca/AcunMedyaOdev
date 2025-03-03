using CompanySalaryProgram_InterfaceAndAbstract.Abstracts;
using CompanySalaryProgram_InterfaceAndAbstract.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanySalaryProgram_InterfaceAndAbstract.Interfaces; 

namespace CompanySalaryProgram_InterfaceAndAbstract.Classes
{
    internal class Stajyer : Calisan, IMaasHesapla
    {
        public double maasinizNedir()
        {
            Console.WriteLine("Stajyer Maaş: " + maas);
            return maas;
        }
    }
}
