using TaxiStation.Core.MetaData;
using TaxiStation.Core.Transport.Components.EngineModel.Abstract.Property;

namespace TaxiStation.Core.Transport.Components.EngineModel.Abstract
{
    public interface IEngine
    {
        int EngineId { get; }
        MetaInfo MetaInfo { get; }
        EngineProperty EngineProperty { get; }

        string Work();
    }
}
