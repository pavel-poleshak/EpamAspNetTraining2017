using TaxiStation.Core.MetaData;
using TaxiStation.Core.Transport.Components.EngineModel.Abstract.Property;

namespace TaxiStation.Core.Transport.Components.EngineModel.Abstract
{
    public abstract class CombustionEngine : Engine
    {
        protected CombustionEngine(int engineId, MetaInfo metaInfo, EngineProperty engineProperty)
            : base(engineId, metaInfo, engineProperty)
        {
        }

        public override string Work()
        {
            return string.Format("Combustion Engine working.");
        }
    }
}