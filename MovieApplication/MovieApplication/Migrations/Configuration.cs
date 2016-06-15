namespace MovieApplication.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MovieApplication.Models.MovieContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MovieApplication.Models.MovieContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Movies.AddOrUpdate(
              m => m.Title,
              new Movie { ID = 1, Title = "Frozen", ReleaseDate = new DateTime(2013, 1, 1), Price = 15 },
              new Movie { ID = 2, Title = "Star Wars VII", ReleaseDate = new DateTime(2015, 1, 1), Price = 35 },
              new Movie { ID = 3, Title = "Batman", ReleaseDate = new DateTime(1989, 1, 1), Price = 10 },
              new Movie { ID = 4, Title = "Toy Story", ReleaseDate = new DateTime(2013, 1, 1), Price = 16 },
              new Movie { ID = 5, Title = "Home Alone", ReleaseDate = new DateTime(2015, 1, 1), Price = 28 },
              new Movie { ID = 6, Title = "Avatar", ReleaseDate = new DateTime(1989, 1, 1), Price = 19 },
              new Movie { ID = 7, Title = "Aliens", ReleaseDate = new DateTime(2013, 1, 1), Price = 12 },
              new Movie { ID = 8, Title = "Mars Attacks", ReleaseDate = new DateTime(2015, 1, 1), Price = 8 },
              new Movie { ID = 9, Title = "Zorro", ReleaseDate = new DateTime(1989, 1, 1), Price = 9 },
              new Movie { ID = 10, Title = "Candyman", ReleaseDate = new DateTime(2013, 1, 1), Price = 5 },
              new Movie { ID = 11, Title = "Lost in translation", ReleaseDate = new DateTime(2015, 1, 1), Price = 10 },
              new Movie { ID = 12, Title = "Contact", ReleaseDate = new DateTime(1992, 1, 1), Price = 11 }
            );
        }
    }
}
