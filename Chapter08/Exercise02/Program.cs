using System.Text.RegularExpressions;
using System;
using static System.Console;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("The default regular expression checks for at least one digit.");
            ConsoleKeyInfo info;

            do
            {
                Write("Enter a regular expression (or press ENTER to use the default): ");
                string regInput = ReadLine();
                Write("Enter some input: ");
                string input = ReadLine();
                var regChecker = new Regex(@regInput);
                WriteLine($"{input} mathces {regInput}? {regChecker.IsMatch(input)}");
                WriteLine("Press ESC to end or any key to try again.");
                info = ReadKey();
            } while (info.Key != ConsoleKey.Escape);
        }
    }
}
