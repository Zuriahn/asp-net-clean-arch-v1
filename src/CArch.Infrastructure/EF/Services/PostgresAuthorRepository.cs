
using CArch.Application.Services;
using CArch.Infrastructure.EF.Contexts;
using CArch.Infrastructure.EF.Models;
using Microsoft.EntityFrameworkCore;

namespace CArch.Infrastructure.EF.Services
{
    internal sealed class PostgresAuthorReadService : IAuthorReadService
    {
        private readonly DbSet<AuthorReadModel> _authors;

        public PostgresAuthorReadService(ReadDbContext context)
        {
            _authors = context.Authors;
        }

        public Task<bool> AuthorExistsAsync(string name)
        {
            return _authors.AnyAsync(a => a.Name == name);
        }
    }
}