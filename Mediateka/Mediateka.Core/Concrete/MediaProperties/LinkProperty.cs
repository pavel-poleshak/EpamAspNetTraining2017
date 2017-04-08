using System;
using Mediateka.Core.Abstract.Classes;
using Mediateka.Core.Abstract.Interfaces;

namespace Mediateka.Core.Concrete.MediaProperties
{
    public class LinkProperty:BaseMediaElementProperty
    {
        public LinkProperty
        (
            string author,
            DateTime createdDate,
            string path,
            byte size,
            string extension,
            IMediaElement linkedObject
        )
            : base(author, createdDate, path, size, extension)
        {
            Object = linkedObject;
        }

        public IMediaElement Object { get; }
    }
}