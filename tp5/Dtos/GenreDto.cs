using System.ComponentModel.DataAnnotations;

namespace tp5.Dtos
{
    public class GenreDto
    {
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
