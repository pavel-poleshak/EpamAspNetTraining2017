namespace Mediateka.Core.Abstract.Interfaces
{
    public interface ILocalizable
    {
        string Path { get; }
        string GetFullPath();
    }
}