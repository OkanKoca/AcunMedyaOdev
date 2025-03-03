
using ACNMDY03.Classes;

Bmw bmw = new Bmw();
Audi audi = new Audi();
Mercedes mercedes = new Mercedes();
Porsche porsche = new Porsche();
Togg togg = new Togg();
Toyota toyota = new Toyota();

bmw.brand = "BMW";
audi.brand = "Audi";
mercedes.brand = "Mercedes";
porsche.brand = "Porsche";
togg.brand = "Togg";
toyota.brand = "Toyota";

bmw.gear = true;
audi.gear = true;
mercedes.gear = true;
porsche.gear = true;
togg.gear = false;
toyota.gear = false;


bmw.vitesYazdir();
audi.vitesYazdir();
mercedes.vitesYazdir();
porsche.vitesYazdir();
togg.vitesYazdir();
toyota.vitesYazdir();


// tam tersi olan çıktı ve parametreli şekilde de yazdirma fonksiyonu kullanılabilir.
Console.WriteLine("\n");
Console.WriteLine("-------------------------------------------------");
Console.WriteLine("tam tersi çıktı");
Console.WriteLine("\n");

bmw.gear = false;
audi.gear = false;
mercedes.gear = false;
porsche.gear = false;
togg.gear = true;
toyota.gear = true;


bmw.vitesYazdir(bmw.brand, bmw.gear);
audi.vitesYazdir(audi.brand, audi.gear );
mercedes.vitesYazdir(mercedes.brand, mercedes.gear);
porsche.vitesYazdir(porsche.brand, porsche.gear);
togg.vitesYazdir(togg.brand, togg.gear);
toyota.vitesYazdir(toyota.brand, toyota.gear);