using System;
using Mediateka.Core.Abstract.Interfaces;

namespace Mediateka.Core.Abstract.Classes
{
    public abstract class BaseMediaElementProperty : IMediaElementProperty
    {
        protected BaseMediaElementProperty(
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
