using System;

namespace Basic
{
    public class Exercise39
    {
        public static (int largest, int lowest) FindLargestAndLowest(int num1, int num2, int num3)
        {
            int largest = Math.Max(Math.Max(num1, num2), num3);
            int lowest = Math.Min(Math.Min(num1, num2), num3);

            return (largest, lowest);
        }

        public static string GetComparisonResult(int num1, int num2, int num3)
        {
            var (largest, lowest) = FindLargestAndLowest(num1, num2, num3);
            return $"Largest of three: {largest}\nLowest of three: {lowest}";
        }
    }
}