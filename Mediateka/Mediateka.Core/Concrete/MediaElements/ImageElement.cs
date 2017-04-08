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
    public class ImageElement:BaseMediaElement, IShowable
    {
        public ImageElement(string name, ImageProperty property) : base(name, property)
        {
        }

        public string Show()
        {
            return string.Format("Showing the image: {0}", Name);
        }
    }
}
