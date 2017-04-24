using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiStation.Core.Transport.Components.BodyModel.Abstract
{
    public abstract class BodyClass : IBodyClass
    {
        protected BodyClass(int bodyClassId)
        {
            BodyClassId = bodyClassId;
        }

        public int BodyClassId { get; private set; }
    }
}