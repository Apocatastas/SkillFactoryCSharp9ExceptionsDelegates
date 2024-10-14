using System;

namespace ExceptionsDelegates
{
    public class PaulException : Exception
    {
        public PaulException(string message)
            : base(message) { }
    }
}

