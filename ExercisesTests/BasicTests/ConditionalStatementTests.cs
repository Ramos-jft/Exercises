using Exercises;
using FluentAssertions;
using System.Runtime.InteropServices;

namespace ExercisesTests;

[TestClass]
public class ConditionalStatementTests
{
    // Exercise 1 - Write a C# Sharp program to accept two integers and check whether they are equal or not.
    [TestMethod]
    public void CheckEqual_WhenNumbersAreEqual_ReturnsEqualMessage()
    {
        // Arrange
        var num1 = 5;
        var num2 = 5;
        var expected = "5 and 5 are equal";

        // Act
        var result = ConditionalStatements.CheckEqual(num1, num2);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void CheckEqual_WhenNumbersAreNotEqual_ReturnsNotEqualMessage()
    {
        // Arrange
        var num1 = 20;
        var num2 = 10;
        var expected = "20 and 10 are not equal";

        // Act
        var result = ConditionalStatements.CheckEqual(num1, num2);

        // Assert
        result.Should().Be(expected);
    }

    // Exercise 2 - Write a C# Sharp program to check whether a given number is even or odd.
    [TestMethod]
    public void CheckEvenOdd_WhenNumberIsOdd_ReturnsOddMessage()
    {
        // Arrange
        var number = 15;
        var expected = "15 is an odd integer";

        // Act
        var result = ConditionalStatements.CheckEvenOdd(number);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void CheckEvenOdd_WhenNumberIsEven_ReturnsEvenMessage()
    {
        // Arrange
        var number = 10;
        var expected = "10 is an even integer";

        // Act
        var result = ConditionalStatements.CheckEvenOdd(number);

        // Assert
        result.Should().Be(expected);
    }

    // Exercise 3 - Write a C# Sharp program to check whether a given number is positive or negative.
    [TestMethod]
    public void CheckPositiveNegative_WhenNumberIsPositive_ReturnsPositiveMessage()
    {
        // Arrange
        var number = 14;
        var expected = "14 is a positive number";

        // Act
        var result = ConditionalStatements.CheckPositiveNegative(number);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void CheckPositiveNegative_WhenNumberIsNegative_ReturnsNegativeMessage()
    {
        // Arrange
        var number = -10;
        var expected = "-10 is a negative number";

        // Act
        var result = ConditionalStatements.CheckPositiveNegative(number);

        // Assert
        result.Should().Be(expected);
    }

    // Exercise 4 - Write a C# Sharp program to find out whether a given year is a leap year or not.
    [TestMethod]
    public void CheckLeapYear_WhenYearIsLeap_ReturnsLeapYearMessage()
    {
        // Arrange
        var year = 2016;
        var expected = "2016 is a leap year";

        // Act
        var result = ConditionalStatements.CheckLeapYear(year);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void CheckLeapYear_WhenYearIsNotLeap_ReturnsNotLeapYearMessage()
    {
        // Arrange
        var year = 2017;
        var expected = "2017 is not a leap year";

        // Act
        var result = ConditionalStatements.CheckLeapYear(year);

        // Assert
        result.Should().Be(expected);
    }

    // Exercise 5 - Write a C# Sharp program to read the age of a candidate and determine whether it is eligible for casting his/her own vote.
    [TestMethod]
    public void CheckVotingEligibility_WhenAgeIsEligible_ReturnsEligibleMessage()
    {
        // Arrange
        var age = 21;
        var expected = "Congratulation! You are eligible for casting your vote";

        // Act
        var result = ConditionalStatements.CheckVotingEligibility(age);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void CheckVotingEligibility_WhenAgeIsNotEligible_ReturnsNotEligibleMessage()
    {
        // Arrange
        var age = 16;
        var expected = "Sorry, You are not eligible to caste your vote.\nYou would be able to caste your vote after 2 year";

        // Act
        var result = ConditionalStatements.CheckVotingEligibility(age);

        // Assert
        result.Should().Be(expected);
    }

    // Exercise 6 - Write a C# Sharp program to read the value of an integer m and display the value of n is 1 when m is larger than 0, 0 when m is 0 and -1 when m is less than 0.
    [TestMethod]
    public void CalculateN_WhenMLessThanZero_ReturnsMinusOne()
    {
        // Arrange
        var m = -5;
        var expected = -1;

        // Act
        var result = ConditionalStatements.CalculateN(m);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void CalculateN_WhenMEqualsZero_ReturnsZero()
    {
        // Arrange
        var m = 0;
        var expected = 0;

        // Act
        var result = ConditionalStatements.CalculateN(m);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void CalculateN_WhenMGreaterThanZero_ReturnsOne()
    {
        // Arrange
        var m = 5;
        var expected = 1;

        // Act
        var result = ConditionalStatements.CalculateN(m);

        // Assert
        result.Should().Be(expected);
    }

    // Exercise 7 - Write a C# Sharp program to accept a person's height in centimeters and categorize them according to their height.
    [TestMethod]
    public void CategorizeHeight_WhenHeightLessThan150_ReturnsDwarf()
    {
        // Arrange
        var height = 135f;
        var expected = "The person is Dwarf";

        // Act
        var result = ConditionalStatements.CategorizeHeight(height);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void CategorizeHeight_WhenHeightBetween150And165_ReturnsAverageHeighted()
    {
        // Arrange
        var height = 160f;
        var expected = "The person is average heighted";

        // Act
        var result = ConditionalStatements.CategorizeHeight(height);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void CategorizeHeight_WhenHeightBetween165And195_ReturnsTaller()
    {
        // Arrange
        var height = 190f;
        var expected = "The person is taller";

        // Act
        var result = ConditionalStatements.CategorizeHeight(height);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void CategorizeHeight_WhenHeightAbove195_ReturnsAbnormalHeight()
    {
        // Arrange
        var height = 200f;
        var expected = "Abnormal height";

        // Act
        var result = ConditionalStatements.CategorizeHeight(height);

        // Assert
        result.Should().Be(expected);
    }

    // Exercise 8 - Write a C# Sharp program to find the largest of three numbers.
    [TestMethod]
    public void FindLargestNumber_WhenSecondNumberIsLargest_ReturnsSecondNumberMessage()
    {
        // Arrange
        var num1 = 25;
        var num2 = 63;
        var num3 = 10;
        var expected = "The 2nd Number is the greatest among three";

        // Act
        var result = ConditionalStatements.FindLargestNumber(num1, num2, num3);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void FindLargestNumber_WhenFirstNumberIsLargest_ReturnsFirstNumberMessage()
    {
        // Arrange
        var num1 = 100;
        var num2 = 50;
        var num3 = 75;
        var expected = "The 1st Number is the greatest among three";

        // Act
        var result = ConditionalStatements.FindLargestNumber(num1, num2, num3);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void FindLargestNumber_WhenThirdNumberIsLargest_ReturnsThirdNumberMessage()
    {
        // Arrange
        var num1 = 30;
        var num2 = 40;
        var num3 = 90;
        var expected = "The 3rd Number is the greatest among three";

        // Act
        var result = ConditionalStatements.FindLargestNumber(num1, num2, num3);

        // Assert
        result.Should().Be(expected);
    }

    // Exercise 9 - Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
    [TestMethod]
    public void DetermineQuadrant_WhenFirstQuadrant_ReturnsFirstQuadrantMessage()
    {
        // Arrange
        var x = 7;
        var y = 9;
        var expected = "The coordinate point (7,9) lies in the First quadrant";

        // Act
        var result = ConditionalStatements.DetermineQuadrant(x, y);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void DetermineQuadrant_WhenSecondQuadrant_ReturnsSecondQuadrantMessage()
    {
        // Arrange
        var x = -5;
        var y = 3;
        var expected = "The coordinate point (-5,3) lies in the Second quadrant";

        // Act
        var result = ConditionalStatements.DetermineQuadrant(x, y);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void DetermineQuadrant_WhenThirdQuadrant_ReturnsThirdQuadrantMessage()
    {
        // Arrange
        var x = -4;
        var y = -6;
        var expected = "The coordinate point (-4,-6) lies in the Third quadrant";

        // Act
        var result = ConditionalStatements.DetermineQuadrant(x, y);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void DetermineQuadrant_WhenFourthQuadrant_ReturnsFourthQuadrantMessage()
    {
        // Arrange
        var x = 8;
        var y = -2;
        var expected = "The coordinate point (8,-2) lies in the Fourth quadrant";

        // Act
        var result = ConditionalStatements.DetermineQuadrant(x, y);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void DetermineQuadrant_WhenOrigin_ReturnsOriginMessage()
    {
        // Arrange
        var x = 0;
        var y = 0;
        var expected = "The coordinate point (0,0) lies at the origin";

        // Act
        var result = ConditionalStatements.DetermineQuadrant(x, y);

        // Assert
        result.Should().Be(expected);
    }

    // Exercise 10 - Write a C# Sharp program to determine the eligibility for admission to a professional course based on the following criteria:
    [TestMethod]
    public void CheckAdmissionEligibility_WhenEligible_ReturnsEligibleMessage()
    {
        // Arrange
        var physics = 65;
        var chemistry = 51;
        var math = 72;
        var expected = "The candidate is eligible for admission";

        // Act
        var result = ConditionalStatements.CheckAdmissionEligibility(physics, chemistry, math);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void CheckAdmissionEligibility_WhenNotEligible_ReturnsNotEligibleMessage()
    {
        // Arrange
        var physics = 50;
        var chemistry = 50;
        var math = 60;
        var expected = "The candidate is not eligible";

        // Act
        var result = ConditionalStatements.CheckAdmissionEligibility(physics, chemistry, math);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void CheckAdmissionEligibility_WhenTotalMeetsCriteria_ReturnsEligibleMessage()
    {
        // Arrange
        var physics = 55;
        var chemistry = 50;
        var math = 65;
        var expected = "The candidate is not eligible";

        // Act
        var result = ConditionalStatements.CheckAdmissionEligibility(physics, chemistry, math);

        // Assert
        result.Should().Be(expected);
    }

    // Exercise 11 - Write a C# Sharp program to calculate the root of a quadratic equation.
    [TestMethod]
    public void CalculateQuadraticRoots_WhenImaginaryRoots_ReturnsImaginaryMessage()
    {
        // Arrange
        var a = 1;
        var b = 5;
        var c = 7;
        var expected = "Roots are imaginary;\nNo Solution.";

        // Act
        var result = ConditionalStatements.CalculateQuadraticRoots(a, b, c);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void CalculateQuadraticRoots_WhenEqualRoots_ReturnsEqualRootsMessage()
    {
        // Arrange
        var a = 1;
        var b = 2;
        var c = 1;
        var expected = "Both roots are equal.\nFirst Root Root1= -1\nSecond Root Root2= -1";

        // Act
        var result = ConditionalStatements.CalculateQuadraticRoots(a, b, c);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void CalculateQuadraticRoots_WhenRealDifferentRoots_ReturnsRealRootsMessage()
    {
        // Arrange
        var a = 1;
        var b = -3;
        var c = 2;
        var expected = "Both roots are real and different.\nFirst Root Root1= 2\nSecond Root Root2= 1";

        // Act
        var result = ConditionalStatements.CalculateQuadraticRoots(a, b, c);

        // Assert
        result.Should().Be(expected);
    }

    // Exercise 12 - Write a C# Sharp program to read roll no, name and marks of three subjects and calculate the total, percentage and division.
    [TestMethod]
    public void CalculateStudentResult_WhenFirstDivision_ReturnsFirstDivisionResult()
    {
        // Arrange
        var rollNo = 784;
        var name = "James";
        var physics = 70;
        var chemistry = 80;
        var computerApp = 90;
        var expected = "Roll No : 784\nName of Student : James\nMarks in Physics : 70\nMarks in Chemistry : 80\nMarks in Computer Application : 90\nTotal Marks = 240\nPercentage = 80\nDivision = First";

        // Act
        var result = ConditionalStatements.CalculateStudentResult(rollNo, name, physics, chemistry, computerApp);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void CalculateStudentResult_WhenSecondDivision_ReturnsSecondDivisionResult()
    {
        // Arrange
        var rollNo = 10;
        var name = "john smith";
        var physics = 50;
        var chemistry = 46;
        var computerApp = 64;
        var expected = "Roll No : 10\nName of Student : john smith\nMarks in Physics : 50\nMarks in Chemistry : 46\nMarks in Computer Application : 64\nTotal Marks = 160\nPercentage = 53.333333333333336\nDivision = Second";

        // Act
        var result = ConditionalStatements.CalculateStudentResult(rollNo, name, physics, chemistry, computerApp);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void CalculateStudentResult_WhenPassDivision_ReturnsPassDivisionResult()
    {
        // Arrange
        var rollNo = 15;
        var name = "Test Student";
        var physics = 40;
        var chemistry = 38;
        var computerApp = 42;
        var expected = "Roll No : 15\nName of Student : Test Student\nMarks in Physics : 40\nMarks in Chemistry : 38\nMarks in Computer Application : 42\nTotal Marks = 120\nPercentage = 40\nDivision = Pass";

        // Act
        var result = ConditionalStatements.CalculateStudentResult(rollNo, name, physics, chemistry, computerApp);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void CalculateStudentResult_WhenFail_ReturnsFailResult()
    {
        // Arrange
        var rollNo = 20;
        var name = "Fail Student";
        var physics = 30;
        var chemistry = 25;
        var computerApp = 35;
        var expected = "Roll No : 20\nName of Student : Fail Student\nMarks in Physics : 30\nMarks in Chemistry : 25\nMarks in Computer Application : 35\nTotal Marks = 90\nPercentage = 30\nDivision = Fail";

        // Act
        var result = ConditionalStatements.CalculateStudentResult(rollNo, name, physics, chemistry, computerApp);

        // Assert
        result.Should().Be(expected);
    }

    // Exercise 13 - Write a C# Sharp program to read temperature in centigrade and display a suitable message according to the temperature state below:
    /* Temp < 0 then Freezing weather
    Temp 0-10 then Very Cold weather
    Temp 10-20 then Cold weather
    Temp 20-30 then Normal in Temp
    Temp 30-40 then Its Hot
    Temp >=40 then Its Very Hot*/
    [TestMethod]
    public void GetTemperatureMessage_WhenVeryHot_ReturnsVeryHotMessage()
    {
        // Arrange
        var temperature = 42;
        var expected = "It's very hot";

        // Act
        var result = ConditionalStatements.GetTemperatureMessage(temperature);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void GetTemperatureMessage_WhenHot_ReturnsHotMessage()
    {
        // Arrange
        var temperature = 35;
        var expected = "It's Hot";

        // Act
        var result = ConditionalStatements.GetTemperatureMessage(temperature);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void GetTemperatureMessage_WhenNormal_ReturnsNormalMessage()
    {
        // Arrange
        var temperature = 25;
        var expected = "Normal in temp";

        // Act
        var result = ConditionalStatements.GetTemperatureMessage(temperature);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void GetTemperatureMessage_WhenCold_ReturnsColdMessage()
    {
        // Arrange
        var temperature = 15;
        var expected = "Cold weather";

        // Act
        var result = ConditionalStatements.GetTemperatureMessage(temperature);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void GetTemperatureMessage_WhenVeryCold_ReturnsVeryColdMessage()
    {
        // Arrange
        var temperature = 5;
        var expected = "Very cold weather";

        // Act
        var result = ConditionalStatements.GetTemperatureMessage(temperature);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void GetTemperatureMessage_WhenFreezing_ReturnsFreezingMessage()
    {
        // Arrange
        var temperature = -5;
        var expected = "Freezing weather";

        // Act
        var result = ConditionalStatements.GetTemperatureMessage(temperature);

        // Assert
        result.Should().Be(expected);
    }

    // Exercise 14 - Write a C# Sharp program to check whether a triangle is Equilateral, Isosceles or Scalene.
    [TestMethod]
    public void CheckTriangleType_WhenIsosceles_ReturnsIsoscelesMessage()
    {
        // Arrange
        var side1 = 50;
        var side2 = 50;
        var side3 = 60;
        var expected = "This is an isosceles triangle";

        // Act
        var result = ConditionalStatements.CheckTriangleType(side1, side2, side3);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void CheckTriangleType_WhenEquilateral_ReturnsEquilateralMessage()
    {
        // Arrange
        var side1 = 40;
        var side2 = 40;
        var side3 = 40;
        var expected = "This is an equilateral triangle";

        // Act
        var result = ConditionalStatements.CheckTriangleType(side1, side2, side3);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void CheckTriangleType_WhenScalene_ReturnsScaleneMessage()
    {
        // Arrange
        var side1 = 30;
        var side2 = 40;
        var side3 = 50;
        var expected = "This is a scalene triangle";

        // Act
        var result = ConditionalStatements.CheckTriangleType(side1, side2, side3);

        // Assert
        result.Should().Be(expected);
    }

    // Exercise 15 - Write a C# Sharp program to check whether a triangle can be formed by the given angles value.
    [TestMethod]
    public void CheckTriangleValidity_WhenInvalid_ReturnsNotValidMessage()
    {
        // Arrange
        var angle1 = 40;
        var angle2 = 55;
        var angle3 = 65;
        var expected = "The triangle is not valid";

        // Act
        var result = ConditionalStatements.CheckTriangleValidity(angle1, angle2, angle3);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void CheckTriangleValidity_WhenValid_ReturnsValidMessage()
    {
        // Arrange
        var angle1 = 90;
        var angle2 = 45;
        var angle3 = 45;
        var expected = "The triangle is valid";

        // Act
        var result = ConditionalStatements.CheckTriangleValidity(angle1, angle2, angle3);

        // Assert
        result.Should().Be(expected);
    }

    // Exercise 16 - Write a C# Sharp program to check whether an alphabet letter is a vowel or a consonant.
    [TestMethod]
    public void CheckVowelOrConsonant_WhenConsonant_ReturnsConsonantMessage()
    {
        // Arrange
        var ch = 'k';
        var expected = "The Alphabet is consonant";

        // Act
        var result = ConditionalStatements.CheckVowelOrConsonant(ch);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void CheckVowelOrConsonant_WhenVowel_ReturnsVowelMessage()
    {
        // Arrange
        var ch = 'A';
        var expected = "The Alphabet is vowel";

        // Act
        var result = ConditionalStatements.CheckVowelOrConsonant(ch);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void CheckVowelOrConsonant_WhenLowerCaseVowel_ReturnsVowelMessage()
    {
        // Arrange
        var ch = 'e';
        var expected = "The Alphabet is vowel";

        // Act
        var result = ConditionalStatements.CheckVowelOrConsonant(ch);

        // Assert
        result.Should().Be(expected);
    }

    // Exercise 17 - Write a C# Sharp program to calculate profit and loss on a transaction.
    [TestMethod]
    public void CalculateProfitLoss_WhenProfit_ReturnsProfitMessage()
    {
        // Arrange
        var costPrice = 500;
        var sellingPrice = 700;
        var expected = "You can book your profit amount : 200";

        // Act
        var result = ConditionalStatements.CalculateProfitLoss(costPrice, sellingPrice);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void CalculateProfitLoss_WhenLoss_ReturnsLossMessage()
    {
        // Arrange
        var costPrice = 700;
        var sellingPrice = 500;
        var expected = "You got a loss of amount : 200";

        // Act
        var result = ConditionalStatements.CalculateProfitLoss(costPrice, sellingPrice);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void CalculateProfitLoss_WhenBreakEven_ReturnsNoProfitNoLossMessage()
    {
        // Arrange
        var costPrice = 500;
        var sellingPrice = 500;
        var expected = "You are running in no profit no loss condition";

        // Act
        var result = ConditionalStatements.CalculateProfitLoss(costPrice, sellingPrice);

        // Assert
        result.Should().Be(expected);
    }

    /*Exercise 18 - Write a C# Sharp program to calculate and print the electricity bill of a customer. From the keyboard, the customer's name, ID, and unit consumed should be taken and displayed along with the total amount due.
    The charge are as follow :

    Unit Charge/unit
    upto 199 Data Analytics Service	@1.20
    200 and above but less than 400	@1.50
    400 and above but less than 600	@1.80
    600 and above	@2.00
    If bill exceeds Rs. 400 then a surcharge of 15% will be charged and the minimum bill should be of Rs. 100/-*/
    [TestMethod]
    public void CalculateElectricityBill_WhenHighConsumption_ReturnsBillWithSurcharge()
    {
        // Arrange
        var customerId = 1001;
        var customerName = "James";
        var unitsConsumed = 800;
        var expected = "Customer IDNO :1001\nCustomer Name :James\nunit Consumed :800\nAmount Charges @Rs. 2 per unit : 1600\nSurchage Amount : 240\nNet Amount Paid By the Customer : 1840";

        // Act
        var result = ConditionalStatements.CalculateElectricityBill(customerId, customerName, unitsConsumed);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void CalculateElectricityBill_WhenLowConsumption_ReturnsBillWithoutSurcharge()
    {
        // Arrange
        var customerId = 1002;
        var customerName = "John";
        var unitsConsumed = 150;
        var expected = "Customer IDNO :1002\nCustomer Name :John\nunit Consumed :150\nAmount Charges @Rs. 1.2 per unit : 180\nSurchage Amount : 0\nNet Amount Paid By the Customer : 180";

        // Act
        var result = ConditionalStatements.CalculateElectricityBill(customerId, customerName, unitsConsumed);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void CalculateElectricityBill_WhenMinimumBill_ReturnsMinimumAmount()
    {
        // Arrange
        var customerId = 1003;
        var customerName = "Test";
        var unitsConsumed = 50;
        var expected = "Customer IDNO :1003\nCustomer Name :Test\nunit Consumed :50\nAmount Charges @Rs. 1.2 per unit : 60\nSurchage Amount : 0\nNet Amount Paid By the Customer : 100";

        // Act
        var result = ConditionalStatements.CalculateElectricityBill(customerId, customerName, unitsConsumed);

        // Assert
        result.Should().Be(expected);
    }

    /* Exercise 19 - Write a program in C# Sharp to accept a grade and declare the equivalent description:
    Grade	Description
    E	Excellent
    V	Very Good
    G	Good
    A	Average
    F	Fail */
    [TestMethod]
    public void GetGradeDescription_WhenAverageGrade_ReturnsAverage()
    {
        // Arrange
        var grade = 'a';
        var expected = "Average";

        // Act
        var result = ConditionalStatements.GetGradeDescription(grade);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void GetGradeDescription_WhenVeryGoodGrade_ReturnsVeryGood()
    {
        // Arrange
        var grade = 'V';
        var expected = "Very Good";

        // Act
        var result = ConditionalStatements.GetGradeDescription(grade);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void GetGradeDescription_WhenExcellentGrade_ReturnsExcellent()
    {
        // Arrange
        var grade = 'E';
        var expected = "Excellent";

        // Act
        var result = ConditionalStatements.GetGradeDescription(grade);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void GetGradeDescription_WhenGoodGrade_ReturnsGood()
    {
        // Arrange
        var grade = 'G';
        var expected = "Good";

        // Act
        var result = ConditionalStatements.GetGradeDescription(grade);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void GetGradeDescription_WhenFailGrade_ReturnsFail()
    {
        // Arrange
        var grade = 'F';
        var expected = "Fail";

        // Act
        var result = ConditionalStatements.GetGradeDescription(grade);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void GetGradeDescription_WhenInvalidGrade_ReturnsInvalid()
    {
        // Arrange
        var grade = 'X';
        var expected = "Invalid Grade Found";

        // Act
        var result = ConditionalStatements.GetGradeDescription(grade);

        // Assert
        result.Should().Be(expected);
    }

    // Exercise 20 - Write a C# Sharp program to read any day number as an integer and display the name of the day as a word.
    [TestMethod]
    public void GetDayName_WhenThursday_ReturnsThursday()
    {
        // Arrange
        var dayNumber = 4;
        var expected = "Thursday";

        // Act
        var result = ConditionalStatements.GetDayName(dayNumber);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void GetDayName_WhenFriday_ReturnsFriday()
    {
        // Arrange
        var dayNumber = 5;
        var expected = "Friday";

        // Act
        var result = ConditionalStatements.GetDayName(dayNumber);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void GetDayName_WhenMonday_ReturnsMonday()
    {
        // Arrange
        var dayNumber = 1;
        var expected = "Monday";

        // Act
        var result = ConditionalStatements.GetDayName(dayNumber);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void GetDayName_WhenSunday_ReturnsSunday()
    {
        // Arrange
        var dayNumber = 7;
        var expected = "Sunday";

        // Act
        var result = ConditionalStatements.GetDayName(dayNumber);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void GetDayName_WhenInvalidDay_ReturnsInvalid()
    {
        // Arrange
        var dayNumber = 8;
        var expected = "Invalid day number";

        // Act
        var result = ConditionalStatements.GetDayName(dayNumber);

        // Assert
        result.Should().Be(expected);
    }

    // Exercise 21 - Write a program in C# Sharp to read any digit, display in the word.
    [TestMethod]
    public void GetDigitWord_WhenFour_ReturnsFour()
    {
        // Arrange
        var digit = 4;
        var expected = "Four";

        // Act
        var result = ConditionalStatements.GetDigitWord(digit);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void GetDigitWord_WhenEight_ReturnsEight()
    {
        // Arrange
        var digit = 8;
        var expected = "Eight";

        // Act
        var result = ConditionalStatements.GetDigitWord(digit);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void GetDigitWord_WhenZero_ReturnsZero()
    {
        // Arrange
        var digit = 0;
        var expected = "Zero";

        // Act
        var result = ConditionalStatements.GetDigitWord(digit);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void GetDigitWord_WhenNine_ReturnsNine()
    {
        // Arrange
        var digit = 9;
        var expected = "Nine";

        // Act
        var result = ConditionalStatements.GetDigitWord(digit);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void GetDigitWord_WhenInvalidDigit_ReturnsInvalid()
    {
        // Arrange
        var digit = 10;
        var expected = "Invalid digit";

        // Act
        var result = ConditionalStatements.GetDigitWord(digit);

        // Assert
        result.Should().Be(expected);
    }

    // Exercise 22 - Write C# Sharp program to read any Month Number in integer and display Month name.
    [TestMethod]
    public void GetMonthName_WhenApril_ReturnsApril()
    {
        // Arrange
        var monthNumber = 4;
        var expected = "April";

        // Act
        var result = ConditionalStatements.GetMonthName(monthNumber);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void GetMonthName_WhenFebruary_ReturnsFebruary()
    {
        // Arrange
        var monthNumber = 2;
        var expected = "February";

        // Act
        var result = ConditionalStatements.GetMonthName(monthNumber);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void GetMonthName_WhenDecember_ReturnsDecember()
    {
        // Arrange
        var monthNumber = 12;
        var expected = "December";

        // Act
        var result = ConditionalStatements.GetMonthName(monthNumber);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void GetMonthName_WhenInvalidMonth_ReturnsInvalid()
    {
        // Arrange
        var monthNumber = 13;
        var expected = "Invalid Month number";

        // Act
        var result = ConditionalStatements.GetMonthName(monthNumber);

        // Assert
        result.Should().Be(expected);
    }

    // Exercise 23 - Write a program in C# Sharp to read any Month Number in integer and display the number of days for this month.
    [TestMethod]
    public void GetMonthDays_WhenJuly_Returns31Days()
    {
        // Arrange
        var monthNumber = 7;
        var expected = "Month have 31 days";

        // Act
        var result = ConditionalStatements.GetMonthDays(monthNumber);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void GetMonthDays_WhenFebruary_Returns28DaysWithLeapInfo()
    {
        // Arrange
        var monthNumber = 2;
        var expected = "The 2nd month is February and has 28 days. In leap years, February has 29 days";

        // Act
        var result = ConditionalStatements.GetMonthDays(monthNumber);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void GetMonthDays_WhenApril_Returns30Days()
    {
        // Arrange
        var monthNumber = 4;
        var expected = "Month have 30 days";

        // Act
        var result = ConditionalStatements.GetMonthDays(monthNumber);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void GetMonthDays_WhenInvalidMonth_ReturnsInvalid()
    {
        // Arrange
        var monthNumber = 13;
        var expected = "Invalid Month number";

        // Act
        var result = ConditionalStatements.GetMonthDays(monthNumber);

        // Assert
        result.Should().Be(expected);
    }

    // Exercise 24 - Write a C# Sharp program that calculates the area of geometrical shapes using a menu-driven approach.
    [TestMethod]
    public void CalculateArea_WhenCircle_ReturnsCircleArea()
    {
        // Arrange
        var choice = 1;
        var dimensions = new int[] { 5 };
        var expected = 78.53981633974483;

        // Act
        var result = ConditionalStatements.CalculateArea(choice, dimensions);

        // Assert
        result.Should().BeApproximately(expected, 0.000001);
    }

    [TestMethod]
    public void CalculateArea_WhenRectangle_ReturnsRectangleArea()
    {
        // Arrange
        var choice = 2;
        var dimensions = new int[] { 20, 30 };
        var expected = 600;

        // Act
        var result = ConditionalStatements.CalculateArea(choice, dimensions);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void CalculateArea_WhenTriangle_ReturnsTriangleArea()
    {
        // Arrange
        var choice = 3;
        var dimensions = new int[] { 10, 15 };
        var expected = 75;

        // Act
        var result = ConditionalStatements.CalculateArea(choice, dimensions);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void CalculateArea_WhenInvalidChoice_ReturnsZero()
    {
        // Arrange
        var choice = 4;
        var dimensions = new int[] { 5 };
        var expected = 0;

        // Act
        var result = ConditionalStatements.CalculateArea(choice, dimensions);

        // Assert
        result.Should().Be(expected);
    }

    // Exercise 25 - Write a program in C# Sharp which is a menu-driven program to perform simple calculations.
    [TestMethod]
    public void PerformCalculation_WhenMultiplication_ReturnsMultiplicationResult()
    {
        // Arrange
        var choice = 3;
        var num1 = 10;
        var num2 = 2;
        var expected = "The Multiplication of 10 and 2 is: 20";

        // Act
        var result = ConditionalStatements.PerformCalculation(choice, num1, num2);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void PerformCalculation_WhenDivision_ReturnsDivisionResult()
    {
        // Arrange
        var choice = 4;
        var num1 = 20;
        var num2 = 4;
        var expected = "The Division of 20 and 4 is: 5";

        // Act
        var result = ConditionalStatements.PerformCalculation(choice, num1, num2);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void PerformCalculation_WhenAddition_ReturnsAdditionResult()
    {
        // Arrange
        var choice = 1;
        var num1 = 15;
        var num2 = 25;
        var expected = "The Addition of 15 and 25 is: 40";

        // Act
        var result = ConditionalStatements.PerformCalculation(choice, num1, num2);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void PerformCalculation_WhenSubtraction_ReturnsSubtractionResult()
    {
        // Arrange
        var choice = 2;
        var num1 = 30;
        var num2 = 12;
        var expected = "The Subtraction of 30 and 12 is: 18";

        // Act
        var result = ConditionalStatements.PerformCalculation(choice, num1, num2);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void PerformCalculation_WhenDivisionByZero_ReturnsError()
    {
        // Arrange
        var choice = 4;
        var num1 = 10;
        var num2 = 0;
        var expected = "The second integer is zero. Divide by zero";

        // Act
        var result = ConditionalStatements.PerformCalculation(choice, num1, num2);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void PerformCalculation_WhenInvalidChoice_ReturnsError()
    {
        // Arrange
        var choice = 6;
        var num1 = 10;
        var num2 = 5;
        var expected = "Input correct option";

        // Act
        var result = ConditionalStatements.PerformCalculation(choice, num1, num2);

        // Assert
        result.Should().Be(expected);
    }
}
