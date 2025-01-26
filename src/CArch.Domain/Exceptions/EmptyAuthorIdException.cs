using CArch.Shared.Abstractions.Exceptions;

namespace CArch.Domain.Exceptions
{
    public class EmptyAuthorIdException : CArchException
    {
        public EmptyAuthorIdException() : base("Author id is empty")
        {
        }
    }
}