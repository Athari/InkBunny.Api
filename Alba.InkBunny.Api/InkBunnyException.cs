using System;
using System.Runtime.Serialization;

namespace Alba.InkBunny.Api
{
    [Serializable]
    public class InkBunnyException : Exception
    {
        public int Code { get; } = -1;

        /*public InkBunnyException()
        { }*/

        public InkBunnyException(string message) : base(message)
        { }

        public InkBunnyException(string message, int code) : base(message) => Code = code;

        //public InkBunnyException(string message, int code, Exception inner) : base(message, inner) => Code = code;

        protected InkBunnyException(SerializationInfo info, StreamingContext context) : base(info, context)
        { }
    }
}