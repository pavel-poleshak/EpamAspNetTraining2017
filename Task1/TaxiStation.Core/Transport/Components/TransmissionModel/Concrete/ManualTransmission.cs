using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.Core.MetaData;
using TaxiStation.Core.Transport.Components.TransmissionModel.Abstract;

namespace TaxiStation.Core.Transport.Components.TransmissionModel.Concrete
{
    public class ManualTransmission : Transmission
    {
        public ManualTransmission(int transmissionId, MetaInfo metaInfo, int numberOfGears) : base(transmissionId,
            metaInfo, numberOfGears)
        {
        }
    }
}
