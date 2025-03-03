using InterfaceAndAbstractionAssignment.Classes;

BMW bmw = new BMW();
Console.Write("BMW : ");
bmw.marka = "BMW";
bmw.model = "X6";
bmw.hızlıGit();
bmw.denizdeYuz();
bmw.havadaUc();

Console.WriteLine("**********");

Mercedes mercedes = new Mercedes();
Console.Write("Mercedes : ");
mercedes.marka = "Mercedes";
mercedes.model = "G";
mercedes.denizdeYuz();
mercedes.havadaUc();

Console.WriteLine("**********");

Porsche porsche = new Porsche();
Console.Write("Porsche : ");
porsche.marka = "Porsche";
porsche.model = "panamera";
porsche.havadaUc();

