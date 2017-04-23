using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.Core.MetaData;

namespace TaxiStation.Core.Transport.Components.TransmissionModel.Abstract
{
    public class Transmission:ITransmission
    {
        protected Transmission(int transmissionId, MetaInfo metaInfo, int numberOfGears)
        {
            TransmissionId = transmissionId;
            MetaInfo = metaInfo;
            NumberOfGears = numberOfGears;
        }

        public int TransmissionId { get; }
        public MetaInfo MetaInfo { get; }
        public int NumberOfGears { get; }
    }
}
