using System;

namespace ExceptionsDelegates
{
    public class IvanovException : Exception
    {
        public IvanovException(string message)
            : base(message) { }
    }
}