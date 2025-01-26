using CArch.Shared.Abstractions.Exceptions;

namespace CArch.Domain.Exceptions
{
    public class EmptyAuthorNameException : CArchException
    {
        public EmptyAuthorNameException() : base("Author name is empty")
        {
        }
    }
}