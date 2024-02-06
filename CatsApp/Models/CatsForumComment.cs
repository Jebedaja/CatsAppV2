using System.ComponentModel.DataAnnotations;

namespace CatsForum.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public string AuthorName { get; set; }
    }
}

