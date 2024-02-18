using System.ComponentModel.DataAnnotations;

namespace moment3_ef.Model
{
    public class Author
    {
        public int AuthorId { get; set; }

        [Required]
        [Display(Name = "Name of Author")]
        public string? AuthorName { get; set; }

        public List<Book>? Books { get; set; }
    }
}
