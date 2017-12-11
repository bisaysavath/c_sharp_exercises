using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //object height = 1.88;
            //object name = "Amir";
            //int length1 = name.Length;
            //int length2 = ((string)name).Length;

            //dynamic anotherName = "Ahmed";
            //int length = anotherName.Length;

            var population = 66000000;
            var weight = 1.88;
            var price = 4.99M;
            var fruit = "Apples";
            var letter = 'Z';
            var happy = true;

            //Console.WriteLine($"{default(int)}");
            //Console.WriteLine($"{default(bool)}");
            //Console.WriteLine($"{default(DateTime)}");

            //int ICannotBeNull = 4;
            //int? ICouldBeNull = null;

            //Console.WriteLine(ICouldBeNull.GetValueOrDefault());
            //ICouldBeNull = 3;
            //Console.WriteLine(ICouldBeNull.GetValueOrDefault());

            //string[] names = new string[4];

            //names[0] = "Kate";
            //names[1] = "Jack";
            //names[2] = "Rebacca";
            //names[3] = "Tom";

            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}

            //Console.WriteLine($"The UK population is {population}.");
            //Console.Write($"The UK population is {population:N0}. ");
            //Console.WriteLine($"{weight}kg of {fruit} costs {price:C}.");

            Console.Write("What is your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Type in your age: ");
            string age = Console.ReadLine();
            Console.WriteLine($"Hello {firstName}, you look good for {age}!");
        }
    }
}
