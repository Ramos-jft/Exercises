using System;
using System.Text;

namespace Basic
{
    public class Exercise25
    {
        public static string GetOddNumbers()
        {
            StringBuilder sb = new StringBuilder();
            // Adiciona os primeiros 5 números
            for (int i = 1; i <= 9; i += 2)
            {
                sb.AppendLine(i.ToString());
            }
            // Adiciona "..."
            sb.AppendLine("...");
            // Adiciona os últimos 3 números
            for (int i = 95; i <= 99; i += 2)
            {
                sb.AppendLine(i.ToString());
            }
            return sb.ToString();
        }

        public static void PrintOddNumbers()
        {
            Console.WriteLine("Odd numbers from 1 to 99. Prints one number per line.");
            Console.Write(GetOddNumbers());
        }
    }
}