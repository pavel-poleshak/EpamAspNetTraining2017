using TaxiStation.Core.MetaData;
using TaxiStation.Core.Transport.Abstract.CarModel;

namespace TaxiStation.Core.Transport
{
    public class PassengerCar : Car, IPassengerCar
    {
        public PassengerCar(int transportId, MetaInfo metaInfo, int countOfSeat) : base(transportId, metaInfo)
        {
            CountOfSeat = countOfSeat;
        }

        public int CountOfSeat { get; }
    }
}
