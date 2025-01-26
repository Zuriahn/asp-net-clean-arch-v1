
using CArch.Domain.Entities;
using CArch.Domain.ValueObjects;

namespace CArch.Domain.Repositories
{
    public interface IAuthorRepository
    {
        Task<Author> GetAsync(AuthorId id);

        Task AddAsync(Author author);

        Task UpdateAsync(Author author);

        Task DeleteAsync(Author author);
    }
}