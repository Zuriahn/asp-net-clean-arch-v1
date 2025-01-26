using CArch.Domain.Exceptions;

namespace CArch.Domain.ValueObjects
{
    public record BookId
    {
        public Guid Value { get; }

        public BookId(Guid value)
        {
            if (value == Guid.Empty)
            {
                throw new EmptyBookIdException();
            }

            Value = value;
        }

        public static implicit operator Guid(BookId id) => id.Value;

        public static implicit operator BookId(Guid id) => new (id);
    }
}