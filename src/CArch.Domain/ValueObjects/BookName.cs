
using CArch.Domain.Exceptions;

namespace CArch.Domain.ValueObjects
{
    public record BookName
    {
        public string Value { get; }

        public BookName(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new EmptyBookNameException();
            }
            Value = value;
        }

        public static implicit operator string(BookName name) => name.Value;

        public static implicit operator BookName(string name) => new (name);
    }
}