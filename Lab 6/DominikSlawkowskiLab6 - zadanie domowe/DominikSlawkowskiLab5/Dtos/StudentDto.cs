using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DominikSlawkowskiLab5.Dtos
{
    public class StudentDto
    {
        public int Id { get; set; }
        [Required] //wymagane pole przy dodawaniu
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string City { get; set; }
    }
}