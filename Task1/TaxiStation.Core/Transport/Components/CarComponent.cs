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
        IBody Body { get; }
        IEngine Engine { get; }
        ITransmission Transmission { get; }
        ICollection<IWheel> Wheels { get; }
    }
}