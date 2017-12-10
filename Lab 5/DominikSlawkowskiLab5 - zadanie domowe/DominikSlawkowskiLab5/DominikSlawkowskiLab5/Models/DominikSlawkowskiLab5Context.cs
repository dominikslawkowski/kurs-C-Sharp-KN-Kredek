using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DominikSlawkowskiLab5.Models
{
    public class DominikSlawkowskiLab5Context : DbContext
    {
        /// <summary>
        /// Ładowanie naszej bazy danych w konstruktorze
        /// </summary>
        public DominikSlawkowskiLab5Context() : base("name=DominikSlawkowskiLab5Context")
        {
            this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
        }

        public System.Data.Entity.DbSet<DominikSlawkowskiLab5.Models.Dj> Djs { get; set; }

        public System.Data.Entity.DbSet<DominikSlawkowskiLab5.Models.Genre> Genres { get; set; }
    }
}
