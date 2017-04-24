using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.Core.MetaData;
using TaxiStation.Core.Transport.Components.WheelModel.RimModel.Abstract;

namespace TaxiStation.Core.Transport.Components.WheelModel.RimModel.Concrete
{
    public class AlloyDisc : Rim
    {
        public AlloyDisc(int rimId, MetaInfo metaInfo, RimProperty property) 
            : base(rimId, metaInfo, property)
        {
        }
    }
}
