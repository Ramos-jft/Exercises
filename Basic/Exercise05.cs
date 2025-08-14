namespace Basic
{
    public static class Exercise05
    {
        public static void Swap(ref int n1, ref int n2)
        {
            int temp = n1;
            n1 = n2;
            n2 = temp;
        }
    }
}
