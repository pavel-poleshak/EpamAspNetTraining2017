using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.Core.MetaData;

namespace TaxiStation.Core.Transport.Abstract
{
    public abstract class BaseTransport : ITransport
    {
        protected BaseTransport(int transportId, MetaInfo metaInfo)
        {
            TransportId = transportId;
            MetaInfo = metaInfo;
        }

        public int TransportId { get; private set; }
        public MetaInfo MetaInfo { get; private set; }
    }
}