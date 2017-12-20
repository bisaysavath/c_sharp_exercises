using System;
using static System.Console;
using static System.Convert;

namespace CastingConverting
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 10;
            //double b = a;
            //WriteLine(b);

            //double c = 9.8;
            //int d = (int)c;
            //WriteLine(d);

            //long e = 10;
            //int f = (int)e;
            //WriteLine($"e is {e} and f is {f}");
            //e = long.MaxValue;
            //f = (int)e;
            //WriteLine($"e is {e} and f is {f}");

            //double g = 9.8;
            //int h = ToInt32(g);
            //WriteLine($"g is {g} and h is {h}");

            //double i = 9.49;
            //double j = 9.5;
            //double k = 10.49;
            //double l = 10.5;
            //WriteLine($"i is {i}, ToInt(i) is {ToInt32(i)}");
            //WriteLine($"j is {j}, ToInt(j) is {ToInt32(j)}");
            //WriteLine($"k is {k}, ToInt(k) is {ToInt32(k)}");
            //WriteLine($"l is {l}, ToInt(l) is {ToInt32(l)}");

            //int number = 12;
            //WriteLine(number.ToString());
            //bool boolean = true;
            //WriteLine(boolean.ToString());
            //DateTime now = DateTime.Now;
            //WriteLine(now.ToString());
            //object me = new object();
            //WriteLine(me.ToString());

            //byte[] binaryObject = new byte[128];

            //(new Random()).NextBytes(binaryObject);

            //WriteLine("Binary Object as bytes:");
            //for (int index = 0; index < binaryObject.Length; index++)
            //{
            //    Write($"{binaryObject[index]:X} ");
            //}
            //WriteLine();

            //string encoded = Convert.ToBase64String(binaryObject);
            //WriteLine($"Binary Object as Base 64: {encoded}");

            //byte[] decoded = Convert.FromBase64String(encoded);

            //WriteLine("Binary Object from Base 64: ");
            //for (int index = 0; index < decoded.Length; index++)
            //{
            //    Write($"{decoded[index]:X} ");
            //}
            //WriteLine();

            //int age = int.Parse("27");
            //DateTime birthday = DateTime.Parse("4 July 1980");
            //WriteLine($"I was born {age} years ago.");
            //WriteLine($"My birthday is {birthday}.");
            //WriteLine($"My birthday is {birthday:D}.");

            Write("How many eggs are there? ");
            int count;
            string input = ReadLine();
            
            try
            {
                count = Convert.ToInt16(input);
                WriteLine($"Count is {count}");
            }
            catch
            {
                WriteLine("Cannot convert");
            }

            //if (int.TryParse(input, out count))
            //{
            //    WriteLine($"There are {count} eggs.");
            //}
            //else
            //{
            //    WriteLine("I could not parse the input.");
            //}
        }
    }
}
