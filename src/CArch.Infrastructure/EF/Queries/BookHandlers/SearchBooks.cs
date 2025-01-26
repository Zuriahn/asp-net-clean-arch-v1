
using CArch.Application.DTO;
using CArch.Application.Queries;
using CArch.Infrastructure.EF.Contexts;
using CArch.Infrastructure.EF.Models;
using CArch.Shared.Abstractions.Queries;
using Microsoft.EntityFrameworkCore;

namespace CArch.Infrastructure.EF.Queries.BookHandlers
{
    internal sealed class SearchBookHandler : IQueryHandler<SearchBooks, IEnumerable<BookDto>>
    {
        private readonly DbSet<BookReadModel> _book;

        public SearchBookHandler(ReadDbContext context) => _book = context.Books;

        public async Task<IEnumerable<BookDto>> HandleAsync(SearchBooks query)
        {
            var dbQuery = _book.AsQueryable();

            if(query.Name is not null)
            {
                dbQuery = dbQuery.Where(b =>
                    Microsoft.EntityFrameworkCore.EF.Functions.ILike(b.Name, $"%{query.Name}%")
                );
            }

            return await dbQuery
                .Select(b => new BookDto
                {
                    Id = b.Id,
                    Name = b.Name,
                    Pages = b.Pages,
                    Author = new AuthorDto
                    {
                        Id = b.Author.Id,
                        Name = b.Author.Name
                    }
                })
                .AsNoTracking()
                .ToListAsync();
        }
    }
}