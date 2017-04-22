using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.Core.MetaData;

namespace TaxiStation.Core.Transport.Components.Body.Abstract
{
    public class Body : IBody
    {
        protected Body(int bodyId, MetaInfo metaInfo)
        {
            BodyId = bodyId;
            MetaInfo = metaInfo;
        }

        public int BodyId { get; }
        public MetaInfo MetaInfo { get; }
    }
}