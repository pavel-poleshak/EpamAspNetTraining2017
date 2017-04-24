using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiStation.Core.Transport.Components.BodyModel.Abstract
{
    public abstract class BodyType : IBodyType
    {
        protected BodyType(int bodyTypeId)
        {
            BodyTypeId = bodyTypeId;
        }

        public int BodyTypeId { get; }
    }
}