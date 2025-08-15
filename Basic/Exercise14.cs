namespace Basic
{
    public class Exercise14
    {
        public static double ConvertToKelvin(double celsius)
        {
            return celsius + 273;
        }

        public static double ConvertToFahrenheit(double celsius)
        {
            return celsius * 9 / 5 + 32;
        }

        public static string GetTemperatureConversions(double celsius)
        {
            return $"Kelvin = {ConvertToKelvin(celsius)}\r\nFahrenheit = {ConvertToFahrenheit(celsius)}";
        }
    }
}
