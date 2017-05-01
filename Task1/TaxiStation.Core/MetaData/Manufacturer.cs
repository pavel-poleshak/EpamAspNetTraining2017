namespace TaxiStation.Core.MetaData
{
    public class Manufacturer
    {
        public Manufacturer(int id, string name, string country)
        {
            ManufacturerId = id;
            Name = name;
            Country = country;
        }

        public int ManufacturerId { get; private set; }
        public string Name { get; private set; }
        public string Country { get; private set; }
    }
}
