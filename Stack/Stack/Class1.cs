using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{


    [Serializable]
    public class StackIsEmptyException : Exception
    {
        public StackIsEmptyException() :this ("Stack is Empty") {  }
        public StackIsEmptyException(string message) : base(message) { }
        public StackIsEmptyException(string message, Exception inner) : base(message, inner) { }
        protected StackIsEmptyException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
