using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateka.Core.Abstract.Interfaces
{
    public interface IMediaElement
    {
        string Name { get; }
        byte Size { get; }
        string Author { get; }
        DateTime CreatedDate { get; }
        string Path { get; }
    }
}
