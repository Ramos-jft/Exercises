using System;
using System.Linq;

namespace Basic
{
    public class Exercise47
    {
        public static int CalculateSum(int[] numbers)
        {
            return numbers.Sum();
        }

        public static string GetSumResult(int[] numbers)
        {          
                int sum = CalculateSum(numbers);
                return $"Array1: [{string.Join(", ", numbers)}]\nSum: {sum}";
        }
    }
}