using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.Core.Transport.Abstract.CarModel;

namespace TaxiStation.Core.TaxiStationModel
{
    public class PassengerTaxiStation:TaxiStation<IPassengerCar>
    {
        public PassengerTaxiStation(int taxiStationId, string name, ICollection<IPassengerCar> transport) : base(taxiStationId, name, transport)
        {
        }

        public override IEnumerable<IPassengerCar> FindBySpeed(double min, double max)
        {
            var transport = from car in GetAllTransport()
                where car.MetaInfo.Specification.Speed > min && car.MetaInfo.Specification.Speed < max
                select car;

            return transport.ToList();
        }

        public override IEnumerable<IPassengerCar> SortTransportByFuelConsumption()
        {
            return GetAllTransport().OrderBy(x => x.MetaInfo.Specification.FuelConsumption.CityCycle);
        }

        public override IEnumerable<IPassengerCar> SortTransportByFuelConsumptionDesceding()
        {
            return GetAllTransport().OrderByDescending(x => x.MetaInfo.Specification.FuelConsumption.CityCycle);
        }
    }
}
