namespace WitchSaga.Extensions
{
    public static class IntExtensions
    {
        public static bool IsZeroOrNegative(this int value)
        {
            return value <= 0;
        }
    }
}
