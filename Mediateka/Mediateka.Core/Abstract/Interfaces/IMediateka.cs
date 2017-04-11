using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateka.Core.Abstract.Interfaces
{
    public interface IMediateka
    {
        ICollection<IMediaElement> Items { get; }
    }
}
