using System.ComponentModel.DataAnnotations;

namespace tp5.Dtos
{
    public class MovieDto
    {
        [MaxLength(250)]
        public String Title { get; set; }
        public int Year { get; set; }
        public double Rate { get; set; }

        [MaxLength(2500)]
        public String Storeline { get; set; }
        public IFormFile? Poster { get; set; }
        public byte GenreId { get; set; }
    }
}
