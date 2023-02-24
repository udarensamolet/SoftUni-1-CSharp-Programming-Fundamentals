namespace SpeedRacing
{
    class SpeedRacing
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
                string model = input[0];
                double fuelAmount = Convert.ToDouble(input[1]);
                double fuelConsumptionPerKm = Convert.ToDouble(input[2]);
                Car car = new Car(model, fuelAmount, fuelConsumptionPerKm);
                cars.Add(car);
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                string[] tokens = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string model = tokens[1];
                double amountOfKm = Convert.ToDouble(tokens[2]);

                var targetCar = cars.FirstOrDefault(x => x.Model == model);
                targetCar.CarTravel(amountOfKm);
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TraveledDistance}");
            }
        }
    }
}