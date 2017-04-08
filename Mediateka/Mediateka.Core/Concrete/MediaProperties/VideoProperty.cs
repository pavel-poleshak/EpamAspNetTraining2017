using System;
using Mediateka.Core.Abstract.Classes;

namespace Mediateka.Core.Concrete.MediaProperties
{
    public class VideoProperty : BaseMediaElementProperty
    {
        public VideoProperty
        (
            string author,
            DateTime createdDate,
            string path,
            byte size,
            string extension,
            int fps
        )
            : base(author, createdDate, path, size, extension)
        {
            Fps = fps;
        }

        public int Fps { get; }
    }
}
