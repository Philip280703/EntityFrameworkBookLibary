using EFBooksOpgave.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace EFBooksOpgave.DbAccess
{
    public class MyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=PHILIP-LAPTOP;Database=EntityFrameworkLibaryBooks;TrustServerCertificate = true; Trusted_Connection=True");
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Loaner> Loaners { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}
