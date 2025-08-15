namespace Basic
{
    public class Exercise18
    {
        public static bool CheckPositiveNegativePair(int first, int second)
        {
            return (first < 0 && second > 0) || (first > 0 && second < 0);
        }
    }
}