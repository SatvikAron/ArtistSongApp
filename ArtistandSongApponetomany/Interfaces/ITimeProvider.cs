﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtistandSongApponetomany.Interfaces
{
   public interface ITimeProvider
    {
            DateTime Now { get; set; }
    }
}
