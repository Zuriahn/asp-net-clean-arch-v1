using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using CArch.Domain.Entities;
using CArch.Domain.ValueObjects;

namespace CArch.Infrastructure.EF.Config
{
    internal sealed class WriteConfiguration :
        IEntityTypeConfiguration<Author>,
        IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.Id);

            var bookNameConverter = new ValueConverter<BookName, string>(bn => bn.Value,
                bn => new BookName(bn));
            builder
            .Property(typeof(BookName), "Name")
            .HasConversion(bookNameConverter)
            .HasColumnName("Name");


            var bookPagesConverter = new ValueConverter<BookPages, int>(bp => bp.Value,
                bp => new BookPages(bp));
            builder
            .Property(typeof(BookPages), "Pages")
            .HasConversion(bookPagesConverter)
            .HasColumnName("Pages");

            var bookAuthorIdConverter = new ValueConverter<AuthorId, Guid>(baid => baid.Value,
                baid => new AuthorId(baid));
            builder
            .Property(typeof(AuthorId), "AuthorId")
            .HasConversion(bookAuthorIdConverter)
            .HasColumnName("AuthorId");

            builder
                .Property(pl => pl.Id)
                .HasConversion(id => id.Value, id => new BookId(id));

            builder.ToTable("Books");
        }

        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(a => a.Id);

            var authorNameConverter = new ValueConverter<AuthorName, string>(an => an.Value,
            an => new AuthorName(an));

            builder
            .Property(typeof(AuthorName), "Name")
            .HasConversion(authorNameConverter)
            .HasColumnName("Name");


            builder
                .Property(pl => pl.Id)
                .HasConversion(id => id.Value, id => new AuthorId(id));

            builder.ToTable("Authors");
        }
    }
}