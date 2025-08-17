using System;

namespace Basic
{
    public class Exercise26
    {
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Sqrt(number);

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }

        public static long SumOfFirst500Primes()
        {
            int count = 0;
            int number = 2;
            long sum = 0;

            while (count < 500)
            {
                if (IsPrime(number))
                {
                    sum += number;
                    count++;
                }
                number++;
            }

            return sum;
        }

        public static string GetPrimeSumResult()
        {
            long sum = SumOfFirst500Primes();
            return $"Sum of the first 500 prime numbers:\n{sum}";
        }
    }
}