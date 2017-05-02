using System.Collections.Generic;
using TaxiStation.Core.MetaData;
using TaxiStation.Core.Transport.Abstract.CarModel;
using TaxiStation.Core.Transport.Components;

namespace TaxiStation.Core.Transport
{
    public class PassengerCar : Car, IPassengerCar
    {
        public PassengerCar(int transportId, MetaInfo metaInfo, Specification specification,
            ICollection<IComponent> components, int countOfSeat)
            : base(transportId, metaInfo, specification, components)
        {
            CountOfSeat = countOfSeat;
        }

        public int CountOfSeat { get; }

        public override string Move()
        {
            return string.Format("Passenger Car is moving. Max speed: {0}",Specification.Speed);
        }

        public override string EnableDayLight()
        {
            return string.Format("Day Light enabled");
        }
    }
}
