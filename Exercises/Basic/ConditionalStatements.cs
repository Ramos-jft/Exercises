using System.Globalization;

namespace Exercises
{
    public class ConditionalStatements
    {
        // Exercise 1 - Write a C# Sharp program to accept two integers and check whether they are equal or not.
        public static string CheckEqual(int num1, int num2)
        {
            if (num1 == num2)
                return $"{num1} and {num2} are equal";
            else
                return $"{num1} and {num2} are not equal";
        }

        // Exercise 2 - Write a C# Sharp program to check whether a given number is even or odd.
        public static string CheckEvenOdd(int number)
        {
            if (number % 2 == 0)
                return $"{number} is an even integer";
            else
                return $"{number} is an odd integer";
        }

        // Exercise 3 - Write a C# Sharp program to check whether a given number is positive or negative.
        public static string CheckPositiveNegative(int number)
        {
            if (number >= 0)
                return $"{number} is a positive number";
            else
                return $"{number} is a negative number";
        }

        // Exercise 4 - Write a C# Sharp program to find out whether a given year is a leap year or not.
        public static string CheckLeapYear(int year)
        {
            if (year % 400 == 0)
                return $"{year} is a leap year";
            else if (year % 100 == 0)
                return $"{year} is not a leap year";
            else if (year % 4 == 0)
                return $"{year} is a leap year";
            else
                return $"{year} is not a leap year";
        }

        // Exercise 5 - Write a C# Sharp program to read the age of a candidate and determine whether it is eligible for casting his/her own vote.
        public static string CheckVotingEligibility(int age)
        {
            if (age >= 18)
                return "Congratulation! You are eligible for casting your vote";
            else
                return $"Sorry, You are not eligible to caste your vote.\nYou would be able to caste your vote after {18 - age} year";
        }

        // Exercise 6 - Write a C# Sharp program to read the value of an integer m and display the value of n is 1 when m is larger than 0, 0 when m is 0 and -1 when m is less than 0.
        public static int CalculateN(int m)
        {
            if (m > 0)
                return 1;
            else if (m == 0)
                return 0;
            else
                return -1;
        }

        // Exercise 7 - Write a C# Sharp program to accept a person's height in centimeters and categorize them according to their height.
        public static string CategorizeHeight(float height)
        {
            if (height < 150.0f)
                return "The person is Dwarf";
            else if (height >= 150.0f && height <= 165.0f)
                return "The person is average heighted";
            else if (height >= 165.0f && height <= 195.0f)
                return "The person is taller";
            else
                return "Abnormal height";
        }

        // Exercise 8 - Write a C# Sharp program to find the largest of three numbers.
        public static string FindLargestNumber(int num1, int num2, int num3)
        {
            if (num1 > num2)
            {
                if (num1 > num3)
                    return "The 1st Number is the greatest among three";
                else
                    return "The 3rd Number is the greatest among three";
            }
            else if (num2 > num3)
                return "The 2nd Number is the greatest among three";
            else
                return "The 3rd Number is the greatest among three";
        }

        // Exercise 9 - Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
        public static string DetermineQuadrant(int x, int y)
        {
            if (x > 0 && y > 0)
                return $"The coordinate point ({x},{y}) lies in the First quadrant";
            else if (x < 0 && y > 0)
                return $"The coordinate point ({x},{y}) lies in the Second quadrant";
            else if (x < 0 && y < 0)
                return $"The coordinate point ({x},{y}) lies in the Third quadrant";
            else if (x > 0 && y < 0)
                return $"The coordinate point ({x},{y}) lies in the Fourth quadrant";
            else
                return $"The coordinate point ({x},{y}) lies at the origin";
        }

        // Exercise 10 - Write a C# Sharp program to determine the eligibility for admission to a professional course based on the following criteria:
        public static string CheckAdmissionEligibility(int physics, int chemistry, int math)
        {
            if (math >= 65 && physics >= 55 && chemistry >= 50)
            {
                if ((math + physics + chemistry) >= 180 || (math + physics) >= 140)
                    return "The candidate is eligible for admission";
                else
                    return "The candidate is not eligible";
            }
            else
            {
                return "The candidate is not eligible";
            }
        }

        // Exercise 11 - Write a C# Sharp program to calculate the root of a quadratic equation.
        public static string CalculateQuadraticRoots(int a, int b, int c)
        {
            double discriminant = b * b - 4 * a * c;

            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                return $"Both roots are real and different.\nFirst Root Root1= {x1}\nSecond Root Root2= {x2}";
            }
            else if (discriminant == 0)
            {
                double x1 = -b / (2.0 * a);
                return $"Both roots are equal.\nFirst Root Root1= {x1}\nSecond Root Root2= {x1}";
            }
            else
            {
                return "Roots are imaginary;\nNo Solution.";
            }
        }

        // Exercise 12 - Write a C# Sharp program to read roll no, name and marks of three subjects and calculate the total, percentage and division.
        public static string CalculateStudentResult(int rollNo, string name, int physics, int chemistry, int computerApp)
        {
            var total = physics + chemistry + computerApp;
            var percentage = total / 3.0;

            string division;
            if (percentage >= 60)
                division = "First";
            else if (percentage >= 48)
                division = "Second";
            else if (percentage >= 36)
                division = "Pass";
            else
                division = "Fail";

            return $"Roll No : {rollNo}\nName of Student : {name}\nMarks in Physics : {physics}\nMarks in Chemistry : {chemistry}\nMarks in Computer Application : {computerApp}\nTotal Marks = {total.ToString(CultureInfo.InvariantCulture)}\nPercentage = {percentage.ToString(CultureInfo.InvariantCulture)}\nDivision = {division.ToString(CultureInfo.InvariantCulture)}";
        }

        // Exercise 13 - Write a C# Sharp program to read temperature in centigrade and display a suitable message according to the temperature state below:
        /* Temp < 0 then Freezing weather
        Temp 0-10 then Very Cold weather
        Temp 10-20 then Cold weather
        Temp 20-30 then Normal in Temp
        Temp 30-40 then Its Hot
        Temp >=40 then Its Very Hot*/
        public static string GetTemperatureMessage(int temperature)
        {
            if (temperature < 0)
                return "Freezing weather";
            else if (temperature < 10)
                return "Very cold weather";
            else if (temperature < 20)
                return "Cold weather";
            else if (temperature < 30)
                return "Normal in temp";
            else if (temperature < 40)
                return "It's Hot";
            else
                return "It's very hot";
        }

        // Exercise 14 - Write a C# Sharp program to check whether a triangle is Equilateral, Isosceles or Scalene.
        public static string CheckTriangleType(int side1, int side2, int side3)
        {
            if (side1 == side2 && side2 == side3)
                return "This is an equilateral triangle";
            else if (side1 == side2 || side1 == side3 || side2 == side3)
                return "This is an isosceles triangle";
            else
                return "This is a scalene triangle";
        }

        // Exercise 15 - Write a C# Sharp program to check whether a triangle can be formed by the given angles value.
        public static string CheckTriangleValidity(int angle1, int angle2, int angle3)
        {
            var sum = angle1 + angle2 + angle3;

            if (sum == 180)
                return "The triangle is valid";
            else
                return "The triangle is not valid";
        }

        // Exercise 16 - Write a C# Sharp program to check whether an alphabet letter is a vowel or a consonant.
        public static string CheckVowelOrConsonant(char ch)
        {
            var lowerCh = char.ToLower(ch);

            if (lowerCh == 'a' || lowerCh == 'e' || lowerCh == 'i' || lowerCh == 'o' || lowerCh == 'u')
                return "The Alphabet is vowel";
            else
                return "The Alphabet is consonant";
        }

        // Exercise 17 - Write a C# Sharp program to calculate profit and loss on a transaction.
        public static string CalculateProfitLoss(int costPrice, int sellingPrice)
        {
            if (sellingPrice > costPrice)
            {
                var profit = sellingPrice - costPrice;
                return $"You can book your profit amount : {profit}";
            }
            else if (costPrice > sellingPrice)
            {
                var loss = costPrice - sellingPrice;
                return $"You got a loss of amount : {loss}";
            }
            else
            {
                return "You are running in no profit no loss condition";
            }
        }

        /*Exercise 18 - Write a C# Sharp program to calculate and print the electricity bill of a customer. From the keyboard, the customer's name, ID, 
        and unit consumed should be taken and displayed along with the total amount due.
        The charge are as follow :

        Unit Charge/unit
        upto 199 Data Analytics Service	@1.20
        200 and above but less than 400	@1.50
        400 and above but less than 600	@1.80
        600 and above	@2.00
        If bill exceeds Rs. 400 then a surcharge of 15% will be charged and the minimum bill should be of Rs. 100/-*/
        public static string CalculateElectricityBill(int customerId, string customerName, int unitsConsumed)
        {
            double chargePerUnit;

            if (unitsConsumed < 200)
                chargePerUnit = 1.20;
            else if (unitsConsumed < 400)
                chargePerUnit = 1.50;
            else if (unitsConsumed < 600)
                chargePerUnit = 1.80;
            else
                chargePerUnit = 2.00;

            var amountCharges = unitsConsumed * chargePerUnit;
            var surchargeAmount = amountCharges > 400 ? amountCharges * 0.15 : 0;
            var netAmount = amountCharges + surchargeAmount;

            if (netAmount < 100)
                netAmount = 100;

            return $"Customer IDNO :{customerId}\nCustomer Name :{customerName}\nunit Consumed :{unitsConsumed}\nAmount Charges @Rs. {chargePerUnit.ToString(CultureInfo.InvariantCulture)} per unit : {amountCharges.ToString(CultureInfo.InvariantCulture)}\nSurchage Amount : {surchargeAmount.ToString(CultureInfo.InvariantCulture)}\nNet Amount Paid By the Customer : {netAmount.ToString(CultureInfo.InvariantCulture)}";
        }

        /* Exercise 19 - Write a program in C# Sharp to accept a grade and declare the equivalent description:
        Grade	Description
        E	Excellent
        V	Very Good
        G	Good
        A	Average
        F	Fail */
        public static string GetGradeDescription(char grade)
        {
            var upperGrade = char.ToUpper(grade);

            switch (upperGrade)
            {
                case 'E':
                    return "Excellent";
                case 'V':
                    return "Very Good";
                case 'G':
                    return "Good";
                case 'A':
                    return "Average";
                case 'F':
                    return "Fail";
                default:
                    return "Invalid Grade Found";
            }
        }

        // Exercise 20 - Write a C# Sharp program to read any day number as an integer and display the name of the day as a word.
        public static string GetDayName(int dayNumber)
        {
            switch (dayNumber)
            {
                case 1:
                    return "Monday";
                case 2:
                    return "Tuesday";
                case 3:
                    return "Wednesday";
                case 4:
                    return "Thursday";
                case 5:
                    return "Friday";
                case 6:
                    return "Saturday";
                case 7:
                    return "Sunday";
                default:
                    return "Invalid day number";
            }
        }

        // Exercise 21 - Write a program in C# Sharp to read any digit, display in the word.
        public static string GetDigitWord(int digit)
        {
            switch (digit)
            {
                case 0:
                    return "Zero";
                case 1:
                    return "One";
                case 2:
                    return "Two";
                case 3:
                    return "Three";
                case 4:
                    return "Four";
                case 5:
                    return "Five";
                case 6:
                    return "Six";
                case 7:
                    return "Seven";
                case 8:
                    return "Eight";
                case 9:
                    return "Nine";
                default:
                    return "Invalid digit";
            }
        }

        // Exercise 22 - Write C# Sharp program to read any Month Number in integer and display Month name.
        public static string GetMonthName(int monthNumber)
        {
            switch (monthNumber)
            {
                case 1:
                    return "January";
                case 2:
                    return "February";
                case 3:
                    return "March";
                case 4:
                    return "April";
                case 5:
                    return "May";
                case 6:
                    return "June";
                case 7:
                    return "July";
                case 8:
                    return "August";
                case 9:
                    return "September";
                case 10:
                    return "October";
                case 11:
                    return "November";
                case 12:
                    return "December";
                default:
                    return "Invalid Month number";
            }
        }

        // Exercise 23 - Write a program in C# Sharp to read any Month Number in integer and display the number of days for this month.
        public static string GetMonthDays(int monthNumber)
        {
            switch (monthNumber)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return "Month have 31 days";
                case 2:
                    return "The 2nd month is February and has 28 days. In leap years, February has 29 days";
                case 4:
                case 6:
                case 9:
                case 11:
                    return "Month have 30 days";
                default:
                    return "Invalid Month number";
            }
        }

        // Exercise 24 - Write a C# Sharp program that calculates the area of geometrical shapes using a menu-driven approach.
        public static double CalculateArea(int choice, int[] dimensions)
        {
            switch (choice)
            {
                case 1: // Circle
                    var radius = dimensions[0];
                    return Math.PI * radius * radius;
                case 2: // Rectangle
                    var length = dimensions[0];
                    var width = dimensions[1];
                    return length * width;
                case 3: // Triangle
                    var baseLength = dimensions[0];
                    var height = dimensions[1];
                    return 0.5 * baseLength * height;
                default:
                    return 0;
            }
        }

        // Exercise 25 - Write a program in C# Sharp which is a menu-driven program to perform simple calculations.
        public static string PerformCalculation(int choice, int num1, int num2)
        {
            switch (choice)
            {
                case 1: // Addition
                    return $"The Addition of {num1} and {num2} is: {num1 + num2}";
                case 2: // Subtraction
                    return $"The Subtraction of {num1} and {num2} is: {num1 - num2}";
                case 3: // Multiplication
                    return $"The Multiplication of {num1} and {num2} is: {num1 * num2}";
                case 4: // Division
                    if (num2 == 0)
                        return "The second integer is zero. Divide by zero";
                    else
                        return $"The Division of {num1} and {num2} is: {num1 / num2}";
                case 5: // Exit
                    return "Exit";
                default:
                    return "Input correct option";
            }
        }
    }
}
