using System;
using Mediateka.Core.Abstract.Classes;

namespace Mediateka.Core.Concrete.MediaProperties
{
    public class ImageProperty : BaseMediaElementProperty
    {
        public ImageProperty
        (
            string author,
            DateTime createdDate,
            string path,
            byte size,
            string extension,
            int width,
            int height
        )
            : base(author, createdDate, size)
        {
            Width = width;
            Height = height;
        }

        public int Width { get; private set; }
        public int Height { get; private set; }
    }
}
