/* Exercise #1
 
- Write a program that enters the diameter of the circle from the keyboard and prints the circumference of the circle.
- Write a program that inputs time and distance from the keyboard and print the speed in meters per hour and kilometers per hour.
 */

// Solution Exercise #1 - Part #1
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Security.Cryptography;

Console.Write("Enter the diameter = ");
double diameter = Convert.ToDouble(Console.ReadLine());

double circumference = Math.PI * diameter;
Console.WriteLine("The circumference of the circle = " + circumference);

Console.WriteLine("\n");
// Solution Exercise #1 - Part #2
Console.Write("Enter the distance (In Meters) = ");
double distance = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the time (In Hours) = ");
double time = Convert.ToDouble(Console.ReadLine());

double speedInMetersPerHour = distance / time;
Console.WriteLine("The Speed in meters per hour = " + speedInMetersPerHour + " m/h");

double speedInKilometersPerHour = speedInMetersPerHour / 1000;
Console.WriteLine($"The Speed in kilometers per hour = { speedInKilometersPerHour} km/h");

/* Exercise #2

 - What are the differences between Post Increment and Pre-Increment operators?

Slo:
    - Pre-Increment (++i):  The value of the variable is incremented first, and then the incremented value is used in the expression.
    - Post-Increment (i++): The current value of the variable is used in the expression first, and then the variable is incremented afterward.    
*/


/* Exercise #3

- Use Math.Round to round a double number to the nearest integer
- Use Math.Pow to calculate the result of baseNumberraised to the power of exponent
 */

Console.WriteLine();
// Solution Exercise #3 - Part 1
Console.Write("Enter the number you want to round it: ");
double roundNumber = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"The number after rounded = {Math.Round(roundNumber)} ");

Console.WriteLine();
// Solution Exercise #3 - Part 2
Console.Write("Enter the base number: ");
double baseNumber = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the exponent: ");
double exponent = Convert.ToDouble(Console.ReadLine());

double result = Math.Pow(baseNumber, exponent);
Console.WriteLine($"{baseNumber} raised to the power of {exponent} = {result}");

/* Exercise #4

- Write a program to check whether a year is a leap or not.
- Write program to Check whether an alphabet is lowercase or uppercase.
*/

Console.WriteLine();
// Solution Exercise #4 - Part 1
Console.Write("Enter a year: ");
int year = Convert.ToInt32(Console.ReadLine());

bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
Console.WriteLine(isLeapYear? $"{year} is a leap year.": $"{year} is not a leap year.");

Console.WriteLine();
// Solution Exercise #4 - Part 2
Console.Write("Enter an alphabet: ");
char alphabet = Convert.ToChar(Console.Read());

if (char.IsLetter(alphabet))
{
    if (char.IsUpper(alphabet))
        Console.WriteLine($"{alphabet} is an uppercase letter.");
    
    else if (char.IsLower(alphabet))
        Console.WriteLine($"{alphabet} is a lowercase letter.");
}
else
    Console.WriteLine($"{alphabet} is not a valid alphabet.");


/* Exercise #5

- Write a program to create a simple calculator (+, -, *, /) using switch statement.
- Write a program to take 3 numbers from the keyboard and find the maximum number using ternary operator.
- Write a program to takes a number from the keyboard and check if  the number is odd or even using Ternary operator.
 */

Console.WriteLine();
// Solution Exercise #5 - Part 1
Console.Write("Enter the first number: ");
double numberOne = Convert.ToDouble(Console.ReadLine());


Console.Write("Enter the operator (+, -, *, /): ");
char op = Convert.ToChar(Console.Read()); 

Console.Write("Enter the second number: ");
double numberTwo = Convert.ToDouble(Console.ReadLine());

double resultCalc = 0;

switch (op)
{
    case '+':
        resultCalc = numberOne + numberTwo;
        break;
    case '-':
        resultCalc = numberOne - numberTwo;
        break;
    case '*':
        resultCalc = numberOne * numberTwo;
        break;
    case '/':
        if (numberTwo != 0)
            resultCalc = numberOne / numberTwo;
        else
        {
            Console.WriteLine("Cannot divide by zero.");
            return; 
        }
        break;
    default:
        Console.WriteLine("Invalid operator.");
        return; 
}

Console.WriteLine($"Result =  {resultCalc}");


Console.WriteLine();
// Solution Exercise #5 - Part 2
Console.Write("Enter the first number: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the second number: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the third number: ");
double c = Convert.ToDouble(Console.ReadLine());


double max = (a > b) ? ((a > c) ? a : c) : ((b > c) ? b : c);
Console.WriteLine("The maximum number = " + max);


Console.WriteLine();
// Solution Exercise #5 - Part 3
Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());


string resultOddEven = (number % 2 == 0) ? "Even" : "Odd";
Console.WriteLine($"The number is: {resultOddEven}");