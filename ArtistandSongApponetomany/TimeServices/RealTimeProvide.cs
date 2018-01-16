using ArtistandSongApponetomany.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtistandSongApponetomany.TimeServices
{
    public class RealTimeProvide : ITimeProvider
    {
        public DateTime Now { get => DateTime.Now; set => throw new NotImplementedException(); }

    }
}
