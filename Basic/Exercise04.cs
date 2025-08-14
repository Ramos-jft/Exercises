using System.Data;

namespace Basic
{
    public static class Exercise04
    {
        public static double Calculate(string operation)
        {
            operation = operation.Replace(" ", "");

            using (DataTable dt = new DataTable())
            {
                var result = dt.Compute(operation, null);
                double resultDouble = Convert.ToDouble(result);
                return Math.Round(resultDouble, 2);
            }
        }
    }
}
