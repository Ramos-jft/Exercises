namespace Basic
{
    public class Exercise10
    {
        public static int CalculateFirstFormula(int x, int y, int z)
        {
            return (x + y) * z;
        }

        public static int CalculateSecondFormula(int x, int y, int z)
        {
            return x * y + y * z;
        }

        public static string GetFormulasOutput(int x, int y, int z)
        {
            return $"Result of specified formulas:\r\n" +
                   $"(x + y).z = {CalculateFirstFormula(x, y, z)}\r\n" +
                   $"x.y + y.z = {CalculateSecondFormula(x, y, z)}";
        }
    }
}
