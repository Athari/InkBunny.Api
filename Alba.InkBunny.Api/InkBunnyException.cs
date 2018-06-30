using System;
using JetBrains.Annotations;

#if !NET_STANDARD_13
using System.Runtime.Serialization;
#endif

namespace Alba.InkBunny.Api
{
    [PublicAPI]
  #if !NET_STANDARD_13
    [Serializable]
  #endif
    public sealed class InkBunnyException : Exception
    {
        public int Code { get; } = -1;

        public InkBunnyException(string message) : base(message)
        { }

        public InkBunnyException(string message, int code) : base(message) => Code = code;

        public InkBunnyException(string message, int code, Exception inner) : base(message, inner) => Code = code;

      #if !NET_STANDARD_13
        private InkBunnyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            Code = info.GetInt32(nameof(Code));
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue(nameof(Code), Code);
            base.GetObjectData(info, context);
        }
      #endif
    }
}