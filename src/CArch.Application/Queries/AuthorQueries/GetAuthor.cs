
using CArch.Shared.Abstractions.Queries;
using CArch.Application.DTO;

namespace CArch.Application.Queries
{
    public class GetAuthor : IQuery<AuthorDto>
    {
        public Guid Id { get; set; }
    }
}