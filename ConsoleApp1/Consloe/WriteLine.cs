using System;
using System.Runtime.Serialization;

namespace Consloe
{
    [Serializable]
    internal class WriteLine : Exception
    {
        public WriteLine()
        {
        }

        public WriteLine(string message) : base(message)
        {
        }

        public WriteLine(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected WriteLine(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}