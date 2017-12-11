using System;
using static System.Console;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber;
            try
            {
                Write("Enter a number between 0 and 255: ");
                firstNumber = int.Parse(ReadLine());
                Write("Enter another number between 0 and 255: ");
                secondNumber = int.Parse(ReadLine());

                WriteLine($"{firstNumber} divided by {secondNumber} is {firstNumber / secondNumber}");
            }
            catch (FormatException)
            {
                WriteLine("Input string was not in a correct format.");
            }
            catch (DivideByZeroException)
            {
                WriteLine("It's impossible to divide by a zero.");
            }
        }
    }
}
