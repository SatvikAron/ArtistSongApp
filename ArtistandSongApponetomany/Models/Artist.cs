using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArtistandSongApponetomany.Models
{
    public class Artist
    {
        public int ArtistId { get; set; }
        [StringLength(5)]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public String Email { get; set; }

        List<Song> Songs { get; set; }

    }
}
