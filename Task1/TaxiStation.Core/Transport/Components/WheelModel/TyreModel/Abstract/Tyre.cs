using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.Core.MetaData;

namespace TaxiStation.Core.Transport.Components.WheelModel.TyreModel.Abstract
{
    public abstract class Tyre:ITyre
    {
        protected Tyre(int tyreId, MetaInfo metaInfo, TyreProperty property)
        {
            TyreId = tyreId;
            MetaInfo = metaInfo;
            Property = property;
        }

        public int TyreId { get; private set; }
        public MetaInfo MetaInfo { get; private set; }
        public TyreProperty Property { get; private set; }
    }
}