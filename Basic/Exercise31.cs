using System;
using System.Linq;

namespace Basic
{
    public class Exercise31
    {
        public static int[] MultiplyArrays(int[] array1, int[] array2)
        {
            return array1.Zip(array2, (a, b) => a * b).ToArray();
        }

        public static string GetMultiplicationResult(int[] array1, int[] array2)
        {
                int[] result = MultiplyArrays(array1, array2);
                return $"Array1: [{string.Join(", ", array1)}]\n" +
                       $"Array2: [{string.Join(", ", array2)}]\n" +
                       "Multiply corresponding elements of two arrays:\n" +
                       string.Join(" ", result);
        }
    }
}