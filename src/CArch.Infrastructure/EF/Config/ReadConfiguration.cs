using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CArch.Infrastructure.EF.Models;

namespace CArch.Infrastructure.EF.Config
{
    internal sealed class ReadConfiguration :
        IEntityTypeConfiguration<AuthorReadModel>,
        IEntityTypeConfiguration<BookReadModel>
    {
        public void Configure(EntityTypeBuilder<BookReadModel> builder)
        {
            builder.ToTable("Books");
            builder.HasKey(b => b.Id);

            builder.HasOne(b => b.Author)
                .WithMany(a => a.Books);

        }

        public void Configure(EntityTypeBuilder<AuthorReadModel> builder)
        {
            builder.ToTable("Authors");
            builder.HasKey(a => a.Id);

        }
    }
}