using System;

namespace CArch.Shared.Abstractions.Exceptions
{
    public abstract class CArchException : Exception
    {
        public CArchException(string message) : base(message)
        {
        }
    }
}