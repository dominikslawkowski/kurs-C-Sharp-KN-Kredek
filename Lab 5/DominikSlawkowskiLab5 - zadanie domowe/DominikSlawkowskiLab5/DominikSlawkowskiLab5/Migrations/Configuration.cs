namespace DominikSlawkowskiLab5.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using DominikSlawkowskiLab5.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<DominikSlawkowskiLab5.Models.DominikSlawkowskiLab5Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
        /// <summary>
        /// Metoda inicjalizuj¹ca bazê danych wartoœciami pocz¹tkowymi, jest uruchamiana po ka¿dej migracji
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(DominikSlawkowskiLab5.Models.DominikSlawkowskiLab5Context context)
        {
            context.Djs.AddOrUpdate(x => x.Id,
                    new Dj() { Id = 1, Name = "Chris Liebing"},
                    new Dj() { Id = 2, Name = "Richie Hawtin" },
                    new Dj() { Id = 3, Name = "Solarstone"}
                );

            context.Genres.AddOrUpdate(x => x.Id,
                new Genre() { Id = 1, Name = "Techno", Year = 1985, BpmAmount = "120-140", DjId = 1},
                new Genre() { Id = 2, Name = "Minimal", Year = 1990, BpmAmount = "125-130", DjId = 2 },
                new Genre() { Id = 3, Name = "Trance", Year = 1992, BpmAmount = "120-150", DjId = 3 }
                );

        }
    }
}
