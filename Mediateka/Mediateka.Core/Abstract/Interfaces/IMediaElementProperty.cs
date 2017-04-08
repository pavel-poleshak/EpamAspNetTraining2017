using System;

namespace Mediateka.Core.Abstract.Interfaces
{
    public interface IMediaElementProperty
    {
        string Author { get; }
        DateTime CreatedDate { get; }
        string Path { get; }
        byte Size { get; }
        string Extension { get; }
    }
}