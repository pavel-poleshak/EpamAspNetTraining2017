using System;
using Mediateka.Core.Abstract.Classes;

namespace Mediateka.Core.Concrete.MediaProperties
{
    public class AudioProperty : BaseMediaElementProperty
    {
        public AudioProperty
        (
            string author,
            DateTime createdDate,
            string path,
            int size,
            string extension,
            string genre
        )
            : base(author, createdDate, path, size, extension)
        {
            Genre = genre;
        }

        public string Genre { get; }
    }
}
