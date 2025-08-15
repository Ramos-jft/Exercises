namespace Basic
{
    public class Exercise08
    {
        public static string GenerateMultiplicationTable(int number)
        {
            string table = "";
            for (int i = 0; i <= 10; i++)
            {
                table += $"{number} * {i} = {number * i}";
                if (i < 10)
                {
                    table += "\r\n";
                }
            }
            return table;
        }
    }
}
