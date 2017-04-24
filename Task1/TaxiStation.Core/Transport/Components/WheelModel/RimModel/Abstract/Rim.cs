using TaxiStation.Core.MetaData;

namespace TaxiStation.Core.Transport.Components.WheelModel.RimModel.Abstract
{
    public abstract class Rim : IRim
    {
        protected Rim(int rimId, MetaInfo metaInfo, RimProperty property)
        {
            RimId = rimId;
            MetaInfo = metaInfo;
            Property = property;
        }

        public int RimId { get; private set; }
        public MetaInfo MetaInfo { get; private set; }
        public RimProperty Property { get; private set; }
    }
}