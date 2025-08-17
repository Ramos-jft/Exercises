using System;

namespace Basic
{
    public class Exercise49
    {
        public static bool CheckFirstOrLastEqual(int[] array1, int[] array2)
        {
            return array1[0] == array2[0] || array1[array1.Length - 1] == array2[array2.Length - 1];
        }

        public static string GetCheckResult(int[] array1, int[] array2)
        {
                bool result = CheckFirstOrLastEqual(array1, array2);
                return $"Array1: [{string.Join(", ", array1)}]\n" +
                       $"Array2: [{string.Join(", ", array2)}]\n" +
                       $"Check if the first element or the last element of the two arrays are equal:\n" +
                       $"{result}";
        }
    }
}