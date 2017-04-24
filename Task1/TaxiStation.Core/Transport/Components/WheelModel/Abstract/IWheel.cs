using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.Core.Transport.Components.WheelModel.RimModel.Abstract;
using TaxiStation.Core.Transport.Components.WheelModel.TyreModel.Abstract;

namespace TaxiStation.Core.Transport.Components.WheelModel.Abstract
{
    public interface IWheel
    {
        int WheelId { get; }
        IRim Rim { get; }
        ITyre Tyre { get; }
    }
}