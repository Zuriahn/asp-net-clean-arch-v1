
using CArch.Shared.Abstractions.Exceptions;

namespace CArch.Application.Exceptions
{
    public class BookAlreadyExistsException : CArchException
    {
        public string Name { get; }

        public BookAlreadyExistsException(string name) : base($"Book with name {name} already exists.")
        {
            Name = name;
        }
    }
}