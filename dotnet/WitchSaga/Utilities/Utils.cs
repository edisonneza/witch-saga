using System.Linq;

namespace WitchSaga.Utilities
{
    public static class Utils
    {
        public static double GetAverage(params double[] values)
        {
            return values.Average();
        }
    }
}
