using System;
using System.Linq;
using System.Collections.Generic;

namespace VehicleCatalogue
{
    class VehicleCatalogue
    {
        static void Main()
        {
            string input = Console.ReadLine();
            List<Truck> trucks = new List<Truck>();
            List<Car> cars = new List<Car>();

            while (input != "end")
            {
                char del = ',';
                string[] inputInfo = input.Split(del, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string type = inputInfo[0];
                string brand = inputInfo[1];
                string model = inputInfo[2];
                if (type == "Truck")
                {
                    int weight = Convert.ToInt32(inputInfo[3]);
                    Truck truck = new Truck(brand, model, weight);
                    trucks.Add(truck);
                }
                else if (type == "Car")
                {
                    int horsePower = Convert.ToInt32(inputInfo[3]);
                    Car car = new Car(brand, model, horsePower);
                    cars.Add(car);
                }
                input = Console.ReadLine();
            }

            List<Truck> sortedTrucks = trucks.OrderBy(x => x.Brand).ToList();
            List<Car> sortedCards = cars.OrderBy(x => x.Brand).ToList();
            Catalog catalogue = new Catalog(sortedTrucks, sortedCards);

            if (catalogue.Cars.Any())
            {
                Console.WriteLine("Cars:");
                foreach (var car in catalogue.Cars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (catalogue.Trucks.Any())
            {
                Console.WriteLine("Trucks:");
                foreach (var truck in catalogue.Trucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
}
