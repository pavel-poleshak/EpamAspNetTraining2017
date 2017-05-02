using TaxiStation.Core.MetaData;

namespace TaxiStation.Core.Transport.Components.BodyModel.Abstract
{
    public interface IBody : IComponent
    {
        int BodyId { get; }
        IBodyType BodyType { get; }
        IBodyClass BodyClass { get; }
    }
}