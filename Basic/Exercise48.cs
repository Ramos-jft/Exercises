using System;

namespace Basic
{
    public class Exercise48
    {
        public static bool CheckFirstLastEqual(int[] array)
        {
            return array[0] == array[array.Length - 1];
        }

        public static string GetCheckResult(int[] array)
        {
            bool result = CheckFirstLastEqual(array);
            return $"Array1: [{string.Join(", ", array)}]\n{result}";
        }
    }
}