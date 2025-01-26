
using CArch.Domain.Entities;

namespace CArch.Infrastructure.EF.Models
{
    internal class BookReadModel
    {
        public Guid Id { get; set; }
        public int Version { get; set; }
        public string Name { get; set; }
        public int Pages { get; set; }
        public AuthorReadModel Author { get; set; }
    }
}