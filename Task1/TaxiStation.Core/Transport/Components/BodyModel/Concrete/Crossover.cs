﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.Core.Transport.Components.BodyModel.Abstract;

namespace TaxiStation.Core.Transport.Components.BodyModel.Concrete
{
    public class Crossover:BodyClass
    {
        public Crossover(int bodyClassId) : base(bodyClassId)
        {
        }
    }
}