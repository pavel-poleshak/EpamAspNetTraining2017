namespace TaxiStation.Core.MetaData
{
    public class Model
    {
        public Model(int modelId, string name)
        {
            ModelId = modelId;
            Name = name;
        }

        public int ModelId { get; private set; }
        public string Name { get; private set; }
    }
}
