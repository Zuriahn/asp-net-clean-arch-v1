
using CArch.Domain.Exceptions;

namespace CArch.Domain.ValueObjects
{
    public record BookPages
    {
        public int Value { get; }

        public BookPages(int value)
        {
            if (int.IsNegative(value) || value == 0)
            {
                throw new EmptyBookPagesException();
            }
            Value = value;
        }

        public static implicit operator int(BookPages name) => name.Value;

        public static implicit operator BookPages(int name) => new (name);
    }
}