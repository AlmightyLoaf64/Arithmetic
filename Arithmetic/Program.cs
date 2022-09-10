// 3.15 Arithmetic
// Write an app that asks the user to enter two integers, obtains them from the user and displays their sum, product, difference, and quotient.
using System;
class Addition
{
    // Main method begins execution of C# app
     static void Main()
    {
        int number1; // declare first number to add
        int number2; // declare second number to add
        int sum;//declare sum of number1 and number2

        Console.Write("Enter first integer: "); // prompt user
        // read first number from user
        number1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second integer: "); // prompt user
        // read second number from user
        number2 = int.Parse(Console.ReadLine());

        sum = number1 + number2; // add numbers

        Console.WriteLine($"Sum is {sum}"); // display sum
    } // end Main
} // end class Addition

class Subtraction
{
    // Main method begins execution of C# app
    static void Main()
    {
        int number1; // declare first number to subtract
        int number2; // declare second number to subtract
        int difference; // declare difference of number1 and number2

        Console.Write("Enter first integer: "); // prompt user
        // read first number from user
        number1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second integer: "); // prompt user
        // read second number from user
        number2 = int.Parse(Console.ReadLine());

        difference = number1 - number2; // subtract numbers

        Console.WriteLine($"Difference is {difference}"); // display difference
    } // end Main
} // end class Subtraction

class Multiplication
{
    // Main method begins execution of C# app
    static void Main()
    {
        int number1; // declare first number to multiply
        int number2; // declare second number to multiply
        int product; // declare product of number1 and number2

        Console.Write("Enter first integer: ");// prompt user
            // read first number from user
            number1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second integer: "); // prompt user
        // read second number from user
        number2 = int.Parse(Console.ReadLine());

        product = number1 * number2; // multiply numbers

        Console.WriteLine($"Product is {product}"); // display product
    } // end Main
} // end class Multiplication

class Division
{
    // Main method begins execution of C# app
    static void Main()
    {
        int number1; // declare first number to divide
        int number2; // declare second number to divide
        int quotient; // declare quotient of number1 and number2

        Console.Write("Enter first integer: "); // prompt user
        // read first number from user
        number1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second integer: "); // prompt user
        // read second number from user
        number2 = int.Parse(Console.ReadLine());

        quotient = number1 / number2; // divide numbers

        Console.WriteLine($"Quotient is {quotient}");
    } // end Main
} // end class Division