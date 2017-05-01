using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.Core.Transport.Components.BodyModel.Abstract;
using TaxiStation.Core.Transport.Components.EngineModel.Abstract;
using TaxiStation.Core.Transport.Components.TransmissionModel.Abstract;
using TaxiStation.Core.Transport.Components.WheelModel.Abstract;

namespace TaxiStation.Core.Transport.Components
{
    public class CarComponent
    {
        public CarComponent(IBody body, IEngine engine, ITransmission transmission, ICollection<IWheel> wheels)
        {
            Body = body;
            Engine = engine;
            Transmission = transmission;
            Wheels = wheels;
        }

        public IBody Body { get; private set; }
        public IEngine Engine { get; private set; }
        public ITransmission Transmission { get; private set; }
        public ICollection<IWheel> Wheels { get; private set; }
    }
}