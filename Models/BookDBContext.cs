using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookList.Models
{
    public class BookDBContext:DbContext
    {
      public DbSet<Book> books { get; set; }
    }
}