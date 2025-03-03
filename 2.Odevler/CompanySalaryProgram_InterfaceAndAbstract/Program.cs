
using CompanySalaryProgram_InterfaceAndAbstract.Classes;

GenelMudur gm = new GenelMudur();
Mudur m = new Mudur();
Programci p = new Programci();
Stajyer s = new Stajyer();

gm.maas = 80000;
m.maas = 60000;
p.maas = 40000;
s.maas = 5000;

double toplamMaas = gm.maas + m.maas + p.maas + s.maas;

gm.maasinizNedir();
m.maasinizNedir();
p.maasinizNedir();
s.maasinizNedir();

Console.WriteLine("Toplam maaş: " + toplamMaas);
