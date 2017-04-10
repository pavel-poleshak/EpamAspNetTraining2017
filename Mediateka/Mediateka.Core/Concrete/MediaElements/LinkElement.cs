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
    public class LinkElement : BaseMediaElement, ILink
    {
        public LinkElement(string name, string extension, string path, LinkProperty property) : base(name, extension, path)
        {
            Property = property;
        }

        public LinkProperty Property { get; }

        public string Open()
        {
            return string.Format("Opening File: {0}", Property.Object.GetFullPath());
        }
    }
}
