using System;

namespace Basic
{
    public class Exercise30
    {
        public static int HexToDecimal(string hex)
        {
            return Convert.ToInt32(hex, 16);
        }

        public static string GetConversionResult(string hex)
        {
            int decimalNumber = HexToDecimal(hex);
            return $"Hexadecimal number: {hex}\nConvert to-\nDecimal number: {decimalNumber}";
        }
    }
}