
using CArch.Application.DTO;
using CArch.Application.Queries;
using CArch.Infrastructure.EF.Contexts;
using CArch.Infrastructure.EF.Models;
using CArch.Shared.Abstractions.Queries;
using Microsoft.EntityFrameworkCore;

namespace CArch.Infrastructure.EF.Queries.AuthorHandlers
{
    internal sealed class GetAuthorHandler : IQueryHandler<GetAuthor, AuthorDto>
    {
        private readonly DbSet<AuthorReadModel> _authors;

        public GetAuthorHandler(ReadDbContext context) => _authors = context.Authors;

        public async Task<AuthorDto> HandleAsync(GetAuthor query)
        {
            return await _authors.Where(a => a.Id == query.Id)
                            .Select(a => new AuthorDto
                            {
                                Id = a.Id,
                                Name = a.Name,
                            })
                            .AsNoTracking()
                            .FirstOrDefaultAsync();
        }
    }
}