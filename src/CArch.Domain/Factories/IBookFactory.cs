
using CArch.Domain.Entities;
using CArch.Domain.ValueObjects;

namespace CArch.Domain.Factories
{
    public interface IBookFactory
    {
        Book Create(BookId id, BookName name, BookPages pages, AuthorId authorId);

    }
}