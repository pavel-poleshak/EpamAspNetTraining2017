using TaxiStation.Core.MetaData;

namespace TaxiStation.Core.Transport.Components.BodyModel.Abstract
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