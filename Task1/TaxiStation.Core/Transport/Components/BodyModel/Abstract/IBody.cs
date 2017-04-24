using TaxiStation.Core.MetaData;

namespace TaxiStation.Core.Transport.Components.BodyModel.Abstract
{
    public interface IBody
    {
        int BodyId { get; }
        MetaInfo MetaInfo { get; }
        IBodyType BodyType { get; }
        IBodyClass BodyClass { get; }
    }
}