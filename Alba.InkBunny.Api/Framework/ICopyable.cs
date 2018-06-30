namespace Alba.InkBunny.Api.Framework
{
    internal interface ICopyable<in TTo>
    {
        void CopyTo(TTo other);
    }
}