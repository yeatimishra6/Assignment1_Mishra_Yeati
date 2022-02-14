using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1_Mishra_Yeati.Models
{
    public class Movie
    {
        public string Slug => Name?.Replace(' ', '-').ToLower() + '-' + Year?.ToString();
        public int MovieId { get; set; }
        [Required(ErrorMessage = "Please Enter a Name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter a Year.")]
        [Range(1889, 2999, ErrorMessage = "Year must be after 1889.")]
        public int? Year { get; set; }

        [Required(ErrorMessage = "Please Enter a Rating.")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
        public int? Rating { get; set; }

        [Required(ErrorMessage = "Please Enter a Genre")]
        public string GenreId { get; set; }
        public Genre Genre { get; set; }

    }
}
