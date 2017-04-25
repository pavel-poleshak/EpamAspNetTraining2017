using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiStation.Core.MetaData
{
    public struct FuelConsumption
    {
        public FuelConsumption(double cityCycle, double trackCycle)
        {
            CityCycle = cityCycle;
            TrackCycle = trackCycle;
        }

        public double CityCycle { get; private set; }
        public double TrackCycle { get; private set; }
    }
}