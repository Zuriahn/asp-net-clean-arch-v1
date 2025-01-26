
using CArch.Shared.Abstractions.Queries;
using CArch.Application.DTO;

namespace CArch.Application.Queries
{
    public class SearchBooks : IQuery<IEnumerable<BookDto>>
    {
        public string Name { get; set; }
    }
}