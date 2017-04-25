using TaxiStation.Core.MetaData;
using TaxiStation.Core.Transport.Abstract.CarModel;
using TaxiStation.Core.Transport.Components;

namespace TaxiStation.Core.Transport
{
    public class PassengerCar : Car, IPassengerCar
    {
        public PassengerCar(int transportId, MetaInfo metaInfo, CarComponent component, int countOfSeat) : base(transportId, metaInfo, component)
        {
            CountOfSeat = countOfSeat;
        }

        public int CountOfSeat { get; }
    }
}
