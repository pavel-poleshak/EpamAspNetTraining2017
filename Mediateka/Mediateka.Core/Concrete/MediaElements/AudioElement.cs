using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediateka.Core.Abstract.Classes;
using Mediateka.Core.Abstract.Interfaces;
using Mediateka.Core.Concrete.MediaProperties;

namespace Mediateka.Core.Concrete.MediaElements
{
    public class AudioElement:BaseMediaElement, IHasDuration, IPlayable
    {
        public AudioElement(string name, string extension, string path, AudioProperty property, TimeSpan duration)
            : base(name, extension, path)
        {
            Property = property;
            Duration = duration;
        }

        public AudioProperty Property { get; }
        public TimeSpan Duration { get; }

        public string Play()
        {
            return string.Format("Playing Audio Track: {0}", Name);
        }
    }
}
