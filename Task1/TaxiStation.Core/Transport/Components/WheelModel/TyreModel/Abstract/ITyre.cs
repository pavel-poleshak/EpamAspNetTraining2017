using TaxiStation.Core.MetaData;

namespace TaxiStation.Core.Transport.Components.WheelModel.TyreModel.Abstract
{
    public interface ITyre
    {
        int TyreId { get; }
        MetaInfo MetaInfo { get; }
        TyreProperty Property { get; }
    }
}