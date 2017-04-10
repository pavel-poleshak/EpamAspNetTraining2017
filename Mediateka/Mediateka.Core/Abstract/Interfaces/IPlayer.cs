using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateka.Core.Abstract.Interfaces
{
    public interface IPlayer
    {
        void OpenFile(IMediaElement element);
        void Close(IMediaElement element);
        void Play(IMediaElement element);
        void Stop(IMediaElement element);
        void Pause(IMediaElement element);
    }
}
