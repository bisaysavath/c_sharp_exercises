using static System.Console;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int count = 1; count <= 100; count++)
            {
                if (count % 5 == 0 && count % 3 == 0)
                {
                    Write("FizzBuzz");
                }
                else if (count % 3 == 0)
                {
                    Write("Fizz");
                }
                else if (count % 5 == 0)
                {
                    Write("Buzz");
                }
                else
                {
                    Write(count);
                }

                if (count != 100)
                {
                    Write(", ");
                }
                else
                {
                    WriteLine();
                }
            }
        }
    }
}
