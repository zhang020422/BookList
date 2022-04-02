using System.Data.Entity;

namespace BookList.Models
{
    public class BookDBContext : DbContext
    {
        public DbSet<Book> books { get; set; }
    }
}