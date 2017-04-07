using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediateka.Core.Concrete;

namespace Mediateka.Core.Abstract.Interfaces
{
    public interface IMediaElement
    {
        string Name { get; }
        MediaElementProperty ElementProperty { get; }
    }
}
