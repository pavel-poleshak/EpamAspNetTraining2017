using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.Core.Transport.Abstract;

namespace TaxiStation.Core.TaxiStationModel
{
    public abstract class TaxiStation<T> where T: ITransport
    {
        private ICollection<T> _transport;

        protected TaxiStation(int taxiStationId, string name, ICollection<T> transport)
        {
            TaxiStationId = taxiStationId;
            Name = name;
            _transport = transport;
        }

        public int TaxiStationId { get; private set; }
        public string Name { get; private set; }
        public int TransportCount => _transport.Count;

        public void Add(T obj)
        {
            var source = _transport.FirstOrDefault(x => x.TransportId == obj.TransportId);
            if (source==null)
            {
                _transport.Add(obj);
            }
        }

        public T Get(int transportId) => _transport.FirstOrDefault(x => x.TransportId==transportId);

        public IEnumerable<T> GetAllTransport()
        {
            return _transport;
        }

        public T Remove(int transportId)
        {
            T source = _transport.FirstOrDefault(x => x.TransportId==transportId);
            if (source!=null)
            {
                _transport.Remove(source);
            }
            return source;
        }

        public T Remove(T obj)
        {
            T source = _transport.FirstOrDefault(x=>x.Equals(obj));
            if (source != null)
            {
                _transport.Remove(obj);
            }
            return obj;
        }

        public virtual decimal GetTotalPrice()
        {
            return _transport.Sum(x => x.MetaInfo.Price);
        }

        public abstract IEnumerable<T> FindBySpeed (double min, double max);

        public abstract IEnumerable<T> SortTransportByFuelConsumption();

        public abstract IEnumerable<T> SortTransportByFuelConsumptionDesceding();



        public virtual string GetInfo()
        {
            return string.Format("Id: {0} \tName: {1} \tTransport Count: {2}", TaxiStationId, Name, TransportCount);
        }
    }
}
