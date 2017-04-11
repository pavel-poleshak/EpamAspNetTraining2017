using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Mediateka.Core.Abstract.Classes;
using Mediateka.Core.Abstract.Interfaces;
using Mediateka.Core.Concrete.MediaProperties;

namespace Mediateka.Core.Concrete.MediaElements
{
    public class ImageElement : LocalizedMediaElement, IMediaElement, ILocalizable
    {
        public ImageElement(string name, string extension, string path, ImageProperty property) : base(name, extension, path)
        {
            Property = property;
        }

        public ImageProperty Property { get; }

        public string Play()
        {
            return string.Format("Showing Image: {0}", Name);
        }

        public string GetFullPath()
        {
            return Path + Name + Extension;
        }
    }
}
