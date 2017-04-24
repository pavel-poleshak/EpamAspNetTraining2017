using TaxiStation.Core.MetaData;
using TaxiStation.Core.Transport.Components.BodyModel.Abstract;

namespace TaxiStation.Core.Transport.Components.BodyModel.Concrete
{
    public class ChassisBody : BodyType
    {
        protected ChassisBody(int bodyTypeId) : base(bodyTypeId)
        {
        }
    }
}