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
        protected BaseMediaElement(string name, string extension, string path)
        {
            Name = name;
            Extension = extension;
            Path = path;
        }

        public string Name { get; }
        public string Extension { get; }
        public string Path { get; }
        public string GetFullPath()
        {
           return string.Format(Path+Name+Extension);
        }
    }
}
