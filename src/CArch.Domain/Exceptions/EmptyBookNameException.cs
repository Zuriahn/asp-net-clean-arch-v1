using CArch.Shared.Abstractions.Exceptions;

namespace CArch.Domain.Exceptions
{
    public class EmptyBookNameException : CArchException
    {
        public EmptyBookNameException() : base("Book name is empty")
        {
        }
    }
}