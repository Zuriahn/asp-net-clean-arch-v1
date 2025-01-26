
using CArch.Domain.ValueObjects;
using CArch.Shared.Abstractions.Domain;

namespace CArch.Domain.Entities
{

    public class Book : AggregateRoot<BookId>
    {
        public BookId Id { get; private set; }

        private BookName Name;

        private BookPages Pages;

        private AuthorId AuthorId;

        private Book()
        {
        }
        
        internal Book(BookId id, BookName name, BookPages pages, AuthorId authorId)
        {
            Id = id;
            Name = name;
            Pages = pages;
            AuthorId = authorId;
        }
    }

}