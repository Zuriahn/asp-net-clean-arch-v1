
using CArch.Application.Services;
using CArch.Infrastructure.EF.Contexts;
using CArch.Infrastructure.EF.Models;
using Microsoft.EntityFrameworkCore;

namespace CArch.Infrastructure.EF.Services
{
    internal sealed class PostgresBookReadService : IBookReadService
    {
        private readonly DbSet<BookReadModel> _books;

        public PostgresBookReadService(ReadDbContext context)
        {
            _books = context.Books;
        }

        public Task<bool> ExistByNameAsync(string name)
        {
            return _books.AnyAsync(x => x.Name == name);
        }
    }
}