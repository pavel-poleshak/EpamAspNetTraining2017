using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.Core.MetaData;
using TaxiStation.Core.Transport.Components.BodyModel.Abstract;

namespace TaxiStation.Core.Transport.Components.BodyModel.Concrete
{
    public class FramedBody : BodyType
    {
        public FramedBody(int bodyTypeId) : base(bodyTypeId)
        {
        }
    }
}