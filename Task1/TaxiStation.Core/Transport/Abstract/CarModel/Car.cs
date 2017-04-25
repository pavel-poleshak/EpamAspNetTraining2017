using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.Core.MetaData;
using TaxiStation.Core.Transport.Components;
using TaxiStation.Core.Transport.Components.BodyModel.Abstract;
using TaxiStation.Core.Transport.Components.EngineModel.Abstract;
using TaxiStation.Core.Transport.Components.TransmissionModel.Abstract;
using TaxiStation.Core.Transport.Components.WheelModel.Abstract;

namespace TaxiStation.Core.Transport.Abstract.CarModel
{
    public abstract class Car : BaseTransport, ICar
    {
        protected Car(int transportId, MetaInfo metaInfo, CarComponent component) 
            : base(transportId, metaInfo)
        {
            Component = component;
        }

        public CarComponent Component { get; }
    }
}
