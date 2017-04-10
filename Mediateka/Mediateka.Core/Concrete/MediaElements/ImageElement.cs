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
    public class ImageElement : BaseMediaElement, IShowable
    {
        public ImageElement(string name, string extension, string path, ImageProperty property) : base(name, extension, path)
        {
            Property = property;
        }

        public ImageProperty Property { get; }

        public string Show()
        {
            return string.Format("Showing Image: {0}", Name);
        }
    }
}
