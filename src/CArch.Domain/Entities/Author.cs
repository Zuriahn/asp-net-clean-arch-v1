
using CArch.Domain.ValueObjects;
using CArch.Shared.Abstractions.Domain;

namespace CArch.Domain.Entities
{

    public class Author : AggregateRoot<AuthorId>
    {
        public AuthorId Id { get; private set; }

        private AuthorName Name;

        private Author(){}
        
        internal Author(AuthorId id, AuthorName name)
        {
            Id = id;
            Name = name;
        }
    }

}