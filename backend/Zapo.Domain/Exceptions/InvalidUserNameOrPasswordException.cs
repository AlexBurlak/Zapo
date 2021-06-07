using System;

namespace Zapo.Domain.Exceptions
{
    public class InvalidUserNameOrPasswordException : BaseException
    {
        public InvalidUserNameOrPasswordException()
            : base("Invalid Username of Password exception")
        {
        }

        public InvalidUserNameOrPasswordException(string message)
            : base(message)
        {
        }

        public InvalidUserNameOrPasswordException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}