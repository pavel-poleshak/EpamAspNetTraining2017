﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.Core.Transport.Components;

namespace TaxiStation.Core.Transport.Abstract.CarModel
{
    public interface ICar : ITransport
    {
        CarComponent Component { get; }
    }
}