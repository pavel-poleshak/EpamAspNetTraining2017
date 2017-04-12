using Mediateka.Core.Abstract.Classes;
using Mediateka.Core.Abstract.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateka.Core.Concrete.MediaElements
{
    public class Event : BaseMediaElement, IMediaElement
    {
        public Event(string name) : base(name)
        {
            Elements = new List<IMediaElement>();
        }
        public Event(string name, ICollection<IMediaElement> elements) : base(name)
        {
            Elements = elements;
        }

        public ICollection<IMediaElement> Elements { get; }

        public string Play()
        {
            return string.Format("Event playing: {0}", Name);
        }
    }
}
