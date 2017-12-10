using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DominikSlawkowskiLab5.Models
{
    public class Genre
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Year { get; set; }
        public string BpmAmount { get; set; }
      
        // Foreign Key
        public int DjId { get; set; }
        // Navigation property
        public Dj Dj { get; set; }
    }
}