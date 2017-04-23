using System;

namespace TaxiStation.Core.MetaData
{
    public class MetaInfo
    {
        public Manufacturer Manufacturer { get; private set; }
        public Model Model { get; private set; }
        public DateTime CreatingDate { get; private set; }
        public int Weight { get; private set; }
    }
}
