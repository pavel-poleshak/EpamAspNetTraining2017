using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiStation.Core.MetaData
{
    public class Specification
    {
        public Specification(int weight, FuelConsumption fuelConsumption, int speed)
        {
            Weight = weight;
            FuelConsumption = fuelConsumption;
            Speed = speed;
        }

        public int Weight { get; private set; }
        public FuelConsumption FuelConsumption { get; private set; }
        public int Speed { get; private set; }
    }
}
