using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediateka.Core.Abstract.Classes;
using Mediateka.Core.Abstract.Interfaces;

namespace Mediateka.Core.Concrete.MediaElements
{
    public class Event: BaseMediaElement, IMediaElement
    {
        public Event(string name) : base(name)
        {
            
        }
        public string Play()
        {
            return string.Format("Event playing: {0}", Name);
        }
    }
}
