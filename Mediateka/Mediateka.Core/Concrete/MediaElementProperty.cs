using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateka.Core.Concrete
{
    public class MediaElementProperty
    {
        public string Author { get; }
        public DateTime CreatedDate { get; }
        public string Path { get; }
        public byte Size { get; }
        public string Extension { get; }
    }
}
