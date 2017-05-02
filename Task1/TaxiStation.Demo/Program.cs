using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.Builder;

namespace TaxiStation.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new PassengerTaxiStationBuilder();
            var taxiStation = builder.CreateTaxiStation();

            string countOfPark = taxiStation.TransportCount.ToString();

          


        }
    }
}
