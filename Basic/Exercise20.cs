namespace Basic
{
    public class Exercise20
    {
        public static int CalculateDifference(int a, int b)
        {
            int difference = a - b;
            return a > b ? Math.Abs(difference) * 2 : Math.Abs(difference);
        }
    }
}