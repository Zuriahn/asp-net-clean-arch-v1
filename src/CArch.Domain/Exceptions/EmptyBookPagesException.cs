using CArch.Shared.Abstractions.Exceptions;

namespace CArch.Domain.Exceptions
{
    public class EmptyBookPagesException : CArchException
    {
        public EmptyBookPagesException() : base("Book pages is empty")
        {
        }
    }
}