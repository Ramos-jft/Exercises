using System.Globalization;

namespace Exercises
{
    public class DataTypes
    {
        // Exercise 1 - Write a C# Sharp program that takes three letters and displays them in reverse order.
        public static string ReverseLetters(char letter1, char letter2, char letter3)
        {
            return $"{letter3} {letter2} {letter1}";
        }

        // Exercise 2 - Write a C# Sharp program that takes a number and a width also a number. It then displays a triangle of that width using that number.
        public static string BuildTriangle(int number, int width)
        {
            string result = "";
            int currentWidth = width;

            for (int i = 0; i < width; i++)
            {
                result += new string(char.Parse(number.ToString()), currentWidth);
                if (i < width - 1) result += "\n";
                currentWidth--;
            }

            return result;
        }

        // Exercise 3 - Write a C# Sharp program that takes userid and password as input (string type). After 3 unsuccessful attempts, the user will be rejected.
        public static string Login(string username, string password)
        {
            const string validUsername = "username";
            const string validPassword = "password";

            if (username == validUsername && password == validPassword)
                return "Password entered successfully!";
            else
                return "Login attempt more than three times. Try later!";
        }

        // Exercise 4 - Write a C# Sharp program that takes two numbers as input and performs an operation (+,-,*,x,/) on them and displays the result of that operation.
        public static string CalculateOperation(int firstNumber, char operation, int secondNumber)
        {
            int result = operation switch
            {
                '+' => firstNumber + secondNumber,
                '-' => firstNumber - secondNumber,
                '*' => firstNumber * secondNumber,
                'x' => firstNumber * secondNumber,
                '/' => firstNumber / secondNumber,
            };

            return $"{firstNumber} {operation} {secondNumber} = {result}";
        }

        // Exercise 5 - Write a C# Sharp program that takes the radius of a circle as input and calculates the perimeter and area of the circle.
        public static string CalculateCircleProperties(double radius)
        {
            double perimeter = 2 * Math.PI * radius;
            return $"Perimeter of Circle : {perimeter.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        // Exercise 6 - Write a C# Sharp program to display certain values of the function x = y2 + 2y + 1 (using integer numbers for y, ranging from -5 to +5).
        public static string CalculateFunctionValues()
        {
            string result = "";
            for (int y = -5; y <= 5; y++)
            {
                int x = y * y + 2 * y + 1;
                if (y > -5) result += "\n";
                result += $"y = {y} ; x = ({y})² + 2*({y}) + 1 = {x}";
            }
            return result;
        }

        // Exercise 7 - Write a C# Sharp program that takes distance and time as input and displays speed in kilometres per hour and miles per hour.
        public static string CalculateSpeed(float distance, float hours, float minutes, float seconds)
        {
            float timeSec = (hours * 3600) + (minutes * 60) + seconds;
            float mps = distance / timeSec;
            float kph = (distance / 1000.0f) / (timeSec / 3600.0f);
            float mph = kph / 1.609f;

            return $"Your speed in metres/sec is {mps.ToString(CultureInfo.InvariantCulture)}\n" +
                   $"Your speed in km/h is {kph.ToString(CultureInfo.InvariantCulture)}\n" +
                   $"Your speed in miles/h is {mph.ToString(CultureInfo.InvariantCulture)}";
        }

        // Exercise 8 - Write a C# Sharp program that takes the radius of a sphere as input and calculates and displays the surface and volume of the sphere.
        public static string CalculateSphereProperties(float radius)
        {
            float surfaceArea = 4 * (float)Math.PI * radius * radius;
            float volume = 4f / 3f * (float)Math.PI * radius * radius * radius;

            return $"{surfaceArea.ToString(CultureInfo.InvariantCulture)}\n" +
                   $"{volume.ToString(CultureInfo.InvariantCulture)}";
        }

        // Exercise 9 - Write a C# Sharp program that takes a character as input and checks if it is a vowel, a digit, or any other symbol.
        public static string CheckSymbol(char symbol)
        {
            if (symbol == 'a' || symbol == 'e' || symbol == 'i' || symbol == 'o' || symbol == 'u')
                return "It's a lowercase vowel.";
            else if (symbol >= '0' && symbol <= '9')
                return "It's a digit.";
            else
                return "It's another symbol.";
        }

        // Exercise 10 - Write a C# Sharp program that takes two numbers as input and returns true or false when both numbers are even or odd.
        public static bool AreBothEvenOrOdd(int n1, int n2)
        {
            return (n1 % 2 == 0) && (n2 % 2 == 0);
        }

        // Exercise 11 - Write a C# Sharp program that takes a decimal number as input and displays its equivalent in binary form.
        public static string ConvertToBinary(int number)
        {
            return Convert.ToString(number, 2);
        }
    }
}
