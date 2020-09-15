using System;
using System.Collections.Generic;
using System.Text;

namespace AppInterfaces
{

    [Serializable]
    public class InvalidPasswordException : Exception
    {
        public InvalidPasswordException() : this("Length>8") {}
        public InvalidPasswordException(string message) : base(message) { }
        public InvalidPasswordException(string message, Exception inner) : base(message, inner) { }
        protected InvalidPasswordException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
