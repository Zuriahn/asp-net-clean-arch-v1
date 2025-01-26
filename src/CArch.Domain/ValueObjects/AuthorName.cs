
using CArch.Domain.Exceptions;

namespace CArch.Domain.ValueObjects
{
    public record AuthorName
    {
        public string Value { get; }

        public AuthorName(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new EmptyAuthorNameException();
            }
            Value = value;
        }

        public static implicit operator string(AuthorName name) => name.Value;

        public static implicit operator AuthorName(string name) => new (name);
    }
}