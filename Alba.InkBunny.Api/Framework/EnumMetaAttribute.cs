using System;

namespace Alba.InkBunny.Api.Framework
{
    [AttributeUsage(AttributeTargets.Field)]
    internal class EnumMetaAttribute : Attribute
    {
        public string JsonName { get; set; }
        public string Description { get; set; }
    }
}