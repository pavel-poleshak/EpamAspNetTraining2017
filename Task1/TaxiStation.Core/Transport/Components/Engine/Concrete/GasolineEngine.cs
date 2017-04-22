using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.Core.MetaData;
using TaxiStation.Core.Transport.Components.Engine.Abstract;
using TaxiStation.Core.Transport.Components.Engine.Abstract.Property;

namespace TaxiStation.Core.Transport.Components.Engine.Concrete
{
    public class GasolineEngine : CombustionEngine
    {
        public GasolineEngine(int engineId, MetaInfo metaInfo, EngineProperty engineProperty)
            : base(engineId, metaInfo, engineProperty)
        {
        }

        public override string Work()
        {
            return string.Format("Gasoline Engine working.");
        }
    }
}