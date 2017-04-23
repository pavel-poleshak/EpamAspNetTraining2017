using TaxiStation.Core.MetaData;
using TaxiStation.Core.Transport.Components.EngineModel.Abstract;
using TaxiStation.Core.Transport.Components.EngineModel.Abstract.Property;

namespace TaxiStation.Core.Transport.Components.EngineModel.Concrete
{
    public class GasolineEngine : CombustionEngine
    {
        public GasolineEngine(int engineId, MetaInfo metaInfo, EngineProperty engineProperty)
            : base(engineId, metaInfo, engineProperty)
        {
        }

        public override string Work()
        {
            return string.Format("Gasoline Engine working.");
        }
    }
}