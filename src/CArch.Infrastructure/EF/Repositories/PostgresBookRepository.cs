
using CArch.Domain.Entities;
using CArch.Domain.Repositories;
using CArch.Domain.ValueObjects;
using CArch.Infrastructure.EF.Contexts;
using Microsoft.EntityFrameworkCore;

namespace CArch.Infrastructure.EF.Repositories
{
    internal sealed class PostgresBookRepository : IBookRepository
    {
        private readonly DbSet<Book> _books;
        private readonly WriteDbContext _writeDbContext;

        public PostgresBookRepository(WriteDbContext writeDbContext)
        {
            _writeDbContext = writeDbContext;
            _books = writeDbContext.Books;
        }

        public Task<Book> GetAsync(BookId id)
        {
            return _books.SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task AddAsync(Book book)
        {
            await _books.AddAsync(book);
            await _writeDbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Book book)
        {
            _books.Update(book);
            await _writeDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Book book)
        {
            _books.Remove(book);
            await _writeDbContext.SaveChangesAsync();
        }
    }
}