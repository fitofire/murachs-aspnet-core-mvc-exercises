// required to add data annoatations
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Ch04Ex1MovieList.Models
{
    public class Movie
    {
        // Entity Framework Core will configure the database to generate this value
        public int MovieId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a year.")]
        [Range(1889, 2999, ErrorMessage = "Year must be between 1889 - 2999.")]
        public int? Year { get; set; }

        [Required(ErrorMessage = "Please enter a rating.")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 - 5.")]
        public int? Rating { get; set; }

        // Specifying a foreign key property when adding a Genre property with data validation
        [Required(ErrorMessage = "Please enter a genre.")]
        public string GenreId { get; set; } = string.Empty;

        // Adding a Genre property to the Movie class to relate to the Genre Class
        // Turning off data validation for the Genre property
        [ValidateNever]
        public Genre Genre { get; set; } = null!;

        // Adding a read-only property name Slug
        public string Slug => Name?.Replace(' ', '-').ToLower() + '-' + Year?.ToString();
    }
}
