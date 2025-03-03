using CarsFuelConsumption_InterfaceAndAbstraction.Classes;

BMW bmw = new BMW();
Porsche porsche = new Porsche();
Mercedes mercedes = new Mercedes();

Console.WriteLine("BMW fuel consumption for 1 hour: " + bmw.CalculateFuelConsumption(1));
Console.WriteLine("Porsche fuel consumption for 1 hour: " + porsche.CalculateFuelConsumption(1));
Console.WriteLine("Mercedes fuel consumption for 1 hour: " + mercedes.CalculateFuelConsumption(1));

double totalConsumption = bmw.CalculateFuelConsumption(1) + porsche.CalculateFuelConsumption(1) + mercedes.CalculateFuelConsumption(1);

Console.WriteLine("Total Consumption : " + totalConsumption);

