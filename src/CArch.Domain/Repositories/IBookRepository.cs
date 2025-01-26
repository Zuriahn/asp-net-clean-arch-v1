
using CArch.Domain.Entities;
using CArch.Domain.ValueObjects;

namespace CArch.Domain.Repositories
{
    public interface IBookRepository
    {
        Task<Book> GetAsync(BookId id);

        Task AddAsync(Book book);

        Task UpdateAsync(Book book);

        Task DeleteAsync(Book book);
    }
}