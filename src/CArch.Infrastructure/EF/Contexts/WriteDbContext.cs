using Microsoft.EntityFrameworkCore;
using CArch.Domain.Entities;
using CArch.Domain.ValueObjects;
using CArch.Infrastructure.EF.Config;

namespace CArch.Infrastructure.EF.Contexts
{
    internal sealed class WriteDbContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        public WriteDbContext(DbContextOptions<WriteDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("carch_db");
            
            var configuration = new WriteConfiguration();
            modelBuilder.ApplyConfiguration<Author>(configuration);
            modelBuilder.ApplyConfiguration<Book>(configuration);
        }
    }
}