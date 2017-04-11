using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediateka.Core.Abstract.Interfaces;

namespace Mediateka.Core.Abstract.Classes
{
    public abstract class BaseMediaElement
    {
        protected BaseMediaElement(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
