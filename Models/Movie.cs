using System.ComponentModel.DataAnnotations;

namespace MoviesRESTFull.Models
{
    public class Movie
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public string description { get; set; }
        [Required]
        public float rating { get; set; }
        [Required]
        public string image { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
