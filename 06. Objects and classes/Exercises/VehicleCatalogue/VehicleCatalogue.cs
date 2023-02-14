using System;
using System.Linq;
using System.Collections.Generic;

namespace VehicleCatalogue
{
    class VehicleCatalogue
    {
        static void Main()
        {
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                else
                {
                    string[] inputData = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                    string typeOfVehicle = inputData[0];
                    string modelOfVehicle = inputData[1];
                    string colorOfVehicle = inputData[2];
                    int horsePowerOfVehicle = Convert.ToInt32(inputData[3]);

                    if (typeOfVehicle == "car")
                    {
                        Car car = new Car("Car", modelOfVehicle, colorOfVehicle, horsePowerOfVehicle);
                        cars.Add(car);
                    }
                    else if (typeOfVehicle == "truck")
                    {
                        Truck truck = new Truck("Truck", modelOfVehicle, colorOfVehicle, horsePowerOfVehicle);
                        trucks.Add(truck);
                    }
                }
            }
            double carsAverageHorsePower = 0;
            double trucksAverageHorsePower = 0;

            if (cars.Any())
            {
                carsAverageHorsePower = cars.Average(item => item.HorsePower);
            }
            if (trucks.Any())
            {
                trucksAverageHorsePower = trucks.Average(item => item.HorsePower);
            }


            while (true)
            {


                string model = Console.ReadLine();
                if (model == "Close the Catalogue")
                {
                    break;
                }
                else
                {
                    foreach (var car in cars)
                    {
                        if (car.Model == model)
                        {
                            Console.WriteLine($"Type: {car.Type}");
                            Console.WriteLine($"Model: {car.Model}");
                            Console.WriteLine($"Color: {car.Color}");
                            Console.WriteLine($"Horsepower: {car.HorsePower}");
                        }
                    }
                    foreach (var truck in trucks)
                    {
                        if (truck.Model == model)
                        {
                            Console.WriteLine($"Type: {truck.Type}");
                            Console.WriteLine($"Model: {truck.Model}");
                            Console.WriteLine($"Color: {truck.Color}");
                            Console.WriteLine($"Horsepower: {truck.HorsePower}");
                        }
                    }
                }
            }
            Console.WriteLine($"Cars have average horsepower of: {carsAverageHorsePower:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAverageHorsePower:f2}.");
        }
    }
}
