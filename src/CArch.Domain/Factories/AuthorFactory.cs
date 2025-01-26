
using CArch.Domain.Entities;
using CArch.Domain.ValueObjects;

namespace CArch.Domain.Factories
{
    public sealed class AuthorFactory : IAuthorFactory
    {
        public Author Create(AuthorId id, AuthorName name) => new(id, name);
    }
}