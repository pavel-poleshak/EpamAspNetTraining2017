using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.Core.MetaData;

namespace TaxiStation.Core.Transport.Components.Engine.Abstract
{
    public interface IEngine
    {
        int EngineId { get; }
        MetaInfo MetaInfo { get; }
        EngineProperty EngineProperty { get; }
    }
}
