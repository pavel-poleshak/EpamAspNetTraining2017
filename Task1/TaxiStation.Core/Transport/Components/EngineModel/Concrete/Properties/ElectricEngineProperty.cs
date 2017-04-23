using TaxiStation.Core.Transport.Components.EngineModel.Abstract.Property;

namespace TaxiStation.Core.Transport.Components.EngineModel.Concrete.Properties
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
