using TaxiStation.Core.Transport.Components.EngineModel.Abstract.Property;

namespace TaxiStation.Core.Transport.Components.EngineModel.Concrete.Properties
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
