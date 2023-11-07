using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using pop_maria_lab2.Models;

namespace pop_maria_lab2.Data
{
    public class pop_maria_lab2Context : DbContext
    {
        public pop_maria_lab2Context (DbContextOptions<pop_maria_lab2Context> options)
            : base(options)
        {
        }

        public DbSet<pop_maria_lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<pop_maria_lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<pop_maria_lab2.Models.Author>? Author { get; set; }

        public DbSet<pop_maria_lab2.Models.Category>? Category { get; set; }
    }
}
