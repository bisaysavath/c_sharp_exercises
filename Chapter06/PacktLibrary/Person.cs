using System;
using System.Collections.Generic;
using static System.Console;
using System.Threading;

namespace Packt.CS7
{
    public partial class Person : IComparable<Person>
    {
        // fields
        public string Name;
        public DateTime DateOfBirth;
        public List<Person> Children = new List<Person>();

        // methods
        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on {DateOfBirth:dddd, MMM d yyyy}");
        }

        // methods to "multiply"
        public static Person Procreate(Person p1, Person p2)
        {
            var baby = new Person
            {
                Name = $"Baby of {p1.Name} and {p2.Name}"
            };
            p1.Children.Add(baby);
            p2.Children.Add(baby);
            return baby;
        }

        public Person ProcreateWith(Person partner)
        {
            return Procreate(this, partner);
        }

        // operator to "multiply"
        public static Person operator *(Person p1, Person p2)
        {
            return Person.Procreate(p1, p2);
        }

        // method with a cloal function
        public static int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException($"{nameof(number)} cannot be less than zero.");
            }
            return localFactorial(number);

            int localFactorial(int localNumber)
            {
                if (localNumber < 1) return 1;
                return localNumber * localFactorial(localNumber - 1);
            }
        }

        // event
        public event EventHandler Shout;

        // field
        public int AngerLevel;

        // method
        public void poke()
        {
            AngerLevel++;
            if (AngerLevel >= 3)
            {
                // if something is listening...
                Shout?.Invoke(this, EventArgs.Empty);
            }
        }

        public int CompareTo(Person other)
        {
            return Name.CompareTo(other.Name);
        }

        public override string ToString()
        {
            return $"{Name} is a {base.ToString()}";
        }

        public void TimeTravel(DateTime when)
        {
            if (when <= DateOfBirth)
            {
                throw new PersonException("If you travel back in time to date earlier than your own birth, then the universe will explode!");
            }
            else
            {
                WriteLine($"Welcome to {when:yyyy}!");
            }
        }
    }

    public class PersonComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            // Compare the Name lengths...
            int temp = x.Name.Length.CompareTo(y.Name.Length);

            // ...if they are equal...
            if (temp == 0)
            {
                // ...then sort by the Names...
                return x.Name.CompareTo(y.Name);
            }
            else
            {
                // ...otherwise sort by the lengths
                return temp;
            }
        }
    }

    public class Thing
    {
        public object Data = default(object);
        public string Process(String input)
        {
            if (Data == input)
            {
                return Data.ToString() + Data.ToString();
            }
            else
            {
                return Data.ToString();
            }
        }
    }

    public class GenericThing<T> where T : IComparable, IFormattable
    {
        public T Data = default(T);
        public string Process(string input)
        {
            if (Data.ToString().CompareTo(input) == 0)
            {
                return Data.ToString() + Data.ToString();
            }
            else
            {
                return Data.ToString();
            }
        }
    }

    public static class Squarer
    {
        public static double Square<T>(T input) where T : IConvertible
        {
            double d = input.ToDouble(Thread.CurrentThread.CurrentCulture);
            return d * d;
        }
    }

    public class PersonException : Exception
    {
        public PersonException() : base() { }
        public PersonException(string message) : base(message) { }
        public PersonException(string message, Exception innerException) : base(message, innerException) { }
    }
}
