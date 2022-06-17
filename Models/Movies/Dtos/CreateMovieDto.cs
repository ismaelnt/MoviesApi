using System.ComponentModel.DataAnnotations;

namespace MoviesApi.Models.Movies.Dtos
{
    public class CreateMovieDto
    {
        [Required]
        public string Title { get; set; }

        [Required, StringLength(30)]
        public string Director { get; set; }

        [StringLength(90)]
        public string Genre { get; set; }

        [Range(1, 210, ErrorMessage = "A duração deve ter no mínimo 1 e no máximo 210 minutos")]
        public int Time { get; set; }
    }
}
