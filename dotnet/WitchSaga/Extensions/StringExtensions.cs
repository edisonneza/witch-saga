namespace WitchSaga.Extensions
{
    public static class StringExtensions
    {
        public static int ToInt(this string value)
        {
            int convertedValue;
            int.TryParse(value, out convertedValue);
            return convertedValue;
        }
    }
}
