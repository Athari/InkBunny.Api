using System;
using JetBrains.Annotations;

namespace Alba.InkBunny.Api
{
    [Flags]
    [PublicAPI]
    public enum Rating
    {
        None = 0,

        General = 1 << 0,
        MatureNudity = 1 << 1,
        MatureViolence = 1 << 2,
        AdultSex = 1 << 3,
        AdultViolence = 1 << 4,

        All = General | MatureNudity | MatureViolence | AdultSex | AdultViolence,
    }

    internal static class RatingExts
    {
        public static string ToStringMask(this Rating @this)
        {
            return string.Concat(ToBit(0), ToBit(1), ToBit(2), ToBit(3), ToBit(4)).TrimEnd('0');
            char ToBit(int i) => (@this & (Rating)(1 << i)) != 0 ? '1' : '0';
        }

        public static Rating Parse(string str)
        {
            str = str.PadRight(5, '0');
            return FromBit(0) | FromBit(1) | FromBit(2) | FromBit(3) | FromBit(4);
            Rating FromBit(int i) => str[i] == '1' ? (Rating)(1 << i) : 0;
        }
    }
}