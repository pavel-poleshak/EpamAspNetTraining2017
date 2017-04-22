using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.Core.Transport.Components.Engine.Abstract.Property;

namespace TaxiStation.Core.Transport.Components.Engine.Concrete.Properties
{
    public class CombustionEngineProperty : EngineProperty
    {
        public CombustionEngineProperty(EngineMaterial material, int power, int torque, int capacity, int cylindersCount) 
            : base(material, power, torque)
        {
            Capacity = capacity;
            CylindersCount = cylindersCount;
        }

        public int Capacity { get; private set; }
        public int CylindersCount { get; private set; }
    }
}
