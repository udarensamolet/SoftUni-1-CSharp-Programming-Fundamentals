using System.Collections.Generic;

namespace RawData
{
    class RawData
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string carModel = input[0];
                int engineSpeed = Convert.ToInt32(input[1]);
                int enginePower = Convert.ToInt32(input[2]);
                int cargoWeight = Convert.ToInt32(input[3]);
                string cargoType = input[4];

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                Car car = new Car(carModel, engine, cargo);

                cars.Add(car);
            }

            string command = Console.ReadLine();
            if (command == "fragile")
            {
                foreach (var car in cars.Where(x => x.Cargo.Type == "fragile" && x.Cargo.Weight < 1000))
                {
                    Console.WriteLine(car.Model);
                }
            }
            else if (command == "flamable")
            {
                foreach (var car in cars.Where(x => x.Cargo.Type == "flamable" && x.Engine.Power > 250))
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}