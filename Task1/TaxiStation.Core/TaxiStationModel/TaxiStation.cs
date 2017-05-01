using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.Core.Transport.Abstract;

namespace TaxiStation.Core.TaxiStationModel
{
    public class TaxiStation<T> where T: ITransport
    {
        private ICollection<T> _transport;

        public TaxiStation(int taxiStationId, string name, ICollection<T> transport)
        {
            TaxiStationId = taxiStationId;
            Name = name;
            _transport = transport;
        }

        public int TaxiStationId { get; private set; }
        public string Name { get; private set; }
        public int TransportCount => _transport.Count;

        public void AddTransport(T transport)
        {
            var source = _transport.FirstOrDefault(x => x.TransportId == transport.TransportId);
            if (source==null)
            {
                _transport.Add(transport);
            }
        }

        public T GetTransport(int transportId) => _transport.FirstOrDefault(x => x.TransportId==transportId);

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

        public T Remove(T transport)
        {
            T source = _transport.FirstOrDefault(x=>x.Equals(transport));
            if (source != null)
            {
                _transport.Remove(transport);
            }
            return transport;
        }

        public decimal GetTotalPrice()
        {
            return _transport.Sum(x => x.MetaInfo.Price);
        }

        public IEnumerable<T> FindTransportBy(Predicate<T> projector)
        {
            var source = from transport in _transport
                where projector(transport)
                select transport;
            return source;
        }

        public IEnumerable<T> SortTransportBy(Predicate<T> projector)
        {
            var source = from transport in _transport
                orderby projector
                select transport;
            return source;
        }

        public IEnumerable<T> SortTransportDescedingBy(Predicate<T> projector)
        {
            var source = from transport in _transport
                orderby projector descending 
                select transport;
            return source;
        }

        public string GetInfo()
        {
            return string.Format("Id: {0} \tName: {1} \tTransport Count: {2}", TaxiStationId, Name, TransportCount);
        }
    }
}
