using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.Core.MetaData;
using TaxiStation.Core.Transport.Components.Engine.Abstract.Property;

namespace TaxiStation.Core.Transport.Components.Engine.Abstract
{
    public abstract class Engine : IEngine
    {
        protected Engine(int engineId, MetaInfo metaInfo, EngineProperty engineProperty)
        {
            EngineId = engineId;
            MetaInfo = metaInfo;
            EngineProperty = engineProperty;
        }

        public int EngineId { get; }
        public MetaInfo MetaInfo { get; }
        public EngineProperty EngineProperty { get; }
    }
}
