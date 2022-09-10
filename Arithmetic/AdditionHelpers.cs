// 3.15 Arithmetic
// Write an app that asks the user to enter two integers, obtains them from the user and displays their sum, product, difference, and quotient.
internal static class AdditionHelpers
{
    // Main method begins execution of C# app
    private static void Main()
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
}