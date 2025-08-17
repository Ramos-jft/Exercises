using System;

namespace Basic
{
    public class Exercise50
    {
        public static int[] RotateLeft(int[] array)
        {
            return new int[] { array[1], array[2], array[0] };
        }

        public static string GetRotatedResult(int[] array)
        {
            int[] rotated = RotateLeft(array);
            return $"Array1: [{string.Join(", ", array)}]\n" +
                   $"After rotating array becomes: [{string.Join(", ", rotated)}]";
        }
    }
}