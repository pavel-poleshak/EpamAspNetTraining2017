using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateka.Core.Concrete
{
    public class MediaElementProperty
    {
        public MediaElementProperty(
            string author,
            DateTime createdDate,
            string path,
            byte size,
            string extension)
        {
            Author = author;
            CreatedDate = createdDate;
            Path = path;
            Size = size;
            Extension = extension;
        }

        public string Author { get; }
        public DateTime CreatedDate { get; }
        public string Path { get; }
        public byte Size { get; }
        public string Extension { get; }
    }
}
