using TaxiStation.Core.MetaData;

namespace TaxiStation.Core.Transport.Components.BodyModel.Abstract
{
    public class Body : IBody
    {
        protected Body(int bodyId, MetaInfo metaInfo, IBodyType bodyType, IBodyClass bodyClass)
        {
            BodyId = bodyId;
            MetaInfo = metaInfo;
            BodyType = bodyType;
            BodyClass = bodyClass;
        }

        public int BodyId { get; private set; }
        public MetaInfo MetaInfo { get; private set; }
        public IBodyType BodyType { get; private set; }
        public IBodyClass BodyClass { get; private set; }
    }
}