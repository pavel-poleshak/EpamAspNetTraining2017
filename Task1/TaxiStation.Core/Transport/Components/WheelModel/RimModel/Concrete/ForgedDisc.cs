using TaxiStation.Core.MetaData;
using TaxiStation.Core.Transport.Components.WheelModel.RimModel.Abstract;

namespace TaxiStation.Core.Transport.Components.WheelModel.RimModel.Concrete
{
    public class ForgedDisc : Rim
    {
        public ForgedDisc(int rimId, MetaInfo metaInfo, RimProperty property)
            : base(rimId, metaInfo, property)
        {
        }
    }
}
