﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleCatalogue
{
    class Catalog
    {
        public List<Truck> Trucks { get; set; }
        public List<Car> Cars { get; set; }
        public Catalog(List<Truck> trucks, List<Car> cars)
        {
            Trucks = trucks;
            Cars = cars;
        }
    }
}
