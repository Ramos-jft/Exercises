using System;
using System.Linq;

namespace Basic
{
    public class Exercise45
    {
        public static int CountNumberInArray(int[] numbers, int target)
        {
            if (numbers == null || numbers.Length == 0)
                return 0;

            return numbers.Count(n => n == target);
        }

        public static string GetCountResult(int[] numbers, int target)
        {
            int count = CountNumberInArray(numbers, target);
            return $"Number of {target} present in the said array: {count}";
        }
    }
}