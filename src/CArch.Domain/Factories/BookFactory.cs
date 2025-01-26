
using CArch.Domain.Entities;
using CArch.Domain.ValueObjects;

namespace CArch.Domain.Factories
{
    public sealed class BookFactory : IBookFactory
    {
        public Book Create(BookId id, BookName name, BookPages pages, AuthorId authorId) => new(id, name, pages, authorId);
    }
}