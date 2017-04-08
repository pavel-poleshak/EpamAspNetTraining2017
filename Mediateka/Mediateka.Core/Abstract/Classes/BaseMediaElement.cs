using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediateka.Core.Abstract.Interfaces;

namespace Mediateka.Core.Abstract.Classes
{
    public abstract class BaseMediaElement : IMediaElement
    {
        protected BaseMediaElement(string name, BaseMediaElementProperty property)
        {
            Name = name;
            ElementProperty = property;
        }

        public string Name { get; }
        public BaseMediaElementProperty ElementProperty { get; }
    }
}
