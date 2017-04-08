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
    public class VideoElement:BaseMediaElement, IHasDuration, IPlayable
    {
        public VideoElement(string name, VideoProperty property, TimeSpan duration) 
            : base(name, property)
        {
            Duration = duration;
        }

        public TimeSpan Duration { get; }
        public string Play()
        {
            return string.Format("Playing Video File: {0}", Name);
        }
    }
}
