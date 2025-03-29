
// list of cars
using GenericListVeNesne;

List<Car> cars = new List<Car>();
cars.Add(
    new Car { Marka = "Toyota", Model = "Corolla", fuelConsumptionPerHundredKm = 6.5, totalDistance = 2500 }
);
cars.Add(
    new Car { Marka = "BMW", Model = "X5", fuelConsumptionPerHundredKm = 9.0, totalDistance = 1350 }
);
cars.Add(
    new Car { Marka = "Mercedes", Model = "C200", fuelConsumptionPerHundredKm = 8.2, totalDistance = 1125}
);

for(int i= 0; i < cars.Count; i++)
{
    Console.WriteLine("Marka: " + cars[i].Marka + " " + "Model:" + cars[i].Model 
        + " " + "Yaktığı yakıt: " + cars[i].fuelConsumptionPerHundredKm + " " +
        " Toplam Yakıt Tüketimi: " + cars[i].CalculateTotalFuelConsumption());
}

