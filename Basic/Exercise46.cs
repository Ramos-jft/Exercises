using System;

namespace Basic
{
    public class Exercise46
    {
        public static bool CheckFirstOrLast(int[] array, int number)
        {
            return array[0] == number || array[array.Length - 1] == number;
        }

        public static string GetCheckResult(int[] array, int number)
        {
                bool result = CheckFirstOrLast(array, number);
                return $"Input an integer: {number}\n{result}";
        }
    }
}