using ArtistandSongApponetomany.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtistandSongApponetomany.Data
{
    public class DbSeed
    {
        public static void Seed(ApplicationDbContext context, UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            //Admin Role for Role mananger for Menu bar
            if (!context.Roles.Any())
            {
                var admin = new IdentityRole { Name = "Admin" };
                var result = roleManager.CreateAsync(admin);
            }
            if (!context.Users.Any())
            {
                var user = new ApplicationUser { UserName = "Student@test.com", Email = "Student@test.com" };
                var result = userManager.CreateAsync(user, "MVc12@").Result;
                var roleResult = userManager.AddToRoleAsync(user, "Admin").Result;
            }

            //for one to many relation for Artist and song
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
