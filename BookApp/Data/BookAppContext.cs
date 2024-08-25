using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PersonApp.Models;

namespace BookApp.Data
{
    public class BookAppContext : DbContext
    {
        public BookAppContext (DbContextOptions<BookAppContext> options)
            : base(options)
        {
        }

        public DbSet<PersonApp.Models.Book> Book { get; set; } = default!;
    }
}
