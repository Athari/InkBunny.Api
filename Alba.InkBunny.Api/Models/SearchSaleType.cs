using System;

namespace Alba.InkBunny.Api
{
    [Flags]
    public enum SearchSaleType
    {
        None = 0,

        Digital = 1 << 0,
        Print = 1 << 1,

        All = Digital | Print,
    }
}