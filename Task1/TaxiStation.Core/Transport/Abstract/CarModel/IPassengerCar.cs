﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiStation.Core.Transport.Abstract.CarModel
{
    public interface IPassengerCar : ICar
    {
        int CountOfSeat { get; }
    }
}
