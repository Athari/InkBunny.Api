using System.Diagnostics;

namespace Alba.InkBunny.Api.Diagnostics
{
    public static class InkBunnyApiTraceSources
    {
        private const string BaseNamespace = nameof(Alba) + "." + nameof(InkBunny) + "." + nameof(Api);
        public const string NetTraceSourceName = BaseNamespace + "." + nameof(Net);

        private static TraceSource _net;

        public static TraceSource Net => _net ?? (_net = new TraceSource(NetTraceSourceName));
    }
}