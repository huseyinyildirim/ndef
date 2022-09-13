using System;
using System.Runtime.Serialization;

namespace buluton.ndef
{
    [Serializable()]
    class NFCException : Exception
    {
        public NFCException() : base()
        {
        }

        public NFCException(string message) : base(message)
        {
        }

        public NFCException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NFCException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}