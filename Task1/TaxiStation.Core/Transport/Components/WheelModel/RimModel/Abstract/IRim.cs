using TaxiStation.Core.MetaData;

namespace TaxiStation.Core.Transport.Components.WheelModel.RimModel.Abstract
{
    public interface IRim
    {
        int RimId { get; }
        MetaInfo MetaInfo { get; }
        RimProperty Property { get; }
    }
}