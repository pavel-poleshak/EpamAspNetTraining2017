using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediateka.Core.Abstract.Classes;

namespace Mediateka.Core.Abstract.Interfaces
{
    public interface IMediaElement
    {
        string Name { get; }
        string Extension { get; }
        string Path { get; }

        string GetFullPath();
    }
}
