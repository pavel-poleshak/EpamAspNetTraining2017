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
    public class AudioElement : LocalizedMediaElement, IDurationable, ILocalizable
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
            return $"Playing Audio Track: {Name}";
        }


        public string GetFullPath() => Path+Name+Extension;
    }
}
