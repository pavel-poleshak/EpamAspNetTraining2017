using TaxiStation.Core.MetaData;
using TaxiStation.Core.Transport.Components.EngineModel.Abstract.Property;

namespace TaxiStation.Core.Transport.Components.EngineModel.Abstract
{
    public abstract class Engine : IEngine
    {
        protected Engine(int engineId, MetaInfo metaInfo, EngineProperty engineProperty)
        {
            EngineId = engineId;
            MetaInfo = metaInfo;
            EngineProperty = engineProperty;
        }

        public int EngineId { get; }
        public MetaInfo MetaInfo { get; }
        public EngineProperty EngineProperty { get; }

        public abstract string Work();

    }
}
