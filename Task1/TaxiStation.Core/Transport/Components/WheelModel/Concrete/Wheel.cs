using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.Core.MetaData;
using TaxiStation.Core.Transport.Components.WheelModel.Abstract;
using TaxiStation.Core.Transport.Components.WheelModel.RimModel.Abstract;
using TaxiStation.Core.Transport.Components.WheelModel.TyreModel.Abstract;

namespace TaxiStation.Core.Transport.Components.WheelModel.Concrete
{
    public class Wheel : IWheel
    {
        public MetaInfo MetaInfo { get; private set; }

        public IRim Rim { get; set; }

        public ITyre Tyre { get;set; }

        public int WheelId { get; private set; }
    }
}
