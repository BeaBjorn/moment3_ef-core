using System.ComponentModel.DataAnnotations;

namespace moment3_ef.Model
{
    public class Book
    {
        public int BookId { get; set; }

        [Required]
        [Display(Name = "Name of book")]
        public string? BookName { get; set; }

        [Required]
        [Display(Name = "Author")]
        public string? BookAuthor { get; set; }

        public int? AuthorId { get; set; }
        public Author? Author { get; set; }
    }
}
