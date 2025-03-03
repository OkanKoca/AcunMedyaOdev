using CompanySalaryProgram_InterfaceAndAbstract.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanySalaryProgram_InterfaceAndAbstract.Interfaces;

namespace CompanySalaryProgram_InterfaceAndAbstract.Classes
{
    internal class GenelMudur : Calisan, IMaasHesapla
    {
        public double maasinizNedir()
        {
            Console.WriteLine("Genel Mudur Maaş: " + maas);
            return maas;
        }
    }
}
