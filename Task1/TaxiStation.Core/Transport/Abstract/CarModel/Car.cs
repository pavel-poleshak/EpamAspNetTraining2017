using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.Core.MetaData;

namespace TaxiStation.Core.Transport.Abstract.CarModel
{
    public abstract class Car : BaseTransport
    {
        protected Car(int transportId, MetaInfo metaInfo) : base(transportId, metaInfo)
        {
        }
    }
}
