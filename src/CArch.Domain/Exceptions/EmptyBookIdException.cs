using CArch.Shared.Abstractions.Exceptions;

namespace CArch.Domain.Exceptions
{
    public class EmptyBookIdException : CArchException
    {
        public EmptyBookIdException() : base("Book id is empty")
        {
        }
    }
}