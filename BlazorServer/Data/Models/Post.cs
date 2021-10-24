using System.ComponentModel.DataAnnotations;

namespace BlazorServer.Data.Models
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }

        [Required]
        [MaxLength(128)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }
    }
}
