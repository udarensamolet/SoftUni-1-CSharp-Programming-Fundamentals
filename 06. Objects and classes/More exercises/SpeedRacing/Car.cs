namespace SpeedRacing
{
    class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumptionPerKm)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKm = fuelConsumptionPerKm;
        }

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKm { get; set; }
        public double TraveledDistance { get; set; }

        public void CarTravel(double distance)
        {
            double neededFuel = distance * FuelConsumptionPerKm;

            if (neededFuel <= FuelAmount)
            {
                FuelAmount -= neededFuel;
                TraveledDistance += distance;
            }
            else
            {
                Console.WriteLine($"Insufficient fuel for the drive");
            }
        }
    }
}