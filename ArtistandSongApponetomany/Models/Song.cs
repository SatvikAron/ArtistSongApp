using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtistandSongApponetomany.Models
{
    public class Song
    {
        public int SongId { get; set; }
        public string Title { get; set; }
        public string SongType { get; set; }
        public string Description { get; set; }

        public int ArtistId { get; set; }
        public Artist Artist { get; set; }

    }
}
