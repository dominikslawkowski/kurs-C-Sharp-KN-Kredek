using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DominikSlawkowskiLab5.Models
{
    public class GenreDetailDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string BpmAmount { get; set; }
        public string DjName { get; set; }
        public string Genre { get; set; }
    }
}