using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class Article
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        public string AuthorId { get; set; }

        public virtual ApplicationUser Author { get; set; }

        public bool IsAuthor(string authorId)
        {
            return this.AuthorId == authorId;
        }
    }
}