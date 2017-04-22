namespace TaxiStation.Core.Transport.Components.Engine.Abstract.Property
{
    public abstract class EngineProperty
    {
        protected EngineProperty(EngineMaterial material, int power)
        {
            Material = material;
            Power = power;
        }

        public EngineMaterial Material { get; private set; }
        public int Power { get; private set; }
    }
}
