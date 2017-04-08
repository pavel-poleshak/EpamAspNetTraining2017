using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediateka.Core.Abstract.Classes;
using Mediateka.Core.Abstract.Interfaces;

namespace Mediateka.Core.Concrete.MediaElements
{
    public class AudioElement:BaseMediaElement, IHasDuration, IPlayable
    {
        public AudioElement(string name, BaseMediaElementProperty property, TimeSpan duration) 
            : base(name, property)
        {
            Duration = duration;
        }

        public TimeSpan Duration { get; }
        public string Play()
        {
            return string.Format("Playing Audio Track: {0}", Name);
        }
    }
}
