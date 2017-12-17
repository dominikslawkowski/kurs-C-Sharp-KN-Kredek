using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DominikSlawkowskiLab5.Dtos
{
    public class PostDto
    {
        public int Id { get; set; }
        [Required] //wymagane pole przy dodawaniu
        public string Title { get; set; }
        [Required]
        public string Body { get; set; }
        public string Author { get; set; }
    }
}