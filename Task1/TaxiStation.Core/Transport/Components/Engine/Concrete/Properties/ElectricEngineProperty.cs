using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.Core.Transport.Components.Engine.Abstract.Property;

namespace TaxiStation.Core.Transport.Components.Engine.Concrete.Properties
{
    public class ElectricEngineProperty:EngineProperty
    {
        public ElectricEngineProperty(EngineMaterial material, int power, int torque, int ratedVoltage) 
            : base(material, power, torque)
        {
            RatedVoltage = ratedVoltage;
        }

        public int RatedVoltage { get; private set; }
    }
}
