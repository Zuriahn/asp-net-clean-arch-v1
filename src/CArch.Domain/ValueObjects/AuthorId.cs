using CArch.Domain.Exceptions;

namespace CArch.Domain.ValueObjects
{
    public record AuthorId
    {
        public Guid Value { get; }

        public AuthorId(Guid value)
        {
            if (value == Guid.Empty)
            {
                throw new EmptyAuthorIdException();
            }

            Value = value;
        }

        public static implicit operator Guid(AuthorId id) => id.Value;

        public static implicit operator AuthorId(Guid id) => new (id);
    }
}