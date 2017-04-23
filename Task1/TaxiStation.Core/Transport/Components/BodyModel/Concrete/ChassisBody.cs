using TaxiStation.Core.MetaData;
using TaxiStation.Core.Transport.Components.BodyModel.Abstract;

namespace TaxiStation.Core.Transport.Components.BodyModel.Concrete
{
    public class ChassisBody : Body
    {
        public ChassisBody(int bodyId, MetaInfo metaInfo) : base(bodyId, metaInfo)
        {
        }
    }
}