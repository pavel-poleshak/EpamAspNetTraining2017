﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.Core.MetaData;

namespace TaxiStation.Core.Transport.Components
{
    public interface IComponent
    {
        MetaInfo MetaInfo { get; }
    }
}
