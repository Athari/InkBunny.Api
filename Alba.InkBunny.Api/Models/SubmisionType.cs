using System;
using JetBrains.Annotations;

namespace Alba.InkBunny.Api
{
    [Flags]
    [PublicAPI]
    public enum SubmisionType
    {
        None = 0,

        Picture = 1 << 1,
        Sketch = 1 << 2,
        PictureSeries = 1 << 3,
        Comic = 1 << 4,
        Portfolio = 1 << 5,
        FlashAnimation = 1 << 6,
        FlashInteractive = 1 << 7,
        VideoFeature = 1 << 8,
        VideoAnimation = 1 << 9,
        MusicTrack = 1 << 10,
        MusicAlbum = 1 << 11,
        Writing = 1 << 12,
        CharacterSheet = 1 << 13,
        Photo = 1 << 14,

        All = 0b111111111111110,
    }
}