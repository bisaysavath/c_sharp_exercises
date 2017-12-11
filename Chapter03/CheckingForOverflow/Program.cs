using System;
using static System.Console;

namespace CheckingForOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            //checked
            //{
            //    try
            //    {
            //        int x = int.MaxValue - 1;
            //        WriteLine(x);
            //        x++;
            //        WriteLine(x);
            //        x++;
            //        WriteLine(x);
            //        x++;
            //        WriteLine(x);
            //    }
            //    catch (OverflowException)
            //    {
            //        WriteLine("The code overflowed, but I caught the exception.");
            //    }
            //}

            //unchecked
            //{
            //    try
            //    {
            //        int y = int.MaxValue + 1;
            //        WriteLine(y);
            //        y++;
            //        WriteLine(y);
            //        y++;
            //        WriteLine(y);
            //    }
            //    catch (OverflowException)
            //    {
            //        WriteLine("The code overflowed, but I caught the exception.");
            //    }
            //}

            checked
            {
                try
                {
                    int max = 500;
                    for (byte i = 0; i < max; i++)
                    {
                        WriteLine(i);
                    }
                }
                catch(OverflowException)
                {
                    WriteLine("We got into an infinite loop.");
                }
            }
        }
    }
}
