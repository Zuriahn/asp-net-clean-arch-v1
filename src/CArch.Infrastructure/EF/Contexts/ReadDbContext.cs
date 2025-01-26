using Microsoft.EntityFrameworkCore;
using CArch.Infrastructure.EF.Config;
using CArch.Infrastructure.EF.Models;

namespace CArch.Infrastructure.EF.Contexts
{
    internal sealed class ReadDbContext : DbContext
    {
        public DbSet<AuthorReadModel> Authors { get; set; }
        public DbSet<BookReadModel> Books { get; set; }

        public ReadDbContext(DbContextOptions<ReadDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("carch_db");

            var configuration = new ReadConfiguration();
            modelBuilder.ApplyConfiguration<AuthorReadModel>(configuration);
            modelBuilder.ApplyConfiguration<BookReadModel>(configuration);
        }
    }
}