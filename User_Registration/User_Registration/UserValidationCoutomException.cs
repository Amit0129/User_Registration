using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Registration
{
    public class UserValidationCoutomException : Exception
    {
        public enum ExceptionType
        {
            NULL_INPUT,
            EMPTY_INPUT,
            INVALID_INPUT
        }
        private readonly ExceptionType type;
        public UserValidationCoutomException(ExceptionType type,string message) : base(message)
        {
            this.type = type;
        }
    }
}
