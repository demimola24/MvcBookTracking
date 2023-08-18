using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcBook.Models;

    public class MvcBookContext : DbContext
    {
        public MvcBookContext (DbContextOptions<MvcBookContext> options)
            : base(options)
        {
        }

        public DbSet<MvcBook.Models.Book> Book { get; set; } = default!;

        public DbSet<MvcBook.Models.Category> Category { get; set; }

        public DbSet<MvcBook.Models.CategoryType> CategoryType { get; set; }
    }
