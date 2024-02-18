using Microsoft.EntityFrameworkCore;
using moment3_ef.Model;

namespace moment3_ef.Data
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {

        }
        public DbSet<Book> Book { get; set; }
        public DbSet<Author> Author { get; set; }
    }
}
