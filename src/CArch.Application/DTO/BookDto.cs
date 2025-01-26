namespace CArch.Application.DTO
{
    public class BookDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Pages { get; set; }
        public AuthorDto Author { get; set; }
    }
}