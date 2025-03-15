using WorkerSalaryAndCarFuelConsumptionProgram;

Calisan gm = new Calisan("genel", "mudur", "genel mudur", 150000, "yönetim");
Calisan mudur = new Calisan("müdür", "müdür", "müdür", 100000, "yönetim");
Calisan programci = new Calisan("ali", "veli", "programci", 50000, "yazılım");
Calisan stajyer = new Calisan("ayse", "fatma", "stajyer", 20000, "yazılım");

double toplamMaas = gm.maas + mudur.maas + programci.maas + stajyer.maas;
Console.WriteLine("Toplam Maas: " + toplamMaas);


Araba bmw = new Araba("bmw", 10);
Araba audi = new Araba("audi", 15);
Araba mercedes = new Araba("mercedes", 20);

List<Araba> arabalar = new List<Araba>();
arabalar.Add(bmw);
arabalar.Add(audi);
arabalar.Add(mercedes);

for (int i = 0; i < arabalar.Count; i++)
{
    Console.WriteLine(arabalar[i].calculateFuelConsumption(100)); // 100 mesafesi için her arabanın yakıt tüketimini hesaplar ve ekrana yazar
}