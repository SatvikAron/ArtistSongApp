using ArtistandSongApponetomany.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtistandSongApponetomany.Data
{
    public class DbSeed
    {
        public static void Seed(ApplicationDbContext context)
        {
            var aartist = new Artist() { FirstName = "Aron", LastName = "Satvik", Email = "aron@gmail.com" };
            var bartist = new Artist() { FirstName = "Jahurul", LastName = "Melondic", Email = "melhom@gmail.com" };

            var asong = new Song() { Title="Oh my god",SongType="Comedy",Description = "About parent life",  Artist = aartist };
            var bsong = new Song() {Title="Here i am", SongType="Romantic",Description = "About first time love", Artist = bartist };



            context.Add(asong);
            context.Add(bsong);
            context.SaveChanges();

        }
    }
}
