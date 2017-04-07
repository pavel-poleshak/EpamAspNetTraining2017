using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediateka.Core.Abstract.Interfaces;
using Mediateka.Core.Concrete;

namespace Mediateka.Core.Abstract.Classes
{
    public abstract class BaseMediaElement : IMediaElement
    {
        protected BaseMediaElement(string name, MediaElementProperty property)
        {
            Name = name;
            ElemetProperty = property;
        }

        public string Name { get; }
        public MediaElementProperty ElemetProperty { get; }
    }
}
