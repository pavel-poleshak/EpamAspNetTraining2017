using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateka.Core.Abstract.Classes
{
    public abstract class LocalizedMediaElement : BaseMediaElement
    {
        protected LocalizedMediaElement(string name, string extension, string path) : base(name)
        {
            Extension = extension;
            Path = path;
        }

        public string Extension { get; }
        public string Path { get; }
    }
}
