using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.Core.MetaData;
using TaxiStation.Core.TaxiStationModel;
using TaxiStation.Core.Transport;
using TaxiStation.Core.Transport.Abstract.CarModel;
using TaxiStation.Core.Transport.Components;
using TaxiStation.Core.Transport.Components.BodyModel.Abstract;
using TaxiStation.Core.Transport.Components.BodyModel.Concrete;
using TaxiStation.Core.Transport.Components.EngineModel;
using TaxiStation.Core.Transport.Components.EngineModel.Abstract;
using TaxiStation.Core.Transport.Components.EngineModel.Concrete;
using TaxiStation.Core.Transport.Components.EngineModel.Concrete.Properties;
using TaxiStation.Core.Transport.Components.TransmissionModel.Abstract;
using TaxiStation.Core.Transport.Components.TransmissionModel.Concrete;
using TaxiStation.Core.Transport.Components.WheelModel.Abstract;
using TaxiStation.Core.Transport.Components.WheelModel.Concrete;

namespace TaxiStation.Builder
{
    public class PassengerTaxiStationBuilder
    {
        private TaxiStation<IPassengerCar> _taxiStation;

        public TaxiStation<IPassengerCar> CreateTaxiStation()
        {
            return _taxiStation = new TaxiStation<IPassengerCar>(0,"Test", CreateListOfCar("BMW", "Germany", "M-ser"));
        }

        public ICollection<IPassengerCar> CreateListOfCar(string manufacturer, string country, string modelName)
        {
            return new List<IPassengerCar>()
            {
                CreateCar(manufacturer, country, modelName),
                CreateCar(manufacturer, country, modelName),
                CreateCar(manufacturer, country, modelName),
                CreateCar(manufacturer, country, modelName)
            };
        }

        private IPassengerCar CreateCar(string manufacturer, string country, string modelName)
        {
            return new PassengerCar(
                1,
                new MetaInfo(
                    new Manufacturer(1, manufacturer, country),
                    new Model(1, modelName),
                    DateTime.Now,
                    2800m),
                new Specification(
                    850,
                    new FuelConsumption(18.0, 9.80),
                    320),
                new List<IComponent>()
                {
                    CreateBody(manufacturer, country, modelName),
                    CreateGasolineEngine(manufacturer, country, modelName),
                    CreateManualTransmission(manufacturer, country, modelName),
                    CreateWheel()
                },
                5);
        }


        private IEngine CreateGasolineEngine(string manufacturer, string country, string modelName)
        {
            return new GasolineEngine(
                1,
                new MetaInfo(
                    new Manufacturer(1, manufacturer, country),
                    new Model(1, modelName),
                    DateTime.Now,
                    100m),
                new CombustionEngineProperty(
                    EngineMaterial.Magnesium,
                    850,
                    745,
                    3,
                    12));
        }

        private ITransmission CreateManualTransmission(string manufacturer, string country, string modelName)
        {
            return new ManualTransmission(
                1,
                new MetaInfo(
                    new Manufacturer(1, manufacturer, country),
                    new Model(1, modelName),
                    DateTime.Now,
                    100m),
                5);
        }

        private IWheel CreateWheel()
        {
            return new Wheel();
        }

        private IBody CreateBody(string manufacturer, string country, string modelName)
        {
            return new Body(
                1,
                new MetaInfo(
                    new Manufacturer(1, manufacturer, country),
                    new Model(1, modelName),
                    DateTime.Now,
                    100m),
                new ChassisBody(1),
                new Crossover(1));
        }






    }
}
