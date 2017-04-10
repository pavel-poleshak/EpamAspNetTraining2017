using System;
using Mediateka.Core.Abstract.Interfaces;

namespace Mediateka.Core.Abstract.Classes
{
    public abstract class BaseMediaElementProperty
    {
        protected BaseMediaElementProperty
        (
            string author,
            DateTime createdDate,
            int size
        )
        {
            Author = author;
            CreatedDate = createdDate;
            Size = size;
        }

        public string Author { get; }
        public DateTime CreatedDate { get; }
        public int Size { get; }
        
    }
}
