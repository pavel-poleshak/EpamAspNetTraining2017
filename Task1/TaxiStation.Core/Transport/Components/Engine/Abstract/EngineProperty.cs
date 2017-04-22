using System;
using System.Security.Policy;

namespace TaxiStation.Core.Transport.Components.Engine.Abstract
{
    public abstract class EngineProperty
    {
        public EngineMaterial Material { get; private set; }
        public int Power { get; private set; }
    }
}
