
using CArch.Shared.Abstractions.Exceptions;

namespace CArch.Application.Exceptions
{
    public class AuthorAlreadyExistsException : CArchException
    {
        public string Name { get; }

        public AuthorAlreadyExistsException(string name)
            : base($"Author with name '{name}' already exists.")
        {
            Name = name;
        }
    }
}