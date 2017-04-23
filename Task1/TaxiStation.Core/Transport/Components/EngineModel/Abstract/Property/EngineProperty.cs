namespace TaxiStation.Core.Transport.Components.EngineModel.Abstract.Property
{
    public abstract class EngineProperty
    {
        protected EngineProperty(EngineMaterial material, int power, int torque)
        {
            Material = material;
            Power = power;
            Torque = torque;
        }

        public EngineMaterial Material { get; private set; }
        public int Power { get; private set; }
        public int Torque { get; private set; }
    }
}
