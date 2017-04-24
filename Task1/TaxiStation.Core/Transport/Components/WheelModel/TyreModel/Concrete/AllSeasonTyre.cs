using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.Core.MetaData;
using TaxiStation.Core.Transport.Components.WheelModel.TyreModel.Abstract;

namespace TaxiStation.Core.Transport.Components.WheelModel.TyreModel.Concrete
{
    public class AllSeasonTyre:Tyre
    {
        public AllSeasonTyre(int tyreId, MetaInfo metaInfo, TyreProperty property) : base(tyreId, metaInfo, property)
        {
        }
    }
}