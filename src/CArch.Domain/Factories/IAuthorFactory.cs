
using CArch.Domain.Entities;
using CArch.Domain.ValueObjects;

namespace CArch.Domain.Factories
{
    public interface IAuthorFactory
    {
        Author Create(AuthorId id, AuthorName name);

    }
}