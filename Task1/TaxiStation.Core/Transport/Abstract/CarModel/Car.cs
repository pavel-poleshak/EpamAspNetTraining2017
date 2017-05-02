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
        protected Car(int transportId, MetaInfo metaInfo, Specification specification, ICollection<IComponent> components) 
            : base(transportId, metaInfo)
        {
            Specification = specification;
            Components = components;
        }

        public Specification Specification { get; private set; }
        public ICollection<IComponent> Components { get; private set; }

        public abstract string Move();
        public abstract string EnableDayLight();
    }
}
