
namespace CArch.Infrastructure.EF.Models
{
    internal class AuthorReadModel
    {
        public Guid Id { get; set; }
        public int Version { get; set; }
        public string Name { get; set; }
        public ICollection<BookReadModel> Books { get; set; }
    }
}