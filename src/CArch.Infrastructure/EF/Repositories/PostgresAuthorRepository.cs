
using CArch.Domain.Entities;
using CArch.Domain.Repositories;
using CArch.Domain.ValueObjects;
using CArch.Infrastructure.EF.Contexts;
using Microsoft.EntityFrameworkCore;

namespace CArch.Infrastructure.EF.Repositories
{
    internal sealed class PostgresAuthorRepository : IAuthorRepository
    {
        private readonly DbSet<Author> _authors;
        private readonly WriteDbContext _writeDbContext;

        public PostgresAuthorRepository(WriteDbContext writeDbContext)
        {
            _writeDbContext = writeDbContext;
            _authors = writeDbContext.Authors;
        }

        public Task<Author> GetAsync(AuthorId id)
        {
            return _authors.SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task AddAsync(Author author)
        {
            await _authors.AddAsync(author);
            await _writeDbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Author author)
        {
            _authors.Update(author);
            await _writeDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Author author)
        {
            _authors.Remove(author);
            await _writeDbContext.SaveChangesAsync();
        }
    }
}