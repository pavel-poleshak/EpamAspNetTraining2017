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
    public class VideoElement : LocalizedMediaElement, IMediaElement, ILocalizable, IDurationable
    {
        public VideoElement(string name, string extension, string path, VideoProperty property, TimeSpan duration)
            : base(name, extension, path)
        {
            Property = property;
            Duration = duration;
        }

        public VideoProperty Property { get; }
        public TimeSpan Duration { get; }

        public string Play()
        {
            return string.Format("Playing Video File: {0}", Name);
        }
        public string GetFullPath()
        {
            return Path + Name + Extension;
        }
    }
}
